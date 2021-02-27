using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.models
{
    public class Account
    {
        public string Name { get; set; }

        public List<Note> Notes { get; set; }
    }
}
