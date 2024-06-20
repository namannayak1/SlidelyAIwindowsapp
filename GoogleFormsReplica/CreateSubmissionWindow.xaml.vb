Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Threading

Namespace GoogleFormsReplica
    Public Class CreateSubmissionWindow
        Private timer As DispatcherTimer
        Private stopwatchTime As TimeSpan

        Public Sub New()
            InitializeComponent()
            timer = New DispatcherTimer()
            timer.Interval = TimeSpan.FromSeconds(1)
            AddHandler timer.Tick, AddressOf Timer_Tick
        End Sub

        Private Sub Timer_Tick(sender As Object, e As EventArgs)
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
            txtStopwatchTime.Text = stopwatchTime.ToString("hh\:mm\:ss")
        End Sub

        Private Sub btnToggleStopwatch_Click(sender As Object, e As RoutedEventArgs)
            If timer.IsEnabled Then
                timer.Stop()
            Else
                timer.Start()
            End If
        End Sub

        Private Sub btnSubmit_Click(sender As Object, e As RoutedEventArgs)
            Dim submission As New Submission With {
                .Name = txtName.Text,
                .Email = txtEmail.Text,
                .PhoneNumber = txtPhoneNumber.Text,
                .GithubLink = txtGithubLink.Text,
                .StopwatchTime = txtStopwatchTime.Text
            }

            ' Logic to save the submission (e.g., to a file, database, etc.)
            SaveSubmission(submission)

            MessageBox.Show("Submission Successful!")
            Me.Close()
        End Sub

        Private Sub SaveSubmission(submission As Submission)
            ' Implement the logic to save the submission
        End Sub

        Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
            If e.KeyboardDevice.Modifiers = ModifierKeys.Control Then
                Select Case e.Key
                    Case Key.T
                        btnToggleStopwatch_Click(sender, e)
                    Case Key.S
                        btnSubmit_Click(sender, e)
                End Select
            End If
        End Sub

        Private Sub txtName_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtName.TextChanged

        End Sub
    End Class

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class
End Namespace
