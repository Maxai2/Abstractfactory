using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------
namespace Command
{
    class User
    {
        Reciever receiver = new Reciever();
        List<Command> commands = new List<Command>();

        int current = 0;

        public void Undo(int cur)
        {
            for (int i = 0; i < cur; i++)
            {
                if (current > 0)
                {
                    current--;
                    Command command = commands[current];
                    command.Undo();
                }
            }
        }

        public void Redo(int cur)
        {
            for (int i = 0; i < cur; i++)
            {
                if (current <= commands.Count - 1)
                {
                    Command command = commands[current];
                    current++;
                    command.Redo();
                }
            }
        }

        public void Compute(ref PictureBox box)
        {
            Command command = new TicTacToeClass(receiver, ref box);
            command.Redo();
            if (current < commands.Count - 1)
                commands.RemoveRange(current, commands.Count - current);
            commands.Add(command);
            current++;
        }
    }
}
//----------------------------------