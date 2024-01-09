<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Os8DataSet4 = New optical_shop.os8DataSet4
        Me.Os8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Os8TableAdapter = New optical_shop.os8DataSet4TableAdapters.os8TableAdapter
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMPLOYEEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADDDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WORKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QUALIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPERIENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os8DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPLOYEE DETAILS:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEENAMEDataGridViewTextBoxColumn, Me.EMPLOYEEIDDataGridViewTextBoxColumn, Me.ADDDRESSDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.WORKDataGridViewTextBoxColumn, Me.QUALIFICATIONDataGridViewTextBoxColumn, Me.EXPERIENCEDataGridViewTextBoxColumn, Me.AGEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Os8BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(202, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 313)
        Me.DataGridView1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1116, 602)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Os8DataSet4
        '
        Me.Os8DataSet4.DataSetName = "os8DataSet4"
        Me.Os8DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Os8BindingSource
        '
        Me.Os8BindingSource.DataMember = "os8"
        Me.Os8BindingSource.DataSource = Me.Os8DataSet4
        '
        'Os8TableAdapter
        '
        Me.Os8TableAdapter.ClearBeforeFill = True
        '
        'EMPLOYEENAMEDataGridViewTextBoxColumn
        '
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE NAME"
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE NAME"
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.Name = "EMPLOYEENAMEDataGridViewTextBoxColumn"
        '
        'EMPLOYEEIDDataGridViewTextBoxColumn
        '
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.Name = "EMPLOYEEIDDataGridViewTextBoxColumn"
        '
        'ADDDRESSDataGridViewTextBoxColumn
        '
        Me.ADDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDDRESS"
        Me.ADDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDDRESS"
        Me.ADDDRESSDataGridViewTextBoxColumn.Name = "ADDDRESSDataGridViewTextBoxColumn"
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        '
        'WORKDataGridViewTextBoxColumn
        '
        Me.WORKDataGridViewTextBoxColumn.DataPropertyName = "WORK"
        Me.WORKDataGridViewTextBoxColumn.HeaderText = "WORK"
        Me.WORKDataGridViewTextBoxColumn.Name = "WORKDataGridViewTextBoxColumn"
        '
        'QUALIFICATIONDataGridViewTextBoxColumn
        '
        Me.QUALIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "QUALIFICATION"
        Me.QUALIFICATIONDataGridViewTextBoxColumn.HeaderText = "QUALIFICATION"
        Me.QUALIFICATIONDataGridViewTextBoxColumn.Name = "QUALIFICATIONDataGridViewTextBoxColumn"
        '
        'EXPERIENCEDataGridViewTextBoxColumn
        '
        Me.EXPERIENCEDataGridViewTextBoxColumn.DataPropertyName = "EXPERIENCE"
        Me.EXPERIENCEDataGridViewTextBoxColumn.HeaderText = "EXPERIENCE"
        Me.EXPERIENCEDataGridViewTextBoxColumn.Name = "EXPERIENCEDataGridViewTextBoxColumn"
        '
        'AGEDataGridViewTextBoxColumn
        '
        Me.AGEDataGridViewTextBoxColumn.DataPropertyName = "AGE"
        Me.AGEDataGridViewTextBoxColumn.HeaderText = "AGE"
        Me.AGEDataGridViewTextBoxColumn.Name = "AGEDataGridViewTextBoxColumn"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os8DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Os8DataSet4 As optical_shop.os8DataSet4
    Friend WithEvents Os8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Os8TableAdapter As optical_shop.os8DataSet4TableAdapters.os8TableAdapter
    Friend WithEvents EMPLOYEENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYEEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUALIFICATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPERIENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
