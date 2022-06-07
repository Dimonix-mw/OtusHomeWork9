using OtusHomeWork9.Interfaces;

namespace OtusHomeWork9
{
    /// <summary>
    /// SOLID - O. Принцип открытости-закрытости
    /// </summary>
    public abstract class BaseGame : IGame
    {
        protected int _attempts;
        protected int _beginRange;
        protected int _endRange;
        protected bool _win = false;

        public int Attempts { get => _attempts; set => _attempts = value; }
        public int BeginRange { get => _beginRange; set => _beginRange = value; }
        public int EndRange { get => _endRange; set => _endRange = value; }
        public bool Win { get => _win; }

        public virtual void Play()
        {
        }
    }
}
