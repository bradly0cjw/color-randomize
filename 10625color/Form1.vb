Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.BackColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.BackColor = Color.Lime
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.BackColor = Color.Cyan
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label2.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label3.Text = HScrollBar2.Value
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label4.Text = HScrollBar3.Value
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a, b, c As Integer
        a = (Int(255) * Rnd() + 0)
        b = (Int(255) * Rnd() + 0)
        c = (Int(255) * Rnd() + 0)
        Label1.BackColor = Color.FromArgb(a, b, c)
        Label2.Text = a
        Label3.Text = b
        Label4.Text = c
        HScrollBar1.Value = a
        HScrollBar2.Value = b
        HScrollBar3.Value = c
        Label1.ForeColor = Color.FromArgb(255 - a, 255 - b, 255 - c)
    End Sub
End Class
