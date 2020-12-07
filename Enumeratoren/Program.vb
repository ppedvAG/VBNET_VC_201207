Imports System

Module Program

    'ENUMERATOREN sind Datentypen, deren Variablen ausschlie�lich bestimmte vordefinierte Werte annehmen k�nnen.
    ''Enumeratoren m�ssen au�erhalb von Methoden definiert werden
    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag
    End Enum

    Sub Main()

        'Deklaration und Initialisierung einer Enumerator-Variablen
        Dim heute As Wochentag = Wochentag.Mittwoch
        Console.WriteLine($"Heute ist {heute}.")

        Console.WriteLine($"Was glaubst du, welcher Wochentag heute ist?")
        'Durchlauf �ber die m�glichen Zustande
        For index = 1 To 7
            Console.WriteLine($"{index}: {DirectCast(index, Wochentag)}")
        Next

        'Abfrage eines Enumerator-Zustandes vom Benutzer und Umwandlung von String -> Int -> Enumarator
        heute = Integer.Parse(Console.ReadLine())

        Console.WriteLine($"Heute ist {heute}.")


        'SELECTs sind verk�rzte If-Bl�cke, mit denen genau eine Variable auf ihren Zustand hin �berpr�ft wird.
        ''Jeder Zustand, bei dem etwas passieren soll, wird als CASE definiert, in welchem dann der spezifische Programm-
        ''verlauf definiert wird. Wenn die Variable einen nicht n�her definierten Zustand annimmt, wird der ELSE-CASE
        ''ausgef�hrt
        Select Case heute

            Case Wochentag.Montag
                Console.WriteLine("Sch�nen Wochenstart")
            Case Wochentag.Mittwoch
                Console.WriteLine("H�lfte geschafft")
            Case Wochentag.Freitag
                Console.WriteLine("Woche fast vorbei")
            Case Else
                Console.WriteLine("Woche l�uft...")

        End Select


        Console.ReadKey()
    End Sub

End Module
