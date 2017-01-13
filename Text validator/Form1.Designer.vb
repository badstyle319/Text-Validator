<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpSample = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.tlpSample.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSample
        '
        Me.tlpSample.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpSample.ColumnCount = 2
        Me.tlpSample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSample.Controls.Add(Me.lblOne, 0, 0)
        Me.tlpSample.Controls.Add(Me.lblTwo, 0, 1)
        Me.tlpSample.Controls.Add(Me.txtOne, 1, 0)
        Me.tlpSample.Controls.Add(Me.txtTwo, 1, 1)
        Me.tlpSample.Location = New System.Drawing.Point(12, 12)
        Me.tlpSample.Name = "tlpSample"
        Me.tlpSample.RowCount = 2
        Me.tlpSample.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSample.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSample.Size = New System.Drawing.Size(200, 59)
        Me.tlpSample.TabIndex = 0
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOne.Location = New System.Drawing.Point(4, 1)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(92, 28)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "Int16 value"
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTwo.Location = New System.Drawing.Point(4, 30)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(92, 28)
        Me.lblTwo.TabIndex = 1
        Me.lblTwo.Text = "Float value"
        Me.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOne
        '
        Me.txtOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOne.Location = New System.Drawing.Point(103, 4)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(93, 22)
        Me.txtOne.TabIndex = 2
        Me.txtOne.Text = "123"
        Me.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTwo
        '
        Me.txtTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTwo.Location = New System.Drawing.Point(103, 33)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(93, 22)
        Me.txtTwo.TabIndex = 3
        Me.txtTwo.Text = "1.23"
        Me.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 83)
        Me.Controls.Add(Me.tlpSample)
        Me.Name = "Form1"
        Me.Text = "Text validator"
        Me.tlpSample.ResumeLayout(False)
        Me.tlpSample.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSample As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox

End Class
