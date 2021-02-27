using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diary.models;

namespace Diary
{
    public partial class Menu : Form
    {
        public Menu()
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

        public void UpdateContent()
        {
            Account account = Data.Accounts[Data.ChosenAccount];

            Text = $"{account.Name} - Diary";
            ChosenAccountDisplay.Text = $"You're using {account.Name}";

            Days.Items.Clear();
            if (account.Notes == null) { return; }
            foreach (Note note in account.Notes) { Days.Items.Add(note.Name); }
        }

        private void ChooseAccountButton_Click(object sender, EventArgs e)
        {
            if (Data.ChoosingAccount) { return; }

            Account_choose chooseAcc = new Account_choose(this);
            chooseAcc.Show(); 
            Data.ChoosingAccount = true;
        }

        private void ReadEditButton_Click(object sender, EventArgs e)
        {
            if (Days.SelectedItems.Count <= 0) { return; }

            Account account = Data.Accounts[Data.ChosenAccount];
            int selected = Days.Items.IndexOf(Days.SelectedItems[0]);
            Note selectedNote = account.Notes[selected];

            Note_edit editNote = new Note_edit(
                $"You're using {account.Name}, {selectedNote.Name}",
                selectedNote.Content,
                selectedNote.Day,
                selected
            );
            editNote.Show();
        }

        private void NewDayButton_Click(object sender, EventArgs e)
        {
            Account account = Data.Accounts[Data.ChosenAccount];

            if (NewNoteName.Text == "" || NewNoteName.Text.Length > 75) { return; }
            if (account.Notes == null) { account.Notes = new List<Note>(); }

            account.Notes.Add(
                new Note { Name = NewNoteName.Text, Content = " ", Day = DateTime.Now });

            NewNoteName.Text = "";
            Days.Items.Clear();
            foreach (Note note in account.Notes) { Days.Items.Add(note.Name); }
        }
    }
}
