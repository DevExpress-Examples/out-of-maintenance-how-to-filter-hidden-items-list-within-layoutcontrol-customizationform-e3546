Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class AdvancedCustomizationForm
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
			Me.hiddenItemsList1 = New DevExpress.XtraLayout.Customization.Controls.HiddenItemsList()
			Me.layoutTreeView1 = New DevExpress.XtraLayout.Customization.Controls.LayoutTreeView()
			Me.customizationPropertyGrid1 = New DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid()
			Me.buttonsPanel1 = New DevExpress.XtraLayout.Customization.Controls.ButtonsPanel()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.hiddenItemEditor = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			CType(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.hiddenItemEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' hiddenItemsList1
			' 
			Me.hiddenItemsList1.Location = New System.Drawing.Point(24, 97)
			Me.hiddenItemsList1.Name = "hiddenItemsList1"
			Me.hiddenItemsList1.Size = New System.Drawing.Size(199, 230)
			' 
			' layoutTreeView1
			' 
			Me.layoutTreeView1.Location = New System.Drawing.Point(24, 73)
			Me.layoutTreeView1.Name = "layoutTreeView1"
			Me.layoutTreeView1.Role = DevExpress.XtraLayout.Customization.Controls.TreeViewRoles.LayoutTreeView
			Me.layoutTreeView1.ShowHiddenItemsInTreeView = True
			Me.layoutTreeView1.Size = New System.Drawing.Size(199, 254)
			' 
			' customizationPropertyGrid1
			' 
			Me.customizationPropertyGrid1.Location = New System.Drawing.Point(245, 41)
			Me.customizationPropertyGrid1.Name = "customizationPropertyGrid1"
			Me.customizationPropertyGrid1.Size = New System.Drawing.Size(218, 298)
			' 
			' buttonsPanel1
			' 
			Me.buttonsPanel1.Location = New System.Drawing.Point(12, 12)
			Me.buttonsPanel1.Name = "buttonsPanel1"
			Me.buttonsPanel1.Size = New System.Drawing.Size(100, 25)
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.hiddenItemEditor)
			Me.layoutControl1.Controls.Add(Me.hiddenItemsList1)
			Me.layoutControl1.Controls.Add(Me.buttonsPanel1)
			Me.layoutControl1.Controls.Add(Me.layoutTreeView1)
			Me.layoutControl1.Controls.Add(Me.customizationPropertyGrid1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(609, 175, 450, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(475, 351)
			Me.layoutControl1.TabIndex = 4
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' hiddenItemEditor
			' 
			Me.hiddenItemEditor.Location = New System.Drawing.Point(24, 73)
			Me.hiddenItemEditor.Name = "hiddenItemEditor"
			Me.hiddenItemEditor.Size = New System.Drawing.Size(199, 20)
			Me.hiddenItemEditor.StyleController = Me.layoutControl1
			Me.hiddenItemEditor.TabIndex = 4
'			Me.hiddenItemEditor.EditValueChanged += New System.EventHandler(Me.OnHiddenItemEditorValueChanged);
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.tabbedControlGroup1, Me.layoutControlItem4, Me.layoutControlItem2, Me.splitterItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(475, 351)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' tabbedControlGroup1
			' 
			Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
			Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 29)
			Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
			Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup2
			Me.tabbedControlGroup1.SelectedTabPageIndex = 0
			Me.tabbedControlGroup1.Size = New System.Drawing.Size(227, 302)
			Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup3})
			Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem5})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(203, 258)
			Me.layoutControlGroup2.Text = "Hidden Items"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.hiddenItemsList1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(203, 234)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.hiddenItemEditor
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(203, 24)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(203, 258)
			Me.layoutControlGroup3.Text = "Layout Tree View"
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.layoutTreeView1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(203, 258)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.buttonsPanel1
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(455, 29)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.customizationPropertyGrid1
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(233, 29)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(222, 302)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(227, 29)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 302)
			' 
			' AdvancedCustomizationForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(475, 351)
			Me.Controls.Add(Me.layoutControl1)
			Me.MinimumSize = New System.Drawing.Size(200, 96)
			Me.Name = "AdvancedCustomizationForm"
			Me.Text = "AdvancedCustomizationForm"
			CType(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.hiddenItemEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private hiddenItemsList1 As DevExpress.XtraLayout.Customization.Controls.HiddenItemsList
		Private layoutTreeView1 As DevExpress.XtraLayout.Customization.Controls.LayoutTreeView
		Private customizationPropertyGrid1 As DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid
		Private buttonsPanel1 As DevExpress.XtraLayout.Customization.Controls.ButtonsPanel
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents hiddenItemEditor As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
	End Class
End Namespace