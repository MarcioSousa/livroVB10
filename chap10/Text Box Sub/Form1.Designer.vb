<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtMkt = New System.Windows.Forms.TextBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblMkt = New System.Windows.Forms.Label()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnMkt = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(22, 45)
        Me.txtSales.Multiline = True
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSales.Size = New System.Drawing.Size(147, 104)
        Me.txtSales.TabIndex = 0
        Me.txtSales.TabStop = False
        '
        'txtMkt
        '
        Me.txtMkt.Location = New System.Drawing.Point(187, 45)
        Me.txtMkt.Multiline = True
        Me.txtMkt.Name = "txtMkt"
        Me.txtMkt.ReadOnly = True
        Me.txtMkt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMkt.Size = New System.Drawing.Size(147, 104)
        Me.txtMkt.TabIndex = 1
        Me.txtMkt.TabStop = False
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(21, 29)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(38, 13)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "Sales"
        '
        'lblMkt
        '
        Me.lblMkt.AutoSize = True
        Me.lblMkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMkt.Location = New System.Drawing.Point(186, 29)
        Me.lblMkt.Name = "lblMkt"
        Me.lblMkt.Size = New System.Drawing.Size(63, 13)
        Me.lblMkt.TabIndex = 3
        Me.lblMkt.Text = "Marketing"
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(50, 155)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(75, 23)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = "Add Name"
        '
        'btnMkt
        '
        Me.btnMkt.Location = New System.Drawing.Point(217, 155)
        Me.btnMkt.Name = "btnMkt"
        Me.btnMkt.Size = New System.Drawing.Size(75, 23)
        Me.btnMkt.TabIndex = 5
        Me.btnMkt.Text = "Add Name"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(136, 199)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 234)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMkt)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.lblMkt)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.txtMkt)
        Me.Controls.Add(Me.txtSales)
        Me.Name = "Form1"
        Me.Text = "Assign Department Teams "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents txtMkt As System.Windows.Forms.TextBox
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents lblMkt As System.Windows.Forms.Label
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnMkt As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
