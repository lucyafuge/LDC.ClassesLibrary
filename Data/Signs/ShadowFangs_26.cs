using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ShadowFangs_26 : Sign
    {
        public ShadowFangs_26()
        {
            Name = "26. Клыки теней";
            Description = "Тени тянутся дальше, чем им позволено, не боясь лучей Шамаса. Они, как клыки, вонзились в лучи солнца.";
            Effect = "Каждый искатель в вашей группы получают бонус к проверкам Ловкости (Скрытность) и Харизмы (Обман), равный половине своего уровня, округляя в меньшую сторону (минимум 1).";
            Success = "Искатель, прочитавший знамение, получает одного малого духа - теневой дух* - до следующего знамения.";
            Failure = "Вы не получаете эффекта, и тени затягивают вас в мир зари*.";
            Difficult = 18;
            Bunti = 1;
            Ayur = 2;
            Dodor = 1;
            Takhar = 0;
         }
    }
}
