Public Class ChildProjectProjectInfoEditFormUIModel

    Private Sub ChildProjectProjectInfoEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myProjectInfoHelper As New ProjectInfoHelper(Me, Common.CRMHelper.FormMode.Edit)
        myProjectInfoHelper.InitializeCodeTableVars()
        myProjectInfoHelper.InitializeUIDisplay()
    End Sub

End Class