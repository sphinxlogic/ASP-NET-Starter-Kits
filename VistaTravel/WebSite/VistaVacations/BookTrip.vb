Imports System
Imports System.Collections
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports Microsoft.VisualBasic

Namespace VistaVacations

    Public Class BookTrip
        Inherits System.Web.UI.Page

        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then   ' Evals true first time browser hits the page	
            End If
        End Sub

        Overrides Protected Sub Init()
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent
        End Sub

        'CODEGEN: This procedure is required by the Web Form Designer
        'Do not modify it using the code editor.
        Private Sub InitializeComponent() 



        End Sub

    End Class

End Namespace
