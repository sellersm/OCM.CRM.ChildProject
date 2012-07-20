Public Class ChildProjectUIModelVersionViewFormUIModel

    Private Sub ChildProjectUIModelVersionViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Me.Fields("VERSION").ValueObject = "Version #VersionNumber#"
    End Sub

End Class