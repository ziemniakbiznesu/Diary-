
namespace Diary
{
    partial class Form2
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
            this.NewAccountName = new System.Windows.Forms.TextBox();
            this.SubmitNewAccount = new System.Windows.Forms.Button();
            this.NumberOfAccounts = new System.Windows.Forms.Label();
            this.AccountsView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoseAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAccountName
            // 
            this.NewAccountName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewAccountName.ForeColor = System.Drawing.Color.Black;
            this.NewAccountName.Location = new System.Drawing.Point(12, 42);
            this.NewAccountName.MaxLength = 9;
            this.NewAccountName.Name = "NewAccountName";
            this.NewAccountName.PlaceholderText = "Your name...";
            this.NewAccountName.Size = new System.Drawing.Size(560, 36);
            this.NewAccountName.TabIndex = 1;
            this.NewAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubmitNewAccount
            // 
            this.SubmitNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SubmitNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitNewAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitNewAccount.FlatAppearance.BorderSize = 2;
            this.SubmitNewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SubmitNewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SubmitNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitNewAccount.ForeColor = System.Drawing.Color.White;
            this.SubmitNewAccount.Location = new System.Drawing.Point(12, 84);
            this.SubmitNewAccount.Name = "SubmitNewAccount";
            this.SubmitNewAccount.Size = new System.Drawing.Size(560, 36);
            this.SubmitNewAccount.TabIndex = 2;
            this.SubmitNewAccount.Text = "Submit";
            this.SubmitNewAccount.UseVisualStyleBackColor = false;
            this.SubmitNewAccount.Click += new System.EventHandler(this.SubmitNewAccount_Click);
            // 
            // NumberOfAccounts
            // 
            this.NumberOfAccounts.AutoSize = true;
            this.NumberOfAccounts.BackColor = System.Drawing.Color.Black;
            this.NumberOfAccounts.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfAccounts.ForeColor = System.Drawing.Color.White;
            this.NumberOfAccounts.Location = new System.Drawing.Point(12, 9);
            this.NumberOfAccounts.Name = "NumberOfAccounts";
            this.NumberOfAccounts.Size = new System.Drawing.Size(253, 30);
            this.NumberOfAccounts.TabIndex = 3;
            this.NumberOfAccounts.Text = "You have 0 / 250 profiles\r\n";
            // 
            // AccountsView
            // 
            this.AccountsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsView.BackColor = System.Drawing.Color.Black;
            this.AccountsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountsView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountsView.ForeColor = System.Drawing.Color.White;
            this.AccountsView.HideSelection = false;
            this.AccountsView.Location = new System.Drawing.Point(12, 156);
            this.AccountsView.Name = "AccountsView";
            this.AccountsView.Size = new System.Drawing.Size(560, 97);
            this.AccountsView.TabIndex = 4;
            this.AccountsView.UseCompatibleStateImageBehavior = false;
            this.AccountsView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profiles: ";
            // 
            // ChoseAccountButton
            // 
            this.ChoseAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoseAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChoseAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoseAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChoseAccountButton.FlatAppearance.BorderSize = 2;
            this.ChoseAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChoseAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChoseAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoseAccountButton.ForeColor = System.Drawing.Color.White;
            this.ChoseAccountButton.Location = new System.Drawing.Point(12, 273);
            this.ChoseAccountButton.Name = "ChoseAccountButton";
            this.ChoseAccountButton.Size = new System.Drawing.Size(560, 36);
            this.ChoseAccountButton.TabIndex = 6;
            this.ChoseAccountButton.Text = "Continue";
            this.ChoseAccountButton.UseVisualStyleBackColor = false;
            this.ChoseAccountButton.Click += new System.EventHandler(this.ChoseAccountButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.ChoseAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountsView);
            this.Controls.Add(this.NumberOfAccounts);
            this.Controls.Add(this.SubmitNewAccount);
            this.Controls.Add(this.NewAccountName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Choose profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NewAccountName;
        private System.Windows.Forms.Button SubmitNewAccount;
        private System.Windows.Forms.Label NumberOfAccounts;
        private System.Windows.Forms.ListView AccountsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChoseAccountButton;
    }
}