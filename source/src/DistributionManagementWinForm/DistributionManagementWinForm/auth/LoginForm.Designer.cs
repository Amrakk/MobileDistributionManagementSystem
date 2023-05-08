
namespace DistributionManagementWinForm.auth
{
    partial class LoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.logoBox = new FontAwesome.Sharp.IconPictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passPanel = new System.Windows.Forms.Panel();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.passPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(123, 12);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(106, 39);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dragPanel.Size = new System.Drawing.Size(344, 30);
            this.dragPanel.TabIndex = 10;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 20;
            this.closeBtn.Location = new System.Drawing.Point(320, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.SystemColors.Window;
            this.logoBox.BackgroundImage = global::DistributionManagementWinForm.Properties.Resources.logo_no_background;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.logoBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.logoBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoBox.IconSize = 109;
            this.logoBox.Location = new System.Drawing.Point(0, 30);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(344, 109);
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Window;
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passPanel);
            this.loginPanel.Controls.Add(this.userPanel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.ForeColor = System.Drawing.Color.Black;
            this.loginPanel.Location = new System.Drawing.Point(0, 139);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(344, 361);
            this.loginPanel.TabIndex = 10;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 3;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.loginBtn.Location = new System.Drawing.Point(75, 224);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(203, 51);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // passPanel
            // 
            this.passPanel.Controls.Add(this.passTextBox);
            this.passPanel.Controls.Add(this.panel6);
            this.passPanel.Controls.Add(this.passIcon);
            this.passPanel.Location = new System.Drawing.Point(20, 136);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(312, 34);
            this.passPanel.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.White;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passTextBox.Location = new System.Drawing.Point(32, 3);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(280, 20);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.Text = "Password";
            this.passTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passTextBox_MouseClick);
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            this.passTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTextBox_KeyDown);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel6.Location = new System.Drawing.Point(32, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 2);
            this.panel6.TabIndex = 10;
            // 
            // passIcon
            // 
            this.passIcon.BackColor = System.Drawing.Color.White;
            this.passIcon.ForeColor = System.Drawing.Color.Black;
            this.passIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passIcon.IconColor = System.Drawing.Color.Black;
            this.passIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passIcon.IconSize = 27;
            this.passIcon.Location = new System.Drawing.Point(0, 0);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(27, 27);
            this.passIcon.TabIndex = 3;
            this.passIcon.TabStop = false;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userTextBox);
            this.userPanel.Controls.Add(this.panel3);
            this.userPanel.Controls.Add(this.userIcon);
            this.userPanel.Location = new System.Drawing.Point(20, 70);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(312, 34);
            this.userPanel.TabIndex = 1;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.White;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.Gray;
            this.userTextBox.Location = new System.Drawing.Point(32, 3);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(280, 20);
            this.userTextBox.TabIndex = 1;
            this.userTextBox.Text = "Username";
            this.userTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userTextBox_MouseClick);
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            this.userTextBox.Leave += new System.EventHandler(this.userTextBox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(32, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 2);
            this.panel3.TabIndex = 10;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.White;
            this.userIcon.ForeColor = System.Drawing.Color.Black;
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.userIcon.IconColor = System.Drawing.Color.Black;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 27;
            this.userIcon.Location = new System.Drawing.Point(-1, -1);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(27, 27);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 2;
            this.userIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(344, 500);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passPanel.ResumeLayout(false);
            this.passPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel dragPanel;
        private FontAwesome.Sharp.IconPictureBox logoBox;
        private System.Windows.Forms.Panel loginPanel;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private FontAwesome.Sharp.IconPictureBox passIcon;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel passPanel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button loginBtn;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}