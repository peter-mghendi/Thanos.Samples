open System.IO
open Thanos
open Thanos.Stones

// Setup
let directory = Directory.CreateDirectory("earth")
for i in 1 .. 10 do 
    let file = File.Create (Path.Combine(directory.FullName, $"{i}.txt"))
    file.Close()

// A new mad titan called Thanos.
let thanos = new MadTitan()

// Forge a new Infinity Gauntlet.
let gauntlet = new InfinityGauntlet()

// Give Thanos the gauntlet
// You may choose to add the stones then give Thanos the gauntlet.
// The most important thing is that everything is in place before calling Snap() 
thanos.Give gauntlet

// Add the Infinity Stones.
gauntlet.Add (new SpaceStone())
gauntlet.Add (new MindStone())
gauntlet.Add (new RealityStone())
gauntlet.Add (new PowerStone())
gauntlet.Add (new TimeStone())
gauntlet.Add (new SoulStone())

// The Snappening
// This won't work if Thanos doesn't have a gauntlet or all the stones.
thanos.Snap directory.FullName |> ignore
