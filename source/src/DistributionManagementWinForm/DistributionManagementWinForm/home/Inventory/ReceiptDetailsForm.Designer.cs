
namespace DistributionManagementWinForm.home.Inventory
{
    partial class ReceiptDetailsForm
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
            this.dragPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_productName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_receivedItemList = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker_receivedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBox_totalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_receivedFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.button_submit = new Guna.UI2.WinForms.Guna2Button();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_receivedItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dragPanel.Size = new System.Drawing.Size(820, 30);
            this.dragPanel.TabIndex = 10;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 20;
            this.closeBtn.Location = new System.Drawing.Point(795, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(36, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Product Name";
            // 
            // comboBox_productName
            // 
            this.comboBox_productName.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_productName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_productName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_productName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_productName.ItemHeight = 30;
            this.comboBox_productName.Location = new System.Drawing.Point(150, 338);
            this.comboBox_productName.Name = "comboBox_productName";
            this.comboBox_productName.Size = new System.Drawing.Size(296, 36);
            this.comboBox_productName.TabIndex = 100;
            this.comboBox_productName.SelectedValueChanged += new System.EventHandler(this.comboBox_productName_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(38, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 1);
            this.panel2.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(33, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 98;
            this.label5.Text = "Goods Received Note";
            // 
            // dataGridView_receivedItemList
            // 
            this.dataGridView_receivedItemList.AllowUserToResizeColumns = false;
            this.dataGridView_receivedItemList.AllowUserToResizeRows = false;
            this.dataGridView_receivedItemList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_receivedItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_receivedItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_receivedItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_receivedItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.quantity,
            this.cost,
            this.total_cost});
            this.dataGridView_receivedItemList.Location = new System.Drawing.Point(37, 385);
            this.dataGridView_receivedItemList.Name = "dataGridView_receivedItemList";
            this.dataGridView_receivedItemList.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.dataGridView_receivedItemList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_receivedItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_receivedItemList.Size = new System.Drawing.Size(750, 234);
            this.dataGridView_receivedItemList.TabIndex = 97;
            this.dataGridView_receivedItemList.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_receivedItemList_CellValidated);
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            // 
            // total_cost
            // 
            this.total_cost.HeaderText = "Total Cost";
            this.total_cost.Name = "total_cost";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(37, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 1);
            this.panel1.TabIndex = 96;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label17.Location = new System.Drawing.Point(32, 289);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 30);
            this.label17.TabIndex = 95;
            this.label17.Text = "Received Item";
            // 
            // dateTimePicker_receivedDate
            // 
            this.dateTimePicker_receivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker_receivedDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.dateTimePicker_receivedDate.Checked = true;
            this.dateTimePicker_receivedDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_receivedDate.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_receivedDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_receivedDate.Location = new System.Drawing.Point(37, 151);
            this.dateTimePicker_receivedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_receivedDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_receivedDate.Name = "dateTimePicker_receivedDate";
            this.dateTimePicker_receivedDate.Size = new System.Drawing.Size(312, 36);
            this.dateTimePicker_receivedDate.TabIndex = 94;
            this.dateTimePicker_receivedDate.Value = new System.DateTime(2023, 5, 6, 0, 46, 35, 284);
            // 
            // textBox_totalCost
            // 
            this.textBox_totalCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_totalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_totalCost.DefaultText = "";
            this.textBox_totalCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_totalCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_totalCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_totalCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_totalCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_totalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_totalCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_totalCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_totalCost.Location = new System.Drawing.Point(475, 231);
            this.textBox_totalCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_totalCost.Name = "textBox_totalCost";
            this.textBox_totalCost.PasswordChar = '\0';
            this.textBox_totalCost.PlaceholderText = "";
            this.textBox_totalCost.SelectedText = "";
            this.textBox_totalCost.Size = new System.Drawing.Size(312, 36);
            this.textBox_totalCost.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(472, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Total Cost";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_quantity.DefaultText = "";
            this.textBox_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantity.Location = new System.Drawing.Point(475, 151);
            this.textBox_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.PasswordChar = '\0';
            this.textBox_quantity.PlaceholderText = "";
            this.textBox_quantity.SelectedText = "";
            this.textBox_quantity.Size = new System.Drawing.Size(312, 36);
            this.textBox_quantity.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(472, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Quantity";
            // 
            // textBox_receivedFrom
            // 
            this.textBox_receivedFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_receivedFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_receivedFrom.DefaultText = "";
            this.textBox_receivedFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_receivedFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_receivedFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_receivedFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_receivedFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_receivedFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_receivedFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_receivedFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_receivedFrom.Location = new System.Drawing.Point(37, 231);
            this.textBox_receivedFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_receivedFrom.Name = "textBox_receivedFrom";
            this.textBox_receivedFrom.PasswordChar = '\0';
            this.textBox_receivedFrom.PlaceholderText = "";
            this.textBox_receivedFrom.SelectedText = "";
            this.textBox_receivedFrom.Size = new System.Drawing.Size(312, 36);
            this.textBox_receivedFrom.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Received From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Received Date";
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.LinkColor = System.Drawing.SystemColors.GrayText;
            this.loginBtn.Location = new System.Drawing.Point(392, 716);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(54, 18);
            this.loginBtn.TabIndex = 86;
            this.loginBtn.TabStop = true;
            this.loginBtn.Text = "Cancel";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.loginLabel.Location = new System.Drawing.Point(281, 44);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(266, 39);
            this.loginLabel.TabIndex = 84;
            this.loginLabel.Text = "Receipt Details";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_submit
            // 
            this.button_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.button_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(298, 636);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(242, 45);
            this.button_submit.TabIndex = 102;
            this.button_submit.Text = "Submit";
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // ReceiptDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(820, 760);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_productName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_receivedItemList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePicker_receivedDate);
            this.Controls.Add(this.textBox_totalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_receivedFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptDetailsForm";
            this.Text = "ReceiptDetailsForm";
            this.Load += new System.EventHandler(this.ReceiptDetailsForm_Load);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_receivedItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_productName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_receivedItemList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_receivedDate;
        private Guna.UI2.WinForms.Guna2TextBox textBox_totalCost;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_quantity;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_receivedFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel loginBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private Guna.UI2.WinForms.Guna2Button button_submit;
    }
}