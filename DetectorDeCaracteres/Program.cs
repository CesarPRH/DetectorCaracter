using System;

namespace DetectorDeCaracteres
{
   public static class DetectorDeCaracteres
    {
        public static void Main(string[] args)
        {
            string oracion;
            char caracter;
            string caracterAux;
            char caracterUpper;
            int contador = 0;
            string cadenaChar ="";
            int tamano;
            int error;

            do
            {
                Console.WriteLine("Escriba el caracter que quisiera detectar.\n");
                caracterAux = Console.ReadLine();
                try
                {
                    caracter = char.Parse(caracterAux);
                    caracterUpper = char.Parse(caracterAux.ToUpper());
                    Console.WriteLine("Escriba una oracion. \n");
                    oracion = Console.ReadLine();
                    tamano = oracion.Length;

                    for (int i = 0; i < tamano; i++)
                    {
                        char c = oracion[i];
                        if (c == caracter || c==caracterUpper)
                        {
                            Console.WriteLine(c);
                            Console.WriteLine(i);
                            contador++;
                            cadenaChar += c;

                        }
                        else
                        {
                            cadenaChar += " ";
                        }
                    }
                    Console.WriteLine($"Hay {contador} {caracter}s en la oracion.");
                    Console.WriteLine($"Cadena de caracteres:\n{cadenaChar}");
                    error = 0;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Solo tiene que ser un caracter.");
                    error = 1;
                }
            } while (error == 1);

        }
    }
}
