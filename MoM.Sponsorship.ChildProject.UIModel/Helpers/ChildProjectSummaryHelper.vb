Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common


''' <summary>
''' Used for the Child Project Add form, summary view and edit forms
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ChildProjectSummaryHelper
    Private Const errorTextCouldNotFindChildProjectTypeOther = "Could not find 'Other' Project Type code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property childProjectTypeOtherGuid As String = ""


    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueChanged, AddressOf ChildProjectTypeCodeID_ValueChanged
    End Sub

    Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
            childProjectTypeOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTTYPE_OTHER, True, errorTextCouldNotFindChildProjectTypeOther)
        End Using
    End Sub

    Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_ChildProjectTypeOther()
    End Sub

    Private Sub ChildProjectTypeCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ChildProjectTypeOther()
    End Sub

    Private Sub Toggle_ChildProjectTypeOther()
        If model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueObject Is Nothing OrElse
            model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueObject.ToString <> childProjectTypeOtherGuid Then
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Visible = False
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit, CRMHelper.FormMode.Add
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Enabled = False
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Visible = True

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit, CRMHelper.FormMode.Add
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Enabled = True
                    model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Required = True
            End Select
        End If
    End Sub
End Class
