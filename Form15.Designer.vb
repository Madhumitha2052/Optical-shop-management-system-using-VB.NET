<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ITEMNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LEFTEYEPOWERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RIGHTEYEPOWERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTALPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONSULTEDDOCTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HOSPITALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Os3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Os3DataSet6 = New optical_shop.os3DataSet6
        Me.Os3TableAdapter = New optical_shop.os3DataSet6TableAdapters.os3TableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os3DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(449, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PURCHASE DETAILS:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMERNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.ITEMNODataGridViewTextBoxColumn, Me.ITEMNAMEDataGridViewTextBoxColumn, Me.LEFTEYEPOWERDataGridViewTextBoxColumn, Me.RIGHTEYEPOWERDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.GSTDataGridViewTextBoxColumn, Me.TOTALPRICEDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.CONSULTEDDOCTORDataGridViewTextBoxColumn, Me.HOSPITALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Os3BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1333, 331)
        Me.DataGridView1.TabIndex = 2
        '
        'CUSTOMERNAMEDataGridViewTextBoxColumn
        '
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.Name = "CUSTOMERNAMEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'ITEMNODataGridViewTextBoxColumn
        '
        Me.ITEMNODataGridViewTextBoxColumn.DataPropertyName = "ITEM NO"
        Me.ITEMNODataGridViewTextBoxColumn.HeaderText = "ITEM NO"
        Me.ITEMNODataGridViewTextBoxColumn.Name = "ITEMNODataGridViewTextBoxColumn"
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "ITEM NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        '
        'LEFTEYEPOWERDataGridViewTextBoxColumn
        '
        Me.LEFTEYEPOWERDataGridViewTextBoxColumn.DataPropertyName = "LEFT EYE POWER"
        Me.LEFTEYEPOWERDataGridViewTextBoxColumn.HeaderText = "LEFT EYE POWER"
        Me.LEFTEYEPOWERDataGridViewTextBoxColumn.Name = "LEFTEYEPOWERDataGridViewTextBoxColumn"
        '
        'RIGHTEYEPOWERDataGridViewTextBoxColumn
        '
        Me.RIGHTEYEPOWERDataGridViewTextBoxColumn.DataPropertyName = "RIGHT EYE POWER"
        Me.RIGHTEYEPOWERDataGridViewTextBoxColumn.HeaderText = "RIGHT EYE POWER"
        Me.RIGHTEYEPOWERDataGridViewTextBoxColumn.Name = "RIGHTEYEPOWERDataGridViewTextBoxColumn"
        '
        'PRICEDataGridViewTextBoxColumn
        '
        Me.PRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.Name = "PRICEDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'GSTDataGridViewTextBoxColumn
        '
        Me.GSTDataGridViewTextBoxColumn.DataPropertyName = "GST"
        Me.GSTDataGridViewTextBoxColumn.HeaderText = "GST"
        Me.GSTDataGridViewTextBoxColumn.Name = "GSTDataGridViewTextBoxColumn"
        '
        'TOTALPRICEDataGridViewTextBoxColumn
        '
        Me.TOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.HeaderText = "TOTAL PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.Name = "TOTALPRICEDataGridViewTextBoxColumn"
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        '
        'CONSULTEDDOCTORDataGridViewTextBoxColumn
        '
        Me.CONSULTEDDOCTORDataGridViewTextBoxColumn.DataPropertyName = "CONSULTED DOCTOR"
        Me.CONSULTEDDOCTORDataGridViewTextBoxColumn.HeaderText = "CONSULTED DOCTOR"
        Me.CONSULTEDDOCTORDataGridViewTextBoxColumn.Name = "CONSULTEDDOCTORDataGridViewTextBoxColumn"
        '
        'HOSPITALDataGridViewTextBoxColumn
        '
        Me.HOSPITALDataGridViewTextBoxColumn.DataPropertyName = "HOSPITAL"
        Me.HOSPITALDataGridViewTextBoxColumn.HeaderText = "HOSPITAL"
        Me.HOSPITALDataGridViewTextBoxColumn.Name = "HOSPITALDataGridViewTextBoxColumn"
        '
        'Os3BindingSource
        '
        Me.Os3BindingSource.DataMember = "os3"
        Me.Os3BindingSource.DataSource = Me.Os3DataSet6
        '
        'Os3DataSet6
        '
        Me.Os3DataSet6.DataSetName = "os3DataSet6"
        Me.Os3DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Os3TableAdapter
        '
        Me.Os3TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1172, 626)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form15"
        Me.Text = "Form15"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os3DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Os3DataSet6 As optical_shop.os3DataSet6
    Friend WithEvents Os3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Os3TableAdapter As optical_shop.os3DataSet6TableAdapters.os3TableAdapter
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEFTEYEPOWERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RIGHTEYEPOWERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSULTEDDOCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
