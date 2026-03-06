namespace _5TTI_DayaniPoty_Mael_ProgrammeTableau;

public class FunctionProgram
{
    public static int LireEntier(string question)
    {
        int resultat;

        do
        {
            Console.WriteLine(question);
        }
        while (!int.TryParse(Console.ReadLine(), out resultat));

        return resultat;
    }

    public static int[] CreationTableauAleatoire(
        int tailleTableau,
        int bornInfIntervalle,
        int borneSupIntervalle)
    {
        Random alea = new Random();

        int[] tableau = new int[tailleTableau];

        for (int iPlace = 0; iPlace < tableau.Length; iPlace++)
        {
            tableau[iPlace] = alea.Next(bornInfIntervalle, borneSupIntervalle + 1);
        }

        return tableau;
    }
    
    public static int[,] CreationMatriceAleatoire(
        int tailleMatrice,
        int bornInfIntervalle,
        int borneSupIntervalle)
    {
        Random alea = new Random();

        int[,] matrice = new int[tailleMatrice, tailleMatrice];

        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                matrice[iLigne, iColonne] = alea.Next(bornInfIntervalle, borneSupIntervalle + 1);
            }
        }

        return matrice;
    }
    public static (int[,] matricePairs, int[,] matriceImpairs) ClasserPairsImpairs(int[,] matrice)
    {
        int tailleMatrice = matrice.GetLength(0);

        int[,] matricePairs = new int[tailleMatrice, tailleMatrice];
        int[,] matriceImpairs = new int[tailleMatrice, tailleMatrice];

        for (int iLigne = 0; iLigne < tailleMatrice; iLigne++)
        {
            int iPair = 0;
            int iImpair = 0;

            for (int iColonne = 0; iColonne < tailleMatrice; iColonne++)
            {
                if (matrice[iLigne, iColonne] % 2 == 0)
                {
                    matricePairs[iLigne, iPair] = matrice[iLigne, iColonne];
                    iPair++;
                }
                else
                {
                    matriceImpairs[iLigne, iImpair] = matrice[iLigne, iColonne];
                    iImpair++;
                }
            }
        }

        return (matricePairs, matriceImpairs);
    }

    public static (int[] tableauPairs, int[] tableauImpairs) ClasserPairsImpairs(int[] tableau)
    {
        int tailleTableau = tableau.Length;

        int[] tableauPairs = new int[tailleTableau];
        int[] tableauImpairs = new int[tailleTableau];

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

        return (tableauPairs, tableauImpairs);
    }

    public static string ConcatenerContenuTableau(int[] tableau)
    {
        string contenu = "";

        for (int i = 0; i < tableau.Length; i++)
        {
            contenu += tableau[i] + "; ";
        }

        return contenu;
    }

    public static string ConcatenerContenuMatrice(int[,] matrice)
    {
        string contenu = "";

        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                contenu += matrice[iLigne, iColonne] + "; ";
            }

            contenu += Environment.NewLine;
        }

        return contenu;
    }
}