namespace Shop.Forms
{
    partial class Orders
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shopDataSet = new Shop.shopDataSet();
            this.viewORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewORDERTableAdapter = new Shop.shopDataSetTableAdapters.ViewORDERTableAdapter();
            this.tableAdapterManager = new Shop.shopDataSetTableAdapters.TableAdapterManager();
            this.viewORDERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewORDERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.cOUNTTextBox = new System.Windows.Forms.TextBox();
            this.oRDERTIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sURNAMETextBox = new System.Windows.Forms.TextBox();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            this.pATRONYMICTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingNavigator)).BeginInit();
            this.viewORDERBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label6.Location = new System.Drawing.Point(59, 229);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 20);
            label6.TabIndex = 35;
            label6.Text = "Дата заказа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label5.Location = new System.Drawing.Point(64, 189);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 20);
            label5.TabIndex = 34;
            label5.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label4.Location = new System.Drawing.Point(121, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 20);
            label4.TabIndex = 33;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label3.Location = new System.Drawing.Point(82, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 20);
            label3.TabIndex = 32;
            label3.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label2.Location = new System.Drawing.Point(39, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 20);
            label2.TabIndex = 31;
            label2.Text = "Наименование";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label7.Location = new System.Drawing.Point(124, 272);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 20);
            label7.TabIndex = 51;
            label7.Text = "ФИО";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label8.Location = new System.Drawing.Point(88, 315);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(85, 20);
            label8.TabIndex = 52;
            label8.Text = "Телефон";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(192, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 28);
            this.button6.TabIndex = 42;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(426, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 40;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 39;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 38;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(258, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "Заказы";
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewORDERBindingSource
            // 
            this.viewORDERBindingSource.DataMember = "ViewORDER";
            this.viewORDERBindingSource.DataSource = this.shopDataSet;
            // 
            // viewORDERTableAdapter
            // 
            this.viewORDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PRODUCTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shop.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // viewORDERBindingNavigator
            // 
            this.viewORDERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.viewORDERBindingNavigator.BindingSource = this.viewORDERBindingSource;
            this.viewORDERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewORDERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.viewORDERBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewORDERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.viewORDERBindingNavigatorSaveItem});
            this.viewORDERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewORDERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewORDERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewORDERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewORDERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewORDERBindingNavigator.Name = "viewORDERBindingNavigator";
            this.viewORDERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewORDERBindingNavigator.Size = new System.Drawing.Size(700, 31);
            this.viewORDERBindingNavigator.TabIndex = 54;
            this.viewORDERBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // viewORDERBindingNavigatorSaveItem
            // 
            this.viewORDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewORDERBindingNavigatorSaveItem.Enabled = false;
            this.viewORDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("viewORDERBindingNavigatorSaveItem.Image")));
            this.viewORDERBindingNavigatorSaveItem.Name = "viewORDERBindingNavigatorSaveItem";
            this.viewORDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.viewORDERBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(189, 72);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(335, 22);
            this.nAMETextBox.TabIndex = 55;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(189, 107);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(335, 22);
            this.dESCRIPTIONTextBox.TabIndex = 56;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(189, 149);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(335, 22);
            this.pRICETextBox.TabIndex = 57;
            // 
            // cOUNTTextBox
            // 
            this.cOUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "COUNT", true));
            this.cOUNTTextBox.Location = new System.Drawing.Point(189, 189);
            this.cOUNTTextBox.Name = "cOUNTTextBox";
            this.cOUNTTextBox.Size = new System.Drawing.Size(335, 22);
            this.cOUNTTextBox.TabIndex = 58;
            // 
            // oRDERTIMEDateTimePicker
            // 
            this.oRDERTIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewORDERBindingSource, "ORDERTIME", true));
            this.oRDERTIMEDateTimePicker.Location = new System.Drawing.Point(189, 229);
            this.oRDERTIMEDateTimePicker.Name = "oRDERTIMEDateTimePicker";
            this.oRDERTIMEDateTimePicker.Size = new System.Drawing.Size(335, 22);
            this.oRDERTIMEDateTimePicker.TabIndex = 59;
            // 
            // sURNAMETextBox
            // 
            this.sURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "SURNAME", true));
            this.sURNAMETextBox.Location = new System.Drawing.Point(189, 276);
            this.sURNAMETextBox.Name = "sURNAMETextBox";
            this.sURNAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.sURNAMETextBox.TabIndex = 60;
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(295, 276);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.Size = new System.Drawing.Size(112, 22);
            this.expr1TextBox.TabIndex = 61;
            // 
            // pATRONYMICTextBox
            // 
            this.pATRONYMICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PATRONYMIC", true));
            this.pATRONYMICTextBox.Location = new System.Drawing.Point(413, 276);
            this.pATRONYMICTextBox.Name = "pATRONYMICTextBox";
            this.pATRONYMICTextBox.Size = new System.Drawing.Size(111, 22);
            this.pATRONYMICTextBox.TabIndex = 62;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(189, 315);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(335, 22);
            this.pHONETextBox.TabIndex = 63;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 617);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(this.pATRONYMICTextBox);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(this.sURNAMETextBox);
            this.Controls.Add(this.oRDERTIMEDateTimePicker);
            this.Controls.Add(this.cOUNTTextBox);
            this.Controls.Add(this.pRICETextBox);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.viewORDERBindingNavigator);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Name = "Orders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingNavigator)).EndInit();
            this.viewORDERBindingNavigator.ResumeLayout(false);
            this.viewORDERBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource viewORDERBindingSource;
        private shopDataSetTableAdapters.ViewORDERTableAdapter viewORDERTableAdapter;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viewORDERBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton viewORDERBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox cOUNTTextBox;
        private System.Windows.Forms.DateTimePicker oRDERTIMEDateTimePicker;
        private System.Windows.Forms.TextBox sURNAMETextBox;
        private System.Windows.Forms.TextBox expr1TextBox;
        private System.Windows.Forms.TextBox pATRONYMICTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
    }
}