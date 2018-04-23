Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections
Imports DevExpress.XtraLayout

Namespace DXSample
    Partial Public Class AdvancedCustomizationForm
        Inherits DevExpress.XtraLayout.Customization.UserCustomizationForm

        Private needUpdateHiddenItems As Integer = 0

        Public Sub New()
            InitializeComponent()
            AddHandler hiddenItemsList1.Items.ListChanged, AddressOf OnItemsListChanged
        End Sub

        Private ReadOnly Property SearchText() As String
            Get
                Return hiddenItemEditor.Text.ToUpper()
            End Get
        End Property

        Private Sub BeginFilterItems()
            needUpdateHiddenItems += 1
        End Sub

        Private Sub EndFilterItems()
            needUpdateHiddenItems -= 1
        End Sub

        Private ReadOnly Property CanFilterItems() As Boolean
            Get
                Return needUpdateHiddenItems = 0
            End Get
        End Property

        Private Sub OnItemsListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            FilterHiddenItems()
        End Sub

        Private Sub OnHiddenItemEditorValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles hiddenItemEditor.EditValueChanged
            FilterHiddenItems()
        End Sub

        Private Sub FilterHiddenItems()
            If (Not CanFilterItems) OrElse hiddenItemsList1.Items.Count < OwnerControl.HiddenItems.FixedItemsCount OrElse OwnerControl Is Nothing OrElse OwnerControl.HiddenItems Is Nothing Then
                Return
            End If
            BeginFilterItems()
            Do While hiddenItemsList1.Items.Count <> OwnerControl.HiddenItems.FixedItemsCount
               hiddenItemsList1.Items.RemoveAt(hiddenItemsList1.Items.Count - 1)
            Loop
            For Each nonFixedItem As BaseLayoutItem In OwnerControl.HiddenItems
                If nonFixedItem.ShowInCustomizationForm AndAlso nonFixedItem.Name.ToUpper().StartsWith(SearchText) Then
                    hiddenItemsList1.Items.Add(nonFixedItem)
                End If
            Next nonFixedItem
            EndFilterItems()
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            MyBase.OnFormClosing(e)
            RemoveHandler hiddenItemsList1.Items.ListChanged, AddressOf OnItemsListChanged
        End Sub
    End Class
End Namespace