using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class DeadHands_14 : Sign
    {
        public DeadHands_14()
        {
            Name = "14. Мертвые руки";
            Description = "Одинокий скрюченный засохший куст тянется вверх к небесам, как рука мертвеца.";
            Effect = "Все броски, восстанавливающие хиты от заклинаний и других магических эффектов, совершаются два раза и выбирается меньший результат";
            Success = "Ваша группа не получает эффекта, и все существа в группе получают временные хиты в количестве, равном их уровню или ПО при отсутствии уровня.";
            Failure = "У каждого существа в вашей группе максимальные хиты уменьшаются на количество, равное его Уровню или ПО при отсутствии Уровня. ";
            Difficult = 14;
            Bunti = 1;
            Ayur = 0;
            Dodor = 0;
            Takhar = 3;
         }
    }
}
