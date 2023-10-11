Imports DevExpress.Xpo

Public Class Book : Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _title As String

    Private _author As String

    Private _isAvailable As Boolean

    Property Title As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Title), _title, value)
        End Set
    End Property

    Property Author As String
        Get
            Return _author
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Author), _author, value)
        End Set
    End Property

    Property IsAvailable As Boolean
        Get
            Return _isAvailable
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(NameOf(IsAvailable), _isAvailable, value)
        End Set
    End Property

    <Association("Book-Borrowings")>
    Public ReadOnly Property Borrowings As XPCollection(Of Borrowing)
        Get
            Return GetCollection(Of Borrowing)("Borrowings")
        End Get
    End Property

End Class
