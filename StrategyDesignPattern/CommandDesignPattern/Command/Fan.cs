namespace CommandDesignPattern.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    class Fan
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Turn On");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turn Off");
        }
    }
}
