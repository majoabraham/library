Imports DevExpress.Xpo

Public Class BookEditXtraForm

    Private _oid As Integer
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using uow As New UnitOfWork
            Dim book = New Book(uow) With {
               .Title = TitleTextEdit.Text,
               .Author = AuthorTextEdit.Text,
               .IsAvailable = IsAvailableCheckEdit.Checked
            }

            uow.CommitChanges()
            uow.Dispose()
        End Using

        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub

    Private Sub BookEditXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rowId = MainXtraForm.GridView2.GetSelectedRows().First()
        _oid = CInt(MainXtraForm.GridView2.GetRow(rowId).Oid)
        MessageBox.Show(_oid.ToString())
    End Sub
End Class