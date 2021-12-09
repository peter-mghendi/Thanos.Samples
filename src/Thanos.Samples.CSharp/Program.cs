using Thanos;
using Thanos.Stones;

// Setup
var directory = Directory.CreateDirectory("earth");
for (var i = 0; i < 10; i++)
{
    File.Create(path: Path.Combine(directory.FullName, $"{i}.txt")).Close();
}

// A new mad titan called Thanos.
MadTitan thanos = new();

// Forge a new Infinity Gauntlet.
InfinityGauntlet gauntlet = new();

// Give Thanos the gauntlet
// You may choose to add the stones then give Thanos the gauntlet.
// The most important thing is that everything is in place before calling Snap() 
thanos.Give(gauntlet: gauntlet);

// Add the Infinity Stones.
gauntlet.Add(stone: new SpaceStone());
gauntlet.Add(stone: new MindStone());
gauntlet.Add(stone: new RealityStone());
gauntlet.Add(stone: new PowerStone());
gauntlet.Add(stone: new TimeStone());
gauntlet.Add(stone: new SoulStone());

// The Snappening
// This won't work if Thanos doesn't have a gauntlet or all the stones.
thanos.Snap(location: directory.FullName);
