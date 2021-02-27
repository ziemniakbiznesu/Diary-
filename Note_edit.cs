using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.models;

namespace Diary
{
    public partial class Note_edit : Form
    {
        readonly int Id;

        public Note_edit(String Title, String Notes, DateTime Day, int Id)
        {
            InitializeComponent();
            PathDisplay.Text = Title;

            DateDisplay.Text = $"{Day.Day}.{(Day.Month < 10 ? "0" : "")}{Day.Month}.{Day.Year}";
            
            NotesEditDisplay.Text = Notes;
            this.Id = Id;
        }

        private void ExitEditingButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveDiaryButton_Click(object sender, EventArgs e)
        {
            Account account = Data.Accounts[Data.ChosenAccount];

            account.Notes[Id].Content = NotesEditDisplay.Text;
            Data.Save();
            Close();
        }
    }
}
