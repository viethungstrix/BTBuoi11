namespace BT1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnadd = new Button();
            btndel = new Button();
            btnfix = new Button();
            btnshow = new Button();
            sinhvien = new TextBox();
            hoten = new TextBox();
            masv = new Label();
            tensv = new Label();
            ShowListSV = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(351, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sinh viên";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(31, 362);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(128, 40);
            btnadd.TabIndex = 1;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(245, 362);
            btndel.Name = "btndel";
            btndel.Size = new Size(128, 40);
            btndel.TabIndex = 2;
            btndel.Text = "Xóa";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnfix
            // 
            btnfix.Location = new Point(468, 362);
            btnfix.Name = "btnfix";
            btnfix.Size = new Size(128, 40);
            btnfix.TabIndex = 3;
            btnfix.Text = "Sửa";
            btnfix.UseVisualStyleBackColor = true;
            btnfix.Click += btnfix_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(692, 362);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(128, 40);
            btnshow.TabIndex = 4;
            btnshow.Text = "Hiển thị";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // sinhvien
            // 
            sinhvien.Location = new Point(173, 104);
            sinhvien.Name = "sinhvien";
            sinhvien.Size = new Size(200, 27);
            sinhvien.TabIndex = 5;
            // 
            // hoten
            // 
            hoten.Location = new Point(173, 171);
            hoten.Name = "hoten";
            hoten.Size = new Size(200, 27);
            hoten.TabIndex = 6;
            // 
            // masv
            // 
            masv.AutoSize = true;
            masv.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            masv.Location = new Point(31, 104);
            masv.Name = "masv";
            masv.Size = new Size(106, 23);
            masv.TabIndex = 7;
            masv.Text = "Mã sinh viên";
            // 
            // tensv
            // 
            tensv.AutoSize = true;
            tensv.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tensv.Location = new Point(31, 171);
            tensv.Name = "tensv";
            tensv.Size = new Size(62, 23);
            tensv.TabIndex = 8;
            tensv.Text = "Họ tên";
            // 
            // ShowListSV
            // 
            ShowListSV.FormattingEnabled = true;
            ShowListSV.ItemHeight = 20;
            ShowListSV.Location = new Point(447, 104);
            ShowListSV.Name = "ShowListSV";
            ShowListSV.Size = new Size(373, 224);
            ShowListSV.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 443);
            Controls.Add(ShowListSV);
            Controls.Add(tensv);
            Controls.Add(masv);
            Controls.Add(hoten);
            Controls.Add(sinhvien);
            Controls.Add(btnshow);
            Controls.Add(btnfix);
            Controls.Add(btndel);
            Controls.Add(btnadd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Function";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnadd;
        private Button btndel;
        private Button btnfix;
        private Button btnshow;
        private TextBox sinhvien;
        private TextBox hoten;
        private Label masv;
        private Label tensv;
        private ListBox ShowListSV;
    }
}