<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bttnWarehouse = New System.Windows.Forms.Button()
        Me.bttnPrices = New System.Windows.Forms.Button()
        Me.bttnProducts = New System.Windows.Forms.Button()
        Me.bttnOrders = New System.Windows.Forms.Button()
        Me.bttnMenu = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.pnlForms = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.bttnWarehouse)
        Me.pnlMenu.Controls.Add(Me.bttnPrices)
        Me.pnlMenu.Controls.Add(Me.bttnProducts)
        Me.pnlMenu.Controls.Add(Me.bttnOrders)
        Me.pnlMenu.Controls.Add(Me.bttnMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 37)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(308, 560)
        Me.pnlMenu.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Controls.Add(Me.bttnClose)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1333, 37)
        Me.Panel2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Location = New System.Drawing.Point(75, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "PRP - SOFT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnWarehouse
        '
        Me.bttnWarehouse.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.bttnWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnWarehouse.FlatAppearance.BorderSize = 0
        Me.bttnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnWarehouse.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.bttnWarehouse.Image = Global.PDAapp.My.Resources.Resources.warehousenew1
        Me.bttnWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnWarehouse.Location = New System.Drawing.Point(0, 342)
        Me.bttnWarehouse.Name = "bttnWarehouse"
        Me.bttnWarehouse.Size = New System.Drawing.Size(307, 50)
        Me.bttnWarehouse.TabIndex = 15
        Me.bttnWarehouse.Text = "ΑΠΟΘΗΚΗ"
        Me.bttnWarehouse.UseVisualStyleBackColor = False
        '
        'bttnPrices
        '
        Me.bttnPrices.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.bttnPrices.FlatAppearance.BorderSize = 0
        Me.bttnPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPrices.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.bttnPrices.Image = Global.PDAapp.My.Resources.Resources.pricedollarnewTrans
        Me.bttnPrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnPrices.Location = New System.Drawing.Point(0, 266)
        Me.bttnPrices.Name = "bttnPrices"
        Me.bttnPrices.Size = New System.Drawing.Size(307, 50)
        Me.bttnPrices.TabIndex = 14
        Me.bttnPrices.Text = "ΤΙΜΕΣ"
        Me.bttnPrices.UseVisualStyleBackColor = False
        '
        'bttnProducts
        '
        Me.bttnProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.bttnProducts.FlatAppearance.BorderSize = 0
        Me.bttnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProducts.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.bttnProducts.Image = CType(resources.GetObject("bttnProducts.Image"), System.Drawing.Image)
        Me.bttnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnProducts.Location = New System.Drawing.Point(0, 190)
        Me.bttnProducts.Name = "bttnProducts"
        Me.bttnProducts.Size = New System.Drawing.Size(307, 50)
        Me.bttnProducts.TabIndex = 13
        Me.bttnProducts.Text = "ΠΡΟΪΟΝΤΑ"
        Me.bttnProducts.UseVisualStyleBackColor = False
        '
        'bttnOrders
        '
        Me.bttnOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.bttnOrders.FlatAppearance.BorderSize = 0
        Me.bttnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOrders.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.bttnOrders.Image = Global.PDAapp.My.Resources.Resources.ordersnew
        Me.bttnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnOrders.Location = New System.Drawing.Point(0, 114)
        Me.bttnOrders.Name = "bttnOrders"
        Me.bttnOrders.Size = New System.Drawing.Size(307, 50)
        Me.bttnOrders.TabIndex = 12
        Me.bttnOrders.Text = "ΠΑΡΑΓΓΕΛΙΕΣ"
        Me.bttnOrders.UseVisualStyleBackColor = False
        '
        'bttnMenu
        '
        Me.bttnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bttnMenu.FlatAppearance.BorderSize = 0
        Me.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnMenu.ForeColor = System.Drawing.SystemColors.Control
        Me.bttnMenu.Image = Global.PDAapp.My.Resources.Resources.menunew
        Me.bttnMenu.Location = New System.Drawing.Point(264, 6)
        Me.bttnMenu.Name = "bttnMenu"
        Me.bttnMenu.Size = New System.Drawing.Size(38, 38)
        Me.bttnMenu.TabIndex = 0
        Me.bttnMenu.UseVisualStyleBackColor = False
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Image = Global.PDAapp.My.Resources.Resources.closeimgnew
        Me.bttnClose.Location = New System.Drawing.Point(1295, -1)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(38, 38)
        Me.bttnClose.TabIndex = 3
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'pnlForms
        '
        Me.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForms.Location = New System.Drawing.Point(308, 37)
        Me.pnlForms.Name = "pnlForms"
        Me.pnlForms.Size = New System.Drawing.Size(1025, 560)
        Me.pnlForms.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1333, 597)
        Me.Controls.Add(Me.pnlForms)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents bttnMenu As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bttnOrders As Button
    Friend WithEvents bttnProducts As Button
    Friend WithEvents bttnWarehouse As Button
    Friend WithEvents bttnPrices As Button
    Friend WithEvents bttnClose As Button
    Friend WithEvents pnlForms As Panel
End Class
