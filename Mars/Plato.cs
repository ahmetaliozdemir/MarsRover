using System;
using System.Collections.Generic;

namespace Mars
{
    public class Plato
    {
        //Platonun sınırlarını belli eden x ve y değerleri.
        private int x;
        private int y;

        List<Yon> Yonlistesi = new List<Yon>();


        public Plato(int _x, int _y)
        {
            x = _x;
            y = _y;
            Yonlistesi.Add(new Yon() { Id = 0, yon = 'N' });
            Yonlistesi.Add(new Yon() { Id = 1, yon = 'E' });
            Yonlistesi.Add(new Yon() { Id = 2, yon = 'S' });
            Yonlistesi.Add(new Yon() { Id = 3, yon = 'W' });
        }
    }
}
