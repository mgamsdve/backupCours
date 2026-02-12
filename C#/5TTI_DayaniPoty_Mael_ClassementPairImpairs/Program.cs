namespace _5TTI_DayaniPoty_Mael_ClassementPairImpairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau; //Tableau à classer
            int[] tableauPairs; //Tableau contenant tout les chiffres pairs
            int[] tableauImpairs; //Tableau contenant tout les chiffres impairs
            int tailleTableau; //Taille du tableau à classer
            string contenuPairs; //Contenu du tableau des pairs
            string contenuImpairs; //Contenu du tableau des impairs
            string recommencer; //boucle recommencer

            do
            {
                do
                {
                    LireEntier("Nombre de places dans votre tableau (>= 0) : ", out tailleTableau);
                }
                while (tailleTableau < 0);
                remplirTableau(tailleTableau, out tableau);

                ClasserPairsImpairs(tableau, out tableauPairs, out tableauImpairs);

                lireTableau(tableauPairs, out contenuPairs);
                lireTableau(tableauImpairs, out contenuImpairs);

                Console.WriteLine("Tableau des nombres pairs :");
                Console.WriteLine(contenuPairs);

                Console.WriteLine("Tableau des nombres impairs :");
                Console.WriteLine(contenuImpairs);

                Console.WriteLine("Entrez espace pour recommencer.");
                recommencer = Console.ReadLine();
            }
            while (recommencer == " ");
        }


        static void LireEntier(string question, out int resultat)
        {
            do
            {
                Console.WriteLine(question);
            }
            while (!int.TryParse(Console.ReadLine(), out resultat));
        }


        static void remplirTableau(int tailleTableau, out int[] tableau)
        {
            tableau = new int[tailleTableau];

            for (int i = 0; i < tableau.Length; i++)
            {
                do
                {
                    LireEntier("Entrez la valeur STRICTEMENT POSITIVE de la place " + i + " : ", out tableau[i]);
                }
                while (tableau[i] <= 0);
            }
        }

        static void lireTableau(int[] tableau, out string contenu)
        {
            contenu = "";

            for (int i = 0; i < tableau.Length; i++)
            {
                contenu += tableau[i] + "; ";
            }
        }


        static void ClasserPairsImpairs(int[] tableau, out int[] tableauPairs, out int[] tableauImpairs)
        {
            int tailleTableau = tableau.Length; //taille du tableau à classer

            tableauPairs = new int[tailleTableau]; //initialisation du tableau des pairs
            tableauImpairs = new int[tailleTableau]; //initialisation du tableau des impairs

            int iPair = 0;
            int iImpair = 0;

            for (int i = 0; i < tailleTableau; i++)
            {
                if (tableau[i] % 2 == 0)
                {
                    tableauPairs[iPair] = tableau[i];
                    iPair++;
                }
                else
                {
                    tableauImpairs[iImpair] = tableau[i];
                    iImpair++;
                }
            }
        }
    }
}
