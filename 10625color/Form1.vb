Public Class Form1
    Dim ultra, button As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.Black
        Dim a, b, c As Integer
        a = 0
        b = 0
        c = 0
        Label1.BackColor = Color.FromArgb(a, b, c)
        Label2.Text = a
        Label3.Text = b
        Label4.Text = c
        HScrollBar1.Value = a
        HScrollBar2.Value = b
        HScrollBar3.Value = c
        Label1.ForeColor = Color.FromArgb(255 - a, 255 - b, 255 - c)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.White
        Dim a, b, c As Integer
        a = 255
        b = 255
        c = 255
        Label1.BackColor = Color.FromArgb(a, b, c)
        Label2.Text = a
        Label3.Text = b
        Label4.Text = c
        HScrollBar1.Value = a
        HScrollBar2.Value = b
        HScrollBar3.Value = c
        Label1.ForeColor = Color.FromArgb(255 - a, 255 - b, 255 - c)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.Lime
        Dim a, b, c As Integer
        a = 0
        b = 255
        c = 0
        Label1.BackColor = Color.FromArgb(a, b, c)
        Label2.Text = a
        Label3.Text = b
        Label4.Text = c
        HScrollBar1.Value = a
        HScrollBar2.Value = b
        HScrollBar3.Value = c
        Label1.ForeColor = Color.FromArgb(255 - a, 255 - b, 255 - c)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.Cyan
        Dim a, b, c As Integer
        a = 0
        b = 255
        c = 255
        Label1.BackColor = Color.FromArgb(a, b, c)
        Label2.Text = a
        Label3.Text = b
        Label4.Text = c
        HScrollBar1.Value = a
        HScrollBar2.Value = b
        HScrollBar3.Value = c
        Label1.ForeColor = Color.FromArgb(255 - a, 255 - b, 255 - c)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label2.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label3.Text = HScrollBar2.Value
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 - HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label4.Text = HScrollBar3.Value
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        ultra = 0
        button = 1
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ans, msg, ult, ans3 As Single
        msg = MsgBox("選擇更改項目 是:Random 否:Ultra Random 取消:Ultra Button", 3, "設定")
        If msg = 6 Then
            On Error GoTo errorhandler
            ans = InputBox("Random變色速度", "選擇變色速度(單位:毫秒 0為關閉)", 1000)
            If ans = 0 Then
                Timer1.Enabled = False
            Else
                Timer1.Enabled = True
                Timer1.Interval = ans
            End If

            Exit Sub
errorhandler:
            MsgBox("輸入錯誤", 0, "random")
            Timer1.Interval = 1000
            Timer1.Enabled = False
            Resume Next
        ElseIf msg = 7 Then
            On Error GoTo errorhandler2
            ult = InputBox("Text變色速度", "選擇變色速度(單位:毫秒 輸入需>0)", 200)
            If ult = 0 Then
                MsgBox("輸入錯誤", 0, "Ultra Random")
                Timer2.Interval = 200
            Else
                Timer2.Interval = ult
            End If

            Exit Sub
errorhandler2:
            MsgBox("輸入錯誤", 0, "Ultra Random")
            Timer2.Interval = 200
            Resume Next
        Else
            On Error GoTo errorhandler3
            ans3 = InputBox("Ultra變色速度", "選擇變色速度(單位:毫秒 0為關閉)", 100)
            If ans3 = 0 Then
                MsgBox("輸入錯誤", 0, "Ultra Button")
                Timer3.Interval = 100
            Else
                Timer3.Interval = ans3
            End If

            Exit Sub
errorhandler3:
            MsgBox("輸入錯誤", 0, "Ultra Button")
            Timer3.Interval = 100
            Resume Next
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ultra = 0
        button = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim h, f, g As Integer
        h = (Int(255) * Rnd() + 0)
        f = (Int(255) * Rnd() + 0)
        g = (Int(255) * Rnd() + 0)
        Button6.BackColor = Color.FromArgb(h, f, g)
        Button6.ForeColor = Color.FromArgb(255 - h, 255 - f, 255 - g)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ultra = 0 Then
            Timer2.Enabled = True
            ultra = 1
        Else
            Timer2.Enabled = False
            ultra = 0
        End If
        If button = 0 Then
            Timer3.Enabled = True
            button = 1
        Else
            Timer3.Enabled = False
            button = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim aa, bb, cc As Integer
        aa = (Int(255) * Rnd() + 0)
        bb = (Int(255) * Rnd() + 0)
        cc = (Int(255) * Rnd() + 0)
        Button8.BackColor = Color.FromArgb(aa, bb, cc)
        Button8.ForeColor = Color.FromArgb(255 - aa, 255 - bb, 255 - cc)
    End Sub

End Class
