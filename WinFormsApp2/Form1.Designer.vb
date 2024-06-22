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
        Blue_Plank = New Label()
        App_Idenfire = New Label()
        First_Name_Idenfire = New Label()
        Last_Name_Idenfire = New Label()
        Gender_Idenfire = New Label()
        First_Name_txt = New TextBox()
        Last_Name_txt = New TextBox()
        KeywordTextBox = New TextBox()
        Gender_cbx = New ComboBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        Data_dgv = New DataGridView()
        Insert_bt = New Button()
        Update_bt = New Button()
        Delete_bt = New Button()
        Search_bt = New Button()
        StatusStrip1.SuspendLayout()
        CType(Data_dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Blue_Plank
        ' 
        Blue_Plank.AutoSize = True
        Blue_Plank.BackColor = Color.Teal
        Blue_Plank.Font = New Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Blue_Plank.ForeColor = Color.Teal
        Blue_Plank.Location = New Point(-7, -4)
        Blue_Plank.Name = "Blue_Plank"
        Blue_Plank.Size = New Size(1189, 159)
        Blue_Plank.TabIndex = 0
        Blue_Plank.Text = "                                  "
        ' 
        ' App_Idenfire
        ' 
        App_Idenfire.AutoSize = True
        App_Idenfire.BackColor = Color.Teal
        App_Idenfire.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        App_Idenfire.ForeColor = SystemColors.Window
        App_Idenfire.Location = New Point(30, 49)
        App_Idenfire.Name = "App_Idenfire"
        App_Idenfire.Size = New Size(741, 54)
        App_Idenfire.TabIndex = 1
        App_Idenfire.Text = "VB.NET and MS Access : SMART CRUD"
        ' 
        ' First_Name_Idenfire
        ' 
        First_Name_Idenfire.AutoSize = True
        First_Name_Idenfire.Font = New Font("Segoe UI", 16.2F)
        First_Name_Idenfire.Location = New Point(30, 172)
        First_Name_Idenfire.Name = "First_Name_Idenfire"
        First_Name_Idenfire.Size = New Size(157, 38)
        First_Name_Idenfire.TabIndex = 2
        First_Name_Idenfire.Text = "First Name:"
        ' 
        ' Last_Name_Idenfire
        ' 
        Last_Name_Idenfire.AutoSize = True
        Last_Name_Idenfire.Font = New Font("Segoe UI", 16.2F)
        Last_Name_Idenfire.Location = New Point(30, 234)
        Last_Name_Idenfire.Name = "Last_Name_Idenfire"
        Last_Name_Idenfire.Size = New Size(153, 38)
        Last_Name_Idenfire.TabIndex = 3
        Last_Name_Idenfire.Text = "Last Name:"
        ' 
        ' Gender_Idenfire
        ' 
        Gender_Idenfire.AutoSize = True
        Gender_Idenfire.Font = New Font("Segoe UI", 16.2F)
        Gender_Idenfire.Location = New Point(30, 284)
        Gender_Idenfire.Name = "Gender_Idenfire"
        Gender_Idenfire.Size = New Size(114, 38)
        Gender_Idenfire.TabIndex = 4
        Gender_Idenfire.Text = "Gender:"
        ' 
        ' First_Name_txt
        ' 
        First_Name_txt.Location = New Point(193, 183)
        First_Name_txt.Name = "First_Name_txt"
        First_Name_txt.Size = New Size(187, 27)
        First_Name_txt.TabIndex = 5
        First_Name_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Last_Name_txt
        ' 
        Last_Name_txt.Location = New Point(193, 245)
        Last_Name_txt.Name = "Last_Name_txt"
        Last_Name_txt.Size = New Size(187, 27)
        Last_Name_txt.TabIndex = 7
        Last_Name_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' KeywordTextBox
        ' 
        KeywordTextBox.Location = New Point(794, 63)
        KeywordTextBox.Name = "KeywordTextBox"
        KeywordTextBox.Size = New Size(187, 27)
        KeywordTextBox.TabIndex = 8
        KeywordTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gender_cbx
        ' 
        Gender_cbx.FormattingEnabled = True
        Gender_cbx.Items.AddRange(New Object() {"Male", "Female"})
        Gender_cbx.Location = New Point(193, 295)
        Gender_cbx.Name = "Gender_cbx"
        Gender_cbx.Size = New Size(187, 28)
        Gender_cbx.TabIndex = 9
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 569)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1176, 26)
        StatusStrip1.TabIndex = 10
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.ForeColor = Color.Red
        ToolStripStatusLabel1.LinkColor = Color.LightGray
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(130, 20)
        ToolStripStatusLabel1.Text = "number of row(s): "
        ' 
        ' Data_dgv
        ' 
        Data_dgv.AllowUserToAddRows = False
        Data_dgv.AllowUserToDeleteRows = False
        Data_dgv.AllowUserToResizeColumns = False
        Data_dgv.AllowUserToResizeRows = False
        Data_dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Data_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Data_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_dgv.Location = New Point(12, 341)
        Data_dgv.Name = "Data_dgv"
        Data_dgv.ReadOnly = True
        Data_dgv.RowHeadersWidth = 51
        Data_dgv.Size = New Size(1146, 225)
        Data_dgv.TabIndex = 12
        ' 
        ' Insert_bt
        ' 
        Insert_bt.Font = New Font("Segoe UI", 13.8F)
        Insert_bt.Location = New Point(441, 183)
        Insert_bt.Name = "Insert_bt"
        Insert_bt.Size = New Size(199, 139)
        Insert_bt.TabIndex = 13
        Insert_bt.Text = "INSERT"
        Insert_bt.UseVisualStyleBackColor = True
        ' 
        ' Update_bt
        ' 
        Update_bt.Font = New Font("Segoe UI", 13.8F)
        Update_bt.Location = New Point(665, 183)
        Update_bt.Name = "Update_bt"
        Update_bt.Size = New Size(199, 139)
        Update_bt.TabIndex = 14
        Update_bt.Text = "Update"
        Update_bt.UseVisualStyleBackColor = True
        ' 
        ' Delete_bt
        ' 
        Delete_bt.Font = New Font("Segoe UI", 13.8F)
        Delete_bt.Location = New Point(895, 183)
        Delete_bt.Name = "Delete_bt"
        Delete_bt.Size = New Size(199, 139)
        Delete_bt.TabIndex = 15
        Delete_bt.Text = "Delete"
        Delete_bt.UseVisualStyleBackColor = True
        ' 
        ' Search_bt
        ' 
        Search_bt.Font = New Font("Segoe UI", 14F)
        Search_bt.ForeColor = Color.Red
        Search_bt.Location = New Point(1002, 55)
        Search_bt.Name = "Search_bt"
        Search_bt.Size = New Size(126, 42)
        Search_bt.TabIndex = 16
        Search_bt.Text = "Search"
        Search_bt.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1176, 595)
        Controls.Add(Search_bt)
        Controls.Add(Delete_bt)
        Controls.Add(Update_bt)
        Controls.Add(Insert_bt)
        Controls.Add(Data_dgv)
        Controls.Add(StatusStrip1)
        Controls.Add(Gender_cbx)
        Controls.Add(KeywordTextBox)
        Controls.Add(Last_Name_txt)
        Controls.Add(First_Name_txt)
        Controls.Add(Gender_Idenfire)
        Controls.Add(Last_Name_Idenfire)
        Controls.Add(First_Name_Idenfire)
        Controls.Add(App_Idenfire)
        Controls.Add(Blue_Plank)
        Name = "Form1"
        Text = "SMART CRUD"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(Data_dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Blue_Plank As Label
    Friend WithEvents App_Idenfire As Label
    Friend WithEvents First_Name_Idenfire As Label
    Friend WithEvents Last_Name_Idenfire As Label
    Friend WithEvents Gender_Idenfire As Label
    Friend WithEvents First_Name_txt As TextBox
    Friend WithEvents Last_Name_txt As TextBox
    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents Gender_cbx As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Data_dgv As DataGridView
    Friend WithEvents Insert_bt As Button
    Friend WithEvents Update_bt As Button
    Friend WithEvents Delete_bt As Button
    Friend WithEvents Search_bt As Button

End Class
