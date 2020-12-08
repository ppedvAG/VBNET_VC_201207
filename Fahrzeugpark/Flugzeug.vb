'vgl Schiff
Public Class Flugzeug
    Inherits Fahrzeug
    Implements IBewegbar

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
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

    Public Sub New(name As String, preis As Double, maxG As Integer, maxF As Integer)
        MyBase.New(name, preis, maxG)
        _maxFlughöhe = maxF
        _anzahlReader = 8
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Flugzeug " + MyBase.BeschreibeMich() + $" Es kann auf {MaxFlughöhe}m aufsteigen."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Piep")
    End Sub

    Public Sub Crash() Implements IBewegbar.Crash
        AnzahlRaeder -= 1
        Console.WriteLine("Die Startbahn war nicht frei")
    End Sub
End Class
