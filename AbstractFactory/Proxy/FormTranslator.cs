using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------------------------------
namespace Proxy
{
    public partial class FormTranslator : Form
    {
        public FormTranslator()
        {
            InitializeComponent();
        }

        private void BTranslate_Click(object sender, EventArgs e)
        {
            Proxy proxy = new Proxy();

            tBEng.Text = proxy.Translate(tBRus.Text);
        }

        private void Translator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proxy proxy = new Proxy();

            proxy.Serialize();
        }
    }
}
//--------------------------------------