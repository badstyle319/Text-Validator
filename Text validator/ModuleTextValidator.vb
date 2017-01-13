Imports System.Text.RegularExpressions

Module ModuleTextValidator
    Dim DEFAULT_COLOR As Color = Color.White
    Dim CHANGE_COLOR As Color = Color.DeepSkyBlue
    Dim FAULT_COLOR As Color = Color.Red
    Dim OrigStr As String = Nothing
    Sub RecordString(sender As Object)
        If String.IsNullOrEmpty(OrigStr) Then
            If TypeOf sender Is TextBox Then
                OrigStr = CType(sender, TextBox).Text
            ElseIf TypeOf sender Is ToolStripTextBox Then
                OrigStr = CType(sender, ToolStripTextBox).Text
            ElseIf TypeOf sender Is ComboBox Then
                OrigStr = CType(sender, ComboBox).Text
            End If
        End If
    End Sub
    Sub RestoreString(sender As Object)
        If Not String.IsNullOrEmpty(OrigStr) Then
            sender.Text = OrigStr
        End If
        ClearString(sender)
    End Sub
    Sub ClearString(sender As Object)
        OrigStr = Nothing
        sender.BackColor = DEFAULT_COLOR
    End Sub
    Sub VerifyData(sender As Object, minus As Boolean, dot As Boolean, Optional minValue As Object = Nothing, Optional maxValue As Object = Nothing, Optional closed As Boolean = True)
        Dim txt As Object = Nothing
        If TypeOf sender Is TextBox Then
            txt = CType(sender, TextBox)
        ElseIf TypeOf sender Is ToolStripTextBox Then
            txt = CType(sender, ToolStripTextBox)
        End If

        If IsNothing(txt) Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(OrigStr) Then
            Exit Sub
        End If

        If OrigStr = txt.Text Then
            txt.BackColor = DEFAULT_COLOR
            Exit Sub
        End If

        Dim pattern As String = "^"
        If minus Then
            pattern &= "-?"
        End If
        pattern &= "\d+"
        If dot Then
            pattern &= "(\.\d+)?"
        End If
        pattern &= "(E{1}[+-]{1}\d+)?"
        pattern &= "$"
        If Regex.IsMatch(txt.Text, pattern) Then
            Dim val As Object = Convert.ToDouble(txt.Text)
            If Not IsNothing(minValue) AndAlso Not IsNothing(maxValue) Then
                If closed Then
                    If val < minValue OrElse val > maxValue Then
                        txt.BackColor = FAULT_COLOR
                        Exit Sub
                    End If
                Else
                    If val <= minValue OrElse val >= maxValue Then
                        txt.BackColor = FAULT_COLOR
                        Exit Sub
                    End If
                End If
            Else
                'these can not handle all field perfectly
                If dot Then
                    If val < Single.MinValue OrElse val > Single.MaxValue Then
                        txt.BackColor = FAULT_COLOR
                        Exit Sub
                    End If
                Else
                    If val < Integer.MinValue OrElse val > Integer.MaxValue Then
                        txt.BackColor = FAULT_COLOR
                        Exit Sub
                    End If
                End If
            End If
            txt.BackColor = CHANGE_COLOR
        Else
            txt.BackColor = FAULT_COLOR
        End If
    End Sub
End Module
