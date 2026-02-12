namespace _5TTI_DayaniPoty_Mael_ProgrammeTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tailleTableau;
            int bornInfIntervalle;
            int borneSupIntervalle;

            int[] tableau;
            int[] tableauPairs;
            int[] tableauImpairs;

            string contenu;
            string contenuPairs;
            string contenuImpairs;
            string recommencer;

            do
            {
                LireEntier("Entrez la taille du tableau : ", out tailleTableau);
                LireEntier("Entrez la borne inférieure : ", out bornInfIntervalle);
                LireEntier("Entrez la borne supérieure : ", out borneSupIntervalle);

                CreationTableauAleatoire(
                    tailleTableau,
                    bornInfIntervalle,
                    borneSupIntervalle,
                    out tableau
                );

                ConcatenerContenuTableau(tableau, out contenu);
                Console.WriteLine("Tableau généré aléatoirement :");
                Console.WriteLine(contenu);

                ClasserPairsImpairs(tableau, out tableauPairs, out tableauImpairs);

                ConcatenerContenuTableau(tableauPairs, out contenuPairs);
                ConcatenerContenuTableau(tableauImpairs, out contenuImpairs);

                Console.WriteLine("Nombres pairs :");
                Console.WriteLine(contenuPairs);

                Console.WriteLine("Nombres impairs :");
                Console.WriteLine(contenuImpairs);

                Console.WriteLine("Appuyez sur ESPACE pour recommencer");
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


        static void CreationTableauAleatoire(
            int tailleTableau,
            int bornInfIntervalle,
            int borneSupIntervalle,
            out int[] tableau)
        {
            Random alea = new Random();

            tableau = new int[tailleTableau];

            for (int iPlace = 0; iPlace < tableau.Length; iPlace++)
            {
                tableau[iPlace] = alea.Next(bornInfIntervalle, borneSupIntervalle + 1);
            }
        }


        static void ClasserPairsImpairs(
            int[] tableau,
            out int[] tableauPairs,
            out int[] tableauImpairs)
        {
            int tailleTableau = tableau.Length;

            tableauPairs = new int[tailleTableau];
            tableauImpairs = new int[tailleTableau];

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

        static void ConcatenerContenuTableau(int[] tableau, out string contenu)
        {
            contenu = "";

            for (int i = 0; i < tableau.Length; i++)
            {
                contenu += tableau[i] + "; ";
            }
        }
    }
}

