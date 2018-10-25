namespace Mr.KimRice
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category_list = new System.Windows.Forms.ListView();
            this.menu_list = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "좌석";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "통계";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "카테고리별 하루 매출";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(516, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "메뉴별 하루 매출";
            // 
            // category_list
            // 
            this.category_list.Location = new System.Drawing.Point(17, 143);
            this.category_list.Name = "category_list";
            this.category_list.Size = new System.Drawing.Size(395, 384);
            this.category_list.TabIndex = 5;
            this.category_list.UseCompatibleStateImageBehavior = false;
            // 
            // menu_list
            // 
            this.menu_list.Location = new System.Drawing.Point(520, 143);
            this.menu_list.Name = "menu_list";
            this.menu_list.Size = new System.Drawing.Size(393, 384);
            this.menu_list.TabIndex = 6;
            this.menu_list.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1023, 610);
            this.Controls.Add(this.menu_list);
            this.Controls.Add(this.category_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView category_list;
        private System.Windows.Forms.ListView menu_list;
    }
}