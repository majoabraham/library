Public Class MainXtraForm
    Public Sub New()
        InitializeComponent()
        Connection.Connect()
    End Sub

    Private Sub BookCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookCreateBarButtonItem.ItemClick
        BookCreateXtraForm.Show()
    End Sub

    Private Sub ReaderCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReaderCreateBarButtonItem.ItemClick
        ReaderCreateXtraForm.Show()
    End Sub

    Private Sub BookEditButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookEditBarButtonItem.ItemClick
        BookEditXtraForm.Show()
    End Sub

    Private Sub ReaderEditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReaderEditBarButtonItem.ItemClick
        ReaderEditXtraForm.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        CheckoutXtraForm.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        CheckinXtraForm.Show()
    End Sub

    Private Sub AgendaXtraTabControl_Selected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles AgendaXtraTabControl.Selected
        Select Case AgendaXtraTabControl.SelectedTabPage.Name
            Case "BooksXtraTabPage"
                MessageBox.Show("Books")
            Case "ReadersXtraTabPage"
                MessageBox.Show("Readers")
            Case "BorrowingsXtraTabPage"
                MessageBox.Show("Borrowings")
        End Select
    End Sub
End Class