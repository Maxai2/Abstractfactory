using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void BTranslate_Click(object sender, EventArgs e)
        {
            WordTranslateCreator creator = new WordTranslateCreator();

            tBEng.Text = creator.GetWord(tBRus.Text);
        }
    }
}
