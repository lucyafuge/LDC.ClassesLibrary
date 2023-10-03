using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class TwoLivers_11 : Sign
    {
        public TwoLivers_11()
        {
            Name = "11. Две печени";
            Description = "Раздвоенная печень мертвого животного — знак того, что война будет неуспешной и с ней нужно повременить. ";
            Effect = "Совершая бросок урона от атаки, каждый искатель в вашей группе отнимает от результата половину своего уровня, округляя в меньшую сторону (минимум 1). ";
            Success = "Ваша группа не получает эффекта и каждый искатель в группе добавляет половину своего уровня к спасброскам Телосложения, округляя в меньшую сторону (минимум 1).";
            Failure = "Максимальное количество хитов искателя, прочитавшего знамение, уменьшается до половины от текущего максимума, округляя в меньшую сторону, до следующего знамения. ";
            Difficult = 15;
            Bunti = 1;
            Ayur = 0;
            Dodor = 3;
            Takhar = 0;
         }
    }
}
