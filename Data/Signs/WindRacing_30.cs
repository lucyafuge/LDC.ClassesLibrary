using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class WindRacing_30 : Sign
    {
        public WindRacing_30()
        {
            Name = "30. Гонки ветров";
            Description = "Холодный ветер севера и теплый ветер юга приносят вести соревнуясь в великой гонке.";
            Effect = "Ваша группа может видеть сквозь магическую и не магическую тьму на расстоянии 60 фт.";
            Success = "Скорость ходьбы искателей в вашей группе удваивается и труднопроходимая местность не оказывает влияния.";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6. ";
            Difficult = 18;
            Bunti = 1;
            Ayur = 0;
            Dodor = 2;
            Takhar = 1;
         }
    }
}
