
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
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.button1);
            this.panelAccount.Controls.Add(this.textBox1);
            this.panelAccount.Controls.Add(this.btn_DeleteAccount);
            this.panelAccount.Controls.Add(this.btn_EditAccount);
            this.panelAccount.Controls.Add(this.btn_CreateAccount);
            this.panelAccount.Controls.Add(this.panel3);
            this.panelAccount.Controls.Add(this.accountGridView);
            this.panelAccount.Controls.Add(this.label2);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(1170, 800);
            this.panelAccount.TabIndex = 6;
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Location = new System.Drawing.Point(525, 700);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(175, 40);
            this.btn_DeleteAccount.TabIndex = 6;
            this.btn_DeleteAccount.Text = "Delete";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Location = new System.Drawing.Point(730, 700);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(175, 40);
            this.btn_EditAccount.TabIndex = 5;
            this.btn_EditAccount.Text = "Edit";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Location = new System.Drawing.Point(935, 700);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(175, 40);
            this.btn_CreateAccount.TabIndex = 4;
            this.btn_CreateAccount.Text = "Create";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
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
            // accountGridView
            // 
            this.accountGridView.AllowUserToAddRows = false;
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGridView.Location = new System.Drawing.Point(60, 110);
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.Size = new System.Drawing.Size(1050, 550);
            this.accountGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(60, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(925, 24);
            this.textBox1.TabIndex = 12;
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
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}