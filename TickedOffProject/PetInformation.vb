Imports System.ComponentModel

Public Class PetInformation
    Dim ascDes As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Sets the colours for various parts of the petDataGridView 
        petDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        petDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        petDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        petDataGridView.EnableHeadersVisualStyles = False
        petDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))

        Try
            'Fills the petDataGridVeiw with data from the pet database
            petDataGridView.DataSource = PetTableAdapter1.GetDataByWithCusName()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Form1.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error has occurred. " & ex.Message)
        End Try

    End Sub
    Private Sub btnSavePetData_Click(sender As Object, e As EventArgs) Handles btnSavePetData.Click
        Dim result = MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo)
        If result.Yes Then
            Try
                'Saves all changes in the datagrid veiw to the database
                PetTableAdapter1.Update(petDataGridView.DataSource)
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
                Form1.Close()
            Catch ex As Exception

                MsgBox("An error has occurred. " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnCancelPetData_Click(sender As Object, e As EventArgs) Handles btnCancelPetData.Click
        Dim result = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo)
        If result.Yes Then

            Try
                'Reloads the database to the dataGridVeiw removing any changes
                petDataGridView.DataSource = PetTableAdapter1.GetDataByWithCusName()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
                Form1.Close()
            Catch ex As Exception

                MsgBox("An error has occurred. " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAddPetData_Click(sender As Object, e As EventArgs) Handles btnAddPetData.Click
        AddPet.Show()
    End Sub

    Private Sub btnDeletePet_Click(sender As Object, e As EventArgs) Handles btnDeletePet.Click

        Dim result = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If result.Yes Then
            Dim deleted As Boolean = False
            Dim count As Integer = -1

            For Each row As DataGridViewRow In petDataGridView.SelectedRows
                Try
                    'Deletes the selected pet's information form the database including its Stays and Bookings information
                    StayTableAdapter1.DeleteByPetID(row.Cells("petID").Value)
                    BookingTableAdapter1.DeleteBypetID(row.Cells("petID").Value)
                    PetTableAdapter1.DeletePetByID(row.Cells("petID").Value)
                    deleted = True
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
                    Form1.Close()
                Catch ex As Exception

                    MsgBox("An error has occurred. " & ex.Message)
                End Try

            Next
            If deleted = False Then
                MsgBox("Please select a pet to delete")
            Else

                Try
                    'Updates the dataGridVeiw to include changes
                    petDataGridView.DataSource = PetTableAdapter1.GetDataByWithCusName()
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
                    Form1.Close()
                Catch ex As Exception

                    MsgBox("An error has occurred. " & ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            'Reloads the database to the dataGridVeiw removing any changes made in the datagridveiw and dispalys any changes made to the database
            petDataGridView.DataSource = PetTableAdapter1.GetDataByWithCusName()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("A connection error has occurred. Please contact an Admin. " & ex.ToString)
            Form1.Close()
        Catch ex As Exception

            MsgBox("An error has occurred. " & ex.Message)
        End Try


    End Sub

    Private Sub btnAcsDes_Click(sender As Object, e As EventArgs) Handles btnAcsDes.Click
        'Changes what is displayed on the AcsDes button
        If ascDes = True Then
            ascDes = False
            btnAcsDes.Text = "Descending"
        Else
            ascDes = True
            btnAcsDes.Text = "Ascending"
        End If
        'Checks if a collumn to sort by has been selected
        If cmbSort.SelectedIndex <> -1 Then
            cmbSort_SelectedIndexChanged()
        End If

    End Sub

    Private Sub cmbSort_SelectedIndexChanged() Handles cmbSort.SelectedIndexChanged

        If ascDes = True Then
            'Sets the direction of the selected column to sort ascending
            petDataGridView.Sort(petDataGridView.Columns(cmbSort.SelectedIndex), ListSortDirection.Ascending)
        Else
            'Sets the direction of the selected column to sort descending
            petDataGridView.Sort(petDataGridView.Columns(cmbSort.SelectedIndex), ListSortDirection.Descending)
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