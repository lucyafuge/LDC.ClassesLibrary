using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class HeavenWrath_15 : Sign
    {
        public HeavenWrath_15()
        {
            Name = "15. Гнев небес";
            Description = "Мелкие животные и насекомые быстро прячутся под камни и в песок, будто чувствуют что-то. Погода стремительно портится, и вы видите, как гневаются небеса.";
            Effect = "Ваша группа теряет всю провизию (Кость Провизии понижена до 0).";
            Success = "Ваша группа теряет всю провизию, но на следующую проверку поиска провизии у вас преимущество.  ";
            Failure = "Ваша группа получаете 1 уровень усталости. ";
            Difficult = 14;
            Bunti = 0;
            Ayur = 1;
            Dodor = 0;
            Takhar = 3;
         }
    }
}
