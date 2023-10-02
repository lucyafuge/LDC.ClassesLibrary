using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class GoldenFruit_06: Sign
    {
        public GoldenFruit_06()
        {
            Name = "6. Золотой фрукт";
            Description = "Когда узришь золотой фрукт в лучах Шамаса — это к крепкому здоровью.";
            Effect = "Ваша группа совершает спасброски Телосложения с преимуществом.";
            Success = "Каждый искатель в вашей группе получает дополнительную 1к6Н, которую он может добавлять к спасброскам Телосложения. ";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 14;
            Bunti = 3;
            Ayur = 0;
            Dodor = 1;
            Takhar = 1;
         }
    }
}
