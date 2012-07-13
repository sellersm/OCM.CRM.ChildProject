Imports MoM.Common
Imports Blackbaud.AppFx.UIModeling.Core

Public Class ChildProjectQuotaEditFormUIModel

    Private Sub ChildProjectQuotaEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myQuotaHelper As New QuotaHelper(Me, MoM.Common.CRMHelper.FormMode.Edit)
        myQuotaHelper.InitializeCodeTableVars()
        myQuotaHelper.InitializeUIDisplay()

    End Sub

End Class