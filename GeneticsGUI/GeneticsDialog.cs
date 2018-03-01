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
    public partial class GeneticsDialog : Form
    {
        public GeneticsDialog()
        {
            InitializeComponent();
        }
        public GeneticsDialog(string TITLE, string CONTENT)
        {
            InitializeComponent();
            Title = TITLE;
            Content = CONTENT;
        }

        private void GeneticsDialog_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            Text = Title;
            lblContext.Text = Content;
        }

        public string Title;
        public string Content;
        public string ReturnValue { get; set; }
    }
}
