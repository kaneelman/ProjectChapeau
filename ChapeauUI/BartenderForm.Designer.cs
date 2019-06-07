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
            this.flpnl_Orders = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MarkFinished = new System.Windows.Forms.Button();
            this.btn_SortByFinished = new System.Windows.Forms.Button();
            this.btn_SortByRunning = new System.Windows.Forms.Button();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.PicBox_TableNumber = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnl_Orders
            // 
            this.flpnl_Orders.AutoScroll = true;
            this.flpnl_Orders.Location = new System.Drawing.Point(54, 17);
            this.flpnl_Orders.Name = "flpnl_Orders";
            this.flpnl_Orders.Size = new System.Drawing.Size(290, 618);
            this.flpnl_Orders.TabIndex = 0;
            this.flpnl_Orders.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnl_Orders_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(391, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 529);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn_MarkFinished
            // 
            this.btn_MarkFinished.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarkFinished.Location = new System.Drawing.Point(767, 642);
            this.btn_MarkFinished.Name = "btn_MarkFinished";
            this.btn_MarkFinished.Size = new System.Drawing.Size(175, 50);
            this.btn_MarkFinished.TabIndex = 0;
            this.btn_MarkFinished.Text = "Mark Finished";
            this.btn_MarkFinished.UseVisualStyleBackColor = true;
            // 
            // btn_SortByFinished
            // 
            this.btn_SortByFinished.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByFinished.Location = new System.Drawing.Point(238, 652);
            this.btn_SortByFinished.Name = "btn_SortByFinished";
            this.btn_SortByFinished.Size = new System.Drawing.Size(100, 40);
            this.btn_SortByFinished.TabIndex = 9;
            this.btn_SortByFinished.Text = "Finished";
            this.btn_SortByFinished.UseVisualStyleBackColor = true;
            // 
            // btn_SortByRunning
            // 
            this.btn_SortByRunning.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByRunning.Location = new System.Drawing.Point(132, 652);
            this.btn_SortByRunning.Name = "btn_SortByRunning";
            this.btn_SortByRunning.Size = new System.Drawing.Size(100, 40);
            this.btn_SortByRunning.TabIndex = 10;
            this.btn_SortByRunning.Text = "Running";
            this.btn_SortByRunning.UseVisualStyleBackColor = true;
            // 
            // lbl_SortBy
            // 
            this.lbl_SortBy.AutoSize = true;
            this.lbl_SortBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortBy.Location = new System.Drawing.Point(51, 664);
            this.lbl_SortBy.Name = "lbl_SortBy";
            this.lbl_SortBy.Size = new System.Drawing.Size(75, 22);
            this.lbl_SortBy.TabIndex = 11;
            this.lbl_SortBy.Text = "Sort by:";
            // 
            // PicBox_TableNumber
            // 
            this.PicBox_TableNumber.Location = new System.Drawing.Point(391, 10);
            this.PicBox_TableNumber.Name = "PicBox_TableNumber";
            this.PicBox_TableNumber.Size = new System.Drawing.Size(100, 90);
            this.PicBox_TableNumber.TabIndex = 12;
            this.PicBox_TableNumber.TabStop = false;
            // 
            // BartenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PicBox_TableNumber);
            this.Controls.Add(this.btn_MarkFinished);
            this.Controls.Add(this.lbl_SortBy);
            this.Controls.Add(this.btn_SortByRunning);
            this.Controls.Add(this.btn_SortByFinished);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpnl_Orders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BartenderForm";
            this.Text = "BartenderForm";
            this.Load += new System.EventHandler(this.BartenderForm_Load);
            this.Controls.SetChildIndex(this.flpnl_Orders, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.btn_SortByFinished, 0);
            this.Controls.SetChildIndex(this.btn_SortByRunning, 0);
            this.Controls.SetChildIndex(this.lbl_SortBy, 0);
            this.Controls.SetChildIndex(this.btn_MarkFinished, 0);
            this.Controls.SetChildIndex(this.PicBox_TableNumber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpnl_Orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SortByFinished;
        private System.Windows.Forms.Button btn_SortByRunning;
        private System.Windows.Forms.Label lbl_SortBy;
        private System.Windows.Forms.Button btn_MarkFinished;
        private System.Windows.Forms.PictureBox PicBox_TableNumber;
    }
}