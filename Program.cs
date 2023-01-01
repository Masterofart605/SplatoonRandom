internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int weaponTypeInt = random.Next(1,12);
        int chosenWeapon = 0;
        bool freshStars = true;
        weaponType weaponTypeToo = weaponType.Null;
        Console.WriteLine("");
        switch(weaponTypeInt){
            case 1:
                weaponTypeToo = weaponType.Shooter;
                chosenWeapon = random.Next(1,20);
                Console.Write("Your weapon is the shooter: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splatershot Jr. \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Custom Splatershot Jr. \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splatershot \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Tentatek Splatershot \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splatershot Pro \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Forge Splatershot Pro \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splattershot Nova \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 8:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splash-o-matic \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 9:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Sploosh-o-matic \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 10:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Aerospray MG \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 11:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Aerospray RG \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 12:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Hero Shot Replica \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 13:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(".52 Gal \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 14:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(".96 Gal \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("L-3 Nozzlenose \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 16:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("H-3 Nozzlenose \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 17:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("N-ZAP '85 \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 18:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Jet Squelcher \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 19:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Squeezer \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 2:
                weaponTypeToo = weaponType.Roller;
                chosenWeapon = random.Next(1,7);
                Console.Write("Your weapon is the roller: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Carbon Roller \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 3 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Carbon Roller Deco \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 2 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splat Roller \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 2 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dynamo Roller \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 2 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Flingza Roller \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Big Swig Roller \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 3:
                weaponTypeToo = weaponType.Charger;
                chosenWeapon = random.Next(1,9);
                Console.Write("Your weapon is the charger: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splat Charger \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splaterscope \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("E-liter 4k \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("E-liter 4k Scope \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Classic Squiffer \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bamboozler 14 mk I \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Goo Tuber \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 8:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Snipewriter 5H \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 4:
                weaponTypeToo = weaponType.Slosher;
                chosenWeapon = random.Next(1,7);
                Console.Write("Your weapon is the slosher: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Slosher \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Slosher Deco \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Tri-Slosher \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 3 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Sloshing Machine \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 2 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bloblobber \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 4 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Explosher \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 5:
                weaponTypeToo = weaponType.Splatling;
                chosenWeapon = random.Next(1,7);
                Console.Write("Your weapon is the splatling: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Mini Splatling \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Zink Mini Splatling \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                    
                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Heavy Splatling \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Hydra Splatling \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                    
                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Nautilus 47 \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ballpoint Splatling \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 6:
                weaponTypeToo = weaponType.Daulies;
                chosenWeapon = random.Next(1,7);
                Console.Write("Your weapon is the dualies: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splat Dualies \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dapple Dualies \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dapple Dualies Nouveau \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Glooga Dualies \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dualie Squelchers \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dark Tetra Dualies \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 7:
                weaponTypeToo = weaponType.Brella;
                chosenWeapon = random.Next(1,4);
                Console.Write("Your weapon is the brella: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splat Brella \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Tenta Brella \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Undercover Brella \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 8:
                weaponTypeToo = weaponType.Blaster;
                chosenWeapon = random.Next(1,8);
                Console.Write("Your weapon is the blaster: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Luna Blaster \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Luna Blaster Neo \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Blaster \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Range Blaster \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Rapid Blaster \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Rapid Blaster Pro \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Clash Blaster \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 9:
                weaponTypeToo = weaponType.Brush;
                chosenWeapon = random.Next(1,4);
                Console.Write("Your weapon is the brush: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Inkbrush \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 2 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Inkbrush Nouveau \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This is a reskin.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;

                    case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Octobrush \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 0 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 10:
                weaponTypeToo = weaponType.Stringer;
                chosenWeapon = random.Next(1,3);
                Console.Write("Your weapon is the stringer: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Tri-Stringer \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("REEF-LUX 450 \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            case 11:
                weaponTypeToo = weaponType.Splatna;
                chosenWeapon = random.Next(1,3);
                Console.Write("Your weapon is the splatana: ");
                switch(chosenWeapon){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splatana Stamper \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Splatana Wiper \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (freshStars == true){
                        Console.WriteLine("the weapon has 1 star(s) of freshness");
                    }
                    break;
                }
            break;
            default:
                Console.WriteLine("You should not see this");
            break;
        }
        Console.WriteLine(" ");
    }
    public enum weaponType { Shooter, Roller, Charger, Slosher, Splatling, Daulies, Brella, Blaster, Brush, Stringer, Splatna, Null}
}