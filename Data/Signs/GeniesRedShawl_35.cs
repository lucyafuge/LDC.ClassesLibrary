using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class GeniesRedShawl_35 : Sign
    {
        public GeniesRedShawl_35()
        {
            Name = "35. Красная шаль джинна";
            Description = "Красная шаль - это признак верной дороги. Считается, что джинны Акрепы оставляют красные шали из кожи багровых ящеров, направляя путников на правильный путь.";
            Effect = "Ваша группа совершает проверки Мудрость (Выживание) и Интеллект (Анализ) с преимуществом.";
            Success = "Ваша группа получает сопротивление к урону огнем. ";
            Failure = "Ваша группа не получает эффекта, а Хранитель Узлов получает Кость Проклятия 1к6.";
            Difficult = 14;
            Bunti = 1;
            Ayur = 1;
            Dodor = 1;
            Takhar = 1;
         }
    }
}
