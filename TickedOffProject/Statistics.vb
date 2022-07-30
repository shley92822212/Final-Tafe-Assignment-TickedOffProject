Public Class Statistics
    Dim DAL As New StatisticsDAL
    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls DAL.cmbData to fill with combo box 
        For Each item In DAL.cmbData()
            cmbSpecies.Items.Add(item)
        Next
        'Fill the apropriate lables in the form with the apropriate values using the StatisticsDAL
        lblLongestStayVar.Text = DAL.calculateTotalStays("max") & " Days"
        lblShortestStayVar.Text = DAL.calculateTotalStays("min") & " Days"
        lblAverageStayVar.Text = Math.Round(DAL.calculateTotalStays("avg"), 2) & " Days"
        lblHighestCost.Text = "$" & Math.Round(DAL.calculateTotalCosts("max"), 2)
        lblLowestCost.Text = "$" & Math.Round(DAL.calculateTotalCosts("min"), 2)
        lblAverageCost.Text = "$" & Math.Round(DAL.calculateTotalCosts("avg"), 2)
        btnCalculate_Click()

    End Sub

    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        'Fills the apropriate lables on the form with information about stays based off selected species by using the StatisticsDALa
        lblTotalStays.Text = "Total number of stays " & DAL.calculateTotalStays(cmbSpecies.Text)
        lblTotalPaid.Text = "$" & Math.Round(DAL.calculateTotalCosts(cmbSpecies.Text), 2) & " Total amount paid"
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class