

Console.WriteLine("Faire un choix: \n choix '1'calculer le nombre d'adresse possible selon le nombre de bits \n choix '2' Calculer memoire adresse selon espace memoire et nombre de bits ");
char choix = Convert.ToChar(Console.ReadLine());

switch (choix)
{
    case '1':
        Calcul();
        break;
    case '2':
        TrouverMemoireAdresse();
        break;
}
static void Calcul()
{


    Console.WriteLine("Tout les calcules sont fait selon 'la convention des octets sans normalisation CEI' ");
    Console.WriteLine(" Qu'elle est le nombre de bits du 'Mots'?");
    int mots = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qu'elle est le nombre de bits de l'adresse?");
    int adresse = Convert.ToInt32(Console.ReadLine());

    double octet = Math.Pow(2, adresse);
    double bit = octet * 8;
    double kiloOctet = octet / Math.Pow(2, 10);
    double megaoctet = kiloOctet / Math.Pow(2, 20);
    double gigaoctet = megaoctet / Math.Pow(2, 30);
    double teraoctet = gigaoctet / Math.Pow(2, 40);
    double taille = Math.Pow(2, adresse) * mots / 8;
    
    Console.WriteLine("Voulez vous votre réponse en (Écrire abréviation) \n -bits \n -octet \n -kilo-octet (KO) \n -mégaoctet (MO) \n -gigaoctet (GO) \n -téraoctet (TO)");
    string choix = Console.ReadLine();

    switch (choix.ToLower())
    {
        case "bits":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {bit} bits");
            break;
        
        case "octet":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {octet} Octets");
            break;
        
        case "ko":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {kiloOctet} kilo-octets");
            break;
        
        case "mo":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {megaoctet} mégaoctets");
            break;
        
        case "go":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {gigaoctet} gigaoctets");
            break;
        
        case "to":
            Console.WriteLine(
                $"Si une mémoire stocke des mots de {mots / 8} Octets et nécessite {adresse} bits pour adresser, la valeur totale en octets est {teraoctet} teraoctets");
            break;

    }


}
//Une mémoire possède une espace totale de 32 MO et peut stocker des mots de 32 bits. De combien de bits a-t-on besoin pour representer les adresses dans cette mémoire.

// taille totale = nbradresse * taille1mots
static void TrouverMemoireAdresse()
{
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

        Console.WriteLine("Qu'elle est le nombre de bits du 'Mots'?");
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

        Console.WriteLine("Qu'elle est le nombre de bits du 'Mots'?");
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

        Console.WriteLine("Qu'elle est le nombre de bits du 'Mots'?");
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

        Console.WriteLine("Qu'elle est le nombre de bits du 'Mots'?");
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

        Console.WriteLine("Qu'elle est le nombre de bits du 'Mots'?");
        double nbrDeBits = Convert.ToDouble(Console.ReadLine());

        nbrDeBits = nbrDeBits / 8;
        double calcul = memoire * Math.Pow(2, 40) / nbrDeBits;
        double resultat2 = Math.Log(calcul) / Math.Log(2);

        Console.Write($"Dans chaque adresses ont besoin de {resultat2} bits pour être représenter.");
    }
    
    

}
