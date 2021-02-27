using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Diary.models;

namespace Diary
{
    public class Data
    {
        public Menu Menu = new Menu();

        public static List<Account> Accounts = new List<Account>();
        public static int ChosenAccount;
        public static bool ChoosingAccount = false;

        public static void Save()
        {
            var jsonString = JsonSerializer.Serialize(Accounts);
            File.WriteAllText("data.json", jsonString);
        }

        public static void Load()
        {
            try
            {
                var jsonString = File.ReadAllText("data.json");
                Accounts = JsonSerializer.Deserialize<List<Account>>(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

