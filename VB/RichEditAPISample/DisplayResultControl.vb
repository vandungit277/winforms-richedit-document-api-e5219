﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Docking

Namespace RichEditAPISample
    Partial Public Class DisplayResultControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            richEditControl1.Options.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Hidden
            richEditControl1.Options.Comments.ShowAllAuthors = True
        End Sub

        Public ReadOnly Property RichEdit() As RichEditControl
            Get
                Return richEditControl1
            End Get
        End Property
        Public Property ReviewingPaneFormVisible() As Boolean
            Get
                Return If(dockPanel1.Visibility <> DockVisibility.Visible, True, False)
            End Get
            Set(ByVal value As Boolean)
                dockPanel1.Visibility = If(value, DockVisibility.Visible, DockVisibility.Hidden)
            End Set
        End Property

        Public ReadOnly Property DockPanel() As DockPanel
            Get
                dockManager1.ForceInitialize()
                Return dockPanel1
            End Get
        End Property
    End Class
End Namespace
