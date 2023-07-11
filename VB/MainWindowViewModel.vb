Imports System.Collections.Generic
' ...

Namespace PrintDXGridSample
	Public Class MainWindowViewModel
		Public Property Persons() As IEnumerable(Of Person)

		Public Sub New()
			Persons = {
				New Person("John", 25),
				New Person("Mary", 33)
			}
		End Sub
	End Class
End Namespace
