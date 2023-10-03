using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class BrokenJester_27 : Sign
    {
        public BrokenJester_27()
        {
            Name = "27. Сломанный шут";
            Description = "Существо, которое всем нравится и приносит счастье. Но опасайтесь шута, что не рад лучам Шамаса, ведь он несет беду. ";
            Effect = "Ваша группа получают штраф 1к4 + бонус мастерства ко всем спасброскам.";
            Success = "Ваша группа не получает эффект и получает 2 Кости Удачи.";
            Failure = "Кость штрафа увеличивается с 1к4 до 1к6.";
            Difficult = 15;
            Bunti = 1;
            Ayur = 2;
            Dodor = 0;
            Takhar = 1;
         }
    }
}
