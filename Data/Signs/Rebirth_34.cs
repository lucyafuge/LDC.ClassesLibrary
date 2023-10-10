using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class Rebirth_34 : Sign
    {
        public Rebirth_34()
        {
            Name = "34. Перерождение";
            Description = "Особой удачей среди кочевников считается повстречать змею, еще не сбросившую кожу до конца. Это символ перерождения. Того, кто встретит такую в песках, ждут удача и прилив жизненных сил. ";
            Effect = "Каждый искатель в группе получает временные хиты в количестве, равном своему уровню.";
            Success = "Ваша группа получает бонус +1 ко всем спасброскам.";
            Failure = "Эффект знамения получаете не ваша группа, а противники вашей группы в следующем бою. ";
            Difficult = 14;
            Bunti = 0;
            Ayur = 1;
            Dodor = 1;
            Takhar = 2;
         }
    }
}
