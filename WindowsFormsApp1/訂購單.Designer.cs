namespace WindowsFormsApp1
{
    partial class 訂購單
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
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.btn後節底木 = new System.Windows.Forms.Button();
            this.gbox材料選擇 = new System.Windows.Forms.GroupBox();
            this.btn款式 = new System.Windows.Forms.Button();
            this.btn握把 = new System.Windows.Forms.Button();
            this.btn環 = new System.Windows.Forms.Button();
            this.btn前節 = new System.Windows.Forms.Button();
            this.btn插角底木 = new System.Windows.Forms.Button();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.gbox材料選擇.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看購物車.Location = new System.Drawing.Point(538, 688);
            this.btn查看購物車.Margin = new System.Windows.Forms.Padding(2);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(251, 71);
            this.btn查看購物車.TabIndex = 17;
            this.btn查看購物車.Text = "查看購物車-結帳";
            this.btn查看購物車.UseVisualStyleBackColor = true;
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(331, 695);
            this.btn加入購物車.Margin = new System.Windows.Forms.Padding(2);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(184, 64);
            this.btn加入購物車.TabIndex = 16;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(17, 185);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(2);
            this.listView商品展示.MultiSelect = false;
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(777, 486);
            this.listView商品展示.TabIndex = 15;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            this.listView商品展示.SelectedIndexChanged += new System.EventHandler(this.listView商品展示_SelectedIndexChanged);
            // 
            // btn後節底木
            // 
            this.btn後節底木.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn後節底木.Location = new System.Drawing.Point(6, 51);
            this.btn後節底木.Name = "btn後節底木";
            this.btn後節底木.Size = new System.Drawing.Size(120, 50);
            this.btn後節底木.TabIndex = 18;
            this.btn後節底木.Text = "後節底木";
            this.btn後節底木.UseVisualStyleBackColor = true;
            this.btn後節底木.Click += new System.EventHandler(this.btn後節底木_Click);
            // 
            // gbox材料選擇
            // 
            this.gbox材料選擇.Controls.Add(this.btn款式);
            this.gbox材料選擇.Controls.Add(this.btn握把);
            this.gbox材料選擇.Controls.Add(this.btn環);
            this.gbox材料選擇.Controls.Add(this.btn前節);
            this.gbox材料選擇.Controls.Add(this.btn插角底木);
            this.gbox材料選擇.Controls.Add(this.btn後節底木);
            this.gbox材料選擇.Location = new System.Drawing.Point(11, 12);
            this.gbox材料選擇.Name = "gbox材料選擇";
            this.gbox材料選擇.Size = new System.Drawing.Size(777, 112);
            this.gbox材料選擇.TabIndex = 19;
            this.gbox材料選擇.TabStop = false;
            this.gbox材料選擇.Text = "材料選擇";
            this.gbox材料選擇.Enter += new System.EventHandler(this.gbox材料選擇_Enter);
            // 
            // btn款式
            // 
            this.btn款式.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn款式.Location = new System.Drawing.Point(636, 51);
            this.btn款式.Name = "btn款式";
            this.btn款式.Size = new System.Drawing.Size(120, 50);
            this.btn款式.TabIndex = 23;
            this.btn款式.Text = "款式";
            this.btn款式.UseVisualStyleBackColor = true;
            this.btn款式.Click += new System.EventHandler(this.btn款式_Click);
            // 
            // btn握把
            // 
            this.btn握把.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn握把.Location = new System.Drawing.Point(510, 51);
            this.btn握把.Name = "btn握把";
            this.btn握把.Size = new System.Drawing.Size(120, 50);
            this.btn握把.TabIndex = 22;
            this.btn握把.Text = "握把";
            this.btn握把.UseVisualStyleBackColor = true;
            this.btn握把.Click += new System.EventHandler(this.btn握把_Click);
            // 
            // btn環
            // 
            this.btn環.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn環.Location = new System.Drawing.Point(384, 51);
            this.btn環.Name = "btn環";
            this.btn環.Size = new System.Drawing.Size(120, 50);
            this.btn環.TabIndex = 21;
            this.btn環.Text = "環";
            this.btn環.UseVisualStyleBackColor = true;
            this.btn環.Click += new System.EventHandler(this.btn環_Click);
            // 
            // btn前節
            // 
            this.btn前節.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn前節.Location = new System.Drawing.Point(258, 51);
            this.btn前節.Name = "btn前節";
            this.btn前節.Size = new System.Drawing.Size(120, 50);
            this.btn前節.TabIndex = 20;
            this.btn前節.Text = "前節";
            this.btn前節.UseVisualStyleBackColor = true;
            this.btn前節.Click += new System.EventHandler(this.btn前節_Click);
            // 
            // btn插角底木
            // 
            this.btn插角底木.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn插角底木.Location = new System.Drawing.Point(132, 51);
            this.btn插角底木.Name = "btn插角底木";
            this.btn插角底木.Size = new System.Drawing.Size(120, 50);
            this.btn插角底木.TabIndex = 19;
            this.btn插角底木.Text = "插角底木";
            this.btn插角底木.UseVisualStyleBackColor = true;
            this.btn插角底木.Click += new System.EventHandler(this.btn插角底木_Click);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 訂購單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 770);
            this.Controls.Add(this.gbox材料選擇);
            this.Controls.Add(this.btn查看購物車);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.listView商品展示);
            this.Name = "訂購單";
            this.Text = "訂購單";
            this.Load += new System.EventHandler(this.訂購單_Load);
            this.gbox材料選擇.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn查看購物車;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Button btn後節底木;
        private System.Windows.Forms.GroupBox gbox材料選擇;
        private System.Windows.Forms.Button btn款式;
        private System.Windows.Forms.Button btn握把;
        private System.Windows.Forms.Button btn環;
        private System.Windows.Forms.Button btn前節;
        private System.Windows.Forms.Button btn插角底木;
        private System.Windows.Forms.ImageList imageList商品圖檔;
    }
}