double milhas, km;

Console.Write ("Entre com a medida (em milhas): ");
milhas = Convert.ToDouble(Console.ReadLine());

km = milhas * 1.609;

Console.WriteLine($"{km:N3} Km");