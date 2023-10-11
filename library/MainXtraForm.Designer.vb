<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ReadersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ReaderXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.ReadersUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ReaderCreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BookCreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.FooterBarStaticItem = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BooksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BookXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.BooksUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReaderXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ReadersGridControl)
        Me.LayoutControl1.Controls.Add(Me.BooksGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 20)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1106, 581)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ReadersGridControl
        '
        Me.ReadersGridControl.DataSource = Me.ReaderXpServerCollectionSource
        Me.ReadersGridControl.Location = New System.Drawing.Point(12, 274)
        Me.ReadersGridControl.MainView = Me.GridView2
        Me.ReadersGridControl.MenuManager = Me.BarManager1
        Me.ReadersGridControl.Name = "ReadersGridControl"
        Me.ReadersGridControl.Size = New System.Drawing.Size(1082, 295)
        Me.ReadersGridControl.TabIndex = 6
        Me.ReadersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ReaderXpServerCollectionSource
        '
        Me.ReaderXpServerCollectionSource.DisplayableProperties = "FirstName;LastName;IdCard;BirthDate"
        Me.ReaderXpServerCollectionSource.ObjectType = GetType(library.Reader)
        Me.ReaderXpServerCollectionSource.Session = Me.ReadersUnitOfWork
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colLastName, Me.colIdCard, Me.colBirthDay})
        Me.GridView2.GridControl = Me.ReadersGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colFirstName
        '
        Me.colFirstName.Caption = "First Name"
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.Visible = True
        Me.colFirstName.VisibleIndex = 0
        '
        'colLastName
        '
        Me.colLastName.Caption = "Last Name"
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.Visible = True
        Me.colLastName.VisibleIndex = 1
        '
        'colIdCard
        '
        Me.colIdCard.Caption = "ID Card"
        Me.colIdCard.FieldName = "IdCard"
        Me.colIdCard.Name = "colIdCard"
        Me.colIdCard.Visible = True
        Me.colIdCard.VisibleIndex = 2
        '
        'colBirthDay
        '
        Me.colBirthDay.Caption = "Birth Day"
        Me.colBirthDay.FieldName = "BirthDate"
        Me.colBirthDay.Name = "colBirthDay"
        Me.colBirthDay.Visible = True
        Me.colBirthDay.VisibleIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar4})
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Readers", New System.Guid("07681dac-007f-4f3d-a1c4-e1dc6a0de0c5")), New DevExpress.XtraBars.BarManagerCategory("Books", New System.Guid("9165bda4-ec64-42c8-8d5c-22e51d4d3c9c"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarSubItem2, Me.FooterBarStaticItem, Me.BarButtonItem2, Me.BarButtonItem3, Me.ReaderCreateBarButtonItem, Me.BarButtonItem5, Me.BookCreateBarButtonItem, Me.BarButtonItem7})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 23
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Home"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Readers"
        Me.BarSubItem1.Id = 6
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.ReaderCreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&View"
        Me.BarButtonItem2.Id = 17
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'ReaderCreateBarButtonItem
        '
        Me.ReaderCreateBarButtonItem.Caption = "&Create"
        Me.ReaderCreateBarButtonItem.Id = 19
        Me.ReaderCreateBarButtonItem.Name = "ReaderCreateBarButtonItem"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "&Edit"
        Me.BarButtonItem5.Id = 20
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "&Books"
        Me.BarSubItem2.Id = 14
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BookCreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&View"
        Me.BarButtonItem3.Id = 18
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BookCreateBarButtonItem
        '
        Me.BookCreateBarButtonItem.Caption = "&Create"
        Me.BookCreateBarButtonItem.Id = 21
        Me.BookCreateBarButtonItem.Name = "BookCreateBarButtonItem"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "&Edit"
        Me.BarButtonItem7.Id = 22
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 3"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.FooterBarStaticItem)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Custom 3"
        '
        'FooterBarStaticItem
        '
        Me.FooterBarStaticItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.FooterBarStaticItem.Caption = "© My Library 2023"
        Me.FooterBarStaticItem.Id = 16
        Me.FooterBarStaticItem.Name = "FooterBarStaticItem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1106, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1106, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 581)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1106, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 581)
        '
        'BooksGridControl
        '
        Me.BooksGridControl.DataSource = Me.BookXpServerCollectionSource
        Me.BooksGridControl.Location = New System.Drawing.Point(12, 12)
        Me.BooksGridControl.MainView = Me.GridView1
        Me.BooksGridControl.MenuManager = Me.BarManager1
        Me.BooksGridControl.Name = "BooksGridControl"
        Me.BooksGridControl.Size = New System.Drawing.Size(1082, 258)
        Me.BooksGridControl.TabIndex = 5
        Me.BooksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BookXpServerCollectionSource
        '
        Me.BookXpServerCollectionSource.DisplayableProperties = "Title;Author;IsAvailable"
        Me.BookXpServerCollectionSource.ObjectType = GetType(library.Book)
        Me.BookXpServerCollectionSource.Session = Me.BooksUnitOfWork
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitle, Me.colAuthor, Me.colIsAvailable})
        Me.GridView1.GridControl = Me.BooksGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 0
        '
        'colAuthor
        '
        Me.colAuthor.FieldName = "Author"
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.Visible = True
        Me.colAuthor.VisibleIndex = 1
        '
        'colIsAvailable
        '
        Me.colIsAvailable.Caption = "Available"
        Me.colIsAvailable.FieldName = "IsAvailable"
        Me.colIsAvailable.Name = "colIsAvailable"
        Me.colIsAvailable.Visible = True
        Me.colIsAvailable.VisibleIndex = 2
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1106, 581)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.BooksGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1086, 262)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ReadersGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1086, 299)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 1
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.Text = "Custom 3"
        '
        'MainXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 623)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "MainXtraForm"
        Me.Text = "My Library"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReaderXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents FooterBarStaticItem As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BooksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BookXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents BooksUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ReadersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ReaderXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents ReadersUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReaderCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BookCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
End Class
