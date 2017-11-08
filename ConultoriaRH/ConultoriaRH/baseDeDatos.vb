Imports System.Data.OleDb
Public Class baseDeDatos
    'poner el path de udes!!!!!
    Public path As String = "C:\Users\Juan Diego\Downloads\BDRH.mdb"

    Private provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    Private connString As String
    Private myConnection As OleDbConnection
    Private userTables As DataTable

    Private tableResults As DataTable = New DataTable()
    Public ReadOnly Property table() As DataTable
        Get
            Return tableResults
        End Get
    End Property


    Public Sub New()
        Me.connString = provider & path
        Me.myConnection = New OleDbConnection(connString)
    End Sub


    Public Sub make_query(ByVal query As String)
        Using (myConnection)
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter()
            adapter.SelectCommand = New OleDbCommand(query, myConnection)
            tableResults = New DataTable()
            adapter.Fill(tableResults)
            myConnection.Close()
        End Using
    End Sub
End Class
