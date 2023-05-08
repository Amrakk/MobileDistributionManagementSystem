
namespace DistributionManagementWinForm.home.Inventory
{
    partial class ReceiptForm
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
            this.panelAccount = new System.Windows.Forms.Panel();
            this.button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.button_create = new Guna.UI2.WinForms.Guna2Button();
            this.receiptGridView = new System.Windows.Forms.DataGridView();
            this.textBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.button_delete);
            this.panelAccount.Controls.Add(this.button_edit);
            this.panelAccount.Controls.Add(this.button_create);
            this.panelAccount.Controls.Add(this.receiptGridView);
            this.panelAccount.Controls.Add(this.textBox_search);
            this.panelAccount.Controls.Add(this.panel3);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(1170, 800);
            this.panelAccount.TabIndex = 8;
            this.panelAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccount_Paint);
            // 
            // button_delete
            // 
            this.button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(475, 719);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(180, 45);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            // 
            // button_edit
            // 
            this.button_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(710, 719);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(180, 45);
            this.button_edit.TabIndex = 19;
            this.button_edit.Text = "Edit";
            // 
            // button_create
            // 
            this.button_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(930, 719);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(180, 45);
            this.button_create.TabIndex = 18;
            this.button_create.Text = "Create";
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // receiptGridView
            // 
            this.receiptGridView.AllowUserToAddRows = false;
            this.receiptGridView.AllowUserToDeleteRows = false;
            this.receiptGridView.AllowUserToResizeColumns = false;
            this.receiptGridView.AllowUserToResizeRows = false;
            this.receiptGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.receiptGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.receiptGridView.ColumnHeadersHeight = 40;
            this.receiptGridView.Location = new System.Drawing.Point(60, 105);
            this.receiptGridView.Name = "receiptGridView";
            this.receiptGridView.ReadOnly = true;
            this.receiptGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.receiptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptGridView.Size = new System.Drawing.Size(1050, 550);
            this.receiptGridView.TabIndex = 16;
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
            this.textBox_search.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 799);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1170, 1);
            this.panel3.TabIndex = 3;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 800);
            this.Controls.Add(this.panelAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptForm";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panelAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_search;
        private System.Windows.Forms.DataGridView receiptGridView;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        private Guna.UI2.WinForms.Guna2Button button_create;
    }
}