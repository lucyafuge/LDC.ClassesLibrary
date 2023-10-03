using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ThreeBrokenMoonlighters_18 : Sign
    {
        public ThreeBrokenMoonlighters_18()
        {
            Name = "18. Три сломанных лунника";
            Description = "Знак вражды. Три сломанных лунника — дурная примета, означающая, что любые разговоры обречены на неудачу. ";
            Effect = "Ваша группа совершает проверки и спасброски Харизмы с помехой.";
            Success = "Ваша группа не получает эффект и каждый искатель в группе добавляет половину своего уровня, к проверкам Харизмы (Обман), округляя в меньшую сторону (минимум 1). ";
            Failure = "Ваша группа делает с помехой проверки Мудрости (Проницательность). ";
            Difficult = 15;
            Bunti = 2;
            Ayur = 0;
            Dodor = 2;
            Takhar = 0;
         }
    }
}
