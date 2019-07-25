Public Class Form1
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlStats.Top = btnDashboard.Top
        pnlStats.Height = btnDashboard.Height
        pnlDashboard.Visible = True
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        pnlStats.Top = btnCalendar.Top
        pnlStats.Height = btnCalendar.Height
        pnlDashboard.Visible = False
    End Sub

    Private Sub btnAnnouncement_Click(sender As Object, e As EventArgs) Handles btnAnnouncement.Click
        pnlStats.Top = btnAnnouncement.Top
        pnlStats.Height = btnAnnouncement.Height
        pnlDashboard.Visible = False
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        pnlStats.Top = btnCourses.Top
        pnlStats.Height = btnCourses.Height
        pnlDashboard.Visible = False
    End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        pnlStats.Top = btnMessages.Top
        pnlStats.Height = btnMessages.Height
        pnlDashboard.Visible = False
    End Sub

    Private Sub btnForum_Click(sender As Object, e As EventArgs) Handles btnForum.Click
        pnlStats.Top = btnForum.Top
        pnlStats.Height = btnForum.Height
        pnlDashboard.Visible = False
    End Sub
End Class
