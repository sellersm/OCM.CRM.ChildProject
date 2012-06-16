Imports MoM.Common

Public Class ChildProjectExtensionSummaryEditFormUIModel

    Private Sub ChildProjectExtensionSummaryEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myChildProjectSummaryHelper As New ChildProjectSummaryHelper(Me, CRMHelper.FormMode.Edit)
        myChildProjectSummaryHelper.InitializeCodeTableVars()
        myChildProjectSummaryHelper.InitializeUIDisplay()
    End Sub

End Class