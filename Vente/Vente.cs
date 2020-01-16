/*
    Programmeur:        Jonathan Zogona
    Date:               12/12/2019

    Solution:           VenteDeSmartPhones.sln
    Projet:             VenteDeSmartPhones.csproj
    Classe:             Vente.cs
    
    But:                Créer une application qui gère un service de vente de smartphones
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace VenteDeSmartPhones
{
    /// <summary>
    /// Objet métier : Vente
    /// </summary>
    /// <remarks>Tous droits réservés SmartPhones Inc 2019<remarks>
    public class Vente
    {
        #region Champs privés

        // Constante pour délimiteur
        private const Char DELIMITEURS_CHAR = ';';

        // Variables pour les données
        private string[] tVendeursString;
        private string[] tModelesString;
        private Decimal[] tPrixDecimal;

        // Variables des champs du formulaire
        private Decimal prixTotalDecimal;
        private string nomClientString;
        private string nomVendeurString;
        private string modeleString;
        private DateTime dateTransactionDateTime;

        // Variable pour la culture courante
        private System.Globalization.CultureInfo enCaCultureInfo = new System.Globalization.CultureInfo("en-Ca");

        #endregion

        #region Propriétés

        /// <summary>
        /// Prix total smartphone
        /// </summary>
        public Decimal PrixTotal
        {
            get
            {
                return prixTotalDecimal;
            }
            set
            {
                if (value > 0.0M)
                    prixTotalDecimal = value;
                else
                    throw new Exception("Le prix total du smartphon est invalide");
            }
        }

        /// <summary>
        /// Nom du client
        /// </summary>
        public string NomClient
        {
            get
            {
                return nomClientString;
            }
            set
            {
                value = value.Trim();
                if (value != String.Empty)
                    nomClientString = value;
                else                
                    throw new Exception("Le nom du client est obligatoire");
            }
        }

        /// <summary>
        /// Nom du vendeur de smartphone
        /// </summary>
        public string NomVendeur
        {
            get
            {
                return nomVendeurString;
            }
            set
            {
                if(value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tVendeursString, value) != -1)
                        nomVendeurString = value;
                    else
                        throw new Exception("Le nom du vendeur est invalide");
                }
                else
                    throw new Exception("Le nom du vendeur est obligatoire");
            }
        }

        /// <summary>
        /// Modèle du smartphone
        /// </summary>
        public string Modele
        {
            get
            {
                return modeleString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tModelesString, value) != -1)
                        modeleString = value;
                    else
                        throw new Exception("Le modèle est invalide");
                }
                else
                    throw new Exception("Le modèle est obligatoire");
            }
        }

        /// <summary>
        /// Date de transaction du smartphone
        /// </summary>
        public DateTime Date
        {
            get
            {
                return dateTransactionDateTime;
            }
            set
            {
                if (value != null)
                    dateTransactionDateTime = value;
                else
                    throw new Exception("La date de transaction est obligatoire");
            }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur de "smartphone vendu" sans paramètre
        /// </summary>
        public Vente()
        {
            InitVendeurs();
            InitModèlesPrix();
        }

        #endregion

        #region Initialisation : Tableaux de vendeurs, modèles et prix

        /// <summary>
        /// Initialise le tableau de vendeurs
        /// </summary>
        private void InitVendeurs()
        { 
            try
            {
                using (StreamReader sr = new StreamReader(@"../../Data/vendeurs.data", System.Text.Encoding.UTF8))
                {
                    int nombre = 0;

                    nombre = int.Parse(sr.ReadLine());

                    Array.Resize(ref tVendeursString, nombre);

                    for (int i = 0; i <= nombre - 1; i++)
                    {
                        tVendeursString[i] = (sr.ReadLine()).Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible d'initialiser la liste des vendeurs. Veuillez contacter le programmeur." +
                    Environment.NewLine + ex.Message);
            }
        }


        /// <summary>
        /// Initialise le tableau de modèles et des prix
        /// </summary>
        private void InitModèlesPrix()
        {
            try
            {
                tModelesString = new string[100];
                tPrixDecimal = new Decimal[100];

                using (StreamReader sr = new StreamReader(@"../../Data/modeleSmartphone.data", System.Text.Encoding.UTF8))
                {
                    string modelePrix;
                    int nombre = 0;   

                    modelePrix = sr.ReadLine().Trim();

                    while(modelePrix != null)
                    {
                        string[] champs = (modelePrix.Trim()).Split(DELIMITEURS_CHAR);
                        tModelesString[nombre] = champs[0].Trim();
                        tPrixDecimal[nombre] = Decimal.Parse(champs[1].Trim(), enCaCultureInfo);
                        nombre++;
                        modelePrix = sr.ReadLine();
                    }

                    Array.Resize(ref tModelesString, nombre);
                    Array.Resize(ref tPrixDecimal, nombre);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible d'initialiser la liste des modeles et celle des prix. Veuillez contacter le programmeur." +
                    Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region Méthodes privées

        #endregion

        #region Méthodes publiques

        #region Getteurs

        /// <summary>
        /// Méthode pour récupérer le tableau de vendeurs 
        /// </summary>
        /// <returns>tVendeursString : Tableaux de string contenant la liste des vendeurs de smartphones</returns>
        public string[] GetVendeurs()
        {
            return tVendeursString;
        }

        /// <summary>
        /// Méthode pour récupérer le tableau de modèles 
        /// </summary>
        /// <returns>tModelesString : Tableaux de string contenant la liste des modèles de smartphones</returns>
        public string[] GetModeles()
        {
            return tModelesString;
        }

        /// <summary>
        /// Determiner le prix d'un modele de smartphone basé sur l'index du modele 
        /// selectionné dans le comboBox des modèles
        /// </summary>
        /// <param name="indexModele">indice du modèle de smartphone</param>
        /// <returns>Decimal : Prix sans taxe du smartphone</returns>
        public Decimal GetPrix(int indexModele)
        {
            if (indexModele >= 0 && indexModele < tPrixDecimal.Length)
                return tPrixDecimal[indexModele];
            else
                throw new Exception("Il est impossible d'obtenir le prix à partir de l'index du modèle fournie.");
        }

        #endregion

        #region Enregistrer

        /// <summary>
        /// Enregistrer la transaction courante
        /// </summary>
        /// <param name="pPrixTotal">Decimal : Prix total incluant taxe</param>
        /// <param name="pNomClient">String : Nom du client</param>
        /// <param name="pNomVendeur">String : Nom du vendeur</param>
        /// <param name="pModele">String : Modèle du smartphone</param>
        /// <param name="pDate">String : Date de vente</param>
        public void Enregistrer(Decimal pPrixTotal, string pNomClient, string pNomVendeur, string pModele, DateTime pDate)
        {
            this.PrixTotal = pPrixTotal;
            this.NomClient = pNomClient;
            this.NomVendeur = pNomVendeur;
            this.Modele = pModele;
            this.Date = pDate;

            try
            {
                using (StreamWriter expeditionStreamWriter = new StreamWriter(@"../../Data/Transactions.data", true, System.Text.Encoding.UTF8))
                {
                    string enregistrement = "{0};{1};{2};{3};{4}";

                    expeditionStreamWriter.WriteLine(string.Format(enregistrement,
                        this.NomClient, this.Date.ToShortDateString(), this.NomVendeur, 
                        this.Modele, (this.PrixTotal).ToString(enCaCultureInfo)));
                }

            }
            catch(Exception ex)
            {
                throw new Exception("Impossible d'enregistrer la transaction. Veuillez contacter le programmeur." +
                    Environment.NewLine + ex.Message);
            }

        }

        #endregion

        #region Imprimer

        /// <summary>
        /// Imprimer la transaction courante
        /// </summary>
        /// <param name="nomCompagnie">String : Nom de la compagnie</param>
        public void ImprimerTransactions(string nomCompagnie)
        {
             decimal totalPrix = 0.0M;
            try
            {
                using(StreamReader sr = new StreamReader("../../Data/Transactions.data", Encoding.UTF8))
                {
                    string[] champs;

                    string ligne = "{0,-15} {1, -30} {2, -15} {3}";

                    Console.WriteLine(nomCompagnie + " " + "Jonathan ZOGONA");
                    Console.WriteLine("Date: " + DateTime.Now.ToLongDateString() + Environment.NewLine);

                    Console.WriteLine(string.Format(ligne, "Vendeur", "Modele", "Prix", "Date") + Environment.NewLine);

                    string enregistrement = sr.ReadLine();

                    while(enregistrement != null)
                    {
                        champs = enregistrement.Split(DELIMITEURS_CHAR);   
                        Console.WriteLine(string.Format(ligne,champs[2],champs[3], (Decimal.Parse(champs[4])).ToString("C2"), champs[1]));

                        totalPrix += Decimal.Parse(champs[4], enCaCultureInfo);

                        enregistrement = sr.ReadLine();
                    }

                    Console.WriteLine(Environment.NewLine + "Total des ventes : " + totalPrix.ToString("C2"));
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Impossible d'imprimer la transaction. Veuillez contacter le programmeur." +
                    Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #endregion
    }
}
