Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
' ...

Namespace PrintDXGridSample
	Public Class Person
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Private Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Private Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property

		Public Sub New(ByVal name As String, ByVal age As Integer)
			Me.Name = name
			Me.Age = age
		End Sub
	End Class
End Namespace
