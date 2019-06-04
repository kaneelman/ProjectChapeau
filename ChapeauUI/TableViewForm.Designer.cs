namespace ChapeauUI
{
    partial class TableViewForm
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
            this.flpnl_DiningTables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpnl_DiningTables
            // 
            this.flpnl_DiningTables.Location = new System.Drawing.Point(30, 97);
            this.flpnl_DiningTables.Name = "flpnl_DiningTables";
            this.flpnl_DiningTables.Size = new System.Drawing.Size(920, 492);
            this.flpnl_DiningTables.TabIndex = 8;
            // 
            // TableViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.flpnl_DiningTables);
            this.Name = "TableViewForm";
            this.Text = "TableViewForm";
            this.Load += new System.EventHandler(this.TableViewForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_DiningTables, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_DiningTables;
    }
}