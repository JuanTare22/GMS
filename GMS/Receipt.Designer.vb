<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receipt
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtImg1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtImg2 = New System.Windows.Forms.TextBox()
        Me.txtImg3 = New System.Windows.Forms.TextBox()
        Me.txtImg4 = New System.Windows.Forms.TextBox()
        Me.txtqty1 = New System.Windows.Forms.TextBox()
        Me.txtqty4 = New System.Windows.Forms.TextBox()
        Me.txtqty3 = New System.Windows.Forms.TextBox()
        Me.txtqty2 = New System.Windows.Forms.TextBox()
        Me.txtctrlno = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(49, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(268, 20)
        Me.txtName.TabIndex = 0
        '
        'txtImg1
        '
        Me.txtImg1.Location = New System.Drawing.Point(49, 56)
        Me.txtImg1.Name = "txtImg1"
        Me.txtImg1.Size = New System.Drawing.Size(100, 20)
        Me.txtImg1.TabIndex = 1
        Me.txtImg1.Text = "N/A"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 94)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtImg2
        '
        Me.txtImg2.Location = New System.Drawing.Point(49, 82)
        Me.txtImg2.Name = "txtImg2"
        Me.txtImg2.Size = New System.Drawing.Size(100, 20)
        Me.txtImg2.TabIndex = 3
        Me.txtImg2.Text = "N/A"
        '
        'txtImg3
        '
        Me.txtImg3.Location = New System.Drawing.Point(49, 108)
        Me.txtImg3.Name = "txtImg3"
        Me.txtImg3.Size = New System.Drawing.Size(100, 20)
        Me.txtImg3.TabIndex = 4
        Me.txtImg3.Text = "N/A"
        '
        'txtImg4
        '
        Me.txtImg4.Location = New System.Drawing.Point(49, 134)
        Me.txtImg4.Name = "txtImg4"
        Me.txtImg4.Size = New System.Drawing.Size(100, 20)
        Me.txtImg4.TabIndex = 5
        Me.txtImg4.Text = "N/A"
        '
        'txtqty1
        '
        Me.txtqty1.Location = New System.Drawing.Point(217, 52)
        Me.txtqty1.Name = "txtqty1"
        Me.txtqty1.Size = New System.Drawing.Size(100, 20)
        Me.txtqty1.TabIndex = 11
        Me.txtqty1.Text = "0"
        '
        'txtqty4
        '
        Me.txtqty4.Location = New System.Drawing.Point(217, 134)
        Me.txtqty4.Name = "txtqty4"
        Me.txtqty4.Size = New System.Drawing.Size(100, 20)
        Me.txtqty4.TabIndex = 13
        Me.txtqty4.Text = "0"
        '
        'txtqty3
        '
        Me.txtqty3.Location = New System.Drawing.Point(217, 108)
        Me.txtqty3.Name = "txtqty3"
        Me.txtqty3.Size = New System.Drawing.Size(100, 20)
        Me.txtqty3.TabIndex = 15
        Me.txtqty3.Text = "0"
        '
        'txtqty2
        '
        Me.txtqty2.Location = New System.Drawing.Point(217, 82)
        Me.txtqty2.Name = "txtqty2"
        Me.txtqty2.Size = New System.Drawing.Size(100, 20)
        Me.txtqty2.TabIndex = 17
        Me.txtqty2.Text = "0"
        '
        'txtctrlno
        '
        Me.txtctrlno.Location = New System.Drawing.Point(70, 167)
        Me.txtctrlno.Name = "txtctrlno"
        Me.txtctrlno.Size = New System.Drawing.Size(247, 20)
        Me.txtctrlno.TabIndex = 19
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(7, 213)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 23
        Me.txtquantity.Visible = False
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(169, 213)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 25
        Me.txtprice.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Qty1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Qty2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(182, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Qty3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Qty4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Control No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Img4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Img3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Img2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Img1"
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 199)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtctrlno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtqty2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtqty3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtqty4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtqty1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImg4)
        Me.Controls.Add(Me.txtImg3)
        Me.Controls.Add(Me.txtImg2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtImg1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtImg1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtImg2 As TextBox
    Friend WithEvents txtImg3 As TextBox
    Friend WithEvents txtImg4 As TextBox
    Friend WithEvents txtqty1 As TextBox
    Friend WithEvents txtqty4 As TextBox
    Friend WithEvents txtqty3 As TextBox
    Friend WithEvents txtqty2 As TextBox
    Friend WithEvents txtctrlno As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
