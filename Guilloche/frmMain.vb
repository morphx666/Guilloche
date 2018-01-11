Public Class frmMain
    Private guillocheObj As Guilloche
    Private settingsDlg As frmSettings

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        guillocheObj = New Guilloche(Me)

        guillocheObj.Color1 = Color.Red
        guillocheObj.Color2 = Color.Cyan
        guillocheObj.BackgroundColor = Color.Black
        guillocheObj.Thickness = 3
        guillocheObj.Scale = 32
        guillocheObj.Steps = 800

        settingsDlg = New frmSettings()
        settingsDlg.GuillocheObj = guillocheObj
        settingsDlg.Show(Me)
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        e.Graphics.Clear(guillocheObj.BackgroundColor)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        guillocheObj.Paint(e.Graphics, New PointF(Me.DisplayRectangle.Width / 2, Me.DisplayRectangle.Height / 2))
    End Sub
End Class
