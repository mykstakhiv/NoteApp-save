using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    
    public class NoteBook
    {
        //name and notes that apply to each new object
        public string Name { get; init; }
        public List<string> Notes { get; set; } = new List<string>();

        
        public NoteBook(string name)
        {
            Name = name;
        }
    }

    public class NoteBooks
    {
        public List<NoteBook> ListNoteBooks { get; set; } = new List<NoteBook>();

    }
}
