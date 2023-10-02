using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class SunnyPestilence_07 : Sign
    {
        public SunnyPestilence_07()
        {
            Name = "7. Солнечный мор";
            Description = "Мертвый аюр означает день очищения пустошей. И день этот будет особенно жарким. ";
            Effect = "Ваша группа совершает проверки и спасброски Телосложения с помехой.";
            Success = "Ваша группа не получает эффекта и получает сопротивление к урону ядом.";
            Failure = "Ваша группа получает штраф -2 КД.";
            Difficult = 14;
            Bunti = 3;
            Ayur = 0;
            Dodor = 0;
            Takhar = 1;
         }
    }
}
