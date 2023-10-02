using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes.Signs
{
    public class StretchedThreads_02 : Sign
    {
        public StretchedThreads_02()
        {
            Name = "2. Натянутые нити";
            Description = "Среди кочевников лишь отчаянные смельчаки рискнут отправиться в путь, когда боги затаили дыхание. Ветер дует, но ничто не движется, будто замерло в ожидании.";
            Effect = "Следующее знамение считается автоматическим провалом, и его эффект нельзя изменить.";
            Success = "Эффект знамения не отменяется, но в следующий раз вы бросаете на знамение дважды и можете выбирать результат.";
            Failure = "В следующий раз вы получаете не одно, а два знамения, которые нельзя изменить. Они оба считаются автоматическим провалом.";
            Difficult = 15;
            Bunti = 0;
            Ayur = 4;
            Dodor = 0;
            Takhar = 0;
         }
    }
}
