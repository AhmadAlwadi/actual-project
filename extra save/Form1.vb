Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private Structure importvalues
        Dim name_ As String
        Dim score As Integer
    End Structure
    Dim leaderboard(9999) As importvalues
    Dim swaps As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("please insert your full name")
        answer = InputBox("who is the first president of the US")
        If answer = "george washington" Or answer = "George washington" Or answer = "George Washington" Or answer = "George Washington" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("What is the capital of England?")
        If answer = "London" Or answer = "london" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many yellow cards are needed to get a red in football")
        If answer = "two" Or answer = "2" Or answer = "Two" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is the current US president")
        If answer = "Donald Trump" Or answer = "Donald trump" Or answer = "donald trump" Or answer = "Trump" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many pairs of wings does a pidgeon have")
        If answer = "1" Or answer = "One" Or answer = "1" Or answer = "one" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        TextBox1.Text = TextBox1.Text + "your score was " + Str(points) + vbNewLine


        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = " data source = P:\ConnorComputingAssignment\Assignment\Project Redo\Project Redo\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()

            Dim query2 As String = "insert into [Assignment DB](Name_,Score) values('" & name & "', '" & points & "');"
            Dim command2 As New OleDbCommand(query2, conn)
            SQLReader = command2.ExecuteReader()

            conn.Close()

        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

        Printresults()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("Please enter your name ")
        answer = InputBox("How many points is a try worth in rugby")
        If answer = "5" Or answer = "Five" Or answer = "five" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what is the capital of Scotland")
        If answer = "Edinburgh" Or answer = "edinburgh" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what element is represented by the letter O on the periodic table")
        If answer = "Oxygen" Or answer = "oxygen" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is married to Victoria Adams ")
        If answer = "David beckham" Or answer = "David Beckham" Or answer = "david beckham" Or answer = "Beckham" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many pairs of wings does a bee have")
        If answer = "2" Or answer = "Two" Or answer = "2" Or answer = "two" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If


        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = " data source = P:\ConnorComputingAssignment\Assignment\Project Redo\Project Redo\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()

            Dim query2 As String = "insert into [Assignment DB](Name_,Score) values('" & name & "', '" & points & "');"
            Dim command2 As New OleDbCommand(query2, conn)
            SQLReader = command2.ExecuteReader()

            conn.Close()

        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

        Printresults()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("Please enter your name ")
        answer = InputBox("How many points is a covertion worth in rugby")
        If answer = "2" Or answer = "Two" Or answer = "two" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what is the capital of Brazil")
        If answer = "brasilia" Or answer = "Brasilia" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what element is represented by the letter K on the periodic table")
        If answer = "Potassium" Or answer = "potassium" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is the current prime minister ")
        If answer = "Boris Johnson" Or answer = "Boris johnson" Or answer = "boris johnson" Or answer = "johnson" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many european cups have manchester city won as of the 2018/19 season")
        If answer = "0" Or answer = "Zero" Or answer = "zero" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        TextBox1.Text = TextBox1.Text + "your score was " + Str(points)

        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = " data source = P:\ConnorComputingAssignment\Assignment\Project Redo\Project Redo\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()

            Dim query2 As String = "insert into [Assignment DB](Name_,Score) values('" & name & "', '" & points & "');"
            Dim command2 As New OleDbCommand(query2, conn)
            SQLReader = command2.ExecuteReader()

            conn.Close()

        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

        Printresults()
    End Sub

    Private Sub Printresults()


        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = "  data source = P:\ConnorComputingAssignment\Assignment\Project Redo\Project Redo\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()


            Dim query1 As String = "select * from [Assignment DB]"
            Dim command1 As New OleDbCommand(query1, conn)
            SQLReader = command1.ExecuteReader()

            If SQLReader.HasRows Then
                While SQLReader.Read

                    TextBox1.Text = TextBox1.Text + SQLReader("Name_") + SQLReader("Score") + vbNewLine

                End While

            End If


        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = " data source = P:\ConnorComputingAssignment\Assignment\Project Redo\Project Redo\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()

            Dim noOfRes As Integer
            Dim query2 As String = "select count(*) as [NumberOfRes] from [Assignment DB];"
            Dim command2 As New OleDbCommand(query2, conn)
            SQLReader = command2.ExecuteReader()
            If SQLReader.HasRows Then
                While SQLReader.Read
                    noOfRes = SQLReader("NumberOfRes")
                    MsgBox(Str(noOfRes))
                End While
            End If

            Dim index As Integer = 0
            Dim query1 As String = "select * from [Assignment DB];"
            Dim command1 As New OleDbCommand(query1, conn)
            SQLReader = command1.ExecuteReader()

            If SQLReader.HasRows Then
                While SQLReader.Read

                    leaderboard(index).name_ = SQLReader("Name_")
                    leaderboard(index).score = SQLReader("Score")
                    index += 1

                End While

            End If


        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try
        sortlist()
        searchforvalue()
    End Sub

    Private Sub searchforvalue()
        Dim target As String
        target = InputBox("please insert the name of the person you are looking for")
        For counter = 0 To leaderboard.Length - 1
            If leaderboard(counter).name_ = target Then
                TextBox1.Text = TextBox1.Text + leaderboard(counter).name_ + "achieved the score of " + leaderboard(counter).score
            End If
        Next
    End Sub

    Private Sub sortlist()

        Dim n As Integer
        Dim swapped As Boolean
        n = leaderboard.Length - 1
        Do
            swapped = False
            For inner = 1 To n
                If leaderboard(inner - 1).score < leaderboard(inner).score Then
                    swap(leaderboard(inner - 1), leaderboard(inner))
                    swapped = True
                End If
            Next
        Loop Until swapped = False

        For counter = 0 To leaderboard.Length - 1
            TextBox1.Text = TextBox1.Text + leaderboard(counter).name_ + Str(leaderboard(counter).score) + vbNewLine
        Next

    End Sub

    Private Sub swap(ByRef first As importvalues, ByRef second As importvalues)
        Dim temp As importvalues
        temp = first
        first = second
        second = temp
    End Sub
End Class
