

ruoka1 pääaine = ruoka1.nautaa;
ruoka2 sivuaine = ruoka2.perunaa;
ruoka3 mauste = ruoka3.chili;

Console.WriteL("Pääruoka-aine (nautaa, kanaa, kasviksia) ");
string pääInput = Console.ReadLine();
    if (pääInput != null){
        if (pääInput == "nautaa"){
        pääaine = ruoka1.nautaa;
        }
        if (pääInput == "kanaa"){
            pääaine = ruoka1.kanaa;
        }
        if (pääInput == "kanaa"){
            pääaine = ruoka1.kanaa;
        }
    }
Console.Write("Sivuruoka-aine (perunaa, riisiä, pastaa) ");
string sivuInput = Console.ReadLine();
    if (sivuInput != null){
        if (sivuInput == "perunaa"){
            sivuaine = ruoka2.perunaa;
        }
        if (sivuInput == "riisä"){
            sivuaine = ruoka2.riisiä;
        }
        if (sivuInput == "pastaa"){
            sivuaine = ruoka2.pastaa;
        }
    }
Console.Write("Mauste (pippuri, chili, tomaatti, curry) ");
string mausteInput = Console.ReadLine();
    if (mausteInput != null){
        if (mausteInput == "pippuri"){
            mauste = ruoka3.pippuri;
        }
        if (mausteInput == "chili"){
            mauste = ruoka3.chili;
        }
        if (mausteInput == "tomaatti"){
            mauste = ruoka3.tomaatti;
        }
        if (mausteInput == "curry"){
            mauste = ruoka3.curry;
        }
        Console.WriteLine($"{pääaine} ja {sivuaine} {mauste}-kastikkeella.");
    }




enum ruoka1{
    nautaa,
    kanaa,
    kasviksia
}
enum ruoka2{
    perunaa,
    riisiä,
    pastaa
}
enum ruoka3{
    curry,
    tomaatti,
    pippuri,
    chili
}