
namespace DistributionManagementWinForm.home.Order
{
    partial class OrderDetailsForm
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
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_address = new System.Windows.Forms.Label();
            this.label_resellerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_orderDate = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_deliveryMethod = new System.Windows.Forms.Label();
            this.label_paymentMethod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label_orderId = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_statusName = new System.Windows.Forms.Label();
            this.dataGridView_productList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 27;
            this.closeBtn.Location = new System.Drawing.Point(630, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 27);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dragPanel.Size = new System.Drawing.Size(660, 38);
            this.dragPanel.TabIndex = 11;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(225, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(18, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 1);
            this.panel2.TabIndex = 67;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(464, 206);
            this.label_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(99, 21);
            this.label_address.TabIndex = 65;
            this.label_address.Text = "456 Broad St";
            // 
            // label_resellerName
            // 
            this.label_resellerName.AutoSize = true;
            this.label_resellerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resellerName.Location = new System.Drawing.Point(487, 172);
            this.label_resellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_resellerName.Name = "label_resellerName";
            this.label_resellerName.Size = new System.Drawing.Size(79, 21);
            this.label_resellerName.TabIndex = 64;
            this.label_resellerName.Text = "Reseller A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 63;
            this.label8.Text = "Order Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Shipped To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Reseller Name :";
            // 
            // label_orderDate
            // 
            this.label_orderDate.AutoSize = true;
            this.label_orderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderDate.Location = new System.Drawing.Point(464, 240);
            this.label_orderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_orderDate.Name = "label_orderDate";
            this.label_orderDate.Size = new System.Drawing.Size(94, 21);
            this.label_orderDate.TabIndex = 66;
            this.label_orderDate.Text = "30/04/2023";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNumber.Location = new System.Drawing.Point(150, 272);
            this.label_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(100, 21);
            this.label_phoneNumber.TabIndex = 60;
            this.label_phoneNumber.Text = "0904632382";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(78, 240);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(163, 21);
            this.label_email.TabIndex = 59;
            this.label_email.Text = "bobsmith@gmail.com";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(116, 206);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(51, 21);
            this.label_lastName.TabIndex = 58;
            this.label_lastName.Text = "Smith";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(118, 172);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(37, 21);
            this.label_firstName.TabIndex = 57;
            this.label_firstName.Text = "Bob";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Reseller Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "First Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 335);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 21);
            this.label14.TabIndex = 69;
            this.label14.Text = "Delivery Method :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 21);
            this.label13.TabIndex = 68;
            this.label13.Text = "Payment Method :";
            // 
            // label_deliveryMethod
            // 
            this.label_deliveryMethod.AutoSize = true;
            this.label_deliveryMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deliveryMethod.Location = new System.Drawing.Point(163, 335);
            this.label_deliveryMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deliveryMethod.Name = "label_deliveryMethod";
            this.label_deliveryMethod.Size = new System.Drawing.Size(138, 21);
            this.label_deliveryMethod.TabIndex = 70;
            this.label_deliveryMethod.Text = "Standard Shipping";
            // 
            // label_paymentMethod
            // 
            this.label_paymentMethod.AutoSize = true;
            this.label_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paymentMethod.Location = new System.Drawing.Point(166, 303);
            this.label_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentMethod.Name = "label_paymentMethod";
            this.label_paymentMethod.Size = new System.Drawing.Size(44, 21);
            this.label_paymentMethod.TabIndex = 71;
            this.label_paymentMethod.Text = "Cash";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(18, 418);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 1);
            this.panel1.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label17.Location = new System.Drawing.Point(13, 384);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 30);
            this.label17.TabIndex = 72;
            this.label17.Text = "Product Information";
            // 
            // label_orderId
            // 
            this.label_orderId.AutoSize = true;
            this.label_orderId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderId.Location = new System.Drawing.Point(14, 42);
            this.label_orderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_orderId.Name = "label_orderId";
            this.label_orderId.Size = new System.Drawing.Size(73, 21);
            this.label_orderId.TabIndex = 74;
            this.label_orderId.Text = "Order ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(447, 125);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 21);
            this.label19.TabIndex = 75;
            this.label19.Text = "Status :";
            // 
            // label_statusName
            // 
            this.label_statusName.AutoSize = true;
            this.label_statusName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_statusName.Location = new System.Drawing.Point(518, 125);
            this.label_statusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_statusName.Name = "label_statusName";
            this.label_statusName.Size = new System.Drawing.Size(88, 21);
            this.label_statusName.TabIndex = 76;
            this.label_statusName.Text = "Confirmed";
            // 
            // dataGridView_productList
            // 
            this.dataGridView_productList.AllowUserToAddRows = false;
            this.dataGridView_productList.AllowUserToResizeColumns = false;
            this.dataGridView_productList.AllowUserToResizeRows = false;
            this.dataGridView_productList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productList.Location = new System.Drawing.Point(18, 435);
            this.dataGridView_productList.Name = "dataGridView_productList";
            this.dataGridView_productList.RowHeadersVisible = false;
            this.dataGridView_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_productList.Size = new System.Drawing.Size(625, 236);
            this.dataGridView_productList.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 683);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 78;
            this.label9.Text = "Total Price :";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalPrice.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_totalPrice.Location = new System.Drawing.Point(512, 683);
            this.label_totalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(88, 21);
            this.label_totalPrice.TabIndex = 79;
            this.label_totalPrice.Text = "Confirmed";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(660, 745);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView_productList);
            this.Controls.Add(this.label_statusName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label_orderId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label_paymentMethod);
            this.Controls.Add(this.label_deliveryMethod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_resellerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_orderDate);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderDetailsForm";
            this.Text = "Order Note";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_resellerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_orderDate;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_deliveryMethod;
        private System.Windows.Forms.Label label_paymentMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_orderId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_statusName;
        private System.Windows.Forms.DataGridView dataGridView_productList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_totalPrice;
    }
}