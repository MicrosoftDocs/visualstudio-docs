Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString("ReturnUrl")
    End Sub

    Protected Sub RegisterUser_CreatedUser(ByVal sender As Object, ByVal e As EventArgs) Handles RegisterUser.CreatedUser
        FormsAuthentication.SetAuthCookie(RegisterUser.UserName, False)

        Dim continueUrl As String = RegisterUser.ContinueDestinationPageUrl
        If String.IsNullOrEmpty(continueUrl) Then
            continueUrl = "~/"
        End If

        Response.Redirect(continueUrl)
    End Sub
End Class