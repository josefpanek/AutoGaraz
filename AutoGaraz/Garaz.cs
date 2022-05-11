using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGaraz
{
    /// <summary>
    /// Reprezentuje garáž
    /// </summary>
    internal class Garaz
    {
        /// <summary>
        /// Instance auta, které je v garáži zaparkované
        /// </summary>
        private Auto auto;
        /// <summary>
        /// Vloží auto do garáže
        /// </summary>
        public void Vloz(Auto auto)
        {
            this.auto = auto;
        }
        /// <summary>
        /// Vrátí textovou reprezentaci garáže
        /// </summary>
        /// <returns>textová reprezentace garáže</returns>
        public override string ToString()
        {
            return string.Format("V garáži je auto: {0}", auto.VratSpz());
        }
    }
}