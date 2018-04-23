Imports Microsoft.VisualBasic
Imports System
Namespace LayoutControl_CalcHitInfo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.buttonEdit4 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit3 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.buttonEdit4)
			Me.layoutControl1.Controls.Add(Me.buttonEdit3)
			Me.layoutControl1.Controls.Add(Me.buttonEdit2)
			Me.layoutControl1.Controls.Add(Me.buttonEdit1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(397, 187)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
'			Me.layoutControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.layoutControl1_MouseDown);
			' 
			' buttonEdit4
			' 
			Me.buttonEdit4.Location = New System.Drawing.Point(243, 60)
			Me.buttonEdit4.Name = "buttonEdit4"
			Me.buttonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit4.Size = New System.Drawing.Size(142, 20)
			Me.buttonEdit4.StyleController = Me.layoutControl1
			Me.buttonEdit4.TabIndex = 9
			' 
			' buttonEdit3
			' 
			Me.buttonEdit3.Location = New System.Drawing.Point(55, 60)
			Me.buttonEdit3.Name = "buttonEdit3"
			Me.buttonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit3.Size = New System.Drawing.Size(141, 20)
			Me.buttonEdit3.StyleController = Me.layoutControl1
			Me.buttonEdit3.TabIndex = 6
			' 
			' buttonEdit2
			' 
			Me.buttonEdit2.Location = New System.Drawing.Point(55, 36)
			Me.buttonEdit2.Name = "buttonEdit2"
			Me.buttonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit2.Size = New System.Drawing.Size(330, 20)
			Me.buttonEdit2.StyleController = Me.layoutControl1
			Me.buttonEdit2.TabIndex = 5
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(55, 12)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(330, 20)
			Me.buttonEdit1.StyleController = Me.layoutControl1
			Me.buttonEdit1.TabIndex = 4
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem6, Me.emptySpaceItem2, Me.simpleLabelItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(397, 187)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.buttonEdit1
			Me.layoutControlItem1.CustomizationFormText = "Name"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(377, 24)
			Me.layoutControlItem1.Text = "Name"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(39, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.buttonEdit2
			Me.layoutControlItem2.CustomizationFormText = "Title"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(377, 24)
			Me.layoutControlItem2.Text = "Title"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(39, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.buttonEdit3
			Me.layoutControlItem3.CustomizationFormText = "Phone"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(188, 24)
			Me.layoutControlItem3.Text = "Phone"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(39, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.buttonEdit4
			Me.layoutControlItem6.CustomizationFormText = "Address"
			Me.layoutControlItem6.Location = New System.Drawing.Point(188, 48)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(189, 24)
			Me.layoutControlItem6.Text = "Address"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(39, 13)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 72)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(377, 78)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' simpleLabelItem1
			' 
			Me.simpleLabelItem1.CustomizationFormText = "Click an item's caption to focus the corresponding control."
			Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 150)
			Me.simpleLabelItem1.Name = "simpleLabelItem1"
			Me.simpleLabelItem1.Size = New System.Drawing.Size(377, 17)
			Me.simpleLabelItem1.Text = "Click an item's caption to focus the corresponding control."
			Me.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.simpleLabelItem1.TextSize = New System.Drawing.Size(276, 13)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(397, 187)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private buttonEdit4 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit3 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit2 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
	End Class
End Namespace

