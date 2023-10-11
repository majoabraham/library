Imports DevExpress.Xpo

Public Class ReaderEditXtraForm

    Private _oid As Integer
    Private _reader As Reader
    Private Sub ReaderEditXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadReader()

        FirstNameTextEdit.Text = _reader.FirstName
        LastNameTextEdit.Text = _reader.LastName
        IdCardTextEdit.Text = _reader.IdCard
        BirthDayDateEdit.DateTime = _reader.BirthDate

    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using uow As New UnitOfWork()

            _reader = uow.GetObjectByKey(Of Reader)(_oid)

            _reader.FirstName = FirstNameTextEdit.Text
            _reader.LastName = LastNameTextEdit.Text
            _reader.IdCard = IdCardTextEdit.Text
            _reader.BirthDate = BirthDayDateEdit.DateTime

            uow.CommitChanges()
            uow.Dispose()
        End Using

        MainXtraForm.ReadersGridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub LoadReader()
        Dim rowId = MainXtraForm.ReadersGridView.GetSelectedRows().First()
        Dim row As Reader = CType(MainXtraForm.ReadersGridView.GetRow(rowId), Reader)
        _oid = row.Oid

        Using uow As New UnitOfWork()
            _reader = uow.GetObjectByKey(Of Reader)(_oid)

            uow.Dispose()
        End Using
    End Sub
End Class