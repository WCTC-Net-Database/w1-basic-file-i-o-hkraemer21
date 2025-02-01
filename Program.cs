class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("input.csv");

        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Level Up Character");

        var menuOption = Console.ReadLine();

        if (menuOption == "1")
        {
            for (int i = 0; i < lines.Length; i++)
            {
                var cols = lines[i].Split(",");

                var name = cols[0];
                var profession = cols[1];
                var level = cols[2];
                var hitPoints = cols[3];
                var equipment = cols[4];

                var items = equipment.Split("|");
                var firstItem = items[0];
                var secondItem = items[1];
                var thirdItem = items[2];

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Job: {profession}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"Hit Points: {hitPoints}");
                Console.WriteLine($"Equipment: {firstItem}, {secondItem}, {thirdItem}\n");
            }
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Level Up Character");

            menuOption = Console.ReadLine();

        }
        if (menuOption == "2")
        {

            using (StreamWriter writer = new StreamWriter("input.csv", true))
            {
                Console.WriteLine("Enter Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("\nEnter Profession: ");
                var profession = Console.ReadLine();
                Console.WriteLine("\nEnter Level: ");
                var level = Console.ReadLine();
                Console.WriteLine("\nEnter Hit Points: ");
                var hitPoints = Console.ReadLine();
                Console.WriteLine("\nEnter First Equipment Item: ");
                var firstItem = Console.ReadLine();
                Console.WriteLine("\nEnter Second Equipment Item: ");
                var secondItem = Console.ReadLine();
                Console.WriteLine("\nEnter Third Equipment Item: ");
                var thirdItem = Console.ReadLine();
                writer.WriteLine($"{name},{profession},{level},{hitPoints},{firstItem}|{secondItem}|{thirdItem}");
            }
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Level Up Character");

            menuOption = Console.ReadLine();

        }
        if (menuOption == "3")
        {
            Console.WriteLine("Enter the name of the character you want to level up: ");
            var characterName = Console.ReadLine();

            var data = File.ReadAllLines("input.csv");

            using (StreamWriter writer = new StreamWriter("input.csv", false))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    var cols = data[i].Split(",");
                    var name = cols[0];
                    var profession = cols[1];
                    var level = cols[2];
                    var hitPoints = cols[3];
                    var equipment = cols[4];
                    var items = equipment.Split("|");
                    var firstItem = items[0];
                    var secondItem = items[1];
                    var thirdItem = items[2];
                    if (name == characterName)
                    {
                        int newLevel = int.Parse(level) + 1;
                        writer.WriteLine($"{name},{profession},{newLevel},{hitPoints},{firstItem}|{secondItem}|{thirdItem}");
                    }
                    else
                    {
                        writer.WriteLine($"{name},{profession},{level},{hitPoints},{firstItem}|{secondItem}|{thirdItem}");
                    }
                }
            }
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Level Up Character");

            menuOption = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}