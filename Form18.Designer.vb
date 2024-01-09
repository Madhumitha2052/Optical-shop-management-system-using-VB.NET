<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GROSSPAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEDUCTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NETPAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Os7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Os7DataSet4 = New optical_shop.os7DataSet4
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Os7TableAdapter = New optical_shop.os7DataSet4TableAdapters.os7TableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os7DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SALARY DETAILS:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALARYDataGridViewTextBoxColumn, Me.HRADataGridViewTextBoxColumn, Me.DFDataGridViewTextBoxColumn, Me.TFDataGridViewTextBoxColumn, Me.PFDataGridViewTextBoxColumn, Me.LICDataGridViewTextBoxColumn, Me.GROSSPAYDataGridViewTextBoxColumn, Me.DEDUCTIONDataGridViewTextBoxColumn, Me.NETPAYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Os7BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(176, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 389)
        Me.DataGridView1.TabIndex = 2
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        '
        'HRADataGridViewTextBoxColumn
        '
        Me.HRADataGridViewTextBoxColumn.DataPropertyName = "HRA"
        Me.HRADataGridViewTextBoxColumn.HeaderText = "HRA"
        Me.HRADataGridViewTextBoxColumn.Name = "HRADataGridViewTextBoxColumn"
        '
        'DFDataGridViewTextBoxColumn
        '
        Me.DFDataGridViewTextBoxColumn.DataPropertyName = "DF"
        Me.DFDataGridViewTextBoxColumn.HeaderText = "DF"
        Me.DFDataGridViewTextBoxColumn.Name = "DFDataGridViewTextBoxColumn"
        '
        'TFDataGridViewTextBoxColumn
        '
        Me.TFDataGridViewTextBoxColumn.DataPropertyName = "TF"
        Me.TFDataGridViewTextBoxColumn.HeaderText = "TF"
        Me.TFDataGridViewTextBoxColumn.Name = "TFDataGridViewTextBoxColumn"
        '
        'PFDataGridViewTextBoxColumn
        '
        Me.PFDataGridViewTextBoxColumn.DataPropertyName = "PF"
        Me.PFDataGridViewTextBoxColumn.HeaderText = "PF"
        Me.PFDataGridViewTextBoxColumn.Name = "PFDataGridViewTextBoxColumn"
        '
        'LICDataGridViewTextBoxColumn
        '
        Me.LICDataGridViewTextBoxColumn.DataPropertyName = "LIC"
        Me.LICDataGridViewTextBoxColumn.HeaderText = "LIC"
        Me.LICDataGridViewTextBoxColumn.Name = "LICDataGridViewTextBoxColumn"
        '
        'GROSSPAYDataGridViewTextBoxColumn
        '
        Me.GROSSPAYDataGridViewTextBoxColumn.DataPropertyName = "GROSS PAY"
        Me.GROSSPAYDataGridViewTextBoxColumn.HeaderText = "GROSS PAY"
        Me.GROSSPAYDataGridViewTextBoxColumn.Name = "GROSSPAYDataGridViewTextBoxColumn"
        '
        'DEDUCTIONDataGridViewTextBoxColumn
        '
        Me.DEDUCTIONDataGridViewTextBoxColumn.DataPropertyName = "DEDUCTION"
        Me.DEDUCTIONDataGridViewTextBoxColumn.HeaderText = "DEDUCTION"
        Me.DEDUCTIONDataGridViewTextBoxColumn.Name = "DEDUCTIONDataGridViewTextBoxColumn"
        '
        'NETPAYDataGridViewTextBoxColumn
        '
        Me.NETPAYDataGridViewTextBoxColumn.DataPropertyName = "NET PAY"
        Me.NETPAYDataGridViewTextBoxColumn.HeaderText = "NET PAY"
        Me.NETPAYDataGridViewTextBoxColumn.Name = "NETPAYDataGridViewTextBoxColumn"
        '
        'Os7BindingSource
        '
        Me.Os7BindingSource.DataMember = "os7"
        Me.Os7BindingSource.DataSource = Me.Os7DataSet4
        '
        'Os7DataSet4
        '
        Me.Os7DataSet4.DataSetName = "os7DataSet4"
        Me.Os7DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1120, 599)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Os7TableAdapter
        '
        Me.Os7TableAdapter.ClearBeforeFill = True
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form18"
        Me.Text = "Form18"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os7DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Os7DataSet4 As optical_shop.os7DataSet4
    Friend WithEvents Os7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Os7TableAdapter As optical_shop.os7DataSet4TableAdapters.os7TableAdapter
    Friend WithEvents SALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LICDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GROSSPAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEDUCTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NETPAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
