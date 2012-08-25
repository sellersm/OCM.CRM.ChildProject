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
''' Represents the UI model for the 'Child Project Extension Summary View Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "aa3e5fbc-21c8-4a4a-9ace-3450dff54cd1", "9b09d107-78a8-487f-9699-0ab996be70b4", "Child Project Extension")> _
Partial Public Class [ChildProjectExtensionSummaryViewFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _lookupid As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _name As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _country As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojecttype As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojecttypecodeid As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _childprojecttypeother As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojectstatus As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojectcategory As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojectsubcategory As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _locationreportrecipients As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _childprojecttypeotherseparator As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Sub New()
        MyBase.New()

        _lookupid = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _name = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _country = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojecttype = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojecttypecodeid = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _childprojecttypeother = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojectstatus = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojectcategory = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojectsubcategory = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _locationreportrecipients = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _childprojecttypeotherseparator = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New Guid("aa3e5fbc-21c8-4a4a-9ace-3450dff54cd1")
        MyBase.DataFormInstanceId = New Guid("9b09d107-78a8-487f-9699-0ab996be70b4")
        MyBase.RecordType = "Child Project Extension"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/ChildProject.ExtensionSummary.ViewForm.html"

        '
        '_lookupid
        '
        _lookupid.Name = "LOOKUPID"
        _lookupid.Caption = "Lookup ID"
        _lookupid.DBReadOnly = True
        _lookupid.MaxLength = 36
        Me.Fields.Add(_lookupid)
        '
        '_name
        '
        _name.Name = "NAME"
        _name.Caption = "Name"
        _name.Visible = False
        _name.DBReadOnly = True
        _name.MaxLength = 100
        Me.Fields.Add(_name)
        '
        '_country
        '
        _country.Name = "COUNTRY"
        _country.Caption = "Country"
        _country.DBReadOnly = True
        _country.MaxLength = 100
        Me.Fields.Add(_country)
        '
        '_childprojecttype
        '
        _childprojecttype.Name = "CHILDPROJECTTYPE"
        _childprojecttype.Caption = "Project type"
        _childprojecttype.DBReadOnly = True
        _childprojecttype.MaxLength = 100
        Me.Fields.Add(_childprojecttype)
        '
        '_childprojecttypecodeid
        '
        _childprojecttypecodeid.Name = "CHILDPROJECTTYPECODEID"
        _childprojecttypecodeid.Caption = "Project type code"
        _childprojecttypecodeid.DBReadOnly = True
        Me.Fields.Add(_childprojecttypecodeid)
        '
        '_childprojecttypeother
        '
        _childprojecttypeother.Name = "CHILDPROJECTTYPEOTHER"
        _childprojecttypeother.Caption = "Other description"
        _childprojecttypeother.DBReadOnly = True
        _childprojecttypeother.MaxLength = 50
        Me.Fields.Add(_childprojecttypeother)
        '
        '_childprojectstatus
        '
        _childprojectstatus.Name = "CHILDPROJECTSTATUS"
        _childprojectstatus.Caption = "Status"
        _childprojectstatus.DBReadOnly = True
        _childprojectstatus.MaxLength = 100
        Me.Fields.Add(_childprojectstatus)
        '
        '_childprojectcategory
        '
        _childprojectcategory.Name = "CHILDPROJECTCATEGORY"
        _childprojectcategory.Caption = "Category"
        _childprojectcategory.DBReadOnly = True
        _childprojectcategory.MaxLength = 100
        Me.Fields.Add(_childprojectcategory)
        '
        '_childprojectsubcategory
        '
        _childprojectsubcategory.Name = "CHILDPROJECTSUBCATEGORY"
        _childprojectsubcategory.Caption = "Subcategory"
        _childprojectsubcategory.DBReadOnly = True
        _childprojectsubcategory.MaxLength = 100
        Me.Fields.Add(_childprojectsubcategory)
        '
        '_locationreportrecipients
        '
        _locationreportrecipients.Name = "LOCATIONREPORTRECIPIENTS"
        _locationreportrecipients.Caption = "Report recipient(s)"
        _locationreportrecipients.DBReadOnly = True
        Me.Fields.Add(_locationreportrecipients)
        '
        '_childprojecttypeotherseparator
        '
        _childprojecttypeotherseparator.Name = "CHILDPROJECTTYPEOTHERSEPARATOR"
        _childprojecttypeotherseparator.Caption = "CHILDPROJECTTYPEOTHERSEPARATOR"
        _childprojecttypeotherseparator.DBReadOnly = True
        _childprojecttypeotherseparator.MaxLength = 1
        Me.Fields.Add(_childprojecttypeotherseparator)

		OnCreated()

    End Sub
    
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
    ''' Name
    ''' </summary>
    <System.ComponentModel.Description("Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [NAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _name
        End Get
    End Property
    
    ''' <summary>
    ''' Country
    ''' </summary>
    <System.ComponentModel.Description("Country")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [COUNTRY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _country
        End Get
    End Property
    
    ''' <summary>
    ''' Project type
    ''' </summary>
    <System.ComponentModel.Description("Project type")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojecttype
        End Get
    End Property
    
    ''' <summary>
    ''' Project type code
    ''' </summary>
    <System.ComponentModel.Description("Project type code")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPECODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _childprojecttypecodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Other description
    ''' </summary>
    <System.ComponentModel.Description("Other description")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPEOTHER]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojecttypeother
        End Get
    End Property
    
    ''' <summary>
    ''' Status
    ''' </summary>
    <System.ComponentModel.Description("Status")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTSTATUS]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojectstatus
        End Get
    End Property
    
    ''' <summary>
    ''' Category
    ''' </summary>
    <System.ComponentModel.Description("Category")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTCATEGORY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojectcategory
        End Get
    End Property
    
    ''' <summary>
    ''' Subcategory
    ''' </summary>
    <System.ComponentModel.Description("Subcategory")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTSUBCATEGORY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojectsubcategory
        End Get
    End Property
    
    ''' <summary>
    ''' Report recipient(s)
    ''' </summary>
    <System.ComponentModel.Description("Report recipient(s)")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [LOCATIONREPORTRECIPIENTS]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _locationreportrecipients
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDPROJECTTYPEOTHERSEPARATOR]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _childprojecttypeotherseparator
        End Get
    End Property
    
End Class
