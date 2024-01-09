<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form27
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form27))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ITEMNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Os13BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Os13DataSet1 = New optical_shop.os13DataSet1
        Me.Os13BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Os13DataSet = New optical_shop.os13DataSet
        Me.Os13TableAdapter = New optical_shop.os13DataSetTableAdapters.os13TableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Os13TableAdapter1 = New optical_shop.os13DataSet1TableAdapters.os13TableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os13BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os13DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os13BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Os13DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMNODataGridViewTextBoxColumn, Me.ITEMNAMEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Os13BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(391, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 455)
        Me.DataGridView1.TabIndex = 0
        '
        'ITEMNODataGridViewTextBoxColumn
        '
        Me.ITEMNODataGridViewTextBoxColumn.DataPropertyName = "ITEMNO"
        Me.ITEMNODataGridViewTextBoxColumn.HeaderText = "ITEMNO"
        Me.ITEMNODataGridViewTextBoxColumn.Name = "ITEMNODataGridViewTextBoxColumn"
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "ITEM NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'Os13BindingSource1
        '
        Me.Os13BindingSource1.DataMember = "os13"
        Me.Os13BindingSource1.DataSource = Me.Os13DataSet1
        '
        'Os13DataSet1
        '
        Me.Os13DataSet1.DataSetName = "os13DataSet1"
        Me.Os13DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Os13BindingSource
        '
        Me.Os13BindingSource.DataMember = "os13"
        Me.Os13BindingSource.DataSource = Me.Os13DataSet
        '
        'Os13DataSet
        '
        Me.Os13DataSet.DataSetName = "os13DataSet"
        Me.Os13DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Os13TableAdapter
        '
        Me.Os13TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STOCK DETAILS"
        '
        'Os13TableAdapter1
        '
        Me.Os13TableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1107, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 76)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(808, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "VIEW REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form27
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form27"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os13BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os13DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os13BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Os13DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Os13DataSet As optical_shop.os13DataSet
    Friend WithEvents Os13BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Os13TableAdapter As optical_shop.os13DataSetTableAdapters.os13TableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Os13DataSet1 As optical_shop.os13DataSet1
    Friend WithEvents Os13BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Os13TableAdapter1 As optical_shop.os13DataSet1TableAdapters.os13TableAdapter
    Friend WithEvents ITEMNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
