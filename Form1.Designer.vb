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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.lblfinalprice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weekly Pay Calc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rate"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(189, 293)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(56, 22)
        Me.lbltotal.TabIndex = 3
        Me.lbltotal.Text = "XXXXX"
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(189, 130)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(125, 27)
        Me.txthours.TabIndex = 4
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(189, 193)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(125, 27)
        Me.txtrate.TabIndex = 5
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(309, 289)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(94, 29)
        Me.btncalc.TabIndex = 6
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(782, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Discount Applier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(596, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(596, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Discount?"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(746, 134)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(125, 27)
        Me.txtprice.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(792, 203)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(596, 270)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(94, 29)
        Me.btnstart.TabIndex = 13
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'lblfinalprice
        '
        Me.lblfinalprice.AutoSize = True
        Me.lblfinalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfinalprice.Location = New System.Drawing.Point(782, 274)
        Me.lblfinalprice.Name = "lblfinalprice"
        Me.lblfinalprice.Size = New System.Drawing.Size(56, 22)
        Me.lblfinalprice.TabIndex = 14
        Me.lblfinalprice.Text = "XXXXX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 584)
        Me.Controls.Add(Me.lblfinalprice)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Utter Rubbish"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txthours As TextBox
    Friend WithEvents txtrate As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnstart As Button
    Friend WithEvents lblfinalprice As Label
End Class
