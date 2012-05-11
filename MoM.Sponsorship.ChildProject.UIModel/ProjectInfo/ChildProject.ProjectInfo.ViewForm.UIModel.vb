Public Class ChildProjectProjectInfoViewFormUIModel

    Private Sub ChildProjectProjectInfoViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myProjectInfoHelper As New ProjectInfoHelper(Me, Common.CRMHelper.FormMode.View)
        myProjectInfoHelper.InitializeCodeTableVars()
        myProjectInfoHelper.InitializeUIDisplay()
    End Sub

End Class