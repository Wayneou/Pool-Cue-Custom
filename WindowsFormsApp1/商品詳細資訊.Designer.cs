namespace WindowsFormsApp1
{
    partial class 商品詳細資訊
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
            this.gBox刪除 = new System.Windows.Forms.GroupBox();
            this.btn刪除商品 = new System.Windows.Forms.Button();
            this.gBox修改 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取圖片2 = new System.Windows.Forms.Button();
            this.gBox新增 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn儲存新增 = new System.Windows.Forms.Button();
            this.btn選取圖片1 = new System.Windows.Forms.Button();
            this.pictureBox商品圖片 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBox刪除.SuspendLayout();
            this.gBox修改.SuspendLayout();
            this.gBox新增.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // gBox刪除
            // 
            this.gBox刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gBox刪除.Controls.Add(this.btn刪除商品);
            this.gBox刪除.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox刪除.Location = new System.Drawing.Point(170, 541);
            this.gBox刪除.Margin = new System.Windows.Forms.Padding(2);
            this.gBox刪除.Name = "gBox刪除";
            this.gBox刪除.Padding = new System.Windows.Forms.Padding(2);
            this.gBox刪除.Size = new System.Drawing.Size(150, 76);
            this.gBox刪除.TabIndex = 27;
            this.gBox刪除.TabStop = false;
            this.gBox刪除.Text = "刪除";
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.Location = new System.Drawing.Point(4, 24);
            this.btn刪除商品.Margin = new System.Windows.Forms.Padding(2);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(140, 40);
            this.btn刪除商品.TabIndex = 4;
            this.btn刪除商品.Text = "刪除商品";
            this.btn刪除商品.UseVisualStyleBackColor = true;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // gBox修改
            // 
            this.gBox修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gBox修改.Controls.Add(this.btn儲存修改);
            this.gBox修改.Controls.Add(this.btn選取圖片2);
            this.gBox修改.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox修改.Location = new System.Drawing.Point(170, 418);
            this.gBox修改.Margin = new System.Windows.Forms.Padding(2);
            this.gBox修改.Name = "gBox修改";
            this.gBox修改.Padding = new System.Windows.Forms.Padding(2);
            this.gBox修改.Size = new System.Drawing.Size(150, 123);
            this.gBox修改.TabIndex = 26;
            this.gBox修改.TabStop = false;
            this.gBox修改.Text = "修改";
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Location = new System.Drawing.Point(4, 68);
            this.btn儲存修改.Margin = new System.Windows.Forms.Padding(2);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(140, 40);
            this.btn儲存修改.TabIndex = 4;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取圖片2
            // 
            this.btn選取圖片2.Location = new System.Drawing.Point(4, 24);
            this.btn選取圖片2.Margin = new System.Windows.Forms.Padding(2);
            this.btn選取圖片2.Name = "btn選取圖片2";
            this.btn選取圖片2.Size = new System.Drawing.Size(140, 40);
            this.btn選取圖片2.TabIndex = 3;
            this.btn選取圖片2.Text = "選取圖片";
            this.btn選取圖片2.UseVisualStyleBackColor = true;
            this.btn選取圖片2.Click += new System.EventHandler(this.btn選取圖片2_Click);
            // 
            // gBox新增
            // 
            this.gBox新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gBox新增.Controls.Add(this.btn清空欄位);
            this.gBox新增.Controls.Add(this.btn儲存新增);
            this.gBox新增.Controls.Add(this.btn選取圖片1);
            this.gBox新增.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox新增.Location = new System.Drawing.Point(16, 418);
            this.gBox新增.Margin = new System.Windows.Forms.Padding(2);
            this.gBox新增.Name = "gBox新增";
            this.gBox新增.Padding = new System.Windows.Forms.Padding(2);
            this.gBox新增.Size = new System.Drawing.Size(150, 199);
            this.gBox新增.TabIndex = 25;
            this.gBox新增.TabStop = false;
            this.gBox新增.Text = "新增";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(4, 144);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(2);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(140, 43);
            this.btn清空欄位.TabIndex = 2;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn儲存新增
            // 
            this.btn儲存新增.Location = new System.Drawing.Point(6, 83);
            this.btn儲存新增.Margin = new System.Windows.Forms.Padding(2);
            this.btn儲存新增.Name = "btn儲存新增";
            this.btn儲存新增.Size = new System.Drawing.Size(140, 40);
            this.btn儲存新增.TabIndex = 1;
            this.btn儲存新增.Text = "儲存新增";
            this.btn儲存新增.UseVisualStyleBackColor = true;
            this.btn儲存新增.Click += new System.EventHandler(this.btn儲存新增_Click);
            // 
            // btn選取圖片1
            // 
            this.btn選取圖片1.Location = new System.Drawing.Point(4, 24);
            this.btn選取圖片1.Margin = new System.Windows.Forms.Padding(2);
            this.btn選取圖片1.Name = "btn選取圖片1";
            this.btn選取圖片1.Size = new System.Drawing.Size(140, 40);
            this.btn選取圖片1.TabIndex = 0;
            this.btn選取圖片1.Text = "選取圖片";
            this.btn選取圖片1.UseVisualStyleBackColor = true;
            this.btn選取圖片1.Click += new System.EventHandler(this.btn選取圖片1_Click);
            // 
            // pictureBox商品圖片
            // 
            this.pictureBox商品圖片.Location = new System.Drawing.Point(460, 86);
            this.pictureBox商品圖片.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox商品圖片.Name = "pictureBox商品圖片";
            this.pictureBox商品圖片.Size = new System.Drawing.Size(411, 531);
            this.pictureBox商品圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖片.TabIndex = 24;
            this.pictureBox商品圖片.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(499, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "商品圖片";
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt商品描述.Location = new System.Drawing.Point(16, 221);
            this.txt商品描述.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(440, 174);
            this.txt商品描述.TabIndex = 22;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt商品價格.Location = new System.Drawing.Point(131, 139);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(214, 39);
            this.txt商品價格.TabIndex = 21;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt商品名稱.Location = new System.Drawing.Point(131, 94);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(326, 39);
            this.txt商品名稱.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "商品描述(50字以內)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(325, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品詳細資訊";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(131, 56);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(176, 33);
            this.txtid.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "id";
            // 
            // 商品詳細資訊
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 641);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBox刪除);
            this.Controls.Add(this.gBox修改);
            this.Controls.Add(this.gBox新增);
            this.Controls.Add(this.pictureBox商品圖片);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "商品詳細資訊";
            this.Text = "商品詳細資訊(員工使用)";
            this.Load += new System.EventHandler(this.商品詳細資訊_Load);
            this.gBox刪除.ResumeLayout(false);
            this.gBox修改.ResumeLayout(false);
            this.gBox新增.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox刪除;
        private System.Windows.Forms.Button btn刪除商品;
        private System.Windows.Forms.GroupBox gBox修改;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取圖片2;
        private System.Windows.Forms.GroupBox gBox新增;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn儲存新增;
        private System.Windows.Forms.Button btn選取圖片1;
        private System.Windows.Forms.PictureBox pictureBox商品圖片;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
    }
}