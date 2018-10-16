Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports MojangSharp.Responses
Imports MojangSharp.Responses.ApiStatusResponse

Public Class Main
    Private Shared client As Object

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Shared Async Function GetProductAsync(ByVal path As String) As Task(Of Main)
        Dim product As Main = Nothing
        Dim response As HttpResponseMessage = Await client.GetAsync(path)

        If response.IsSuccessStatusCode Then
            product = Await response.Content.ReadAsAsync(Of Main)()
        End If

        Return product
    End Function

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click, Button2.Click
        TextBoxUsername1.Text = "jtrent238"
        TextBoxUsername2.Text = "jtrent238"
        TextBoxUUID.Text = "962338d78deb47c3b144f64eab941480"
    End Sub

    Private Sub ButtonGetSkin_Click(sender As Object, e As EventArgs) Handles ButtonGetSkin.Click
        TextBoxUsername2.Text = TextBoxUsername1.Text

        Dim sUrl As String = "https://api.mojang.com/users/profiles/minecraft/" + TextBoxUsername1.ToString
        Dim wRequest As HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create(sUrl), HttpWebRequest)

        wRequest.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials 'Not always needed
        wRequest.Method = "GET"

        Dim wResponse As HttpWebResponse = DirectCast(wRequest.GetResponse(), HttpWebResponse)

        Dim sResponse As String = ""

        Using srRead As New StreamReader(wResponse.GetResponseStream())
            sResponse = srRead.ReadToEnd()
        End Using

        TextBoxUUID.Text = sResponse

        'WebBrowser1.Navigate("https://api.mojang.com/user/profile/" + TextBoxUUID.ToString + "/skin")
    End Sub

    Private Sub ButtonRandomSkin_Click(sender As Object, e As EventArgs) Handles ButtonRandomSkin.Click

        If File.Exists("usernames.usr") Then
            'StreamReader to read our file
            Dim ioFile As New StreamReader("usernames.usr")
            'Generic list for holding the lines
            Dim lines As New List(Of String)
            'Random class to generate our random number
            Dim rnd As New Random()
            'Variable to hold our random line number
            Dim line As Integer
            'Now we loop through each line of our text file
            'adding each line to our list
            While ioFile.Peek <> -1
                lines.Add(ioFile.ReadLine())
            End While

            'Now we need a random number
            line = rnd.Next(lines.Count + 1)
            'Now write out the random line to the TextBox
            'RichTextBox1.AppendText(lines(line).Trim())
            TextBoxUsername1.Text = lines(line).Trim()
            'TextBoxUsername2.Text = lines(line).Trim()
            'Close our StreamReader
            ioFile.Close()
            'Dispose of the instance
            ioFile.Dispose()
        Else
            Dim ioFile As New StreamWriter("sayings.txt")

            ioFile.WriteLine("Chinese words here")
            ioFile.WriteLine("Chinese words here")
            ioFile.WriteLine("Chinese words here")
            ioFile.Close()
        End If

        'TextBoxUUID.Text = "962338d78deb47c3b144f64eab941480"
    End Sub
End Class
