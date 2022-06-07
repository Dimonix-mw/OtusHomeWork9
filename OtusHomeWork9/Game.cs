using OtusHomeWork9.Interfaces;

namespace OtusHomeWork9
{
    /// <summary>
    /// SOLID - O. Принцип открытости-закрытости - расширяемый класс
    /// </summary>
    public class Game : BaseGame, IGameResult
    {
        private int _attempt = 0;

        private IGenerator _generator;
        /// <summary>
        /// SOLID - D. Принцип инверсии зависимости
        /// </summary>
        public Game(IGenerator generator)
        {
            _generator = generator;
        }

        public void ShowResult()
        {
            if (_win)
            {
                Console.WriteLine($"Поздравляю, Вы отгадали за {_attempt} попыток.");
            } else
            {
                Console.WriteLine($"В этот раз не повезло! Все {_attempts} попыток израсходованы.");
            }
        }

        public override void Play()
        {
            int number = _generator.GenerateVal(_beginRange, _endRange);
            int answer;
            Console.WriteLine($"Загадано число в диапозоне от {_beginRange} до {_endRange}");
            Console.Write("Ваше предположение: ");
            while (true)
            {
                _attempt++;
                if (_attempt > _attempts) break;

                if (Int32.TryParse(Console.ReadLine(), out answer))
                {
                    if (number == answer)
                    {
                        _win = true;
                        break;
                    } else if (answer < number)
                    {
                        Console.WriteLine("Нужно больше");
                    } else
                    {
                        Console.WriteLine("Нужно меньше");
                    }
                } else
                {
                    Console.WriteLine("Введите числовое значение!");
                }
            }
            ShowResult();
        }
    }
}
