using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.models
{
    public class Note
    { 
        public string Name { get; set; }

        public string Content { get; set; }
        
        public DateTime Day { get; set; }
    }
}
