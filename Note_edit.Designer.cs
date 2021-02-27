
namespace Diary
{
    partial class Note_edit
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
            this.PathDisplay = new System.Windows.Forms.Label();
            this.NotesEditDisplay = new System.Windows.Forms.TextBox();
            this.DateDisplay = new System.Windows.Forms.Label();
            this.ExitEditingButton = new System.Windows.Forms.Button();
            this.SaveDiaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathDisplay
            // 
            this.PathDisplay.AutoSize = true;
            this.PathDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathDisplay.ForeColor = System.Drawing.Color.White;
            this.PathDisplay.Location = new System.Drawing.Point(13, 13);
            this.PathDisplay.Name = "PathDisplay";
            this.PathDisplay.Size = new System.Drawing.Size(136, 15);
            this.PathDisplay.TabIndex = 0;
            this.PathDisplay.Text = "Diary -> Profile? -> Day?";
            // 
            // NotesEditDisplay
            // 
            this.NotesEditDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesEditDisplay.BackColor = System.Drawing.Color.White;
            this.NotesEditDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesEditDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotesEditDisplay.Location = new System.Drawing.Point(13, 32);
            this.NotesEditDisplay.MaxLength = 100000;
            this.NotesEditDisplay.Multiline = true;
            this.NotesEditDisplay.Name = "NotesEditDisplay";
            this.NotesEditDisplay.PlaceholderText = "Your notes...";
            this.NotesEditDisplay.Size = new System.Drawing.Size(775, 360);
            this.NotesEditDisplay.TabIndex = 1;
            // 
            // DateDisplay
            // 
            this.DateDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDisplay.AutoSize = true;
            this.DateDisplay.ForeColor = System.Drawing.Color.White;
            this.DateDisplay.Location = new System.Drawing.Point(735, 9);
            this.DateDisplay.Name = "DateDisplay";
            this.DateDisplay.Size = new System.Drawing.Size(53, 15);
            this.DateDisplay.TabIndex = 2;
            this.DateDisplay.Text = "??.??.????";
            // 
            // ExitEditingButton
            // 
            this.ExitEditingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitEditingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitEditingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitEditingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitEditingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitEditingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitEditingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitEditingButton.ForeColor = System.Drawing.Color.White;
            this.ExitEditingButton.Location = new System.Drawing.Point(13, 398);
            this.ExitEditingButton.Name = "ExitEditingButton";
            this.ExitEditingButton.Size = new System.Drawing.Size(268, 40);
            this.ExitEditingButton.TabIndex = 3;
            this.ExitEditingButton.Text = "<- Exit";
            this.ExitEditingButton.UseVisualStyleBackColor = false;
            this.ExitEditingButton.Click += new System.EventHandler(this.ExitEditingButton_Click);
            // 
            // SaveDiaryButton
            // 
            this.SaveDiaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDiaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveDiaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveDiaryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveDiaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveDiaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveDiaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDiaryButton.ForeColor = System.Drawing.Color.White;
            this.SaveDiaryButton.Location = new System.Drawing.Point(287, 398);
            this.SaveDiaryButton.Name = "SaveDiaryButton";
            this.SaveDiaryButton.Size = new System.Drawing.Size(501, 40);
            this.SaveDiaryButton.TabIndex = 4;
            this.SaveDiaryButton.Text = "Save";
            this.SaveDiaryButton.UseVisualStyleBackColor = false;
            this.SaveDiaryButton.Click += new System.EventHandler(this.SaveDiaryButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveDiaryButton);
            this.Controls.Add(this.ExitEditingButton);
            this.Controls.Add(this.DateDisplay);
            this.Controls.Add(this.NotesEditDisplay);
            this.Controls.Add(this.PathDisplay);
            this.Name = "Form3";
            this.Text = "Diary - read, edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathDisplay;
        private System.Windows.Forms.TextBox NotesEditDisplay;
        private System.Windows.Forms.Label DateDisplay;
        private System.Windows.Forms.Button ExitEditingButton;
        private System.Windows.Forms.Button SaveDiaryButton;
    }
}