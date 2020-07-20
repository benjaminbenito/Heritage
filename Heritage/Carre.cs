using System;

namespace Heritage
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double Aire => Longueur*Longueur;

        public override double Perimetre => Longueur*4;

        public override string ToString()
        {
            return $"Carre de cote {Longueur}" + Environment.NewLine + base.ToString();
        }
    }
}