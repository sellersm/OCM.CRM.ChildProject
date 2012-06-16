Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common

''' <summary>
''' Used for the Child Project Add form
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ChildProjectHelper
    Private Const errorTextcouldNotFindChildProjectTypeOther = "Could not find 'Other' Child Project Type code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property projectTypeOtherGuid As String = ""

    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueChanged, AddressOf ProjectTypeCode_ValueChanged
    End Sub

    ''' <summary>
    ''' 'Initialize Code Table IDs 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeCodeTableVars()
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
            projectTypeOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTTYPE_OTHER, True, errorTextcouldNotFindChildProjectTypeOther)
        End Using
    End Sub

    ''' <summary>
    ''' Initialize the UI objects based on the loaded form values
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeUIDisplay()
        Toggle_ProjectTypeOther()
    End Sub

    Private Sub ProjectTypeCode_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ProjectTypeOther()
    End Sub

    ''' <summary>
    ''' Toggle the "Project Type Other" field based on the code table
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Toggle_ProjectTypeOther()
        If model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueObject Is Nothing OrElse
                model.Fields(ChildProjectFields.CHILDPROJECTTYPECODEID).ValueObject.ToString <> projectTypeOtherGuid Then
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Visible = False
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Enabled = False
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Required = False
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).ValueObject = Nothing
        Else
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Visible = True
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Enabled = True
            model.Fields(ChildProjectFields.CHILDPROJECTTYPEOTHER).Required = True
        End If
    End Sub



End Class

