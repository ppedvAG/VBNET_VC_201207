Module Module1

    'Methoden sind Programmteile, von denen jeder eine sehr spezielle und kleinteilige Aufgabe ausf�hrt.
    ''Es wird unterschieden zwischen Prozeduren, welche keinen R�ckgabewert besitzen und mit dem Stichwort
    ''SUB gekennzeichnet sind...
    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe = a + b
        Console.WriteLine(summe)
    End Sub

    '...und Funktionen, die einen R�ckgabewert besitzen und mit dem Stichwort FUNCTION markiert werden.
    ''Jede Methode besteht aus einem Kopf (einer Signatur) in welchem der Zugriff und die Methodenart
    ''definiert werden, ein Bezeichner f�r die Methode bestimmt wird und �bergabeparameter (und R�ckgabe-
    ''wert bei Funktionen) definiert werden... 
    Function Addiere(a As Integer, b As Integer) As Integer

        '...und einem K�rper, in welchem die Programmlogik hinterlegt wird.
        ''Mittels des RETURN-Befehls wird in Funktionen der R�ckgabewert an den Aufrufer gesand und die
        ''Ausf�hrung der Methode unterbrochen
        Dim summe = a + b
        Return summe

    End Function

    'Methoden, welche den gleichen Bezeichner haben aber unterschiedliche �bergabeparameter hei�en '�BERLADENE
    ''Methoden'. Eine Eindeutigkeit wird durch die verschiedenen �bergabeparameter erzielt. 
    Function Addiere(a As Double, b As Double) As Double

        Return a + b

    End Function

    'Mit dem OPTIONAL-Stichwort kann man Default-Werte f�r die �bergabeparameter definieren. Diese werden
    ''bei Nicht-Angabe der Parameter w�hrend des Methodenaufrufs eingesetzt.
    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Dim summe = a + b + c + d
        Return summe

    End Function

    'Mittels des PARAMARRAY-Stichwort k�nnen beliebig viele Parameter eines Datentyps �bergeben werden, welche 
    ''Methodenintern als Array interpretiert werden
    Public Function BildeSumme(ParamArray summanden() As Integer) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function


    Sub Main()

        AddiereUndGibAus(45, 12)

        Dim summe = Addiere(56, 12, 45)
        Console.WriteLine(summe)

        Console.WriteLine(Addiere(12, 12))

        Console.ReadKey()
    End Sub

End Module