using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_QLSV_Tuan8
{
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }

        private void ketQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSV2DataSet);

        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV2DataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.qLSV2DataSet.KetQua);

        }
    }
}
