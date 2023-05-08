
namespace DistributionManagementWinForm.home.Inventory
{
    partial class DeliveryDetailsForm
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
            this.button_submit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_deliveriedItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker_receivedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_deliMethod = new System.Windows.Forms.Label();
            this.label_resellerName = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deliveriedItems)).BeginInit();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
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
            this.button_submit.Location = new System.Drawing.Point(293, 687);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(242, 45);
            this.button_submit.TabIndex = 119;
            this.button_submit.Text = "Submit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 1);
            this.panel2.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 30);
            this.label5.TabIndex = 115;
            this.label5.Text = "Delivery Information";
            // 
            // dataGridView_deliveriedItems
            // 
            this.dataGridView_deliveriedItems.AllowUserToAddRows = false;
            this.dataGridView_deliveriedItems.AllowUserToDeleteRows = false;
            this.dataGridView_deliveriedItems.AllowUserToOrderColumns = true;
            this.dataGridView_deliveriedItems.AllowUserToResizeRows = false;
            this.dataGridView_deliveriedItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_deliveriedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_deliveriedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_deliveriedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_deliveriedItems.Location = new System.Drawing.Point(32, 382);
            this.dataGridView_deliveriedItems.Name = "dataGridView_deliveriedItems";
            this.dataGridView_deliveriedItems.ReadOnly = true;
            this.dataGridView_deliveriedItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.dataGridView_deliveriedItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_deliveriedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_deliveriedItems.Size = new System.Drawing.Size(750, 288);
            this.dataGridView_deliveriedItems.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(32, 374);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 1);
            this.panel1.TabIndex = 113;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label17.Location = new System.Drawing.Point(27, 340);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 30);
            this.label17.TabIndex = 112;
            this.label17.Text = "Deliveried Items";
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
            this.dateTimePicker_receivedDate.Location = new System.Drawing.Point(32, 278);
            this.dateTimePicker_receivedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_receivedDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_receivedDate.Name = "dateTimePicker_receivedDate";
            this.dateTimePicker_receivedDate.Size = new System.Drawing.Size(255, 36);
            this.dateTimePicker_receivedDate.TabIndex = 111;
            this.dateTimePicker_receivedDate.Value = new System.DateTime(2023, 5, 6, 0, 46, 35, 284);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(671, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Reseller Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(710, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(679, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Deliveried To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(28, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Deliveried Date";
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.LinkColor = System.Drawing.SystemColors.GrayText;
            this.loginBtn.Location = new System.Drawing.Point(387, 767);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(54, 18);
            this.loginBtn.TabIndex = 103;
            this.loginBtn.TabStop = true;
            this.loginBtn.Text = "Cancel";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.loginLabel.Location = new System.Drawing.Point(275, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(276, 39);
            this.loginLabel.TabIndex = 120;
            this.loginLabel.Text = "Delivery Details";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dragPanel.TabIndex = 121;
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
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(28, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 122;
            this.label6.Text = "Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(28, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 123;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 124;
            this.label8.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(28, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 125;
            this.label9.Text = "Delivery Method:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_name.Location = new System.Drawing.Point(92, 135);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(96, 20);
            this.label_name.TabIndex = 126;
            this.label_name.Text = "Duy Nguyen";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_email.Location = new System.Drawing.Point(84, 165);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(192, 20);
            this.label_email.TabIndex = 127;
            this.label_email.Text = "duynguyen@example.com";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_phone.Location = new System.Drawing.Point(153, 195);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(89, 20);
            this.label_phone.TabIndex = 128;
            this.label_phone.Text = "0902529803";
            // 
            // label_deliMethod
            // 
            this.label_deliMethod.AutoSize = true;
            this.label_deliMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deliMethod.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_deliMethod.Location = new System.Drawing.Point(163, 225);
            this.label_deliMethod.Name = "label_deliMethod";
            this.label_deliMethod.Size = new System.Drawing.Size(136, 20);
            this.label_deliMethod.TabIndex = 129;
            this.label_deliMethod.Text = "Standard Shipping";
            // 
            // label_resellerName
            // 
            this.label_resellerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_resellerName.AutoSize = true;
            this.label_resellerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resellerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_resellerName.Location = new System.Drawing.Point(701, 165);
            this.label_resellerName.Name = "label_resellerName";
            this.label_resellerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_resellerName.Size = new System.Drawing.Size(76, 20);
            this.label_resellerName.TabIndex = 130;
            this.label_resellerName.Text = "Reseller A";
            // 
            // label_address
            // 
            this.label_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_address.Location = new System.Drawing.Point(632, 225);
            this.label_address.Name = "label_address";
            this.label_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_address.Size = new System.Drawing.Size(145, 20);
            this.label_address.TabIndex = 131;
            this.label_address.Text = "123 Oak St, Cali USA";
            // 
            // label_quantity
            // 
            this.label_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_quantity.Location = new System.Drawing.Point(752, 285);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_quantity.Size = new System.Drawing.Size(25, 20);
            this.label_quantity.TabIndex = 132;
            this.label_quantity.Text = "20";
            // 
            // DeliveryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(820, 800);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_resellerName);
            this.Controls.Add(this.label_deliMethod);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_deliveriedItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePicker_receivedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeliveryDetailsForm";
            this.Text = "DeliveryDetailsForm";
            this.Load += new System.EventHandler(this.DeliveryDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deliveriedItems)).EndInit();
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_deliveriedItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_receivedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel loginBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel dragPanel;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_deliMethod;
        private System.Windows.Forms.Label label_resellerName;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_quantity;
    }
}