<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SPECSTYPEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.POWERGLASSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SUNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CONTACTLENSESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FRAMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GLASSDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SPECSTYPEToolStripMenuItem, Me.GLASSDETAILSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 65)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SPECSTYPEToolStripMenuItem
        '
        Me.SPECSTYPEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POWERGLASSToolStripMenuItem, Me.SUNToolStripMenuItem, Me.CONTACTLENSESToolStripMenuItem, Me.FRAMESToolStripMenuItem})
        Me.SPECSTYPEToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPECSTYPEToolStripMenuItem.Name = "SPECSTYPEToolStripMenuItem"
        Me.SPECSTYPEToolStripMenuItem.Size = New System.Drawing.Size(307, 61)
        Me.SPECSTYPEToolStripMenuItem.Text = "SPECS TYPE"
        '
        'POWERGLASSToolStripMenuItem
        '
        Me.POWERGLASSToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POWERGLASSToolStripMenuItem.Name = "POWERGLASSToolStripMenuItem"
        Me.POWERGLASSToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.POWERGLASSToolStripMenuItem.Text = "POWER LENSES"
        '
        'SUNToolStripMenuItem
        '
        Me.SUNToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUNToolStripMenuItem.Name = "SUNToolStripMenuItem"
        Me.SUNToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.SUNToolStripMenuItem.Text = "SUN GLASSES"
        '
        'CONTACTLENSESToolStripMenuItem
        '
        Me.CONTACTLENSESToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTACTLENSESToolStripMenuItem.Name = "CONTACTLENSESToolStripMenuItem"
        Me.CONTACTLENSESToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.CONTACTLENSESToolStripMenuItem.Text = "CONTACT LENSES"
        '
        'FRAMESToolStripMenuItem
        '
        Me.FRAMESToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRAMESToolStripMenuItem.Name = "FRAMESToolStripMenuItem"
        Me.FRAMESToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.FRAMESToolStripMenuItem.Text = "FRAMES"
        '
        'GLASSDETAILSToolStripMenuItem
        '
        Me.GLASSDETAILSToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLASSDETAILSToolStripMenuItem.Name = "GLASSDETAILSToolStripMenuItem"
        Me.GLASSDETAILSToolStripMenuItem.Size = New System.Drawing.Size(379, 61)
        Me.GLASSDETAILSToolStripMenuItem.Text = "GLASS DETAILS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1147, 500)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SPECSTYPEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POWERGLASSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONTACTLENSESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FRAMESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GLASSDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
