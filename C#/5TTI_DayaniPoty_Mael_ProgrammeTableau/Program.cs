namespace _5TTI_DayaniPoty_Mael_ProgrammeTableau
{
    internal class Program
    {
        static int Main(string[] _)
        {
            // Ajout d'une matrice comme pour le tableau.
            int tailleMatrice;
            int bornInfIntervalleMatrice;
            int borneSupIntervalleMatrice;
            int tailleTableau;
            int bornInfIntervalle;
            int borneSupIntervalle;

            int[,] matrice;
            int[,] impair;
            int[,] pair; 
            
            int[] tableau;
            int[] tableauPairs;
            int[] tableauImpairs;

            string contenuMatrice;
            string contenuPairsMatrice;
            string contenuImpairsMatrice;
            string contenu;
            string contenuPairs;
            string contenuImpairs;
            string recommencer;

            do
            {
                tailleTableau = FunctionProgram.LireEntier("Entrez la taille du tableau : ");
                bornInfIntervalle = FunctionProgram.LireEntier("Entrez la borne inférieure : ");
                borneSupIntervalle = FunctionProgram.LireEntier("Entrez la borne supérieure : ");
                
                tailleMatrice = FunctionProgram.LireEntier("Entrez la matrice : ");
                bornInfIntervalleMatrice = FunctionProgram.LireEntier("Entrez la borne inférieure : ");
                borneSupIntervalleMatrice = FunctionProgram.LireEntier("Entrez la borne supérieure : ");

                tableau = FunctionProgram.CreationTableauAleatoire(
                    tailleTableau,
                    bornInfIntervalle,
                    borneSupIntervalle
                );
                matrice = FunctionProgram.CreationMatriceAleatoire(
                    tailleMatrice,
                    bornInfIntervalleMatrice,
                    borneSupIntervalleMatrice
                );
                contenuMatrice = FunctionProgram.ConcatenerContenuMatrice(matrice);
                Console.WriteLine("Matrice : " + contenuMatrice);

                contenu = FunctionProgram.ConcatenerContenuTableau(tableau);
                Console.WriteLine("Tableau généré aléatoirement :");
                Console.WriteLine(contenu);

                (tableauPairs, tableauImpairs) = FunctionProgram.ClasserPairsImpairs(tableau);
                (pair, impair) = FunctionProgram.ClasserPairsImpairs(matrice);
                contenuPairsMatrice = FunctionProgram.ConcatenerContenuMatrice(pair);
                contenuImpairsMatrice = FunctionProgram.ConcatenerContenuMatrice(impair);

                contenuPairs = FunctionProgram.ConcatenerContenuTableau(tableauPairs);
                contenuImpairs = FunctionProgram.ConcatenerContenuTableau(tableauImpairs);

                Console.WriteLine("Nombres pairs :");
                Console.WriteLine(contenuPairs);

                Console.WriteLine("Nombres impairs :");
                Console.WriteLine(contenuImpairs);

                Console.WriteLine("Matrice des pairs : " + contenuPairsMatrice);
                Console.WriteLine("Matrice des impairs : " + contenuImpairsMatrice);
                Console.WriteLine("Appuyez sur ESPACE pour recommencer");
                recommencer = Console.ReadLine() ?? "";
            }
            while (recommencer == " ");

            return 0;
        }
    }
}

