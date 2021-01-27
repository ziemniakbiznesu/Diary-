using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class Form1 : Form
    {

        public void UpdateContent()
        {
            Text = $"{Data.accounts[Data.chosenAccount].name} - Diary";
            ChosenAccountDisplay.Text = $"You're using {Data.accounts[Data.chosenAccount].name}";

            Days.Items.Clear();
            if (Data.accounts[Data.chosenAccount].notes == null) return;
            foreach (Note note in Data.accounts[Data.chosenAccount].notes) Days.Items.Add(note.name);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Load();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Data.Save();
        }

        private void ChooseAccountButton_Click(object sender, EventArgs e)
        {
            if (Data.choosingAccount) return;

            Form2 choose = new Form2(this);
            choose.Show();
            Data.choosingAccount = true;
        }

        private void ReadEditButton_Click(object sender, EventArgs e)
        {
            if (Days.SelectedItems.Count == 0) return;

            Form3 edit = new Form3(
                $"Diary -> {Data.accounts[Data.chosenAccount].name} -> {Data.accounts[Data.chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].name}",
                Data.accounts[Data.chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].content,
                Data.accounts[Data.chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].day,
                Days.Items.IndexOf(Days.SelectedItems[0])
            );
            edit.Show();
        }

        private void NewDayButton_Click(object sender, EventArgs e)
        {
            if (NewNoteName.Text == "" || NewNoteName.Text.Length > 75) return;

            if (Data.accounts[Data.chosenAccount].notes == null)
                Data.accounts[Data.chosenAccount].notes = new List<Note> {
                    new Note { name = NewNoteName.Text, content = " ", day = DateTime.Now }};
            else
                Data.accounts[Data.chosenAccount].notes.Add(
                     new Note { name = NewNoteName.Text, content = " ", day = DateTime.Now });

            NewNoteName.Text = "";
            Days.Items.Clear();
            foreach(Note note in Data.accounts[Data.chosenAccount].notes) Days.Items.Add(note.name);
        }
    }
}
