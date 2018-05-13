namespace TaxiApp.Controlls
{
    partial class ReviewsControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.taxiDataSet = new TaxiApp.TaxiDataSet();
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsReviewTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.ClientsReviewTableAdapter();
            this.reviewIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsReviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client review";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TaxiApp.Properties.Resources.icons8_administrator_male_52;
            this.pictureBox2.Location = new System.Drawing.Point(22, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewIdDataGridViewTextBoxColumn,
            this.completedOrderDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.clientsReviewBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Snow;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(22, 69);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 40;
            this.bunifuCustomDataGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(438, 293);
            this.bunifuCustomDataGrid1.TabIndex = 6;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxiDataSetBindingSource
            // 
            this.taxiDataSetBindingSource.DataSource = this.taxiDataSet;
            this.taxiDataSetBindingSource.Position = 0;
            // 
            // clientsReviewBindingSource
            // 
            this.clientsReviewBindingSource.DataMember = "ClientsReview";
            this.clientsReviewBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // clientsReviewTableAdapter
            // 
            this.clientsReviewTableAdapter.ClearBeforeFill = true;
            // 
            // reviewIdDataGridViewTextBoxColumn
            // 
            this.reviewIdDataGridViewTextBoxColumn.DataPropertyName = "ReviewId";
            this.reviewIdDataGridViewTextBoxColumn.HeaderText = "ReviewId";
            this.reviewIdDataGridViewTextBoxColumn.Name = "reviewIdDataGridViewTextBoxColumn";
            // 
            // completedOrderDataGridViewTextBoxColumn
            // 
            this.completedOrderDataGridViewTextBoxColumn.DataPropertyName = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.HeaderText = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.Name = "completedOrderDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // ReviewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "ReviewsControl";
            this.Size = new System.Drawing.Size(702, 384);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsReviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsReviewBindingSource;
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.ClientsReviewTableAdapter clientsReviewTableAdapter;
    }
}
