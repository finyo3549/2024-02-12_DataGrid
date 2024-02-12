using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_12_DataGrid
{
    internal class Orszag
    {
        private string orszagnev;
        private string kontinens;
        private string fovaros;
        private decimal terulet;

        public string Orszagnev { get => orszagnev; set => orszagnev = value; }
        public string Kontinens { get => kontinens; set => kontinens = value; }
        public string Fovaros { get => fovaros; set => fovaros = value; }
        public decimal Terulet { get => terulet; set => terulet = value; }

        public Orszag(string orszag, string kontinens, string fovaros, decimal terulet)
        {
            Orszagnev = orszag;
            Kontinens = kontinens;
            Fovaros = fovaros;
            Terulet = terulet;
        }
    }
}
