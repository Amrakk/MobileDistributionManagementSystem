
namespace DistributionManagementWinForm.home.Order
{
    partial class OrderListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_allOrder = new System.Windows.Forms.Label();
            this.label_pending = new System.Windows.Forms.Label();
            this.textBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_orderList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label_allOrder
            // 
            this.label_allOrder.AutoSize = true;
            this.label_allOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_allOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_allOrder.Location = new System.Drawing.Point(31, 32);
            this.label_allOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_allOrder.Name = "label_allOrder";
            this.label_allOrder.Size = new System.Drawing.Size(105, 30);
            this.label_allOrder.TabIndex = 3;
            this.label_allOrder.Text = "All Orders";
            this.label_allOrder.Click += new System.EventHandler(this.label_allOrder_Click_1);
            this.label_allOrder.Leave += new System.EventHandler(this.label_allOrder_Leave_1);

            // 
            // label_pending
            // 
            this.label_pending.AutoSize = true;
            this.label_pending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_pending.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pending.Location = new System.Drawing.Point(144, 32);
            this.label_pending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pending.Name = "label_pending";
            this.label_pending.Size = new System.Drawing.Size(88, 30);
            this.label_pending.TabIndex = 4;
            this.label_pending.Text = "Pending";
            this.label_pending.Click += new System.EventHandler(this.label_pending_Click);
            this.label_pending.Leave += new System.EventHandler(this.label_pending_Leave_1);
           
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_search.BorderThickness = 2;
            this.textBox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_search.DefaultText = "";
            this.textBox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_search.FillColor = System.Drawing.SystemColors.Control;
            this.textBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_search.Location = new System.Drawing.Point(36, 83);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PasswordChar = '\0';
            this.textBox_search.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBox_search.PlaceholderText = " Search By Reseller Name";
            this.textBox_search.SelectedText = "";
            this.textBox_search.Size = new System.Drawing.Size(505, 39);
            this.textBox_search.TabIndex = 6;
           
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // dataGridView_orderList
            // 
            this.dataGridView_orderList.AllowUserToAddRows = false;
            this.dataGridView_orderList.AllowUserToResizeColumns = false;
            this.dataGridView_orderList.AllowUserToResizeRows = false;
            this.dataGridView_orderList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_orderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_orderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_orderList.ColumnHeadersHeight = 40;
            this.dataGridView_orderList.Location = new System.Drawing.Point(36, 159);
            this.dataGridView_orderList.Name = "dataGridView_orderList";
            this.dataGridView_orderList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_orderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_orderList.RowHeadersVisible = false;
            this.dataGridView_orderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_orderList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_orderList.Size = new System.Drawing.Size(1099, 545);
            this.dataGridView_orderList.TabIndex = 5;
            this.dataGridView_orderList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_orderList_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 7;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1162, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_orderList);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_pending);
            this.Controls.Add(this.label_allOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderListForm";
            this.Text = "Order List";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
           
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_allOrder;
        private System.Windows.Forms.Label label_pending;
        private Guna.UI2.WinForms.Guna2TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_orderList;
        private System.Windows.Forms.Label label1;
    }
}