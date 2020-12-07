Imports System

Module Program

    'KONTROLLSTRUKTUREN regeln den Ablauf des Programms unter Bezug auf bestimmte, durch boolsche Werte oder logische
    ''Operationen dargestellte Zust�nde des Programms
    Sub Main(args As String())

        'Deklaration und Initialisierung von Bool-Variablen
        Dim a As Integer = 110
        Dim b As Integer = 120

        'Ein IF-Block teilt den Programmablauf in mehrere Pfade, abh�ngig von einer oder mehrerer Bedingungen. Das Programm
        ''wird jeweils den ersten Block ausf�hren, bei welchem es auf eine wahre Bedingung trifft.
        If a < b Then
            'Dies wird ausgef�hrt, wenn die Bedingung des IF-Blocks wahr ist.
            Console.WriteLine("A ist kleiner als B")
            'Diese Variable ist nur innerhalb des If-Blocks bekannt
            Dim zahl As Integer = 123
            Console.WriteLine(zahl)

        ElseIf a > b Then
            'Ein If-Block kann beliebig viele ELSEIF-Bl�cke beinhalten, welche weitere Bedingungen pr�fen. Diese werden
            ''jedoch nur gepr�ft, wenn alle vorherigen Bedingungen false sind.
            Console.WriteLine("A ist gr��er als B")

        ElseIf a > b Then
            'Dieser Block wird nie ausgef�hrt, da diese Bedingung bereits durch die vorherige abgedeckt wird
            Console.WriteLine("Hallo")

        Else
            'Der optionale ELSE-Block wird ausgef�hrt, wenn keine der vorherigen Bedingungen wahr sind.
            Console.WriteLine("A ist gleich B")

        End If
        Console.WriteLine("Ende des IF-Blocks")


        'Eine WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein
        ''unwahr, wird die Schleife �bersprungen
        While a < b

            Console.WriteLine("Schleife " + a.ToString())

            a += 1

            'Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und zwingt das Programm die Bedingung erneut
            ''zu pr�fen. Ist die Bedingug nicht wahr, wird kein neuer Durchlauf gestartet.
            Continue While

        End While


        'Auch eine DO-WHILE-Schleife wird solange wiederholt, bis die Bedingung unwahr ist. Allerdings findet die Bedingungs-
        ''pr�fung erst am Ende eines Schleifendurchlaufs statt. D.h. die Scheife l�uft mindestens einmal durch.
        Do

            Console.WriteLine("Do-Schleife")

            Console.Write("Soll die Schleife wiederholt werden (Y/N)?")
            If Console.ReadKey().Key <> ConsoleKey.Y Then
                'Der EXIT-Befehl beendet eine Schleife sofort und zwingt das Programm unterhalb der Schleife weiter zu machen.
                Exit Do
            End If

        Loop While True

        'Bsp f�r Do Until (<= Verneinung von Do While)
        Do

            a -= 1


        Loop Until a < 110


        'Do

        '    a -= 1


        'Loop While Not a < 110


        'Eine FOR-Schleife besitzt eine Laufindexvariable, welche bei jedem Durchlauf manipuliert wird. Durch die Initialisierung
        ''dieser und der Angabe eines maximalen Werts, kann man festlegen, wie oft die Schleife durchl�uft
        For index = 1 To 10

            Console.WriteLine("Durchlauf Nr. " + index.ToString())

        Next

        'Mittels des optionalen STEP-Befehls kann man selbst die Manipulation der Indexvariablen bestimmen
        For index = 10 To 0 Step -2

            Console.WriteLine("Durchlauf Nr. " + index.ToString())

        Next


        'Ein ARRAY ist eine Sammlung von Werten eines bestimmten Datentyps. Ein Zugriff auf die einzelnen Werte erfolgt �ber
        ''einen Null-basierten Index. Die Gr��e eines Arrays muss bei Deklaration festgelegt werden.
        Dim St�dte As String() = {"M�nchen", "Berlin", "Hamburg"}
        Dim St�dte2 = New String() {"M�nchen", "Berlin", "Hamburg"}

        'Ausgabe des Werts an der Indexposition 1
        Console.WriteLine(St�dte(1))
        'Manipulation des Wertes an der ersten(!) Position
        St�dte(0) = "K�ln"

        'Iteration einer For-Schleife �ber ein Array
        For index = 0 To St�dte.Length - 1

            Console.WriteLine(St�dte(index))

        Next

        'Eine FOREACH-Schleife kann �ber eine Collection wie z.B. ein Array laufen und spricht dabei jedes Element genau
        ''einmal an
        For Each stadt In St�dte

            Console.WriteLine(stadt)

        Next

        'Mittels des REDIM-Befehls kann man die Gr��e (d.h. Kapazit�t) des Arrays manipulieren. In die Klammern schreibt man
        ''die neue Gr��e des Arrays. Mit dem PRESERVE-Stichwort beh�lt das Array alle bisherigen Werte
        ReDim Preserve St�dte(3)
        St�dte(3) = "Berlin"

        'Mittels der Contains()-Methode kann eine Collection auf einen Inhalt hin �berpr�ft werden
        Console.WriteLine(St�dte.Contains("Hamburg"))

    End Sub

End Module
