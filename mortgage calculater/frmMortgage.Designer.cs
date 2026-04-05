namespace mortgage_calculater
{
    partial class frmMortgage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnswitch = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtGrace = new System.Windows.Forms.TextBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtAnnual = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblGrace = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnzero = new System.Windows.Forms.Button();
            this.lblTotalpay_Result = new System.Windows.Forms.Label();
            this.lblTotalinterestexpense_Result = new System.Windows.Forms.Label();
            this.lblFirstInstallmentPrincipal_Result = new System.Windows.Forms.Label();
            this.lblFirstInstallment_Result = new System.Windows.Forms.Label();
            this.lblMonthlyAmountDue_Result = new System.Windows.Forms.Label();
            this.lblTotalLoan_Result = new System.Windows.Forms.Label();
            this.lblTotalpay = new System.Windows.Forms.Label();
            this.lblTotalinterestexpense = new System.Windows.Forms.Label();
            this.lblFirstInstallmentPrincipal = new System.Windows.Forms.Label();
            this.lblFirstInstallment = new System.Windows.Forms.Label();
            this.lblMonthlyAmountDue = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnswitch);
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.txtGrace);
            this.grpInput.Controls.Add(this.txtLoan);
            this.grpInput.Controls.Add(this.txtAnnual);
            this.grpInput.Controls.Add(this.txtDown);
            this.grpInput.Controls.Add(this.txtTotal);
            this.grpInput.Controls.Add(this.lblGrace);
            this.grpInput.Controls.Add(this.lblLoan);
            this.grpInput.Controls.Add(this.lblAnnual);
            this.grpInput.Controls.Add(this.lblDown);
            this.grpInput.Controls.Add(this.lblTotal);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(290, 347);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnswitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnswitch.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnswitch.Location = new System.Drawing.Point(245, 79);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(39, 23);
            this.btnswitch.TabIndex = 11;
            this.btnswitch.Text = "切換";
            this.btnswitch.UseVisualStyleBackColor = false;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Azure;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.Location = new System.Drawing.Point(61, 291);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(166, 34);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtGrace
            // 
            this.txtGrace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGrace.Location = new System.Drawing.Point(139, 210);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(100, 29);
            this.txtGrace.TabIndex = 9;
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(139, 165);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 29);
            this.txtLoan.TabIndex = 8;
            // 
            // txtAnnual
            // 
            this.txtAnnual.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnnual.Location = new System.Drawing.Point(139, 120);
            this.txtAnnual.Name = "txtAnnual";
            this.txtAnnual.Size = new System.Drawing.Size(100, 29);
            this.txtAnnual.TabIndex = 7;
            // 
            // txtDown
            // 
            this.txtDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDown.Location = new System.Drawing.Point(139, 75);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(100, 29);
            this.txtDown.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(139, 30);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 5;
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGrace.Location = new System.Drawing.Point(8, 214);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(87, 20);
            this.lblGrace.TabIndex = 4;
            this.lblGrace.Text = "寬限期 (年)";
            //this.lblGrace.Click += new System.EventHandler(this.lblGrace_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoan.Location = new System.Drawing.Point(8, 170);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(103, 20);
            this.lblLoan.TabIndex = 3;
            this.lblLoan.Text = "貸款年限 (年)";
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnnual.Location = new System.Drawing.Point(8, 124);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(101, 20);
            this.lblAnnual.TabIndex = 2;
            this.lblAnnual.Text = "貸款利率 (%)";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDown.Location = new System.Drawing.Point(8, 78);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(119, 20);
            this.lblDown.TabIndex = 1;
            this.lblDown.Text = "自備款金額 (元)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(8, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "房屋總價 (元)";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnzero);
            this.grpOutput.Controls.Add(this.lblTotalpay_Result);
            this.grpOutput.Controls.Add(this.lblTotalinterestexpense_Result);
            this.grpOutput.Controls.Add(this.lblFirstInstallmentPrincipal_Result);
            this.grpOutput.Controls.Add(this.lblFirstInstallment_Result);
            this.grpOutput.Controls.Add(this.lblMonthlyAmountDue_Result);
            this.grpOutput.Controls.Add(this.lblTotalLoan_Result);
            this.grpOutput.Controls.Add(this.lblTotalpay);
            this.grpOutput.Controls.Add(this.lblTotalinterestexpense);
            this.grpOutput.Controls.Add(this.lblFirstInstallmentPrincipal);
            this.grpOutput.Controls.Add(this.lblFirstInstallment);
            this.grpOutput.Controls.Add(this.lblMonthlyAmountDue);
            this.grpOutput.Controls.Add(this.lblTotalLoan);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(308, 12);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(306, 347);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Azure;
            this.btnzero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzero.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnzero.Location = new System.Drawing.Point(77, 291);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(166, 34);
            this.btnzero.TabIndex = 11;
            this.btnzero.Text = "歸零";
            this.btnzero.UseVisualStyleBackColor = false;
            // 
            // lblTotalpay_Result
            // 
            this.lblTotalpay_Result.BackColor = System.Drawing.Color.MistyRose;
            this.lblTotalpay_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalpay_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalpay_Result.Location = new System.Drawing.Point(141, 247);
            this.lblTotalpay_Result.Name = "lblTotalpay_Result";
            this.lblTotalpay_Result.Size = new System.Drawing.Size(144, 29);
            this.lblTotalpay_Result.TabIndex = 12;
            this.lblTotalpay_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalinterestexpense_Result
            // 
            this.lblTotalinterestexpense_Result.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalinterestexpense_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalinterestexpense_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalinterestexpense_Result.Location = new System.Drawing.Point(141, 203);
            this.lblTotalinterestexpense_Result.Name = "lblTotalinterestexpense_Result";
            this.lblTotalinterestexpense_Result.Size = new System.Drawing.Size(144, 29);
            this.lblTotalinterestexpense_Result.TabIndex = 11;
            this.lblTotalinterestexpense_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstInstallmentPrincipal_Result
            // 
            this.lblFirstInstallmentPrincipal_Result.BackColor = System.Drawing.Color.MintCream;
            this.lblFirstInstallmentPrincipal_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstInstallmentPrincipal_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInstallmentPrincipal_Result.Location = new System.Drawing.Point(141, 159);
            this.lblFirstInstallmentPrincipal_Result.Name = "lblFirstInstallmentPrincipal_Result";
            this.lblFirstInstallmentPrincipal_Result.Size = new System.Drawing.Size(144, 29);
            this.lblFirstInstallmentPrincipal_Result.TabIndex = 10;
            this.lblFirstInstallmentPrincipal_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstInstallment_Result
            // 
            this.lblFirstInstallment_Result.BackColor = System.Drawing.Color.Azure;
            this.lblFirstInstallment_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstInstallment_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInstallment_Result.Location = new System.Drawing.Point(141, 115);
            this.lblFirstInstallment_Result.Name = "lblFirstInstallment_Result";
            this.lblFirstInstallment_Result.Size = new System.Drawing.Size(144, 29);
            this.lblFirstInstallment_Result.TabIndex = 9;
            this.lblFirstInstallment_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyAmountDue_Result
            // 
            this.lblMonthlyAmountDue_Result.BackColor = System.Drawing.Color.AliceBlue;
            this.lblMonthlyAmountDue_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyAmountDue_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyAmountDue_Result.Location = new System.Drawing.Point(141, 71);
            this.lblMonthlyAmountDue_Result.Name = "lblMonthlyAmountDue_Result";
            this.lblMonthlyAmountDue_Result.Size = new System.Drawing.Size(144, 29);
            this.lblMonthlyAmountDue_Result.TabIndex = 8;
            this.lblMonthlyAmountDue_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalLoan_Result
            // 
            this.lblTotalLoan_Result.BackColor = System.Drawing.Color.Lavender;
            this.lblTotalLoan_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalLoan_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalLoan_Result.Location = new System.Drawing.Point(141, 27);
            this.lblTotalLoan_Result.Name = "lblTotalLoan_Result";
            this.lblTotalLoan_Result.Size = new System.Drawing.Size(144, 29);
            this.lblTotalLoan_Result.TabIndex = 7;
            this.lblTotalLoan_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalpay
            // 
            this.lblTotalpay.AutoSize = true;
            this.lblTotalpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalpay.Location = new System.Drawing.Point(19, 251);
            this.lblTotalpay.Name = "lblTotalpay";
            this.lblTotalpay.Size = new System.Drawing.Size(89, 20);
            this.lblTotalpay.TabIndex = 6;
            this.lblTotalpay.Text = "總還款金額";
            // 
            // lblTotalinterestexpense
            // 
            this.lblTotalinterestexpense.AutoSize = true;
            this.lblTotalinterestexpense.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalinterestexpense.Location = new System.Drawing.Point(19, 207);
            this.lblTotalinterestexpense.Name = "lblTotalinterestexpense";
            this.lblTotalinterestexpense.Size = new System.Drawing.Size(89, 20);
            this.lblTotalinterestexpense.TabIndex = 5;
            this.lblTotalinterestexpense.Text = "總利息支出";
            // 
            // lblFirstInstallmentPrincipal
            // 
            this.lblFirstInstallmentPrincipal.AutoSize = true;
            this.lblFirstInstallmentPrincipal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInstallmentPrincipal.Location = new System.Drawing.Point(19, 163);
            this.lblFirstInstallmentPrincipal.Name = "lblFirstInstallmentPrincipal";
            this.lblFirstInstallmentPrincipal.Size = new System.Drawing.Size(73, 20);
            this.lblFirstInstallmentPrincipal.TabIndex = 4;
            this.lblFirstInstallmentPrincipal.Text = "首期本金";
            // 
            // lblFirstInstallment
            // 
            this.lblFirstInstallment.AutoSize = true;
            this.lblFirstInstallment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInstallment.Location = new System.Drawing.Point(19, 120);
            this.lblFirstInstallment.Name = "lblFirstInstallment";
            this.lblFirstInstallment.Size = new System.Drawing.Size(73, 20);
            this.lblFirstInstallment.TabIndex = 3;
            this.lblFirstInstallment.Text = "首期利息";
            // 
            // lblMonthlyAmountDue
            // 
            this.lblMonthlyAmountDue.AutoSize = true;
            this.lblMonthlyAmountDue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyAmountDue.Location = new System.Drawing.Point(19, 76);
            this.lblMonthlyAmountDue.Name = "lblMonthlyAmountDue";
            this.lblMonthlyAmountDue.Size = new System.Drawing.Size(105, 20);
            this.lblMonthlyAmountDue.TabIndex = 2;
            this.lblMonthlyAmountDue.Text = "每月應繳金額";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalLoan.Location = new System.Drawing.Point(19, 31);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(89, 20);
            this.lblTotalLoan.TabIndex = 1;
            this.lblTotalLoan.Text = "貸款總金額";
            // 
            // frmMortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(626, 371);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmMortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房貸計算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtGrace;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtAnnual;
        private System.Windows.Forms.Label lblTotalpay_Result;
        private System.Windows.Forms.Label lblTotalinterestexpense_Result;
        private System.Windows.Forms.Label lblFirstInstallmentPrincipal_Result;
        private System.Windows.Forms.Label lblFirstInstallment_Result;
        private System.Windows.Forms.Label lblMonthlyAmountDue_Result;
        private System.Windows.Forms.Label lblTotalLoan_Result;
        private System.Windows.Forms.Label lblTotalpay;
        private System.Windows.Forms.Label lblTotalinterestexpense;
        private System.Windows.Forms.Label lblFirstInstallmentPrincipal;
        private System.Windows.Forms.Label lblFirstInstallment;
        private System.Windows.Forms.Label lblMonthlyAmountDue;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Label lblDown;
    }
}

