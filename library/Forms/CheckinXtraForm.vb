Imports DevExpress.Xpo

Public Class CheckinXtraForm

    Private _uow As UnitOfWork
    Private _borrowing As Borrowing

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

    End Sub
    Private Sub CheckinXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBorrowing()

        'book
        BookLookUpEdit.Properties.DataSource = New List(Of Book)({_borrowing.Book})
        BookLookUpEdit.Properties.DisplayMember = NameOf(Book.Title)
        BookLookUpEdit.Properties.ValueMember = NameOf(Book.Oid)
        BookLookUpEdit.EditValue = _borrowing.Book.Oid

        'reader
        Dim uow As New UnitOfWork
        ReaderLookUpEdit.Properties.DataSource = New List(Of Reader)({_borrowing.Reader})
        ReaderLookUpEdit.Properties.DisplayMember = NameOf(Reader.FullName)
        ReaderLookUpEdit.Properties.ValueMember = NameOf(Reader.Oid)
        ReaderLookUpEdit.EditValue = _borrowing.Reader.Oid

        'checkout
        CheckoutDateEdit.DateTime = _borrowing.CheckoutDate.Value.Date

        'checkin
        CheckinDateEdit.DateTime = DateTime.Now

    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using _uow

            _borrowing.CheckinDate = CheckinDateEdit.DateTime

            _borrowing.Book.InStock += 1
            _borrowing.Book.IsAvailable = True

            _uow.CommitChanges()
        End Using

        MainXtraForm.BorrowingGridControl.DataSource = DataManipulation.GetAllBorrowings()
        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub

    Private Sub LoadBorrowing()
        Dim rowId = MainXtraForm.BorrowingGridView.GetSelectedRows().First()
        Dim row As Borrowing = CType(MainXtraForm.BorrowingGridView.GetRow(rowId), Borrowing)

        _borrowing = _uow.GetObjectByKey(Of Borrowing)(row.Oid)

    End Sub
End Class