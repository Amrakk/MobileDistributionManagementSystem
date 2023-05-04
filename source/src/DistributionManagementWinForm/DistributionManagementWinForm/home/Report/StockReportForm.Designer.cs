
namespace DistributionManagementWinForm.home.Report
{
    partial class StockReportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
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
            this.panelAccount.Controls.Add(this.productGridView);
            this.panelAccount.Controls.Add(this.label2);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(1170, 800);
            this.panelAccount.TabIndex = 8;
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
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(60, 110);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.Size = new System.Drawing.Size(1050, 550);
            this.productGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Report";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 800);
            this.Controls.Add(this.panelAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockReportForm";
            this.Text = "Stock Report";
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Label label2;
    }
}