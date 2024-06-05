namespace WindowsFormsApp1
{
    partial class 會員Form2
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
            this.lbl帳號 = new Sunny.UI.UILabel();
            this.lbl密碼 = new Sunny.UI.UILabel();
            this.txt帳號 = new Sunny.UI.UITextBox();
            this.btn登入 = new Sunny.UI.UIButton();
            this.txt密碼 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // lbl帳號
            // 
            this.lbl帳號.BackColor = System.Drawing.Color.Black;
            this.lbl帳號.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl帳號.ForeColor = System.Drawing.Color.White;
            this.lbl帳號.Location = new System.Drawing.Point(31, 78);
            this.lbl帳號.Name = "lbl帳號";
            this.lbl帳號.Size = new System.Drawing.Size(100, 23);
            this.lbl帳號.TabIndex = 1;
            this.lbl帳號.Text = "帳號";
            this.lbl帳號.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl帳號.Click += new System.EventHandler(this.lbl帳號_Click);
            // 
            // lbl密碼
            // 
            this.lbl密碼.BackColor = System.Drawing.Color.Black;
            this.lbl密碼.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl密碼.ForeColor = System.Drawing.Color.White;
            this.lbl密碼.Location = new System.Drawing.Point(31, 203);
            this.lbl密碼.Name = "lbl密碼";
            this.lbl密碼.Size = new System.Drawing.Size(100, 23);
            this.lbl密碼.TabIndex = 2;
            this.lbl密碼.Text = "密碼";
            this.lbl密碼.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt帳號
            // 
            this.txt帳號.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt帳號.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(129, 78);
            this.txt帳號.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt帳號.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Padding = new System.Windows.Forms.Padding(5);
            this.txt帳號.ShowText = false;
            this.txt帳號.Size = new System.Drawing.Size(214, 58);
            this.txt帳號.TabIndex = 4;
            this.txt帳號.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt帳號.Watermark = "";
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.White;
            this.btn登入.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn登入.FillColor = System.Drawing.Color.White;
            this.btn登入.FillColor2 = System.Drawing.Color.White;
            this.btn登入.FillDisableColor = System.Drawing.Color.Black;
            this.btn登入.FillHoverColor = System.Drawing.Color.Black;
            this.btn登入.FillPressColor = System.Drawing.Color.White;
            this.btn登入.FillSelectedColor = System.Drawing.Color.White;
            this.btn登入.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.ForeColor = System.Drawing.Color.Black;
            this.btn登入.Location = new System.Drawing.Point(195, 344);
            this.btn登入.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn登入.Name = "btn登入";
            this.btn登入.Radius = 15;
            this.btn登入.RectColor = System.Drawing.Color.White;
            this.btn登入.RectDisableColor = System.Drawing.Color.White;
            this.btn登入.RectHoverColor = System.Drawing.Color.White;
            this.btn登入.RectPressColor = System.Drawing.Color.White;
            this.btn登入.RectSelectedColor = System.Drawing.Color.White;
            this.btn登入.Size = new System.Drawing.Size(148, 53);
            this.btn登入.TabIndex = 6;
            this.btn登入.Text = "登入";
            this.btn登入.TipsFont = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // txt密碼
            // 
            this.txt密碼.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt密碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(132, 203);
            this.txt密碼.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt密碼.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Padding = new System.Windows.Forms.Padding(5);
            this.txt密碼.ShowText = false;
            this.txt密碼.Size = new System.Drawing.Size(214, 62);
            this.txt密碼.TabIndex = 3;
            this.txt密碼.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt密碼.Watermark = "";
            // 
            // 會員Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.lbl密碼);
            this.Controls.Add(this.lbl帳號);
            this.Name = "會員Form2";
            this.Text = "使用者登入Form";
            this.Load += new System.EventHandler(this.會員Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lbl帳號;
        private Sunny.UI.UILabel lbl密碼;
        private Sunny.UI.UITextBox txt帳號;
        private Sunny.UI.UIButton btn登入;
        private Sunny.UI.UITextBox txt密碼;
    }
}