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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.loadingText = New System.Windows.Forms.Label()
        Me.reconnect = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(188, 102)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(422, 142)
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'loadingText
        '
        Me.loadingText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loadingText.BackColor = System.Drawing.Color.Transparent
        Me.loadingText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loadingText.Location = New System.Drawing.Point(188, 257)
        Me.loadingText.Name = "loadingText"
        Me.loadingText.Size = New System.Drawing.Size(422, 21)
        Me.loadingText.TabIndex = 1
        Me.loadingText.Text = "Initialize App..."
        Me.loadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reconnect
        '
        Me.reconnect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.reconnect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.reconnect.FlatAppearance.BorderSize = 0
        Me.reconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reconnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reconnect.Location = New System.Drawing.Point(341, 295)
        Me.reconnect.Name = "reconnect"
        Me.reconnect.Size = New System.Drawing.Size(105, 37)
        Me.reconnect.TabIndex = 2
        Me.reconnect.Text = "Reconnect"
        Me.reconnect.UseVisualStyleBackColor = False
        Me.reconnect.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 450)
        Me.Controls.Add(Me.reconnect)
        Me.Controls.Add(Me.loadingText)
        Me.Controls.Add(Me.logo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents loadingText As Label
    Friend WithEvents reconnect As Button
End Class
