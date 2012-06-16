Imports MoM.Common

Public Class ChildProjectCommunity2EditFormUIModel

    Private Sub ChildProjectCommunity2EditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityTwoHelper(Me, CRMHelper.FormMode.Edit)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()
    End Sub

End Class