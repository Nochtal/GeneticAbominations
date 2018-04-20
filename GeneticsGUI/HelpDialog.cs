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
                case "basics":
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
            return string.Format("Welcome to Genetic Abominations!\n\n" +
                "Creatures mate, either randomly or by your choice, to create new creatures! You get to pick what you want to breed for! For each mating, each parent will create a helix of genes which will then combine to create the DNA of the new creature born! Each time this is done, any aberations on a parents passed-on gene is folded into the effect of the gene, and the new, resulting gene has a small chance to mutate itself.\n" +
                "By creatively picking who to mate, you can raise specific attributes! Depending on the species, each creature has a maximum lifespan! Once they reach that age, they die, and can no longer participate in reproduction of creatures. Under View, you can always visit the graveyard to see creatures that have passed in the society."
                );
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
            return string.Format("Welcome to Genetic Abominations!\n\n" + 
                "This is a simple little game with no distinct endgoal. A random society with 4 random creatures will start you off. By clicking on a name in the list to the left, you can see their attribute values, age, name, and parentage.\n" +
                "Below the list of creatures, there are three options:\n" +
                "\t\u2022Randomly Mate (choose how many times to the right)\n" +
                "\t\u2022Sort by: (pick which attribute to sort by to the right)\n" +
                "\t\u2022Mate\nFor the Mate option, click on one name in the population list, and then a second name on the population list. When you click Mate, the current and previous selections will mate to produce a new creature.\n" +
                "On the ribbon bar, you can save/open societies."
                );
        }        
    }
}
