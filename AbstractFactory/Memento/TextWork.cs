using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------------------
namespace Memento
{
    public partial class FTextWork : Form
    {
        LoadHistory load;
        public FTextWork()
        {
            InitializeComponent();
            load = new LoadHistory();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            load.Add(new TextMemento(rTBWorkPlace.Text, rTBWorkPlace.Font.Style, rTBWorkPlace.SelectionLength, rTBWorkPlace.SelectionStart));
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            rTBWorkPlace.Text = load.History[load.Selected].Text;    
        }

        private void Style_Click(object sender, EventArgs e)
        {
            if (rTBWorkPlace.SelectionFont == null)
                return;

            FontStyle style = rTBWorkPlace.SelectionFont.Style;

            if (((Button)sender).Name == bBold.Name)
            {
                if (rTBWorkPlace.SelectionFont.Bold)
                    style &= ~FontStyle.Bold;
                else
                    style |= FontStyle.Bold;
            }
            else
            if (((Button)sender).Name == bUnderline.Name)
            {
                if (rTBWorkPlace.SelectionFont.Underline)
                    style &= ~FontStyle.Underline;
                else
                    style |= FontStyle.Underline;
            }
            else
            {
                if (rTBWorkPlace.SelectionFont.Italic)
                    style &= ~FontStyle.Italic;
                else
                    style |= FontStyle.Italic;
            }

            rTBWorkPlace.SelectionFont = new Font(rTBWorkPlace.SelectionFont, style);
        }

        private void bRendo_Click(object sender, EventArgs e)
        {
            TextMemento memento = load.Rendo();
            rTBWorkPlace.Text = memento.Text;
            rTBWorkPlace.SelectionStart = memento.CursorPosition;
        }

        private void bUndo_Click(object sender, EventArgs e)
        {
            TextMemento memento = load.Undo();
            rTBWorkPlace.Text = memento.Text;
            rTBWorkPlace.SelectionStart = memento.CursorPosition;
        }
    }
}
//-------------------------------------------------------------