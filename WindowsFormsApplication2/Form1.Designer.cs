namespace WindowsFormsApplication2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.dataSet11 = new WindowsFormsApplication2.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rágóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leszokásBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leszokásBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leszokásBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leszokásBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Save";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rágóDataGridViewTextBoxColumn,
            this.cigiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leszokásBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // rágóDataGridViewTextBoxColumn
            // 
            this.rágóDataGridViewTextBoxColumn.DataPropertyName = "rágó";
            this.rágóDataGridViewTextBoxColumn.HeaderText = "rágó";
            this.rágóDataGridViewTextBoxColumn.Name = "rágóDataGridViewTextBoxColumn";
            // 
            // cigiDataGridViewTextBoxColumn
            // 
            this.cigiDataGridViewTextBoxColumn.DataPropertyName = "cigi";
            this.cigiDataGridViewTextBoxColumn.HeaderText = "cigi";
            this.cigiDataGridViewTextBoxColumn.Name = "cigiDataGridViewTextBoxColumn";
            // 
            // leszokásBindingSource
            // 
            this.leszokásBindingSource.DataMember = "leszokás";
            this.leszokásBindingSource.DataSource = this.dataSet11;
            // 
            // leszokásBindingSource1
            // 
            this.leszokásBindingSource1.DataMember = "leszokás";
            this.leszokásBindingSource1.DataSource = this.dataSet11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "program name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trainButton
            // 
            this.trainButton.AccessibleName = "trainButton";
            this.trainButton.Location = new System.Drawing.Point(93, 12);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(75, 23);
            this.trainButton.TabIndex = 4;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leszokásBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leszokásBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Start;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rágóDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource leszokásBindingSource;
        private System.Windows.Forms.BindingSource leszokásBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trainButton;
    }
}

