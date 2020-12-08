'vgl auch Schiff
Public Class PKW
    Inherits Fahrzeug
    Implements IBewegbar

    Private _anzahlTueren As Integer
    Public Property AnzahlTueren() As Integer
        Get
            Return _anzahlTueren
        End Get
        Set(ByVal value As Integer)
            _anzahlTueren = value
        End Set
    End Property

    Private _anzahlReader As Integer
    Public Property AnzahlRaeder As Integer Implements IBewegbar.AnzahlRaeder
        Get
            Return _anzahlReader
        End Get
        Set(value As Integer)
            _anzahlReader = value
        End Set
    End Property

    Public Sub New(name As String, maxG As Integer, preis As Double, anzT As Integer)
        MyBase.New(name, maxG, preis)

        _anzahlTueren = anzT

        _anzahlReader = 4
    End Sub

    'Überschreibende Methode (Benötigt eine gleichnamige, mit OVERRIDABLE markierte Methode in der Mutterklasse)
    Public Overrides Function BeschreibeMich() As String
        Return $"Der PKW {MyBase.BeschreibeMich()} Er hat {AnzahlTueren} Türen."
    End Function

    'Implementierung der abstrakten Methode der Fahrzeug-Klasse
    Public Overrides Sub Hupen()
        Console.WriteLine("Hup Hup")
    End Sub

    Public Sub Crash() Implements IBewegbar.Crash
        AnzahlRaeder -= 1
        Console.WriteLine("Da war ein Baum im Weg")
    End Sub
End Class
