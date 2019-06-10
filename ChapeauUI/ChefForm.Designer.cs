namespace ChapeauUI
{
    partial class ChefForm
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
            this.flpnl_Orders = new System.Windows.Forms.FlowLayoutPanel();
            this.PicBox_TableNumber = new System.Windows.Forms.PictureBox();
            this.lst_Orders = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnl_Orders
            // 
            this.flpnl_Orders.AutoScroll = true;
            this.flpnl_Orders.Location = new System.Drawing.Point(54, 17);
            this.flpnl_Orders.Name = "flpnl_Orders";
            this.flpnl_Orders.Size = new System.Drawing.Size(290, 618);
            this.flpnl_Orders.TabIndex = 10;
            // 
            // PicBox_TableNumber
            // 
            this.PicBox_TableNumber.Location = new System.Drawing.Point(391, 10);
            this.PicBox_TableNumber.Name = "PicBox_TableNumber";
            this.PicBox_TableNumber.Size = new System.Drawing.Size(100, 90);
            this.PicBox_TableNumber.TabIndex = 13;
            this.PicBox_TableNumber.TabStop = false;
            // 
            // lst_Orders
            // 
            this.lst_Orders.Location = new System.Drawing.Point(391, 106);
            this.lst_Orders.Name = "lst_Orders";
            this.lst_Orders.Size = new System.Drawing.Size(561, 529);
            this.lst_Orders.TabIndex = 14;
            this.lst_Orders.UseCompatibleStateImageBehavior = false;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lst_Orders);
            this.Controls.Add(this.PicBox_TableNumber);
            this.Controls.Add(this.flpnl_Orders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChefForm";
            this.Text = "ChefForm";
            this.Load += new System.EventHandler(this.ChefForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_Orders, 0);
            this.Controls.SetChildIndex(this.PicBox_TableNumber, 0);
            this.Controls.SetChildIndex(this.lst_Orders, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_Orders;
        private System.Windows.Forms.PictureBox PicBox_TableNumber;
        private System.Windows.Forms.ListView lst_Orders;
    }
}