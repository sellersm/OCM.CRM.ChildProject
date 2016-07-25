Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common

Public NotInheritable Class CommunityThreeHelper
    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property highestEducationOtherGuid As String = ""


    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHER).ValueChanged, AddressOf ChildCareWhenParentAbsentOther_ValueChanged
    End Sub

	<CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")>
	<CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId:="Vars")>
	Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
    End Sub

	Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_ChildCareWhenParentAbsentOther()
        
    End Sub

    Private Sub ChildCareWhenParentAbsentOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ChildCareWhenParentAbsentOther()
    End Sub

    Private Sub Toggle_ChildCareWhenParentAbsentOther()
        If model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    ' ** FIX model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPERATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.CHILDCAREWHENPARENTABSENTOTHERDESC).Required = True
            End Select
        End If
    End Sub


    
End Class

