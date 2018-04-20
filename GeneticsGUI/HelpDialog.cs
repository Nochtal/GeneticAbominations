using System;
using System.Windows.Forms;
using System.Drawing;

namespace GeneticsGUI
{
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

        public HelpDialog(string level)
        {
            InitializeComponent();
            lblTitle.Text = level;
            lblTitle.Location = new Point((Width / 2) - (lblTitle.Width / 2), 9);
            Text = "Help - " + level;
            rtbContext.Text = GetText(level);
        }

        private void HelpDialog_Load(object sender, EventArgs e)
        {

        }

        private string GetText(string level)
        {
            switch (level.ToLower())
            {
                case "basic":
                    return basicContext();
                case "about":
                    return aboutContext();
                case "advanced":
                    return advancedContext();
                default:
                    return "No context found.";
            }
        }

        private string advancedContext()
        {
            throw new NotImplementedException();
        }

        private string aboutContext()
        {
            return string.Format("Welcome to Genetic Abominations!\n" +
                "Mate creatures to raise population, advance time, and try to breed for a specific attribute. " +
                "Each attribute is determined by two genes, one from each parent. Even species is determined by genes! "+ "At the beginning, you will be given a random society with four randomly generated creatures. "+
                "Click on their name to see details about an individual creature. " + 
                "The following are genetic traits of the creatures you rule over: \n" +
                //== Attribute list ==//
                "\t\u2022Race\n\t\u2022Strength\n\t\u2022Dexterity\n\t\u2022Constitution\n\t\u2022Intelligence\n\t\u2022Wisdom\n\t\u2022Charisma\n\t\u2022Arcane\n\t\u2022Divine\n" +
                "Breed away, how strong of a society can you make? More to come in the future!\n" +
                "Genetic Abominations is a proof of concept application where I can test out various theories and programming concepts.");
        }

        private string basicContext()
        {
            throw new NotImplementedException();
        }        
    }
}
