Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports System.Data.SqlClient
Imports MoM.Common

Public NotInheritable Class ProjectInfoHelper

    Private Const maxAgeStandard As Integer = 18    'The standard maximum age for a child, which does not require an explanation

    Private Const errorTextcouldNotFindMaxGradeLevelPreSchool = "Could not find 'Pre-School' Maximum Grade Level code table value."
    Private Const errorTextcouldNotFindMaxGradeLevelKindergarten = "Could not find 'Kindergarten' Maximum Grade Level code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode     'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property maxGradeLevelPreSchoolGuid As String = ""
    Property maxGradeLevelKindergartenGuid As String = ""

    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.MAXCHILDAGE).ValueChanged, AddressOf MaxChildAge_ValueChanged
        AddHandler model.Fields(ChildProjectFields.MAXGRADELEVELCODEID).ValueChanged, AddressOf MaxGradeLevel_ValueChanged
    End Sub

    Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
            maxGradeLevelPreSchoolGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTMAXGRADELEVEL_PRESCHOOL, True, errorTextcouldNotFindMaxGradeLevelPreSchool)
            maxGradeLevelKindergartenGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTMAXGRADELEVEL_KINDERGARTEN, True, errorTextcouldNotFindMaxGradeLevelKindergarten)
        End Using
    End Sub

    Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_MaxAgeException()
        Toggle_MaxGradeLevel()
    End Sub


    Private Sub MaxChildAge_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_MaxAgeException()
    End Sub

    Private Sub Toggle_MaxAgeException()

        If model.Fields(ChildProjectFields.MAXCHILDAGE).ValueObject Is Nothing OrElse
            CInt(model.Fields(ChildProjectFields.MAXCHILDAGE).ValueObject) <> maxAgeStandard And _
            CInt(model.Fields(ChildProjectFields.MAXCHILDAGE).ValueObject) <> 0 Then
            model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Visible = True

            If helperMode = CRMHelper.FormMode.Edit Then
                model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Enabled = True
                model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Required = True
            End If

        Else
            model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Enabled = False
            model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Enabled = False
            model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Enabled = False
                    model.Fields(ChildProjectFields.MAXCHILDAGEEXCEPTIONREASON).Required = False
            End Select

        End If
    End Sub

    Private Sub MaxGradeLevel_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_MaxGradeLevel()
    End Sub

    Private Sub Toggle_MaxGradeLevel()
        If model.Fields(ChildProjectFields.MAXGRADELEVELCODEID).ValueObject Is Nothing OrElse _
            model.Fields(ChildProjectFields.MAXGRADELEVELCODEID).ValueObject.ToString <> maxGradeLevelPreSchoolGuid And _
            model.Fields(ChildProjectFields.MAXGRADELEVELCODEID).ValueObject.ToString <> maxGradeLevelKindergartenGuid Then
            model.Fields(ChildProjectFields.MAXGRADELEVEL).Visible = True
            model.Fields(ChildProjectFields.MAXGRADELEVEL).Enabled = True


        Else
            model.Fields(ChildProjectFields.MAXGRADELEVEL).Visible = False
            model.Fields(ChildProjectFields.MAXGRADELEVEL).Enabled = False
            model.Fields(ChildProjectFields.MAXGRADELEVEL).ValueObject = Nothing

        End If
    End Sub

End Class
