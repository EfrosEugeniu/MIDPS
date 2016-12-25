using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ControlUnit
    {
        private List<Command> commands =
new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current > 0)
                    commands[--current].UnExecute();
        }
        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current < commands.Count )
                    commands[current++].Execute();
        }

        public override string ToString()
        {
            string myString = "";
            if (current != 0) myString += (commands[0].ToString()).Remove(0, 1);
            for (int i = 1; i < current; i++)
            {
                myString += commands[i].ToString();
            }
            return myString;
        }

        internal void Cleaning()
        {
            commands.Clear();
            current = 0;
        }
    }
}
