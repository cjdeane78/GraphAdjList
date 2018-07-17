Module Module1
    Class Graph
        Property Edges As Dictionary(Of String, String())
    End Class

    Sub Main()
        Dim Graph1 As New Graph

        Graph1.Edges = New Dictionary(Of String, String()) From
            {
            {"A", {"B", "C"}},
            {"B", {"A", "C", "D"}},
            {"C", {"A", "B"}},
            {"D", {"C"}}
            }

        For Each edge In Graph1.Edges("A")
            Console.WriteLine(edge)
        Next

        Console.ReadLine()
    End Sub

End Module
