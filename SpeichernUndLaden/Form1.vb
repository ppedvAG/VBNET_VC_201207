Imports System.IO

Public Class Form1
    'Events-Handler der Click-Events der Buttons
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        'Aufruf der Speichern-Funktion mit Übergabe des TextBox-Inhalts
        SaveText(Tbx_Input.Text)
    End Sub

    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        'Leeren der TextBox
        Tbx_Input.Clear()
        'Einfügen des geladenenen Texts in die TextBox
        Tbx_Input.Text = LoadText()
    End Sub

    'Methode zum Speichern eines Strings
    Private Sub SaveText(text As String)
        'Deklarierung der StreamWriter-Vatiablen vor dem Try-Block
        Dim writer As StreamWriter

        Try
            'Initialisierung des SaveFileDialogs
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()

            'Einstellungen des SaveDialogs
            ''Standart-Dateiname
            saveDialog.FileName = "testText.txt"
            ''Standart-Dateipfad
            saveDialog.InitialDirectory = "C:\"
            ''Verwendung eines Standart-Ordners (hier MyDocuments)
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            ''Dateityp-Filterliste
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            'Öffnen des Dialogs und Abfrage der Antwort
            If saveDialog.ShowDialog() = DialogResult.OK Then
                'Initialisierung des StreamWriters mit Übergabe des Speicherorts
                writer = New StreamWriter(saveDialog.FileName)
                'Schreiben des Texts in die Datei
                writer.WriteLine(text)
                'Schreiben einer zusätzlichen Zeile in die Datei
                writer.Write("ENDE DER DATEI")
                'Ausgabe einer Erfolgsnachricht
                MessageBox.Show("Speichern erfolgreich")

            End If

        Catch ex As Exception
            'Ausgabe einer Fehlermeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally

            'Prüfung, ob der StreamWriter initialisiert wurde
            If Not IsNothing(writer) Then
                'Schließen des Streams zur Freigabe der Datei für andere Applikationen
                writer.Close()
            End If

            ''Alternative Null-Prüfung
            'writer?.Close()

        End Try

    End Sub

    'Methode zum Laden eines Strings aus der Datei (vgl. SaveText())
    Private Function LoadText() As String

        Dim loadedString As String = String.Empty
        Dim reader As StreamReader

        Try

            Dim openDialog = New OpenFileDialog()

            openDialog.FileName = "testText.txt"
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            If openDialog.ShowDialog() = DialogResult.OK Then

                reader = New StreamReader(openDialog.FileName)

                'Lesen des gasamten Texts der Datei
                loadedString = reader.ReadToEnd()

                ''Alterativ: Lesen jeder einzelnen Zeile in der Datei
                'While Not reader.EndOfStream
                '    loadedString += reader.ReadLine() + vbNewLine
                'End While

                MessageBox.Show("Laden erfolgreich")

            End If

        Catch ex As Exception

            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            reader?.Close()

        End Try

        Return loadedString

    End Function
End Class
