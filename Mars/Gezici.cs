using System;
using System.Collections.Generic;
using System.Text;

namespace Mars
{
    class Gezici
    {
        private int x;
        private int y;
        private int yon_sayisi;
        public List<Yon> Yonlistesi;
        public Gezici(int _x, int _y, char _yon, List<Yon> Yonler)
        {
            x = _x;
            y = _y;
            Yonlistesi = Yonler;
            //Yön sayısı ve yon id eşleştirilerek yon sayısı tespit edildi.
            yon_sayisi = Yonlistesi.Find(y => y.yon == _yon).Id;
        }

        public string Right()
        {
            yon_sayisi = yon_sayisi + 1 > Yonlistesi.Count - 1 ? 0 : yon_sayisi + 1;
            return this.bilgi();
        }

        public string Left()
        {
            yon_sayisi = yon_sayisi - 1 < 0 ? Yonlistesi.Count - 1 : yon_sayisi - 1;
            return this.bilgi();

        }

        public string Move(int xlimit, int ylimit)
        {
            switch (yon_sayisi)
            {
                case 0:
                    y = y + 1 > ylimit ? ylimit : y + 1;
                    break;
                case 1:
                    x = x + 1 > xlimit ? xlimit : x + 1;
                    break;
                case 2:
                    y = y - 1 < 0 ? 0 : y - 1;
                    break;
                case 3:
                    x = x - 1 < 0 ? 0 : x - 1;
                    break;
            }

            return bilgi();
        }

        public string bilgi()
        {
            return (x.ToString() + "," + y.ToString() + "," + Yonlistesi.Find(y => y.Id == yon_sayisi).yon);
        }
    }
}
