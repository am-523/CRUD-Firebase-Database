<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnClearAll = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCreateID = New Guna.UI2.WinForms.Guna2Button()
        Me.TBCity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TBID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelRegistration = New System.Windows.Forms.Label()
        Me.OpenFileDialogUserImage = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTotalUser = New System.Windows.Forms.Label()
        Me.DGVUserData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CMSUserDataTable = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClearSelection = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelRecordView = New System.Windows.Forms.Label()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.PictureBoxUserReg = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSUserDataTable.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.PictureBoxUserReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.BorderRadius = 8
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.PictureBoxUserReg)
        Me.Guna2Panel1.Controls.Add(Me.BtnClearAll)
        Me.Guna2Panel1.Controls.Add(Me.BtnSave)
        Me.Guna2Panel1.Controls.Add(Me.BtnCreateID)
        Me.Guna2Panel1.Controls.Add(Me.TBCity)
        Me.Guna2Panel1.Controls.Add(Me.CBGender)
        Me.Guna2Panel1.Controls.Add(Me.TBID)
        Me.Guna2Panel1.Controls.Add(Me.TBName)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(589, 253)
        Me.Guna2Panel1.TabIndex = 0
        '
        'BtnClearAll
        '
        Me.BtnClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearAll.BorderRadius = 5
        Me.BtnClearAll.CheckedState.Parent = Me.BtnClearAll
        Me.BtnClearAll.CustomImages.Parent = Me.BtnClearAll
        Me.BtnClearAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnClearAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClearAll.ForeColor = System.Drawing.Color.White
        Me.BtnClearAll.HoverState.Parent = Me.BtnClearAll
        Me.BtnClearAll.Location = New System.Drawing.Point(276, 204)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.ShadowDecoration.Parent = Me.BtnClearAll
        Me.BtnClearAll.Size = New System.Drawing.Size(106, 29)
        Me.BtnClearAll.TabIndex = 11
        Me.BtnClearAll.Text = "Clear"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(164, 204)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(106, 29)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        '
        'BtnCreateID
        '
        Me.BtnCreateID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateID.BorderRadius = 5
        Me.BtnCreateID.CheckedState.Parent = Me.BtnCreateID
        Me.BtnCreateID.CustomImages.Parent = Me.BtnCreateID
        Me.BtnCreateID.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnCreateID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCreateID.ForeColor = System.Drawing.Color.White
        Me.BtnCreateID.HoverState.Parent = Me.BtnCreateID
        Me.BtnCreateID.Location = New System.Drawing.Point(304, 82)
        Me.BtnCreateID.Name = "BtnCreateID"
        Me.BtnCreateID.ShadowDecoration.Parent = Me.BtnCreateID
        Me.BtnCreateID.Size = New System.Drawing.Size(78, 29)
        Me.BtnCreateID.TabIndex = 9
        Me.BtnCreateID.Text = "Create ID"
        '
        'TBCity
        '
        Me.TBCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCity.Animated = True
        Me.TBCity.AutoRoundedCorners = True
        Me.TBCity.BorderRadius = 12
        Me.TBCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBCity.DefaultText = ""
        Me.TBCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBCity.DisabledState.Parent = Me.TBCity
        Me.TBCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBCity.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.TBCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBCity.FocusedState.Parent = Me.TBCity
        Me.TBCity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TBCity.ForeColor = System.Drawing.Color.White
        Me.TBCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBCity.HoverState.Parent = Me.TBCity
        Me.TBCity.Location = New System.Drawing.Point(98, 161)
        Me.TBCity.Name = "TBCity"
        Me.TBCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBCity.PlaceholderText = "Your City"
        Me.TBCity.SelectedText = ""
        Me.TBCity.ShadowDecoration.Parent = Me.TBCity
        Me.TBCity.Size = New System.Drawing.Size(284, 26)
        Me.TBCity.TabIndex = 8
        '
        'CBGender
        '
        Me.CBGender.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBGender.Animated = True
        Me.CBGender.AutoRoundedCorners = True
        Me.CBGender.BackColor = System.Drawing.Color.Transparent
        Me.CBGender.BorderRadius = 17
        Me.CBGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGender.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.CBGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBGender.FocusedState.Parent = Me.CBGender
        Me.CBGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBGender.ForeColor = System.Drawing.Color.White
        Me.CBGender.HoverState.Parent = Me.CBGender
        Me.CBGender.ItemHeight = 30
        Me.CBGender.Items.AddRange(New Object() {"Select Your Gender", "Male", "Female"})
        Me.CBGender.ItemsAppearance.Parent = Me.CBGender
        Me.CBGender.Location = New System.Drawing.Point(98, 117)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.ShadowDecoration.Parent = Me.CBGender
        Me.CBGender.Size = New System.Drawing.Size(284, 36)
        Me.CBGender.StartIndex = 0
        Me.CBGender.TabIndex = 7
        '
        'TBID
        '
        Me.TBID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBID.Animated = True
        Me.TBID.AutoRoundedCorners = True
        Me.TBID.BorderRadius = 12
        Me.TBID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBID.DefaultText = ""
        Me.TBID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBID.DisabledState.Parent = Me.TBID
        Me.TBID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBID.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.TBID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBID.FocusedState.Parent = Me.TBID
        Me.TBID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TBID.ForeColor = System.Drawing.Color.White
        Me.TBID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBID.HoverState.Parent = Me.TBID
        Me.TBID.Location = New System.Drawing.Point(98, 85)
        Me.TBID.Name = "TBID"
        Me.TBID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBID.PlaceholderText = "Auto Create ID"
        Me.TBID.ReadOnly = True
        Me.TBID.SelectedText = ""
        Me.TBID.ShadowDecoration.Parent = Me.TBID
        Me.TBID.Size = New System.Drawing.Size(200, 26)
        Me.TBID.TabIndex = 6
        '
        'TBName
        '
        Me.TBName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBName.Animated = True
        Me.TBName.AutoRoundedCorners = True
        Me.TBName.BorderRadius = 12
        Me.TBName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBName.DefaultText = ""
        Me.TBName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBName.DisabledState.Parent = Me.TBName
        Me.TBName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBName.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.TBName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBName.FocusedState.Parent = Me.TBName
        Me.TBName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TBName.ForeColor = System.Drawing.Color.White
        Me.TBName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBName.HoverState.Parent = Me.TBName
        Me.TBName.Location = New System.Drawing.Point(98, 52)
        Me.TBName.Name = "TBName"
        Me.TBName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBName.PlaceholderText = "Your Full Name"
        Me.TBName.SelectedText = ""
        Me.TBName.ShadowDecoration.Parent = Me.TBName
        Me.TBName.Size = New System.Drawing.Size(284, 26)
        Me.TBName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(19, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(19, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(19, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(19, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name "
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 8
        Me.Guna2Panel2.Controls.Add(Me.LabelRegistration)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(589, 34)
        Me.Guna2Panel2.TabIndex = 0
        '
        'LabelRegistration
        '
        Me.LabelRegistration.AutoSize = True
        Me.LabelRegistration.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegistration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelRegistration.Location = New System.Drawing.Point(19, 9)
        Me.LabelRegistration.Name = "LabelRegistration"
        Me.LabelRegistration.Size = New System.Drawing.Size(108, 16)
        Me.LabelRegistration.TabIndex = 5
        Me.LabelRegistration.Text = "Form Register"
        '
        'OpenFileDialogUserImage
        '
        Me.OpenFileDialogUserImage.FileName = "OpenFileDialog1"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel3.BorderRadius = 8
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.TBSearch)
        Me.Guna2Panel3.Controls.Add(Me.LblTotalUser)
        Me.Guna2Panel3.Controls.Add(Me.DGVUserData)
        Me.Guna2Panel3.Controls.Add(Me.BtnClearSelection)
        Me.Guna2Panel3.Controls.Add(Me.BtnRefresh)
        Me.Guna2Panel3.Controls.Add(Me.BtnDelete)
        Me.Guna2Panel3.Controls.Add(Me.BtnEdit)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.CBSearchBy)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 284)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(591, 321)
        Me.Guna2Panel3.TabIndex = 1
        '
        'LblTotalUser
        '
        Me.LblTotalUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalUser.AutoSize = True
        Me.LblTotalUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalUser.ForeColor = System.Drawing.Color.White
        Me.LblTotalUser.Location = New System.Drawing.Point(480, 101)
        Me.LblTotalUser.Name = "LblTotalUser"
        Me.LblTotalUser.Size = New System.Drawing.Size(86, 16)
        Me.LblTotalUser.TabIndex = 19
        Me.LblTotalUser.Text = "Total Users :"
        '
        'DGVUserData
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DGVUserData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVUserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUserData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGVUserData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVUserData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUserData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUserData.ColumnHeadersHeight = 35
        Me.DGVUserData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5})
        Me.DGVUserData.ContextMenuStrip = Me.CMSUserDataTable
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUserData.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUserData.EnableHeadersVisualStyles = False
        Me.DGVUserData.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DGVUserData.Location = New System.Drawing.Point(32, 134)
        Me.DGVUserData.Name = "DGVUserData"
        Me.DGVUserData.RowHeadersVisible = False
        Me.DGVUserData.RowTemplate.Height = 50
        Me.DGVUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserData.Size = New System.Drawing.Size(539, 170)
        Me.DGVUserData.TabIndex = 18
        Me.DGVUserData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.DGVUserData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DGVUserData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVUserData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVUserData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVUserData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVUserData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGVUserData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DGVUserData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DGVUserData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVUserData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUserData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVUserData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVUserData.ThemeStyle.HeaderStyle.Height = 35
        Me.DGVUserData.ThemeStyle.ReadOnly = False
        Me.DGVUserData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGVUserData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUserData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUserData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVUserData.ThemeStyle.RowsStyle.Height = 50
        Me.DGVUserData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.DGVUserData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'CMSUserDataTable
        '
        Me.CMSUserDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ClearSelectionToolStripMenuItem})
        Me.CMSUserDataTable.Name = "CMSUserDataTable"
        Me.CMSUserDataTable.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMSUserDataTable.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.CMSUserDataTable.RenderStyle.ColorTable = Nothing
        Me.CMSUserDataTable.RenderStyle.RoundedEdges = True
        Me.CMSUserDataTable.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.CMSUserDataTable.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMSUserDataTable.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.CMSUserDataTable.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.CMSUserDataTable.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CMSUserDataTable.Size = New System.Drawing.Size(159, 92)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        Me.ClearSelectionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ClearSelectionToolStripMenuItem.Text = "Clear Selection"
        '
        'BtnClearSelection
        '
        Me.BtnClearSelection.BorderRadius = 5
        Me.BtnClearSelection.CheckedState.Parent = Me.BtnClearSelection
        Me.BtnClearSelection.CustomImages.Parent = Me.BtnClearSelection
        Me.BtnClearSelection.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnClearSelection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClearSelection.ForeColor = System.Drawing.Color.White
        Me.BtnClearSelection.HoverState.Parent = Me.BtnClearSelection
        Me.BtnClearSelection.Location = New System.Drawing.Point(368, 92)
        Me.BtnClearSelection.Name = "BtnClearSelection"
        Me.BtnClearSelection.ShadowDecoration.Parent = Me.BtnClearSelection
        Me.BtnClearSelection.Size = New System.Drawing.Size(106, 29)
        Me.BtnClearSelection.TabIndex = 17
        Me.BtnClearSelection.Text = "Clear Selection"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BorderRadius = 5
        Me.BtnRefresh.CheckedState.Parent = Me.BtnRefresh
        Me.BtnRefresh.CustomImages.Parent = Me.BtnRefresh
        Me.BtnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.HoverState.Parent = Me.BtnRefresh
        Me.BtnRefresh.Location = New System.Drawing.Point(256, 92)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.ShadowDecoration.Parent = Me.BtnRefresh
        Me.BtnRefresh.Size = New System.Drawing.Size(106, 29)
        Me.BtnRefresh.TabIndex = 16
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnDelete
        '
        Me.BtnDelete.BorderRadius = 5
        Me.BtnDelete.CheckedState.Parent = Me.BtnDelete
        Me.BtnDelete.CustomImages.Parent = Me.BtnDelete
        Me.BtnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.HoverState.Parent = Me.BtnDelete
        Me.BtnDelete.Location = New System.Drawing.Point(144, 92)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.ShadowDecoration.Parent = Me.BtnDelete
        Me.BtnDelete.Size = New System.Drawing.Size(106, 29)
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.Text = "Delete"
        '
        'BtnEdit
        '
        Me.BtnEdit.BorderRadius = 5
        Me.BtnEdit.CheckedState.Parent = Me.BtnEdit
        Me.BtnEdit.CustomImages.Parent = Me.BtnEdit
        Me.BtnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.HoverState.Parent = Me.BtnEdit
        Me.BtnEdit.Location = New System.Drawing.Point(32, 92)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.ShadowDecoration.Parent = Me.BtnEdit
        Me.BtnEdit.Size = New System.Drawing.Size(106, 29)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(365, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "By"
        '
        'CBSearchBy
        '
        Me.CBSearchBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSearchBy.Animated = True
        Me.CBSearchBy.AutoRoundedCorners = True
        Me.CBSearchBy.BackColor = System.Drawing.Color.Transparent
        Me.CBSearchBy.BorderRadius = 17
        Me.CBSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSearchBy.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.CBSearchBy.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBSearchBy.FocusedState.Parent = Me.CBSearchBy
        Me.CBSearchBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSearchBy.ForeColor = System.Drawing.Color.White
        Me.CBSearchBy.HoverState.Parent = Me.CBSearchBy
        Me.CBSearchBy.ItemHeight = 30
        Me.CBSearchBy.Items.AddRange(New Object() {"Name", "ID"})
        Me.CBSearchBy.ItemsAppearance.Parent = Me.CBSearchBy
        Me.CBSearchBy.Location = New System.Drawing.Point(399, 39)
        Me.CBSearchBy.Name = "CBSearchBy"
        Me.CBSearchBy.ShadowDecoration.Parent = Me.CBSearchBy
        Me.CBSearchBy.Size = New System.Drawing.Size(172, 36)
        Me.CBSearchBy.StartIndex = 0
        Me.CBSearchBy.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Name "
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderRadius = 8
        Me.Guna2Panel4.Controls.Add(Me.LabelRecordView)
        Me.Guna2Panel4.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel4.CustomizableEdges.BottomRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(591, 33)
        Me.Guna2Panel4.TabIndex = 0
        '
        'LabelRecordView
        '
        Me.LabelRecordView.AutoSize = True
        Me.LabelRecordView.BackColor = System.Drawing.Color.Transparent
        Me.LabelRecordView.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecordView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelRecordView.Location = New System.Drawing.Point(19, 10)
        Me.LabelRecordView.Name = "LabelRecordView"
        Me.LabelRecordView.Size = New System.Drawing.Size(96, 16)
        Me.LabelRecordView.TabIndex = 6
        Me.LabelRecordView.Text = "View Record"
        '
        'Col1
        '
        Me.Col1.HeaderText = "Name"
        Me.Col1.Name = "Col1"
        '
        'Col2
        '
        Me.Col2.HeaderText = "ID"
        Me.Col2.Name = "Col2"
        '
        'Col3
        '
        Me.Col3.HeaderText = "Gender"
        Me.Col3.Name = "Col3"
        '
        'Col4
        '
        Me.Col4.HeaderText = "City"
        Me.Col4.Name = "Col4"
        '
        'Col5
        '
        Me.Col5.HeaderText = "Image"
        Me.Col5.Name = "Col5"
        '
        'TBSearch
        '
        Me.TBSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.TBSearch.ForeColor = System.Drawing.Color.White
        Me.TBSearch.Location = New System.Drawing.Point(79, 42)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(233, 22)
        Me.TBSearch.TabIndex = 20
        '
        'PictureBoxUserReg
        '
        Me.PictureBoxUserReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxUserReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserReg.Image = Global.CRUD_Firebase.My.Resources.Resources.avatar
        Me.PictureBoxUserReg.Location = New System.Drawing.Point(399, 82)
        Me.PictureBoxUserReg.Name = "PictureBoxUserReg"
        Me.PictureBoxUserReg.Size = New System.Drawing.Size(166, 150)
        Me.PictureBoxUserReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserReg.TabIndex = 12
        Me.PictureBoxUserReg.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(436, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Profile Image"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 617)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firebase CRUD"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSUserDataTable.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.PictureBoxUserReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnClearAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCreateID As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TBCity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TBID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelRegistration As Label
    Friend WithEvents OpenFileDialogUserImage As OpenFileDialog
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVUserData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CMSUserDataTable As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnClearSelection As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CBSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelRecordView As Label
    Friend WithEvents LblTotalUser As Label
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
    Friend WithEvents Col5 As DataGridViewTextBoxColumn
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents PictureBoxUserReg As PictureBox
    Friend WithEvents Label5 As Label
End Class
