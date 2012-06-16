Imports MoM.Common

Public Class ChildProjectCommunity3ViewFormUIModel

    Private Sub ChildProjectCommunity3ViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityThreeHelper(Me, CRMHelper.FormMode.View)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()

    End Sub

End Class