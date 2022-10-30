Public NotInheritable Class AboutBox1

    Dim myTime As Integer

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AdvancedBetCalc.Show()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '
        TextTime.Text = myTime + 1
        If TextTime.Text = 30 Then Call AdvancedBetCalc.Sistemi()
        myTime = TextTime.Text
        If TextTime.Text = 35 Then Me.Hide()
        If TextTime.Text = 35 Then Timer1.Enabled = False
        If TextTime.Text = 35 Then TextTime.Text = 0

    End Sub
End Class
