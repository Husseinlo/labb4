namespace Gik299_Mahamed_Huseen_labb4;



    class Program
    {

        // Skapar en lista som lagrar alla inmatningar om personens egenskaper
        public static List<Person> people = new List<Person>();


        
        public static void Main(String[] args)
        {

            // Anropar metoden Menue
            Menu();
        }


        // Skapar en metod där användaren välja ett av alternativeran 
        public static void Menu()
        {

            
            int choice = 0;
            bool meny = true;

            // Så länge som användaren inte matar in 3 fortsätter loopen
            while (true)
            {

                // Skriver ut meny med alternativerna som använder kan välja mellan
                Console.WriteLine("Menu");
                Console.WriteLine("1. Lägg till person i databas");
                Console.WriteLine("2. visa alla personer i databas ");
                Console.WriteLine("3. Avsluta");


                // Omvandlar till datatypen int
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("fel");
                    continue;
                }



                // Skapar swich/case som hanterar användarens alternativ från menyn 
                switch (choice)
                {

                    
                    case 1: 
                        // alternativ 1 anropar på metoden AddPerson
                        AddPerson();
                        break;
                    case 2:
                        // Alternativ 2 anropar på metoden information
                        Information();
                        break;
                    case 3:
                        // Alternativ 3 avslutar programmet
                        Console.WriteLine("Exiting...");
                        return;
                    
                }
            }
        }


        // Skapar en metod där användaren kan mata in infromationen för Person-objektet
        static void AddPerson()
        {

            // Skapar en variabel med datatypen bool och har värdet true
            bool inputs = true;


            // Loppen forstätter om värdet av inputs är sant 
            while (inputs)
            {


                Console.WriteLine("--------------------------------------");

                // Skriver ut vad användaren ska mata in
                Console.WriteLine("Ange förnamn ");
                // Variabel för användaren förnamn och med hjälp av Console.ReadLine() användaren kan mata in
                string name = Console.ReadLine();
                while (int.TryParse(name, out _) || string.IsNullOrEmpty(name))
                    
                {
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Du måste ange giltig förnamn. ");
                    }
                    else if (string.IsNullOrEmpty(name))
                    {                           
                        Console.WriteLine("Du måste ange förnamn: ");
                            
                    }

                    {
                        Console.WriteLine("Ange förnamn: ");
                        name = Console.ReadLine();
                            
                    }
                }
                
                

                DateTime birthday;

                while (true)
                {
                    Console.WriteLine("Ange födelsedag MM/DD: ");
    
                    // Försök att parsae användarens inmatning till ett DateTime-objekt
                    if (DateTime.TryParse(Console.ReadLine(), out birthday))
                    {
                        // Avsluta loopen om inmatningen är giltig
                        break; 
                    }
                    else 
                    {
                        // Loopen fortsätter tills en giltig inmatning görs
                        Console.WriteLine("Du måste ange födelsedag, vänligen försök igen.");
                    }

                    
                } 


                
                    Console.WriteLine("Ögönfärg ");
                    string eyecolor = Console.ReadLine();
                    while (int.TryParse(eyecolor, out _) || string.IsNullOrEmpty(eyecolor))
                    
                    {
                        if (string.IsNullOrEmpty(eyecolor))
                        {
                            Console.WriteLine("Du måste ange giltig ögonfärg. ");
                        }
                        else if (string.IsNullOrEmpty(eyecolor))
                        {                           
                            Console.WriteLine("Du måste ange Ögönfärg: ");
                            
                        }

                        {
                            Console.WriteLine("Ange ögonfärg: ");
                            eyecolor = Console.ReadLine();
                            
                        }
                    }
                    
                    Console.WriteLine("Hårfärg: ");
                    string haircolor = Console.ReadLine();
                    while (int.TryParse(haircolor, out _) || string.IsNullOrEmpty(haircolor))
                    
                    {
                        if (int.TryParse(haircolor, out _))
                        {
                            Console.WriteLine("Du måste ange en giltig hårfärg, inte en siffra.");
                        }
                        
                        else if (string.IsNullOrEmpty (haircolor))
                    {
                        Console.WriteLine("Du måste ange hårfärg ");
                        
                    }
                        Console.WriteLine("Ange hårfärg: ");
                        haircolor = Console.ReadLine();
                        
                        
                    }

                    Console.WriteLine("Ange hår längd i centimeter ");
                    string hairlength = Console.ReadLine();
                    int hårlängdperson;

                    while (!int.TryParse(hairlength, out hårlängdperson))
                    {
                        Console.WriteLine("Fel angiven input, var snäll och skriv igen");
                        hairlength = Console.ReadLine();
                    }

                    
                  
                    

                    
                    string gen;

                    while (true)
                    {
                        Console.WriteLine("Du måste ange kön: Ange välj mellan dessa allternativ Man/Kvinna/Ickebinar/Annat: ");
                        gen = Console.ReadLine();

                        if (!Enum.TryParse(typeof(Gender), gen, true, out _))
                        {
                            Console.WriteLine("Felaktig inmatning. Var god försök igen.");
                        }
                        else
                        {
                            break; 
                        }
                    }

                    Gender gender = (Gender)Enum.Parse(typeof(Gender), gen, true);

                    
                    
                    Person person = new Person(name, birthday, haircolor, hairlength, eyecolor, gender);
                    people.Add(person);

                    Console.WriteLine("Vill du lägga till en ny person i databasen? (Ange J för ja och N för nej )");
                    if (Console.ReadLine().ToUpper() != "J")
                    {
                        inputs = false;
                    }
                    
                
            }
        }

        // infromationen som är lagrad i listan people skriv ut 
        public static void Information()
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }