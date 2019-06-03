namespace ChapeauUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.img_ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ID.Location = new System.Drawing.Point(486, 357);
            this.txtBox_ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(242, 35);
            this.txtBox_ID.TabIndex = 0;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.Location = new System.Drawing.Point(486, 412);
            this.txtBox_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(242, 35);
            this.txtBox_Password.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(311, 506);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(417, 65);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(323, 365);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(149, 27);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Employee ID";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(323, 415);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(117, 27);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            // 
            // img_
            // 
            this.img_.Image = ((System.Drawing.Image)(resources.GetObject("img_.Image")));
            this.img_.Location = new System.Drawing.Point(311, 66);
            this.img_.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.img_.Name = "img_";
            this.img_.Size = new System.Drawing.Size(417, 240);
            this.img_.TabIndex = 8;
            this.img_.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.img_);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_ID);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.txtBox_ID, 0);
            this.Controls.SetChildIndex(this.txtBox_Password, 0);
            this.Controls.SetChildIndex(this.btn_Login, 0);
            this.Controls.SetChildIndex(this.lbl_ID, 0);
            this.Controls.SetChildIndex(this.lbl_Password, 0);
            this.Controls.SetChildIndex(this.img_, 0);
            ((System.ComponentModel.ISupportInitialize)(this.img_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Password;
        public System.Windows.Forms.PictureBox img_;
    }
}

