using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diary.models;

namespace Diary
{
    public partial class Account_choose : Form
    {
        public Menu Menu;

        public Account_choose(Menu form1)
        {
            InitializeComponent();
            Menu = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Data.Accounts == null) { return; }

            AccountsView.Items.Clear();
            foreach (var account in Data.Accounts) { AccountsView.Items.Add(account.Name); }

            NumberOfAccounts.Text = $"You have {Data.Accounts.Count}{(Data.Accounts.Count >= 80 ? " / 100" : "")} profiles";
        }

        private void SubmitNewAccount_Click(object sender, EventArgs e)
        {
            if (Data.Accounts.Count >= 100 || NewAccountName.Text == "") { return; }
            if (Data.Accounts == null) { Data.Accounts = new List<Account>(); }

            Data.Accounts.Add(
                new Account { Name = NewAccountName.Text });

            NewAccountName.Text = "";
            AccountsView.Items.Clear();
            foreach (Account account in Data.Accounts) { AccountsView.Items.Add(account.Name); }

            NumberOfAccounts.Text = $"You have {Data.Accounts.Count}{(Data.Accounts.Count >= 80 ? " / 100" : "")} profiles";
        }

        private void ChoseAccountButton_Click(object sender, EventArgs e)
        {
            if (AccountsView.SelectedItems.Count == 0) { return; }

            Data.ChoosingAccount = false;
            UpdateForm1();
            Close();
        }

        private void Form2_FormClosing(object sender, EventArgs e)
        {
            Data.ChoosingAccount = false;
            UpdateForm1();
        }

        public void UpdateForm1()
        {
            Data.ChosenAccount = AccountsView.Items.IndexOf(AccountsView.SelectedItems[0]);
            Menu.UpdateContent();
        }
    }
}
