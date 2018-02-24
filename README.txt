# GeneticAbominations
Algorithm testing through mini genetics based game.

Starting with three individuals, choose which genetic sequence will reproduce. 
Offspring will have genetic code resulting from parents. 
See what you can get! 

Individuals have a double helix setup. Alpha Helix and Beta Helix.
Each set of genes has both. 
Each Gene has a Key, which is the name of the gene, and three variables.
  Variable One: Value of gene (1 through 10)
  Variable Two: Weight of gene (1 for dominate, 0 for recessive)
  Variable Three: Aberration (-2 through 2, with 0 being no aberration.)

Aberrations can cause a gene's value to be below 1 or above 10.

When reproducing, both parental individuals generate a Zygot, which chooses randomly 
from Alpha Helix or Beta Helix the values it passes on. Both Zygots are then combined
to create the Alpha and Beta Helixes of the Offspring. Each time a Zygot is generated, 
there is a small chance for adaptation or aberration to happen within the gene as it is
passed on. The gene passed on from the parent will be modified by the parents Aberration, 
and the new gene will roll for random aberration seperately.

Each gene governs a statistic or attribute of the individual. The Result is determiend by the 
Alpha-Beta Compromise Formula (ABCF).
This gives each gene a Result range of -4 through 24, as two dominate genes will compound, and a recessive
gene will be nullified by the dominate gene. If both genes are recessive, the value will be the Alpha Helix
recessive gene values only.
At least one dominate gene:
  Result = Alpha[Value * Weight] + Beta[Value* Weight] + Aberrations.
Both recessive genes:
  The gene with the highest value will be used for calcuation:
  Result = [Value + Aberrations].
(Changes have beeen made to these formulas, will update when changes are completed)

These genes are stored as parallel Dictionary<string, double[]> _alpha and _beta (as private fields).

A full diagnostic of an indiviual can be called upon, showing the following text for each gene-key.
  {Gene Key}: Alpha: Value #; Weight #; Aberration #.
              Beta: Value #; Weight #; Aberration #.
              Result: #
              
              
During development, the following Genes will be implemented:
  Strength
  Dexterity
  Constitution
  Intelligence
  Wisdom
  Height
  Eyes
  Arcane
  Divine

They are a bit arbitrary, and kept to 9 for simplicity. An actual system of gene-keys will be 
implemented further into development (and when I get more of an idea of what attributes I want
to include and how they are utilized).
