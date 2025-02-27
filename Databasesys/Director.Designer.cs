namespace Databasesys
{
    partial class Director
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
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet7 = new Databasesys.QuietatticDataSet7();
            this.directorTableAdapter = new Databasesys.QuietatticDataSet7TableAdapters.DirectorTableAdapter();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdirectid = new System.Windows.Forms.TextBox();
            this.datagriddirect = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quietatticDataSet11 = new Databasesys.QuietatticDataSet11();
            this.directorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter1 = new Databasesys.QuietatticDataSet11TableAdapters.DirectorTableAdapter();
            this.directorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddirect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "Director";
            this.directorBindingSource.DataSource = this.quietatticDataSet7;
            // 
            // quietatticDataSet7
            // 
            this.quietatticDataSet7.DataSetName = "QuietatticDataSet7";
            this.quietatticDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(15, 701);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 51);
            this.btnexit.TabIndex = 103;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(15, 616);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(126, 51);
            this.btnback.TabIndex = 102;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 85);
            this.panel1.TabIndex = 101;
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
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 35);
            this.label8.TabIndex = 100;
            this.label8.Text = "Director";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(664, 663);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 58);
            this.btndelete.TabIndex = 99;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(494, 663);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 58);
            this.btnupdate.TabIndex = 98;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(333, 663);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(147, 58);
            this.btninsert.TabIndex = 97;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(333, 139);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 96;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(333, 374);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(478, 31);
            this.txtcontact.TabIndex = 95;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(333, 338);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(478, 31);
            this.txtemail.TabIndex = 94;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(333, 298);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(478, 31);
            this.txtaddr.TabIndex = 93;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(333, 257);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(478, 31);
            this.txtname.TabIndex = 92;
            // 
            // txtdirectid
            // 
            this.txtdirectid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdirectid.Location = new System.Drawing.Point(333, 215);
            this.txtdirectid.Name = "txtdirectid";
            this.txtdirectid.Size = new System.Drawing.Size(478, 31);
            this.txtdirectid.TabIndex = 91;
            // 
            // datagriddirect
            // 
            this.datagriddirect.AutoGenerateColumns = false;
            this.datagriddirect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddirect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directorIDDataGridViewTextBoxColumn,
            this.directorNameDataGridViewTextBoxColumn,
            this.directorAddressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contNoDataGridViewTextBoxColumn});
            this.datagriddirect.DataSource = this.directorBindingSource1;
            this.datagriddirect.Location = new System.Drawing.Point(333, 419);
            this.datagriddirect.Name = "datagriddirect";
            this.datagriddirect.RowHeadersWidth = 51;
            this.datagriddirect.RowTemplate.Height = 24;
            this.datagriddirect.Size = new System.Drawing.Size(946, 226);
            this.datagriddirect.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 89;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 88;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 87;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 86;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 85;
            this.label3.Text = "Director ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "Search";
            // 
            // quietatticDataSet11
            // 
            this.quietatticDataSet11.DataSetName = "QuietatticDataSet11";
            this.quietatticDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorBindingSource1
            // 
            this.directorBindingSource1.DataMember = "Director";
            this.directorBindingSource1.DataSource = this.quietatticDataSet11;
            // 
            // directorTableAdapter1
            // 
            this.directorTableAdapter1.ClearBeforeFill = true;
            // 
            // directorIDDataGridViewTextBoxColumn
            // 
            this.directorIDDataGridViewTextBoxColumn.DataPropertyName = "Director_ID";
            this.directorIDDataGridViewTextBoxColumn.HeaderText = "Director_ID";
            this.directorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorIDDataGridViewTextBoxColumn.Name = "directorIDDataGridViewTextBoxColumn";
            this.directorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorNameDataGridViewTextBoxColumn
            // 
            this.directorNameDataGridViewTextBoxColumn.DataPropertyName = "Director_Name";
            this.directorNameDataGridViewTextBoxColumn.HeaderText = "Director_Name";
            this.directorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorNameDataGridViewTextBoxColumn.Name = "directorNameDataGridViewTextBoxColumn";
            this.directorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorAddressDataGridViewTextBoxColumn
            // 
            this.directorAddressDataGridViewTextBoxColumn.DataPropertyName = "Director_Address";
            this.directorAddressDataGridViewTextBoxColumn.HeaderText = "Director_Address";
            this.directorAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorAddressDataGridViewTextBoxColumn.Name = "directorAddressDataGridViewTextBoxColumn";
            this.directorAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contNoDataGridViewTextBoxColumn
            // 
            this.contNoDataGridViewTextBoxColumn.DataPropertyName = "Cont_No";
            this.contNoDataGridViewTextBoxColumn.HeaderText = "Cont_No";
            this.contNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contNoDataGridViewTextBoxColumn.Name = "contNoDataGridViewTextBoxColumn";
            this.contNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(841, 133);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 145;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 764);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtdirectid);
            this.Controls.Add(this.datagriddirect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Director";
            this.Text = "Director";
            this.Load += new System.EventHandler(this.Director_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddirect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuietatticDataSet7 quietatticDataSet7;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private QuietatticDataSet7TableAdapters.DirectorTableAdapter directorTableAdapter;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdirectid;
        private System.Windows.Forms.DataGridView datagriddirect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QuietatticDataSet11 quietatticDataSet11;
        private System.Windows.Forms.BindingSource directorBindingSource1;
        private QuietatticDataSet11TableAdapters.DirectorTableAdapter directorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsearch;
    }
}