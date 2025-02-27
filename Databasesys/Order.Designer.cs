namespace Databasesys
{
    partial class Order
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
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietatticDataSet3 = new Databasesys.QuietatticDataSet3();
            this.orderTableAdapter = new Databasesys.QuietatticDataSet3TableAdapters.OrderTableAdapter();
            this.paymentTableAdapter = new Databasesys.QuietatticDataSet9TableAdapters.PaymentTableAdapter();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtorderty = new System.Windows.Forms.TextBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.datagridorder = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtordertype = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.quietatticDataSet16 = new Databasesys.QuietatticDataSet16();
            this.neworderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.new_orderTableAdapter = new Databasesys.QuietatticDataSet16TableAdapters.new_orderTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neworderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.quietatticDataSet3;
            // 
            // quietatticDataSet3
            // 
            this.quietatticDataSet3.DataSetName = "QuietatticDataSet3";
            this.quietatticDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(16, 701);
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
            this.btnback.Location = new System.Drawing.Point(16, 616);
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
            this.panel1.Location = new System.Drawing.Point(-6, -3);
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
            this.label8.Location = new System.Drawing.Point(10, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 35);
            this.label8.TabIndex = 100;
            this.label8.Text = "Order";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(665, 663);
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
            this.btnupdate.Location = new System.Drawing.Point(495, 663);
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
            this.btninsert.Location = new System.Drawing.Point(334, 663);
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
            this.txtsearch.Location = new System.Drawing.Point(334, 139);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(478, 31);
            this.txtsearch.TabIndex = 96;
            // 
            // txtorderty
            // 
            this.txtorderty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderty.Location = new System.Drawing.Point(334, 257);
            this.txtorderty.Name = "txtorderty";
            this.txtorderty.Size = new System.Drawing.Size(478, 31);
            this.txtorderty.TabIndex = 92;
            this.txtorderty.TextChanged += new System.EventHandler(this.txtorderty_TextChanged);
            // 
            // txtorderid
            // 
            this.txtorderid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderid.Location = new System.Drawing.Point(334, 215);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(478, 31);
            this.txtorderid.TabIndex = 91;
            // 
            // datagridorder
            // 
            this.datagridorder.AutoGenerateColumns = false;
            this.datagridorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.ordertypeDataGridViewTextBoxColumn});
            this.datagridorder.DataSource = this.neworderBindingSource;
            this.datagridorder.Location = new System.Drawing.Point(334, 419);
            this.datagridorder.Name = "datagridorder";
            this.datagridorder.RowHeadersWidth = 51;
            this.datagridorder.RowTemplate.Height = 24;
            this.datagridorder.Size = new System.Drawing.Size(946, 226);
            this.datagridorder.TabIndex = 90;
            this.datagridorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridorder_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 87;
            this.label5.Text = "Order type";
            // 
            // txtordertype
            // 
            this.txtordertype.AutoSize = true;
            this.txtordertype.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordertype.Location = new System.Drawing.Point(200, 257);
            this.txtordertype.Name = "txtordertype";
            this.txtordertype.Size = new System.Drawing.Size(0, 26);
            this.txtordertype.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 85;
            this.label10.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "Search";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(846, 133);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 44);
            this.btnsearch.TabIndex = 147;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // quietatticDataSet16
            // 
            this.quietatticDataSet16.DataSetName = "QuietatticDataSet16";
            this.quietatticDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // neworderBindingSource
            // 
            this.neworderBindingSource.DataMember = "new_order";
            this.neworderBindingSource.DataSource = this.quietatticDataSet16;
            // 
            // new_orderTableAdapter
            // 
            this.new_orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordertypeDataGridViewTextBoxColumn
            // 
            this.ordertypeDataGridViewTextBoxColumn.DataPropertyName = "Order_type";
            this.ordertypeDataGridViewTextBoxColumn.HeaderText = "Order_type";
            this.ordertypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordertypeDataGridViewTextBoxColumn.Name = "ordertypeDataGridViewTextBoxColumn";
            this.ordertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Order
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
            this.Controls.Add(this.txtorderty);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.datagridorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtordertype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietatticDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neworderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuietatticDataSet3 quietatticDataSet3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private QuietatticDataSet3TableAdapters.OrderTableAdapter orderTableAdapter;
        private QuietatticDataSet9TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtorderty;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.DataGridView datagridorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtordertype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private QuietatticDataSet16 quietatticDataSet16;
        private System.Windows.Forms.BindingSource neworderBindingSource;
        private QuietatticDataSet16TableAdapters.new_orderTableAdapter new_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertypeDataGridViewTextBoxColumn;
    }
}