using LDC.ClassesLibrary.Classes.Signs;
using LDC.ClassesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Classes
{
    /// <summary>
    /// Базовый класс для инициализации базы знамений
    /// </summary>
    public class SignContextInitializer
    {
        private List<Sign> signs;

        public SignContextInitializer()
        {
            signs = new List<Sign>();
        }

        private void Update(SignContext signContext, List<Sign> signs)
        {
            var r = signContext.Database.ExecuteSqlCommand("DELETE FROM Signs");
            for (int i = 0; i < signs.Count; i++)
            {
                Sign sign = signs[i];
                signContext.Signs.Add(sign);
            }
            signContext.SaveChanges();
        }

        /// <summary>
        /// Доступный для переопледения метод, инициализирующий список знамений
        /// 
        /// При переопределении метода необходимо после объявления списка знамений
        /// вызвать конструкцию
        /// using (signContext) { Update(signContext, signs); }
        /// </summary>
        internal virtual void Initialize(SignContext signContext)
        {
            signs.Add(new RottingShadow_01());
            signs.Add(new StretchedThreads_02());
            signs.Add(new ThreeLeggedDodor_03());

            using (signContext)
            {
                Update(signContext, signs);
            }
        }
    }
}
