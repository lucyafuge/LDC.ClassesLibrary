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
            signs.Add(new CripplingMoon_04());
            signs.Add(new ToadsSong_05());
            signs.Add(new GoldenFruit_06());
            signs.Add(new SunnyPestilence_07());
            signs.Add(new RedSunBlades_08());
            signs.Add(new BaturinasGifts_09());
            signs.Add(new MukamaStrings_10());
            signs.Add(new TwoLivers_11());
            signs.Add(new DancingSpirits_12());
            signs.Add(new BloodRain_13());
            signs.Add(new DeadHands_14());
            signs.Add(new HeavenWrath_15());
            signs.Add(new BlueWindRibbons_16());
            signs.Add(new OngonTraces_17());
            signs.Add(new ThreeBrokenMoonlighters_18());
            signs.Add(new ThreeTornTongues_19());
            signs.Add(new Unbridled_20());
            signs.Add(new FalseSun_21());
            signs.Add(new ExtinguishedSpark_22());
            signs.Add(new EightShamasHorsemen_23());
            signs.Add(new BrokenCage_24());
            signs.Add(new LonelyMoon_25());
            signs.Add(new ShadowFangs_26());
            signs.Add(new BrokenJester_27());
            signs.Add(new LostBeast_28());
            signs.Add(new BlindDutarMusician_29());
            signs.Add(new WindRacing_30());
            signs.Add(new BaraskusRoad_31());
            signs.Add(new CryingWind_32());
            signs.Add(new ThreeNorthernStars_33());
            signs.Add(new Rebirth_34());
            signs.Add(new GeniesRedShawl_35());


            using (signContext)
            {
                Update(signContext, signs);
            }
        }
    }
}
