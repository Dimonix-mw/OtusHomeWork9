using OtusHomeWork9.Interfaces;

namespace OtusHomeWork9
{
    /// <summary>
    /// SOLID - S. Принцип единственной ответственности
    /// </summary>
    public class Generator : IGenerator
    {
        public int GenerateVal(int beginRange, int endRange)
        {
            var rnd = new Random();
            return rnd.Next(beginRange, endRange + 1);
        }
    }
}
