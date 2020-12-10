Imports System

Module Program
    Sub Main(args As String())

        Dim hund1 As Hund = New Hund("Bello", "Braun")
        Dim rabe1 As Rabe = New Rabe("Korax", "Schwarz")
        Dim flugzeug1 As Flugzeug = New Flugzeug(60)

        hund1.Fressen()
        Console.WriteLine(rabe1.Federfarbe)
        Console.WriteLine(flugzeug1.AnzahlPassagiere)

        Dim tier1 As Tier = hund1

        Dim fliegendesObjekt As IFlugfaehig = flugzeug1
        fliegendesObjekt = rabe1

        Dim liste As List(Of IFlugfaehig) = New List(Of IFlugfaehig)()

        liste.Add(rabe1)
        liste.Add(flugzeug1)

        Dim tierliste As List(Of Tier) = New List(Of Tier)()

        tierliste.Add(hund1)
        tierliste.Add(rabe1)

    End Sub
End Module

Public MustInherit Class Tier

    Private _anzahlBeine As Integer
    Public Property AnzahlBeine() As Integer
        Get
            Return _anzahlBeine
        End Get
        Set(ByVal value As Integer)
            _anzahlBeine = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Sub New(name As String, anzB As Integer)
        _name = name
        _anzahlBeine = anzB
    End Sub

    Public MustOverride Sub Fressen()

End Class

Public Class Hund
    Inherits Tier

    Private _fellFarbe As String
    Public Property FellString() As String
        Get
            Return _fellFarbe
        End Get
        Set(ByVal value As String)
            _fellFarbe = value
        End Set
    End Property

    Public Sub New(name As String, fellfarbe As String)
        MyBase.New(name, 4)
        _fellFarbe = fellfarbe
    End Sub

    Public Overrides Sub Fressen()
        Console.WriteLine("Der Hund " + Name + " frisst ein Stück Fleisch")
    End Sub
End Class

Public Class Rabe
    Inherits Tier
    Implements IFlugfaehig

    Private _federFarbe As String
    Public Property Federfarbe() As String
        Get
            Return _federFarbe
        End Get
        Set(ByVal value As String)
            _federFarbe = value
        End Set
    End Property

    Private _maxFlughoehe As Integer
    Public Property MaxFlughoehe As Integer Implements IFlugfaehig.MaxFlughoehe
        Get
            Return _maxFlughoehe
        End Get
        Set(value As Integer)
            _maxFlughoehe = value
        End Set
    End Property

    Public Sub New(name As String, federfarbe As String)
        MyBase.New(name, 2)
        _federFarbe = federfarbe
        _maxFlughoehe = 2
    End Sub

    Public Overrides Sub Fressen()
        Console.WriteLine("Der Rabe hat ein Korn gefunden.")
    End Sub

    Public Sub Absturz() Implements IFlugfaehig.Absturz
        Console.WriteLine("Der Rabe muss zum Arzt...")
    End Sub
End Class

Public Class Flugzeug
    Implements IFlugfaehig

    Private _anzahlPassagiere As Integer
    Public Property AnzahlPassagiere() As Integer
        Get
            Return _anzahlPassagiere
        End Get
        Set(ByVal value As Integer)
            _anzahlPassagiere = value
        End Set
    End Property

    Private _maxFlughoehe As Integer
    Public Property MaxFlughoehe As Integer Implements IFlugfaehig.MaxFlughoehe
        Get
            Return _maxFlughoehe
        End Get
        Set(value As Integer)
            _maxFlughoehe = value
        End Set
    End Property

    Public Sub New(anzahlP As Integer)
        _anzahlPassagiere = anzahlP
        _maxFlughoehe = 9000
    End Sub

    Public Sub Absturz() Implements IFlugfaehig.Absturz
        Console.WriteLine("Das Flugzeug braucht eine Reparatur")
    End Sub
End Class

Public Interface IFlugfaehig

    Property MaxFlughoehe As Integer

    Sub Absturz()

End Interface
