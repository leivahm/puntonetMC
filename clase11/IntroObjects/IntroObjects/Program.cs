namespace IntroObjects 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int edad = 0;
            int[] array = new int[4];

            // Instancia 1
            Perro firulais = new Perro();
            firulais.Color = "Negro";
            firulais.Edad = 4;
            firulais.Tamanio = "Grande";
            firulais.Raza = "Matin Napolitano";
            
            // Instancia 2
            var fatiga = new Perro();
            fatiga.Color = "Blanco";
            fatiga.Edad = 2;
            fatiga.Tamanio = "Chico";
            fatiga.Raza = "Maltes";

            // Instancia 3
            Perro cartucho = new Perro();
            cartucho.Color = "Marrón";
            cartucho.Edad = 3;
            cartucho.Tamanio = "Medio";
            cartucho.Raza = "Chow Chow";

            // Lista de perros
            var perritos = new List<Perro>();

            perritos.Add(firulais);
            perritos.Add(fatiga);
            perritos.Add(cartucho);

            //Console.WriteLine(firulais.Raza + " " + fatiga.Raza + " " + cartucho.Raza);

            Console.WriteLine($"Hay {perritos.Count} perritos en la lista");
            foreach (Perro item in perritos)
            {
                Console.Write(item.Raza + " -> ");
                item.Ladrar();
            }

        }
    }
}