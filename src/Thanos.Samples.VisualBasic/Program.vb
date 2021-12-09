Imports System.IO
Imports Thanos
Imports Thanos.Stones

Module Program
    Sub Main(args As String())
        ' Setup
        Dim dir As DirectoryInfo = Directory.CreateDirectory("earth")
        For index As Integer = 1 to 10
            File.Create(Path.Combine(dir.FullName, $"{index}.txt")).Close()
        Next

        ' A new mad titan called Thanos.
        Dim thanos As New MadTitan

        ' Forge a new Infinity Gauntlet.
        Dim gauntlet As New InfinityGauntlet

        ' Give Thanos the gauntlet
        ' You may choose to add the stones then give Thanos the gauntlet.
        ' The most important thing is that everything is in place before calling Snap() 
        thanos.Give(gauntlet)

        ' Add the Infinity Stones.
        gauntlet.Add(New SpaceStone)
        gauntlet.Add(New MindStone)
        gauntlet.Add(New RealityStone)
        gauntlet.Add(New PowerStone)
        gauntlet.Add(New TimeStone)
        gauntlet.Add(New SoulStone)

        ' The Snappening
        ' This won't work if Thanos doesn't have a gauntlet or all the stones.
        thanos.Snap(dir.FullName)
    End Sub
End Module
