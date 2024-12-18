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
            MessageBox.Show(message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return valid
    End Function

    Public Shared Function ValidarTextBoxEnGroupBox(grp As GroupBox) As Boolean
        For Each ctrl As Control In grp.Controls

            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    MessageBox.Show("los campos no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function

End Class
