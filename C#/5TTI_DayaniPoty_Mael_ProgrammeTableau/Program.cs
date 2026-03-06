namespace _5TTI_DayaniPoty_Mael_ProgrammeTableau
{
    internal class Program
    {
        static void Main(string[] _)
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
                tailleTableau = FunctionProgram.LireEntier("Entrez la taille du tableau : ");
                bornInfIntervalle = FunctionProgram.LireEntier("Entrez la borne inférieure : ");
                borneSupIntervalle = FunctionProgram.LireEntier("Entrez la borne supérieure : ");

                tableau = FunctionProgram.CreationTableauAleatoire(
                    tailleTableau,
                    bornInfIntervalle,
                    borneSupIntervalle
                );

                contenu = FunctionProgram.ConcatenerContenuTableau(tableau);
                Console.WriteLine("Tableau généré aléatoirement :");
                Console.WriteLine(contenu);

                (tableauPairs, tableauImpairs) = FunctionProgram.ClasserPairsImpairs(tableau);

                contenuPairs = FunctionProgram.ConcatenerContenuTableau(tableauPairs);
                contenuImpairs = FunctionProgram.ConcatenerContenuTableau(tableauImpairs);

                Console.WriteLine("Nombres pairs :");
                Console.WriteLine(contenuPairs);

                Console.WriteLine("Nombres impairs :");
                Console.WriteLine(contenuImpairs);

                Console.WriteLine("Appuyez sur ESPACE pour recommencer");
                recommencer = Console.ReadLine() ?? "";
            }
            while (recommencer == " ");
        }
    }
}

