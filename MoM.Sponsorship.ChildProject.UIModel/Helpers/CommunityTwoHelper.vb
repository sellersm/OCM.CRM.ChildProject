Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common

Public NotInheritable Class CommunityTwoHelper
    Private Const errorTextCouldNotFindHighestEducationOther = "Could not find 'Other' Highest Education code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property highestEducationOtherGuid As String = ""
    

    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLECODEID).ValueChanged, AddressOf HighestEducationAvailableCodeID_ValueChanged
        AddHandler model.Fields(ChildProjectFields.EDUCATIONTYPEOTHER).ValueChanged, AddressOf EducationAvailableOther_ValueChanged
        AddHandler model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHER).ValueChanged, AddressOf PrimaryOccupationOther_ValueChanged
        AddHandler model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHER).ValueChanged, AddressOf FamilyStructureOther_ValueChanged
        AddHandler model.Fields(ChildProjectFields.SOCIALISSUESOTHER).ValueChanged, AddressOf SocialIssuesOther_ValueChanged
    End Sub

	<CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId:="Vars")>
	Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
			highestEducationOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTHIGHESTEDUCATION_OTHER, True, errorTextCouldNotFindHighestEducationOther)
		End Using
	End Sub

	Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_HighestEducationOther()
        Toggle_EducationTypeOther()
        Toggle_PrimaryOccupationOther()
        Toggle_FamilyStructureOther()
        Toggle_SocialIssuesOther()
    End Sub

    Private Sub HighestEducationAvailableCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_HighestEducationOther()
    End Sub

    Private Sub Toggle_HighestEducationOther()
        If model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLECODEID).ValueObject Is Nothing OrElse
            model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLECODEID).ValueObject.ToString <> highestEducationOtherGuid Then
            model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Visible = False
            model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.RELIGIONOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Enabled = False
                    model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Visible = True

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.RELIGIONOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Enabled = True
                    model.Fields(ChildProjectFields.HIGHESTEDUCATIONAVAILABLEOTHER).Required = True
            End Select
        End If
    End Sub

    Private Sub EducationAvailableOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_EducationTypeOther()
    End Sub

    Private Sub Toggle_EducationTypeOther()
        If model.Fields(ChildProjectFields.EDUCATIONTYPEOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.EDUCATIONTYPEOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.EDUCATIONTYPEOTHERDESC).Required = True
            End Select
        End If
    End Sub


    Private Sub PrimaryOccupationOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_PrimaryOccupationOther()
    End Sub

    Private Sub Toggle_PrimaryOccupationOther()
        If model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.PRIMARYOCCUPATIONOTHERDESC).Required = True
            End Select
        End If
    End Sub

    Private Sub FamilyStructureOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_FamilyStructureOther()
    End Sub

    Private Sub Toggle_FamilyStructureOther()
        If model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHER).ValueObject) = False Then

            model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.FAMILYSTRUCTUREOTHERDESC).Required = True
            End Select
        End If
    End Sub

    Private Sub SocialIssuesOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_SocialIssuesOther()
    End Sub

    Private Sub Toggle_SocialIssuesOther()
        If model.Fields(ChildProjectFields.SOCIALISSUESOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.SOCIALISSUESOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.SOCIALISSUESOTHERDESC).Required = True
            End Select
        End If
    End Sub
End Class

