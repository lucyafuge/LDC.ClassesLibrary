using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class BaraskusRoad_31 : Sign
    {
        public BaraskusRoad_31()
        {
            Name = "31. Дорога Баракуса";
            Description = "Говорят, что некоторые дороги среди песков благословлены самим Бараскусом, однако эти тайные тропы известны лишь аджаидам. Но иногда на них можно выйти совершенно случайно.";
            Effect = "Ваша группа добавляют бонус мастерства к проверкам Ловкости (Инициатива).";
            Success = "Ваша группа совершает проверки Ловкости (Инициатива) с преимуществом.";
            Failure = "Ваша группа имеет минимальную инициативу (0) в бою.";
            Difficult = 15;
            Bunti = 0;
            Ayur = 1;
            Dodor = 2;
            Takhar = 1;
         }
    }
}
