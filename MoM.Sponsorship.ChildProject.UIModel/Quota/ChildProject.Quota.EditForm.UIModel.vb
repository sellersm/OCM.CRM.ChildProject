Imports Blackbaud.AppFx.Browser.Shell
Imports MoM.Common
Imports Blackbaud.AppFx.UIModeling.Core

Public Class ChildProjectQuotaEditFormUIModel
    Private isSaved = False


    Private Sub Test_Saved(ByVal sender As Object, e As Blackbaud.AppFx.UIModeling.Core.SavedEventArgs) Handles Me.Saved
        isSaved = True
        CRMHelper.ShowMessage("Test", UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)
        'Dim prompt As New UIPrompt

        'prompt.Text = "HERE"
        'Me.Prompts.Add(prompt)


    End Sub


    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        ''This was added here so that the batch entry would display after the gift batch add save was completely done.
        ''The 'SaveComplete' event was not sufficient to accomplish this.

        'CRMHelper.ShowMessage("Test", UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)

        If (isSaved) Then
            'Dim s As Blackbaud.AppFx.Browser.ShellPage
            Dim g As New Guid("F95B8041-B78B-4337-A04E-540D31DCC146")

            ShowAddDataForm(g)

        End If

        'If disposing AndAlso components IsNot Nothing Then
        '    components.Dispose()
        'End If
        MyBase.Dispose(disposing)
    End Sub


    Private Sub ChildProjectQuotaEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded

        Dim prompt As New UIPrompt

        prompt.Text = "HERE"
        Me.Prompts.Add(prompt)
        Me.RootUIModel.Prompts.Add(prompt)


        Dim myQuotaHelper As New QuotaHelper(Me, MoM.Common.CRMHelper.FormMode.Edit)
        myQuotaHelper.InitializeCodeTableVars()
        myQuotaHelper.InitializeUIDisplay()

        Dim g As New Guid("8adbd8d5-5657-4349-8d46-80aa7b1853ba") '5c128565-4494-4510-aa82-a9b8608bb613") 'F95B8041-B78B-4337-A04E-540D31DCC146")

        'ShowAddDataForm(g)

        

    End Sub


    Private Sub ChildProjectQuotaEditFormUIModel_Saving(sender As Object, e As Blackbaud.AppFx.UIModeling.Core.SavingEventArgs) Handles Me.Saving
        CRMHelper.ShowMessage("Test", UIPromptButtonStyle.Ok, UIPromptImageStyle.Exclamation, Me)

    End Sub
End Class