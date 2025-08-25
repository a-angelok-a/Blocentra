namespace Blocentra.Services
{
    public interface IWindowService
    {
        void CloseWindowCommand();
        void MaximizeRestoreCommand();
        void MinimizeRestoreCommand();
    }
}
