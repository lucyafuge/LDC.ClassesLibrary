using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class FalseSun_21 : Sign
    {
        public FalseSun_21()
        {
            Name = "21. Ложное солнце";
            Description = "Тени от лучей Шамаса падают в противоположную сторону, в направлении солнца, перестав бежать от света.";
            Effect = "Ваша группа совершает проверки Ловкости (Скрытность) и Интеллект (Природа) с помехой.";
            Success = "Ваша группа не получает эффекта, и каждый искатель в группе может прибавить 1к4Н к проверкам Ловкости (Скрытность) и Интеллекта (Природа).";
            Failure = "Искатель, прочитавший знамение, получает помеху на проверки Мудрости (Внимательность).";
            Difficult = 16;
            Bunti = 0;
            Ayur = 2;
            Dodor = 0;
            Takhar = 2;
         }
    }
}
