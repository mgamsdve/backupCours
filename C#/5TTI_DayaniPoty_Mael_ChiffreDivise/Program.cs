namespace _5TTI_DayaniPoty_Mael_ChiffreDivise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer; //Permet de recommencer le programme
            int choixProgramme; 
            // Titre de bienvenue
            Console.WriteLine("Bienvenue dans le programme des chiffres");

            //boucle recommencer
            do
            {
                do
                {
                    LireEntier("Choisissez le programme que vous voulez utiliser : \n1: Chiffre divisé \n2: Nombres parfait \n3: Nombres premiers", out choixProgramme);
                } while (choixProgramme != 1 && choixProgramme != 2 && choixProgramme != 3);

                switch (choixProgramme)
                {
                    case 1:
                        {
                            int nombre; //nombre encoder
                            string chiffreDiviseur; //contient tout les chiffres diviseurs

                            do
                            {
                                LireEntier("Veuillez entrer la valeur de nombre", out nombre);
                            } while (nombre < 0 || nombre >= 10000);

                            ChiffreDivise(nombre, out chiffreDiviseur);
                            Console.WriteLine("Les chiffres qui divisent " + nombre + " sont : " + chiffreDiviseur);

                            break;
                        }

                    case 2:
                        {
                            int a; //nombre pour le début de la ranger
                            int b; //nombre pour la fin de la ranger
                            string nombreParfait; //Contient les divers nombres parfaits

                            do
                            {
                                LireEntier("Entrez une valeur pour a : ", out a);
                                LireEntier("Entrez une valeur pour b : ", out b);
                            }
                            while (a <= 2 || a >= b);

                            NombreParfait(a, b, out nombreParfait);
                            Console.WriteLine("Les nombres parfaits entre " + a + " et " + b + " sont : " + nombreParfait);

                            break;
                        }

                    case 3:
                        {
                            int N; //le nombre de nombre premier demandé
                            string nombresPremiers; //contient tout les nombres premiers demandé

                            do
                            {
                                LireEntier("Entrez la valeur de N : ", out N);
                            } while (N < 0);

                            NombresPremiers(N, out nombresPremiers);
                            Console.WriteLine("Les " + N + " premiers nombres premiers sont : " + nombresPremiers);
                            break;
                        }
                    default:
                        break;
                }



                Console.WriteLine("Entrez espace pour recommencer");
                recommencer = Console.ReadLine();
            } while (recommencer == " ");
        }

        static void LireEntier(string question, out int resultat)
        {
            do
            {
                Console.WriteLine(question);
            }
            while (!int.TryParse(Console.ReadLine(), out resultat));
        }


        static void ChiffreDivise(int nombre, out string chiffreDiviseur)
        {
            int chiffre; //chiffre qui sont potentiellement diviseurs
            chiffreDiviseur = "";
            for (chiffre = 2; chiffre <= 9; chiffre++)
            {
                if (nombre % chiffre == 0)
                {
                    chiffreDiviseur += chiffre + ", ";
                }
            }
        }

        static void NombreParfait(int a, int b, out string nombreParfait)
        {
            int diviseur; //sert à chercher tous les diviseur du nombre
            int somme; //sert à stocker la somme des diviseur
            int nombre; //nombre potentiellement parfait
            nombreParfait = "";
            for (nombre = a; nombre <= b; nombre++)
            {
                somme = 0;
                for (diviseur = 1; diviseur <= (nombre - 1); diviseur++)
                {
                    if (nombre % diviseur == 0)
                    {
                        somme += diviseur;
                    }
                }
                if (somme == nombre)
                {
                    nombreParfait += nombre + ", ";
                }
            }
        }

        static void NombresPremiers(int N, out string nombresPremiers)
        {
            int compteurNbrPremier; //sert à compter les nombres premier trouver
            int nombre; //sert à parcourir et tester les divers nombre pour savoir lesquels sont premiers
            bool nbrEstPremier; //sert à valider si le nombres est bien premier
            int diviseur; //sert à parcourir les diviseur de chaques nombres pour savoir s’ils sont premiers

            compteurNbrPremier = 0;
            nombresPremiers = "";
            nombre = 2;

            do
            {
                nbrEstPremier = true;
                for (diviseur = 2; diviseur <= (nombre - 1); diviseur++)
                {
                    if (nombre % diviseur == 0)
                    {
                        nbrEstPremier = false;
                    }
                }
                if (nbrEstPremier)
                {
                    nombresPremiers += nombre + ", ";
                    compteurNbrPremier++;
                }
                nombre++;
            } while (compteurNbrPremier != N);
        }
    }
}
