Imports System.ComponentModel.DataAnnotations
Public Class DataValidation
    Private context As ValidationContext
    Private results As List(Of ValidationResult)
    Private valid As Boolean
    Private message As String

    Public Sub New(instance As Object)
        context = New ValidationContext(instance)
        results = New List(Of ValidationResult)
        valid = Validator.TryValidateObject(instance, context, results, True)
    End Sub

    Public Function validate() As Boolean
        If valid = False Then
            For Each item As ValidationResult In results
                message += item.ErrorMessage + vbNewLine
            Next
            MessageBox.Show(message)
        End If
        Return valid
    End Function

End Class
