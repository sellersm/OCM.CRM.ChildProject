Imports MoM.Common

Public Class ChildProjectCommunityViewFormUIModel

    Private Sub ChildProjectCommunityViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityOneHelper(Me, CRMHelper.FormMode.View)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()
    End Sub

End Class