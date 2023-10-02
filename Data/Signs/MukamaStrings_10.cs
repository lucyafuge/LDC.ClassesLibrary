using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class MukamaStrings_10 : Sign
    {
        public MukamaStrings_10()
        {
            Name = "10. Струны мукама";
            Description = "Свист ветра, шелест лент и оберегов звучат будто мягкая успокаивающая мелодия.";
            Effect = "Ваша группа совершает проверки Харизмы (Выступление) и Харизмы (Обман) с преимуществом.  ";
            Success = "Ваша группа получает иммунитет к состоянию очарование.";
            Failure = "Искатель, прочитавший знамение, теряет голос до следующего знамения.";
            Difficult = 14;
            Bunti = 0;
            Ayur = 3;
            Dodor = 0;
            Takhar = 1;
         }
    }
}
