
namespace DistributionManagementWinForm.home.Admin
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.button_create = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.button_delete);
            this.panelAccount.Controls.Add(this.button_edit);
            this.panelAccount.Controls.Add(this.button_create);
            this.panelAccount.Controls.Add(this.textBox_search);
            this.panelAccount.Controls.Add(this.accountGridView);
            this.panelAccount.Controls.Add(this.panel3);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(1170, 800);
            this.panelAccount.TabIndex = 6;
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
            this.button_delete.Location = new System.Drawing.Point(475, 708);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(180, 45);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
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
            this.button_edit.Location = new System.Drawing.Point(710, 708);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(180, 45);
            this.button_edit.TabIndex = 19;
            this.button_edit.Text = "Edit";
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
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
            this.button_create.Location = new System.Drawing.Point(930, 708);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(180, 45);
            this.button_create.TabIndex = 18;
            this.button_create.Text = "Create";
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
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
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_search.Location = new System.Drawing.Point(60, 53);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PasswordChar = '\0';
            this.textBox_search.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBox_search.PlaceholderText = " Search By Username";
            this.textBox_search.SelectedText = "";
            this.textBox_search.Size = new System.Drawing.Size(559, 37);
            this.textBox_search.TabIndex = 15;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // accountGridView
            // 
            this.accountGridView.AllowUserToAddRows = false;
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.AllowUserToResizeColumns = false;
            this.accountGridView.AllowUserToResizeRows = false;
            this.accountGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.accountGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountGridView.ColumnHeadersHeight = 40;
            this.accountGridView.Location = new System.Drawing.Point(60, 120);
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.accountGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountGridView.Size = new System.Drawing.Size(1050, 550);
            this.accountGridView.TabIndex = 14;
            this.accountGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountGridView_CellClick);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1170, 800);
            this.Controls.Add(this.panelAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.DataGridView accountGridView;
        private Guna.UI2.WinForms.Guna2TextBox textBox_search;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        private Guna.UI2.WinForms.Guna2Button button_create;
    }
}