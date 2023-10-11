Imports DevExpress.Xpo

Module DataManipulation

    Function GetAllBooks() As XPCollection(Of Book)
        Using uow As New UnitOfWork

            Return New XPCollection(Of Book)

        End Using
    End Function

    Function GetAllReaders() As XPCollection(Of Reader)
        Using uow As New UnitOfWork

            Return New XPCollection(Of Reader)

        End Using
    End Function

End Module
