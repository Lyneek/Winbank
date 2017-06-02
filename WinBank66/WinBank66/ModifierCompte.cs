using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBank66
{
    public partial class ModifierCompte : Form
    {

        public string Num { set { textBoxNumCompteModif.Text = value; } }
        public string Solde { get { return textBoxSoldeCompteModif.Text; } set { textBoxSoldeCompteModif.Text = value; } }
        public string MDecouvert { get { return textBoxMDecouvertCompteModif.Text; } set { textBoxMDecouvertCompteModif.Text = value; } }
        public string Agios { get { return textBoxAgiosCompteModif.Text; } set { textBoxAgiosCompteModif.Text = value; } }
        public string Interets { get { return textBoxInteretsCompteModif.Text; } set { textBoxInteretsCompteModif.Text = value; } }
        public string Plafond { get { return textBoxPlafondCompteModif.Text; } set { textBoxPlafondCompteModif.Text = value; } }

        public ModifierCompte()
        {
            InitializeComponent();
        }

        private void btnModifCompte_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
