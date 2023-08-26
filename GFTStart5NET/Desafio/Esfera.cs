using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTStart5NET.Desafio
{
    public class Esfera
    {
        public void resultado()
        {
            double pi, raio, volume;
            pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());
            volume = (4.0 / 3.0) * pi * (Math.Pow(raio, 3.0));
            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
            //escreva o seu código
        }
    }
}
