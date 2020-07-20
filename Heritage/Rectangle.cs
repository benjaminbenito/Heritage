using System;

namespace Heritage
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur*Longueur;

        public override double Perimetre => (Largeur+Longueur)*2;

        public override string ToString()
        {
            return $"Rectangle de Longueur={Longueur} et de Largeur={Largeur}"  + Environment.NewLine + base.ToString();
        }
    }
}