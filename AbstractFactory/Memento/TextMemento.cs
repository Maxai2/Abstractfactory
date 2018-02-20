using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------
namespace Memento
{
    class TextMemento
    {
        public string Text { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public string SelectedText { get; set; }
        public int CursorPosition { get; set; }

        public TextMemento(string Text, bool Bold, bool Italic, bool Underline, string Seltext, int CurPos)
        {
            this.Text = Text;
            this.Bold = Bold;
            this.Italic = Italic;
            this.Underline = Underline;
            SelectedText = Seltext;
            CursorPosition = CurPos;
        }
    }
}
//-------------------------------------------------------------