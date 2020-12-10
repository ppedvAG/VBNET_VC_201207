Imports Newtonsoft.Json
Imports System.IO

Public Class Form1
    'Event-Handler der Click-Events der Buttons
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        'Hinzufügen einer neuen Person zu der Liste
        Lbx_People.Items.Add(CreateNewPerson())
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        'Löschen der durch den Benutzer in der Liste markierten Person
        DeletePerson(Lbx_People.SelectedItem)
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        'Speichern der Personenobjekte in der Liste
        SavePeople(Lbx_People.Items)
    End Sub

    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        'Leeren der LIste
        Lbx_People.Items.Clear()
        'Hinzufügen der geladenen Personen zu der Liste
        For Each person In LoadPeople()
            Lbx_People.Items.Add(person)
        Next
    End Sub

    'Methode zum zufälligen Erstellen einer Person
    Private generator As Random = New Random()
    Private Function CreateNewPerson() As Person
        'Würfeln des Namens
        Dim name As String = String.Empty
        Select Case generator.Next(1, 5)
            Case 1
                name = "Anna Nass"
            Case 2
                name = "Rainer Zufall"
            Case 3
                name = "Maria Johanna"
            Case 4
                name = "Hugo Meier"
        End Select
        'Würfeln des Geburtsdatums
        Dim geburtsdatum As DateTime = New DateTime(generator.Next(1930, 2021), generator.Next(1, 13), generator.Next(1, 29))
        'Rückgabe einer neuen Person
        Return New Person(name, generator.Next(120, 210), geburtsdatum)
    End Function

    'Methode zum Löschen einer Person
    Private Sub DeletePerson(person As Person)
        'Löschen einer Person aus der Liste
        Lbx_People.Items.Remove(person)
    End Sub

    'Methode zum Speichern einer Personenliste
    Private Sub SavePeople(liste As IList)

        Dim writer As StreamWriter

        Try

            writer = New StreamWriter("personen.txt")

            'Erstellen von Settings für den Serialisierer
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            'Einstelung, damit der Objekttyp mitgespeichert wird
            settings.TypeNameHandling = TypeNameHandling.Objects

            'Schleife über die Liste
            For Each person In liste
                'Serialisierung einer Person in einen String
                Dim personAsString As String = JsonConvert.SerializeObject(person, settings)
                'Speichern des Person-Strings in der Datei
                writer.WriteLine(personAsString)
            Next

            MessageBox.Show("Speichern erfolgreich")

        Catch ex As Exception

            MessageBox.Show("Speichern fehgeschlagen")


        Finally

            writer?.Close()

        End Try

    End Sub

    'Methode zum Laden einer Personenliste
    Private Function LoadPeople() As List(Of Person)

        Dim personenliste As List(Of Person) = New List(Of Person)()

        Dim reader As StreamReader

        Try
            reader = New StreamReader("personen.txt")

            'Setzen der Einstellungen
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            'Schleife über die Datei
            While Not reader.EndOfStream
                'Laden und Desirialisieren des Strings in eine Person, sowie hinzufügen zu der Liste
                personenliste.Add(JsonConvert.DeserializeObject(Of Person)(reader.ReadLine(), settings))

            End While

            MessageBox.Show("Laden erfolgreich")

        Catch ex As Exception

            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            reader?.Close()

        End Try

        Return personenliste

    End Function

End Class
