'
' Created by SharpDevelop.
' User: Christopher
' Date: 14/02/2019
' Time: 09:46 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.textBoxR11 = New System.Windows.Forms.TextBox()
		Me.textBoxR10 = New System.Windows.Forms.TextBox()
		Me.textBoxR01 = New System.Windows.Forms.TextBox()
		Me.textBoxR00 = New System.Windows.Forms.TextBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.buttonSumar = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.textBoxA11 = New System.Windows.Forms.TextBox()
		Me.textBoxA10 = New System.Windows.Forms.TextBox()
		Me.textBoxA01 = New System.Windows.Forms.TextBox()
		Me.textBoxA00 = New System.Windows.Forms.TextBox()
		Me.groupBox4.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(161, 93)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(30, 23)
		Me.label1.TabIndex = 19
		Me.label1.Text = "="
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.textBoxR11)
		Me.groupBox4.Controls.Add(Me.textBoxR10)
		Me.groupBox4.Controls.Add(Me.textBoxR01)
		Me.groupBox4.Controls.Add(Me.textBoxR00)
		Me.groupBox4.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox4.Location = New System.Drawing.Point(197, 41)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(142, 125)
		Me.groupBox4.TabIndex = 18
		Me.groupBox4.TabStop = false
		Me.groupBox4.Text = "Inversa"
		'
		'textBoxR11
		'
		Me.textBoxR11.BackColor = System.Drawing.SystemColors.ControlLight
		Me.textBoxR11.ForeColor = System.Drawing.SystemColors.InfoText
		Me.textBoxR11.Location = New System.Drawing.Point(74, 74)
		Me.textBoxR11.Name = "textBoxR11"
		Me.textBoxR11.Size = New System.Drawing.Size(62, 26)
		Me.textBoxR11.TabIndex = 4
		'
		'textBoxR10
		'
		Me.textBoxR10.BackColor = System.Drawing.SystemColors.ControlLight
		Me.textBoxR10.ForeColor = System.Drawing.SystemColors.InfoText
		Me.textBoxR10.Location = New System.Drawing.Point(6, 74)
		Me.textBoxR10.Name = "textBoxR10"
		Me.textBoxR10.Size = New System.Drawing.Size(62, 26)
		Me.textBoxR10.TabIndex = 3
		'
		'textBoxR01
		'
		Me.textBoxR01.BackColor = System.Drawing.SystemColors.ControlLight
		Me.textBoxR01.ForeColor = System.Drawing.SystemColors.InfoText
		Me.textBoxR01.Location = New System.Drawing.Point(74, 26)
		Me.textBoxR01.Name = "textBoxR01"
		Me.textBoxR01.Size = New System.Drawing.Size(62, 26)
		Me.textBoxR01.TabIndex = 1
		'
		'textBoxR00
		'
		Me.textBoxR00.BackColor = System.Drawing.SystemColors.ControlLight
		Me.textBoxR00.ForeColor = System.Drawing.SystemColors.InfoText
		Me.textBoxR00.Location = New System.Drawing.Point(6, 26)
		Me.textBoxR00.Name = "textBoxR00"
		Me.textBoxR00.Size = New System.Drawing.Size(62, 26)
		Me.textBoxR00.TabIndex = 0
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(364, 115)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(93, 33)
		Me.button2.TabIndex = 17
		Me.button2.Text = "salir"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'buttonSumar
		'
		Me.buttonSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonSumar.Location = New System.Drawing.Point(364, 61)
		Me.buttonSumar.Name = "buttonSumar"
		Me.buttonSumar.Size = New System.Drawing.Size(93, 32)
		Me.buttonSumar.TabIndex = 16
		Me.buttonSumar.Text = "Calcular"
		Me.buttonSumar.UseVisualStyleBackColor = true
		AddHandler Me.buttonSumar.Click, AddressOf Me.ButtonSumarClick
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.textBoxA11)
		Me.groupBox1.Controls.Add(Me.textBoxA10)
		Me.groupBox1.Controls.Add(Me.textBoxA01)
		Me.groupBox1.Controls.Add(Me.textBoxA00)
		Me.groupBox1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(24, 41)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(120, 125)
		Me.groupBox1.TabIndex = 14
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Matriz A"
		'
		'textBoxA11
		'
		Me.textBoxA11.Location = New System.Drawing.Point(58, 74)
		Me.textBoxA11.Name = "textBoxA11"
		Me.textBoxA11.Size = New System.Drawing.Size(39, 26)
		Me.textBoxA11.TabIndex = 4
		'
		'textBoxA10
		'
		Me.textBoxA10.Location = New System.Drawing.Point(6, 74)
		Me.textBoxA10.Name = "textBoxA10"
		Me.textBoxA10.Size = New System.Drawing.Size(36, 26)
		Me.textBoxA10.TabIndex = 3
		'
		'textBoxA01
		'
		Me.textBoxA01.Location = New System.Drawing.Point(58, 26)
		Me.textBoxA01.Name = "textBoxA01"
		Me.textBoxA01.Size = New System.Drawing.Size(39, 26)
		Me.textBoxA01.TabIndex = 1
		'
		'textBoxA00
		'
		Me.textBoxA00.Location = New System.Drawing.Point(6, 26)
		Me.textBoxA00.Name = "textBoxA00"
		Me.textBoxA00.Size = New System.Drawing.Size(36, 26)
		Me.textBoxA00.TabIndex = 0
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 181)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.groupBox4)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.buttonSumar)
		Me.Controls.Add(Me.groupBox1)
		Me.Name = "MainForm"
		Me.Text = "InversaM"
		Me.groupBox4.ResumeLayout(false)
		Me.groupBox4.PerformLayout
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private textBoxA00 As System.Windows.Forms.TextBox
	Private textBoxA01 As System.Windows.Forms.TextBox
	Private textBoxA10 As System.Windows.Forms.TextBox
	Private textBoxA11 As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private buttonSumar As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private textBoxR00 As System.Windows.Forms.TextBox
	Private textBoxR01 As System.Windows.Forms.TextBox
	Private textBoxR10 As System.Windows.Forms.TextBox
	Private textBoxR11 As System.Windows.Forms.TextBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private label1 As System.Windows.Forms.Label
End Class
