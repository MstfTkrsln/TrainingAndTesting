using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Command_Pattern
{
    class Program
    {
        public interface ICommand
        {
            void Execute();
        }

        public class UndoCommand : ICommand
        {

            public void Execute()
            {
                Console.WriteLine("UnduCommand Worked");
            }
        }

        public class RedoCommand : ICommand
        {

            public void Execute()
            {
                Console.WriteLine("RedoCommand Worked");
            }
        }


        public class Invoker
        {
            Stack<ICommand> commandlist = new Stack<ICommand>();

            public void ExecuteAll()
            {
                while (commandlist.Count > 0)
                {
                    commandlist.Pop().Execute();
                }
            }

            public void AddCommand(ICommand c)
            {
                commandlist.Push(c);
            }

        }
        
        static void Main(string[] args)
        {

           Invoker invoker=new Invoker();

            invoker.AddCommand(new UndoCommand());
            invoker.AddCommand(new UndoCommand());
            invoker.AddCommand(new RedoCommand());

            invoker.ExecuteAll();

            Console.ReadLine();
        }
    }
}
