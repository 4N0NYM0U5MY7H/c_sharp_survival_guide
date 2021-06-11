namespace Section.DesignPatterns.Command.Presentation
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}