/*
    Programmeur:        Jonathan Zogona
    Date:               12/12/2019

    Solution:           VenteDeSmartPhones.sln
    Projet:             VenteDeSmartPhones.csproj
    Classe:             VenteDeSmartPhonesForm.cs
    
    But:                Créer une application qui gère un service de vente de smartphones
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace VenteDeSmartPhones
{
    /// <summary>
    /// Service de vente de smartphones
    /// </summary>
    public partial class venteDeSmartphonesForm : Form
    {
        #region Champs privées

        // Constantes
        private const Decimal TAXE_DECIMAL = 1.15M;

        // Variables pour le formulaire
        private Vente oVente;

        // Variable pour la culture
        private System.Globalization.CultureInfo enCaCultureInfo = new System.Globalization.CultureInfo("en-Ca");

        #endregion

        #region Constructeur

        public venteDeSmartphonesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Chargement du formulaire

        private void venteSmartphonesForm_Load(object sender, EventArgs e)
        {
            try
            {
                oVente = new Vente();

                vendeurVenteComboBox.Items.AddRange(oVente.GetVendeurs());
                modeleVenteComboBox.Items.AddRange(oVente.GetModeles());

                vendeurVenteComboBox.SelectedIndex = 0;
                modeleVenteComboBox.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du formulaire : " + ex.Message);
            }

        }

        #endregion

        #region Evénement validating pour la date de vente

        private void dateInformationClientMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            DateTime valideDateDateTime;
            if (DateTime.TryParse(dateInformationClientMaskedTextBox.Text, out valideDateDateTime))
                dateInformationClientMaskedTextBox.Text = valideDateDateTime.ToLongDateString();
            else
                dateInformationClientMaskedTextBox.Text = DateTime.Today.ToLongDateString();
        }

        #endregion

        #region Evénement SelectedIndexChanged du comboBox des modèles

        private void modeleVenteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (modeleVenteComboBox.SelectedIndex != -1)
                {
                    Decimal prixSmartphoneDecimal = oVente.GetPrix(modeleVenteComboBox.SelectedIndex);
                    oVente.PrixTotal = prixSmartphoneDecimal * TAXE_DECIMAL;
                    prixValeurVenteLabel.Text = prixSmartphoneDecimal.ToString("C2",enCaCultureInfo);
                    totalValeurVenteLabel.Text = (oVente.PrixTotal).ToString("C2", enCaCultureInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la selection du modèle : " + ex.Message);
            }
        }

        #endregion

        #region Enregistrer

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                oVente.Enregistrer(Decimal.Parse(totalValeurVenteLabel.Text.Trim(), System.Globalization.NumberStyles.Currency, enCaCultureInfo),
                    nomInformationClientMaskedTextBox.Text,vendeurVenteComboBox.SelectedItem.ToString(),
                    modeleVenteComboBox.SelectedItem.ToString(), 
                    DateTime.Parse(dateInformationClientMaskedTextBox.Text.Trim()));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la vente : " + ex.Message);
            }
        }

        #endregion

        #region Imprimer

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                oVente.ImprimerTransactions(this.CompanyName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la vente : " + ex.Message);
            }
        }

        #endregion
    }
}
