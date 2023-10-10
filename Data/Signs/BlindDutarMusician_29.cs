using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class BlindDutarMusician_29 : Sign
    {
        public BlindDutarMusician_29()
        {
            Name = "29. Слепой музыкант с дутаром";
            Description = "Один из небесных музыкантов, слепой старик с дутаром, — символ храбрости и наступления хороших времен.";
            Effect = "Каждый персонаж в вашей группе получает к12 Кость Вдохновения (Вдохновение Барда), которую можно использовать до следующего знамения.";
            Success = "Ваша группа получают иммунитет к состоянию испуг. ";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 12;
            Bunti = 1;
            Ayur = 1;
            Dodor = 2;
            Takhar = 0;
         }
    }
}
