using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGaraz
{
    /// <summary>
    /// Reprezentuje auto
    /// </summary>
    internal class Auto
    {
        /// <summary>
        /// SPZ
        /// </summary>
        private string Spz;
        /// <summary>
        /// Barva
        /// </summary>
        private string Barva;
        /// <summary>
        /// Inicializuje novou instanci
        /// </summary>
        /// <param name="spz">SPZ</param>
        /// <param name="barva">Barva</param>
        public Auto(string Spz, string Barva)
        {
            this.Spz = Spz;
            this.Barva = Barva;
        }
        /// <summary>
        /// Vrátí SPZ auta
        /// </summary>
        /// <returns>SPZ auta</returns>
        public string VratSpz()
        {
            return Spz;
        }
        /// <summary>
        /// Zaparkuje auto do garáže
        /// </summary>
        /// <param name="garaz">Garáž</param>
        public void Zaparkuj(Garaz garaz)
        {
            garaz.Vloz(this);
        }
    }
}