Imports System.Windows

Namespace GoogleFormsReplica
    Public Class ViewSubmissionsWindow
        Private currentSubmissionIndex As Integer
        Private submissions As List(Of Submission)

        Public Sub New()
            InitializeComponent()
            ' Load the submissions (replace with actual data loading logic)
            submissions = LoadSubmissions()
            currentSubmissionIndex = 0
            DisplaySubmission(currentSubmissionIndex)
        End Sub

        Private Function LoadSubmissions() As List(Of Submission)
            ' This function should return the list of submissions. Replace with actual data.
            Return New List(Of Submission) From {
                New Submission With {
                    .Name = "John Doe",
                    .Email = "johndoe@gmail.com",
                    .PhoneNumber = "9876543210",
                    .GithubLink = "https://github.com/john_doe/my_slidely_task/",
                    .StopwatchTime = "00:01:19"
                }
            }
        End Function

        Private Sub DisplaySubmission(index As Integer)
            If index >= 0 AndAlso index < submissions.Count Then
                txtName.Text = submissions(index).Name
                txtEmail.Text = submissions(index).Email
                txtPhoneNumber.Text = submissions(index).PhoneNumber
                txtGithubLink.Text = submissions(index).GithubLink
                txtStopwatchTime.Text = submissions(index).StopwatchTime
            End If
        End Sub

        Private Sub btnPrevious_Click(sender As Object, e As RoutedEventArgs)
            If currentSubmissionIndex > 0 Then
                currentSubmissionIndex -= 1
                DisplaySubmission(currentSubmissionIndex)
            End If
        End Sub

        Private Sub btnNext_Click(sender As Object, e As RoutedEventArgs)
            If currentSubmissionIndex < submissions.Count - 1 Then
                currentSubmissionIndex += 1
                DisplaySubmission(currentSubmissionIndex)
            End If
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
