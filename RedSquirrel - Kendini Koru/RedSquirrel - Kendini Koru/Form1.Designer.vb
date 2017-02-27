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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnKorumaya_Al = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnKorumaya_Al
        '
        Me.btnKorumaya_Al.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKorumaya_Al.ForeColor = System.Drawing.Color.Red
        Me.btnKorumaya_Al.Location = New System.Drawing.Point(87, 55)
        Me.btnKorumaya_Al.Name = "btnKorumaya_Al"
        Me.btnKorumaya_Al.Size = New System.Drawing.Size(130, 55)
        Me.btnKorumaya_Al.TabIndex = 0
        Me.btnKorumaya_Al.Text = "Korumaya Al"
        Me.btnKorumaya_Al.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(319, 180)
        Me.Controls.Add(Me.btnKorumaya_Al)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hack4Sec.Net - Exe Koruma"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKorumaya_Al As Button
End Class
