namespace Databasesys
{
    partial class Location
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
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet8 = new Databasesys.QuietatticDataSet8();
            this.locationTableAdapter = new Databasesys.QuietatticDataSet8TableAdapters.LocationTableAdapter();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocationid = new System.Windows.Forms.TextBox();
            this.datagridlocation = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.quietatticDataSet12 = new Databasesys.QuietatticDataSet12();
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter1 = new Databasesys.QuietatticDataSet12TableAdapters.LocationTableAdapter();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridlocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.quietatticDataSet8;
            // 
            // quietatticDataSet8
            // 
            this.quietatticDataSet8.DataSetName = "QuietatticDataSet8";
            this.quietatticDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(14, 701);
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
            this.btnback.Location = new System.Drawing.Point(14, 616);
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
            this.panel1.Location = new System.Drawing.Point(-8, -3);
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
            this.label8.Location = new System.Drawing.Point(8, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 35);
            this.label8.TabIndex = 100;
            this.label8.Text = "Location";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(663, 663);
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
            this.btnupdate.Location = new System.Drawing.Point(493, 663);
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
            this.btninsert.Location = new System.Drawing.Point(332, 663);
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
            this.txtsearch.Location = new System.Drawing.Point(332, 139);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 96;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(332, 271);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(478, 31);
            this.txtname.TabIndex = 92;
            // 
            // txtlocationid
            // 
            this.txtlocationid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocationid.Location = new System.Drawing.Point(332, 215);
            this.txtlocationid.Name = "txtlocationid";
            this.txtlocationid.Size = new System.Drawing.Size(478, 31);
            this.txtlocationid.TabIndex = 91;
            // 
            // datagridlocation
            // 
            this.datagridlocation.AutoGenerateColumns = false;
            this.datagridlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridlocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationIDDataGridViewTextBoxColumn,
            this.locNameDataGridViewTextBoxColumn});
            this.datagridlocation.DataSource = this.locationBindingSource1;
            this.datagridlocation.Location = new System.Drawing.Point(332, 419);
            this.datagridlocation.Name = "datagridlocation";
            this.datagridlocation.RowHeadersWidth = 51;
            this.datagridlocation.RowTemplate.Height = 24;
            this.datagridlocation.Size = new System.Drawing.Size(946, 226);
            this.datagridlocation.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 86;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 85;
            this.label3.Text = "Location ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "Search";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(834, 133);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 146;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // quietatticDataSet12
            // 
            this.quietatticDataSet12.DataSetName = "QuietatticDataSet12";
            this.quietatticDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataMember = "Location";
            this.locationBindingSource1.DataSource = this.quietatticDataSet12;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            this.locationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // locNameDataGridViewTextBoxColumn
            // 
            this.locNameDataGridViewTextBoxColumn.DataPropertyName = "Loc_Name";
            this.locNameDataGridViewTextBoxColumn.HeaderText = "Loc_Name";
            this.locNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locNameDataGridViewTextBoxColumn.Name = "locNameDataGridViewTextBoxColumn";
            this.locNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Location
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
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtlocationid);
            this.Controls.Add(this.datagridlocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Location";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridlocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuietatticDataSet8 quietatticDataSet8;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private QuietatticDataSet8TableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocationid;
        private System.Windows.Forms.DataGridView datagridlocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private QuietatticDataSet12 quietatticDataSet12;
        private System.Windows.Forms.BindingSource locationBindingSource1;
        private QuietatticDataSet12TableAdapters.LocationTableAdapter locationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locNameDataGridViewTextBoxColumn;
    }
}