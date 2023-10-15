Imports DevExpress.Xpo

Public Class BookCreateXtraForm
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using uow As New UnitOfWork
            Dim book = New Book(uow) With {
               .Title = TitleTextEdit.Text,
               .Author = AuthorTextEdit.Text,
               .IsAvailable = IsAvailableCheckEdit.Checked,
               .Quantity = CInt(QuantitySpinEdit.Value),
               .InStock = CInt(InStockSpinEdit.Value)
            }

            uow.CommitChanges()
        End Using

        'MainXtraForm.BooksGridControl.RefreshDataSource()
        'MainXtraForm.BooksGridControl.Refresh()
        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub
End Class