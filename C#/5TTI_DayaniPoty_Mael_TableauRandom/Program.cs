namespace _5TTI_DayaniPoty_Mael_TableauRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tailleTableau;
            int borneInf;
            int borneSup;
            int[] tableau;
            string contenu;
            string recommencer;

            do
            {
                do
                {
                    LireEntier("Taille du tableau (> 0) : ", out tailleTableau);
                }
                while (tailleTableau <= 0);

                LireEntier("Borne inférieure : ", out borneInf);
                LireEntier("Borne supérieure : ", out borneSup);

                while (borneSup < borneInf)
                {
                    Console.WriteLine("La borne supérieure doit être >= à la borne inférieure.");
                    LireEntier("Borne supérieure : ", out borneSup);
                }

                CreationTableauAleatoire(tailleTableau, borneInf, borneSup, out tableau);

                ConcatenerContenuTableau(tableau, out contenu);
                Console.WriteLine("Tableau généré :");
                Console.WriteLine(contenu);

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

        static void CreationTableauAleatoire(int tailleTableau, int bornInfIntervalle, int borneSupIntervalle, out int[] tableau)
        {
            Random alea = new Random();
            tableau = new int[tailleTableau];

            for (int iPlace = 0; iPlace < tableau.Length; iPlace++)
            {
                tableau[iPlace] = alea.Next(bornInfIntervalle, borneSupIntervalle + 1);
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
