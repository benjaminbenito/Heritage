using System;

namespace Heritage
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Aire => (A*B)/2;

        public override double Perimetre => A*B*C;

        public override string ToString()
        {
            return $"Triangle de cote A={A}, B={B}, C={C} " + Environment.NewLine + base.ToString();
        }
    }
}