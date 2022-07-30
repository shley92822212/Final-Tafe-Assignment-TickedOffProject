Imports System.IO
Public Class Form1
    Private Sub btnPetInfo_Click(sender As Object, e As EventArgs) Handles btnPetInfo.Click
        PetInformation.Show()
    End Sub

    Private Sub btnCostCalculator_Click(sender As Object, e As EventArgs) Handles btnCostCalculator.Click
        boardingCostCalculator.Show()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Statistics.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim sw As StreamWriter
        'Finds the path to the computers desktop
        Dim desktopPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Dim fileName As String = desktopPath & "\TickedOffPet.csv"
        Dim dataTable As DataTable
        Dim PetTableAdapter1 As tickedoffDataSetTableAdapters.petTableAdapter
        PetTableAdapter1 = New tickedoffDataSetTableAdapters.petTableAdapter()
        Try
            'Fills the dataTable variable with the petData + customer name
            dataTable = PetTableAdapter1.GetDataByWithCusName()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try
        'Declares an array with the size of the datatable
        Dim PetArray(dataTable.Rows.Count - 1, dataTable.Columns.Count - 1) As String
        'Fills the array with the values from the datatable
        For count = 0 To dataTable.Rows.Count - 1
            For count2 = 0 To dataTable.Columns.Count - 1
                Try
                    PetArray(count, count2) = dataTable.Rows(count)(count2)
                Catch ex As InvalidCastException
                    PetArray(count, count2) = "Null"
                End Try
            Next
        Next
        'Creates and writes the values from the array into a CSV file
        sw = File.CreateText(fileName)
        For count = 0 To dataTable.Rows.Count - 1
            For count2 = 0 To dataTable.Columns.Count - 1
                sw.WriteLine(PetArray(count, count2) & ",")
            Next
        Next
        sw.Close()
        MsgBox("The pet data has been saved here: " & desktopPath & "\TickedOffPet.csv")
    End Sub

    Private Sub btnPromo_Click(sender As Object, e As EventArgs) Handles btnPromo.Click
        MsgBox("Insert video here!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Calls the tooStripControls class with the value "exit" 
        Dim toolStripControls = New toolStripControls()
        toolStripControls.exitCompanyApplication("exit")
    End Sub

    Private Sub AboutThisCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisCompanyToolStripMenuItem.Click
        'Calls the tooStripControls class with the value "company" 
        Dim toolStripControls = New toolStripControls()
        toolStripControls.exitCompanyApplication("company")
    End Sub

    Private Sub AboutThisApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisApplicationToolStripMenuItem.Click
        'Calls the tooStripControls class with the value "application" 
        Dim toolStripControls = New toolStripControls()
        toolStripControls.exitCompanyApplication("application")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
