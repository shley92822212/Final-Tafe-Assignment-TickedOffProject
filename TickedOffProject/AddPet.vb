Public Class AddPet
    Dim Text As String
    Dim letter As String
    Dim petWeightCharacters As String = "1234567890."
    Dim petNameCharacters As String = " ,'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Private Sub AddPet_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            'Adds values to the species combo box
            PetTableAdapter1.FillBySpecies(TickedoffDataSet.pet)
        Catch ex As MySql.Data.MySqlClient.MySqlException

            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)

            Form1.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has orrurred. " & ex.Message)
        End Try

        Try
            'Add values to the customerID combo box
            CustomerTableAdapter1.FillCustomerID(TickedoffDataSet.customer)
        Catch ex As MySql.Data.MySqlClient.MySqlException

            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)

            Form1.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has orrurred. " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Checks if there is input in all fields
        If txtboxPetName.Text <> "" And cmbSpecies.Text <> "" And cmbGender.Text <> "" And txtboxWeight.Text <> "" And cmbCustomer.Text <> "" Then
            'Checks that the data selected is not in the future
            If dtpDOB.Value.Date <= Today Then
                Try
                    'Adds a pet to the database
                    PetTableAdapter1.InsertPet(txtboxPetName.Text, cmbSpecies.Text, dtpDOB.Value.Date, cmbGender.Text, Convert.ToDouble(txtboxWeight.Text), cmbCustomer.Text)

                    'Reloads the database to the dataGridVeiw removing any changes made in the datagridveiw and dispalys any changes made to the database
                    PetInformation.petDataGridView.DataSource = PetTableAdapter1.GetDataByWithCusName()
                    Me.Close()

                Catch ex As Exception
                    MsgBox("An error has orrurred. " & ex.Message)
                End Try
            Else
                MsgBox("Please select a DOB that is not in the future.")
            End If
        Else
            MsgBox("Please fill in all required fields. Required fields are marked by a *")
        End If
    End Sub

    Private Sub txtboxPetName_TextChanged(sender As Object, e As EventArgs) Handles txtboxPetName.TextChanged
        Text = txtboxPetName.Text
        'Checks that input is a valid character and removes invalid characters
        For count As Integer = 0 To txtboxPetName.Text.Length - 1
            letter = txtboxPetName.Text.Substring(count, 1)
            If petNameCharacters.Contains(letter) = False Then
                Text = Text.Replace(letter, String.Empty)
            End If
        Next
        txtboxPetName.Text = Text
        txtboxPetName.Select(txtboxPetName.Text.Length, 0)

    End Sub

    Private Sub txtboxWeight_TextChanged(sender As Object, e As EventArgs) Handles txtboxWeight.TextChanged
        Text = txtboxWeight.Text
        'Checks that input is a valid character and removes invalid characters
        For count As Integer = 0 To txtboxWeight.Text.Length - 1
            letter = txtboxWeight.Text.Substring(count, 1)
            If petWeightCharacters.Contains(letter) = False Then
                Text = Text.Replace(letter, String.Empty)
            End If
        Next
        txtboxWeight.Text = Text
        txtboxWeight.Select(txtboxWeight.Text.Length, 0)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
End Class