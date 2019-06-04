namespace ChapeauUI
{
    partial class BartenderForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flpnl_Orders = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flpnl_Orders
            // 
            this.flpnl_Orders.Location = new System.Drawing.Point(54, 47);
            this.flpnl_Orders.Name = "flpnl_Orders";
            this.flpnl_Orders.Size = new System.Drawing.Size(200, 643);
            this.flpnl_Orders.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(307, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 643);
            this.panel1.TabIndex = 8;
            // 
            // BartenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpnl_Orders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BartenderForm";
            this.Text = "BartenderForm";
            this.Load += new System.EventHandler(this.BartenderForm_Load);
            this.Controls.SetChildIndex(this.flpnl_Orders, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpnl_Orders;
        private System.Windows.Forms.Panel panel1;
    }
}