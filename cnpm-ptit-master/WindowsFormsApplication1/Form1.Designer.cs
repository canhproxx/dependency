namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.txtLoailenh = new System.Windows.Forms.TextBox();
            this.btnDatlenh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBan = new System.Windows.Forms.RadioButton();
            this.rbMua = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAILENHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAILENHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUNGKHOANDataSet = new WindowsFormsApplication1.CHUNGKHOANDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lENHDATTableAdapter = new WindowsFormsApplication1.CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.datePick);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtSl);
            this.panel1.Controls.Add(this.txtMaCP);
            this.panel1.Controls.Add(this.txtLoailenh);
            this.panel1.Controls.Add(this.btnDatlenh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbBan);
            this.panel1.Controls.Add(this.rbMua);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 272);
            this.panel1.TabIndex = 0;
            // 
            // datePick
            // 
            this.datePick.Enabled = false;
            this.datePick.Location = new System.Drawing.Point(59, 204);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(144, 20);
            this.datePick.TabIndex = 11;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(79, 159);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 10;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(79, 120);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(100, 20);
            this.txtSl.TabIndex = 9;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(79, 82);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(100, 20);
            this.txtMaCP.TabIndex = 8;
            // 
            // txtLoailenh
            // 
            this.txtLoailenh.Enabled = false;
            this.txtLoailenh.Location = new System.Drawing.Point(79, 43);
            this.txtLoailenh.Name = "txtLoailenh";
            this.txtLoailenh.Size = new System.Drawing.Size(100, 20);
            this.txtLoailenh.TabIndex = 7;
            this.txtLoailenh.TextChanged += new System.EventHandler(this.Loailenh_TextChanged);
            // 
            // btnDatlenh
            // 
            this.btnDatlenh.Location = new System.Drawing.Point(59, 230);
            this.btnDatlenh.Name = "btnDatlenh";
            this.btnDatlenh.Size = new System.Drawing.Size(75, 23);
            this.btnDatlenh.TabIndex = 6;
            this.btnDatlenh.Text = "Đặt lệnh";
            this.btnDatlenh.UseVisualStyleBackColor = true;
            this.btnDatlenh.Click += new System.EventHandler(this.btnDatlenh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại lệnh";
            // 
            // rbBan
            // 
            this.rbBan.AutoSize = true;
            this.rbBan.Location = new System.Drawing.Point(132, 3);
            this.rbBan.Name = "rbBan";
            this.rbBan.Size = new System.Drawing.Size(47, 17);
            this.rbBan.TabIndex = 1;
            this.rbBan.Text = "BÁN";
            this.rbBan.UseVisualStyleBackColor = true;
            this.rbBan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbMua
            // 
            this.rbMua.AutoSize = true;
            this.rbMua.Checked = true;
            this.rbMua.Location = new System.Drawing.Point(16, 3);
            this.rbMua.Name = "rbMua";
            this.rbMua.Size = new System.Drawing.Size(49, 17);
            this.rbMua.TabIndex = 0;
            this.rbMua.TabStop = true;
            this.rbMua.Text = "MUA";
            this.rbMua.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(236, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 271);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mACPDataGridViewTextBoxColumn,
            this.nGAYDATDataGridViewTextBoxColumn,
            this.lOAIGDDataGridViewTextBoxColumn,
            this.lOAILENHDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.gIADATDataGridViewTextBoxColumn,
            this.tRANGTHAILENHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lENHDATBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mACPDataGridViewTextBoxColumn
            // 
            this.mACPDataGridViewTextBoxColumn.DataPropertyName = "MACP";
            this.mACPDataGridViewTextBoxColumn.HeaderText = "MACP";
            this.mACPDataGridViewTextBoxColumn.Name = "mACPDataGridViewTextBoxColumn";
            // 
            // nGAYDATDataGridViewTextBoxColumn
            // 
            this.nGAYDATDataGridViewTextBoxColumn.DataPropertyName = "NGAYDAT";
            this.nGAYDATDataGridViewTextBoxColumn.HeaderText = "NGAYDAT";
            this.nGAYDATDataGridViewTextBoxColumn.Name = "nGAYDATDataGridViewTextBoxColumn";
            // 
            // lOAIGDDataGridViewTextBoxColumn
            // 
            this.lOAIGDDataGridViewTextBoxColumn.DataPropertyName = "LOAIGD";
            this.lOAIGDDataGridViewTextBoxColumn.HeaderText = "LOAIGD";
            this.lOAIGDDataGridViewTextBoxColumn.Name = "lOAIGDDataGridViewTextBoxColumn";
            // 
            // lOAILENHDataGridViewTextBoxColumn
            // 
            this.lOAILENHDataGridViewTextBoxColumn.DataPropertyName = "LOAILENH";
            this.lOAILENHDataGridViewTextBoxColumn.HeaderText = "LOAILENH";
            this.lOAILENHDataGridViewTextBoxColumn.Name = "lOAILENHDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // gIADATDataGridViewTextBoxColumn
            // 
            this.gIADATDataGridViewTextBoxColumn.DataPropertyName = "GIADAT";
            this.gIADATDataGridViewTextBoxColumn.HeaderText = "GIADAT";
            this.gIADATDataGridViewTextBoxColumn.Name = "gIADATDataGridViewTextBoxColumn";
            // 
            // tRANGTHAILENHDataGridViewTextBoxColumn
            // 
            this.tRANGTHAILENHDataGridViewTextBoxColumn.DataPropertyName = "TRANGTHAILENH";
            this.tRANGTHAILENHDataGridViewTextBoxColumn.HeaderText = "TRANGTHAILENH";
            this.tRANGTHAILENHDataGridViewTextBoxColumn.Name = "tRANGTHAILENHDataGridViewTextBoxColumn";
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            this.lENHDATBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(13, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 49);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bảng Giá Trực Tuyến";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lENHDATTableAdapter
            // 
            this.lENHDATTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 347);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.TextBox txtLoailenh;
        private System.Windows.Forms.Button btnDatlenh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBan;
        private System.Windows.Forms.RadioButton rbMua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAILENHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAILENHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

