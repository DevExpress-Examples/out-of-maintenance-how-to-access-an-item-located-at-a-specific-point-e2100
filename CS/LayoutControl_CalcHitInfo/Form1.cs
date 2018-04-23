using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.HitInfo;


namespace LayoutControl_CalcHitInfo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void layoutControl1_MouseDown(object sender, MouseEventArgs e) {
            LayoutControl lc = sender as LayoutControl;
            BaseLayoutItemHitInfo hi = lc.CalcHitInfo(e.Location);
            LayoutControlItem currentItem = hi.Item as LayoutControlItem;
            if (currentItem == null || hi.HitType != LayoutItemHitTest.TextArea) return;
            if(currentItem.Control != null)
                currentItem.Control.Focus();
        }
    }
}
