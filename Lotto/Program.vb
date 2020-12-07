Imports System

Module Program

    Sub Main(args As String())

        'Deklaration/Initialisierung des Random-Objekts
        Dim generator = New Random()
        'Deklaration der Arrays
        Dim zufallsZahlen(2), benutzerZahlen(2) As Integer

        Do
            '"Bef�llung" des Zufallszahlenarrays
            For index = 0 To 2
                'Erstellung einer Hilfsvariablen
                Dim temp As Integer
                Do
                    'Erw�rfeln der Hilfsvariablen
                    temp = generator.Next(1, 11)
                    'Wiederholung des Wurfes, wenn die Zahl schon im Array ist
                Loop While zufallsZahlen.Contains(temp)
                '�bertrag in das Zufallszahlenarray
                zufallsZahlen(index) = temp
            Next

            '"Bef�llung" des Benutzerzahlenarrays
            For index = 0 To 2
                Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ")
                benutzerZahlen(index) = Integer.Parse(Console.ReadLine())
            Next

            'Z�hlen der Treffer
            Dim treffer As Integer = 0
            For Each zahl In zufallsZahlen
                If benutzerZahlen.Contains(zahl) Then
                    treffer += 1
                End If
            Next

            'Ausgabe des Ergebnisses
            Console.WriteLine($"Gewinnzahlen: {zufallsZahlen(0)}, {zufallsZahlen(1)}, {zufallsZahlen(2)}")
            Console.WriteLine($"Du hast {treffer} Richtige(n)")

            'Schleife zur Wiederholung
            Console.WriteLine(Environment.NewLine + "Nochmal? (Y/N)")
        Loop While Console.ReadKey(True).Key = ConsoleKey.Y
    End Sub

End Module
