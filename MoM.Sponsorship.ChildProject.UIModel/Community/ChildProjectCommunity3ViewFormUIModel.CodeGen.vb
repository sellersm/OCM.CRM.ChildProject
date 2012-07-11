﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.91.1535.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Child Project Community 3 View Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "325e6fc0-c0ec-4870-bc0e-d53d78b77a09", "d3c9d00c-3be7-4c58-b2a0-cbe01d8af2ae", "Child Project Extension")> _
Partial Public Class [ChildProjectCommunity3ViewFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Enums"

    ''' <summary>
    ''' Enumerated values for use with the CHILDLEGALPROTECTIONCODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public Enum CHILDLEGALPROTECTIONCODES As Integer
        [ValueNotEntered] = 0
        [CommunityIsUnawareOfTheConventionOnTheRightsOfTheChildThereAreNoLocalLawsToProtectChildren] = 1
        [CommunityIsAwareOfTheConventionOnTheRightsOfTheChildButItIsNotEnforcedThereAreLocalLawsToProtect] = 2
        [CommunityIsAwareOfTheCoventionOnTheRightsOfTheChildAndEffortIsMadeToEducateAndPostInformationOnThi] = 3
    End Enum

    ''' <summary>
    ''' Enumerated values for use with the CHILDLABORCODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public Enum CHILDLABORCODES As Integer
        [ValueNotEntered] = 0
        [ChildrenRegularlyParticipateInTheLaborPoolAndInDangerousTasksSuchAsFarmingFactoryWorkAndExposureTo] = 1
        [ChildrenSometimesParticipateInTheLaborPoolAndInDangerousTasksButDoHaveTheOpportunityForEducation] = 2
        [ChildrenDoNotParticipateInTheLaborPoolEducationForChildrenIsHighlyEncouragedAndSupported] = 3
    End Enum

#End Region

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _id As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _childlegalprotectioncode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLEGALPROTECTIONCODES))
    Private WithEvents _childlaborcode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLABORCODES))
    Private WithEvents _childcarewhenparentabsentadoption As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentextendedfamily As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentfostercare As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentinstitution As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentnocare As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentother As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _childcarewhenparentabsentotherdesc As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _localadoptionaccepted As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _foreignadoptionlegal As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public Sub New()
        MyBase.New()

        _id = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _childlegalprotectioncode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLEGALPROTECTIONCODES))
        _childlaborcode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLABORCODES))
        _childcarewhenparentabsentadoption = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentextendedfamily = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentfostercare = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentinstitution = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentnocare = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentother = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _childcarewhenparentabsentotherdesc = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _localadoptionaccepted = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _foreignadoptionlegal = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New Guid("325e6fc0-c0ec-4870-bc0e-d53d78b77a09")
        MyBase.DataFormInstanceId = New Guid("d3c9d00c-3be7-4c58-b2a0-cbe01d8af2ae")
        MyBase.RecordType = "Child Project Extension"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/ChildProject.Community3.ViewForm.html"

        '
        '_id
        '
        _id.Name = "ID"
        _id.Caption = "ID"
        _id.Visible = False
        _id.DBReadOnly = True
        Me.Fields.Add(_id)
        '
        '_childlegalprotectioncode
        '
        _childlegalprotectioncode.Name = "CHILDLEGALPROTECTIONCODE"
        _childlegalprotectioncode.Caption = "Child Legal Protection"
        _childlegalprotectioncode.DBReadOnly = True
        _childlegalprotectioncode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLEGALPROTECTIONCODES)) With {.Value = CHILDLEGALPROTECTIONCODES.[ValueNotEntered], .Translation = "value not entered"})
        _childlegalprotectioncode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLEGALPROTECTIONCODES)) With {.Value = CHILDLEGALPROTECTIONCODES.[CommunityIsUnawareOfTheConventionOnTheRightsOfTheChildThereAreNoLocalLawsToProtectChildren], .Translation = "Community is unaware of the Convention on the Rights of the Child. There are no local laws to protect children."})
        _childlegalprotectioncode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLEGALPROTECTIONCODES)) With {.Value = CHILDLEGALPROTECTIONCODES.[CommunityIsAwareOfTheConventionOnTheRightsOfTheChildButItIsNotEnforcedThereAreLocalLawsToProtect], .Translation = "Community is aware of the Convention on the Rights of the Child, but it is not enforced. There are local laws to protect children, but they are not enforced."})
        _childlegalprotectioncode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLEGALPROTECTIONCODES)) With {.Value = CHILDLEGALPROTECTIONCODES.[CommunityIsAwareOfTheCoventionOnTheRightsOfTheChildAndEffortIsMadeToEducateAndPostInformationOnThi], .Translation = "Community is aware of the Covention on the Rights of the Child and effort is made to educate and post information on this topic. There are local laws to protect children and they are enforced."})
        Me.Fields.Add(_childlegalprotectioncode)
        '
        '_childlaborcode
        '
        _childlaborcode.Name = "CHILDLABORCODE"
        _childlaborcode.Caption = "Child Labor"
        _childlaborcode.DBReadOnly = True
        _childlaborcode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLABORCODES)) With {.Value = CHILDLABORCODES.[ValueNotEntered], .Translation = "value not entered"})
        _childlaborcode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLABORCODES)) With {.Value = CHILDLABORCODES.[ChildrenRegularlyParticipateInTheLaborPoolAndInDangerousTasksSuchAsFarmingFactoryWorkAndExposureTo], .Translation = "Children regularly participate in the labor pool and in dangerous tasks, such as farming, factory work, and exposure to hazardous materials."})
        _childlaborcode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLABORCODES)) With {.Value = CHILDLABORCODES.[ChildrenSometimesParticipateInTheLaborPoolAndInDangerousTasksButDoHaveTheOpportunityForEducation], .Translation = "Children sometimes participate in the labor pool and in dangerous tasks, but do have the opportunity for education."})
        _childlaborcode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of CHILDLABORCODES)) With {.Value = CHILDLABORCODES.[ChildrenDoNotParticipateInTheLaborPoolEducationForChildrenIsHighlyEncouragedAndSupported], .Translation = "Children do not participate in the labor pool.  Education for children is  highly encouraged and supported."})
        Me.Fields.Add(_childlaborcode)
        '
        '_childcarewhenparentabsentadoption
        '
        _childcarewhenparentabsentadoption.Name = "CHILDCAREWHENPARENTABSENTADOPTION"
        _childcarewhenparentabsentadoption.Caption = "Adoption"
        _childcarewhenparentabsentadoption.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentadoption)
        '
        '_childcarewhenparentabsentextendedfamily
        '
        _childcarewhenparentabsentextendedfamily.Name = "CHILDCAREWHENPARENTABSENTEXTENDEDFAMILY"
        _childcarewhenparentabsentextendedfamily.Caption = "Extended family"
        _childcarewhenparentabsentextendedfamily.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentextendedfamily)
        '
        '_childcarewhenparentabsentfostercare
        '
        _childcarewhenparentabsentfostercare.Name = "CHILDCAREWHENPARENTABSENTFOSTERCARE"
        _childcarewhenparentabsentfostercare.Caption = "Foster care"
        _childcarewhenparentabsentfostercare.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentfostercare)
        '
        '_childcarewhenparentabsentinstitution
        '
        _childcarewhenparentabsentinstitution.Name = "CHILDCAREWHENPARENTABSENTINSTITUTION"
        _childcarewhenparentabsentinstitution.Caption = "Institution"
        _childcarewhenparentabsentinstitution.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentinstitution)
        '
        '_childcarewhenparentabsentnocare
        '
        _childcarewhenparentabsentnocare.Name = "CHILDCAREWHENPARENTABSENTNOCARE"
        _childcarewhenparentabsentnocare.Caption = "No care available"
        _childcarewhenparentabsentnocare.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentnocare)
        '
        '_childcarewhenparentabsentother
        '
        _childcarewhenparentabsentother.Name = "CHILDCAREWHENPARENTABSENTOTHER"
        _childcarewhenparentabsentother.Caption = "Other"
        _childcarewhenparentabsentother.DBReadOnly = True
        Me.Fields.Add(_childcarewhenparentabsentother)
        '
        '_childcarewhenparentabsentotherdesc
        '
        _childcarewhenparentabsentotherdesc.Name = "CHILDCAREWHENPARENTABSENTOTHERDESC"
        _childcarewhenparentabsentotherdesc.Caption = "Child care when parent absent other description"
        _childcarewhenparentabsentotherdesc.DBReadOnly = True
        _childcarewhenparentabsentotherdesc.MaxLength = 50
        Me.Fields.Add(_childcarewhenparentabsentotherdesc)
        '
        '_localadoptionaccepted
        '
        _localadoptionaccepted.Name = "LOCALADOPTIONACCEPTED"
        _localadoptionaccepted.Caption = "Is local adoption accepted?"
        _localadoptionaccepted.DBReadOnly = True
        _localadoptionaccepted.MaxLength = 20
        Me.Fields.Add(_localadoptionaccepted)
        '
        '_foreignadoptionlegal
        '
        _foreignadoptionlegal.Name = "FOREIGNADOPTIONLEGAL"
        _foreignadoptionlegal.Caption = "Is foreign adoption legal?"
        _foreignadoptionlegal.DBReadOnly = True
        _foreignadoptionlegal.MaxLength = 20
        Me.Fields.Add(_foreignadoptionlegal)

		OnCreated()

    End Sub
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [ID]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _id
        End Get
    End Property
    
    ''' <summary>
    ''' Child Legal Protection
    ''' </summary>
    <System.ComponentModel.Description("Child Legal Protection")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDLEGALPROTECTIONCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLEGALPROTECTIONCODES))
        Get
            Return _childlegalprotectioncode
        End Get
    End Property
    
    ''' <summary>
    ''' Child Labor
    ''' </summary>
    <System.ComponentModel.Description("Child Labor")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDLABORCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of CHILDLABORCODES))
        Get
            Return _childlaborcode
        End Get
    End Property
    
    ''' <summary>
    ''' Adoption
    ''' </summary>
    <System.ComponentModel.Description("Adoption")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTADOPTION]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentadoption
        End Get
    End Property
    
    ''' <summary>
    ''' Extended family
    ''' </summary>
    <System.ComponentModel.Description("Extended family")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTEXTENDEDFAMILY]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentextendedfamily
        End Get
    End Property
    
    ''' <summary>
    ''' Foster care
    ''' </summary>
    <System.ComponentModel.Description("Foster care")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTFOSTERCARE]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentfostercare
        End Get
    End Property
    
    ''' <summary>
    ''' Institution
    ''' </summary>
    <System.ComponentModel.Description("Institution")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTINSTITUTION]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentinstitution
        End Get
    End Property
    
    ''' <summary>
    ''' No care available
    ''' </summary>
    <System.ComponentModel.Description("No care available")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTNOCARE]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentnocare
        End Get
    End Property
    
    ''' <summary>
    ''' Other
    ''' </summary>
    <System.ComponentModel.Description("Other")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTOTHER]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _childcarewhenparentabsentother
        End Get
    End Property
    
    ''' <summary>
    ''' Child care when parent absent other description
    ''' </summary>
    <System.ComponentModel.Description("Child care when parent absent other description")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [CHILDCAREWHENPARENTABSENTOTHERDESC]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childcarewhenparentabsentotherdesc
        End Get
    End Property
    
    ''' <summary>
    ''' Is local adoption accepted?
    ''' </summary>
    <System.ComponentModel.Description("Is local adoption accepted?")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [LOCALADOPTIONACCEPTED]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _localadoptionaccepted
        End Get
    End Property
    
    ''' <summary>
    ''' Is foreign adoption legal?
    ''' </summary>
    <System.ComponentModel.Description("Is foreign adoption legal?")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.91.1535.0")> _
    Public ReadOnly Property [FOREIGNADOPTIONLEGAL]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _foreignadoptionlegal
        End Get
    End Property
    
End Class