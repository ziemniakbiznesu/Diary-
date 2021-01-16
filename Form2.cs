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
        readonly Form1 frm = null;

        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NumberOfAccounts.Text = Form1.accounts.Length < 80
                ? $"You have {Form1.accounts.Length} profiles"
                : $"You have {Form1.accounts.Length} / 100 profiles";

            AccountsView.Items.Clear();
            foreach (var a in Form1.accounts)
            {
                AccountsView.Items.Add(a.name);
            }
        }

        private void SubmitNewAccount_Click(object sender, EventArgs e)
        {
            if (Form1.accounts.Length < 100 && NewAccountName.Text != "")
            {
                List<Account> a = Form1.accounts.ToList();
                a.Add(new Account { name = NewAccountName.Text});
                Form1.accounts = a.ToArray();
                AccountsView.Items.Add(Form1.accounts[^1].name);

                NewAccountName.Text = "";
            }

            NumberOfAccounts.Text = Form1.accounts.Length < 80
                ? $"You have {Form1.accounts.Length} profiles"
                : $"You have {Form1.accounts.Length} / 100 profiles";
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
        }

        public void RefreshForm1()
        {
            Form1.chosenAccount = AccountsView.Items.IndexOf(AccountsView.SelectedItems[0]);
            frm.RefreshChoosenAccount();
        }

    }
}
