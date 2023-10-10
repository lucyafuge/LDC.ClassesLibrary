using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class CryingWind_32 : Sign
    {
        public CryingWind_32()
        {
            Name = "32. Плачущий ветер";
            Description = "Путники в дюнах знают, что плачущий ветер приносит беду. Что-то невероятно опасное рядом. Многие караванщики отказываются дальше путешествовать, если знамение таково.";
            Effect = "Ваша группа совершают спасброски от испуга с помехой.";
            Success = "Ваша группа не получает эффекта, и в следующем сражении ваша группа захватывает врасплох всех вражеских существ.";
            Failure = "Зверь ночи захватит группу врасплох. Зверь Ночи использует статблок Нотика.";
            Difficult = 14;
            Bunti = 1;
            Ayur = 1;
            Dodor = 0;
            Takhar = 2;
         }
    }
}
