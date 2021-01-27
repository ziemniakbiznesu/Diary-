using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diary
{
    public partial class Form2 : Form
    {
        public Form1 menu;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            menu = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Data.accounts == null) return;

            AccountsView.Items.Clear();
            foreach (var account in Data.accounts) AccountsView.Items.Add(account.name);

            NumberOfAccounts.Text = Data.accounts.Count < 80
                ? $"You have {Data.accounts.Count} profiles"
                : $"You have {Data.accounts.Count} / 100 profiles";
        }

        private void SubmitNewAccount_Click(object sender, EventArgs e)
        {
            if (Data.accounts == null) Data.accounts = new List<Account>();
            if (Data.accounts.Count >= 100 || NewAccountName.Text == "") return;
            
            Data.accounts.Add(
                new Account { name = NewAccountName.Text });

            NewAccountName.Text = "";
            AccountsView.Items.Clear();
            foreach (Account account in Data.accounts) AccountsView.Items.Add(account.name);

            NumberOfAccounts.Text = Data.accounts.Count < 80
                ? $"You have {Data.accounts.Count} profiles"
                : $"You have {Data.accounts.Count} / 100 profiles";
        }

        private void ChoseAccountButton_Click(object sender, EventArgs e)
        {
            if (AccountsView.SelectedItems.Count == 0) return;

            UpdateForm1();
            Close();
        }

        private void Form2_FormClosing(object sender, EventArgs e)
        {
            UpdateForm1();
            Data.choosingAccount = false;
        }

        public void UpdateForm1()
        {
            Data.chosenAccount = AccountsView.Items.IndexOf(AccountsView.SelectedItems[0]);
            menu.UpdateContent();
        }

    }
}
