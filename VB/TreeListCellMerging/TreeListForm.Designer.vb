﻿Imports Microsoft.VisualBasic
Imports System
Namespace TreeListCellMerging
	Partial Public Class TreeListForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New TreeListCellMerging.MyTreeList()
			Me.colDEPARTMENT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colBUDGET = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colLOCATION = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPHONE1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPHONE2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.departmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.departmentsDataSet = New DepartmentsDataSet()
            Me.departmentsTableAdapter = New DepartmentsDataSetTableAdapters.DepartmentsTableAdapter()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colDEPARTMENT, Me.colBUDGET, Me.colLOCATION, Me.colPHONE1, Me.colPHONE2})
			Me.treeList1.Cursor = System.Windows.Forms.Cursors.Default
			Me.treeList1.DataSource = Me.departmentsBindingSource
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseUp
			Me.treeList1.OptionsView.AllowHorizontalMerge = True
			Me.treeList1.ParentFieldName = "PARENTID"
			Me.treeList1.Size = New System.Drawing.Size(754, 333)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.AllowMergeRowCells += New TreeListCellMerging.AllowMergeRowCellsEventHandler(Me.treeList1_AllowMergeRowCells);
			' 
			' colDEPARTMENT
			' 
			Me.colDEPARTMENT.FieldName = "DEPARTMENT"
			Me.colDEPARTMENT.Name = "colDEPARTMENT"
			Me.colDEPARTMENT.Visible = True
			Me.colDEPARTMENT.VisibleIndex = 0
			Me.colDEPARTMENT.Width = 61
			' 
			' colBUDGET
			' 
			Me.colBUDGET.FieldName = "BUDGET"
			Me.colBUDGET.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colBUDGET.Name = "colBUDGET"
			Me.colBUDGET.Visible = True
			Me.colBUDGET.VisibleIndex = 1
			Me.colBUDGET.Width = 61
			' 
			' colLOCATION
			' 
			Me.colLOCATION.FieldName = "LOCATION"
			Me.colLOCATION.Name = "colLOCATION"
			Me.colLOCATION.Visible = True
			Me.colLOCATION.VisibleIndex = 2
			Me.colLOCATION.Width = 61
			' 
			' colPHONE1
			' 
			Me.colPHONE1.FieldName = "PHONE1"
			Me.colPHONE1.Name = "colPHONE1"
			Me.colPHONE1.Visible = True
			Me.colPHONE1.VisibleIndex = 3
			Me.colPHONE1.Width = 62
			' 
			' colPHONE2
			' 
			Me.colPHONE2.FieldName = "PHONE2"
			Me.colPHONE2.Name = "colPHONE2"
			Me.colPHONE2.Visible = True
			Me.colPHONE2.VisibleIndex = 4
			Me.colPHONE2.Width = 62
			' 
			' departmentsBindingSource
			' 
			Me.departmentsBindingSource.DataMember = "Departments"
			Me.departmentsBindingSource.DataSource = Me.departmentsDataSet
			' 
			' departmentsDataSet
			' 
			Me.departmentsDataSet.DataSetName = "DepartmentsDataSet"
			Me.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' departmentsTableAdapter
			' 
			Me.departmentsTableAdapter.ClearBeforeFill = True
			' 
			' TreeListForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(754, 333)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "TreeListForm"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As MyTreeList
		Private departmentsDataSet As DepartmentsDataSet
		Private departmentsBindingSource As System.Windows.Forms.BindingSource
        Private departmentsTableAdapter As DepartmentsDataSetTableAdapters.DepartmentsTableAdapter
        Private colDEPARTMENT As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colBUDGET As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colLOCATION As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPHONE1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPHONE2 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

