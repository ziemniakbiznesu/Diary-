using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Diary
{
    public partial class Form3 : Form
    {
        readonly int id;

        public Form3(String title, String notes, DateTime day, int id)
        {
            InitializeComponent();
            PathDisplay.Text = title;

            DateDisplay.Text = day.Month < 10 
                ? $"{day.Day}.0{day.Month}.{day.Year}"
                : $"{day.Day}.{day.Month}.{day.Year}";

            NotesEditDisplay.Text = notes;
            this.id = id;
        }

        private void ExitEditingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveDiaryButton_Click(object sender, EventArgs e)
        {
            Form1.accounts[Form1.chosenAccount].notes[id].content = NotesEditDisplay.Text;
            Form1.SaveFile();
            this.Close();
        }
    }
}
