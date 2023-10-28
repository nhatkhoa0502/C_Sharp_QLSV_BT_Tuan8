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
    public partial class DanhMucKhoa : Form
    {
        public DanhMucKhoa()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSV2DataSet);

        }

        private void DanhMucKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV2DataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSV2DataSet.Khoa);
            // TODO: This line of code loads data into the 'qLSV2DataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSV2DataSet.Khoa);

        }

        private void khoaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSV2DataSet);

        }
    }
}
