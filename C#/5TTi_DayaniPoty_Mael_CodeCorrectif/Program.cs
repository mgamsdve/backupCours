using System.Numerics;

namespace _5TTi_DayaniPoty_Mael_CodeCorrectif
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
                            int nDepart; //nombre pour lequel on cherche les diviseurs
                            string diviseurs; //contient l’ensemble des diviseurs de nDepart

                            do
                            {
                                LireEntier("Veuillez entrer la valeur de nombre", out nDepart);
                            } while (nDepart <= 0 || nDepart >= 10000);

                            ListeDiviseur(nDepart, out diviseurs);
                            Console.WriteLine("Les chiffres qui divisent " + nDepart + " sont : " + diviseurs);

                            break;
                        }

                    case 2:
                        {
                            int borneInf; //borne inférieure de l’intervalle
                            int borneSup; //borne supérieure de l’intervalle
                            string listeNbParfaits; //contient l’ensemble des nombres parfaits compris dans l’intervalle fourni

                            do
                            {
                                LireEntier("Entrez une valeur pour a : ", out borneInf);
                                LireEntier("Entrez une valeur pour b : ", out borneSup);
                            }
                            while (borneInf <= 2 || borneInf >= borneSup);

                            NombresParfaits(borneInf, borneSup, out listeNbParfaits);
                            Console.WriteLine(listeNbParfaits);

                            break;
                        }

                    case 3:
                        {
                            int n; //nombre de nombres premiers souhaités
                            string listeNbPremiers; //liste des n premiers nombres premiers

                            do
                            {
                                LireEntier("Entrez la valeur de N : ", out n);
                            } while (n <= 1);

                            NombresPremiers(n, out listeNbPremiers);
                            Console.WriteLine(listeNbPremiers);
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

        static void ListeDiviseur(int nDepart, out string diviseurs)
        {
            int iNombre; //chiffre qui sont potentiellement diviseurs
            diviseurs = "";
            for (iNombre = 2; iNombre <= nDepart; iNombre++)
            {
                if (nDepart % iNombre == 0)
                {
                    diviseurs += iNombre + ", ";
                }
            }
        }

        static void NombresParfaits(int borneInf, int borneSup, out string listeNbParfaits)
        {
            int iDiviseur; //Diviseur à tester
            int totalDiviseurs; //Somme des diviseurs d’un nombre
            int iNombre; //Sert à parcourir les nombres compris dans l’intervalle
            listeNbParfaits = "Les nombres parfaits compris dans l'intervalle ] " + borneInf + ", " + borneSup + " [ sont : ";
            for (iNombre = borneInf + 1; iNombre <= borneSup - 1; iNombre++)
            {
                totalDiviseurs = 0;
                for (iDiviseur = 1; iDiviseur <= (iNombre - 1); iDiviseur++)
                {
                    if (iNombre % iDiviseur == 0)
                    {
                        totalDiviseurs += iDiviseur;
                    }
                }
                if (totalDiviseurs == iNombre)
                {
                    listeNbParfaits += iNombre + ", ";
                }
            }
        }

        static void NombresPremiers(int n, out string listeNbPremiers)
        {
            int compteNombresPremiers; //compteur de nombres premiers
            int iNombre; //Sert à parcourir les nombres entiers
            bool ok; //sert à valider si le nombres est bien premier
            int iDiviseur; //sert à tester les diviseurs possibles d’un nombre

            compteNombresPremiers = 0;
            listeNbPremiers = "Les " + n + " premiers nombres premiers sont : ";
            iNombre = 2;

            while (compteNombresPremiers < n)
            {
                iDiviseur = 2;
                ok = true;
                while ((iDiviseur < iNombre) && ok)
                {
                    if (iNombre % iDiviseur == 0)
                    {
                        ok = false;
                    }
                    iDiviseur++;
                }
                if (ok)
                {
                    listeNbPremiers += iNombre + ", ";
                    compteNombresPremiers++;
                }
                iNombre++;
            }

        }

    }
}
