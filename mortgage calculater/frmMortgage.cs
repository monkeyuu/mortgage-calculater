using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mortgage_calculater
{
    public partial class frmMortgage : Form
    {
        bool isAmountMode = false;
        public frmMortgage()
        {
            InitializeComponent();
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            // 切換布林值狀態
            isAmountMode = !isAmountMode;

            if (isAmountMode)
            {
                // 切換為金額模式 
                lblDown.Text = "自備款金額 (元)";
            }
            else
            {
                // 切換回比例模式 
                lblDown.Text = "自備款比例 (%)";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // --- 1. 必填欄位有無填寫的初步檢查 ---
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("請填寫房屋總價", "輸入警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDown.Text))
            {
                MessageBox.Show("請填寫自備款", "輸入警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDown.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAnnual.Text))
            {
                MessageBox.Show("請填寫貸款利率", "輸入警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnnual.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLoan.Text))
            {
                MessageBox.Show("請填寫貸款年限", "輸入警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoan.Focus();
                return;
            }

            try
            {
                // --- 2. 資料解析 (將文字轉為數字) ---
                // 增加解析失敗時的 Warning 圖示提示
                if (!double.TryParse(txtTotal.Text, out double totalHousePrice))
                {
                    MessageBox.Show("房屋總價格式錯誤", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtDown.Text, out double downPaymentInput))
                {
                    MessageBox.Show("自備款格式錯誤", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtAnnual.Text, out double annualInterestRate))
                {
                    MessageBox.Show("貸款利率格式錯誤", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtLoan.Text, out double loanYears))
                {
                    MessageBox.Show("貸款年限格式錯誤", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 寬限期為選填
                double graceYears = string.IsNullOrWhiteSpace(txtGrace.Text) ? 0 : double.Parse(txtGrace.Text);

                // --- 3. 邏輯驗證 (防呆) [cite: 34] ---

                // 新增：房價不能小於或等於 0 的檢查
                if (totalHousePrice <= 0)
                {
                    MessageBox.Show("房屋總價必須大於 0", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 檢查自備款是否超過房價（金額模式）
                if (isAmountMode && downPaymentInput >= totalHousePrice)
                {
                    MessageBox.Show("自備款金額不能大於或等於房屋總價", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 新增：寬限期不能大於或等於貸款年限的檢查
                if (graceYears >= loanYears && loanYears > 0)
                {
                    MessageBox.Show("寬限期不能大於或等於貸款年限", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 檢查比例模式 [cite: 13]
                if (!isAmountMode && downPaymentInput >= 100)
                {
                    MessageBox.Show("自備款比例不能大於或等於 100%", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (loanYears <= 0)
                {
                    MessageBox.Show("貸款年限必須大於 0 年", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (annualInterestRate <= 0 || annualInterestRate > 100)
                {
                    MessageBox.Show("請輸入合理的貸款利率 (0.1% ~ 100%)", "數值警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 4. 基礎參數計算 ---
                double loanPrincipal = 0;

                // 根據模式計算貸款本金 [cite: 13]
                if (isAmountMode)
                {
                    loanPrincipal = totalHousePrice - downPaymentInput;
                }
                else
                {
                    loanPrincipal = totalHousePrice * (1 - (downPaymentInput / 100));
                }

                // 轉換為月計單位 [cite: 32]
                double monthlyRate = annualInterestRate / 12 / 100;
                int totalMonths = (int)(loanYears * 12);
                int graceMonths = (int)(graceYears * 12);
                int repaymentMonths = totalMonths - graceMonths;

                // --- 5. 核心房貸公式 (本息平均攤還法) ---
                double monthlyPayment = 0;

                // 防呆：避免除以零（當寬限期等於貸款年限時）
                if (repaymentMonths <= 0)
                {
                    monthlyPayment = loanPrincipal * monthlyRate;
                }
                else
                {
                    // 本息平均攤還公式 [cite: 32]
                    double numerator = Math.Pow(1 + monthlyRate, repaymentMonths) * monthlyRate;
                    double denominator = Math.Pow(1 + monthlyRate, repaymentMonths) - 1;
                    monthlyPayment = loanPrincipal * (numerator / denominator);
                }

                // --- 6. 計算首期資訊與總額 ---
                double firstInterest = loanPrincipal * monthlyRate;
                double firstPrincipal = (graceMonths > 0) ? 0 : (monthlyPayment - firstInterest);

                // 總還款金額計算
                double totalPayment = (graceMonths * firstInterest) + (repaymentMonths * monthlyPayment);

                // 如果全期寬限，到期需歸還本金
                if (repaymentMonths <= 0)
                {
                    totalPayment += loanPrincipal;
                }
                double totalInterestExpense = totalPayment - loanPrincipal;

                // --- 7. 顯示結果 (格式化輸出) [cite: 18, 19] ---
                lblTotalLoan_Result.Text = loanPrincipal.ToString("N2");
                lblMonthlyAmountDue_Result.Text = monthlyPayment.ToString("N2");
                lblFirstInstallment_Result.Text = firstInterest.ToString("N2");
                lblFirstInstallmentPrincipal_Result.Text = firstPrincipal.ToString("N2");
                lblTotalinterestexpense_Result.Text = totalInterestExpense.ToString("N2");
                lblTotalpay_Result.Text = totalPayment.ToString("N2");
            }
            catch (Exception ex)
            {
                // 系統性錯誤使用 Error 圖示區分
                MessageBox.Show("運算發生錯誤：" + ex.Message, "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            txtDown.Text = "";
            txtAnnual.Text = "";
            txtLoan.Text = "";
            txtGrace.Text = "";


            lblTotalLoan_Result.Text = "";
            lblMonthlyAmountDue_Result.Text = "";
            lblFirstInstallment_Result.Text = "";
            lblFirstInstallmentPrincipal_Result.Text = "";
            lblTotalinterestexpense_Result.Text = "";
            lblTotalpay_Result.Text = "";

        }

        private void lblTotalLoan_Result_Click(object sender, EventArgs e)
        {

        }

        private void frmMortgage_Load(object sender, EventArgs e)
        {

        }
    }
}
