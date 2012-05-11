Public Class ChildProjectQuotaViewFormUIModel

    Private Sub ChildProjectQuotaViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myQuotaHelper As New QuotaHelper(Me, MoM.Common.CRMHelper.FormMode.View)
        myQuotaHelper.InitializeCodeTableVars()
        myQuotaHelper.InitializeUIDisplay()
    End Sub

End Class