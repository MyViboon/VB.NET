Imports System.Data.SqlClient
Module Functiondata
    Function executesql(sql As String) As DataTable
        Dim strcon As String = "Data Source=DESKTOP-N2OM162\SQLEXPRESS;Initial Catalog=Minimart;Integrated Security=True"
        Try
            Dim dtadapter As SqlDataAdapter
            Dim objconn As New SqlConnection
            Dim dt As New DataTable
            objconn.ConnectionString = strcon
            objconn.Open()
            dtadapter = New SqlDataAdapter(sql, objconn)
            dtadapter.Fill(dt)
            objconn.Close()
            objconn = Nothing

            Return dt
        Catch ex As Exception

        End Try
    End Function

End Module
