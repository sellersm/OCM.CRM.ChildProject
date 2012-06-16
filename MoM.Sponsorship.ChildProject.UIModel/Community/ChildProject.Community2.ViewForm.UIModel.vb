Imports MoM.Common

Public Class ChildProjectCommunity2ViewFormUIModel

    Private Sub ChildProjectCommunity2ViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityTwoHelper(Me, CRMHelper.FormMode.View)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()
    End Sub

End Class