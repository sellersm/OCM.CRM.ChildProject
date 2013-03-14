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
    Private Const errorTextCouldNotFindChildProjectStatusCodeClosed = "Could not find 'Closed' Project Status code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property childProjectTypeOtherGuid As String = ""
    Property childProjectStatusCodeClosedGuid As String = ""


    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueChanged, AddressOf ChildProjectTypeCodeID_ValueChanged
        If Me.helperMode <> CRMHelper.FormMode.View Then
            AddHandler model.Fields(ChildProjectFields.CHILDPROJECTSTATUSCODEID).ValueChanged, AddressOf ChildProjectStatusCodeID_ValueChanged
        End If
    End Sub

    Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
            childProjectTypeOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTTYPE_OTHER, True, errorTextCouldNotFindChildProjectTypeOther)
            childProjectStatusCodeClosedGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTSTATUS_CLOSED, True, errorTextCouldNotFindChildProjectStatusCodeClosed)
        End Using
    End Sub

    Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_ChildProjectTypeOther()
        Toggle_ChildProjectClosureDate()

    End Sub

    Private Sub ChildProjectTypeCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ChildProjectTypeOther()
    End Sub

    Private Sub ChildProjectStatusCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ChildProjectClosureDate()
    End Sub

    Private Sub Toggle_ChildProjectClosureDate()
        ' View form doesn't change based on the Project Status
        If Me.helperMode <> CRMHelper.FormMode.View Then

            If model.Fields(ChildProjectFields.CHILDPROJECTSTATUSCODEID).ValueObject Is Nothing OrElse
                model.Fields(ChildProjectFields.CHILDPROJECTSTATUSCODEID).ValueObject.ToString <> childProjectStatusCodeClosedGuid Then

                'model.Fields(ChildProjectFields.CLOSUREDATE).Visible = False
                model.Fields(ChildProjectFields.CLOSUREDATE).ValueObject = Nothing

                If helperMode = CRMHelper.FormMode.Add Or helperMode = CRMHelper.FormMode.Edit Then
                        model.Fields(ChildProjectFields.CLOSUREDATE).Enabled = False
                        model.Fields(ChildProjectFields.CLOSUREDATE).Required = False
                End If

            Else
                'model.Fields(ChildProjectFields.CLOSUREDATE).Visible = True

                If helperMode = CRMHelper.FormMode.Add Or helperMode = CRMHelper.FormMode.Edit Then
                        model.Fields(ChildProjectFields.CLOSUREDATE).Enabled = True
                        model.Fields(ChildProjectFields.CLOSUREDATE).Required = True
                End If
            End If
        End If

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
