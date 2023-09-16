<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtStart = New Button()
        txtStop = New Button()
        txtClear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        txtIncrement = New TextBox()
        txtInterval = New TextBox()
        txtProgressBar1 = New Windows.Forms.ProgressBar()
        SuspendLayout()
        ' 
        ' txtStart
        ' 
        txtStart.Location = New Point(156, 205)
        txtStart.Name = "txtStart"
        txtStart.Size = New Size(112, 34)
        txtStart.TabIndex = 0
        txtStart.Text = "Start"
        txtStart.UseVisualStyleBackColor = True
        ' 
        ' txtStop
        ' 
        txtStop.Location = New Point(156, 271)
        txtStop.Name = "txtStop"
        txtStop.Size = New Size(112, 34)
        txtStop.TabIndex = 1
        txtStop.Text = "Stop"
        txtStop.UseVisualStyleBackColor = True
        ' 
        ' txtClear
        ' 
        txtClear.Location = New Point(156, 326)
        txtClear.Name = "txtClear"
        txtClear.Size = New Size(112, 34)
        txtClear.TabIndex = 2
        txtClear.Text = "Clear"
        txtClear.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(457, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 3
        Label1.Text = "Increment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(465, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 4
        Label2.Text = "Interval"
        ' 
        ' Timer1
        ' 
        ' 
        ' txtIncrement
        ' 
        txtIncrement.Location = New Point(576, 207)
        txtIncrement.Name = "txtIncrement"
        txtIncrement.Size = New Size(150, 31)
        txtIncrement.TabIndex = 5
        ' 
        ' txtInterval
        ' 
        txtInterval.Location = New Point(582, 280)
        txtInterval.Name = "txtInterval"
        txtInterval.Size = New Size(150, 31)
        txtInterval.TabIndex = 6
        ' 
        ' txtProgressBar1
        ' 
        txtProgressBar1.Location = New Point(12, 69)
        txtProgressBar1.Name = "txtProgressBar1"
        txtProgressBar1.Size = New Size(729, 80)
        txtProgressBar1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtProgressBar1)
        Controls.Add(txtInterval)
        Controls.Add(txtIncrement)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtClear)
        Controls.Add(txtStop)
        Controls.Add(txtStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStart As Button
    Friend WithEvents txtStop As Button
    Friend WithEvents txtClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtIncrement As TextBox
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents txtProgressBar1 As Windows.Forms.ProgressBar
End Class
