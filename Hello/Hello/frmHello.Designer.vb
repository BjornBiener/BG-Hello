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
        Me.grpHello = New System.Windows.Forms.GroupBox()
        Me.pnlHello = New System.Windows.Forms.Panel()
        Me.grHello = New System.Windows.Forms.DataGridView()
        Me.grpHello.SuspendLayout()
        Me.pnlHello.SuspendLayout()
        CType(Me.grHello, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpHello
        '
        Me.grpHello.Controls.Add(Me.pnlHello)
        Me.grpHello.Location = New System.Drawing.Point(56, 101)
        Me.grpHello.Name = "grpHello"
        Me.grpHello.Size = New System.Drawing.Size(763, 609)
        Me.grpHello.TabIndex = 0
        Me.grpHello.TabStop = False
        Me.grpHello.Text = "BG"
        '
        'pnlHello
        '
        Me.pnlHello.Controls.Add(Me.grHello)
        Me.pnlHello.Location = New System.Drawing.Point(44, 64)
        Me.pnlHello.Name = "pnlHello"
        Me.pnlHello.Size = New System.Drawing.Size(644, 509)
        Me.pnlHello.TabIndex = 0
        '
        'grHello
        '
        Me.grHello.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grHello.Location = New System.Drawing.Point(34, 108)
        Me.grHello.Name = "grHello"
        Me.grHello.RowTemplate.Height = 28
        Me.grHello.Size = New System.Drawing.Size(542, 289)
        Me.grHello.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 772)
        Me.Controls.Add(Me.grpHello)
        Me.Name = "Form1"
        Me.Text = "frmHello"
        Me.grpHello.ResumeLayout(False)
        Me.pnlHello.ResumeLayout(False)
        CType(Me.grHello, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpHello As GroupBox
    Friend WithEvents pnlHello As Panel
    Friend WithEvents grHello As DataGridView
End Class
