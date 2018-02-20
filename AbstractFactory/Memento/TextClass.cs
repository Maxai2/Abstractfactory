using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------
namespace Memento
{
    class TextClass
    {
        public string Text { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public string SelectedText { get; set; }
        public int CursorPosition { get; set; }

        public TextMemento SaveState()
        {
            return new TextMemento(Text, Bold, Italic, Underline, SelectedText, CursorPosition);
        }

        public void RestoreState(TextMemento memento)
        {
            Text = memento.Text;
            Bold = memento.Bold;
            Italic = memento.Italic;
            Underline = memento.Underline;
            SelectedText = memento.SelectedText;
            CursorPosition = memento.CursorPosition;
        }
    }
}
//-------------------------------------------------------------