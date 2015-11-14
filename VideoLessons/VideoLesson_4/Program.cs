using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFight fightRoundOne = GetFighter(FighterType.EugeneFighter);
            BaseFight fightRoundTwo = GetFighter(FighterType.AlexandrFighter);

            Console.WriteLine(string.Empty + '\n' + $"На арене {fightRoundOne}");
            Console.WriteLine(fightRoundOne.Ult() + '\n' + fightRoundOne.Miss(1000));

            Console.WriteLine(string.Empty + '\n' + $"На арене {fightRoundTwo}");
            Console.WriteLine(fightRoundTwo.Ult() + '\n' + fightRoundTwo.Miss(2000));

            Console.ReadLine();
        }

        private static BaseFight GetFighter(FighterType type)
        {
            switch (type)
            {
                case FighterType.EugeneFighter:
                    return new EugeneFighter();

                case FighterType.AlexandrFighter:
                    return new AlexandrFighter();

                default:
                    throw new Exception("Нет такого бойца, УХОДИ!");
            }
        }
    }
}
