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
            this.components = new System.ComponentModel.Container();
            this.flpnl_DiningTables = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_FreeColor = new System.Windows.Forms.Label();
            this.lbl_ReservedColor = new System.Windows.Forms.Label();
            this.lbl_OccupiedColor = new System.Windows.Forms.Label();
            this.tableViewRefresher = new System.Windows.Forms.Timer(this.components);
            this.btn_KitchenNotifications = new ChapeauUI.BaseButton();
            this.btn_BarNotifications = new ChapeauUI.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Notifications = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnl_DiningTables
            // 
            this.flpnl_DiningTables.Location = new System.Drawing.Point(107, 166);
            this.flpnl_DiningTables.Name = "flpnl_DiningTables";
            this.flpnl_DiningTables.Size = new System.Drawing.Size(780, 359);
            this.flpnl_DiningTables.TabIndex = 8;
            this.flpnl_DiningTables.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnl_DiningTables_Paint);
            // 
            // lbl_FreeColor
            // 
            this.lbl_FreeColor.AutoSize = true;
            this.lbl_FreeColor.Location = new System.Drawing.Point(102, 543);
            this.lbl_FreeColor.Name = "lbl_FreeColor";
            this.lbl_FreeColor.Size = new System.Drawing.Size(61, 27);
            this.lbl_FreeColor.TabIndex = 9;
            this.lbl_FreeColor.Text = "Free";
            // 
            // lbl_ReservedColor
            // 
            this.lbl_ReservedColor.AutoSize = true;
            this.lbl_ReservedColor.Location = new System.Drawing.Point(102, 620);
            this.lbl_ReservedColor.Name = "lbl_ReservedColor";
            this.lbl_ReservedColor.Size = new System.Drawing.Size(113, 27);
            this.lbl_ReservedColor.TabIndex = 10;
            this.lbl_ReservedColor.Text = "Reserved";
            // 
            // lbl_OccupiedColor
            // 
            this.lbl_OccupiedColor.AutoSize = true;
            this.lbl_OccupiedColor.Location = new System.Drawing.Point(102, 581);
            this.lbl_OccupiedColor.Name = "lbl_OccupiedColor";
            this.lbl_OccupiedColor.Size = new System.Drawing.Size(115, 27);
            this.lbl_OccupiedColor.TabIndex = 11;
            this.lbl_OccupiedColor.Text = "Occupied";
            // 
            // tableViewRefresher
            // 
            this.tableViewRefresher.Enabled = true;
            this.tableViewRefresher.Interval = 2000;
            this.tableViewRefresher.Tick += new System.EventHandler(this.tableViewRefresher_Tick);
            // 
            // btn_KitchenNotifications
            // 
            this.btn_KitchenNotifications.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_KitchenNotifications.Location = new System.Drawing.Point(317, 47);
            this.btn_KitchenNotifications.Name = "btn_KitchenNotifications";
            this.btn_KitchenNotifications.Size = new System.Drawing.Size(239, 62);
            this.btn_KitchenNotifications.TabIndex = 12;
            this.btn_KitchenNotifications.Text = "Kitchen";
            this.btn_KitchenNotifications.UseVisualStyleBackColor = true;
            // 
            // btn_BarNotifications
            // 
            this.btn_BarNotifications.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_BarNotifications.Location = new System.Drawing.Point(31, 47);
            this.btn_BarNotifications.Name = "btn_BarNotifications";
            this.btn_BarNotifications.Size = new System.Drawing.Size(239, 63);
            this.btn_BarNotifications.TabIndex = 13;
            this.btn_BarNotifications.Text = "Bar";
            this.btn_BarNotifications.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Notifications);
            this.panel1.Controls.Add(this.btn_KitchenNotifications);
            this.panel1.Controls.Add(this.btn_BarNotifications);
            this.panel1.Location = new System.Drawing.Point(107, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 141);
            this.panel1.TabIndex = 14;
            // 
            // lbl_Notifications
            // 
            this.lbl_Notifications.AutoSize = true;
            this.lbl_Notifications.Location = new System.Drawing.Point(31, 9);
            this.lbl_Notifications.Name = "lbl_Notifications";
            this.lbl_Notifications.Size = new System.Drawing.Size(142, 27);
            this.lbl_Notifications.TabIndex = 14;
            this.lbl_Notifications.Text = "Notifications";
            // 
            // TableViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_OccupiedColor);
            this.Controls.Add(this.lbl_ReservedColor);
            this.Controls.Add(this.lbl_FreeColor);
            this.Controls.Add(this.flpnl_DiningTables);
            this.Name = "TableViewForm";
            this.Text = "TableViewForm";
            this.Load += new System.EventHandler(this.TableViewForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_DiningTables, 0);
            this.Controls.SetChildIndex(this.lbl_FreeColor, 0);
            this.Controls.SetChildIndex(this.lbl_ReservedColor, 0);
            this.Controls.SetChildIndex(this.lbl_OccupiedColor, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_DiningTables;
        private System.Windows.Forms.Label lbl_FreeColor;
        private System.Windows.Forms.Label lbl_ReservedColor;
        private System.Windows.Forms.Label lbl_OccupiedColor;
        private System.Windows.Forms.Timer tableViewRefresher;
        private BaseButton btn_KitchenNotifications;
        private BaseButton btn_BarNotifications;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Notifications;
    }
}