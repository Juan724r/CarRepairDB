namespace CarRepairDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carWorkshop = new CarRepairDB.carWorkshop();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carOwnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carLicensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.carModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carModelIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.carModelIDDataGridViewTextBoxColumn,
            this.carOwnerIDDataGridViewTextBoxColumn,
            this.carLicensePlateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // carWorkshop
            // 
            this.carWorkshop.DataSetName = "carWorkshop";
            this.carWorkshop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carWorkshop;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // carModelIDDataGridViewTextBoxColumn
            // 
            this.carModelIDDataGridViewTextBoxColumn.DataPropertyName = "CarModelID";
            this.carModelIDDataGridViewTextBoxColumn.HeaderText = "CarModelID";
            this.carModelIDDataGridViewTextBoxColumn.Name = "carModelIDDataGridViewTextBoxColumn";
            // 
            // carOwnerIDDataGridViewTextBoxColumn
            // 
            this.carOwnerIDDataGridViewTextBoxColumn.DataPropertyName = "CarOwnerID";
            this.carOwnerIDDataGridViewTextBoxColumn.HeaderText = "CarOwnerID";
            this.carOwnerIDDataGridViewTextBoxColumn.Name = "carOwnerIDDataGridViewTextBoxColumn";
            // 
            // carLicensePlateDataGridViewTextBoxColumn
            // 
            this.carLicensePlateDataGridViewTextBoxColumn.DataPropertyName = "CarLicensePlate";
            this.carLicensePlateDataGridViewTextBoxColumn.HeaderText = "CarLicensePlate";
            this.carLicensePlateDataGridViewTextBoxColumn.Name = "carLicensePlateDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModelIDDataGridViewTextBoxColumn1,
            this.carModelNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.carModelsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(538, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // carModelsBindingSource
            // 
            this.carModelsBindingSource.DataMember = "CarModels";
            this.carModelsBindingSource.DataSource = this.carWorkshop;
            // 
            // carModelIDDataGridViewTextBoxColumn1
            // 
            this.carModelIDDataGridViewTextBoxColumn1.DataPropertyName = "CarModelID";
            this.carModelIDDataGridViewTextBoxColumn1.HeaderText = "CarModelID";
            this.carModelIDDataGridViewTextBoxColumn1.Name = "carModelIDDataGridViewTextBoxColumn1";
            // 
            // carModelNameDataGridViewTextBoxColumn
            // 
            this.carModelNameDataGridViewTextBoxColumn.DataPropertyName = "CarModelName";
            this.carModelNameDataGridViewTextBoxColumn.HeaderText = "CarModelName";
            this.carModelNameDataGridViewTextBoxColumn.Name = "carModelNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carOwnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carLicensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private carWorkshop carWorkshop;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carModelsBindingSource;
    }
}

