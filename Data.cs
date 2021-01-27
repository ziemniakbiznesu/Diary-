using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Diary
{
    public class Data
    {
        public Form1 menu = new Form1();

        public static List<Account> accounts = new List<Account>();
        public static int chosenAccount;
        public static bool choosingAccount = false;

        public void ChooseAccount()
        {
            menu.UpdateContent();
        }

        public static void Save()
        {
            var jsonString = JsonSerializer.Serialize(accounts);
            File.WriteAllText("data.json", jsonString);
        }

        public static void Load()
        {
            try
            {
                var jsonString = File.ReadAllText("data.json");
                accounts = JsonSerializer.Deserialize<List<Account>>(jsonString);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}

