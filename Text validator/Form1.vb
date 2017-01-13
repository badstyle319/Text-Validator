Public Class Form1

    Private Sub txtOne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOne.KeyPress, txtTwo.KeyPress
        Dim txt As TextBox = sender
        RecordString(txt)
        If e.KeyChar = ChrW(Keys.Return) Then
            If txt.BackColor = Color.DeepSkyBlue Then
                '----------------------
                'process you wanna do
                '----------------------
                Select Case txt.Name
                    Case "txtOne"

                    Case "txtTwo"

                End Select
                ClearString(txt)
            ElseIf txt.BackColor = Color.Red Then
                RestoreString(txt)
            End If
        End If
    End Sub
  
    Private Sub txtOne_TextChanged(sender As Object, e As EventArgs) Handles txtOne.TextChanged, txtTwo.TextChanged
        Dim txt As TextBox = sender
        Select Case txt.Name
            Case "txtOne"
                VerifyData(txt, True, False, Int16.MinValue, Int16.MaxValue)
            Case "txtTwo"
                VerifyData(txt, True, True, Single.MinValue, Single.MaxValue)
        End Select
    End Sub

    Private Sub txtOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOne.KeyDown, txtTwo.KeyDown
        If e.KeyValue = Keys.Delete Then
            RecordString(sender)
        End If
    End Sub

    Private Sub txtOne_Leave(sender As Object, e As EventArgs) Handles txtOne.Leave, txtTwo.Leave
        Dim txt As TextBox = sender
        If txt.BackColor <> Color.White Then
            RestoreString(txt)
        End If
        ClearString(txt)
    End Sub

End Class
