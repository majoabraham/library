Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class BookReadersXtraForm
    Private Sub BookReadersXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rowId = MainXtraForm.BooksGridView.GetSelectedRows().First()
        Dim bookRow As Book = CType(MainXtraForm.BooksGridView.GetRow(rowId), Book)

        Dim readers = New List(Of Reader)
        Dim criteria = CriteriaOperator.FromLambda(Of Borrowing)(Function(b) b.Book.Oid = bookRow.Oid And b.CheckinDate Is Nothing)

        Dim uow = New UnitOfWork()

        Dim borrowings = New XPCollection(Of Borrowing)(uow, criteria)

        For Each borrowing In borrowings
            readers.Add(borrowing.Reader)

        Next

        BookReadersGridControl.DataSource = readers

    End Sub
End Class