using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class EightShamasHorsemen_23 : Sign
    {
        public EightShamasHorsemen_23()
        {
            Name = "23. Восемь всадников Шамаса";
            Description = "Если на заре видны все 8 лучей Шамаса, мудрецы оглашают, что настал день светлого разума.";
            Effect = "Ваша группа совершает проверки и спасброски Мудрости с преимуществом.";
            Success = "Совершая бросок урона от атаки, каждый искатель в вашей группе наносит дополнительный урон огнём равный половине своего уровня, округляя в меньшую сторону (минимум 1).";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 16;
            Bunti = 2;
            Ayur = 1;
            Dodor = 1;
            Takhar = 0;
         }
    }
}
