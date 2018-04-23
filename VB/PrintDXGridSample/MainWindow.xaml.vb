Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
' ...

Namespace PrintDXGridSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New PrintableControlLink(CType(gridControl.View, TableView))
			Dim model As New LinkPreviewModel(link)
			preview.Model = model
			link.CreateDocument(True)
		End Sub
	End Class
End Namespace
