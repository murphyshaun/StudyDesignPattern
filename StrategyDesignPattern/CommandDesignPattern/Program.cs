
using CommandDesignPattern.Command;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan();

            ICommand turnOnCommand = new TurnOnCommand(fan);
            ICommand turnOffCommand = new TurnOffCommand(fan);

            var remote = new Remote(turnOnCommand, turnOffCommand);

            remote.TurnOnButtonClick();
            remote.TurnOffButtonClick();

            System.Console.WriteLine();

            System.Console.Read();
        }
    }
}
