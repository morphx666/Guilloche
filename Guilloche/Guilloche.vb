' http://www.subblue.com/blog/2008/10/10/guilloche
' http://mathworld.wolfram.com/Hypotrochoid.html

Public Class Guilloche
    Private Const deg2rad As Single = Math.PI / 180

    Private mSteps As Integer = 1000
    Private mMajorRipple As Single = 50
    Private mMinorRipple As Single = 0.25
    Private mRadiusTypeEffect As Single = 25
    Private mAngleMultiplier As Single = 1
    Private mAmplitude As Single = 2.5

    Private mSectionLength As Integer = 10

    Private mOpacity As Single = 0.2
    Private mColor1 As Color = Color.White
    Private mColor2 As Color = Color.White
    Private mBackColor As Color = Color.Black
    Private mThickness As Single = 1

    Private mColorCycle As Integer = 1
    Private colorPalette() As Color

    Private mParentForm As Form

    Public Sub New(parentForm As Form)
        mParentForm = parentForm
        SetColorPalette()
    End Sub

    Public Property Steps() As Integer
        Get
            Return mSteps
        End Get
        Set(value As Integer)
            If mSteps <> value Then
                mSteps = value
                SetColorPalette()
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Scale() As Single
        Get
            Return mAmplitude * 10
        End Get
        Set(value As Single)
            value /= 10
            If mAmplitude <> value Then
                mAmplitude = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Multiplier() As Single
        Get
            Return mAngleMultiplier * 100
        End Get
        Set(ByVal value As Single)
            value /= 100
            If mAngleMultiplier <> value Then
                mAngleMultiplier = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property MajorRipple() As Single
        Get
            Return mMajorRipple
        End Get
        Set(ByVal value As Single)
            If mMajorRipple <> value Then
                mMajorRipple = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property MinorRipple() As Single
        Get
            Return mMinorRipple * 1000
        End Get
        Set(value As Single)
            value /= 100
            If mMinorRipple <> value Then
                mMinorRipple = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Radius() As Single
        Get
            Return mRadiusTypeEffect
        End Get
        Set(value As Single)
            If mRadiusTypeEffect <> value Then
                mRadiusTypeEffect = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Opacity() As Single
        Get
            Return mOpacity * 1000
        End Get
        Set(value As Single)
            value /= 1000
            If mOpacity <> value Then
                mOpacity = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Thickness() As Single
        Get
            Return mThickness
        End Get
        Set(value As Single)
            If mThickness <> value Then
                mThickness = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property BackgroundColor() As Color
        Get
            Return mBackColor
        End Get
        Set(ByVal value As Color)
            If mBackColor <> value Then
                mBackColor = value
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Color1() As Color
        Get
            Return mColor1
        End Get
        Set(ByVal value As Color)
            If mColor1 <> value Then
                mColor1 = value
                SetColorPalette()
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Property Color2() As Color
        Get
            Return mColor2
        End Get
        Set(ByVal value As Color)
            If mColor2 <> value Then
                mColor2 = value
                SetColorPalette()
                mParentForm.Invalidate()
            End If
        End Set
    End Property

    Public Sub Paint(g As Graphics, center As PointF)
        Dim p1 As PointF
        Dim p2 As PointF
        Dim sl As Integer = 0
        Dim theta As Double
        Dim thetaStep As Double = 2 * Math.PI / mSteps
        Dim s As Double = (mMajorRipple + mMinorRipple) / mMinorRipple
        Dim phi As Double = s * mAngleMultiplier
        Dim rR As Double = mMinorRipple + mMajorRipple
        Dim rp As Double = mMinorRipple + mRadiusTypeEffect
        Dim cpl As Integer = colorPalette.Length
        Dim opacity As Integer = mOpacity * 255
        Dim p As New Pen(Brushes.Black)

        Debug.WriteLine("Steps: " + mSteps.ToString())
        Debug.WriteLine("Multiplier: " + mAngleMultiplier.ToString())
        Debug.WriteLine("MajorRipple: " + mMajorRipple.ToString())
        Debug.WriteLine("MinorRipple: " + mMinorRipple.ToString())
        Debug.WriteLine("Radius: " + mRadiusTypeEffect.ToString())
        Debug.WriteLine("")

        g.TranslateTransform(center.X, center.Y)

        For t As Integer = 0 To mSteps
            p1 = New PointF((rR * Math.Cos(mAngleMultiplier * theta) + rp * Math.Cos(phi * theta)) * mAmplitude,
                            (rR * Math.Sin(mAngleMultiplier * theta) + rp * Math.Sin(phi * theta)) * mAmplitude)

            If sl = 0 Then
                p.Dispose()
                p = New Pen(Color.FromArgb(opacity, If(mColor1 = mColor2 OrElse cpl < 2, mColor1, colorPalette(t Mod cpl))), mThickness)

                If t <> 0 Then g.DrawLine(p, p2, p1)
            Else
                g.DrawLine(p, p2, p1)
            End If

            p2 = p1
            sl += 1
            theta += thetaStep

            If sl = mSectionLength Then sl = 0
        Next
    End Sub

    Private Sub SetColorPalette()
        colorPalette = BlendColorsArray(mColor1, mColor2, (mSteps / mSectionLength) - 1, False)
        colorPalette = colorPalette.Concat(BlendColorsArray(mColor2, mColor1, (mSteps / mSectionLength) - 1, False)).ToArray()
    End Sub

    Private Function BlendColors(c1 As Color, c2 As Color, p As Single, bc As Color) As Color
        If p >= 1 Then Return c2
        If p <= 0 Then Return c1

        Dim r As Integer = (CInt(c1.R) + c2.R - c1.R) * p
        Dim g As Integer = (CInt(c1.G) + c2.G - c1.G) * p
        Dim b As Integer = (CInt(c1.B) + c2.B - c1.B) * p
        Dim a As Integer = If(c1 = bc, c2.A, Math.Min(CInt(c1.A) + c2.A, 255))

        Return Color.FromArgb(a, r, g, b)
    End Function

    Private Function BlendColorsArray(c1 As Color, c2 As Color, n As Integer, Optional last As Boolean = True) As Color()
        Dim a As Stack(Of Color) = New Stack(Of Color)
        Dim p As Double = 1 / (n + 1)

        For i As Integer = 0 To n - 1
            a.Push(BlendColors(c1, c2, i * p, Color.White))
        Next
        If last Then a.Push(c2)

        Return a.ToArray()
    End Function
End Class
