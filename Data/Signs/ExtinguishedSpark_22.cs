﻿using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class ExtinguishedSpark_22 : Sign
    {
        public ExtinguishedSpark_22()
        {
            Name = "22. Потухшая Искра";
            Description = "Огонь гаснет резко, как будто кто-то задул его. Среди старцев адаадов считается, что это знак беспокойной Искры.";
            Effect = "Каждый раз, когда персонаж накладывает заклинание или использует магический эффект, есть шанс, что они не сработают. Искатель должен совершить бросок к20. При результате 1-4, заклинание или магический эффект не срабатывают (однако, ячейка заклинания или использование эффекта тратятся соответственно).";
            Success = "Искатель, прочитавший знамение, получает одного малого духа - осколок духа Ильбеша - до следующего знамения.";
            Failure = "Шанс того, что магия не сработает, повышается. Теперь магия не срабатывает при значениях 1-10 и искатель, прочитавший знамение, получает 2 уровень усталости.";
            Difficult = 14;
            Bunti = 0;
            Ayur = 0;
            Dodor = 2;
            Takhar = 2;
         }
    }
}