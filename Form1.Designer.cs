
namespace Diary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChooseAccountButton = new System.Windows.Forms.Button();
            this.ChosenAccountDisplay = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.ListView();
            this.NotesTextDisplay = new System.Windows.Forms.Label();
            this.ReadEditButton = new System.Windows.Forms.Button();
            this.NewDayButton = new System.Windows.Forms.Button();
            this.NewNoteName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseAccountButton
            // 
            this.ChooseAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChooseAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChooseAccountButton.FlatAppearance.BorderSize = 2;
            this.ChooseAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChooseAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChooseAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseAccountButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseAccountButton.ForeColor = System.Drawing.Color.White;
            this.ChooseAccountButton.Location = new System.Drawing.Point(12, 27);
            this.ChooseAccountButton.Name = "ChooseAccountButton";
            this.ChooseAccountButton.Size = new System.Drawing.Size(850, 50);
            this.ChooseAccountButton.TabIndex = 4;
            this.ChooseAccountButton.Text = "Choose profile";
            this.ChooseAccountButton.UseVisualStyleBackColor = false;
            this.ChooseAccountButton.Click += new System.EventHandler(this.ChooseAccountButton_Click);
            // 
            // ChosenAccountDisplay
            // 
            this.ChosenAccountDisplay.AutoSize = true;
            this.ChosenAccountDisplay.ForeColor = System.Drawing.Color.White;
            this.ChosenAccountDisplay.Location = new System.Drawing.Point(18, 9);
            this.ChosenAccountDisplay.Name = "ChosenAccountDisplay";
            this.ChosenAccountDisplay.Size = new System.Drawing.Size(162, 15);
            this.ChosenAccountDisplay.TabIndex = 5;
            this.ChosenAccountDisplay.Text = "You haven\'t chose profile yet.";
            // 
            // Days
            // 
            this.Days.BackColor = System.Drawing.Color.Black;
            this.Days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Days.ForeColor = System.Drawing.Color.White;
            this.Days.HideSelection = false;
            this.Days.Location = new System.Drawing.Point(12, 117);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(850, 289);
            this.Days.TabIndex = 6;
            this.Days.UseCompatibleStateImageBehavior = false;
            // 
            // NotesTextDisplay
            // 
            this.NotesTextDisplay.AutoSize = true;
            this.NotesTextDisplay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesTextDisplay.ForeColor = System.Drawing.Color.White;
            this.NotesTextDisplay.Location = new System.Drawing.Point(13, 84);
            this.NotesTextDisplay.Name = "NotesTextDisplay";
            this.NotesTextDisplay.Size = new System.Drawing.Size(75, 30);
            this.NotesTextDisplay.TabIndex = 7;
            this.NotesTextDisplay.Text = "Notes:";
            // 
            // ReadEditButton
            // 
            this.ReadEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReadEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ReadEditButton.FlatAppearance.BorderSize = 2;
            this.ReadEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReadEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReadEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadEditButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadEditButton.ForeColor = System.Drawing.Color.White;
            this.ReadEditButton.Location = new System.Drawing.Point(197, 454);
            this.ReadEditButton.Name = "ReadEditButton";
            this.ReadEditButton.Size = new System.Drawing.Size(665, 41);
            this.ReadEditButton.TabIndex = 8;
            this.ReadEditButton.Text = "Read/edit selected";
            this.ReadEditButton.UseVisualStyleBackColor = false;
            this.ReadEditButton.Click += new System.EventHandler(this.ReadEditButton_Click);
            // 
            // NewDayButton
            // 
            this.NewDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NewDayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewDayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewDayButton.FlatAppearance.BorderSize = 2;
            this.NewDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NewDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NewDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDayButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewDayButton.ForeColor = System.Drawing.Color.White;
            this.NewDayButton.Location = new System.Drawing.Point(12, 454);
            this.NewDayButton.Name = "NewDayButton";
            this.NewDayButton.Size = new System.Drawing.Size(179, 41);
            this.NewDayButton.TabIndex = 9;
            this.NewDayButton.Text = "Add note";
            this.NewDayButton.UseVisualStyleBackColor = false;
            this.NewDayButton.Click += new System.EventHandler(this.NewDayButton_Click);
            // 
            // NewNoteName
            // 
            this.NewNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNoteName.BackColor = System.Drawing.Color.White;
            this.NewNoteName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewNoteName.ForeColor = System.Drawing.Color.Black;
            this.NewNoteName.Location = new System.Drawing.Point(13, 412);
            this.NewNoteName.Name = "NewNoteName";
            this.NewNoteName.PlaceholderText = "New note name...";
            this.NewNoteName.Size = new System.Drawing.Size(849, 36);
            this.NewNoteName.TabIndex = 10;
            this.NewNoteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 507);
            this.Controls.Add(this.NewNoteName);
            this.Controls.Add(this.NewDayButton);
            this.Controls.Add(this.ReadEditButton);
            this.Controls.Add(this.NotesTextDisplay);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.ChosenAccountDisplay);
            this.Controls.Add(this.ChooseAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChooseAccountButton;
        private System.Windows.Forms.Label ChosenAccountDisplay;
        private System.Windows.Forms.ListView Days;
        private System.Windows.Forms.Label NotesTextDisplay;
        private System.Windows.Forms.Button ReadEditButton;
        private System.Windows.Forms.Button NewDayButton;
        private System.Windows.Forms.TextBox NewNoteName;
    }
}

