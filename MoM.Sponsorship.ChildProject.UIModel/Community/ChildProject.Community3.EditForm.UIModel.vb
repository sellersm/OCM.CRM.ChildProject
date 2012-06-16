Imports MoM.Common

Public Class ChildProjectCommunity3EditFormUIModel

    Private Sub ChildProjectCommunity3EditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityThreeHelper(Me, CRMHelper.FormMode.Edit)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()
    End Sub

End Class