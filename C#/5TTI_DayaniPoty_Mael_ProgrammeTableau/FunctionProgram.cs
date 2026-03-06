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
}