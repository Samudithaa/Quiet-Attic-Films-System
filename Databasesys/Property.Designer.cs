namespace Databasesys
{
    partial class Property
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
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet5 = new Databasesys.QuietatticDataSet5();
            this.propertyTableAdapter = new Databasesys.QuietatticDataSet5TableAdapters.PropertyTableAdapter();
            this.actorTableAdapter = new Databasesys.QuietatticDataSet6TableAdapters.ActorTableAdapter();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtproptype = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpropid = new System.Windows.Forms.TextBox();
            this.datagridproperty = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.propertyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproperty)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            this.propertyBindingSource.DataSource = this.quietatticDataSet5;
            // 
            // quietatticDataSet5
            // 
            this.quietatticDataSet5.DataSetName = "QuietatticDataSet5";
            this.quietatticDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(14, 619);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(126, 51);
            this.btnback.TabIndex = 121;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 85);
            this.panel1.TabIndex = 120;
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
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 35);
            this.label8.TabIndex = 119;
            this.label8.Text = "Property";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(663, 666);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 58);
            this.btndelete.TabIndex = 118;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(493, 666);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 58);
            this.btnupdate.TabIndex = 117;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(332, 666);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(147, 58);
            this.btninsert.TabIndex = 116;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(332, 142);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 115;
            // 
            // txtproptype
            // 
            this.txtproptype.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproptype.Location = new System.Drawing.Point(332, 301);
            this.txtproptype.Name = "txtproptype";
            this.txtproptype.Size = new System.Drawing.Size(478, 31);
            this.txtproptype.TabIndex = 112;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(332, 260);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(478, 31);
            this.txtname.TabIndex = 111;
            // 
            // txtpropid
            // 
            this.txtpropid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropid.Location = new System.Drawing.Point(332, 218);
            this.txtpropid.Name = "txtpropid";
            this.txtpropid.Size = new System.Drawing.Size(478, 31);
            this.txtpropid.TabIndex = 110;
            // 
            // datagridproperty
            // 
            this.datagridproperty.AutoGenerateColumns = false;
            this.datagridproperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyIDDataGridViewTextBoxColumn,
            this.propNameDataGridViewTextBoxColumn,
            this.propTypeDataGridViewTextBoxColumn});
            this.datagridproperty.DataSource = this.propertyBindingSource;
            this.datagridproperty.Location = new System.Drawing.Point(332, 422);
            this.datagridproperty.Name = "datagridproperty";
            this.datagridproperty.RowHeadersWidth = 51;
            this.datagridproperty.RowTemplate.Height = 24;
            this.datagridproperty.Size = new System.Drawing.Size(946, 226);
            this.datagridproperty.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "Property type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 105;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 104;
            this.label3.Text = "Property ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 103;
            this.label2.Text = "Search";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(14, 701);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 51);
            this.btnexit.TabIndex = 122;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(829, 136);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 149;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // propertyIDDataGridViewTextBoxColumn
            // 
            this.propertyIDDataGridViewTextBoxColumn.DataPropertyName = "Property_ID";
            this.propertyIDDataGridViewTextBoxColumn.HeaderText = "Property_ID";
            this.propertyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propertyIDDataGridViewTextBoxColumn.Name = "propertyIDDataGridViewTextBoxColumn";
            this.propertyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // propNameDataGridViewTextBoxColumn
            // 
            this.propNameDataGridViewTextBoxColumn.DataPropertyName = "Prop_Name";
            this.propNameDataGridViewTextBoxColumn.HeaderText = "Prop_Name";
            this.propNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propNameDataGridViewTextBoxColumn.Name = "propNameDataGridViewTextBoxColumn";
            this.propNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // propTypeDataGridViewTextBoxColumn
            // 
            this.propTypeDataGridViewTextBoxColumn.DataPropertyName = "Prop_Type";
            this.propTypeDataGridViewTextBoxColumn.HeaderText = "Prop_Type";
            this.propTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propTypeDataGridViewTextBoxColumn.Name = "propTypeDataGridViewTextBoxColumn";
            this.propTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Property
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
            this.Controls.Add(this.txtproptype);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpropid);
            this.Controls.Add(this.datagridproperty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Property";
            this.Text = "Property";
            this.Load += new System.EventHandler(this.Property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuietatticDataSet5 quietatticDataSet5;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private QuietatticDataSet5TableAdapters.PropertyTableAdapter propertyTableAdapter;
        private QuietatticDataSet6TableAdapters.ActorTableAdapter actorTableAdapter;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtproptype;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpropid;
        private System.Windows.Forms.DataGridView datagridproperty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propTypeDataGridViewTextBoxColumn;
    }
}