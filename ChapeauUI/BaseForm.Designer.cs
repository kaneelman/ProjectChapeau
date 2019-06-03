namespace ChapeauUI
{
    partial class BaseForm
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
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.CausesValidation = false;
            this.Btn_LogOut.Location = new System.Drawing.Point(879, 17);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(106, 62);
            this.Btn_LogOut.TabIndex = 7;
            this.Btn_LogOut.Text = "LogOut";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.Btn_LogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button Btn_LogOut;
    }
}