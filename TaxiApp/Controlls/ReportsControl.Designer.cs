namespace TaxiApp.Controlls
{
    partial class ReportsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tripReportDG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.taxiDataSet = new TaxiApp.TaxiDataSet();
            this.tripReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripReportTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.TripReportTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.OrdersTableAdapter();
            this.reportIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tripReportDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tripReportDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tripReportDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tripReportDG.AutoGenerateColumns = false;
            this.tripReportDG.BackgroundColor = System.Drawing.Color.White;
            this.tripReportDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tripReportDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tripReportDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tripReportDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripReportDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportIdDataGridViewTextBoxColumn,
            this.driverDataGridViewTextBoxColumn,
            this.completedOrderDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.tripReportDG.DataSource = this.tripReportBindingSource;
            this.tripReportDG.DoubleBuffered = true;
            this.tripReportDG.EnableHeadersVisualStyles = false;
            this.tripReportDG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.tripReportDG.HeaderForeColor = System.Drawing.Color.Snow;
            this.tripReportDG.Location = new System.Drawing.Point(22, 18);
            this.tripReportDG.Name = "tripReportDG";
            this.tripReportDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tripReportDG.RowTemplate.Height = 40;
            this.tripReportDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tripReportDG.Size = new System.Drawing.Size(537, 344);
            this.tripReportDG.TabIndex = 0;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripReportBindingSource
            // 
            this.tripReportBindingSource.DataMember = "TripReport";
            this.tripReportBindingSource.DataSource = this.taxiDataSet;
            // 
            // tripReportTableAdapter
            // 
            this.tripReportTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.taxiDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // reportIdDataGridViewTextBoxColumn
            // 
            this.reportIdDataGridViewTextBoxColumn.DataPropertyName = "ReportId";
            this.reportIdDataGridViewTextBoxColumn.HeaderText = "ReportId";
            this.reportIdDataGridViewTextBoxColumn.Name = "reportIdDataGridViewTextBoxColumn";
            this.reportIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            // 
            // completedOrderDataGridViewTextBoxColumn
            // 
            this.completedOrderDataGridViewTextBoxColumn.DataPropertyName = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.HeaderText = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.Name = "completedOrderDataGridViewTextBoxColumn";
            this.completedOrderDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tripReportDG);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(702, 384);
            ((System.ComponentModel.ISupportInitialize)(this.tripReportDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid tripReportDG;
        private System.Windows.Forms.BindingSource tripReportBindingSource;
        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.TripReportTableAdapter tripReportTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}
