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
''' Represents the UI model for the 'Child Project UI Model Version' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "2b80cee5-27c7-4845-9651-d191bca0b795", "c1a25251-2943-46c9-bdb3-837690cd6b98", "Child Project Extension")> _
Partial Public Class [ChildProjectUIModelVersionViewFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _version As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Sub New()
        MyBase.New()

        _version = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New Guid("2b80cee5-27c7-4845-9651-d191bca0b795")
        MyBase.DataFormInstanceId = New Guid("c1a25251-2943-46c9-bdb3-837690cd6b98")
        MyBase.RecordType = "Child Project Extension"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/ChildProject.UIModelVersion.ViewForm.html"

        '
        '_version
        '
        _version.Name = "VERSION"
        _version.Caption = "Child Project UI Model:"
        _version.DBReadOnly = True
        _version.MaxLength = 50
        Me.Fields.Add(_version)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Child Project UI Model
    ''' </summary>
    <System.ComponentModel.Description("Child Project UI Model")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [VERSION]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _version
        End Get
    End Property
    
End Class
