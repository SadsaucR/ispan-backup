namespace ADONET3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SqlCode = new System.Windows.Forms.TextBox();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonWhere = new System.Windows.Forms.Button();
            this.ButtonAll = new System.Windows.Forms.Button();
            this.schinput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 368);
            this.dataGridView1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(686, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 554);
            this.textBox2.TabIndex = 10;
            // 
            // SqlCode
            // 
            this.SqlCode.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SqlCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SqlCode.Location = new System.Drawing.Point(67, 149);
            this.SqlCode.Margin = new System.Windows.Forms.Padding(5);
            this.SqlCode.Multiline = true;
            this.SqlCode.Name = "SqlCode";
            this.SqlCode.Size = new System.Drawing.Size(609, 50);
            this.SqlCode.TabIndex = 9;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(483, 23);
            this.ButtonTest.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(193, 56);
            this.ButtonTest.TabIndex = 8;
            this.ButtonTest.Text = "實驗";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // ButtonWhere
            // 
            this.ButtonWhere.Location = new System.Drawing.Point(275, 23);
            this.ButtonWhere.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonWhere.Name = "ButtonWhere";
            this.ButtonWhere.Size = new System.Drawing.Size(198, 56);
            this.ButtonWhere.TabIndex = 7;
            this.ButtonWhere.Text = "有條件";
            this.ButtonWhere.UseVisualStyleBackColor = true;
            this.ButtonWhere.Click += new System.EventHandler(this.ButtonWhere_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.Location = new System.Drawing.Point(67, 23);
            this.ButtonAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.Size = new System.Drawing.Size(198, 56);
            this.ButtonAll.TabIndex = 6;
            this.ButtonAll.Text = "查詢全部";
            this.ButtonAll.UseVisualStyleBackColor = true;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // schinput
            // 
            this.schinput.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.schinput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.schinput.Location = new System.Drawing.Point(67, 89);
            this.schinput.Margin = new System.Windows.Forms.Padding(5);
            this.schinput.Multiline = true;
            this.schinput.Name = "schinput";
            this.schinput.Size = new System.Drawing.Size(609, 50);
            this.schinput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.schinput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SqlCode);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonWhere);
            this.Controls.Add(this.ButtonAll);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox SqlCode;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button ButtonWhere;
        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.TextBox schinput;
    }
}

