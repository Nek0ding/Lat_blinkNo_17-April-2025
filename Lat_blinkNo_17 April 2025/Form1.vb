Public Class Form1
    Private Sub cmb_no(sender As Object, e As MouseEventArgs) Handles btn_no.MouseMove
        Dim koor_horizontal = Int(Rnd() * (Me.Width - 100 - btn_no.Width))
        Dim koor_vertikal = Int(Rnd() * (Me.Height - 100 - btn_no.Height))
        btn_no.Left = koor_horizontal
        btn_no.Top = koor_vertikal
        MsgBox(koor_horizontal)
        MsgBox(koor_vertikal)
    End Sub
End Class
