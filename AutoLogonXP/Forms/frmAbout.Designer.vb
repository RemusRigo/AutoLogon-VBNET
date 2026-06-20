<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lnkLblGitHub = New System.Windows.Forms.LinkLabel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.imgPayPal = New System.Windows.Forms.PictureBox()
        Me.imgRevolut = New System.Windows.Forms.PictureBox()
        CType(Me.imgPayPal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRevolut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkLblGitHub
        '
        Me.lnkLblGitHub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkLblGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkLblGitHub.Location = New System.Drawing.Point(2, 71)
        Me.lnkLblGitHub.Name = "lnkLblGitHub"
        Me.lnkLblGitHub.Size = New System.Drawing.Size(276, 31)
        Me.lnkLblGitHub.TabIndex = 2
        Me.lnkLblGitHub.TabStop = True
        Me.lnkLblGitHub.Text = "appLink"
        Me.lnkLblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(279, 49)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "appTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVer
        '
        Me.lblVer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVer.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.Location = New System.Drawing.Point(2, 49)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(279, 22)
        Me.lblVer.TabIndex = 4
        Me.lblVer.Text = "appVer"
        Me.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgPayPal
        '
        Me.imgPayPal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgPayPal.Image = CType(resources.GetObject("imgPayPal.Image"), System.Drawing.Image)
        Me.imgPayPal.Location = New System.Drawing.Point(3, 102)
        Me.imgPayPal.Name = "imgPayPal"
        Me.imgPayPal.Size = New System.Drawing.Size(70, 70)
        Me.imgPayPal.TabIndex = 6
        Me.imgPayPal.TabStop = False
        '
        'imgRevolut
        '
        Me.imgRevolut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgRevolut.Image = CType(resources.GetObject("imgRevolut.Image"), System.Drawing.Image)
        Me.imgRevolut.Location = New System.Drawing.Point(208, 102)
        Me.imgRevolut.Name = "imgRevolut"
        Me.imgRevolut.Size = New System.Drawing.Size(70, 70)
        Me.imgRevolut.TabIndex = 7
        Me.imgRevolut.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 174)
        Me.Controls.Add(Me.imgRevolut)
        Me.Controls.Add(Me.imgPayPal)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lnkLblGitHub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.imgPayPal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRevolut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lnkLblGitHub As LinkLabel
   Friend WithEvents lblTitle As Label
   Friend WithEvents lblVer As Label
   Friend WithEvents imgPayPal As PictureBox
   Friend WithEvents imgRevolut As PictureBox
End Class
