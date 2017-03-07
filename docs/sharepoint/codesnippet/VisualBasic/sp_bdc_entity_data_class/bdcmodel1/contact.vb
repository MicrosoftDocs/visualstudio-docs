'<Snippet1>
Partial Public Class Contact

    Private _ContactID As Integer
    Public Property ContactID() As Integer
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Integer)
            _ContactID = value
        End Set
    End Property
    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property
    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property
    Private _EmailAddress As String
    Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property
    Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
    Private _EmailPromotion As Integer
    Public Property EmailPromotion() As Integer
        Get
            Return _EmailPromotion
        End Get
        Set(ByVal value As Integer)
            _EmailPromotion = value
        End Set
    End Property
    Private _NameStyle As Boolean
    Public Property NameStyle() As Boolean
        Get
            Return _NameStyle
        End Get
        Set(ByVal value As Boolean)
            _NameStyle = value
        End Set
    End Property
    Private _PasswordHash As String
    Public Property PasswordHash() As String
        Get
            Return _PasswordHash
        End Get
        Set(ByVal value As String)
            _PasswordHash = value
        End Set
    End Property
    Private _PasswordSalt As String
    Public Property PasswordSalt() As String
        Get
            Return _PasswordSalt
        End Get
        Set(ByVal value As String)
            _PasswordSalt = value
        End Set
    End Property

End Class
'</Snippet1>
