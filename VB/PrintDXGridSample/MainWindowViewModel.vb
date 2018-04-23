Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
' ...

Namespace PrintDXGridSample
	Public Class MainWindowViewModel
		Private persons_Renamed As IEnumerable(Of Person)

		Public Property Persons() As IEnumerable(Of Person)
			Get
				Return persons_Renamed
			End Get
			Set(ByVal value As IEnumerable(Of Person))
				persons_Renamed = value
			End Set
		End Property

		Public Sub New()
			persons_Renamed = New List(Of Person)(New Person() { New Person("John", 25), New Person("Mary", 33) })
		End Sub
	End Class
End Namespace
