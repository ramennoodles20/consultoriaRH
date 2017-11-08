Public Class Form1
    Dim querry As New baseDeDatos()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        querry.make_query("SELECT respuestasRH.[Nombre completo], respuestasRH.[Tipo Identificacion], respuestasRH.[pais de procedencia], respuestasRH.[pueto actual]
                            FROM (actividadesComplementarias INNER JOIN respuestasRH ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])
                            GROUP BY respuestasRH.[Nombre completo], respuestasRH.[Tipo Identificacion], respuestasRH.[pais de procedencia], respuestasRH.[pueto actual]")
        For Each row As DataRow In querry.table.Rows
            Dim nombre As String = row.Item("Nombre completo")
            Dim tipoID As String = row.Item("Tipo Identificacion")
            Dim paisDeProc As String = row.Item("pais de procedencia")
            Dim puestoActual As String = row.Item("pueto actual")
            MsgBox("Nombre: " & nombre & vbNewLine &
                   "ID: " & tipoID & vbNewLine &
                   "Pais de Procedencia: " & paisDeProc & vbNewLine &
                   "Pueto Actual: " & puestoActual
                   )
        Next
    End Sub
End Class
