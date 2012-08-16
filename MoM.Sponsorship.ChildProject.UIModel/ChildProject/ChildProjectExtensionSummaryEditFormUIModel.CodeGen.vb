﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.93.2034.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Child Project Extension Summary Edit Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "092cce6e-0535-4598-ad50-4802ba5bcb99", "a3d38811-6c7b-466e-8eb9-6a6a78af2072", "Child Project Extension")> _
Partial Public Class [ChildProjectExtensionSummaryEditFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _name As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _lookupid As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojectstatuscodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _childprojecttypecodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _childprojecttypeother As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojectcategorycodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _childprojectsubcategorycodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Sub New()
        MyBase.New()

        _name = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _lookupid = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojectstatuscodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _childprojecttypecodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _childprojecttypeother = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojectcategorycodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _childprojectsubcategorycodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New Guid("092cce6e-0535-4598-ad50-4802ba5bcb99")
        MyBase.DataFormInstanceId = New Guid("a3d38811-6c7b-466e-8eb9-6a6a78af2072")
        MyBase.RecordType = "Child Project Extension"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom//ChildProject.ExtensionSummary.EditForm.html"

        '
        '_name
        '
        _name.Name = "NAME"
        _name.Caption = "Project name"
        _name.Required = True
        _name.MaxLength = 100
        Me.Fields.Add(_name)
        '
        '_lookupid
        '
        _lookupid.Name = "LOOKUPID"
        _lookupid.Caption = "Lookup ID"
        _lookupid.Required = True
        _lookupid.MaxLength = 36
        Me.Fields.Add(_lookupid)
        '
        '_childprojectstatuscodeid
        '
        _childprojectstatuscodeid.Name = "CHILDPROJECTSTATUSCODEID"
        _childprojectstatuscodeid.Caption = "Status"
        _childprojectstatuscodeid.Required = True
        _childprojectstatuscodeid.CodeTableName = "USR_CHILDPROJECTSTATUSCODE"
        Me.Fields.Add(_childprojectstatuscodeid)
        '
        '_childprojecttypecodeid
        '
        _childprojecttypecodeid.Name = "CHILDPROJECTTYPECODEID"
        _childprojecttypecodeid.Caption = "Project type"
        _childprojecttypecodeid.Required = True
        _childprojecttypecodeid.CodeTableName = "USR_CHILDPROJECTTYPECODE"
        Me.Fields.Add(_childprojecttypecodeid)
        '
        '_childprojecttypeother
        '
        _childprojecttypeother.Name = "CHILDPROJECTTYPEOTHER"
        _childprojecttypeother.Caption = "Describe other"
        _childprojecttypeother.MaxLength = 50
        Me.Fields.Add(_childprojecttypeother)
        '
        '_childprojectcategorycodeid
        '
        _childprojectcategorycodeid.Name = "CHILDPROJECTCATEGORYCODEID"
        _childprojectcategorycodeid.Caption = "Category"
        _childprojectcategorycodeid.Required = True
        _childprojectcategorycodeid.CodeTableName = "USR_CHILDPROJECTCATEGORYCODE"
        Me.Fields.Add(_childprojectcategorycodeid)
        '
        '_childprojectsubcategorycodeid
        '
        _childprojectsubcategorycodeid.Name = "CHILDPROJECTSUBCATEGORYCODEID"
        _childprojectsubcategorycodeid.Caption = "Subcategory"
        _childprojectsubcategorycodeid.CodeTableName = "USR_CHILDPROJECTSUBCATEGORYCODE"
        Me.Fields.Add(_childprojectsubcategorycodeid)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Project name
    ''' </summary>
    <System.ComponentModel.Description("Project name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [NAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _name
        End Get
    End Property
    
    ''' <summary>
    ''' Lookup ID
    ''' </summary>
    <System.ComponentModel.Description("Lookup ID")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [LOOKUPID]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _lookupid
        End Get
    End Property
    
    ''' <summary>
    ''' Status
    ''' </summary>
    <System.ComponentModel.Description("Status")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTSTATUSCODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _childprojectstatuscodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Project type
    ''' </summary>
    <System.ComponentModel.Description("Project type")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPECODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _childprojecttypecodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Describe other
    ''' </summary>
    <System.ComponentModel.Description("Describe other")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPEOTHER]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojecttypeother
        End Get
    End Property
    
    ''' <summary>
    ''' Category
    ''' </summary>
    <System.ComponentModel.Description("Category")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTCATEGORYCODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _childprojectcategorycodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Subcategory
    ''' </summary>
    <System.ComponentModel.Description("Subcategory")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTSUBCATEGORYCODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _childprojectsubcategorycodeid
        End Get
    End Property
    
End Class
