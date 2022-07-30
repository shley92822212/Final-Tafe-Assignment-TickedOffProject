Imports TickedOffProject.tickedoffDataSetTableAdapters

Public Class StatisticsDAL
    Dim tickedOffDataSet As New tickedoffDataSet()
    Dim stayTableAdapter As New tickedoffDataSetTableAdapters.stayTableAdapter()
    Dim speciesTableAdapter As New tickedoffDataSetTableAdapters.speciesTableAdapter()
    ' Dim stayTableAdapter As stayTableAdapter
    Dim result As Double = 0
    Dim species() As String
    Public Function calculateTotalStays(maxAvgMinSpecies As String) As Double
        Try
            If maxAvgMinSpecies = "max" Then
                'Sets result to the maximum stay length from the stays database
                result = stayTableAdapter.FillByMaxStay()
            ElseIf maxAvgMinSpecies = "avg" Then
                'Sets result to the avgerage stay length from the stays database
                result = stayTableAdapter.FillByAVGStay()
            ElseIf maxAvgMinSpecies = "minimum" Then
                'Sets result to the mix stay length from the stays database
                result = stayTableAdapter.FillByMINStay()
            Else
                'Sets result to the number of stays had by spacefic species
                result = stayTableAdapter.FillCountStayBySpecies(maxAvgMinSpecies)
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Form1.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try
        Return result
    End Function
    Public Function calculateTotalCosts(maxAvgMinSpecies As String) As Double

        Try
            If maxAvgMinSpecies = "max" Then
                'Sets result to the maximum cost of a stay
                result = stayTableAdapter.FillByMAXcost()
            ElseIf maxAvgMinSpecies = "avg" Then
                'Sets result to the average cost of a stay
                result = stayTableAdapter.FillByAVGcost()
            ElseIf maxAvgMinSpecies = "min" Then
                'Sets result to the miximum cost of a stay
                result = stayTableAdapter.FillByMINcost()
            Else
                'Sets result to the total cost of stays had by spacefic species
                result = stayTableAdapter.FillSUMBySpecies(maxAvgMinSpecies)
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Form1.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try
        Return result
    End Function

    Public Function cmbData() As Array
        Dim datatable As New tickedoffDataSet.speciesDataTable
        Dim count = -1
        Dim species() As String
        Try
            'Fill the datatable with information from the species datatable
            speciesTableAdapter.Fill(datatable)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Form1.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try

        'Fills the species array with the descripitions from the species table
        For Each item In datatable
            count = count + 1
            ReDim Preserve species(count)
            species(count) = item.description.ToString
        Next
        Return species
    End Function
End Class
