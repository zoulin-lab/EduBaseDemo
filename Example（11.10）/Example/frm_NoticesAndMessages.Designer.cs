namespace Example
{
    partial class frm_NoticesAndMessages
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eduBaseBigHomeworkDataSet = new Example.EduBaseBigHomeworkDataSet();
            this.tbNoticeAndMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_NoticeAndMessageTableAdapter = new Example.EduBaseBigHomeworkDataSetTableAdapters.tb_NoticeAndMessageTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBaseBigHomeworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeAndMessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.transmitTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbNoticeAndMessageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(726, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // eduBaseBigHomeworkDataSet
            // 
            this.eduBaseBigHomeworkDataSet.DataSetName = "EduBaseBigHomeworkDataSet";
            this.eduBaseBigHomeworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNoticeAndMessageBindingSource
            // 
            this.tbNoticeAndMessageBindingSource.DataMember = "tb_NoticeAndMessage";
            this.tbNoticeAndMessageBindingSource.DataSource = this.eduBaseBigHomeworkDataSet;
            // 
            // tb_NoticeAndMessageTableAdapter
            // 
            this.tb_NoticeAndMessageTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // transmitTimeDataGridViewTextBoxColumn
            // 
            this.transmitTimeDataGridViewTextBoxColumn.DataPropertyName = "TransmitTime";
            this.transmitTimeDataGridViewTextBoxColumn.HeaderText = "TransmitTime";
            this.transmitTimeDataGridViewTextBoxColumn.Name = "transmitTimeDataGridViewTextBoxColumn";
            // 
            // frm_NoticesAndMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_NoticesAndMessages";
            this.Text = "frm_NoticesAndMessages";
            this.Load += new System.EventHandler(this.frm_NoticesAndMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBaseBigHomeworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeAndMessageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EduBaseBigHomeworkDataSet eduBaseBigHomeworkDataSet;
        private System.Windows.Forms.BindingSource tbNoticeAndMessageBindingSource;
        private EduBaseBigHomeworkDataSetTableAdapters.tb_NoticeAndMessageTableAdapter tb_NoticeAndMessageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmitTimeDataGridViewTextBoxColumn;
    }
}