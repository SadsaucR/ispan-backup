namespace ADONET5
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
            this.id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonWhere = new System.Windows.Forms.Button();
            this.ButtonAll = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.id.Location = new System.Drawing.Point(26, 92);
            this.id.Margin = new System.Windows.Forms.Padding(5);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(198, 50);
            this.id.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 428);
            this.dataGridView1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(645, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 554);
            this.textBox2.TabIndex = 17;
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.key.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.key.Location = new System.Drawing.Point(234, 92);
            this.key.Margin = new System.Windows.Forms.Padding(5);
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(198, 50);
            this.key.TabIndex = 16;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(442, 26);
            this.ButtonTest.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(193, 56);
            this.ButtonTest.TabIndex = 15;
            this.ButtonTest.Text = "實驗";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // ButtonWhere
            // 
            this.ButtonWhere.Location = new System.Drawing.Point(234, 26);
            this.ButtonWhere.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonWhere.Name = "ButtonWhere";
            this.ButtonWhere.Size = new System.Drawing.Size(198, 56);
            this.ButtonWhere.TabIndex = 14;
            this.ButtonWhere.Text = "Test";
            this.ButtonWhere.UseVisualStyleBackColor = true;
            this.ButtonWhere.Click += new System.EventHandler(this.ButtonWhere_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.Location = new System.Drawing.Point(26, 26);
            this.ButtonAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.Size = new System.Drawing.Size(198, 56);
            this.ButtonAll.TabIndex = 13;
            this.ButtonAll.Text = "查詢全部";
            this.ButtonAll.UseVisualStyleBackColor = true;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name.Location = new System.Drawing.Point(437, 92);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 50);
            this.name.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 630);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonWhere);
            this.Controls.Add(this.ButtonAll);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button ButtonWhere;
        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.TextBox name;
    }
}

