Public Class frmSettings
    Private mGuillocheObj As Guilloche

    Public Property GuillocheObj() As Guilloche
        Get
            Return mGuillocheObj
        End Get
        Set(value As Guilloche)
            mGuillocheObj = value

            cbColor1.Color = mGuillocheObj.Color1
            cbColor2.Color = mGuillocheObj.Color2
            cbBackColor.Color = mGuillocheObj.BackgroundColor

            SetupEventHandlers()
        End Set
    End Property

    Private Sub SetupEventHandlers()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TrackBar Then
                ctrl.DataBindings.Add("Value", mGuillocheObj, ctrl.Name.Remove(0, 2), True, DataSourceUpdateMode.OnPropertyChanged)
            End If
        Next
        ' For some reason this doesn't work correctly :(
        ' I guess I have to do something on the ColorButton class to notify the color change...
        'cbColor1.DataBindings.Add("Color", mGuillocheObj, "Color1", True, DataSourceUpdateMode.OnPropertyChanged)
        'cbColor2.DataBindings.Add("Color", mGuillocheObj, "Color2", True, DataSourceUpdateMode.OnPropertyChanged)
        'cbBackColor.DataBindings.Add("Color", mGuillocheObj, "BackgroundColor", True, DataSourceUpdateMode.OnPropertyChanged)

        AddHandler cbColor1.ColorChanged, AddressOf ColorsChanged
        AddHandler cbColor2.ColorChanged, AddressOf ColorsChanged
        AddHandler cbBackColor.ColorChanged, AddressOf ColorsChanged
    End Sub

    Private Sub ColorsChanged()
        mGuillocheObj.Color1 = cbColor1.Color.Color
        mGuillocheObj.Color2 = cbColor2.Color.Color
        mGuillocheObj.BackgroundColor = cbBackColor.Color.Color
    End Sub
End Class