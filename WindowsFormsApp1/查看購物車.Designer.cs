namespace WindowsFormsApp1
{
    partial class 查看購物車
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
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.btn輸出訂購單檔案 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.lbox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉表單.Location = new System.Drawing.Point(325, 519);
            this.btn關閉表單.Margin = new System.Windows.Forms.Padding(2);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(129, 46);
            this.btn關閉表單.TabIndex = 19;
            this.btn關閉表單.Text = "繼續訂購(關閉表單)";
            this.btn關閉表單.UseVisualStyleBackColor = true;
            // 
            // btn輸出訂購單檔案
            // 
            this.btn輸出訂購單檔案.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單檔案.ForeColor = System.Drawing.Color.Blue;
            this.btn輸出訂購單檔案.Location = new System.Drawing.Point(325, 453);
            this.btn輸出訂購單檔案.Margin = new System.Windows.Forms.Padding(2);
            this.btn輸出訂購單檔案.Name = "btn輸出訂購單檔案";
            this.btn輸出訂購單檔案.Size = new System.Drawing.Size(129, 46);
            this.btn輸出訂購單檔案.TabIndex = 18;
            this.btn輸出訂購單檔案.Text = "輸出訂購單檔案";
            this.btn輸出訂購單檔案.UseVisualStyleBackColor = true;
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.ForeColor = System.Drawing.Color.Red;
            this.btn清除所有品項.Location = new System.Drawing.Point(176, 520);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(2);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(130, 40);
            this.btn清除所有品項.TabIndex = 17;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(176, 452);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(2);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(130, 46);
            this.btn移除所選品項.TabIndex = 16;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.Cyan;
            this.lbl訂單總價.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(499, 408);
            this.lbl訂單總價.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(221, 69);
            this.lbl訂單總價.TabIndex = 15;
            this.lbl訂單總價.Text = "訂單總價00000元";
            this.lbl訂單總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbox訂購品項列表
            // 
            this.lbox訂購品項列表.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂購品項列表.FormattingEnabled = true;
            this.lbox訂購品項列表.ItemHeight = 24;
            this.lbox訂購品項列表.Location = new System.Drawing.Point(11, 128);
            this.lbox訂購品項列表.Margin = new System.Windows.Forms.Padding(2);
            this.lbox訂購品項列表.Name = "lbox訂購品項列表";
            this.lbox訂購品項列表.Size = new System.Drawing.Size(703, 268);
            this.lbox訂購品項列表.TabIndex = 12;
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.AutoSize = true;
            this.lbl訂購人資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl訂購人資料.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(21, 85);
            this.lbl訂購人資料.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(152, 27);
            this.lbl訂購人資料.TabIndex = 11;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(280, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "訂購品項列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 查看購物車
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 578);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.btn輸出訂購單檔案);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.lbox訂購品項列表);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.label1);
            this.Name = "查看購物車";
            this.Text = "查看購物車";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Button btn輸出訂購單檔案;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.ListBox lbox訂購品項列表;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.Label label1;
    }
}