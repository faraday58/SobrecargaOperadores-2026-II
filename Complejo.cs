using System;

namespace SobrecargaOperadores_2026_II
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;


        public Complejo(float real, float imaginaria )
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }


        public static Complejo Leer(string complejo )
        {
            // El formato esperado es "a + bj"

            string[] partes = complejo.Split('+');
            // partes[0] = "a"
            // partes[1] = " bj"
            partes[1].Trim('j'); // Eliminar la 'j' al final

            float real = float.Parse(partes[0].Trim());
            float imaginaria = float.Parse(partes[1].Trim('j'));
            return new Complejo(real, imaginaria);
        }

        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria );
        }


        public override string ToString()
        {
            return $" {real} + {imaginaria}j";
        }

    }
}
