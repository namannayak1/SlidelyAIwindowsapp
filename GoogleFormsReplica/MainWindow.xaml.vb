Imports System.Windows

Namespace GoogleFormsReplica
    Public Class MainWindow
        Public Sub New()
            InitializeComponent()
            AddHandler Me.KeyDown, AddressOf MainWindow_KeyDown
        End Sub

        Private Sub btnViewSubmissions_Click(sender As Object, e As RoutedEventArgs)
            Dim viewSubmissionsWindow As New ViewSubmissionsWindow()
            viewSubmissionsWindow.ShowDialog()
        End Sub

        Private Sub btnCreateNewSubmission_Click(sender As Object, e As RoutedEventArgs)
            Dim createSubmissionWindow As New CreateSubmissionWindow()
            createSubmissionWindow.ShowDialog()
        End Sub

        Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs)
            If Keyboard.IsKeyDown(Key.LeftCtrl) AndAlso e.Key = Key.V Then
                btnViewSubmissions.RaiseEvent(New RoutedEventArgs(Button.ClickEvent))
            ElseIf Keyboard.IsKeyDown(Key.LeftCtrl) AndAlso e.Key = Key.N Then
                btnCreateNewSubmission.RaiseEvent(New RoutedEventArgs(Button.ClickEvent))
            End If
        End Sub
    End Class
End Namespace
