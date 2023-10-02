using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class RedSunBlades_08 : Sign
    {
        public RedSunBlades_08()
        {
            Name = "8. Красные лезвия солнца";
            Description = "Если в гриве Шамаса на закате виднеются красные лезвия, которые отблесками играют на вашем оружии, то это знак начала войны.";
            Effect = "Ваша группа получаете бонус к броскам урона от атак оружием, равный бонусу мастерства.";
            Success = "Появляется красный бунти. Этот бунти является заклинанием Исцеляющий дух, не требует концентрации и может использовать способность исцеления 3 раза, после чего исчезает.";
            Failure = "У группы в два раза уменьшается дистанция всех дальнобойных атак и заклинаний";
            Difficult = 14;
            Bunti = 1;
            Ayur = 3;
            Dodor = 0;
            Takhar = 0;
         }
    }
}
