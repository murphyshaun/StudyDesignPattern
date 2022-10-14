﻿namespace CommandDesignPattern.Command
{
    class TurnOffCommand : ICommand
    {
        private readonly Fan _fan;

        public TurnOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOff();
        }

        public void Undo()
        {
            _fan.TurnOn();
        }
    }
}
