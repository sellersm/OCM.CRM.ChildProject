Imports MoM.Common

Public Class ChildProjectExtensionSummaryViewFormUIModel

    Private Sub ChildProjectExtensionSummaryViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myChildProjectSummaryHelper As New ChildProjectSummaryHelper(Me, CRMHelper.FormMode.View)
        myChildProjectSummaryHelper.InitializeCodeTableVars()
        myChildProjectSummaryHelper.InitializeUIDisplay()
    End Sub

End Class