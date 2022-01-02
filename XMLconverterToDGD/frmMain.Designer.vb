<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.dgd = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnGetInt = New System.Windows.Forms.Button()
        Me.btnGetString = New System.Windows.Forms.Button()
        CType(Me.dgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgd
        '
        Me.dgd.AllowUserToAddRows = False
        Me.dgd.AllowUserToDeleteRows = False
        Me.dgd.AllowUserToResizeColumns = False
        Me.dgd.AllowUserToResizeRows = False
        Me.dgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgd.Location = New System.Drawing.Point(0, 29)
        Me.dgd.Name = "dgd"
        Me.dgd.Size = New System.Drawing.Size(584, 382)
        Me.dgd.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLoad)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGetInt)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGetString)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(584, 29)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.AutoSize = True
        Me.btnLoad.Location = New System.Drawing.Point(3, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(103, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "WczytajDataGrida"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnGetInt
        '
        Me.btnGetInt.AutoSize = True
        Me.btnGetInt.Location = New System.Drawing.Point(112, 3)
        Me.btnGetInt.Name = "btnGetInt"
        Me.btnGetInt.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInt.TabIndex = 1
        Me.btnGetInt.Text = "Wczytaj Int"
        Me.btnGetInt.UseVisualStyleBackColor = True
        '
        'btnGetString
        '
        Me.btnGetString.AutoSize = True
        Me.btnGetString.Location = New System.Drawing.Point(193, 3)
        Me.btnGetString.Name = "btnGetString"
        Me.btnGetString.Size = New System.Drawing.Size(83, 23)
        Me.btnGetString.TabIndex = 2
        Me.btnGetString.Text = "Wczytaj string"
        Me.btnGetString.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.dgd)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.dgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgd As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnGetInt As Button
    Friend WithEvents btnGetString As Button
End Class
