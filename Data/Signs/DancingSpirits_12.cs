using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class DancingSpirits_12 : Sign
    {
        public DancingSpirits_12()
        {
            Name = "12. Танцующие духи";
            Description = "Иногда по ночам можно увидеть вдалеке слабые огоньки, танцующие в песках. Это духи пустыни веселятся, запутывая ваш путь, заставляя петлять и сходить с намеченной дороги.";
            Effect = "Пока ваша группа в пути, проверки Провизии совершаются с помехой.";
            Success = "Кость Провизии вашей группы повышается на 1 уровень.";
            Failure = "Во время путешествия ваша группа передвигается в два раза медленнее. ";
            Difficult = 14;
            Bunti = 0;
            Ayur = 1;
            Dodor = 3;
            Takhar = 0;
         }
    }
}
