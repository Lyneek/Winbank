namespace WinBank66
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.grpRechercherClient = new System.Windows.Forms.GroupBox();
            this.btnClientChercherVille = new System.Windows.Forms.Button();
            this.btnClientChercherNom = new System.Windows.Forms.Button();
            this.txtClientChercherVille = new System.Windows.Forms.TextBox();
            this.txtClientChercherNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientChercherId = new System.Windows.Forms.Button();
            this.txtClientChercherId = new System.Windows.Forms.TextBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFormClientAnnuler = new System.Windows.Forms.Button();
            this.btnFormClientOk = new System.Windows.Forms.Button();
            this.lblClientAdrVille = new System.Windows.Forms.Label();
            this.lblClientAdrCP = new System.Windows.Forms.Label();
            this.lblClientAdresse = new System.Windows.Forms.Label();
            this.lblClientPrenom = new System.Windows.Forms.Label();
            this.lblClientNom = new System.Windows.Forms.Label();
            this.txtClientAdrVille = new System.Windows.Forms.TextBox();
            this.txtClientAdrCP = new System.Windows.Forms.TextBox();
            this.txtClientAdrRue1 = new System.Windows.Forms.TextBox();
            this.txtClientPrenom = new System.Windows.Forms.TextBox();
            this.txtClientNom = new System.Windows.Forms.TextBox();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageComptes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTauxInteretCompte = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActualiserCompte = new System.Windows.Forms.Button();
            this.textBoxPlafondCompte = new System.Windows.Forms.TextBox();
            this.btnFormCompteAnnuler = new System.Windows.Forms.Button();
            this.btnFormCompteOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoldeCompte = new System.Windows.Forms.TextBox();
            this.textBoxTauxAgiosCompte = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCompte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMontantDecouvertCompte = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxVilleCompteClient = new System.Windows.Forms.TextBox();
            this.textBoxCPCompteClient = new System.Windows.Forms.TextBox();
            this.textBoxAdresseCompteClient = new System.Windows.Forms.TextBox();
            this.textBoxPrenomCompteClient = new System.Windows.Forms.TextBox();
            this.textBoxNomCompteClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewCompte = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripCompte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnection = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.grpRechercherClient.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.contextMenuStripClient.SuspendLayout();
            this.tabPageComptes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStripCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(784, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPageClients);
            this.tabMain.Controls.Add(this.tabPageComptes);
            this.tabMain.Location = new System.Drawing.Point(13, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(759, 485);
            this.tabMain.TabIndex = 2;
            // 
            // tabPageClients
            // 
            this.tabPageClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageClients.Controls.Add(this.grpRechercherClient);
            this.tabPageClients.Controls.Add(this.grpClient);
            this.tabPageClients.Controls.Add(this.listViewClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageClients.Size = new System.Drawing.Size(751, 459);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // grpRechercherClient
            // 
            this.grpRechercherClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRechercherClient.Controls.Add(this.btnClientChercherVille);
            this.grpRechercherClient.Controls.Add(this.btnClientChercherNom);
            this.grpRechercherClient.Controls.Add(this.txtClientChercherVille);
            this.grpRechercherClient.Controls.Add(this.txtClientChercherNom);
            this.grpRechercherClient.Controls.Add(this.label15);
            this.grpRechercherClient.Controls.Add(this.label14);
            this.grpRechercherClient.Controls.Add(this.label1);
            this.grpRechercherClient.Controls.Add(this.btnClientChercherId);
            this.grpRechercherClient.Controls.Add(this.txtClientChercherId);
            this.grpRechercherClient.Location = new System.Drawing.Point(5, 247);
            this.grpRechercherClient.Margin = new System.Windows.Forms.Padding(2);
            this.grpRechercherClient.Name = "grpRechercherClient";
            this.grpRechercherClient.Padding = new System.Windows.Forms.Padding(2);
            this.grpRechercherClient.Size = new System.Drawing.Size(217, 206);
            this.grpRechercherClient.TabIndex = 5;
            this.grpRechercherClient.TabStop = false;
            this.grpRechercherClient.Text = "Rechercher Client";
            // 
            // btnClientChercherVille
            // 
            this.btnClientChercherVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientChercherVille.Location = new System.Drawing.Point(4, 156);
            this.btnClientChercherVille.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientChercherVille.Name = "btnClientChercherVille";
            this.btnClientChercherVille.Size = new System.Drawing.Size(209, 26);
            this.btnClientChercherVille.TabIndex = 10;
            this.btnClientChercherVille.Text = "Chercher";
            this.btnClientChercherVille.UseVisualStyleBackColor = true;
            this.btnClientChercherVille.Click += new System.EventHandler(this.btnClientChercherVille_Click);
            // 
            // btnClientChercherNom
            // 
            this.btnClientChercherNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientChercherNom.Location = new System.Drawing.Point(4, 102);
            this.btnClientChercherNom.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientChercherNom.Name = "btnClientChercherNom";
            this.btnClientChercherNom.Size = new System.Drawing.Size(209, 26);
            this.btnClientChercherNom.TabIndex = 9;
            this.btnClientChercherNom.Text = "Chercher";
            this.btnClientChercherNom.UseVisualStyleBackColor = true;
            this.btnClientChercherNom.Click += new System.EventHandler(this.btnClientChercherNom_Click);
            // 
            // txtClientChercherVille
            // 
            this.txtClientChercherVille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientChercherVille.Location = new System.Drawing.Point(54, 132);
            this.txtClientChercherVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientChercherVille.Name = "txtClientChercherVille";
            this.txtClientChercherVille.Size = new System.Drawing.Size(158, 20);
            this.txtClientChercherVille.TabIndex = 8;
            // 
            // txtClientChercherNom
            // 
            this.txtClientChercherNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientChercherNom.Location = new System.Drawing.Point(55, 78);
            this.txtClientChercherNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientChercherNom.Name = "txtClientChercherNom";
            this.txtClientChercherNom.Size = new System.Drawing.Size(158, 20);
            this.txtClientChercherNom.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Par ville";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Par nom ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Par id ";
            // 
            // btnClientChercherId
            // 
            this.btnClientChercherId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientChercherId.Location = new System.Drawing.Point(4, 47);
            this.btnClientChercherId.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientChercherId.Name = "btnClientChercherId";
            this.btnClientChercherId.Size = new System.Drawing.Size(209, 27);
            this.btnClientChercherId.TabIndex = 1;
            this.btnClientChercherId.Text = "Chercher";
            this.btnClientChercherId.UseVisualStyleBackColor = true;
            this.btnClientChercherId.Click += new System.EventHandler(this.btnClientChercherId_Click);
            // 
            // txtClientChercherId
            // 
            this.txtClientChercherId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientChercherId.Location = new System.Drawing.Point(54, 23);
            this.txtClientChercherId.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientChercherId.Name = "txtClientChercherId";
            this.txtClientChercherId.Size = new System.Drawing.Size(158, 20);
            this.txtClientChercherId.TabIndex = 0;
            // 
            // grpClient
            // 
            this.grpClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpClient.Controls.Add(this.btnActualiser);
            this.grpClient.Controls.Add(this.btnFormClientAnnuler);
            this.grpClient.Controls.Add(this.btnFormClientOk);
            this.grpClient.Controls.Add(this.lblClientAdrVille);
            this.grpClient.Controls.Add(this.lblClientAdrCP);
            this.grpClient.Controls.Add(this.lblClientAdresse);
            this.grpClient.Controls.Add(this.lblClientPrenom);
            this.grpClient.Controls.Add(this.lblClientNom);
            this.grpClient.Controls.Add(this.txtClientAdrVille);
            this.grpClient.Controls.Add(this.txtClientAdrCP);
            this.grpClient.Controls.Add(this.txtClientAdrRue1);
            this.grpClient.Controls.Add(this.txtClientPrenom);
            this.grpClient.Controls.Add(this.txtClientNom);
            this.grpClient.Location = new System.Drawing.Point(5, 11);
            this.grpClient.Margin = new System.Windows.Forms.Padding(2);
            this.grpClient.Name = "grpClient";
            this.grpClient.Padding = new System.Windows.Forms.Padding(2);
            this.grpClient.Size = new System.Drawing.Size(217, 235);
            this.grpClient.TabIndex = 2;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(4, 201);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(209, 24);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFormClientAnnuler
            // 
            this.btnFormClientAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormClientAnnuler.Location = new System.Drawing.Point(134, 155);
            this.btnFormClientAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClientAnnuler.Name = "btnFormClientAnnuler";
            this.btnFormClientAnnuler.Size = new System.Drawing.Size(78, 28);
            this.btnFormClientAnnuler.TabIndex = 12;
            this.btnFormClientAnnuler.Text = "Annuler";
            this.btnFormClientAnnuler.UseVisualStyleBackColor = true;
            this.btnFormClientAnnuler.Click += new System.EventHandler(this.btnClientAnnuler_Click);
            // 
            // btnFormClientOk
            // 
            this.btnFormClientOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormClientOk.Location = new System.Drawing.Point(45, 155);
            this.btnFormClientOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClientOk.Name = "btnFormClientOk";
            this.btnFormClientOk.Size = new System.Drawing.Size(76, 28);
            this.btnFormClientOk.TabIndex = 11;
            this.btnFormClientOk.Text = "OK";
            this.btnFormClientOk.UseVisualStyleBackColor = true;
            this.btnFormClientOk.Click += new System.EventHandler(this.btnClientOk_Click);
            // 
            // lblClientAdrVille
            // 
            this.lblClientAdrVille.AutoSize = true;
            this.lblClientAdrVille.Location = new System.Drawing.Point(4, 114);
            this.lblClientAdrVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAdrVille.Name = "lblClientAdrVille";
            this.lblClientAdrVille.Size = new System.Drawing.Size(26, 13);
            this.lblClientAdrVille.TabIndex = 10;
            this.lblClientAdrVille.Text = "Ville";
            // 
            // lblClientAdrCP
            // 
            this.lblClientAdrCP.AutoSize = true;
            this.lblClientAdrCP.Location = new System.Drawing.Point(4, 90);
            this.lblClientAdrCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAdrCP.Name = "lblClientAdrCP";
            this.lblClientAdrCP.Size = new System.Drawing.Size(21, 13);
            this.lblClientAdrCP.TabIndex = 9;
            this.lblClientAdrCP.Text = "CP";
            // 
            // lblClientAdresse
            // 
            this.lblClientAdresse.AutoSize = true;
            this.lblClientAdresse.Location = new System.Drawing.Point(4, 65);
            this.lblClientAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAdresse.Name = "lblClientAdresse";
            this.lblClientAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblClientAdresse.TabIndex = 8;
            this.lblClientAdresse.Text = "Adresse";
            // 
            // lblClientPrenom
            // 
            this.lblClientPrenom.AutoSize = true;
            this.lblClientPrenom.Location = new System.Drawing.Point(4, 42);
            this.lblClientPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPrenom.Name = "lblClientPrenom";
            this.lblClientPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblClientPrenom.TabIndex = 7;
            this.lblClientPrenom.Text = "Prénom";
            // 
            // lblClientNom
            // 
            this.lblClientNom.AutoSize = true;
            this.lblClientNom.Location = new System.Drawing.Point(4, 20);
            this.lblClientNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientNom.Name = "lblClientNom";
            this.lblClientNom.Size = new System.Drawing.Size(29, 13);
            this.lblClientNom.TabIndex = 6;
            this.lblClientNom.Text = "Nom";
            // 
            // txtClientAdrVille
            // 
            this.txtClientAdrVille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientAdrVille.Location = new System.Drawing.Point(54, 111);
            this.txtClientAdrVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientAdrVille.Name = "txtClientAdrVille";
            this.txtClientAdrVille.Size = new System.Drawing.Size(114, 20);
            this.txtClientAdrVille.TabIndex = 5;
            // 
            // txtClientAdrCP
            // 
            this.txtClientAdrCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientAdrCP.Location = new System.Drawing.Point(54, 87);
            this.txtClientAdrCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientAdrCP.Name = "txtClientAdrCP";
            this.txtClientAdrCP.Size = new System.Drawing.Size(76, 20);
            this.txtClientAdrCP.TabIndex = 4;
            // 
            // txtClientAdrRue1
            // 
            this.txtClientAdrRue1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientAdrRue1.Location = new System.Drawing.Point(54, 63);
            this.txtClientAdrRue1.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientAdrRue1.Name = "txtClientAdrRue1";
            this.txtClientAdrRue1.Size = new System.Drawing.Size(159, 20);
            this.txtClientAdrRue1.TabIndex = 2;
            // 
            // txtClientPrenom
            // 
            this.txtClientPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientPrenom.Location = new System.Drawing.Point(54, 40);
            this.txtClientPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientPrenom.Name = "txtClientPrenom";
            this.txtClientPrenom.Size = new System.Drawing.Size(114, 20);
            this.txtClientPrenom.TabIndex = 1;
            // 
            // txtClientNom
            // 
            this.txtClientNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientNom.Location = new System.Drawing.Point(54, 17);
            this.txtClientNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientNom.Name = "txtClientNom";
            this.txtClientNom.Size = new System.Drawing.Size(114, 20);
            this.txtClientNom.TabIndex = 0;
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewClient.ContextMenuStrip = this.contextMenuStripClient;
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.Location = new System.Drawing.Point(235, 6);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(510, 447);
            this.listViewClient.TabIndex = 7;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresse";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CP";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ville";
            this.columnHeader6.Width = 95;
            // 
            // contextMenuStripClient
            // 
            this.contextMenuStripClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.contextMenuStripClient.Name = "contextMenuStrip1";
            this.contextMenuStripClient.Size = new System.Drawing.Size(130, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // tabPageComptes
            // 
            this.tabPageComptes.Controls.Add(this.groupBox1);
            this.tabPageComptes.Controls.Add(this.listViewCompte);
            this.tabPageComptes.Location = new System.Drawing.Point(4, 22);
            this.tabPageComptes.Name = "tabPageComptes";
            this.tabPageComptes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComptes.Size = new System.Drawing.Size(751, 459);
            this.tabPageComptes.TabIndex = 1;
            this.tabPageComptes.Text = "Comptes";
            this.tabPageComptes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTauxInteretCompte);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnActualiserCompte);
            this.groupBox1.Controls.Add(this.textBoxPlafondCompte);
            this.groupBox1.Controls.Add(this.btnFormCompteAnnuler);
            this.groupBox1.Controls.Add(this.btnFormCompteOk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSoldeCompte);
            this.groupBox1.Controls.Add(this.textBoxTauxAgiosCompte);
            this.groupBox1.Controls.Add(this.textBoxNumeroCompte);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMontantDecouvertCompte);
            this.groupBox1.Controls.Add(this.comboBoxClient);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compte";
            // 
            // textBoxTauxInteretCompte
            // 
            this.textBoxTauxInteretCompte.Location = new System.Drawing.Point(90, 318);
            this.textBoxTauxInteretCompte.Name = "textBoxTauxInteretCompte";
            this.textBoxTauxInteretCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxInteretCompte.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Taux Agios (%)";
            // 
            // btnActualiserCompte
            // 
            this.btnActualiserCompte.Location = new System.Drawing.Point(6, 418);
            this.btnActualiserCompte.Name = "btnActualiserCompte";
            this.btnActualiserCompte.Size = new System.Drawing.Size(184, 23);
            this.btnActualiserCompte.TabIndex = 2;
            this.btnActualiserCompte.Text = "Actualiser";
            this.btnActualiserCompte.UseVisualStyleBackColor = true;
            this.btnActualiserCompte.Click += new System.EventHandler(this.btnActualiserCompte_Click);
            // 
            // textBoxPlafondCompte
            // 
            this.textBoxPlafondCompte.Location = new System.Drawing.Point(90, 352);
            this.textBoxPlafondCompte.Name = "textBoxPlafondCompte";
            this.textBoxPlafondCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlafondCompte.TabIndex = 19;
            // 
            // btnFormCompteAnnuler
            // 
            this.btnFormCompteAnnuler.Location = new System.Drawing.Point(115, 389);
            this.btnFormCompteAnnuler.Name = "btnFormCompteAnnuler";
            this.btnFormCompteAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnFormCompteAnnuler.TabIndex = 5;
            this.btnFormCompteAnnuler.Text = "Annuler";
            this.btnFormCompteAnnuler.UseVisualStyleBackColor = true;
            this.btnFormCompteAnnuler.Click += new System.EventHandler(this.btnFormCompteAnnuler_Click);
            // 
            // btnFormCompteOk
            // 
            this.btnFormCompteOk.Location = new System.Drawing.Point(34, 389);
            this.btnFormCompteOk.Name = "btnFormCompteOk";
            this.btnFormCompteOk.Size = new System.Drawing.Size(75, 23);
            this.btnFormCompteOk.TabIndex = 4;
            this.btnFormCompteOk.Text = "OK";
            this.btnFormCompteOk.UseVisualStyleBackColor = true;
            this.btnFormCompteOk.Click += new System.EventHandler(this.btnFormCompteOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solde";
            // 
            // textBoxSoldeCompte
            // 
            this.textBoxSoldeCompte.Location = new System.Drawing.Point(90, 211);
            this.textBoxSoldeCompte.Name = "textBoxSoldeCompte";
            this.textBoxSoldeCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoldeCompte.TabIndex = 9;
            // 
            // textBoxTauxAgiosCompte
            // 
            this.textBoxTauxAgiosCompte.Location = new System.Drawing.Point(90, 242);
            this.textBoxTauxAgiosCompte.Name = "textBoxTauxAgiosCompte";
            this.textBoxTauxAgiosCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxAgiosCompte.TabIndex = 18;
            // 
            // textBoxNumeroCompte
            // 
            this.textBoxNumeroCompte.Location = new System.Drawing.Point(90, 182);
            this.textBoxNumeroCompte.Name = "textBoxNumeroCompte";
            this.textBoxNumeroCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroCompte.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Taux intérêt (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Plafond";
            // 
            // textBoxMontantDecouvertCompte
            // 
            this.textBoxMontantDecouvertCompte.Location = new System.Drawing.Point(106, 282);
            this.textBoxMontantDecouvertCompte.Name = "textBoxMontantDecouvertCompte";
            this.textBoxMontantDecouvertCompte.Size = new System.Drawing.Size(84, 20);
            this.textBoxMontantDecouvertCompte.TabIndex = 17;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(88, 19);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(100, 21);
            this.comboBoxClient.TabIndex = 10;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Découvert autorisé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Le n° titulaire";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxVilleCompteClient);
            this.groupBox3.Controls.Add(this.textBoxCPCompteClient);
            this.groupBox3.Controls.Add(this.textBoxAdresseCompteClient);
            this.groupBox3.Controls.Add(this.textBoxPrenomCompteClient);
            this.groupBox3.Controls.Add(this.textBoxNomCompteClient);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            // 
            // textBoxVilleCompteClient
            // 
            this.textBoxVilleCompteClient.Location = new System.Drawing.Point(60, 104);
            this.textBoxVilleCompteClient.Name = "textBoxVilleCompteClient";
            this.textBoxVilleCompteClient.ReadOnly = true;
            this.textBoxVilleCompteClient.Size = new System.Drawing.Size(122, 20);
            this.textBoxVilleCompteClient.TabIndex = 16;
            // 
            // textBoxCPCompteClient
            // 
            this.textBoxCPCompteClient.Location = new System.Drawing.Point(82, 82);
            this.textBoxCPCompteClient.Name = "textBoxCPCompteClient";
            this.textBoxCPCompteClient.ReadOnly = true;
            this.textBoxCPCompteClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPCompteClient.TabIndex = 15;
            // 
            // textBoxAdresseCompteClient
            // 
            this.textBoxAdresseCompteClient.Location = new System.Drawing.Point(60, 60);
            this.textBoxAdresseCompteClient.Name = "textBoxAdresseCompteClient";
            this.textBoxAdresseCompteClient.ReadOnly = true;
            this.textBoxAdresseCompteClient.Size = new System.Drawing.Size(122, 20);
            this.textBoxAdresseCompteClient.TabIndex = 14;
            // 
            // textBoxPrenomCompteClient
            // 
            this.textBoxPrenomCompteClient.Location = new System.Drawing.Point(60, 37);
            this.textBoxPrenomCompteClient.Name = "textBoxPrenomCompteClient";
            this.textBoxPrenomCompteClient.ReadOnly = true;
            this.textBoxPrenomCompteClient.Size = new System.Drawing.Size(122, 20);
            this.textBoxPrenomCompteClient.TabIndex = 13;
            // 
            // textBoxNomCompteClient
            // 
            this.textBoxNomCompteClient.Location = new System.Drawing.Point(60, 13);
            this.textBoxNomCompteClient.Name = "textBoxNomCompteClient";
            this.textBoxNomCompteClient.ReadOnly = true;
            this.textBoxNomCompteClient.Size = new System.Drawing.Size(122, 20);
            this.textBoxNomCompteClient.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Code Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom";
            // 
            // listViewCompte
            // 
            this.listViewCompte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader21,
            this.columnHeader15,
            this.columnHeader17,
            this.columnHeader18});
            this.listViewCompte.ContextMenuStrip = this.contextMenuStripCompte;
            this.listViewCompte.FullRowSelect = true;
            this.listViewCompte.Location = new System.Drawing.Point(215, 6);
            this.listViewCompte.Name = "listViewCompte";
            this.listViewCompte.Size = new System.Drawing.Size(531, 447);
            this.listViewCompte.TabIndex = 3;
            this.listViewCompte.UseCompatibleStateImageBehavior = false;
            this.listViewCompte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Numero";
            this.columnHeader13.Width = 64;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Solde";
            this.columnHeader14.Width = 85;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Agios";
            this.columnHeader21.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Découvert Autorisé";
            this.columnHeader15.Width = 115;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Intérêts";
            this.columnHeader17.Width = 87;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Plafond";
            this.columnHeader18.Width = 97;
            // 
            // contextMenuStripCompte
            // 
            this.contextMenuStripCompte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem1,
            this.modifierToolStripMenuItem2});
            this.contextMenuStripCompte.Name = "contextMenuStripCompte";
            this.contextMenuStripCompte.Size = new System.Drawing.Size(130, 48);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            this.modifierToolStripMenuItem2.Click += new System.EventHandler(this.modifierToolStripMenuItem2_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(656, 1);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(107, 23);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinBank66";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.grpRechercherClient.ResumeLayout(false);
            this.grpRechercherClient.PerformLayout();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.contextMenuStripClient.ResumeLayout(false);
            this.tabPageComptes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStripCompte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Button btnFormClientAnnuler;
        private System.Windows.Forms.Button btnFormClientOk;
        private System.Windows.Forms.Label lblClientAdrVille;
        private System.Windows.Forms.Label lblClientAdrCP;
        private System.Windows.Forms.Label lblClientAdresse;
        private System.Windows.Forms.Label lblClientPrenom;
        private System.Windows.Forms.Label lblClientNom;
        private System.Windows.Forms.TextBox txtClientAdrVille;
        private System.Windows.Forms.TextBox txtClientAdrCP;
        private System.Windows.Forms.TextBox txtClientAdrRue1;
        private System.Windows.Forms.TextBox txtClientPrenom;
        private System.Windows.Forms.TextBox txtClientNom;
        private System.Windows.Forms.TabPage tabPageComptes;
        private System.Windows.Forms.GroupBox grpRechercherClient;
        private System.Windows.Forms.Button btnClientChercherId;
        private System.Windows.Forms.TextBox txtClientChercherId;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFormCompteAnnuler;
        private System.Windows.Forms.Button btnFormCompteOk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoldeCompte;
        private System.Windows.Forms.TextBox textBoxNumeroCompte;
        private System.Windows.Forms.TextBox textBoxTauxInteretCompte;
        private System.Windows.Forms.TextBox textBoxPlafondCompte;
        private System.Windows.Forms.TextBox textBoxTauxAgiosCompte;
        private System.Windows.Forms.TextBox textBoxMontantDecouvertCompte;
        private System.Windows.Forms.TextBox textBoxVilleCompteClient;
        private System.Windows.Forms.TextBox textBoxCPCompteClient;
        private System.Windows.Forms.TextBox textBoxAdresseCompteClient;
        private System.Windows.Forms.TextBox textBoxPrenomCompteClient;
        private System.Windows.Forms.TextBox textBoxNomCompteClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button btnActualiserCompte;
        private System.Windows.Forms.ListView listViewCompte;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button btnClientChercherVille;
        private System.Windows.Forms.Button btnClientChercherNom;
        private System.Windows.Forms.TextBox txtClientChercherVille;
        private System.Windows.Forms.TextBox txtClientChercherNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCompte;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
    }
}

