using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ThreeTornTongues_19 : Sign
    {
        public ThreeTornTongues_19()
        {
            Name = "19. Три вырванных языка";
            Description = "Вырезанный язык — тот, кто не молвит: он приносит удачу в торговле. Из-за этого многие торговцы обязательно держат немых в караване как талисман.";
            Effect = "Ваша группа совершает проверки и спасброски Харизмы с преимуществом.";
            Success = "Каждый искатель в вашей группе может один раз автоматически преуспеть при проверке Харизмы (Убеждение).";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 16;
            Bunti = 2;
            Ayur = 0;
            Dodor = 0;
            Takhar = 2;
         }
    }
}
