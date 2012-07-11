Imports Blackbaud.AppFx.Browser.Shell
Imports MoM.Common
Imports Blackbaud.AppFx.UIModeling.Core
Imports Blackbaud.AppFx.XmlTypes.DataForms

Public Class ChildProjectCommunityEditFormUIModel

    Private Sub ChildProjectCommunityEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myCommunityHelper As New CommunityOneHelper(Me, CRMHelper.FormMode.Edit)
        myCommunityHelper.InitializeCodeTableVars()
        myCommunityHelper.InitializeUIDisplay()

        Dim g As New Guid("8adbd8d5-5657-4349-8d46-80aa7b1853ba") '5c128565-4494-4510-aa82-a9b8608bb613") 'F95B8041-B78B-4337-A04E-540D31DCC146")

        Me.Fields(ChildProjectFields.COMMUNITYDESCRIPTION).ValueObject = g.ToString + " test 3"

        'Dim b As Boolean = ShowAddDataForm(g)

    End Sub

    Private Sub ChildProjectCommunityEditFormUIModel_Saved(sender As Object, e As Blackbaud.AppFx.UIModeling.Core.SavedEventArgs) Handles Me.Saved
        CRMHelper.ShowMessage("Saved", UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)

    End Sub



    Private Sub ChildProjectCommunityEditFormUIModel_Saving(sender As Object, e As Blackbaud.AppFx.UIModeling.Core.SavingEventArgs) Handles Me.Saving
        CRMHelper.ShowMessage("Test", UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)

    End Sub


    Private Sub ChildProjectCommunityEditFormUIModel_Validating(sender As Object, e As Blackbaud.AppFx.UIModeling.Core.ValidatingEventArgs) Handles Me.Validating
        Dim g As New Guid("5c128565-4494-4510-aa82-a9b8608bb613") '5c128565-4494-4510-aa82-a9b8608bb613") 'F95B8041-B78B-4337-A04E-540D31DCC146")
        CRMHelper.ShowMessage("Validating - " & g.ToString, UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)


        'Dim b As Boolean

        ''Dim showpage As Blackbaud.AppFx.Browser.Shell.
        'Dim p As New Blackbaud.AppFx.Browser.ShowPopupArgs
        'Dim q As Blackbaud.AppFx.Browser.ShowPopupResult
        'Dim d As New DataFormItem()

        'p.DataFormInstanceID = g
        'p.DataFormItem = d
        ''q = Blackbaud.AppFx.Browser.Shell.ShowPopup(p)

        ''b = Blackbaud.AppFx.Browser.Shell.ShowAddDataForm(g)

        'Dim args As New Blackbaud.AppFx.Browser.ShowAddDataFormArgs(g)

        'Dim result As Blackbaud.AppFx.Browser.ShowAddDataFormResult
        'If (args.DataFormID = Guid.Empty) Then
        '    Throw New ArgumentException("You must specify a dataform instance ID.", "dataFormID")
        'End If
        'Dim args2 As New Blackbaud.AppFx.Browser.BeforeRecordAddEventArgs(args.DataFormID, args.ContextID)
        ''result = Blackbaud.AppFx.Browser.Shell.ShowWebAddDataForm(args)

    End Sub


End Class