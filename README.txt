# GeneticAbominations

About Branch: Establish ribbon menu option Help\About

Algorithm testing through mini genetics based game.

Starting with three individuals, choose which genetic sequence will reproduce. 
Offspring will have genetic code resulting from parents. (Creatures now record parents)
See what you can get! 

Individuals have a double helix setup inside their DNA. Alpha Helix and Beta Helix.
DNA has a key name, and three variables.
  Variable One: Value of gene (1 through 10)
  Variable Two: Weight of gene (1 for dominate, 0 for recessive)
  Variable Three: Deviation (-2 through 2, with 0 being no aberration.)

Deviations can cause a gene's value to be below 1 or above 10.

When reproducing, both parental individuals generate a Zygot, which chooses randomly 
from Alpha Helix or Beta Helix the values it passes on. Both Zygots are then combined
to create the Alpha and Beta Helixes of the Offspring. Each time a Zygot is generated, 
there is a small chance for adaptation or aberration to happen within the gene as it is
passed on. The gene passed on from the parent will be modified by the parents Aberration, 
and the new gene will roll for random aberration seperately.

Each gene governs a statistic or attribute of the individual. The Result is determiend by the 
Alpha-Beta Compromise Formula (ABCF).
This gives each gene a Result range of -3 through 24, as two dominate genes will compound, and a recessive
gene will be nullified by the dominate gene. If both genes are recessive, the value will be the Alpha Helix
recessive gene values only.
At least one dominate gene:
  Result = Alpha[Value * Weight] + Beta[Value* Weight] + Aberrations.
Both recessive genes:
  The gene with the highest value will be used for calcuation:
  Result = [Value + Aberrations].

During development, the following Genes will be implemented:
  Race
  Strength
  Dexterity
  Constitution
  Intelligence
  Wisdom
  Arcane
  Divine
  
Races include: Trolls, Dwarves, Humans, Half-Elves, and Elves. Each creature has a maximum age they will live.
  MaxAge = (Constitution * Race + Divinity) / AberrationIndex + 50.
They have the following lifespans [race: gene range: min through max; age range: min to max]:
  Troll:    Race Gene: -3 through 0;  Age Range: 47 to 74  years
  Dwarf:    Race Gene:  1 through 4;  Age Range: 49 to 170 years
  Human:    Race Gene:  5 through 12; Age Range: 49 to 362 years
  Half-Elf: Race Gene: 13 through 18; Age Range: 48 to 506 years
  Elf:      Race Gene: 19 through 24; Age Range: 48 to 650 years

They are a bit arbitrary, and kept to 9 for simplicity. An actual system of gene-keys will be 
implemented further into development (and when I get more of an idea of what attributes I want
to include and how they are utilized).
