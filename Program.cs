internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool altKit = true;
        bool gearAbilitys = false;
        Random random = new Random();
        int weaponTypeInt = 0;
        int numberOfPlayers = 1;
        bool freshStars = true;

        // Console.WriteLine("Which Mode do you want to use?");
        // Console.WriteLine("1:By weapon type");
        // Console.WriteLine("2:By list");
        // Console.WriteLine("3:Auto weighted");
        // Console.WriteLine("4:Self weighted");

    
        
        Console.WriteLine("Do you want to have Alt Kits?  (y/n)");
        char Input = Console.ReadKey(true).KeyChar;
        if (Input == 'n'){
            altKit = false;
        }
        Console.WriteLine("Will any players do random gear abilitys?  (y/n)");
        Input = Console.ReadKey(true).KeyChar;
        if (Input == 'y'){
            gearAbilitys = true;
        }
        

      
        



        List<(string,bool)> players = new List<(string,bool)>();
        Console.WriteLine("How many players are participating?");
        numberOfPlayers = Convert.ToInt32(Console.ReadLine());
        if (numberOfPlayers > 1)
        {
            freshStars = false;
        }
        bool gear = false;
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.WriteLine("Please give your name");
            string entry = Console.ReadLine();
            if (gearAbilitys == true){
                gear = true;
            }
            players.Add((entry,gear));
        }
        
        while (true)
        {
            weaponTypeInt = random.Next(1, 12);
            foreach ((string,bool) thing in players)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{thing.Item1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'s Weapon is:");
                ByWeaponType(altKit,freshStars);
                if (thing.Item2 == true)
                {  
                    (string,ConsoleColor) abilityOutput = constructAbilitysList(1,false);
                    Console.ForegroundColor = abilityOutput.Item2;
                    Console.Write($"{abilityOutput.Item1} \n");
                    (string,ConsoleColor) abilityOutput2 = constructAbilitysList(2,false);
                    Console.ForegroundColor = abilityOutput2.Item2;
                    Console.Write($"{abilityOutput2.Item1} \n");
                    (string,ConsoleColor) abilityOutput3 = constructAbilitysList(3,false);
                    Console.ForegroundColor = abilityOutput3.Item2;
                    Console.Write($"{abilityOutput3.Item1} \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("---------------------------------------");
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
    public static (string,ConsoleColor) constructAbilitysList(int part,bool specialAbilitys = true){
        List<(string,ConsoleColor)> abilityList = new List<(string,ConsoleColor)>();
        abilityList.Add(("Ink Saver (Main)",ConsoleColor.Yellow));
        abilityList.Add(("Ink Saver (Sub)",ConsoleColor.DarkBlue));
        abilityList.Add(("Ink Recovery Up",ConsoleColor.Green));
        abilityList.Add(("Run Speed Up",ConsoleColor.Magenta));
        abilityList.Add(("Swim Speed Up",ConsoleColor.Magenta));
        abilityList.Add(("Special Charge Up",ConsoleColor.Cyan));
        abilityList.Add(("Special Saver",ConsoleColor.Cyan));
        abilityList.Add(("Special Power Up",ConsoleColor.Green));
        abilityList.Add(("Quick Respawn",ConsoleColor.Green));
        abilityList.Add(("Quick Super Jump",ConsoleColor.Yellow));
        abilityList.Add(("Sub Power Up",ConsoleColor.Green));
        abilityList.Add(("Ink Resistance Up",ConsoleColor.Magenta));
        abilityList.Add(("Sub Resistance Up",ConsoleColor.Magenta));
        abilityList.Add(("Intensify Action",ConsoleColor.Yellow));
        List<string> intermediateList = new List<string>();
        if(specialAbilitys == true){
            if(part == 1){
                intermediateList = new List<string>(File.ReadAllLines("Abilities/Hat"));
                foreach (string thing in intermediateList)
                {
                    abilityList.Add((thing,ConsoleColor.Red));
                }
            }
            if(part == 2){
                intermediateList = new List<string>(File.ReadAllLines("Abilities/Shirt"));
                foreach (string thing in intermediateList)
                {
                    abilityList.Add((thing,ConsoleColor.Red));
                }
            }
            if(part == 1){
                intermediateList = new List<string>(File.ReadAllLines("Abilities/Shoes"));
                foreach (string thing in intermediateList)
                {
                    abilityList.Add((thing,ConsoleColor.Red));
                }
            }
        }
        Random random = new Random();
        int item = random.Next(0,abilityList.Count);
        return abilityList.ElementAt(item);
    }
    
    public static void ByWeaponType(bool DoAltKit = true, bool freshStarsIn = true)
    {
        Random random = new Random();
        int weaponTypeInt = random.Next(1, 12);
        switch (weaponTypeInt)
        {
            case 1:
                //Shooter
                ByWeaponTypePrint("Weapons/Shooters","Weapons/ShootersReKit",DoAltKit,freshStarsIn);
                break;
            case 2:
                //roller
                ByWeaponTypePrint("Weapons/Rollers","Weapons/RollersReKit",DoAltKit,freshStarsIn);
                break;
            case 3:
                //charger
                ByWeaponTypePrint("Weapons/Chargers","Weapons/ChargersReKit",DoAltKit,freshStarsIn);
                break;
            case 4:
                //slosher
                ByWeaponTypePrint("Weapons/Sloshers","Weapons/SloshersReKit",DoAltKit,freshStarsIn);
                break;
            case 5:
                //splatlings   
                ByWeaponTypePrint("Weapons/Splatlings","Weapons/SplatlingsReKit",DoAltKit,freshStarsIn); 
                break;
            case 6:
                //dualies 
                ByWeaponTypePrint("Weapons/Dualies","Weapons/DualiesReKit",DoAltKit,freshStarsIn);  
                break;
            case 7:
                //brella
                ByWeaponTypePrint("Weapons/Brellas","Weapons/BrellasReKit",DoAltKit,freshStarsIn);
                break;
            case 8:
                //blaster
                ByWeaponTypePrint("Weapons/Blasters","Weapons/BlastersReKit",DoAltKit,freshStarsIn);
                break;
            case 9:
                ByWeaponTypePrint("Weapons/Brushes","Weapons/BrushesReKit",DoAltKit,freshStarsIn);
                break;
            case 10:
                //stringer
                ByWeaponTypePrint("Weapons/Stringers","Weapons/StringersReKit",DoAltKit,freshStarsIn);
                break;
            case 11:
                //splatana
                ByWeaponTypePrint("Weapons/Splatana","Weapons/SplatanaReKit",DoAltKit,freshStarsIn);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }



    //print funciton
    public static void ByWeaponTypePrint(string fileName, string KitFileName, bool DoAltKit, bool freshStarsPrint)
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
        List<string> stars = new List<string>();
        incerementer = 0;
        foreach(var thing in new List<string>(LeBruh)){
            string[] splitlist = thing.Split('*');
            LeBruh[incerementer] = splitlist[1];
            stars.Add(splitlist[0]);
            incerementer++;
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
        if (freshStarsPrint == true)
        {
            switch(stars[num]){
                case "0":
                default:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                break;
                case "1":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*");
                break;
                case "2":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("**");
                break;
                case "3":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***");
                break;
                case "4":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("****");
                break;
                case "5":
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("*****");
                break;
            }
        }
    }








    public enum weaponType { Shooter, Roller, Charger, Slosher, Splatling, Daulies, Brella, Blaster, Brush, Stringer, Splatna, Null }
}