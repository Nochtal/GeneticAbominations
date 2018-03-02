using System;
using System.Windows.Forms;

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
        

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0 && txtInput.Text.Length < 25)
            {
                this.ReturnValue = txtInput.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(Title + "Confirmation", "Invalid name. Please be sure input is between 1 and 25 characters long", MessageBoxButtons.OK);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue = "CANCEL";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
