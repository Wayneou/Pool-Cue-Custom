namespace WindowsFormsApp1
{
    partial class 登入畫面
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btn帳號登入 = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.帳號註冊 = new Sunny.UI.UIButton();
            this.btn商品瀏覽 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Black;
            this.uiLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(298, -8);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(299, 105);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Wayne\'s custom cue";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn帳號登入
            // 
            this.btn帳號登入.BackColor = System.Drawing.Color.White;
            this.btn帳號登入.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn帳號登入.FillColor = System.Drawing.Color.White;
            this.btn帳號登入.FillColor2 = System.Drawing.Color.White;
            this.btn帳號登入.FillDisableColor = System.Drawing.Color.Black;
            this.btn帳號登入.FillHoverColor = System.Drawing.Color.Black;
            this.btn帳號登入.FillPressColor = System.Drawing.Color.White;
            this.btn帳號登入.FillSelectedColor = System.Drawing.Color.White;
            this.btn帳號登入.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn帳號登入.ForeColor = System.Drawing.Color.Black;
            this.btn帳號登入.Location = new System.Drawing.Point(22, 672);
            this.btn帳號登入.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn帳號登入.Name = "btn帳號登入";
            this.btn帳號登入.Radius = 15;
            this.btn帳號登入.RectColor = System.Drawing.Color.White;
            this.btn帳號登入.RectDisableColor = System.Drawing.Color.White;
            this.btn帳號登入.RectHoverColor = System.Drawing.Color.White;
            this.btn帳號登入.RectPressColor = System.Drawing.Color.White;
            this.btn帳號登入.RectSelectedColor = System.Drawing.Color.White;
            this.btn帳號登入.Size = new System.Drawing.Size(148, 53);
            this.btn帳號登入.TabIndex = 2;
            this.btn帳號登入.Text = "會員登入";
            this.btn帳號登入.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn帳號登入.Click += new System.EventHandler(this.btn帳號登入_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 548);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // 帳號註冊
            // 
            this.帳號註冊.BackColor = System.Drawing.Color.White;
            this.帳號註冊.Cursor = System.Windows.Forms.Cursors.Hand;
            this.帳號註冊.FillColor = System.Drawing.Color.White;
            this.帳號註冊.FillColor2 = System.Drawing.Color.White;
            this.帳號註冊.FillDisableColor = System.Drawing.Color.Black;
            this.帳號註冊.FillHoverColor = System.Drawing.Color.Black;
            this.帳號註冊.FillPressColor = System.Drawing.Color.White;
            this.帳號註冊.FillSelectedColor = System.Drawing.Color.White;
            this.帳號註冊.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號註冊.ForeColor = System.Drawing.Color.Black;
            this.帳號註冊.Location = new System.Drawing.Point(207, 672);
            this.帳號註冊.MinimumSize = new System.Drawing.Size(1, 1);
            this.帳號註冊.Name = "帳號註冊";
            this.帳號註冊.Radius = 15;
            this.帳號註冊.RectColor = System.Drawing.SystemColors.Window;
            this.帳號註冊.RectDisableColor = System.Drawing.Color.White;
            this.帳號註冊.RectHoverColor = System.Drawing.Color.White;
            this.帳號註冊.RectPressColor = System.Drawing.Color.White;
            this.帳號註冊.RectSelectedColor = System.Drawing.Color.White;
            this.帳號註冊.Size = new System.Drawing.Size(148, 53);
            this.帳號註冊.TabIndex = 4;
            this.帳號註冊.Text = "帳號註冊";
            this.帳號註冊.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號註冊.Click += new System.EventHandler(this.btn帳號註冊_Click);
            // 
            // btn商品瀏覽
            // 
            this.btn商品瀏覽.BackColor = System.Drawing.Color.White;
            this.btn商品瀏覽.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn商品瀏覽.FillColor = System.Drawing.Color.White;
            this.btn商品瀏覽.FillColor2 = System.Drawing.Color.White;
            this.btn商品瀏覽.FillDisableColor = System.Drawing.Color.Black;
            this.btn商品瀏覽.FillHoverColor = System.Drawing.Color.Black;
            this.btn商品瀏覽.FillPressColor = System.Drawing.Color.White;
            this.btn商品瀏覽.FillSelectedColor = System.Drawing.Color.White;
            this.btn商品瀏覽.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品瀏覽.ForeColor = System.Drawing.Color.Black;
            this.btn商品瀏覽.Location = new System.Drawing.Point(744, 672);
            this.btn商品瀏覽.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn商品瀏覽.Name = "btn商品瀏覽";
            this.btn商品瀏覽.Radius = 15;
            this.btn商品瀏覽.RectColor = System.Drawing.Color.White;
            this.btn商品瀏覽.RectDisableColor = System.Drawing.Color.White;
            this.btn商品瀏覽.RectHoverColor = System.Drawing.Color.White;
            this.btn商品瀏覽.RectPressColor = System.Drawing.Color.White;
            this.btn商品瀏覽.RectSelectedColor = System.Drawing.Color.White;
            this.btn商品瀏覽.Size = new System.Drawing.Size(148, 53);
            this.btn商品瀏覽.TabIndex = 5;
            this.btn商品瀏覽.Text = "商品瀏覽";
            this.btn商品瀏覽.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品瀏覽.Click += new System.EventHandler(this.btn商品瀏覽_Click);
            // 
            // 登入畫面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 737);
            this.Controls.Add(this.btn商品瀏覽);
            this.Controls.Add(this.帳號註冊);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn帳號登入);
            this.Controls.Add(this.uiLabel1);
            this.Name = "登入畫面";
            this.Text = "登入畫面";
            this.Load += new System.EventHandler(this.登入畫面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn帳號登入;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton 帳號註冊;
        private Sunny.UI.UIButton btn商品瀏覽;
    }
}

