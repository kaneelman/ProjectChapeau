namespace ChapeauUI
{
    partial class OrderOptionForm
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
            this.lst_CurrentOrder = new System.Windows.Forms.ListView();
            this.Btn_NewOrder = new System.Windows.Forms.Button();
            this.Btn_Payment = new System.Windows.Forms.Button();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_CurrentOrder
            // 
            this.lst_CurrentOrder.Location = new System.Drawing.Point(47, 76);
            this.lst_CurrentOrder.Name = "lst_CurrentOrder";
            this.lst_CurrentOrder.Size = new System.Drawing.Size(495, 609);
            this.lst_CurrentOrder.TabIndex = 10;
            this.lst_CurrentOrder.UseCompatibleStateImageBehavior = false;
            this.lst_CurrentOrder.SelectedIndexChanged += new System.EventHandler(this.lstview_CurrentOrder_SelectedIndexChanged);
            // 
            // Btn_NewOrder
            // 
            this.Btn_NewOrder.Location = new System.Drawing.Point(692, 195);
            this.Btn_NewOrder.Name = "Btn_NewOrder";
            this.Btn_NewOrder.Size = new System.Drawing.Size(174, 85);
            this.Btn_NewOrder.TabIndex = 11;
            this.Btn_NewOrder.Text = "New Order";
            this.Btn_NewOrder.UseVisualStyleBackColor = true;
            // 
            // Btn_Payment
            // 
            this.Btn_Payment.Location = new System.Drawing.Point(692, 302);
            this.Btn_Payment.Name = "Btn_Payment";
            this.Btn_Payment.Size = new System.Drawing.Size(174, 85);
            this.Btn_Payment.TabIndex = 12;
            this.Btn_Payment.Text = "Payment";
            this.Btn_Payment.UseVisualStyleBackColor = true;
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Location = new System.Drawing.Point(43, 37);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(254, 23);
            this.lbl_OrderView.TabIndex = 13;
            this.lbl_OrderView.Text = "The Current Order of Table:";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(692, 407);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(174, 85);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // OrderOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_OrderView);
            this.Controls.Add(this.Btn_Payment);
            this.Controls.Add(this.Btn_NewOrder);
            this.Controls.Add(this.lst_CurrentOrder);
            this.Name = "OrderOptionForm";
            this.Text = "OrderOptionForm";
            this.Load += new System.EventHandler(this.OrderOptionForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.lst_CurrentOrder, 0);
            this.Controls.SetChildIndex(this.Btn_NewOrder, 0);
            this.Controls.SetChildIndex(this.Btn_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_OrderView, 0);
            this.Controls.SetChildIndex(this.btn_remove, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_CurrentOrder;
        private System.Windows.Forms.Button Btn_NewOrder;
        private System.Windows.Forms.Button Btn_Payment;
        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Button btn_remove;
    }
}