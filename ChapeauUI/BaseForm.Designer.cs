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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.picBox_Chapeau = new System.Windows.Forms.PictureBox();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Chapeau)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Chapeau
            // 
            this.picBox_Chapeau.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Chapeau.Image")));
            this.picBox_Chapeau.Location = new System.Drawing.Point(131, 78);
            this.picBox_Chapeau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBox_Chapeau.Name = "picBox_Chapeau";
            this.picBox_Chapeau.Size = new System.Drawing.Size(398, 224);
            this.picBox_Chapeau.TabIndex = 6;
            this.picBox_Chapeau.TabStop = false;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.CausesValidation = false;
            this.Btn_LogOut.Location = new System.Drawing.Point(586, 11);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(71, 40);
            this.Btn_LogOut.TabIndex = 7;
            this.Btn_LogOut.Text = "LogOut";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 456);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.picBox_Chapeau);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Chapeau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBox_Chapeau;
        protected System.Windows.Forms.Button Btn_LogOut;
    }
}