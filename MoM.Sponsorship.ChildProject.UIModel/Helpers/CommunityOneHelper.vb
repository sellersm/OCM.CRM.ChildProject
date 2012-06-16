Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.Constituent.UIModel
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common

Public NotInheritable Class CommunityOneHelper
    Private Const errorTextCouldNotFindRelgionOther = "Could not find 'Other' Religion code table value."
    Private Const errorTextCouldNotFindTerrainOther = "Could not find 'Other' Terrain code table value."

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    ' Code Table IDs
    Property religionOtherGuid As String = ""
    Property terrainOtherGuid As String = ""


    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(ChildProjectFields.RELIGIONCODEID).ValueChanged, AddressOf ReligionCodeID_ValueChanged
        AddHandler model.Fields(ChildProjectFields.HEALTHPROBLEMOTHER).ValueChanged, AddressOf HealthProblemOther_ValueChanged
        AddHandler model.Fields(ChildProjectFields.TERRAINCODEID).ValueChanged, AddressOf TerrainCodeID_ValueChanged
        AddHandler model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHER).ValueChanged, AddressOf TransporationOther_ValueChanged
        AddHandler model.Fields(ChildProjectFields.PRIMARYDIETOTHER).ValueChanged, AddressOf PrimaryDietOther_ValueChanged
    End Sub

    Public Sub InitializeCodeTableVars()
        'Initialize Code Table IDs 
        Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()
            religionOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.RELIGION_OTHER, True, errorTextCouldNotFindRelgionOther)
            terrainOtherGuid = CRMHelper.GetCodeTableItemID(crmSQLConnection, CodeTableFields.CHILDPROJECTTERRAIN_OTHER, True, errorTextCouldNotFindTerrainOther)
        End Using
    End Sub

    Public Sub InitializeUIDisplay()
        ' Set the UI based on loaded values
        Toggle_ReligionOther()
        Toggle_TerrainOther()
        Toggle_TransportationOther()
        Toggle_PrimaryDietOther()
        Toggle_HealthProblemOther()
    End Sub

    Private Sub ReligionCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ReligionOther()
    End Sub

    Private Sub Toggle_ReligionOther()
        If model.Fields(ChildProjectFields.RELIGIONCODEID).ValueObject Is Nothing OrElse
            model.Fields(ChildProjectFields.RELIGIONCODEID).ValueObject.ToString <> religionOtherGuid Then
            model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.RELIGIONOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.RELIGIONOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Visible = True

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.RELIGIONOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.RELIGIONOTHERDESC).Required = True
            End Select
        End If
    End Sub

    Private Sub HealthProblemOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_HealthProblemOther()
    End Sub

    Private Sub Toggle_HealthProblemOther()
        If model.Fields(ChildProjectFields.HEALTHPROBLEMOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.HEALTHPROBLEMOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.HEALTHPROBLEMOTHERDESC).Required = True
            End Select
        End If
    End Sub


    Private Sub TerrainCodeID_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_TerrainOther()
    End Sub

    Private Sub Toggle_TerrainOther()
        If model.Fields(ChildProjectFields.TERRAINCODEID).ValueObject Is Nothing OrElse
            model.Fields(ChildProjectFields.TERRAINCODEID).ValueObject.ToString <> terrainOtherGuid Then
            model.Fields(ChildProjectFields.TERRAINOTHER).Visible = False
            model.Fields(ChildProjectFields.TERRAINOTHER).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.TERRAINOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.TERRAINOTHER).Enabled = False
                    model.Fields(ChildProjectFields.TERRAINOTHER).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.TERRAINOTHER).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.TERRAINOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.TERRAINOTHER).Enabled = True
                    model.Fields(ChildProjectFields.TERRAINOTHER).Required = True
            End Select
        End If
    End Sub

    Private Sub TransporationOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_TransportationOther()
    End Sub

    Private Sub Toggle_TransportationOther()
        If model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.TRANSPORTATIONTYPEOTHERDESC).Required = True
            End Select
        End If
    End Sub


    Private Sub PrimaryDietOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_PrimaryDietOther()
    End Sub

    Private Sub Toggle_PrimaryDietOther()
        If model.Fields(ChildProjectFields.PRIMARYDIETOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(ChildProjectFields.PRIMARYDIETOTHER).ValueObject) = False Then
            model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Visible = False
            model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Enabled = False
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Required = False
            End Select

        Else
            model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Enabled = True
                    model.Fields(ChildProjectFields.PRIMARYDIETOTHERDESC).Required = True
            End Select
        End If
    End Sub
End Class
