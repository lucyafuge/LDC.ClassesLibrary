using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class BrokenCage_24 : Sign
    {
        public BrokenCage_24()
        {
            Name = "24. Сломанная клетка";
            Description = "Сломанная серебряная клетка — символ открытого разума. Многие изобретатели спешат домой, видя такой знак, чтобы скорее начать работу.";
            Effect = "Ваша группа совершает проверки и спасброски Интеллекта с преимуществом.";
            Success = "Ваша группа получают сопротивление к психическому урону.";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 15;
            Bunti = 2;
            Ayur = 1;
            Dodor = 0;
            Takhar = 1;
         }
    }
}
