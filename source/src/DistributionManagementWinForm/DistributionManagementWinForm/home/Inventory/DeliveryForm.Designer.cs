
namespace DistributionManagementWinForm.home.Inventory
{
    partial class DeliveryForm
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
            this.dataGridView_deliveryList = new System.Windows.Forms.DataGridView();
            this.textBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deliveryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_deliveryList
            // 
            this.dataGridView_deliveryList.AllowUserToAddRows = false;
            this.dataGridView_deliveryList.AllowUserToDeleteRows = false;
            this.dataGridView_deliveryList.AllowUserToResizeColumns = false;
            this.dataGridView_deliveryList.AllowUserToResizeRows = false;
            this.dataGridView_deliveryList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_deliveryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_deliveryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_deliveryList.ColumnHeadersHeight = 40;
            this.dataGridView_deliveryList.Location = new System.Drawing.Point(60, 105);
            this.dataGridView_deliveryList.Name = "dataGridView_deliveryList";
            this.dataGridView_deliveryList.ReadOnly = true;
            this.dataGridView_deliveryList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_deliveryList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_deliveryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_deliveryList.Size = new System.Drawing.Size(1050, 668);
            this.dataGridView_deliveryList.TabIndex = 22;
            this.dataGridView_deliveryList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_deliveryList_CellDoubleClick);
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
            this.textBox_search.Location = new System.Drawing.Point(60, 50);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PasswordChar = '\0';
            this.textBox_search.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBox_search.PlaceholderText = " Search By";
            this.textBox_search.SelectedText = "";
            this.textBox_search.Size = new System.Drawing.Size(536, 37);
            this.textBox_search.TabIndex = 21;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 800);
            this.Controls.Add(this.dataGridView_deliveryList);
            this.Controls.Add(this.textBox_search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeliveryForm";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deliveryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_deliveryList;
        private Guna.UI2.WinForms.Guna2TextBox textBox_search;
    }
}