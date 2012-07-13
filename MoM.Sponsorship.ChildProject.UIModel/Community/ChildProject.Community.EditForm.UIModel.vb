Imports MoM.Common
Imports Blackbaud.AppFx.UIModeling.Core
Imports Blackbaud.AppFx.XmlTypes.DataForms

Public Class ChildProjectCommunityEditFormUIModel

    Private Sub ChildProjectCommunityEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityOneHelper(Me, CRMHelper.FormMode.Edit)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()

    End Sub

End Class