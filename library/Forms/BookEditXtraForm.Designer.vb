<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookEditXtraForm
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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TitleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.OkSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.IsAvailableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AuthorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.IsAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(748, 318)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TitleTextEdit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem1.Text = "Title"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(33, 13)
        '
        'TitleTextEdit
        '
        Me.TitleTextEdit.Location = New System.Drawing.Point(57, 12)
        Me.TitleTextEdit.Name = "TitleTextEdit"
        Me.TitleTextEdit.Properties.AdvancedModeOptions.Label = "Title"
        Me.TitleTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TitleTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = True
        Me.TitleTextEdit.Size = New System.Drawing.Size(679, 20)
        Me.TitleTextEdit.StyleController = Me.LayoutControl1
        Me.TitleTextEdit.TabIndex = 4
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.OkSimpleButton)
        Me.LayoutControl1.Controls.Add(Me.CancelSimpleButton)
        Me.LayoutControl1.Controls.Add(Me.IsAvailableCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.AuthorTextEdit)
        Me.LayoutControl1.Controls.Add(Me.TitleTextEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 318)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'OkSimpleButton
        '
        Me.OkSimpleButton.Location = New System.Drawing.Point(12, 84)
        Me.OkSimpleButton.Name = "OkSimpleButton"
        Me.OkSimpleButton.Size = New System.Drawing.Size(360, 22)
        Me.OkSimpleButton.StyleController = Me.LayoutControl1
        Me.OkSimpleButton.TabIndex = 7
        Me.OkSimpleButton.Text = "OK"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Location = New System.Drawing.Point(376, 84)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(360, 22)
        Me.CancelSimpleButton.StyleController = Me.LayoutControl1
        Me.CancelSimpleButton.TabIndex = 8
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'IsAvailableCheckEdit
        '
        Me.IsAvailableCheckEdit.Location = New System.Drawing.Point(12, 60)
        Me.IsAvailableCheckEdit.Name = "IsAvailableCheckEdit"
        Me.IsAvailableCheckEdit.Properties.Caption = "Is Available"
        Me.IsAvailableCheckEdit.Size = New System.Drawing.Size(724, 20)
        Me.IsAvailableCheckEdit.StyleController = Me.LayoutControl1
        Me.IsAvailableCheckEdit.TabIndex = 6
        '
        'AuthorTextEdit
        '
        Me.AuthorTextEdit.Location = New System.Drawing.Point(57, 36)
        Me.AuthorTextEdit.Name = "AuthorTextEdit"
        Me.AuthorTextEdit.Size = New System.Drawing.Size(679, 20)
        Me.AuthorTextEdit.StyleController = Me.LayoutControl1
        Me.AuthorTextEdit.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.AuthorTextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem2.Text = "Author"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(33, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.IsAvailableCheckEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.OkSimpleButton
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(364, 226)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CancelSimpleButton
        Me.LayoutControlItem5.Location = New System.Drawing.Point(364, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(364, 226)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'BookEditXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "BookEditXtraForm"
        Me.Text = "Edit Book"
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.IsAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TitleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AuthorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsAvailableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OkSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
