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
        public static int chosenAccount = 0;
        public static Account[] accounts = new Account[0];
        public static bool openedChooseAccount = false;

        public void RefreshChoosenAccount()
        {
            this.Text = $"Diary - {accounts[chosenAccount].name.ToLower()}";
            ChosenAccountDisplay.Text = $"Using {accounts[chosenAccount].name.ToLower()}";
            openedChooseAccount = false;

            Days.Items.Clear();
            foreach (var note in accounts[chosenAccount].notes)
            {
                Days.Items.Add(note.name);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }
        
        public static void SaveFile()
        {
            var b = accounts;
        
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Account[]));
        
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"//data.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
        
            writer.Serialize(file, b);
            file.Close();
        }
        public void LoadFile()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(Account[]));
                System.IO.StreamReader file = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"//data.xml");
                Account[] b = (Account[])reader.Deserialize(file);
                file.Close();

                accounts = b;
            }
            catch
            {
                return;
            }
        }

        private void ChooseAccountButton_Click(object sender, EventArgs e)
        {
            if (!openedChooseAccount)
            {
                Form2 choose = new Form2(this);
                choose.Show();
                openedChooseAccount = true;
            }
        }

        private void ReadEditButton_Click(object sender, EventArgs e)
        {
            if (Days.SelectedItems.Count > 0)
            {
                Form3 edit = new Form3($"Diary -> {accounts[chosenAccount].name} -> {accounts[chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].name}",
                                        accounts[chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].content,
                                        accounts[chosenAccount].notes[Days.Items.IndexOf(Days.SelectedItems[0])].day,
                                        Days.Items.IndexOf(Days.SelectedItems[0])
                                      );
                edit.Show();
            }
        }

        private void NewDayButton_Click(object sender, EventArgs e)
        {
            if (NewNoteName.Text != "")
            {
                var a = accounts[chosenAccount].notes.ToList();
                a.Add(new Note { name = NewNoteName.Text, content = " ", day = DateTime.Now });
                accounts[chosenAccount].notes = a.ToArray();

                Days.Items.Clear();
                foreach(var note in accounts[chosenAccount].notes)
                {
                    Days.Items.Add(note.name);
                }
            }
            NewNoteName.Text = "";
        }
    }
}
