namespace Mr.KimRice
{
    partial class Order
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
            this.label_teble_count = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_order_time = new System.Windows.Forms.Label();
            this.order_list = new System.Windows.Forms.ListView();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_all_cancel = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.text_order_price = new System.Windows.Forms.Label();
            this.ex_image = new System.Windows.Forms.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_kimbab = new System.Windows.Forms.Button();
            this.btn_bs = new System.Windows.Forms.Button();
            this.btn_meal = new System.Windows.Forms.Button();
            this.btn_noodle = new System.Windows.Forms.Button();
            this.btn_back_toMain = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.count_order = new System.Windows.Forms.Button();
            this.food_list = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label_teble_count
            // 
            this.label_teble_count.AutoSize = true;
            this.label_teble_count.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_teble_count.ForeColor = System.Drawing.SystemColors.Control;
            this.label_teble_count.Location = new System.Drawing.Point(19, 7);
            this.label_teble_count.Name = "label_teble_count";
            this.label_teble_count.Size = new System.Drawing.Size(99, 21);
            this.label_teble_count.TabIndex = 0;
            this.label_teble_count.Text = "n번 테이블 ";
            // 
            // label_order_time
            // 
            this.label_order_time.AutoSize = true;
            this.label_order_time.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_order_time.ForeColor = System.Drawing.SystemColors.Control;
            this.label_order_time.Location = new System.Drawing.Point(218, 7);
            this.label_order_time.Name = "label_order_time";
            this.label_order_time.Size = new System.Drawing.Size(100, 21);
            this.label_order_time.TabIndex = 1;
            this.label_order_time.Text = "주문 시간 : ";
            // 
            // order_list
            // 
            this.order_list.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.order_list.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_list.ForeColor = System.Drawing.SystemColors.Window;
            this.order_list.Location = new System.Drawing.Point(16, 33);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(394, 288);
            this.order_list.TabIndex = 2;
            this.order_list.UseCompatibleStateImageBehavior = false;
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_order.Location = new System.Drawing.Point(16, 327);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(394, 35);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "주문";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(16, 368);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_all_cancel
            // 
            this.btn_all_cancel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_all_cancel.Location = new System.Drawing.Point(97, 368);
            this.btn_all_cancel.Name = "btn_all_cancel";
            this.btn_all_cancel.Size = new System.Drawing.Size(95, 35);
            this.btn_all_cancel.TabIndex = 5;
            this.btn_all_cancel.Text = "전체 취소";
            this.btn_all_cancel.UseVisualStyleBackColor = true;
            this.btn_all_cancel.Click += new System.EventHandler(this.btn_all_cancel_Click_1);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_plus.Location = new System.Drawing.Point(198, 368);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_minus.Location = new System.Drawing.Point(244, 368);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // text_order_price
            // 
            this.text_order_price.AutoSize = true;
            this.text_order_price.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_order_price.ForeColor = System.Drawing.SystemColors.Control;
            this.text_order_price.Location = new System.Drawing.Point(290, 375);
            this.text_order_price.Name = "text_order_price";
            this.text_order_price.Size = new System.Drawing.Size(100, 21);
            this.text_order_price.TabIndex = 8;
            this.text_order_price.Text = "전체 금액 : ";
            // 
            // ex_image
            // 
            this.ex_image.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ex_image.Location = new System.Drawing.Point(16, 414);
            this.ex_image.Name = "ex_image";
            this.ex_image.Size = new System.Drawing.Size(490, 235);
            this.ex_image.TabIndex = 9;
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_all.Location = new System.Drawing.Point(416, 33);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(90, 62);
            this.btn_all.TabIndex = 10;
            this.btn_all.Text = "전체";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_kimbab
            // 
            this.btn_kimbab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_kimbab.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_kimbab.Location = new System.Drawing.Point(416, 101);
            this.btn_kimbab.Name = "btn_kimbab";
            this.btn_kimbab.Size = new System.Drawing.Size(90, 62);
            this.btn_kimbab.TabIndex = 11;
            this.btn_kimbab.Text = "김밥";
            this.btn_kimbab.UseVisualStyleBackColor = false;
            this.btn_kimbab.Click += new System.EventHandler(this.btn_kimbab_Click);
            // 
            // btn_bs
            // 
            this.btn_bs.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_bs.Location = new System.Drawing.Point(416, 169);
            this.btn_bs.Name = "btn_bs";
            this.btn_bs.Size = new System.Drawing.Size(90, 62);
            this.btn_bs.TabIndex = 12;
            this.btn_bs.Text = "분식";
            this.btn_bs.UseVisualStyleBackColor = true;
            this.btn_bs.Click += new System.EventHandler(this.btn_bs_Click);
            // 
            // btn_meal
            // 
            this.btn_meal.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_meal.Location = new System.Drawing.Point(416, 237);
            this.btn_meal.Name = "btn_meal";
            this.btn_meal.Size = new System.Drawing.Size(90, 62);
            this.btn_meal.TabIndex = 13;
            this.btn_meal.Text = "식사류";
            this.btn_meal.UseVisualStyleBackColor = true;
            this.btn_meal.Click += new System.EventHandler(this.btn_meal_Click);
            // 
            // btn_noodle
            // 
            this.btn_noodle.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_noodle.Location = new System.Drawing.Point(416, 303);
            this.btn_noodle.Name = "btn_noodle";
            this.btn_noodle.Size = new System.Drawing.Size(90, 60);
            this.btn_noodle.TabIndex = 14;
            this.btn_noodle.Text = "면류";
            this.btn_noodle.UseVisualStyleBackColor = true;
            this.btn_noodle.Click += new System.EventHandler(this.btn_noodle_Click);
            // 
            // btn_back_toMain
            // 
            this.btn_back_toMain.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back_toMain.Location = new System.Drawing.Point(514, 611);
            this.btn_back_toMain.Name = "btn_back_toMain";
            this.btn_back_toMain.Size = new System.Drawing.Size(560, 38);
            this.btn_back_toMain.TabIndex = 16;
            this.btn_back_toMain.Text = "Back";
            this.btn_back_toMain.UseVisualStyleBackColor = true;
            this.btn_back_toMain.Click += new System.EventHandler(this.btn_back_toMain_Click);
            // 
            // count_order
            // 
            this.count_order.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.count_order.Location = new System.Drawing.Point(514, 567);
            this.count_order.Name = "count_order";
            this.count_order.Size = new System.Drawing.Size(560, 38);
            this.count_order.TabIndex = 17;
            this.count_order.Text = "결제";
            this.count_order.UseVisualStyleBackColor = true;
            this.count_order.Click += new System.EventHandler(this.count_order_Click);
            // 
            // food_list
            // 
            this.food_list.Location = new System.Drawing.Point(514, 33);
            this.food_list.Name = "food_list";
            this.food_list.Size = new System.Drawing.Size(560, 528);
            this.food_list.TabIndex = 18;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.food_list);
            this.Controls.Add(this.count_order);
            this.Controls.Add(this.btn_back_toMain);
            this.Controls.Add(this.btn_noodle);
            this.Controls.Add(this.btn_meal);
            this.Controls.Add(this.btn_bs);
            this.Controls.Add(this.btn_kimbab);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.ex_image);
            this.Controls.Add(this.text_order_price);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_all_cancel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.label_order_time);
            this.Controls.Add(this.label_teble_count);
            this.Name = "Order";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_teble_count;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_order_time;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_all_cancel;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Label text_order_price;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_kimbab;
        private System.Windows.Forms.Button btn_bs;
        private System.Windows.Forms.Button btn_meal;
        private System.Windows.Forms.Button btn_noodle;
        private System.Windows.Forms.Button btn_back_toMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button count_order;
        public System.Windows.Forms.ListView order_list;
        public System.Windows.Forms.Panel ex_image;
        public System.Windows.Forms.FlowLayoutPanel food_list;
    }
}