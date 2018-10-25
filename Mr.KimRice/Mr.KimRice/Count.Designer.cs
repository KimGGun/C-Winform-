namespace Mr.KimRice
{
    partial class Count
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
            this.table_id_label = new System.Windows.Forms.Label();
            this.order_info_label = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.count_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // table_id_label
            // 
            this.table_id_label.AutoSize = true;
            this.table_id_label.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table_id_label.Location = new System.Drawing.Point(12, 9);
            this.table_id_label.Name = "table_id_label";
            this.table_id_label.Size = new System.Drawing.Size(68, 18);
            this.table_id_label.TabIndex = 0;
            this.table_id_label.Text = "table_id";
            // 
            // order_info_label
            // 
            this.order_info_label.AutoSize = true;
            this.order_info_label.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_info_label.Location = new System.Drawing.Point(174, 76);
            this.order_info_label.Name = "order_info_label";
            this.order_info_label.Size = new System.Drawing.Size(102, 21);
            this.order_info_label.TabIndex = 1;
            this.order_info_label.Text = "order_info";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(178, 218);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "결제";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(303, 218);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // count_price
            // 
            this.count_price.AutoSize = true;
            this.count_price.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.count_price.Location = new System.Drawing.Point(12, 219);
            this.count_price.Name = "count_price";
            this.count_price.Size = new System.Drawing.Size(46, 18);
            this.count_price.TabIndex = 4;
            this.count_price.Text = "Price";
            // 
            // Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 263);
            this.Controls.Add(this.count_price);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.order_info_label);
            this.Controls.Add(this.table_id_label);
            this.Name = "Count";
            this.Text = "Count";
            this.Load += new System.EventHandler(this.Count_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_id_label;
        private System.Windows.Forms.Label order_info_label;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label count_price;
    }
}