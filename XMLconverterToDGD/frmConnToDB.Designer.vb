<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnToDB
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(108, 32)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(178, 22)
        Me.txtServer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Połącz się z bazą danych"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Database"
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(108, 60)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(178, 22)
        Me.txtDB.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(108, 88)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(178, 22)
        Me.txtUser.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(108, 116)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(178, 22)
        Me.txtPasswd.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 149)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(304, 30)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Połącz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmConnToDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 179)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnToDB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Utwórz połączenie z bazą danych"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
