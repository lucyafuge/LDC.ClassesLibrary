using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ThreeNorthernStars_33 : Sign
    {
        public ThreeNorthernStars_33()
        {
            Name = "33. Три северные звезды";
            Description = "Три северных звезды сияют в ночном небе, освещая путь странникам ночи и раскрывая древние тайны.";
            Effect = "Ваша группа совершает проверки Интеллекта (Анализ) с преимуществом и пассивная Мудрость (Внимательность) искателей в группе увеличивается на 5.";
            Success = "Искатель, прочитавший знамение, получает истинное зрение радиусом 30 футов.";
            Failure = "Искатель, прочитавший знамение, становится ослепленным до конца продолжительного отдыха.";
            Difficult = 15;
            Bunti = 1;
            Ayur = 0;
            Dodor = 1;
            Takhar = 2;
         }
    }
}
