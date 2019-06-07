﻿namespace ChapeauUI
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.txt_Tip = new System.Windows.Forms.TextBox();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.lbl_Feedbak = new System.Windows.Forms.Label();
            this.lst_Payment = new System.Windows.Forms.ListView();
            this.lbl_serverName = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.lbl_TblNr = new System.Windows.Forms.Label();
            this.rtxt_FeedBack = new System.Windows.Forms.RichTextBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_TotalVAT = new System.Windows.Forms.Label();
            this.radBtn_visa = new System.Windows.Forms.RadioButton();
            this.radBtn_PIN = new System.Windows.Forms.RadioButton();
            this.radBtn_Cash = new System.Windows.Forms.RadioButton();
            this.txt_TVAT = new System.Windows.Forms.TextBox();
            this.picBox_Cash = new System.Windows.Forms.PictureBox();
            this.picBox_PIN = new System.Windows.Forms.PictureBox();
            this.picBox_Visa = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Cash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Visa)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(897, 15);
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Location = new System.Drawing.Point(733, 246);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(100, 30);
            this.txt_TotalAmount.TabIndex = 0;
            // 
            // txt_Tip
            // 
            this.txt_Tip.Location = new System.Drawing.Point(733, 190);
            this.txt_Tip.Name = "txt_Tip";
            this.txt_Tip.Size = new System.Drawing.Size(100, 30);
            this.txt_Tip.TabIndex = 1;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Location = new System.Drawing.Point(585, 246);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(123, 23);
            this.lbl_totalAmount.TabIndex = 3;
            this.lbl_totalAmount.Text = "Total Amount";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Location = new System.Drawing.Point(588, 190);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(36, 23);
            this.lbl_Tip.TabIndex = 4;
            this.lbl_Tip.Text = "Tip";
            // 
            // lbl_Feedbak
            // 
            this.lbl_Feedbak.AutoSize = true;
            this.lbl_Feedbak.Location = new System.Drawing.Point(25, 359);
            this.lbl_Feedbak.Name = "lbl_Feedbak";
            this.lbl_Feedbak.Size = new System.Drawing.Size(97, 23);
            this.lbl_Feedbak.TabIndex = 5;
            this.lbl_Feedbak.Text = "Feedback";
            // 
            // lst_Payment
            // 
            this.lst_Payment.Location = new System.Drawing.Point(29, 73);
            this.lst_Payment.Name = "lst_Payment";
            this.lst_Payment.Size = new System.Drawing.Size(461, 249);
            this.lst_Payment.TabIndex = 6;
            this.lst_Payment.UseCompatibleStateImageBehavior = false;
            this.lst_Payment.SelectedIndexChanged += new System.EventHandler(this.listView_Payment_SelectedIndexChanged);
            // 
            // lbl_serverName
            // 
            this.lbl_serverName.AutoSize = true;
            this.lbl_serverName.Location = new System.Drawing.Point(585, 83);
            this.lbl_serverName.Name = "lbl_serverName";
            this.lbl_serverName.Size = new System.Drawing.Size(125, 23);
            this.lbl_serverName.TabIndex = 7;
            this.lbl_serverName.Text = "Server Name";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(733, 83);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(100, 30);
            this.txt_ServerName.TabIndex = 8;
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Location = new System.Drawing.Point(585, 398);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(87, 23);
            this.lbl_Payment.TabIndex = 10;
            this.lbl_Payment.Text = "Payment";
            // 
            // lbl_TblNr
            // 
            this.lbl_TblNr.AutoSize = true;
            this.lbl_TblNr.Location = new System.Drawing.Point(25, 35);
            this.lbl_TblNr.Name = "lbl_TblNr";
            this.lbl_TblNr.Size = new System.Drawing.Size(137, 23);
            this.lbl_TblNr.TabIndex = 13;
            this.lbl_TblNr.Text = "Table Number:";
            // 
            // rtxt_FeedBack
            // 
            this.rtxt_FeedBack.BackColor = System.Drawing.SystemColors.Window;
            this.rtxt_FeedBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_FeedBack.Location = new System.Drawing.Point(26, 385);
            this.rtxt_FeedBack.Name = "rtxt_FeedBack";
            this.rtxt_FeedBack.Size = new System.Drawing.Size(464, 252);
            this.rtxt_FeedBack.TabIndex = 15;
            this.rtxt_FeedBack.Text = "";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(697, 671);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(162, 38);
            this.btn_Pay.TabIndex = 16;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_TotalVAT
            // 
            this.lbl_TotalVAT.AutoSize = true;
            this.lbl_TotalVAT.Location = new System.Drawing.Point(585, 131);
            this.lbl_TotalVAT.Name = "lbl_TotalVAT";
            this.lbl_TotalVAT.Size = new System.Drawing.Size(94, 23);
            this.lbl_TotalVAT.TabIndex = 19;
            this.lbl_TotalVAT.Text = "Total VAT";
            // 
            // radBtn_visa
            // 
            this.radBtn_visa.AutoSize = true;
            this.radBtn_visa.Location = new System.Drawing.Point(589, 457);
            this.radBtn_visa.Name = "radBtn_visa";
            this.radBtn_visa.Size = new System.Drawing.Size(124, 27);
            this.radBtn_visa.TabIndex = 20;
            this.radBtn_visa.Text = "Visa/Amex";
            this.radBtn_visa.UseVisualStyleBackColor = true;
            // 
            // radBtn_PIN
            // 
            this.radBtn_PIN.AutoSize = true;
            this.radBtn_PIN.Location = new System.Drawing.Point(587, 518);
            this.radBtn_PIN.Name = "radBtn_PIN";
            this.radBtn_PIN.Size = new System.Drawing.Size(63, 27);
            this.radBtn_PIN.TabIndex = 21;
            this.radBtn_PIN.Text = "PIN";
            this.radBtn_PIN.UseVisualStyleBackColor = true;
            // 
            // radBtn_Cash
            // 
            this.radBtn_Cash.AutoSize = true;
            this.radBtn_Cash.Location = new System.Drawing.Point(587, 580);
            this.radBtn_Cash.Name = "radBtn_Cash";
            this.radBtn_Cash.Size = new System.Drawing.Size(76, 27);
            this.radBtn_Cash.TabIndex = 22;
            this.radBtn_Cash.Text = "Cash";
            this.radBtn_Cash.UseVisualStyleBackColor = true;
            // 
            // txt_TVAT
            // 
            this.txt_TVAT.Location = new System.Drawing.Point(733, 131);
            this.txt_TVAT.Name = "txt_TVAT";
            this.txt_TVAT.Size = new System.Drawing.Size(100, 30);
            this.txt_TVAT.TabIndex = 25;
            // 
            // picBox_Cash
            // 
            this.picBox_Cash.BackgroundImage = global::ChapeauUI.Properties.Resources.CashLogo;
            this.picBox_Cash.Location = new System.Drawing.Point(730, 580);
            this.picBox_Cash.Name = "picBox_Cash";
            this.picBox_Cash.Size = new System.Drawing.Size(78, 50);
            this.picBox_Cash.TabIndex = 28;
            this.picBox_Cash.TabStop = false;
            // 
            // picBox_PIN
            // 
            this.picBox_PIN.BackgroundImage = global::ChapeauUI.Properties.Resources.PinLogo;
            this.picBox_PIN.Location = new System.Drawing.Point(730, 518);
            this.picBox_PIN.Name = "picBox_PIN";
            this.picBox_PIN.Size = new System.Drawing.Size(75, 45);
            this.picBox_PIN.TabIndex = 27;
            this.picBox_PIN.TabStop = false;
            // 
            // picBox_Visa
            // 
            this.picBox_Visa.BackgroundImage = global::ChapeauUI.Properties.Resources.VisaLogo1;
            this.picBox_Visa.Location = new System.Drawing.Point(733, 445);
            this.picBox_Visa.Name = "picBox_Visa";
            this.picBox_Visa.Size = new System.Drawing.Size(75, 48);
            this.picBox_Visa.TabIndex = 26;
            this.picBox_Visa.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(26, 671);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 38);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.picBox_Cash);
            this.Controls.Add(this.picBox_PIN);
            this.Controls.Add(this.picBox_Visa);
            this.Controls.Add(this.txt_TVAT);
            this.Controls.Add(this.radBtn_Cash);
            this.Controls.Add(this.radBtn_PIN);
            this.Controls.Add(this.radBtn_visa);
            this.Controls.Add(this.lbl_TotalVAT);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.rtxt_FeedBack);
            this.Controls.Add(this.lbl_TblNr);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.lbl_serverName);
            this.Controls.Add(this.lst_Payment);
            this.Controls.Add(this.lbl_Feedbak);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.txt_Tip);
            this.Controls.Add(this.txt_TotalAmount);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.Controls.SetChildIndex(this.txt_TotalAmount, 0);
            this.Controls.SetChildIndex(this.txt_Tip, 0);
            this.Controls.SetChildIndex(this.lbl_totalAmount, 0);
            this.Controls.SetChildIndex(this.lbl_Tip, 0);
            this.Controls.SetChildIndex(this.lbl_Feedbak, 0);
            this.Controls.SetChildIndex(this.lst_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_serverName, 0);
            this.Controls.SetChildIndex(this.txt_ServerName, 0);
            this.Controls.SetChildIndex(this.lbl_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_TblNr, 0);
            this.Controls.SetChildIndex(this.rtxt_FeedBack, 0);
            this.Controls.SetChildIndex(this.btn_Pay, 0);
            this.Controls.SetChildIndex(this.lbl_TotalVAT, 0);
            this.Controls.SetChildIndex(this.radBtn_visa, 0);
            this.Controls.SetChildIndex(this.radBtn_PIN, 0);
            this.Controls.SetChildIndex(this.radBtn_Cash, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.txt_TVAT, 0);
            this.Controls.SetChildIndex(this.picBox_Visa, 0);
            this.Controls.SetChildIndex(this.picBox_PIN, 0);
            this.Controls.SetChildIndex(this.picBox_Cash, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Cash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Visa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.TextBox txt_Tip;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Label lbl_Feedbak;
        private System.Windows.Forms.ListView lst_Payment;
        private System.Windows.Forms.Label lbl_serverName;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Label lbl_TblNr;
        private System.Windows.Forms.RichTextBox rtxt_FeedBack;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_TotalVAT;
        private System.Windows.Forms.RadioButton radBtn_visa;
        private System.Windows.Forms.RadioButton radBtn_PIN;
        private System.Windows.Forms.RadioButton radBtn_Cash;
        private System.Windows.Forms.TextBox txt_TVAT;
        private System.Windows.Forms.PictureBox picBox_Visa;
        private System.Windows.Forms.PictureBox picBox_PIN;
        private System.Windows.Forms.PictureBox picBox_Cash;
        private System.Windows.Forms.Button btn_Cancel;
    }
}