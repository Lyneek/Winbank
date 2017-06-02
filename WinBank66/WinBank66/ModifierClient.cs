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
    public partial class ModifierClient : Form
    {
        public string ID { set { textBoxModifId.Text = value; } }
        public string NOM { get { return textBoxModifNom.Text; } set { textBoxModifNom.Text = value; } }
        public string PRENOM { get { return textBoxModifPrenom.Text; } set { textBoxModifPrenom.Text = value; } }
        public string ADR { get { return textBoxModifAdresse.Text; } set { textBoxModifAdresse.Text = value; } }
        public string CP { get { return textBoxModifCodePostal.Text; } set { textBoxModifCodePostal.Text = value; } }
        public string VILLE { get { return textBoxModifVille.Text; } set { textBoxModifVille.Text = value; } }

        public ModifierClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

    }
}
