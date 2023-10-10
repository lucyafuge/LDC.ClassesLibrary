using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class BlueWindRibbons_16 : Sign
    {
        public BlueWindRibbons_16()
        {
            Name = "16. Синие ленты ветра";
            Description = "Синие ленты пляшут на обо: это значит, что сегодня Нарар и Раран следуют за тобой по пути. ";
            Effect = "Ваша группа совершает проверки и спасброски Ловкости с преимуществом.";
            Success = "Каждый искатель в вашей группе может один раз автоматически преуспеть при проверке или спасброске Ловкости. ";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 14;
            Bunti = 0;
            Ayur = 0;
            Dodor = 1;
            Takhar = 3;
         }
    }
}
