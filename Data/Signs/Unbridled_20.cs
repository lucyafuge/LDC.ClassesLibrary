using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class Unbridled_20 : Sign
    {
        public Unbridled_20()
        {
            Name = "20. Необузданный";
            Description = "Маленькое животное успешно вырывается из объятий хищника.";
            Effect = "Ваша группа совершает проверки и спасброски Силы с преимуществом.";
            Success = "Ваша группа получает 2 Кости Удачи.";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 12;
            Bunti = 0;
            Ayur = 2;
            Dodor = 2;
            Takhar = 0;
         }
    }
}
