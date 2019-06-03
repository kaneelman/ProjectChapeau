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
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Chapeau)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Chapeau
            // 
            this.picBox_Chapeau.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Chapeau.Image")));
            this.picBox_Chapeau.Location = new System.Drawing.Point(436, 66);
            this.picBox_Chapeau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Chapeau.Name = "picBox_Chapeau";
            this.picBox_Chapeau.Size = new System.Drawing.Size(436, 260);
            this.picBox_Chapeau.TabIndex = 6;
            this.picBox_Chapeau.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.picBox_Chapeau);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Chapeau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox picBox_Chapeau;
    }
}