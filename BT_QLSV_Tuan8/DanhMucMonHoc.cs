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
    public partial class DanhMucMonHoc : Form
    {
        public DanhMucMonHoc()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSV2DataSet);

        }

        private void DanhMucMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV2DataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSV2DataSet.Mon);
            // TODO: This line of code loads data into the 'qLSV2DataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSV2DataSet.SinhVien);
            // TODO: This line of code loads data into the 'qLSV2DataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSV2DataSet.Mon);

        }

        private void monBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSV2DataSet);

        }
    }
}
