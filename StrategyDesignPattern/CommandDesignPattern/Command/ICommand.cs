namespace CommandDesignPattern.Command
{
    interface ICommand
    {
        void Execute();

        void Undo();
    }
}
