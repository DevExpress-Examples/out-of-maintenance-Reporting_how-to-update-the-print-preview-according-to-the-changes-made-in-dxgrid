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

        Sub UpdatePreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim link As New PrintableControlLink(CType(gridControl.View, TableView))
            preview.Model = New LinkPreviewModel(link)
            link.CreateDocument(True)
        End Sub
	End Class
End Namespace
