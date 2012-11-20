Public Class frmSplash
    Inherits System.Windows.Forms.Form
    Public MESSAGE As String
    Public TIMERON As Boolean = False

    Private Sub frmSplash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub frmProcess_FormClosing(ByVal sender As Object, _
            ByVal e As System.Windows.Forms.FormClosingEventArgs) _
            Handles Me.FormClosing
        Me.Timer1.Enabled = False
    End Sub
    Public Sub CloseIt()
        Me.Close()
        Me.Dispose()
    End Sub
    Public Overloads Sub ShowDialog(ByVal Mensaje As String)
        CheckForIllegalCrossThreadCalls = False
        Try
            TIMERON = True
            Me.Timer1.Enabled = True
           
            Me.ShowDialog()
        Catch
        End Try
    End Sub

    Public Sub stopForm()
        TIMERON = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If TIMERON = False Then
                Me.Close()
                Me.Timer1.Enabled = False
                Me.Dispose()
            End If
        Catch ex As Exception

        End Try


    End Sub

End Class