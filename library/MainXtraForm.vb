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

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckoutBarButtonItem.ItemClick
        CheckoutXtraForm.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckinBarButtonItem.ItemClick
        CheckinXtraForm.Show()
    End Sub

    Private Sub AgendaXtraTabControl_Selected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles AgendaXtraTabControl.Selected
        Select Case AgendaXtraTabControl.SelectedTabPage.Name
            Case "BooksXtraTabPage"
                BookEditBarButtonItem.Enabled = True
                ReaderEditBarButtonItem.Enabled = False
                CheckinBarButtonItem.Enabled = False
            Case "ReadersXtraTabPage"
                BookEditBarButtonItem.Enabled = False
                ReaderEditBarButtonItem.Enabled = True
                CheckinBarButtonItem.Enabled = False
            Case "BorrowingsXtraTabPage"
                BookEditBarButtonItem.Enabled = False
                ReaderEditBarButtonItem.Enabled = False
                CheckinBarButtonItem.Enabled = True
        End Select
    End Sub

    Private Sub MainXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReaderEditBarButtonItem.Enabled = False
        CheckinBarButtonItem.Enabled = False
    End Sub
End Class