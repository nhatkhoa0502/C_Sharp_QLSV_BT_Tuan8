﻿namespace BT_QLSV_Tuan8
{
    partial class DanhMucMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucMonHoc));
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label soTietLabel;
            this.qLSV2DataSet = new BT_QLSV_Tuan8.QLSVDataSet();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monTableAdapter = new BT_QLSV_Tuan8.QLSV2DataSetTableAdapters.MonTableAdapter();
            this.tableAdapterManager = new BT_QLSV_Tuan8.QLSV2DataSetTableAdapters.TableAdapterManager();
            this.monBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.monBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maMHTextBox = new System.Windows.Forms.TextBox();
            this.tenMHTextBox = new System.Windows.Forms.TextBox();
            this.soTietTextBox = new System.Windows.Forms.TextBox();
            this.monDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            soTietLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).BeginInit();
            this.monBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qLSV2DataSet
            // 
            this.qLSV2DataSet.DataSetName = "QLSV2DataSet";
            this.qLSV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.qLSV2DataSet;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BT_QLSV_Tuan8.QLSV2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monBindingNavigator
            // 
            this.monBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.monBindingNavigator.BindingSource = this.monBindingSource;
            this.monBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.monBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.monBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.monBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.monBindingNavigatorSaveItem});
            this.monBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.monBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.monBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.monBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.monBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.monBindingNavigator.Name = "monBindingNavigator";
            this.monBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.monBindingNavigator.Size = new System.Drawing.Size(454, 27);
            this.monBindingNavigator.TabIndex = 0;
            this.monBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // monBindingNavigatorSaveItem
            // 
            this.monBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monBindingNavigatorSaveItem.Image")));
            this.monBindingNavigatorSaveItem.Name = "monBindingNavigatorSaveItem";
            this.monBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.monBindingNavigatorSaveItem.Text = "Save Data";
            this.monBindingNavigatorSaveItem.Click += new System.EventHandler(this.monBindingNavigatorSaveItem_Click_1);
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(124, 35);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(53, 16);
            maMHLabel.TabIndex = 1;
            maMHLabel.Text = "Ma MH:";
            // 
            // maMHTextBox
            // 
            this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "MaMH", true));
            this.maMHTextBox.Location = new System.Drawing.Point(188, 32);
            this.maMHTextBox.Name = "maMHTextBox";
            this.maMHTextBox.Size = new System.Drawing.Size(100, 22);
            this.maMHTextBox.TabIndex = 2;
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(124, 63);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(58, 16);
            tenMHLabel.TabIndex = 3;
            tenMHLabel.Text = "Ten MH:";
            // 
            // tenMHTextBox
            // 
            this.tenMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "TenMH", true));
            this.tenMHTextBox.Location = new System.Drawing.Point(188, 60);
            this.tenMHTextBox.Name = "tenMHTextBox";
            this.tenMHTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenMHTextBox.TabIndex = 4;
            // 
            // soTietLabel
            // 
            soTietLabel.AutoSize = true;
            soTietLabel.Location = new System.Drawing.Point(124, 91);
            soTietLabel.Name = "soTietLabel";
            soTietLabel.Size = new System.Drawing.Size(53, 16);
            soTietLabel.TabIndex = 5;
            soTietLabel.Text = "So Tiet:";
            // 
            // soTietTextBox
            // 
            this.soTietTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "SoTiet", true));
            this.soTietTextBox.Location = new System.Drawing.Point(188, 88);
            this.soTietTextBox.Name = "soTietTextBox";
            this.soTietTextBox.Size = new System.Drawing.Size(100, 22);
            this.soTietTextBox.TabIndex = 6;
            // 
            // monDataGridView
            // 
            this.monDataGridView.AutoGenerateColumns = false;
            this.monDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.monDataGridView.DataSource = this.monBindingSource;
            this.monDataGridView.Location = new System.Drawing.Point(12, 115);
            this.monDataGridView.Name = "monDataGridView";
            this.monDataGridView.RowHeadersWidth = 51;
            this.monDataGridView.RowTemplate.Height = 24;
            this.monDataGridView.Size = new System.Drawing.Size(430, 220);
            this.monDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTiet";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoTiet";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // DanhMucMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 339);
            this.Controls.Add(this.monDataGridView);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHTextBox);
            this.Controls.Add(tenMHLabel);
            this.Controls.Add(this.tenMHTextBox);
            this.Controls.Add(soTietLabel);
            this.Controls.Add(this.soTietTextBox);
            this.Controls.Add(this.monBindingNavigator);
            this.Name = "DanhMucMonHoc";
            this.Text = "DanhMucMonHoc";
            this.Load += new System.EventHandler(this.DanhMucMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).EndInit();
            this.monBindingNavigator.ResumeLayout(false);
            this.monBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLSVDataSet qLSV2DataSet;
        private System.Windows.Forms.BindingSource monBindingSource;
        private QLSV2DataSetTableAdapters.MonTableAdapter monTableAdapter;
        private QLSV2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator monBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton monBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maMHTextBox;
        private System.Windows.Forms.TextBox tenMHTextBox;
        private System.Windows.Forms.TextBox soTietTextBox;
        private System.Windows.Forms.DataGridView monDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}