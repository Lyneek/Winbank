using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinBank66
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        bool Connecté = false;

        #region Méthodes évènementielles

        //Bouton de connection à la base de donnée
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (btnConnection.Text == "Se connecter")
            {
                cn = new MySqlConnection("SERVER=127.0.0.1; DATABASE=winbank;UID=root;PWD=;");
                try
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    btnConnection.Text = "Se deconnecter";
                    Connecté = true;
                    ClearFormClient();
                    ClearFormCompte();
                    listViewCompte.Items.Clear();
                    listViewClient.Items.Clear();
                    this.LoadComboBoxClient();
                    this.LoadListViewClient();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                cn.Close();
                btnConnection.Text = "Se connecter";
                Connecté = false;
                ClearFormClient();
                ClearFormCompte();
                listViewCompte.Items.Clear();
                listViewClient.Items.Clear();
            }
        }

        #region Formulaire fiche client

        //Bouton de validation du formulaire client et ajout de celui-ci dans la base de donnée
        private void btnClientOk_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (txtClientNom.Text == "")
                {
                    MessageBox.Show("Entrez un nom");
                }
                else if (txtClientPrenom.Text == "")
                {
                    MessageBox.Show("Entrez un prenom");
                }
                else if (txtClientAdrRue1.Text == "")
                {
                    MessageBox.Show("Entrez une adresse");
                }
                else if (txtClientAdrCP.Text == "")
                {
                    MessageBox.Show("Entrez un code postal");
                }
                else if (txtClientAdrVille.Text == "")
                {
                    MessageBox.Show("Entrez une ville");
                }
                else
                {

                    listViewClient.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO t_client(CLI_Nom, CLI_Prenom, CLI_Adresse, CLI_Cp, CLI_Ville) VALUES (@Nom, @Prenom, @Adresse, @CP, @Ville)", cn);
                    cmd.Parameters.AddWithValue("@Nom", txtClientNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", txtClientPrenom.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtClientAdrRue1.Text);
                    cmd.Parameters.AddWithValue("@CP", int.Parse(txtClientAdrCP.Text));
                    cmd.Parameters.AddWithValue("@Ville", txtClientAdrVille.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    this.ClearFormClient();
                    this.LoadListViewClient();
                    this.LoadComboBoxClient();
                    MessageBox.Show("Utilisateur ajouté");
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        //Bouton pour vider les informations du formulaire client
        private void btnClientAnnuler_Click(object sender, EventArgs e)
        {
            //Méthode vidant le formulaire client
            this.ClearFormClient();
        }

        #endregion

        #region Formulaire fiche compte

        //Remplit les informations du client selectionné et la liste de ses comptes dans la listview compte
        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Connecté)
            {
                listViewCompte.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client C join t_compte Co on C.CLI_Id=Co.CPT_IdClientCompte WHERE CLI_Id='" + comboBoxClient.Text + "'", cn);
                this.LoadInfoClient();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string Numero = dr["CPT_Numero"].ToString();
                        string Solde = dr["CPT_Solde"].ToString();
                        string Plafond = dr["CPT_MontantPlafond"].ToString();
                        string TauxAgios = dr["CPT_TauxAgios"].ToString();
                        string DecouvertMontant = dr["CPT_MontantDecouvert"].ToString();
                        string TauxInteret = dr["CPT_TauxInterets"].ToString();
                        listViewCompte.Items.Add(new ListViewItem(new[] { Numero, Solde, TauxAgios, DecouvertMontant, TauxInteret, Plafond }));
                    }
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        //Bouton d'ajout d'un nouveau compte lié au client selectionné
        private void btnFormCompteOk_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                //Différents messages d'erreur si des champs ne sont pas remplis
                if (textBoxNumeroCompte.Text == "")
                {
                    MessageBox.Show("Entrez un numéro");
                }
                else if (textBoxSoldeCompte.Text == "")
                {
                    MessageBox.Show("Entrez un solde");
                }
                else if (textBoxMontantDecouvertCompte.Text == "")
                {
                    MessageBox.Show("Entrez un montant de découvert");
                }
                else if (textBoxTauxAgiosCompte.Text == "")
                {
                    MessageBox.Show("Entrez un taux d'agios");
                }
                else if (textBoxPlafondCompte.Text == "")
                {
                    MessageBox.Show("Entrez un plafond pour votre compte");
                }
                else if (textBoxTauxInteretCompte.Text == "")
                {
                    MessageBox.Show("Entrez le taux d'intérêt de votre compte");
                }
                else
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO t_compte(CPT_IdClientCompte, CPT_Numero, CPT_Solde, CPT_TauxAgios, CPT_MontantDecouvert, CPT_TauxInterets, CPT_MontantPlafond) VALUES (@IdClientCompte, @Numero, @Solde, @Agios, @MDecouvert, @Interets, @Plafond)", cn);
                    cmd.Parameters.AddWithValue("@IdClientCompte", int.Parse(comboBoxClient.Text));
                    cmd.Parameters.AddWithValue("@Numero", int.Parse(textBoxNumeroCompte.Text));
                    cmd.Parameters.AddWithValue("@Solde", float.Parse(textBoxSoldeCompte.Text));
                    cmd.Parameters.AddWithValue("@Agios", float.Parse(textBoxTauxAgiosCompte.Text));
                    cmd.Parameters.AddWithValue("@MDecouvert", textBoxMontantDecouvertCompte.Text);
                    cmd.Parameters.AddWithValue("@Interets", float.Parse(textBoxTauxInteretCompte.Text));
                    cmd.Parameters.AddWithValue("@Plafond", int.Parse(textBoxPlafondCompte.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    this.ClearFormCompte();
                    this.LoadListviewCompteClientSelect();
                    MessageBox.Show("Compte ajouté");
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }

        }

        //Bouton annuler du formulaire compte qui le remet à zéro
        private void btnFormCompteAnnuler_Click(object sender, EventArgs e)
        {
            this.ClearFormCompte();
        }

        #endregion

        #region Actions sur les clients

        //Bouton d'actualisation listview client
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                listViewClient.Items.Clear();
                this.LoadListViewClient();
            }
            else 
            { 
                MessageBox.Show("Vous n'êtes pas connecté"); 
            }
        }

        //Bouton pour supprimer un client de la liste dans la base de donnée
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listViewClient.SelectedItems.Count > 0)
                {
                    ListViewItem element = listViewClient.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM t_client WHERE CLI_Id=@id", cn);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    element.Remove();
                    MessageBox.Show("Utilisateur supprimé");
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        //Bouton pour modifier les informations client dans la liste et la base de donnée
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listViewClient.SelectedItems.Count > 0)
                {
                    ListViewItem element = listViewClient.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    string Nom = element.SubItems[1].Text;
                    string Prenom = element.SubItems[2].Text;
                    string Adresse = element.SubItems[3].Text;
                    string Cp = element.SubItems[4].Text;
                    string Ville = element.SubItems[5].Text;

                    using (ModifierClient m = new ModifierClient())
                    {
                        m.ID = Id;
                        m.NOM = Nom;
                        m.PRENOM = Prenom;
                        m.ADR = Adresse;
                        m.CP = Cp;
                        m.VILLE = Ville;

                        if (m.ShowDialog() == DialogResult.Yes)
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE t_client SET CLI_Nom=@Nom, CLI_Prenom=@Prenom, CLI_Adresse=@Adresse, CLI_Cp=@Cp, CLI_Ville=@Ville WHERE CLI_Id=@id", cn);
                            cmd.Parameters.AddWithValue("@Nom", m.NOM);
                            cmd.Parameters.AddWithValue("@Prenom", m.PRENOM);
                            cmd.Parameters.AddWithValue("@Adresse", m.ADR);
                            cmd.Parameters.AddWithValue("@Cp", m.CP);
                            cmd.Parameters.AddWithValue("@Ville", m.VILLE);
                            cmd.Parameters.AddWithValue("@id", Id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            element.SubItems[1].Text = m.NOM;
                            element.SubItems[2].Text = m.PRENOM;
                            element.SubItems[3].Text = m.ADR;
                            element.SubItems[4].Text = m.CP;
                            element.SubItems[5].Text = m.VILLE;
                            MessageBox.Show("Informations utilisateur modifiées");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Voous n'êtes pas connecté");
            }
        }

        //Recherche des clients par l'id
        private void btnClientChercherNom_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                listViewClient.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client WHERE CLI_Nom=@Nom", cn);
                cmd.Parameters.AddWithValue("@Nom", txtClientChercherNom.Text);
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["CLI_Id"].ToString();
                        string Nom = Lire["CLI_Nom"].ToString();
                        string Prenom = Lire["CLI_Prenom"].ToString();
                        string Adresse = Lire["CLI_Adresse"].ToString();
                        string CP = Lire["CLI_Cp"].ToString();
                        string Ville = Lire["CLI_Ville"].ToString();
                        listViewClient.Items.Add(new ListViewItem(new[] { ID, Nom, Prenom, Adresse, CP, Ville }));
                    }
                    Lire.Close();
                }
                txtClientChercherNom.Clear();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        //Recherche des clients par Nom
        private void btnClientChercherId_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                listViewClient.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client WHERE CLI_Id=@Id", cn);
                cmd.Parameters.AddWithValue("@Id", txtClientChercherId.Text);
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["CLI_Id"].ToString();
                        string Nom = Lire["CLI_Nom"].ToString();
                        string Prenom = Lire["CLI_Prenom"].ToString();
                        string Adresse = Lire["CLI_Adresse"].ToString();
                        string CP = Lire["CLI_Cp"].ToString();
                        string Ville = Lire["CLI_Ville"].ToString();
                        listViewClient.Items.Add(new ListViewItem(new[] { ID, Nom, Prenom, Adresse, CP, Ville }));
                    }
                    Lire.Close();
                }
                txtClientChercherId.Clear();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        //Recherche des clients par Ville
        private void btnClientChercherVille_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                listViewClient.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client WHERE CLI_Ville=@Ville", cn);
                cmd.Parameters.AddWithValue("@Ville", txtClientChercherVille.Text);
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["CLI_Id"].ToString();
                        string Nom = Lire["CLI_Nom"].ToString();
                        string Prenom = Lire["CLI_Prenom"].ToString();
                        string Adresse = Lire["CLI_Adresse"].ToString();
                        string CP = Lire["CLI_Cp"].ToString();
                        string Ville = Lire["CLI_Ville"].ToString();
                        listViewClient.Items.Add(new ListViewItem(new[] { ID, Nom, Prenom, Adresse, CP, Ville }));
                    }
                    Lire.Close();
                }
                txtClientChercherVille.Clear();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté");
            }
        }

        #endregion

        #region Actions sur les comptes

        //Bouton d'actualisation de la listview des comptes
        private void btnActualiserCompte_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                comboBoxClient.Items.Clear();
                this.LoadComboBoxClient();
                this.LoadListviewCompteClientSelect();
            }
            else 
            { 
                MessageBox.Show("Vous n'êtes pas connecté"); 
            }
        }

        //Bouton pour supprimer un compte de la liste dans la base de donnée
        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listViewCompte.SelectedItems.Count > 0)
                {
                    ListViewItem element = listViewCompte.SelectedItems[0];
                    string Num = element.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM t_compte WHERE CPT_Numero=@Num", cn);
                    cmd.Parameters.AddWithValue("@Num", Num);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    element.Remove();
                    MessageBox.Show("Compte supprimé");
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté"); 
            }
        }

        //Bouton pour modifier les informations compte dans la liste et la base de donnée
        private void modifierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listViewCompte.SelectedItems.Count > 0)
                {
                    ListViewItem element = listViewCompte.SelectedItems[0];
                    string Num = element.SubItems[0].Text;
                    string Solde = element.SubItems[1].Text;
                    string Agios = element.SubItems[2].Text;
                    string MDecouvert = element.SubItems[3].Text;
                    string Interets = element.SubItems[4].Text;
                    string Plafond = element.SubItems[5].Text;

                    using (ModifierCompte m = new ModifierCompte())
                    {
                        m.Num = Num;
                        m.Solde = Solde;
                        m.Agios = Agios;
                        m.MDecouvert = MDecouvert;
                        m.Interets = Interets;
                        m.Plafond = Plafond;

                        if (m.ShowDialog() == DialogResult.Yes)
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE t_compte SET CPT_Solde=@Solde, CPT_TauxAgios=@Agios, CPT_MontantDecouvert=@MDecouvert, CPT_TauxInterets=@Interets, CPT_MontantPlafond=@Plafond WHERE CPT_Numero=@Num", cn);
                            cmd.Parameters.AddWithValue("@Solde", float.Parse(m.Solde));
                            cmd.Parameters.AddWithValue("@Agios", float.Parse(m.Agios));
                            cmd.Parameters.AddWithValue("@MDecouvert", m.MDecouvert);
                            cmd.Parameters.AddWithValue("@Interets", float.Parse(m.Interets));
                            cmd.Parameters.AddWithValue("@Plafond", m.Plafond);
                            cmd.Parameters.AddWithValue("@Num", Num);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            element.SubItems[1].Text = m.Solde;
                            element.SubItems[2].Text = m.Agios;
                            element.SubItems[3].Text = m.MDecouvert;
                            element.SubItems[4].Text = m.Interets;
                            element.SubItems[5].Text = m.Plafond;
                            MessageBox.Show("Informations compte modifiées");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté"); 
            }
        }

        #endregion

        #region Fenêtre principale

        //Fermeture de l'application
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

        #region Méthodes

        #region Méthodes du formulaire client

        //Méthode pour vider les champs du formulaire client
        private void ClearFormClient()
        {
            txtClientNom.Clear();
            txtClientPrenom.Clear();
            txtClientAdrRue1.Clear();
            txtClientAdrCP.Clear();
            txtClientAdrVille.Clear();
        }

        #endregion

        #region Méthodes du formulaire compte

        //Méthode qui vide le formulaire compte
        private void ClearFormCompte()
        {
            textBoxNumeroCompte.Clear();
            textBoxSoldeCompte.Clear();
            textBoxMontantDecouvertCompte.Clear();
            textBoxTauxAgiosCompte.Clear();
            textBoxPlafondCompte.Clear();
            textBoxTauxInteretCompte.Clear();
        }

        #endregion

        #region Méthodes d'initialisation

        //Méthode qui charge les clients de la base de donnée dans la comboBox du formulaire compte
        private void LoadComboBoxClient()
        {
            comboBoxClient.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT CLI_Id FROM t_client", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxClient.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        //Méthode qui charge la liste des clients de la base de donnée dans la listview client
        private void LoadListViewClient()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client", cn);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string ID = Lire["CLI_Id"].ToString();
                    string Nom = Lire["CLI_Nom"].ToString();
                    string Prenom = Lire["CLI_Prenom"].ToString();
                    string Adresse = Lire["CLI_Adresse"].ToString();
                    string CP = Lire["CLI_Cp"].ToString();
                    string Ville = Lire["CLI_Ville"].ToString();
                    listViewClient.Items.Add(new ListViewItem(new[] { ID, Nom, Prenom, Adresse, CP, Ville }));
                }
                Lire.Close();
            }
        }

        //Méthode qui charge la liste des comptes d'un client de la base de donnée dans la listview compte
        private void LoadListviewCompteClientSelect()
        {
            listViewCompte.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_compte WHERE CPT_IdClientCompte='" + comboBoxClient.Text + "'", cn);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    string Numero = dr["CPT_Numero"].ToString();
                    string Solde = dr["CPT_Solde"].ToString();
                    string Plafond = dr["CPT_MontantPlafond"].ToString();
                    string TauxAgios = dr["CPT_TauxAgios"].ToString();
                    string DecouvertMontant = dr["CPT_MontantDecouvert"].ToString();
                    string TauxInteret = dr["CPT_TauxInterets"].ToString();
                    listViewCompte.Items.Add(new ListViewItem(new[] { Numero, Solde, TauxAgios, DecouvertMontant, TauxInteret, Plafond }));
                }
                dr.Close();
            }
      
        }

        //Méthode qui charge les informations dans le formulaire compte du client selectionné dans la comboBox
        private void LoadInfoClient()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_client WHERE CLI_Id='" + comboBoxClient.Text + "'", cn);
            MySqlDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                textBoxNomCompteClient.Text = dr2["CLI_Nom"].ToString();
                textBoxPrenomCompteClient.Text = dr2["CLI_Prenom"].ToString();
                textBoxAdresseCompteClient.Text = dr2["CLI_Adresse"].ToString();
                textBoxCPCompteClient.Text = dr2["CLI_Cp"].ToString();
                textBoxVilleCompteClient.Text = dr2["CLI_Ville"].ToString();
            }
            dr2.Close();
        }

        #endregion

        #endregion
    }
}