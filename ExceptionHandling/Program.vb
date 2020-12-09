Imports System

'Mittels Exception-Handling f�hrt man eine Bearbeitung von Laufzeitfehlern im Programm durch.
Module Program

    'Eigene Exceptions m�ssen von der Exception-Klasse erben und k�nnen dann manuell mittels des throw-Stichworts
    ''geworfen werden
    Public Class MyException
        Inherits Exception

        Public Sub New()
            MyBase.New("Dies ist mein Fehler!")
        End Sub

    End Class

    Sub Main(args As String())

        'In einen TRY-Block werden die Programmteile geschrieben, welche m�glicherweise zur Laufzeit einen Fehler
        ''produzieren (z.B. die Integer.Parse()-Funktion). Kommt es zu einem Fehler wird eine EXCEPTION geworfen,
        ''die Ausf�hrung des Try-Blocks wird abgebrochen und die Exception muss von einem passenden CATCH-Block 
        ''abgefangen werden.
        Try

            'M�glicher Exceptionwurf
            Dim zahl As Integer = Integer.Parse(Console.ReadLine())
            Console.WriteLine(zahl * 2)

            'Mittels des THROW-Stichworts k�nnen Exceptions manuell geworfen werden
            Throw New MyException()

        Catch ex As FormatException
            'Jedem Try-Block muss mindestens ein Catch-Block folgen, in welchem die geworfenen Fehler abgefangen 
            ''werden. Im Catch-Block kann definiert werden, welche Exceptions abgefangen werden (Signatur) und 
            ''wie sie bearbeitet werden (K�rper). Nach der Bearbeitung Nicht abgefangene Exceptions werden an 
            ''den Benutzer durchgereicht und f�hren zum Programmabbruch.

            Console.WriteLine("Du musst eine ganze Zahl eingeben.")
            Console.WriteLine(ex.Message)

        Catch ex As OverflowException

            Console.WriteLine("Deine Zahl ist zu gro�/klein.")
            Console.WriteLine(ex.Message)

            'Ein Throw-Befehl in einem Catch-Block schmei�t die EXception eine Ebene h�her
            Throw

        Catch ex As Exception

            Console.WriteLine("Ein unbekannter Fehler ist aufgetreten")
            Console.WriteLine(ex.Message)

        Finally
            'Der optionale FINALLY-Block wird, egal ob es zu einem Fehler kam oder nicht, immer ausgef�hrt

            Console.WriteLine("Wird immer angezeigt")

        End Try

        Console.WriteLine("ENDE TRY-BLOCK")

    End Sub

End Module
