﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.Charting.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Clockwise.
        '''</summary>
        Friend ReadOnly Property Clockwise() As String
            Get
                Return ResourceManager.GetString("Clockwise", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Data\NWIND.MDB;Persist Security Info=False.
        '''</summary>
        Friend ReadOnly Property ConnectionString() As String
            Get
                Return ResourceManager.GetString("ConnectionString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Counterclockwise.
        '''</summary>
        Friend ReadOnly Property Counterclockwise() As String
            Get
                Return ResourceManager.GetString("Counterclockwise", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Direction of rotation:.
        '''</summary>
        Friend ReadOnly Property DirectionOfRotation() As String
            Get
                Return ResourceManager.GetString("DirectionOfRotation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Finance chart.
        '''</summary>
        Friend ReadOnly Property FinanceChart() As String
            Get
                Return ResourceManager.GetString("FinanceChart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ..\\..\\rpt2DBar.rpx.
        '''</summary>
        Friend ReadOnly Property rpt2DBar() As String
            Get
                Return ResourceManager.GetString("rpt2DBar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ..\\..\\rpt3DBar.rpx.
        '''</summary>
        Friend ReadOnly Property rpt3DBar() As String
            Get
                Return ResourceManager.GetString("rpt3DBar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ..\\..\\rpt3DPie.rpx.
        '''</summary>
        Friend ReadOnly Property rpt3DPie() As String
            Get
                Return ResourceManager.GetString("rpt3DPie", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ..\\..\\rptCandle.rpx.
        '''</summary>
        Friend ReadOnly Property rptCandle() As String
            Get
                Return ResourceManager.GetString("rptCandle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ..\\..\\rptStackedArea.rpx.
        '''</summary>
        Friend ReadOnly Property rptStackedArea() As String
            Get
                Return ResourceManager.GetString("rptStackedArea", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Stacked area chart.
        '''</summary>
        Friend ReadOnly Property StackedAreaChart() As String
            Get
                Return ResourceManager.GetString("StackedAreaChart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 3D bar chart.
        '''</summary>
        Friend ReadOnly Property ThreeDBarChart() As String
            Get
                Return ResourceManager.GetString("ThreeDBarChart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 3D pie chart.
        '''</summary>
        Friend ReadOnly Property ThreeDPieChart() As String
            Get
                Return ResourceManager.GetString("ThreeDPieChart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 2D bar chart.
        '''</summary>
        Friend ReadOnly Property TwoDBarChart() As String
            Get
                Return ResourceManager.GetString("TwoDBarChart", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
