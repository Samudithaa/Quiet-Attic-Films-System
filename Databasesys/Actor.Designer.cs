namespace Databasesys
{
    partial class Actor
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
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet6 = new Databasesys.QuietatticDataSet6();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtactorid = new System.Windows.Forms.TextBox();
            this.datagridactor = new System.Windows.Forms.DataGridView();
            this.actorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet10 = new Databasesys.QuietatticDataSet10();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.actorTableAdapter = new Databasesys.QuietatticDataSet10TableAdapters.ActorTableAdapter();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "Actor";
            this.actorBindingSource.DataSource = this.quietatticDataSet6;
            // 
            // quietatticDataSet6
            // 
            this.quietatticDataSet6.DataSetName = "QuietatticDataSet6";
            this.quietatticDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(13, 618);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(126, 51);
            this.btnback.TabIndex = 140;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 85);
            this.panel1.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(456, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 57);
            this.label1.TabIndex = 45;
            this.label1.Text = "Quiet Attic Films";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Adobe Fangsong Std R", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 35);
            this.label8.TabIndex = 138;
            this.label8.Text = "Actor";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(662, 682);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 58);
            this.btndelete.TabIndex = 137;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(492, 682);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 58);
            this.btnupdate.TabIndex = 136;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(331, 682);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(147, 58);
            this.btninsert.TabIndex = 135;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(331, 141);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 134;
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(331, 339);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(478, 31);
            this.txtsalary.TabIndex = 133;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(331, 297);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(478, 31);
            this.txtaddr.TabIndex = 131;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(331, 256);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(478, 31);
            this.txtname.TabIndex = 130;
            // 
            // txtactorid
            // 
            this.txtactorid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactorid.Location = new System.Drawing.Point(331, 217);
            this.txtactorid.Name = "txtactorid";
            this.txtactorid.Size = new System.Drawing.Size(478, 31);
            this.txtactorid.TabIndex = 129;
            // 
            // datagridactor
            // 
            this.datagridactor.AutoGenerateColumns = false;
            this.datagridactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorIDDataGridViewTextBoxColumn,
            this.actorNameDataGridViewTextBoxColumn,
            this.actorAddressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.contNoDataGridViewTextBoxColumn});
            this.datagridactor.DataSource = this.actorBindingSource1;
            this.datagridactor.Location = new System.Drawing.Point(331, 438);
            this.datagridactor.Name = "datagridactor";
            this.datagridactor.RowHeadersWidth = 51;
            this.datagridactor.RowTemplate.Height = 24;
            this.datagridactor.Size = new System.Drawing.Size(946, 226);
            this.datagridactor.TabIndex = 128;
            this.datagridactor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridactor_CellContentClick);
            // 
            // actorIDDataGridViewTextBoxColumn
            // 
            this.actorIDDataGridViewTextBoxColumn.DataPropertyName = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn.HeaderText = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actorIDDataGridViewTextBoxColumn.Name = "actorIDDataGridViewTextBoxColumn";
            this.actorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // actorNameDataGridViewTextBoxColumn
            // 
            this.actorNameDataGridViewTextBoxColumn.DataPropertyName = "Actor_Name";
            this.actorNameDataGridViewTextBoxColumn.HeaderText = "Actor_Name";
            this.actorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actorNameDataGridViewTextBoxColumn.Name = "actorNameDataGridViewTextBoxColumn";
            this.actorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // actorAddressDataGridViewTextBoxColumn
            // 
            this.actorAddressDataGridViewTextBoxColumn.DataPropertyName = "Actor_Address";
            this.actorAddressDataGridViewTextBoxColumn.HeaderText = "Actor_Address";
            this.actorAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actorAddressDataGridViewTextBoxColumn.Name = "actorAddressDataGridViewTextBoxColumn";
            this.actorAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // contNoDataGridViewTextBoxColumn
            // 
            this.contNoDataGridViewTextBoxColumn.DataPropertyName = "Cont_No";
            this.contNoDataGridViewTextBoxColumn.HeaderText = "Cont_No";
            this.contNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contNoDataGridViewTextBoxColumn.Name = "contNoDataGridViewTextBoxColumn";
            this.contNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // actorBindingSource1
            // 
            this.actorBindingSource1.DataMember = "Actor";
            this.actorBindingSource1.DataSource = this.quietatticDataSet10;
            // 
            // quietatticDataSet10
            // 
            this.quietatticDataSet10.DataSetName = "QuietatticDataSet10";
            this.quietatticDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 127;
            this.label7.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 125;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 124;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 123;
            this.label3.Text = "Actor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 122;
            this.label2.Text = "Search";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(13, 701);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 51);
            this.btnexit.TabIndex = 141;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // txtcont
            // 
            this.txtcont.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcont.Location = new System.Drawing.Point(331, 386);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(478, 31);
            this.txtcont.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 142;
            this.label6.Text = "Contact";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(827, 135);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 144;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 764);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtactorid);
            this.Controls.Add(this.datagridactor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Actor";
            this.Text = "Actor";
            this.Load += new System.EventHandler(this.Actor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource actorBindingSource;
        private QuietatticDataSet6 quietatticDataSet6;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtactorid;
        private System.Windows.Forms.DataGridView datagridactor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private QuietatticDataSet10 quietatticDataSet10;
        private System.Windows.Forms.BindingSource actorBindingSource1;
        private QuietatticDataSet10TableAdapters.ActorTableAdapter actorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch;
    }
}