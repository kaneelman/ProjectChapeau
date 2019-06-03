namespace ChapeauUI
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
            this.txtBox_TotalAmount = new System.Windows.Forms.TextBox();
            this.txtBox_Tip = new System.Windows.Forms.TextBox();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.lbl_Feedbak = new System.Windows.Forms.Label();
            this.listView_Payment = new System.Windows.Forms.ListView();
            this.lbl_serverName = new System.Windows.Forms.Label();
            this.txtBox_ServerName = new System.Windows.Forms.TextBox();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.lbl_TblNr = new System.Windows.Forms.Label();
            this.richTxtBox_FeedBack = new System.Windows.Forms.RichTextBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_TotalVAT9 = new System.Windows.Forms.Label();
            this.lbl_TotalVAT21 = new System.Windows.Forms.Label();
            this.lbl_TotalVAT = new System.Windows.Forms.Label();
            this.RadioBtn_visa = new System.Windows.Forms.RadioButton();
            this.RadioBtn_PIN = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Cash = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(897, 15);
            // 
            // txtBox_TotalAmount
            // 
            this.txtBox_TotalAmount.Location = new System.Drawing.Point(763, 261);
            this.txtBox_TotalAmount.Name = "txtBox_TotalAmount";
            this.txtBox_TotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtBox_TotalAmount.TabIndex = 0;
            // 
            // txtBox_Tip
            // 
            this.txtBox_Tip.Location = new System.Drawing.Point(763, 232);
            this.txtBox_Tip.Name = "txtBox_Tip";
            this.txtBox_Tip.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Tip.TabIndex = 1;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Location = new System.Drawing.Point(619, 264);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(92, 17);
            this.lbl_totalAmount.TabIndex = 3;
            this.lbl_totalAmount.Text = "Total Amount";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Location = new System.Drawing.Point(620, 222);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(28, 17);
            this.lbl_Tip.TabIndex = 4;
            this.lbl_Tip.Text = "Tip";
            // 
            // lbl_Feedbak
            // 
            this.lbl_Feedbak.AutoSize = true;
            this.lbl_Feedbak.Location = new System.Drawing.Point(620, 293);
            this.lbl_Feedbak.Name = "lbl_Feedbak";
            this.lbl_Feedbak.Size = new System.Drawing.Size(70, 17);
            this.lbl_Feedbak.TabIndex = 5;
            this.lbl_Feedbak.Text = "Feedback";
            // 
            // listView_Payment
            // 
            this.listView_Payment.Location = new System.Drawing.Point(28, 73);
            this.listView_Payment.Name = "listView_Payment";
            this.listView_Payment.Size = new System.Drawing.Size(461, 593);
            this.listView_Payment.TabIndex = 6;
            this.listView_Payment.UseCompatibleStateImageBehavior = false;
            this.listView_Payment.SelectedIndexChanged += new System.EventHandler(this.listView_Payment_SelectedIndexChanged);
            // 
            // lbl_serverName
            // 
            this.lbl_serverName.AutoSize = true;
            this.lbl_serverName.Location = new System.Drawing.Point(620, 73);
            this.lbl_serverName.Name = "lbl_serverName";
            this.lbl_serverName.Size = new System.Drawing.Size(91, 17);
            this.lbl_serverName.TabIndex = 7;
            this.lbl_serverName.Text = "Server Name";
            // 
            // txtBox_ServerName
            // 
            this.txtBox_ServerName.Location = new System.Drawing.Point(764, 73);
            this.txtBox_ServerName.Name = "txtBox_ServerName";
            this.txtBox_ServerName.Size = new System.Drawing.Size(100, 22);
            this.txtBox_ServerName.TabIndex = 8;
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Location = new System.Drawing.Point(620, 468);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(63, 17);
            this.lbl_Payment.TabIndex = 10;
            this.lbl_Payment.Text = "Payment";
            // 
            // lbl_TblNr
            // 
            this.lbl_TblNr.AutoSize = true;
            this.lbl_TblNr.Location = new System.Drawing.Point(25, 31);
            this.lbl_TblNr.Name = "lbl_TblNr";
            this.lbl_TblNr.Size = new System.Drawing.Size(102, 17);
            this.lbl_TblNr.TabIndex = 13;
            this.lbl_TblNr.Text = "Table Number:";
            // 
            // richTxtBox_FeedBack
            // 
            this.richTxtBox_FeedBack.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBox_FeedBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtBox_FeedBack.Location = new System.Drawing.Point(623, 324);
            this.richTxtBox_FeedBack.Name = "richTxtBox_FeedBack";
            this.richTxtBox_FeedBack.Size = new System.Drawing.Size(241, 130);
            this.richTxtBox_FeedBack.TabIndex = 15;
            this.richTxtBox_FeedBack.Text = "Comments...";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(623, 628);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(162, 38);
            this.btn_Pay.TabIndex = 16;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_TotalVAT9
            // 
            this.lbl_TotalVAT9.AutoSize = true;
            this.lbl_TotalVAT9.Location = new System.Drawing.Point(619, 125);
            this.lbl_TotalVAT9.Name = "lbl_TotalVAT9";
            this.lbl_TotalVAT9.Size = new System.Drawing.Size(59, 17);
            this.lbl_TotalVAT9.TabIndex = 17;
            this.lbl_TotalVAT9.Text = "VAT 9%";
            // 
            // lbl_TotalVAT21
            // 
            this.lbl_TotalVAT21.AutoSize = true;
            this.lbl_TotalVAT21.Location = new System.Drawing.Point(619, 158);
            this.lbl_TotalVAT21.Name = "lbl_TotalVAT21";
            this.lbl_TotalVAT21.Size = new System.Drawing.Size(67, 17);
            this.lbl_TotalVAT21.TabIndex = 18;
            this.lbl_TotalVAT21.Text = "VAT 21%";
            // 
            // lbl_TotalVAT
            // 
            this.lbl_TotalVAT.AutoSize = true;
            this.lbl_TotalVAT.Location = new System.Drawing.Point(619, 188);
            this.lbl_TotalVAT.Name = "lbl_TotalVAT";
            this.lbl_TotalVAT.Size = new System.Drawing.Size(71, 17);
            this.lbl_TotalVAT.TabIndex = 19;
            this.lbl_TotalVAT.Text = "Total VAT";
            // 
            // RadioBtn_visa
            // 
            this.RadioBtn_visa.AutoSize = true;
            this.RadioBtn_visa.Location = new System.Drawing.Point(623, 505);
            this.RadioBtn_visa.Name = "RadioBtn_visa";
            this.RadioBtn_visa.Size = new System.Drawing.Size(94, 21);
            this.RadioBtn_visa.TabIndex = 20;
            this.RadioBtn_visa.Text = "Visa/Amex";
            this.RadioBtn_visa.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_PIN
            // 
            this.RadioBtn_PIN.AutoSize = true;
            this.RadioBtn_PIN.Location = new System.Drawing.Point(723, 505);
            this.RadioBtn_PIN.Name = "RadioBtn_PIN";
            this.RadioBtn_PIN.Size = new System.Drawing.Size(51, 21);
            this.RadioBtn_PIN.TabIndex = 21;
            this.RadioBtn_PIN.Text = "PIN";
            this.RadioBtn_PIN.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Cash
            // 
            this.RadioBtn_Cash.AutoSize = true;
            this.RadioBtn_Cash.Location = new System.Drawing.Point(802, 505);
            this.RadioBtn_Cash.Name = "RadioBtn_Cash";
            this.RadioBtn_Cash.Size = new System.Drawing.Size(61, 21);
            this.RadioBtn_Cash.TabIndex = 22;
            this.RadioBtn_Cash.Text = "Cash";
            this.RadioBtn_Cash.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.RadioBtn_Cash);
            this.Controls.Add(this.RadioBtn_PIN);
            this.Controls.Add(this.RadioBtn_visa);
            this.Controls.Add(this.lbl_TotalVAT);
            this.Controls.Add(this.lbl_TotalVAT21);
            this.Controls.Add(this.lbl_TotalVAT9);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.richTxtBox_FeedBack);
            this.Controls.Add(this.lbl_TblNr);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.txtBox_ServerName);
            this.Controls.Add(this.lbl_serverName);
            this.Controls.Add(this.listView_Payment);
            this.Controls.Add(this.lbl_Feedbak);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.txtBox_Tip);
            this.Controls.Add(this.txtBox_TotalAmount);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.Controls.SetChildIndex(this.txtBox_TotalAmount, 0);
            this.Controls.SetChildIndex(this.txtBox_Tip, 0);
            this.Controls.SetChildIndex(this.lbl_totalAmount, 0);
            this.Controls.SetChildIndex(this.lbl_Tip, 0);
            this.Controls.SetChildIndex(this.lbl_Feedbak, 0);
            this.Controls.SetChildIndex(this.listView_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_serverName, 0);
            this.Controls.SetChildIndex(this.txtBox_ServerName, 0);
            this.Controls.SetChildIndex(this.lbl_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_TblNr, 0);
            this.Controls.SetChildIndex(this.richTxtBox_FeedBack, 0);
            this.Controls.SetChildIndex(this.btn_Pay, 0);
            this.Controls.SetChildIndex(this.lbl_TotalVAT9, 0);
            this.Controls.SetChildIndex(this.lbl_TotalVAT21, 0);
            this.Controls.SetChildIndex(this.lbl_TotalVAT, 0);
            this.Controls.SetChildIndex(this.RadioBtn_visa, 0);
            this.Controls.SetChildIndex(this.RadioBtn_PIN, 0);
            this.Controls.SetChildIndex(this.RadioBtn_Cash, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_TotalAmount;
        private System.Windows.Forms.TextBox txtBox_Tip;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Label lbl_Feedbak;
        private System.Windows.Forms.ListView listView_Payment;
        private System.Windows.Forms.Label lbl_serverName;
        private System.Windows.Forms.TextBox txtBox_ServerName;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Label lbl_TblNr;
        private System.Windows.Forms.RichTextBox richTxtBox_FeedBack;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_TotalVAT9;
        private System.Windows.Forms.Label lbl_TotalVAT21;
        private System.Windows.Forms.Label lbl_TotalVAT;
        private System.Windows.Forms.RadioButton RadioBtn_visa;
        private System.Windows.Forms.RadioButton RadioBtn_PIN;
        private System.Windows.Forms.RadioButton RadioBtn_Cash;
    }
}