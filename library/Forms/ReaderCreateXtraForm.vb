Imports DevExpress.Xpo

Public Class ReaderCreateXtraForm
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using uow As New UnitOfWork
            Dim reader = New Reader(uow) With {
                .FirstName = FirstNameTextEdit.Text,
                .LastName = LastNameTextEdit.Text,
                .IdCard = IdCardTextEdit.Text,
                .BirthDate = BirthDayDateEdit.DateTime
            }

            uow.CommitChanges()
            uow.Dispose()
        End Using

        MainXtraForm.ReadersGridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub
End Class