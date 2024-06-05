namespace WindowsFormsApp1
{
    partial class 商品展示cs
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl使用者 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl權限 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserName.Location = new System.Drawing.Point(545, -33);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 30);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "User";
            // 
            // btn列表模式
            // 
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.Location = new System.Drawing.Point(319, 11);
            this.btn列表模式.Margin = new System.Windows.Forms.Padding(2);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(137, 53);
            this.btn列表模式.TabIndex = 10;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = true;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.Location = new System.Drawing.Point(162, 11);
            this.btn圖片模式.Margin = new System.Windows.Forms.Padding(2);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(137, 53);
            this.btn圖片模式.TabIndex = 9;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = true;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(11, 86);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(2);
            this.listView商品展示.MultiSelect = false;
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(778, 503);
            this.listView商品展示.TabIndex = 8;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(299, -39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品展示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品展示";
            // 
            // lbl使用者
            // 
            this.lbl使用者.AutoSize = true;
            this.lbl使用者.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者.Location = new System.Drawing.Point(584, 9);
            this.lbl使用者.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl使用者.Name = "lbl使用者";
            this.lbl使用者.Size = new System.Drawing.Size(85, 30);
            this.lbl使用者.TabIndex = 15;
            this.lbl使用者.Text = "使用者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(497, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "用戶";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(497, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "權限";
            // 
            // lbl權限
            // 
            this.lbl權限.AutoSize = true;
            this.lbl權限.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl權限.Location = new System.Drawing.Point(586, 54);
            this.lbl權限.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl權限.Name = "lbl權限";
            this.lbl權限.Size = new System.Drawing.Size(61, 30);
            this.lbl權限.TabIndex = 18;
            this.lbl權限.Text = "權限";
            // 
            // 商品展示cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbl權限);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl使用者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label1);
            this.Name = "商品展示cs";
            this.Text = "商品展示cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl使用者;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl權限;
    }
}