Public Class toolStripControls
    Public Sub exitCompanyApplication(item As String)
        If item = "exit" Then
            Form1.Close()
        ElseIf item = "application" Then
            lblInfo.Text =
"This is a custom-made application designed specifically to meet the needs of
the Ticked Off Vet clinic. It includes features/functions that are regularly
accessed by staff members, and serves to make their everyday tasks much
easier to fulfil.

Version 2.0 will be out soon... but we won't faucet."
            Me.Show()
        Else
            lblInfo.Text =
"Ticked Off is a long-established vet practice that has been operating in the
Hornsby area of Sydney for many years. Keith Cabrade, son-in-law of
long-term businessman Victor Grahams, owns the magical practice.

Ticked Off has recently received a series of accolades from the industry
for their ingenious invention of the easy-tick-disposal product,
the Pop Bag. This incredibly clever invention has catapulted
Ticked Off to veterinary fame in a way that no bag has done before!

Ticked Off is 100% committed to good service, so hopefully you won't
be ticked off... get it?! LOLs. Just a little taste of our witty,
vet-flavoured humour."
            Me.Show()
        End If

    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub toolStripControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class