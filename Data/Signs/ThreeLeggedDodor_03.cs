using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ThreeLeggedDodor_03 : Sign
    {
        public ThreeLeggedDodor_03()
        {
            Name = "3. Трехногий додор";
            Description = "Трехногий додор — знак неудачи. Если кто-то видит его, то всегда должен попытаться прогнать!";
            Effect = "Ваша группа не добавляют бонус мастерства к броскам Атаки.";
            Success = "Ваша группа не получает эффекта и получает 2 Кости Удачи.";
            Failure = "Ваша группа игнорирует все преимущества на Атаки и Спасброски.";
            Difficult = 15;
            Bunti = 0;
            Ayur = 0;
            Dodor = 4;
            Takhar = 0;
         }
    }
}
