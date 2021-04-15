namespace WindowsFormsApp1
{
    public partial class Form2
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
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DB_delete = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.storemenu_View = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manufacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.create_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.calorie_label = new System.Windows.Forms.Label();
            this.manufacture_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.db_insert = new System.Windows.Forms.Button();
            this.stock_checkBox = new System.Windows.Forms.CheckBox();
            this.item_listBox = new System.Windows.Forms.ListBox();
            this.calorie_textbox = new System.Windows.Forms.TextBox();
            this.manufacture_textbox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.product_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.delete_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.delete_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_view = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.db_Button = new System.Windows.Forms.Button();
            this.update_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.update_filename = new System.Windows.Forms.TextBox();
            this.update_butten = new System.Windows.Forms.Button();
            this.update_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.db_update = new System.Windows.Forms.Button();
            this.update_stock = new System.Windows.Forms.CheckBox();
            this.update_item = new System.Windows.Forms.ListBox();
            this.update_Calorie = new System.Windows.Forms.TextBox();
            this.update_manufacture = new System.Windows.Forms.TextBox();
            this.update_price = new System.Windows.Forms.TextBox();
            this.update_product = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.create_panel.SuspendLayout();
            this.delete_panel.SuspendLayout();
            this.update_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.DB_delete);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.create_button);
            this.panel1.Location = new System.Drawing.Point(868, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 186);
            this.panel1.TabIndex = 0;
            // 
            // DB_delete
            // 
            this.DB_delete.Location = new System.Drawing.Point(23, 117);
            this.DB_delete.Name = "DB_delete";
            this.DB_delete.Size = new System.Drawing.Size(133, 44);
            this.DB_delete.TabIndex = 2;
            this.DB_delete.Text = "제품 삭제";
            this.DB_delete.UseVisualStyleBackColor = true;
            this.DB_delete.Click += new System.EventHandler(this.DB_delete_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(24, 67);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(133, 44);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "제품 수정";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(23, 15);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(133, 44);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "제품 추가";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.storemenu_View);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(834, 404);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Info_panel_Paint);
            // 
            // storemenu_View
            // 
            this.storemenu_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.item,
            this.product,
            this.price,
            this.manufacture,
            this.calorie,
            this.stock,
            this.picture});
            this.storemenu_View.HideSelection = false;
            this.storemenu_View.Location = new System.Drawing.Point(4, 0);
            this.storemenu_View.Name = "storemenu_View";
            this.storemenu_View.Size = new System.Drawing.Size(827, 401);
            this.storemenu_View.TabIndex = 0;
            this.storemenu_View.UseCompatibleStateImageBehavior = false;
            this.storemenu_View.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "번호";
            this.columnHeader8.Width = 38;
            // 
            // item
            // 
            this.item.Text = "품목명";
            this.item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item.Width = 99;
            // 
            // product
            // 
            this.product.Text = "제품이름";
            this.product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product.Width = 144;
            // 
            // price
            // 
            this.price.Text = "판매가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 110;
            // 
            // manufacture
            // 
            this.manufacture.Text = "제조회사";
            this.manufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manufacture.Width = 134;
            // 
            // calorie
            // 
            this.calorie.Text = "칼로리";
            this.calorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calorie.Width = 91;
            // 
            // stock
            // 
            this.stock.Text = "재고여부";
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stock.Width = 62;
            // 
            // picture
            // 
            this.picture.Text = "사진이름";
            this.picture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.picture.Width = 146;
            // 
            // create_panel
            // 
            this.create_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.create_panel.Controls.Add(this.label1);
            this.create_panel.Controls.Add(this.filename_textbox);
            this.create_panel.Controls.Add(this.calorie_label);
            this.create_panel.Controls.Add(this.manufacture_label);
            this.create_panel.Controls.Add(this.price_label);
            this.create_panel.Controls.Add(this.product_label);
            this.create_panel.Controls.Add(this.db_insert);
            this.create_panel.Controls.Add(this.stock_checkBox);
            this.create_panel.Controls.Add(this.item_listBox);
            this.create_panel.Controls.Add(this.calorie_textbox);
            this.create_panel.Controls.Add(this.manufacture_textbox);
            this.create_panel.Controls.Add(this.price_textBox);
            this.create_panel.Controls.Add(this.product_textbox);
            this.create_panel.Location = new System.Drawing.Point(15, 809);
            this.create_panel.Name = "create_panel";
            this.create_panel.Size = new System.Drawing.Size(1009, 171);
            this.create_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "파일명 :";
            // 
            // filename_textbox
            // 
            this.filename_textbox.Location = new System.Drawing.Point(625, 51);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(100, 21);
            this.filename_textbox.TabIndex = 13;
            // 
            // calorie_label
            // 
            this.calorie_label.AutoSize = true;
            this.calorie_label.Location = new System.Drawing.Point(434, 102);
            this.calorie_label.Name = "calorie_label";
            this.calorie_label.Size = new System.Drawing.Size(49, 12);
            this.calorie_label.TabIndex = 12;
            this.calorie_label.Text = "칼로리 :";
            // 
            // manufacture_label
            // 
            this.manufacture_label.AutoSize = true;
            this.manufacture_label.Location = new System.Drawing.Point(434, 36);
            this.manufacture_label.Name = "manufacture_label";
            this.manufacture_label.Size = new System.Drawing.Size(73, 12);
            this.manufacture_label.TabIndex = 11;
            this.manufacture_label.Text = "제조회사명 :";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(228, 100);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(61, 12);
            this.price_label.TabIndex = 10;
            this.price_label.Text = "판매가격 :";
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(228, 36);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(49, 12);
            this.product_label.TabIndex = 9;
            this.product_label.Text = "제품명 :";
            // 
            // db_insert
            // 
            this.db_insert.Location = new System.Drawing.Point(831, 43);
            this.db_insert.Name = "db_insert";
            this.db_insert.Size = new System.Drawing.Size(124, 67);
            this.db_insert.TabIndex = 8;
            this.db_insert.Text = "내용 추가";
            this.db_insert.UseVisualStyleBackColor = true;
            this.db_insert.Click += new System.EventHandler(this.Button4_Click);
            // 
            // stock_checkBox
            // 
            this.stock_checkBox.AutoSize = true;
            this.stock_checkBox.Location = new System.Drawing.Point(645, 120);
            this.stock_checkBox.Name = "stock_checkBox";
            this.stock_checkBox.Size = new System.Drawing.Size(72, 16);
            this.stock_checkBox.TabIndex = 5;
            this.stock_checkBox.Text = "재고여부";
            this.stock_checkBox.UseVisualStyleBackColor = true;
            // 
            // item_listBox
            // 
            this.item_listBox.FormattingEnabled = true;
            this.item_listBox.ItemHeight = 12;
            this.item_listBox.Items.AddRange(new object[] {
            "스낵류",
            "아이스크림류",
            "빵류",
            "음료류",
            "캔디젤리류",
            "우유류"});
            this.item_listBox.Location = new System.Drawing.Point(52, 43);
            this.item_listBox.Name = "item_listBox";
            this.item_listBox.Size = new System.Drawing.Size(120, 76);
            this.item_listBox.TabIndex = 4;
            // 
            // calorie_textbox
            // 
            this.calorie_textbox.Location = new System.Drawing.Point(436, 115);
            this.calorie_textbox.Name = "calorie_textbox";
            this.calorie_textbox.Size = new System.Drawing.Size(100, 21);
            this.calorie_textbox.TabIndex = 3;
            // 
            // manufacture_textbox
            // 
            this.manufacture_textbox.Location = new System.Drawing.Point(436, 51);
            this.manufacture_textbox.Name = "manufacture_textbox";
            this.manufacture_textbox.Size = new System.Drawing.Size(100, 21);
            this.manufacture_textbox.TabIndex = 2;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(230, 115);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(100, 21);
            this.price_textBox.TabIndex = 1;
            // 
            // product_textbox
            // 
            this.product_textbox.Location = new System.Drawing.Point(230, 51);
            this.product_textbox.Name = "product_textbox";
            this.product_textbox.Size = new System.Drawing.Size(100, 21);
            this.product_textbox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // delete_panel
            // 
            this.delete_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete_panel.Controls.Add(this.delete_button);
            this.delete_panel.Controls.Add(this.delete_number);
            this.delete_panel.Controls.Add(this.label2);
            this.delete_panel.Controls.Add(this.delete_view);
            this.delete_panel.Controls.Add(this.db_Button);
            this.delete_panel.Location = new System.Drawing.Point(16, 455);
            this.delete_panel.Name = "delete_panel";
            this.delete_panel.Size = new System.Drawing.Size(1009, 171);
            this.delete_panel.TabIndex = 3;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("굴림", 9F);
            this.delete_button.Location = new System.Drawing.Point(160, 28);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(53, 33);
            this.delete_button.TabIndex = 18;
            this.delete_button.Text = "검색";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // delete_number
            // 
            this.delete_number.Location = new System.Drawing.Point(38, 35);
            this.delete_number.Name = "delete_number";
            this.delete_number.Size = new System.Drawing.Size(114, 21);
            this.delete_number.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "번호 입력 : ";
            // 
            // delete_view
            // 
            this.delete_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.delete_view.HideSelection = false;
            this.delete_view.Location = new System.Drawing.Point(38, 85);
            this.delete_view.Name = "delete_view";
            this.delete_view.Size = new System.Drawing.Size(835, 59);
            this.delete_view.TabIndex = 1;
            this.delete_view.UseCompatibleStateImageBehavior = false;
            this.delete_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "품목명";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제품이름";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "판매가격";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "제조회사";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "칼로리";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "재고여부";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 62;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "사진이름";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 175;
            // 
            // db_Button
            // 
            this.db_Button.Location = new System.Drawing.Point(888, 89);
            this.db_Button.Name = "db_Button";
            this.db_Button.Size = new System.Drawing.Size(89, 51);
            this.db_Button.TabIndex = 15;
            this.db_Button.Text = "삭제";
            this.db_Button.UseVisualStyleBackColor = true;
            this.db_Button.Click += new System.EventHandler(this.Db_Button_Click);
            // 
            // update_panel
            // 
            this.update_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.update_panel.Controls.Add(this.label7);
            this.update_panel.Controls.Add(this.update_filename);
            this.update_panel.Controls.Add(this.update_butten);
            this.update_panel.Controls.Add(this.update_number);
            this.update_panel.Controls.Add(this.label8);
            this.update_panel.Controls.Add(this.label3);
            this.update_panel.Controls.Add(this.label4);
            this.update_panel.Controls.Add(this.label5);
            this.update_panel.Controls.Add(this.label6);
            this.update_panel.Controls.Add(this.db_update);
            this.update_panel.Controls.Add(this.update_stock);
            this.update_panel.Controls.Add(this.update_item);
            this.update_panel.Controls.Add(this.update_Calorie);
            this.update_panel.Controls.Add(this.update_manufacture);
            this.update_panel.Controls.Add(this.update_price);
            this.update_panel.Controls.Add(this.update_product);
            this.update_panel.Location = new System.Drawing.Point(15, 632);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(1009, 171);
            this.update_panel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "파일명 :";
            // 
            // update_filename
            // 
            this.update_filename.Location = new System.Drawing.Point(679, 55);
            this.update_filename.Name = "update_filename";
            this.update_filename.Size = new System.Drawing.Size(100, 21);
            this.update_filename.TabIndex = 17;
            // 
            // update_butten
            // 
            this.update_butten.Location = new System.Drawing.Point(92, 98);
            this.update_butten.Name = "update_butten";
            this.update_butten.Size = new System.Drawing.Size(63, 37);
            this.update_butten.TabIndex = 16;
            this.update_butten.Text = "검색";
            this.update_butten.UseVisualStyleBackColor = true;
            this.update_butten.Click += new System.EventHandler(this.Update_seerch_Click);
            // 
            // update_number
            // 
            this.update_number.Location = new System.Drawing.Point(37, 67);
            this.update_number.Name = "update_number";
            this.update_number.Size = new System.Drawing.Size(118, 21);
            this.update_number.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "번호 입력 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "칼로리 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "제조회사명 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "판매가격 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "제품명 :";
            // 
            // db_update
            // 
            this.db_update.Location = new System.Drawing.Point(831, 43);
            this.db_update.Name = "db_update";
            this.db_update.Size = new System.Drawing.Size(124, 67);
            this.db_update.TabIndex = 8;
            this.db_update.Text = "내용 수정";
            this.db_update.UseVisualStyleBackColor = true;
            this.db_update.Click += new System.EventHandler(this.Db_update_Click);
            // 
            // update_stock
            // 
            this.update_stock.AutoSize = true;
            this.update_stock.Location = new System.Drawing.Point(694, 115);
            this.update_stock.Name = "update_stock";
            this.update_stock.Size = new System.Drawing.Size(72, 16);
            this.update_stock.TabIndex = 5;
            this.update_stock.Text = "재고여부";
            this.update_stock.UseVisualStyleBackColor = true;
            // 
            // update_item
            // 
            this.update_item.FormattingEnabled = true;
            this.update_item.ItemHeight = 12;
            this.update_item.Items.AddRange(new object[] {
            "스낵류",
            "아이스크림류",
            "빵류",
            "음료류",
            "캔디젤리류",
            "우유류"});
            this.update_item.Location = new System.Drawing.Point(182, 49);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(120, 76);
            this.update_item.TabIndex = 4;
            // 
            // update_Calorie
            // 
            this.update_Calorie.Location = new System.Drawing.Point(336, 54);
            this.update_Calorie.Name = "update_Calorie";
            this.update_Calorie.Size = new System.Drawing.Size(100, 21);
            this.update_Calorie.TabIndex = 3;
            // 
            // update_manufacture
            // 
            this.update_manufacture.Location = new System.Drawing.Point(510, 55);
            this.update_manufacture.Name = "update_manufacture";
            this.update_manufacture.Size = new System.Drawing.Size(100, 21);
            this.update_manufacture.TabIndex = 2;
            // 
            // update_price
            // 
            this.update_price.Location = new System.Drawing.Point(336, 113);
            this.update_price.Name = "update_price";
            this.update_price.Size = new System.Drawing.Size(100, 21);
            this.update_price.TabIndex = 1;
            // 
            // update_product
            // 
            this.update_product.Location = new System.Drawing.Point(510, 113);
            this.update_product.Name = "update_product";
            this.update_product.Size = new System.Drawing.Size(100, 21);
            this.update_product.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(868, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1056, 992);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.update_panel);
            this.Controls.Add(this.delete_panel);
            this.Controls.Add(this.create_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "주문관리시스템 V1.0.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.create_panel.ResumeLayout(false);
            this.create_panel.PerformLayout();
            this.delete_panel.ResumeLayout(false);
            this.delete_panel.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DB_delete;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView storemenu_View;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader manufacture;
        private System.Windows.Forms.ColumnHeader calorie;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.ColumnHeader picture;
        private System.Windows.Forms.Panel create_panel;
        private System.Windows.Forms.CheckBox stock_checkBox;
        private System.Windows.Forms.ListBox item_listBox;
        private System.Windows.Forms.TextBox calorie_textbox;
        private System.Windows.Forms.TextBox manufacture_textbox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox product_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button db_insert;
        private System.Windows.Forms.Label calorie_label;
        private System.Windows.Forms.Label manufacture_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Panel delete_panel;
        private System.Windows.Forms.Button db_Button;
        private System.Windows.Forms.ListView delete_view;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel update_panel;
        private System.Windows.Forms.Button update_butten;
        private System.Windows.Forms.TextBox update_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button db_update;
        private System.Windows.Forms.CheckBox update_stock;
        private System.Windows.Forms.ListBox update_item;
        private System.Windows.Forms.TextBox update_Calorie;
        private System.Windows.Forms.TextBox update_manufacture;
        private System.Windows.Forms.TextBox update_price;
        private System.Windows.Forms.TextBox update_product;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delete_number;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox update_filename;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}