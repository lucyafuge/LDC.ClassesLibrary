using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class CripplingMoon_04 : Sign
    {
        public CripplingMoon_04()
        {
            Name = "4. Калечащая луна";
            Description = "Ману спрятался за темное отражение своего брата Шамаса, забрав себе всю вашу силу.";
            Effect = " Ваша группа совершает проверки и спасброски Силы с помехой.";
            Success = "Ваша группа не получает эффекта и каждый искатель в группе получает бонус к проверкам Силы (Атлетика) равный половине своего уровня, округляя в меньшую сторону (минимум 1).";
            Failure = "Ваша группа получает уязвимость к урону холодом.";
            Difficult = 14;
            Bunti = 0;
            Ayur = 0;
            Dodor = 0;
            Takhar = 4;
         }
    }
}
