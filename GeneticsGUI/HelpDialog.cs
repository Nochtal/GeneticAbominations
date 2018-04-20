using System;
using System.Windows.Forms;

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
            Text = "Help - " + level;
            lblContext.Text = GetText(level);
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
                "\tRace, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, Arcane, Divine. " +
                "More to come soon. Now to test what is here.");
        }

        private string basicContext()
        {
            throw new NotImplementedException();
        }

        private void HelpDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
