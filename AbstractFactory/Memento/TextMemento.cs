using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------
namespace Memento
{
    class TextMemento
    {
        public string Text { get; set; }
        public FontStyle Style { get; set; }
        public int SelectedTextLength { get; set; }
        public int CursorPosition { get; set; }

        public TextMemento(string Text, FontStyle style, int SeltextLength, int CurPos)
        {
            this.Text = Text;
            Style = style;
            SelectedTextLength = SeltextLength;
            CursorPosition = CurPos;
        }
    }
}
//-------------------------------------------------------------