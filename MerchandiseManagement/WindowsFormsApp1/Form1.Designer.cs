namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.admin_pw = new System.Windows.Forms.TextBox();
            this.login_butten = new System.Windows.Forms.Button();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.order_view = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_butten = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pw_label);
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Controls.Add(this.admin_pw);
            this.panel1.Controls.Add(this.login_butten);
            this.panel1.Controls.Add(this.admin_id);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 219);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "주문 관리 시스템";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(61, 146);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(61, 12);
            this.pw_label.TabIndex = 4;
            this.pw_label.Text = "비밀번호 :";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(61, 92);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(49, 12);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "아이디 :";
            // 
            // admin_pw
            // 
            this.admin_pw.Location = new System.Drawing.Point(63, 161);
            this.admin_pw.Name = "admin_pw";
            this.admin_pw.Size = new System.Drawing.Size(130, 21);
            this.admin_pw.TabIndex = 2;
            this.admin_pw.UseSystemPasswordChar = true;
            // 
            // login_butten
            // 
            this.login_butten.Location = new System.Drawing.Point(238, 118);
            this.login_butten.Name = "login_butten";
            this.login_butten.Size = new System.Drawing.Size(105, 57);
            this.login_butten.TabIndex = 1;
            this.login_butten.Text = "로그인";
            this.login_butten.UseVisualStyleBackColor = true;
            this.login_butten.Click += new System.EventHandler(this.DB_connect);
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(63, 107);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(130, 21);
            this.admin_id.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete_number);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.order_view);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.insert_butten);
            this.panel2.Location = new System.Drawing.Point(12, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 398);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // delete_number
            // 
            this.delete_number.Location = new System.Drawing.Point(941, 150);
            this.delete_number.Name = "delete_number";
            this.delete_number.Size = new System.Drawing.Size(114, 21);
            this.delete_number.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(939, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "번호 입력 : ";
            // 
            // order_view
            // 
            this.order_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.order_view.HideSelection = false;
            this.order_view.Location = new System.Drawing.Point(3, 15);
            this.order_view.Name = "order_view";
            this.order_view.Size = new System.Drawing.Size(932, 369);
            this.order_view.TabIndex = 2;
            this.order_view.UseCompatibleStateImageBehavior = false;
            this.order_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "번호";
            this.columnHeader0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader0.Width = 37;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "전화번호";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "주문 정보";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 259;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "추가 사항";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 208;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "총 결제 금액";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "방문시간";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 145;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("굴림", 9F);
            this.delete_button.Location = new System.Drawing.Point(994, 177);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(61, 28);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // insert_butten
            // 
            this.insert_butten.Font = new System.Drawing.Font("굴림", 13F);
            this.insert_butten.Location = new System.Drawing.Point(941, 15);
            this.insert_butten.Name = "insert_butten";
            this.insert_butten.Size = new System.Drawing.Size(120, 54);
            this.insert_butten.TabIndex = 0;
            this.insert_butten.Text = "DB설정";
            this.insert_butten.UseVisualStyleBackColor = true;
            this.insert_butten.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1140, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "주문관리시스템 V1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.TextBox admin_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login_butten;
        private System.Windows.Forms.Button insert_butten;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListView order_view;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.TextBox delete_number;
        private System.Windows.Forms.Label label2;
    }
}

