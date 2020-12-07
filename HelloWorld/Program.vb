Imports System

'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Program

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    Sub Main(args As String())

        'Zugriff aud die BackgroundColor-Property der Console-Klasse und Neuzuweisung dieser
        Console.BackgroundColor = ConsoleColor.Blue

        'Ausgabe eines String-Literals in der Console
        Console.WriteLine("Hello World")

        'Deklaration einer String-Variablen
        Dim meinString As String
        'Initialisierung der String-Variablen
        meinString = "Hallo Welt"
        'Ausgabe der String-Variablen
        Console.WriteLine(meinString)

        'Neuzuweisung und Ausgabe der String-Variablen
        meinString = "Heute ist ein schöner Tag!"
        Console.WriteLine(meinString)

        'Deklaration und Initialisierung weiterer Variablen (jeweils in einer Zeile)
        Dim Alter As Integer = 31
        Dim Name As String = "Klaas"

        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden
        Dim kombinierterString As String = "Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt."
        Console.WriteLine(kombinierterString)
        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Mein Name ist {0} und ich bin {1} Jahre alt.", Name, Alter)
        ''$-Schreibweise -> Variablen werden direkt im String plaziert
        kombinierterString = $"Mein Name ist {Name} und ich bin {Alter} Jahre alt."
        Console.WriteLine(kombinierterString)
        Console.WriteLine($"Mein Name ist {Name} und ich bin {Alter} Jahre alt.")

        'Formatierung durch Konstanten
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine($"Dies ist ein Zeilenumbuch {System.Environment.NewLine} und dies {vbTab} ein hotizontaler Tab.")

        'C#-Syntax:
        Console.WriteLine($"Dies ist ein Zeilenumbuch \n und dies \t ein hotizontaler Tab.")

        'Deklaration und Initialisierung einer eigenen Konstanten
        Const Pi As Double = 3.15

        'Speichern einer Benutzereingabe (String) in einer Variablen
        Console.WriteLine("Bitte gib eine Zahl ein: ")
        Dim benutzereingabe As String = Console.ReadLine()
        Console.WriteLine(benutzereingabe)

        'Parsen des Strings in einen Integer
        Dim eingabeAlsInt As Integer = Integer.Parse(benutzereingabe)
        Console.WriteLine(eingabeAlsInt * 2)

        'Abgreifen und Zwischenspeichern einer gedrüclten Taste
        Dim pressedKey As ConsoleKeyInfo = Console.ReadKey()
        Console.WriteLine($"Du hast folgende Taste gedrückt: {pressedKey.Key}")

        'Demonstration: Teilung durch 0
        Dim a As Integer = 15
        Dim b As Integer = 0
        Dim erg As Double = a / b
        Console.WriteLine(erg)

        'Umwandlung Double in Integer (impliziet und expliziet)
        Dim gleitkommazahl As Double = 45.456
        Dim ganzzahl As Integer = gleitkommazahl
        ganzzahl = CInt(gleitkommazahl)

    End Sub

End Module
