using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ToadsSong_05 : Sign
    {
        public ToadsSong_05()
        {
            Name = "5. Песня жаб";
            Description = "Когда жабы поют на закате в грязи, старейшины говорят, что это знак неподвижности.";
            Effect = "Ваша группа совершает проверки и спасброски Ловкости с помехой.";
            Success = "Ваша группа не получает эффекта и каждый искатель в группе получает бонус к проверкам Ловкость (Скрытности) равный половине своего уровня, округляя в меньшую сторону (минимум 1).";
            Failure = "Скорость ходьбы всей группы уменьшена на 5 футов до следующего Знамения. ";
            Difficult = 13;
            Bunti = 3;
            Ayur = 1;
            Dodor = 0;
            Takhar = 0;
         }
    }
}
