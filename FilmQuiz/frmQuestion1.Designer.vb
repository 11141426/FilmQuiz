<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion1))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarQ1 = New System.Windows.Forms.ProgressBar()
        Me.tmrQuestion1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(794, 406)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(137, 49)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(15, 20)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(82, 29)
        Me.btnAnswer1.TabIndex = 1
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "1920"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(15, 57)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(82, 29)
        Me.btnAnswer2.TabIndex = 2
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "1929"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(15, 88)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(82, 29)
        Me.btnAnswer3.TabIndex = 3
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "1931"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(15, 127)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(82, 29)
        Me.btnAnswer4.TabIndex = 4
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "1935"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(754, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(312, 30)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(448, 25)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "In What Year Was Audrey Hepburn Born?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Location = New System.Drawing.Point(337, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 188)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'ProgressBarQ1
        '
        Me.ProgressBarQ1.Location = New System.Drawing.Point(191, 380)
        Me.ProgressBarQ1.Name = "ProgressBarQ1"
        Me.ProgressBarQ1.Size = New System.Drawing.Size(519, 61)
        Me.ProgressBarQ1.TabIndex = 9
        '
        'tmrQuestion1
        '
        Me.tmrQuestion1.Interval = 1000
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 470)
        Me.Controls.Add(Me.ProgressBarQ1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmQuestion1"
        Me.Text = "frmQuestion1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBarQ1 As ProgressBar
    Friend WithEvents tmrQuestion1 As Timer
End Class
