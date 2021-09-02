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

		Private Sub UpdatePreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link = New PrintableControlLink(CType(gridControl.View, TableView))
			link.CreateDocument(True)
			preview.DocumentSource = link
		End Sub
	End Class
End Namespace
