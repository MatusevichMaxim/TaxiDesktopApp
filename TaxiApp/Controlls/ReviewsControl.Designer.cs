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
            this.reviewsDG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clientsReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiApp.TaxiDataSet();
            this.clientsReviewTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.ClientsReviewTableAdapter();
            this.reviewIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsReviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
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
            // reviewsDG
            // 
            this.reviewsDG.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reviewsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reviewsDG.AutoGenerateColumns = false;
            this.reviewsDG.BackgroundColor = System.Drawing.Color.White;
            this.reviewsDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reviewsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reviewsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewIdDataGridViewTextBoxColumn,
            this.completedOrderDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.reviewsDG.DataSource = this.clientsReviewBindingSource;
            this.reviewsDG.DoubleBuffered = true;
            this.reviewsDG.EnableHeadersVisualStyles = false;
            this.reviewsDG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.reviewsDG.HeaderForeColor = System.Drawing.Color.Snow;
            this.reviewsDG.Location = new System.Drawing.Point(22, 69);
            this.reviewsDG.Name = "reviewsDG";
            this.reviewsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reviewsDG.RowTemplate.Height = 40;
            this.reviewsDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewsDG.Size = new System.Drawing.Size(469, 293);
            this.reviewsDG.TabIndex = 6;
            // 
            // clientsReviewBindingSource
            // 
            this.clientsReviewBindingSource.DataMember = "ClientsReview";
            this.clientsReviewBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // taxiDataSetBindingSource
            // 
            this.taxiDataSetBindingSource.DataSource = this.taxiDataSet;
            this.taxiDataSetBindingSource.Position = 0;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reviewIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completedOrderDataGridViewTextBoxColumn
            // 
            this.completedOrderDataGridViewTextBoxColumn.DataPropertyName = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.HeaderText = "CompletedOrder";
            this.completedOrderDataGridViewTextBoxColumn.Name = "completedOrderDataGridViewTextBoxColumn";
            this.completedOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.completedOrderDataGridViewTextBoxColumn.Width = 130;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReviewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reviewsDG);
            this.Name = "ReviewsControl";
            this.Size = new System.Drawing.Size(702, 384);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsReviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid reviewsDG;
        private System.Windows.Forms.BindingSource clientsReviewBindingSource;
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.ClientsReviewTableAdapter clientsReviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}
