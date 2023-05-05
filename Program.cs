internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool altKit = true;
        Random random = new Random();
        int weaponTypeInt = 0;
        int numberOfPlayers = 1;
        bool freshStars = true;

        // Console.WriteLine("Which Mode do you want to use?");
        // Console.WriteLine("1:By weapon type");
        // Console.WriteLine("2:By list");
        // Console.WriteLine("3:Auto weighted");
        // Console.WriteLine("4:Self weighted");


        
        Console.WriteLine("Do you want to have Alt Kits?");
        char Input = Console.ReadKey(true).KeyChar;
        if (Input == 'n'){
            altKit = false;
        }
        



        List<string> players = new List<string>();
        Console.WriteLine("How many players are participating?");
        numberOfPlayers = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.WriteLine("Please give your name");
            string entry = Console.ReadLine();
            players.Add(entry);
        }
        while (true)
        {
            weaponTypeInt = random.Next(1, 12);
            foreach (string thing in players)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{thing}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'s Weapon is:");
                ByWeaponType(altKit);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to go again, and N to exit");
            Console.WriteLine(" ");
            char YNentry = Console.ReadKey(true).KeyChar;
            if (YNentry == 'N' || YNentry == 'n')
            {
                break;
            }
        }
    }

    public static int GetUserINTput()
    {
        try
        {
            string stringInput = Console.ReadLine();
            int intInput = Convert.ToInt32(stringInput);
            return intInput;
        }
        catch
        {
            Console.WriteLine("Please Input a number");
            return GetUserINTput();
        }
    }
    public static List<string> constructWeaponList(bool DoReKit)
    {
        List<string> weaponList = new List<string>();
        List<string> inetermediateList = new List<string>(File.ReadAllLines("Weapons/Blasters"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/BlastersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Brellas"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/BrellasReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Brushes"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/BrushesReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Chargers"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/ChargersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Dualies"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/DualiesReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Rollers"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/RollersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Shooters"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/ShootersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Sloshers"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/SloshersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Splatana"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/SplatanaReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Splatlings"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/SplatlingsReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        inetermediateList = new List<string>(File.ReadAllLines("Weapons/Stringers"));
        foreach (string thing in inetermediateList)
        {
            weaponList.Add(thing);
        }
        if (DoReKit == true)
        {
            inetermediateList = new List<string>(File.ReadAllLines("Weapons/StringersReKit"));
            foreach (string thing in inetermediateList)
            {
                weaponList.Add(thing);
            }
        }
        return weaponList;
    }
    public static void ByWeaponType(bool DoAltKit = true)
    {
        Random random = new Random();
        int weaponTypeInt = random.Next(1, 12);
        switch (weaponTypeInt)
        {
            case 1:
                //Shooter
                ByWeaponTypePrint("Weapons/Shooters","Weapons/ShootersReKit",DoAltKit);
                break;
            case 2:
                //roller
                ByWeaponTypePrint("Weapons/Rollers","Weapons/RollersReKit",DoAltKit);
                break;
            case 3:
                //charger
                ByWeaponTypePrint("Weapons/Chargers","Weapons/ChargersReKit",DoAltKit);
                break;
            case 4:
                //slosher
                ByWeaponTypePrint("Weapons/Sloshers","Weapons/SloshersReKit",DoAltKit);
                break;
            case 5:
                //splatlings   
                ByWeaponTypePrint("Weapons/Splatlings","Weapons/SplatlingsReKit",DoAltKit); 
                break;
            case 6:
                //dualies 
                ByWeaponTypePrint("Weapons/Dualies","Weapons/DualiesReKit",DoAltKit);  
                break;
            case 7:
                //brella
                ByWeaponTypePrint("Weapons/Brellas","Weapons/BrellasReKit",DoAltKit);
                break;
            case 8:
                //blaster
                ByWeaponTypePrint("Weapons/Blasters","Weapons/BlastersReKit",DoAltKit);
                break;
            case 9:
                ByWeaponTypePrint("Weapons/Brushes","Weapons/BrushesReKit",DoAltKit);
                break;
            case 10:
                //stringer
                ByWeaponTypePrint("Weapons/Stringers","Weapons/StringersReKit",DoAltKit);
                break;
            case 11:
                //splatana
                ByWeaponTypePrint("Weapons/Splatana","Weapons/SplatanaReKit",DoAltKit);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }



    //print funciton
    public static void ByWeaponTypePrint(string fileName, string KitFileName, bool DoAltKit)
    {
        Random random = new Random();
        List<string> LeBruh = new List<string>(File.ReadAllLines(fileName));
        List<string> numAltKits = new List<string>();
        int checkKit = LeBruh.Count();
        int incerementer = 0;
        foreach (var thing in new List<string>(LeBruh))
        {
            string[] splitEntry = thing.Split('_');
            if (splitEntry.Length > 1)
            {
                LeBruh[incerementer] = splitEntry[0];
                numAltKits.Add(splitEntry[1]);
            }
            else
            {
                numAltKits.Add(" ");
            }
            incerementer++;
        }
        if (DoAltKit == true)
        {
            LeBruh.AddRange(File.ReadAllLines(KitFileName));
        }
        int num = random.Next(0, LeBruh.Count);
        if (num < checkKit)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        Console.Write($" {LeBruh[num]}");
        if (DoAltKit == false)
        {
            if (numAltKits[num] != " ")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("(");
                Console.Write(numAltKits[num]);
                Console.Write(")");
            }
        }
        Console.Write("\n");
    }








    public enum weaponType { Shooter, Roller, Charger, Slosher, Splatling, Daulies, Brella, Blaster, Brush, Stringer, Splatna, Null }
}