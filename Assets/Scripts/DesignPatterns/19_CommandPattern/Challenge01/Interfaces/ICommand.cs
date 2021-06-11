namespace Section.DesignPatterns.Command.Challenge01
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}