<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ASD
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASD))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HotKeyPress = New System.Windows.Forms.Timer(Me.components)
        Me.Key1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttm1 = New System.Windows.Forms.TextBox()
        Me.txttm2 = New System.Windows.Forms.TextBox()
        Me.txttm3 = New System.Windows.Forms.TextBox()
        Me.txttm4 = New System.Windows.Forms.TextBox()
        Me.txttm5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbm3 = New System.Windows.Forms.RadioButton()
        Me.rdbm2 = New System.Windows.Forms.RadioButton()
        Me.rdbm1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-6, -9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 61)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "DR Script"
        '
        'HotKeyPress
        '
        Me.HotKeyPress.Enabled = True
        Me.HotKeyPress.Interval = 10
        '
        'Key1
        '
        Me.Key1.DropDownHeight = 250
        Me.Key1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Key1.DropDownWidth = 100
        Me.Key1.FormattingEnabled = True
        Me.Key1.IntegralHeight = False
        Me.Key1.ItemHeight = 21
        Me.Key1.Items.AddRange(New Object() {"滑鼠側鍵2", "滑鼠側鍵1", "滑鼠中鍵", "T", "B", "V"})
        Me.Key1.Location = New System.Drawing.Point(16, 154)
        Me.Key1.MaxDropDownItems = 5
        Me.Key1.Name = "Key1"
        Me.Key1.Size = New System.Drawing.Size(157, 29)
        Me.Key1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "熱鍵"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 42)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "超級可移動極道滅殺腳本 v1.0   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "免費"
        '
        'txttm1
        '
        Me.txttm1.Location = New System.Drawing.Point(261, 60)
        Me.txttm1.Name = "txttm1"
        Me.txttm1.Size = New System.Drawing.Size(100, 29)
        Me.txttm1.TabIndex = 157
        Me.txttm1.Text = "150"
        '
        'txttm2
        '
        Me.txttm2.Location = New System.Drawing.Point(261, 95)
        Me.txttm2.Name = "txttm2"
        Me.txttm2.Size = New System.Drawing.Size(100, 29)
        Me.txttm2.TabIndex = 158
        Me.txttm2.Text = "530"
        '
        'txttm3
        '
        Me.txttm3.Location = New System.Drawing.Point(261, 130)
        Me.txttm3.Name = "txttm3"
        Me.txttm3.Size = New System.Drawing.Size(100, 29)
        Me.txttm3.TabIndex = 159
        Me.txttm3.Text = "10"
        '
        'txttm4
        '
        Me.txttm4.Location = New System.Drawing.Point(261, 165)
        Me.txttm4.Name = "txttm4"
        Me.txttm4.Size = New System.Drawing.Size(100, 29)
        Me.txttm4.TabIndex = 160
        Me.txttm4.Text = "50"
        '
        'txttm5
        '
        Me.txttm5.Location = New System.Drawing.Point(261, 200)
        Me.txttm5.Name = "txttm5"
        Me.txttm5.Size = New System.Drawing.Size(100, 29)
        Me.txttm5.TabIndex = 161
        Me.txttm5.Text = "50"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(261, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 162
        Me.Button1.Text = "重設"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Checked = True
        Me.rdb1.Location = New System.Drawing.Point(5, 19)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(60, 25)
        Me.rdb1.TabIndex = 163
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "按住"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Location = New System.Drawing.Point(58, 19)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(60, 25)
        Me.rdb2.TabIndex = 164
        Me.rdb2.Text = "開關"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb2)
        Me.GroupBox1.Controls.Add(Me.rdb1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(49, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox1.TabIndex = 165
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbm3)
        Me.GroupBox2.Controls.Add(Me.rdbm2)
        Me.GroupBox2.Controls.Add(Me.rdbm1)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 55)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        '
        'rdbm3
        '
        Me.rdbm3.AutoSize = True
        Me.rdbm3.Location = New System.Drawing.Point(157, 18)
        Me.rdbm3.Name = "rdbm3"
        Me.rdbm3.Size = New System.Drawing.Size(76, 25)
        Me.rdbm3.TabIndex = 168
        Me.rdbm3.Text = "模式三"
        Me.rdbm3.UseVisualStyleBackColor = True
        '
        'rdbm2
        '
        Me.rdbm2.AutoSize = True
        Me.rdbm2.ForeColor = System.Drawing.Color.Black
        Me.rdbm2.Location = New System.Drawing.Point(81, 18)
        Me.rdbm2.Name = "rdbm2"
        Me.rdbm2.Size = New System.Drawing.Size(76, 25)
        Me.rdbm2.TabIndex = 166
        Me.rdbm2.Text = "模式二"
        Me.rdbm2.UseVisualStyleBackColor = True
        '
        'rdbm1
        '
        Me.rdbm1.AutoSize = True
        Me.rdbm1.Checked = True
        Me.rdbm1.ForeColor = System.Drawing.Color.Black
        Me.rdbm1.Location = New System.Drawing.Point(6, 18)
        Me.rdbm1.Name = "rdbm1"
        Me.rdbm1.Size = New System.Drawing.Size(76, 25)
        Me.rdbm1.TabIndex = 165
        Me.rdbm1.TabStop = True
        Me.rdbm1.Text = "模式一"
        Me.rdbm1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 167
        Me.Button2.Text = "模式說明"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ASD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(741, 480)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Key1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttm5)
        Me.Controls.Add(Me.txttm4)
        Me.Controls.Add(Me.txttm3)
        Me.Controls.Add(Me.txttm2)
        Me.Controls.Add(Me.txttm1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.MaximizeBox = False
        Me.Name = "ASD"
        Me.Text = "ASD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents HotKeyPress As Timer
    Friend WithEvents Key1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttm1 As TextBox
    Friend WithEvents txttm2 As TextBox
    Friend WithEvents txttm3 As TextBox
    Friend WithEvents txttm4 As TextBox
    Friend WithEvents txttm5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents rdb1 As RadioButton
    Friend WithEvents rdb2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbm2 As RadioButton
    Friend WithEvents rdbm1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents rdbm3 As RadioButton
End Class
