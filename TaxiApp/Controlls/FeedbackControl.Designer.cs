namespace TaxiApp.Controlls
{
    partial class FeedbackControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackControl));
            this.feedbackDG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.feedbackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiApp.TaxiDataSet();
            this.feedbackTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.FeedbackTableAdapter();
            this.printImage = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printImage)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.feedbackDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.feedbackDG.AutoGenerateColumns = false;
            this.feedbackDG.BackgroundColor = System.Drawing.Color.White;
            this.feedbackDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedbackDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.feedbackDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorEmailDataGridViewTextBoxColumn});
            this.feedbackDG.DataSource = this.feedbackBindingSource;
            this.feedbackDG.DoubleBuffered = true;
            this.feedbackDG.EnableHeadersVisualStyles = false;
            this.feedbackDG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.feedbackDG.HeaderForeColor = System.Drawing.Color.Snow;
            this.feedbackDG.Location = new System.Drawing.Point(22, 18);
            this.feedbackDG.Name = "feedbackDG";
            this.feedbackDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackDG.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.feedbackDG.RowTemplate.Height = 40;
            this.feedbackDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedbackDG.Size = new System.Drawing.Size(591, 344);
            this.feedbackDG.TabIndex = 2;
            // 
            // feedbackIdDataGridViewTextBoxColumn
            // 
            this.feedbackIdDataGridViewTextBoxColumn.DataPropertyName = "FeedbackId";
            this.feedbackIdDataGridViewTextBoxColumn.HeaderText = "FeedbackId";
            this.feedbackIdDataGridViewTextBoxColumn.Name = "feedbackIdDataGridViewTextBoxColumn";
            this.feedbackIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorEmailDataGridViewTextBoxColumn
            // 
            this.authorEmailDataGridViewTextBoxColumn.DataPropertyName = "AuthorEmail";
            this.authorEmailDataGridViewTextBoxColumn.HeaderText = "AuthorEmail";
            this.authorEmailDataGridViewTextBoxColumn.Name = "authorEmailDataGridViewTextBoxColumn";
            this.authorEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "Feedback";
            this.feedbackBindingSource.DataSource = this.taxiDataSet;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // printImage
            // 
            this.printImage.Image = global::TaxiApp.Properties.Resources.icons8_print_52;
            this.printImage.Location = new System.Drawing.Point(631, 18);
            this.printImage.Name = "printImage";
            this.printImage.Size = new System.Drawing.Size(20, 20);
            this.printImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printImage.TabIndex = 3;
            this.printImage.TabStop = false;
            this.printImage.Click += new System.EventHandler(this.printImage_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printImage);
            this.Controls.Add(this.feedbackDG);
            this.Name = "FeedbackControl";
            this.Size = new System.Drawing.Size(702, 384);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid feedbackDG;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox printImage;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
