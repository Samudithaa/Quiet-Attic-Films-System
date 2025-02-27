namespace Databasesys
{
    partial class Customer
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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet2 = new Databasesys.QuietatticDataSet2();
            this.customerTableAdapter = new Databasesys.QuietatticDataSet2TableAdapters.CustomerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.datagridcus = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quietatticDataSet14 = new Databasesys.QuietatticDataSet14();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Databasesys.QuietatticDataSet14TableAdapters.CustomerTableAdapter();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.quietatticDataSet2;
            // 
            // quietatticDataSet2
            // 
            this.quietatticDataSet2.DataSetName = "QuietatticDataSet2";
            this.quietatticDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 85);
            this.panel1.TabIndex = 85;
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
            this.label8.Location = new System.Drawing.Point(10, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 35);
            this.label8.TabIndex = 84;
            this.label8.Text = "Customer";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(665, 660);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 58);
            this.btndelete.TabIndex = 83;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(495, 660);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 58);
            this.btnupdate.TabIndex = 82;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(15, 660);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 51);
            this.btnexit.TabIndex = 81;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(15, 560);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(126, 51);
            this.btnback.TabIndex = 80;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(334, 660);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(147, 58);
            this.btninsert.TabIndex = 79;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(334, 136);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 78;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(334, 371);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(478, 31);
            this.txtcontact.TabIndex = 77;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(334, 335);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(478, 31);
            this.txtemail.TabIndex = 76;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(334, 295);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(478, 31);
            this.txtaddr.TabIndex = 75;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(334, 254);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(478, 31);
            this.txtname.TabIndex = 74;
            // 
            // txtcusid
            // 
            this.txtcusid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(334, 212);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(478, 31);
            this.txtcusid.TabIndex = 73;
            // 
            // datagridcus
            // 
            this.datagridcus.AutoGenerateColumns = false;
            this.datagridcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusAddressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contNoDataGridViewTextBoxColumn});
            this.datagridcus.DataSource = this.customerBindingSource1;
            this.datagridcus.Location = new System.Drawing.Point(334, 416);
            this.datagridcus.Name = "datagridcus";
            this.datagridcus.RowHeadersWidth = 51;
            this.datagridcus.RowTemplate.Height = 24;
            this.datagridcus.Size = new System.Drawing.Size(946, 226);
            this.datagridcus.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 71;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 70;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 69;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 68;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 66;
            this.label2.Text = "Search";
            // 
            // quietatticDataSet14
            // 
            this.quietatticDataSet14.DataSetName = "QuietatticDataSet14";
            this.quietatticDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.quietatticDataSet14;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "Cus_ID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "Cus_ID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "Cus_Name";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "Cus_Name";
            this.cusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            this.cusNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusAddressDataGridViewTextBoxColumn
            // 
            this.cusAddressDataGridViewTextBoxColumn.DataPropertyName = "Cus_Address";
            this.cusAddressDataGridViewTextBoxColumn.HeaderText = "Cus_Address";
            this.cusAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusAddressDataGridViewTextBoxColumn.Name = "cusAddressDataGridViewTextBoxColumn";
            this.cusAddressDataGridViewTextBoxColumn.Width = 125;
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
            this.btnsearch.Location = new System.Drawing.Point(835, 130);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 149;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 764);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.datagridcus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuietatticDataSet2 quietatticDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QuietatticDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.DataGridView datagridcus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QuietatticDataSet14 quietatticDataSet14;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private QuietatticDataSet14TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsearch;
    }
}