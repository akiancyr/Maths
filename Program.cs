

    Console.WriteLine("Qu'elle est la mémoire demandé (octet, Ko, Mo, Go, To)");
    string question = Console.ReadLine();
    
    switch (question.ToLower())
    {
        case "octet":
            Console.WriteLine("Vous avex choisi octet");
            break;
        case "ko":
            Console.WriteLine("Vous avez choisi kilo-octet");
            break;
        case "mo":
            Console.WriteLine("Vous avez choisi mégaoctet");
            break;
        case "go":
            Console.WriteLine("Vous avez choisi gigaoctet.");
            break;
        case "to":
            Console.WriteLine("Vous avez choisi téraoctet");
            break;
    }
   

    if (question.ToLower() == "octet")
    {
        Console.WriteLine("Qu'elle est le nombre de la mémoire en octet");
        double memoire = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qu'elle est le nombre de bits?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * 8 / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
else if (question.ToLower() == "ko")
    {
        Console.WriteLine("Qu'elle est le nombre de la mémoire en kilo-octet (KO)");
        double memoire = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qu'elle est le nombre de bits?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * Math.Pow(2, 10) / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
    else if (question.ToLower() == "mo")
    {
        Console.WriteLine("Qu'elle est le nombre de la mémoire en mégaoctet (MO)");
        double memoire = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qu'elle est le nombre de bits?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * Math.Pow(2, 20) / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
    else if (question.ToLower() == "go")
    {
        Console.WriteLine("Qu'elle est le nombre de la mémoire en gigaoctet (GO)");
        double memoire = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qu'elle est le nombre de bits?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * Math.Pow(2, 30) / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
else if (question.ToLower() == "to")
    {
        Console.WriteLine("Qu'elle est le nombre de la mémoire en téraoctet (TO)");
        double memoire = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qu'elle est le nombre de bits?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * Math.Pow(2, 40) / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
    Console.WriteLine("Terminé");
