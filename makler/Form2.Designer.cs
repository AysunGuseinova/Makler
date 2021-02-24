namespace makler
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database101DataSet1 = new makler.Database101DataSet1();
            this.maklerTableAdapter = new makler.Database101DataSet1TableAdapters.maklerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tikintinovuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mertebeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otaqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rayonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qiymetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maklerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1011DataSet2 = new makler.Database1011DataSet2();
            this.maklerTableAdapter1 = new makler.Database1011DataSet2TableAdapters.maklerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.maklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database101DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1011DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sahibin adi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kontrakt nomresi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "axtar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maklerBindingSource
            // 
            this.maklerBindingSource.DataMember = "makler";
            this.maklerBindingSource.DataSource = this.database101DataSet1;
            // 
            // database101DataSet1
            // 
            this.database101DataSet1.DataSetName = "Database101DataSet1";
            this.database101DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maklerTableAdapter
            // 
            this.maklerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomreDataGridViewTextBoxColumn,
            this.tikintinovuDataGridViewTextBoxColumn,
            this.temirDataGridViewTextBoxColumn,
            this.mertebeDataGridViewTextBoxColumn,
            this.otaqDataGridViewTextBoxColumn,
            this.rayonDataGridViewTextBoxColumn,
            this.saheDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.qiymetDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maklerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1020, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // nomreDataGridViewTextBoxColumn
            // 
            this.nomreDataGridViewTextBoxColumn.DataPropertyName = "nomre";
            this.nomreDataGridViewTextBoxColumn.HeaderText = "nomre";
            this.nomreDataGridViewTextBoxColumn.Name = "nomreDataGridViewTextBoxColumn";
            // 
            // tikintinovuDataGridViewTextBoxColumn
            // 
            this.tikintinovuDataGridViewTextBoxColumn.DataPropertyName = "tikinti_novu";
            this.tikintinovuDataGridViewTextBoxColumn.HeaderText = "tikinti_novu";
            this.tikintinovuDataGridViewTextBoxColumn.Name = "tikintinovuDataGridViewTextBoxColumn";
            // 
            // temirDataGridViewTextBoxColumn
            // 
            this.temirDataGridViewTextBoxColumn.DataPropertyName = "temir";
            this.temirDataGridViewTextBoxColumn.HeaderText = "temir";
            this.temirDataGridViewTextBoxColumn.Name = "temirDataGridViewTextBoxColumn";
            // 
            // mertebeDataGridViewTextBoxColumn
            // 
            this.mertebeDataGridViewTextBoxColumn.DataPropertyName = "mertebe";
            this.mertebeDataGridViewTextBoxColumn.HeaderText = "mertebe";
            this.mertebeDataGridViewTextBoxColumn.Name = "mertebeDataGridViewTextBoxColumn";
            // 
            // otaqDataGridViewTextBoxColumn
            // 
            this.otaqDataGridViewTextBoxColumn.DataPropertyName = "otaq";
            this.otaqDataGridViewTextBoxColumn.HeaderText = "otaq";
            this.otaqDataGridViewTextBoxColumn.Name = "otaqDataGridViewTextBoxColumn";
            // 
            // rayonDataGridViewTextBoxColumn
            // 
            this.rayonDataGridViewTextBoxColumn.DataPropertyName = "rayon";
            this.rayonDataGridViewTextBoxColumn.HeaderText = "rayon";
            this.rayonDataGridViewTextBoxColumn.Name = "rayonDataGridViewTextBoxColumn";
            // 
            // saheDataGridViewTextBoxColumn
            // 
            this.saheDataGridViewTextBoxColumn.DataPropertyName = "sahe";
            this.saheDataGridViewTextBoxColumn.HeaderText = "sahe";
            this.saheDataGridViewTextBoxColumn.Name = "saheDataGridViewTextBoxColumn";
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "unvan";
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            // 
            // qiymetDataGridViewTextBoxColumn
            // 
            this.qiymetDataGridViewTextBoxColumn.DataPropertyName = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.HeaderText = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.Name = "qiymetDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maklerBindingSource1
            // 
            this.maklerBindingSource1.DataMember = "makler";
            this.maklerBindingSource1.DataSource = this.database1011DataSet2;
            // 
            // database1011DataSet2
            // 
            this.database1011DataSet2.DataSetName = "Database1011DataSet2";
            this.database1011DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maklerTableAdapter1
            // 
            this.maklerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database101DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1011DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Database101DataSet1 database101DataSet1;
        private System.Windows.Forms.BindingSource maklerBindingSource;
        private Database101DataSet1TableAdapters.maklerTableAdapter maklerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1011DataSet2 database1011DataSet2;
        private System.Windows.Forms.BindingSource maklerBindingSource1;
        private Database1011DataSet2TableAdapters.maklerTableAdapter maklerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tikintinovuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mertebeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otaqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rayonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qiymetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}