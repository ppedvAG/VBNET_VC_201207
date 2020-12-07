Imports System

Module Program

    'Definition des Enumerators
    Enum Rechenoperation
        Addition = 1
        Subtraktion
        Multiplikation
        Division
    End Enum

    Sub Main()
        'Deklaration der Variablen
        Dim zahl1, zahl2 As Double
        Dim operation As Rechenoperation

        'Abfrage der Zahlen
        Console.Write("Gib eine Zahl ein: ")
        zahl1 = Double.Parse(Console.ReadLine())
        Console.Write("Gib eine weitere Zahl ein: ")
        zahl2 = Double.Parse(Console.ReadLine())

        'Abfrage der Rechenoperation
        Console.WriteLine($"{Environment.NewLine}W�hle eine Rechenoperation:")
        For index = 1 To 4
            Console.WriteLine($"{index}: {DirectCast(index, Rechenoperation)}")
        Next

        'Eingabe der Benutzerwahl (ReadLine) -> Umwandeln in Integer (Parse) -> Zuweisung zu Enum-Variable (=)
        operation = Integer.Parse(Console.ReadLine())

        '�bergabe der Werte an Funktion und Zuweisung des R�ckgabewerts (Ergebnis) zu einer Double-Variablen
        Dim ergebnis As Double = Berechne(zahl1, zahl2, operation)

        If Double.IsNaN(ergebnis) Then
            Console.WriteLine($"Deine Eingabe war fehlerhaft")
        Else
            Console.WriteLine($"{Environment.NewLine}Ergebnis: {ergebnis}")
        End If


        'Programmpause
        Console.ReadKey()
    End Sub

    'Berechne()-Funktion
    Public Function Berechne(zahl1 As Double, zahl2 As Double, operation As Rechenoperation) As Double
        'SelectCase zur Fallunterscheidung
        Select Case operation
            Case Rechenoperation.Addition
                Return zahl1 + zahl2
            Case Rechenoperation.Subtraktion
                Return zahl1 - zahl2
            Case Rechenoperation.Multiplikation
                Return zahl1 * zahl2
            Case Rechenoperation.Division
                Return zahl1 / zahl2
            Case Else
                'R�ckgabe der Konstanten NaN (Not A Number) der Double-Klasse bei fehlerhafter Eingabe
                Return Double.NaN
        End Select
    End Function

End Module
