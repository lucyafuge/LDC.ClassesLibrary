using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class OngonTraces_17 : Sign
    {
        public OngonTraces_17()
        {
            Name = "17. Следы Онгона";
            Description = "Отпечатки 7-пальцевого духа обмана означают, что нельзя быть уверенным в том, что ты видишь сегодня.";
            Effect = "Ваша группа совершает проверки и спасброски Интеллекта с помехой.";
            Success = "Ваша группа не получает эффекта и каждый искатель в группе добавляет двойной бонус мастерства к проверкам Мудрости (Выживание).";
            Failure = "Следующая встреча с противником застанет вашу группу врасплох.";
            Difficult = 14;
            Bunti = 2;
            Ayur = 2;
            Dodor = 0;
            Takhar = 0;
         }
    }
}
