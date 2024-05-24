namespace Oborudovanie
{
    partial class SotrudnikForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.oborudovanieDataSet = new Oborudovanie.OborudovanieDataSet();
            this.oborudovanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudovanieTableAdapter = new Oborudovanie.OborudovanieDataSetTableAdapters.OborudovanieTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRemontaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZaversheniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnikaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oborudovanieDataSet1 = new Oborudovanie.OborudovanieDataSet1();
            this.polzovateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polzovateliTableAdapter = new Oborudovanie.OborudovanieDataSet1TableAdapters.PolzovateliTableAdapter();
            this.oborudovanieDataSet2 = new Oborudovanie.OborudovanieDataSet2();
            this.polzovateliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polzovateliTableAdapter1 = new Oborudovanie.OborudovanieDataSet2TableAdapters.PolzovateliTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оборудование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDSotrudnikaDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.dataRemontaDataGridViewTextBoxColumn,
            this.dataZaversheniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oborudovanieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(756, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDSotrudnikaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.polzovateliBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(756, 253);
            this.dataGridView2.TabIndex = 1;
            // 
            // oborudovanieDataSet
            // 
            this.oborudovanieDataSet.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oborudovanieBindingSource
            // 
            this.oborudovanieBindingSource.DataMember = "Oborudovanie";
            this.oborudovanieBindingSource.DataSource = this.oborudovanieDataSet;
            // 
            // oborudovanieTableAdapter
            // 
            this.oborudovanieTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDSotrudnikaDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "IDSotrudnika";
            this.iDSotrudnikaDataGridViewTextBoxColumn.HeaderText = "IDSotrudnika";
            this.iDSotrudnikaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDSotrudnikaDataGridViewTextBoxColumn.Name = "iDSotrudnikaDataGridViewTextBoxColumn";
            this.iDSotrudnikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            this.naimenovanieDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataRemontaDataGridViewTextBoxColumn
            // 
            this.dataRemontaDataGridViewTextBoxColumn.DataPropertyName = "DataRemonta";
            this.dataRemontaDataGridViewTextBoxColumn.HeaderText = "DataRemonta";
            this.dataRemontaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataRemontaDataGridViewTextBoxColumn.Name = "dataRemontaDataGridViewTextBoxColumn";
            this.dataRemontaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataZaversheniaDataGridViewTextBoxColumn
            // 
            this.dataZaversheniaDataGridViewTextBoxColumn.DataPropertyName = "DataZavershenia";
            this.dataZaversheniaDataGridViewTextBoxColumn.HeaderText = "DataZavershenia";
            this.dataZaversheniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataZaversheniaDataGridViewTextBoxColumn.Name = "dataZaversheniaDataGridViewTextBoxColumn";
            this.dataZaversheniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // iDSotrudnikaDataGridViewTextBoxColumn1
            // 
            this.iDSotrudnikaDataGridViewTextBoxColumn1.DataPropertyName = "IDSotrudnika";
            this.iDSotrudnikaDataGridViewTextBoxColumn1.HeaderText = "IDSotrudnika";
            this.iDSotrudnikaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDSotrudnikaDataGridViewTextBoxColumn1.Name = "iDSotrudnikaDataGridViewTextBoxColumn1";
            this.iDSotrudnikaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // oborudovanieDataSet1
            // 
            this.oborudovanieDataSet1.DataSetName = "OborudovanieDataSet1";
            this.oborudovanieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polzovateliBindingSource
            // 
            this.polzovateliBindingSource.DataMember = "Polzovateli";
            this.polzovateliBindingSource.DataSource = this.oborudovanieDataSet1;
            // 
            // polzovateliTableAdapter
            // 
            this.polzovateliTableAdapter.ClearBeforeFill = true;
            // 
            // oborudovanieDataSet2
            // 
            this.oborudovanieDataSet2.DataSetName = "OborudovanieDataSet2";
            this.oborudovanieDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polzovateliBindingSource1
            // 
            this.polzovateliBindingSource1.DataMember = "Polzovateli";
            this.polzovateliBindingSource1.DataSource = this.oborudovanieDataSet2;
            // 
            // polzovateliTableAdapter1
            // 
            this.polzovateliTableAdapter1.ClearBeforeFill = true;
            // 
            // SotrudnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SotrudnikForm";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.SotrudnikForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private OborudovanieDataSet oborudovanieDataSet;
        private System.Windows.Forms.BindingSource oborudovanieBindingSource;
        private OborudovanieDataSetTableAdapters.OborudovanieTableAdapter oborudovanieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRemontaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZaversheniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikaDataGridViewTextBoxColumn1;
        private OborudovanieDataSet1 oborudovanieDataSet1;
        private System.Windows.Forms.BindingSource polzovateliBindingSource;
        private OborudovanieDataSet1TableAdapters.PolzovateliTableAdapter polzovateliTableAdapter;
        private OborudovanieDataSet2 oborudovanieDataSet2;
        private System.Windows.Forms.BindingSource polzovateliBindingSource1;
        private OborudovanieDataSet2TableAdapters.PolzovateliTableAdapter polzovateliTableAdapter1;
    }
}