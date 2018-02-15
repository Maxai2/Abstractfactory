using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeight
{
    public partial class RandPics : Form
    {
        public RandPics()
        {
            InitializeComponent();
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            PictureCreator creator = new PictureCreator();

            Random random = new Random();

            pBTopLeft.Image = Image.FromFile(creator.GetPicture(random.Next(0, 5)).path);
            pBTopRight.Image = Image.FromFile(creator.GetPicture(random.Next(0, 5)).path);
            pBBottomLeft.Image = Image.FromFile(creator.GetPicture(random.Next(0, 5)).path);
            pBBottomRight.Image = Image.FromFile(creator.GetPicture(random.Next(0, 5)).path);
        }
    }
}
