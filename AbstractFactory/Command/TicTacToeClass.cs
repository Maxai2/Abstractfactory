using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------
namespace Command
{
    class TicTacToeClass : Command
    {
        PictureBox box;
        Reciever reciever;

        public TicTacToeClass(Reciever reciever, ref PictureBox box)
        {
            this.reciever = reciever;
            this.box = box;
        }

        public override void Redo() => reciever.Operation(ref box);

        public override void Undo() => reciever.Operation(ref box);
    }
}
//----------------------------------