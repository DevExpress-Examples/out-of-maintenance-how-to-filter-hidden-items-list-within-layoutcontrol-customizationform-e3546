using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraLayout;

namespace DXSample
{
    public partial class AdvancedCustomizationForm : DevExpress.XtraLayout.Customization.UserCustomizationForm 
    {
        int needUpdateHiddenItems = 0;

        public AdvancedCustomizationForm()
        {
            InitializeComponent();
            hiddenItemsList1.Items.ListChanged += OnItemsListChanged;
        }

        string SearchText
        {
            get { return hiddenItemEditor.Text.ToUpper(); }
        }

        void BeginFilterItems()
        {
            needUpdateHiddenItems++;
        }

        void EndFilterItems()
        {
            needUpdateHiddenItems--;
        }

        bool CanFilterItems
        {
            get { return needUpdateHiddenItems == 0; }
        }

        void OnItemsListChanged(object sender, ListChangedEventArgs e)
        {
            FilterHiddenItems();
        }

        private void OnHiddenItemEditorValueChanged(object sender, EventArgs e)
        {
            FilterHiddenItems();
        }

        void FilterHiddenItems()
        {
            if (!CanFilterItems || hiddenItemsList1.Items.Count < OwnerControl.HiddenItems.FixedItemsCount 
                 || OwnerControl == null || OwnerControl.HiddenItems == null) return;
            BeginFilterItems();
            while (hiddenItemsList1.Items.Count != OwnerControl.HiddenItems.FixedItemsCount)
               hiddenItemsList1.Items.RemoveAt(hiddenItemsList1.Items.Count - 1);
            foreach (BaseLayoutItem nonFixedItem in OwnerControl.HiddenItems)
                if (nonFixedItem.ShowInCustomizationForm && nonFixedItem.Name.ToUpper().StartsWith(SearchText))
                    hiddenItemsList1.Items.Add(nonFixedItem);
            EndFilterItems();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            hiddenItemsList1.Items.ListChanged -= OnItemsListChanged;
        }
    }
}