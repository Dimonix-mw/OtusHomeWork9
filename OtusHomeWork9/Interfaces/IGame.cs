/// <summary>
/// SOLID - I. Принцип разделения интерфейса
/// </summary>
namespace OtusHomeWork9.Interfaces
{
    public interface IGame
    {
        int Attempts { get; set; }
        int BeginRange { get; set; }
        int EndRange { get; set; }
        bool Win { get; }
        void Play();
    }
}
