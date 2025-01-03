namespace ADONET4
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonPgdn = new System.Windows.Forms.Button();
            this.ButtonPgup = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 158);
            this.dataGridView1.TabIndex = 9;
            // 
            // ButtonPgdn
            // 
            this.ButtonPgdn.Location = new System.Drawing.Point(646, 20);
            this.ButtonPgdn.Name = "ButtonPgdn";
            this.ButtonPgdn.Size = new System.Drawing.Size(141, 59);
            this.ButtonPgdn.TabIndex = 8;
            this.ButtonPgdn.Text = "button3";
            this.ButtonPgdn.UseVisualStyleBackColor = true;
            this.ButtonPgdn.Click += new System.EventHandler(this.ButtonPgdn_Click);
            // 
            // ButtonPgup
            // 
            this.ButtonPgup.Location = new System.Drawing.Point(499, 20);
            this.ButtonPgup.Name = "ButtonPgup";
            this.ButtonPgup.Size = new System.Drawing.Size(141, 59);
            this.ButtonPgup.TabIndex = 7;
            this.ButtonPgup.Text = "button2";
            this.ButtonPgup.UseVisualStyleBackColor = true;
            this.ButtonPgup.Click += new System.EventHandler(this.ButtonPgup_Click);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(12, 20);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(141, 59);
            this.ButtonSelect.TabIndex = 6;
            this.ButtonSelect.Text = "button1";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonPgdn);
            this.Controls.Add(this.ButtonPgup);
            this.Controls.Add(this.ButtonSelect);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonPgdn;
        private System.Windows.Forms.Button ButtonPgup;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Label label3;
    }
}

