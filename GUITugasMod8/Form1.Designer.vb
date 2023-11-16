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
        AwalTB = New TextBox()
        Label1 = New Label()
        Convert = New Button()
        AwalCB = New ComboBox()
        Label2 = New Label()
        HasilCB = New ComboBox()
        HasilTB = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' AwalTB
        ' 
        AwalTB.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AwalTB.Location = New Point(173, 150)
        AwalTB.Name = "AwalTB"
        AwalTB.Size = New Size(149, 29)
        AwalTB.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(151, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 32)
        Label1.TabIndex = 1
        Label1.Text = "Temperature Converter"
        ' 
        ' Convert
        ' 
        Convert.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Convert.Location = New Point(254, 258)
        Convert.Name = "Convert"
        Convert.Size = New Size(87, 28)
        Convert.TabIndex = 2
        Convert.Text = "Convert"
        Convert.UseVisualStyleBackColor = True
        ' 
        ' AwalCB
        ' 
        AwalCB.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AwalCB.FormattingEnabled = True
        AwalCB.Location = New Point(344, 150)
        AwalCB.Name = "AwalCB"
        AwalCB.Size = New Size(137, 29)
        AwalCB.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(107, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 21)
        Label2.TabIndex = 4
        Label2.Text = "Temperature"
        ' 
        ' HasilCB
        ' 
        HasilCB.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        HasilCB.FormattingEnabled = True
        HasilCB.Location = New Point(344, 197)
        HasilCB.Name = "HasilCB"
        HasilCB.Size = New Size(137, 29)
        HasilCB.TabIndex = 6
        ' 
        ' HasilTB
        ' 
        HasilTB.Cursor = Cursors.SizeAll
        HasilTB.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        HasilTB.Location = New Point(173, 197)
        HasilTB.Name = "HasilTB"
        HasilTB.ReadOnly = True
        HasilTB.Size = New Size(149, 29)
        HasilTB.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(108, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 21)
        Label3.TabIndex = 7
        Label3.Text = "Input"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(108, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 21)
        Label4.TabIndex = 8
        Label4.Text = "Output"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(603, 401)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(HasilCB)
        Controls.Add(HasilTB)
        Controls.Add(Label2)
        Controls.Add(AwalCB)
        Controls.Add(Convert)
        Controls.Add(Label1)
        Controls.Add(AwalTB)
        Name = "Form1"
        Text = "Kelompok 27"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AwalTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Convert As Button
    Friend WithEvents AwalCB As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HasilCB As ComboBox
    Friend WithEvents HasilTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
