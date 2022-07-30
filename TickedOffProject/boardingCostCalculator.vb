Public Class boardingCostCalculator
    Dim letter As String
    Dim petWeightCharacters As String = ".1234567890"
    Dim stayLengthCharacters As String = "1234567890"
    Private Sub boardingCostCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Fills the species combo box with the description of the species database
            Me.SpeciesTableAdapter1.FillDescription(Me.TickedoffDataSet.species)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Close()
        Catch ex As ConstraintException

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try

    End Sub

    Private Sub txtPetWeight_TextChanged(sender As Object, e As EventArgs) Handles txtPetWeight.TextChanged
        'Checks that input is a valid character and removes invalid characters
        Text = txtPetWeight.Text
        For count As Integer = 0 To txtPetWeight.Text.Length - 1
            letter = txtPetWeight.Text.Substring(count, 1)
            If petWeightCharacters.Contains(letter) = False Then
                Text = Text.Replace(letter, String.Empty)
            End If
        Next
        txtPetWeight.Text = Text
        txtPetWeight.Select(txtPetWeight.Text.Length, 0)
    End Sub

    Private Sub txtStayLength_TextChanged(sender As Object, e As EventArgs) Handles txtStayLength.TextChanged
        'Checks that input is a valid character and removes invalid characters
        Text = txtStayLength.Text
        For count As Integer = 0 To txtStayLength.Text.Length - 1
            letter = txtStayLength.Text.Substring(count, 1)
            If stayLengthCharacters.Contains(letter) = False Then
                Text = Text.Replace(letter, String.Empty)
            End If
        Next
        txtStayLength.Text = Text
        txtStayLength.Select(txtStayLength.Text.Length, 0)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Checks that no fields are empty
        If cmbSpecies.SelectedIndex <> -1 Then
            If txtPetWeight.Text <> "" Then
                If txtStayLength.Text <> "" Then
                    'Declares and calculates the surcharge, fattyFactor, base cost and discount 
                    Dim stayLength As Integer = txtStayLength.Text
                    Dim discount As Double = 0

                    Dim surchagre As Integer = SpeciesTableAdapter1.GetSurcharge(cmbSpecies.Text)
                    Dim fattyFactor As Double = txtPetWeight.Text - 12
                    Dim baseCost As Integer = stayLength * 20
                    If fattyFactor > 0.1 Then
                        fattyFactor = fattyFactor * 1.5
                    Else
                        fattyFactor = 0
                    End If
                    If stayLength > 10 Then
                        discount = 0.9
                    End If
                    'Calcualtes the total using the surcharge, fattyFactor, base cost and discount
                    lblCalculatedCost.Text = Math.Round(((surchagre * stayLength) + fattyFactor + baseCost) * 0.9, 2)
                Else
                    MsgBox("Please enter the length of the stay in the indicated text box")
                End If
            Else
                MsgBox("Please enter the weight of the pet in the indicated text box")
            End If
        Else
            MsgBox("Please select a species from the drop down box.")
        End If

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