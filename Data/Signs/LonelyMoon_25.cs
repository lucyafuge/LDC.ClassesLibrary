using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class LonelyMoon_25 : Sign
    {
        public LonelyMoon_25()
        {
            Name = "25. Одинокая луна";
            Description = "Братец Ману одинок на беззвездном небе, это время раздумий, а не решений.";
            Effect = "Ваша группа совершает проверки и спасброски Мудрости с помехой.";
            Success = "Ваша группа не получает эффекта и каждый искатель в группе добавляет половину своего уровня к спасброскам Мудрости, округляя в меньшую сторону (минимум 1).";
            Failure = "Ваша группа получают уязвимость к психическому урону.";
            Difficult = 14;
            Bunti = 2;
            Ayur = 0;
            Dodor = 1;
            Takhar = 1;
         }
    }
}
