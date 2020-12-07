Imports System

Module Program

    Sub Main(args As String())

        'Deklaration und Initialisierung des Zufallszahlengenerators �ber dessen Konstruktor
        Dim generator As Random = New Random()

        'Schleife zur Wiederholung des Programms
        Do
            'Variable f�r Benutzereingabe
            Dim eingabe As Integer
            'Variable f�r zuf�llige Zahl und w�rfeln dieser
            Dim zuf�lligeZahl As Integer = generator.Next(1, 6)

            'Schleife zu Wiederholung der Benutzereingabe
            Do
                'Benutzereingabe
                Console.Write("Bitte gib eine ganze Zahl zwischen 1 und 5 ein: ")
                eingabe = Integer.Parse(Console.ReadLine())

                'Vergelich der Zahlen
                If eingabe < zuf�lligeZahl Then
                    'Fall 'Zahl zu klein'                    
                    Console.WriteLine("Deine Zahl ist zu klein.")

                ElseIf eingabe > zuf�lligeZahl Then
                    'Fall 'Zahl zu gro�'
                    Console.WriteLine("Deine Zahl ist zu gro�.")

                Else
                    'Fall 'Zahlen gleich'
                    Console.WriteLine("Herzlichen Gl�ckwunsch. Du hast die richtige Zahl erraten.")

                End If

                'Bedingung f�r Schleife: 'Zahlen ungleich'
            Loop While eingabe <> zuf�lligeZahl

            'Ausgabe der gesuchten Zahl
            Console.WriteLine($"Die gesuchte Zahl war {zuf�lligeZahl}.")

            'Bedingung zur Wiederholung: 'Benutzer dr�ckt Taste Y'
            Console.WriteLine("M�chtest du nochmal spielen (Y/N)?")
        Loop While Console.ReadKey(True).Key = ConsoleKey.Y

    End Sub

End Module
