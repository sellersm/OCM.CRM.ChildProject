Imports MoM.Common

Public Class ChildProjectExtensionAddFormUIModel

    Private Sub ChildProjectExtensionAddFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myChildProjectSummaryHelper As New ChildProjectSummaryHelper(Me, CRMHelper.FormMode.Add)
        myChildProjectSummaryHelper.InitializeCodeTableVars()
        myChildProjectSummaryHelper.InitializeUIDisplay()
    End Sub


End Class
