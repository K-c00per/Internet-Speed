<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Internet_speed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Internet_speed))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(290, 53)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(330, 29)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.ForeColor = System.Drawing.Color.Olive
        Me.btnSpeed.Location = New System.Drawing.Point(335, 111)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(209, 47)
        Me.btnSpeed.TabIndex = 1
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.Location = New System.Drawing.Point(640, 85)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.Size = New System.Drawing.Size(98, 199)
        Me.lstInternetSpeed.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(563, 409)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 27)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(425, 458)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(243, 24)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Average Internet Speed: "
        Me.lblAverage.Visible = False
        '
        'Internet_speed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 533)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Internet_speed"
        Me.Text = "Internet Speed Test Surevy for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lstInternetSpeed As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAverage As Label
End Class
