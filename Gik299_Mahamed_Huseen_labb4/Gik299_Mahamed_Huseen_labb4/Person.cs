namespace Gik299_Mahamed_Huseen_labb4;

public class Person
{

    // Privat varibaler för personens egenskaper
    private string eyecolor;
    private string förnamn;
    private DateTime birthday;
    private Gender gender;
    private Hair hair;
        


    // Skapar en property för att hänmta och sätta värde för personens egenskaper
    public string HairColor { get { return hair.hairColor; } set { hair.hairColor = value; } }
    public string HairLength { get { return hair.hairLength; } set { hair.hairLength = value; } }
    public string Förnamn { get { return förnamn; } set { förnamn = value; } }
    public string EyeColor { get { return eyecolor; } set { eyecolor = value; } }
    public DateTime Birthday { get { return birthday; } set {birthday = value; } }
    public Gender Gender { get { return gender; } set { gender = value; } }


    // Skapar en konstruktör för att skapa en ny insats egenskaper för personen
    public Person(string Förnamn, DateTime birthday, string haircolor, string hairlength, string eyecolor, Gender gender)
    {
        // Initaliserar egenskaperna med angivna värdena
        this.Förnamn = Förnamn;
        this.Birthday = Birthday;
        this.hair = new Hair { hairColor = haircolor, hairLength = hairlength };
        this.Gender = gender;
        this.EyeColor = eyecolor;
    }


        
    public override string ToString()
    {
            
        return $"\n Namn: {Förnamn}" +
               $"\n Ålder: {Birthday:mm/dd} " +
               $"\n Kön: {Gender}" +
               $"\n Hårlängd: {HairLength}" +
               $"\n Hårfärg: {HairColor}" +
               $"\n Ögönfärg: {EyeColor}";
    }
}