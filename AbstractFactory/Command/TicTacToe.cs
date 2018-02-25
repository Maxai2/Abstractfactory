using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class FTicTacToe : Form
    {
        PictureBox box;
        User user;
        string path;

        public FTicTacToe()
        {
            InitializeComponent();

            user = new User();
            path = Directory.GetCurrentDirectory();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (((PictureBox)sender) == pBUpLeft)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBUpLeft.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBUpLeft.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBUpCentre)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBUpCentre.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBUpCentre.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBUpRight)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBUpRight.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBUpRight.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBCentreLeft)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBCentreLeft.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBCentreLeft.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBCentre)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBCentre.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBCentre.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBCentreRight)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBCentreRight.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBCentreRight.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBDownLeft)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBDownLeft.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBDownLeft.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBDownCentre)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBDownCentre.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBDownCentre.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }
            else
            if (((PictureBox)sender) == pBDownRight)
            {
                switch (me.Button)
                {
                    case MouseButtons.Right:
                        pBDownRight.Image = Image.FromFile(path + @"\Circle.png");
                        break;
                    case MouseButtons.Left:
                        pBDownRight.Image = Image.FromFile(path + @"\Cross.png");
                        break;
                }
            }

            //box = sender as PictureBox;
            //user.Compute(ref box);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            user.Undo(2);
        }
    }
}
