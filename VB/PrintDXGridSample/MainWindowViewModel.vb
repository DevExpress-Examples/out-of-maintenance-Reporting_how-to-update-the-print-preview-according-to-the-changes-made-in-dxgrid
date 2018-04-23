Imports System.Collections.Generic
' ...

Namespace PrintDXGridSample
    Public Class MainWindowViewModel
        Public Property Persons() As IEnumerable(Of Person)

        Public Sub New()
            Persons = { _
                New Person("John", 25), _
                New Person("Mary", 33) _
            }
        End Sub
    End Class
End Namespace
