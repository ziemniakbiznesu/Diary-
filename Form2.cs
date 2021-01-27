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

        public Form2(Form1 tempForm1)
        {
            menu = tempForm1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AccountsView.Items.Clear();
            if (Data.accounts == null) return;
            foreach (var account in Data.accounts)
            {
                AccountsView.Items.Add(account.name);
            }

            NumberOfAccounts.Text = Data.accounts.Count < 80
                ? $"You have {Data.accounts.Count} profiles"
                : $"You have {Data.accounts.Count} / 100 profiles";
        }

        private void SubmitNewAccount_Click(object sender, EventArgs e)
        {
            if (Data.accounts == null)
            {
                Data.accounts = new List<Account>();
            }
            if (Data.accounts.Count >= 100 || NewAccountName.Text == "") return;
            
            Data.accounts.Add(new Account { name = NewAccountName.Text });
            AccountsView.Items.Add(Data.accounts[^1].name);

            NewAccountName.Text = "";
            NumberOfAccounts.Text = Data.accounts.Count < 80
                ? $"You have {Data.accounts.Count} profiles"
                : $"You have {Data.accounts.Count} / 100 profiles";
        }

        private void ChoseAccountButton_Click(object sender, EventArgs e)
        { 
            if (AccountsView.SelectedItems.Count > 0)
            {
                RefreshForm1();
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, EventArgs e)
        {
            RefreshForm1();
            Data.choosingAccount = false;
        }

        public void RefreshForm1()
        {
            Data.chosenAccount = AccountsView.Items.IndexOf(AccountsView.SelectedItems[0]);
            menu.UpdateContent();
        }

    }
}
