Imports System

Module Program

    'Delegates sind Datentypen, deren Variablen Refernzen auf Methoden aufnehmen k�nnen. Bei Aufruf der
    ''Variablen werden dann die Methoden ausgef�hrt. Jeder Delegatetyp kann die Methoden aufnehmen, welche
    ''seiner Signatur entsprechen

    'Defnition eines Delegate-Datentypen
    Public Delegate Function MyDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main(args As String())

        'Deklaration einer Delegatevariablen
        'Mittels des ADDRESSOF-Stichworts k�nnen Methoden den Delegate-Variablen zugeordnet werden 
        Dim delegateVariable As MyDelegate = AddressOf Addiere
        'Ausf�hrung der Methode in der Variablen
        Console.WriteLine(delegateVariable(78, 45))

        'Neuzuweisung der Variablen
        delegateVariable = AddressOf Subtrahiere
        Console.WriteLine(delegateVariable(78, 45))

        '�bergabe einer Methode an eine andere Methode (mittels Delegate-�bergabeparameter)
        RechneUndGibAus(delegateVariable)
        RechneUndGibAus(AddressOf Addiere)

        'Deklaration eines Funcs (generischer Delegate) und Initialisierung mit einer Methode
        Dim myFunc As Func(Of Integer, Integer, Integer) = AddressOf Addiere
        'Ausf�hrung des Funcs
        Console.WriteLine(myFunc(56, 12))

        Dim st�dteListe As List(Of String) = New List(Of String)()
        st�dteListe.Add("M�nchen")
        st�dteListe.Add("Hamburg")
        st�dteListe.Add("Berlin")
        st�dteListe.Add("K�ln")
        st�dteListe.Add("Stuttgart")

        'Verschiedene Ausf�hrungen der Bef�llung der Find()-Funktion einer Liste:
        ''�bergabe einer Methode (f�r Methode s.u.)
        Dim ergebnis As String = st�dteListe.Find(AddressOf SucheStadtMitH)

        ''�bergabe einer anonymen Methode in einem Delegate <- Methode, welche keinen Bezeichner hat und nur ein einem Delegate existiert
        Dim suchPredicate As Predicate(Of String) = Function(stadt As String) As Boolean
                                                        Return stadt.StartsWith("H")
                                                    End Function

        ergebnis = st�dteListe.Find(suchPredicate)

        ''�bergabe einer anonymen Methode direkt in den �bergabeparamteren
        ergebnis = st�dteListe.Find(Function(stadt As String) As Boolean
                                        Return stadt.StartsWith("H")
                                    End Function)

        ''�bergabe der anonymen Methode in KurzSchreibweise
        ergebnis = st�dteListe.Find(Function(stadt) stadt.StartsWith("H"))

        'Ausgabe des Ergebnisses
        Console.WriteLine(ergebnis)

        'Sortieren der Liste nach Wortl�nge per Kurzschreibweise
        st�dteListe = st�dteListe.OrderByDescending(Function(stadt) stadt.Length).ToList()

        'Ausgabe der Liste
        For Each stadt In st�dteListe
            Console.WriteLine(stadt)
        Next
    End Sub

    'Beispielmethoden:
    ''Methode, welche die Suchlogik f�r die Find()-Funktion beinhaltet
    Public Function SucheStadtMitH(stadt As String) As Boolean
        Return stadt.StartsWith("H")
    End Function

    ''Methode, welche einen Delegate als �begabeparameter verlangt
    Public Sub RechneUndGibAus(methode As MyDelegate)
        Console.WriteLine(methode(123, 456))
    End Sub

    ''Bsp-Methoden zur Bef�llung der Delegates
    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Addiere")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Subtrahiere")
        Return a - b
    End Function

End Module
