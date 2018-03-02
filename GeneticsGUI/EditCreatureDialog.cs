using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticDLL;

namespace GeneticsGUI
{
    public partial class EditCreatureDialog : Form
    {
        public EditCreatureDialog()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HUZZUH!", "You found the secret button!", MessageBoxButtons.OK);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wah Wah!", "This isn't a secret button.", MessageBoxButtons.OK);
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            
        }

        string NAME;
        int AGE;
        int GENERATION;
        string PARENTONE;
        string PARENTTWO;

        private void cbxNameRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameRandom.Checked)
            {
                txtName.Text = ExtensionMethods.GenerateName();
            }
        }
    }
}
