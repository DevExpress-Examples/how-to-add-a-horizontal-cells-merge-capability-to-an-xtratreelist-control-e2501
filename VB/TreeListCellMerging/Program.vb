﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace TreeListCellMerging
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New TreeListForm())
		End Sub
	End Class
End Namespace
