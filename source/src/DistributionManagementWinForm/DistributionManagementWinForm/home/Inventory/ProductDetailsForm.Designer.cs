
namespace DistributionManagementWinForm.home.Inventory
{
    partial class ProductDetailsForm
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
            this.dragPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.richTextBox_productDescription = new System.Windows.Forms.RichTextBox();
            this.loginBtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_model = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_productQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_submit = new Guna.UI2.WinForms.Guna2Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.loginPanel.SuspendLayout();
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
            this.dragPanel.TabIndex = 8;
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
            this.closeBtn.Location = new System.Drawing.Point(800, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.loginLabel.Location = new System.Drawing.Point(275, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(274, 47);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Product Details";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_productDescription
            // 
            this.richTextBox_productDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox_productDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_productDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox_productDescription.Location = new System.Drawing.Point(462, 104);
            this.richTextBox_productDescription.Name = "richTextBox_productDescription";
            this.richTextBox_productDescription.Size = new System.Drawing.Size(312, 94);
            this.richTextBox_productDescription.TabIndex = 13;
            this.richTextBox_productDescription.Text = "";
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.LinkColor = System.Drawing.SystemColors.GrayText;
            this.loginBtn.Location = new System.Drawing.Point(592, 327);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(53, 20);
            this.loginBtn.TabIndex = 16;
            this.loginBtn.TabStop = true;
            this.loginBtn.Text = "Cancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Name";
            // 
            // textBox_productName
            // 
            this.textBox_productName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_productName.DefaultText = "";
            this.textBox_productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_productName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_productName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productName.Location = new System.Drawing.Point(53, 102);
            this.textBox_productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.PasswordChar = '\0';
            this.textBox_productName.PlaceholderText = "";
            this.textBox_productName.SelectedText = "";
            this.textBox_productName.Size = new System.Drawing.Size(312, 36);
            this.textBox_productName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(50, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Model";
            // 
            // textBox_model
            // 
            this.textBox_model.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_model.DefaultText = "";
            this.textBox_model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_model.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_model.Location = new System.Drawing.Point(53, 184);
            this.textBox_model.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.PasswordChar = '\0';
            this.textBox_model.PlaceholderText = "";
            this.textBox_model.SelectedText = "";
            this.textBox_model.Size = new System.Drawing.Size(312, 36);
            this.textBox_model.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(50, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Price";
            // 
            // textBox_productPrice
            // 
            this.textBox_productPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_productPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_productPrice.DefaultText = "";
            this.textBox_productPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_productPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_productPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_productPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_productPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productPrice.Location = new System.Drawing.Point(53, 266);
            this.textBox_productPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_productPrice.Name = "textBox_productPrice";
            this.textBox_productPrice.PasswordChar = '\0';
            this.textBox_productPrice.PlaceholderText = "";
            this.textBox_productPrice.SelectedText = "";
            this.textBox_productPrice.Size = new System.Drawing.Size(312, 36);
            this.textBox_productPrice.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(50, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Quantity";
            // 
            // textBox_productQuantity
            // 
            this.textBox_productQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.textBox_productQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_productQuantity.DefaultText = "";
            this.textBox_productQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_productQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_productQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_productQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_productQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_productQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_productQuantity.Location = new System.Drawing.Point(53, 346);
            this.textBox_productQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_productQuantity.Name = "textBox_productQuantity";
            this.textBox_productQuantity.PasswordChar = '\0';
            this.textBox_productQuantity.PlaceholderText = "";
            this.textBox_productQuantity.SelectedText = "";
            this.textBox_productQuantity.Size = new System.Drawing.Size(312, 36);
            this.textBox_productQuantity.TabIndex = 25;
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
            this.button_submit.Location = new System.Drawing.Point(462, 245);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(312, 57);
            this.button_submit.TabIndex = 26;
            this.button_submit.Text = "Submit";
            this.button_submit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            this.label_status.Location = new System.Drawing.Point(649, 418);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(126, 32);
            this.label_status.TabIndex = 27;
            this.label_status.Text = "Creating...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(458, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Description";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Window;
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.label_status);
            this.loginPanel.Controls.Add(this.button_submit);
            this.loginPanel.Controls.Add(this.textBox_productQuantity);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.textBox_productPrice);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.textBox_model);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.textBox_productName);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.richTextBox_productDescription);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.ForeColor = System.Drawing.Color.Black;
            this.loginPanel.Location = new System.Drawing.Point(0, 30);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(820, 495);
            this.loginPanel.TabIndex = 9;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 525);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDetailsForm";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.ProductDetailsForm_Load);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.RichTextBox richTextBox_productDescription;
        private System.Windows.Forms.LinkLabel loginBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_productName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_model;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_productPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_productQuantity;
        private Guna.UI2.WinForms.Guna2Button button_submit;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel loginPanel;
    }
}