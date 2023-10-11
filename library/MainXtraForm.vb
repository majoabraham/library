Public Class MainXtraForm
    Private Sub MainXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.Connect()
    End Sub

    Private Sub BookCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookCreateBarButtonItem.ItemClick
        BookCreateXtraForm.Show()
    End Sub

    Private Sub ReaderCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReaderCreateBarButtonItem.ItemClick
        ReaderCreateXtraForm.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookEditBarButtonItem.ItemClick
        BookEditXtraForm.Show()
    End Sub
End Class