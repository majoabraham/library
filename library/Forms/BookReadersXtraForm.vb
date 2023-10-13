Imports System.Security.Cryptography
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class BookReadersXtraForm
    Private Sub BookReadersXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rowId = MainXtraForm.BooksGridView.GetSelectedRows().First()
        Dim bookRow As Book = CType(MainXtraForm.BooksGridView.GetRow(rowId), Book)

        Dim borrowings As XPCollection(Of Borrowing)
        Dim readers As List(Of Reader)
        Dim criteria = New BinaryOperator(NameOf(Book.Oid), bookRow.Oid, BinaryOperatorType.Equal)

        Using uow As New UnitOfWork()

            borrowings = New XPCollection(Of Borrowing)(uow, criteria)
        End Using

    End Sub
End Class