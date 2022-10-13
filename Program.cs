
        Console.WriteLine("Qu'elle est la mémoire demandé (choisir nombre) \n 1- octet \n 2- Ko \n 3- Mo \n 4- Go \n 5- To");
       int question = Convert.ToInt32(Console.ReadLine());
        switch (question)
        {
            case 1:
                Console.WriteLine("Vous avex choisi octet");
                break;
            case 2:
                Console.WriteLine("Vous avez choisi kilo-octet");
                break;
            case 3:
                Console.WriteLine("Vous avez choisi mégaoctet");
                break;
            case 4:
                Console.WriteLine("Vous avez choisi gigaoctet.");
                break;
            case 5:
                Console.WriteLine("Vous avez choisi téraoctet");
                break;
            default:
                Console.WriteLine("Vous avez mal entrer la mémoire. Recommencer!");
                break;
        }

        if (question == 1)
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
else if (question == 2)
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
    else if (question == 3)
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
    else if (question == 4)
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
else if (question == 5)
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
