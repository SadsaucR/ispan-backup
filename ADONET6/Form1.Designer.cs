namespace ADONET6
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
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonWhere = new System.Windows.Forms.Button();
            this.ButtonAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name.Location = new System.Drawing.Point(440, 100);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(401, 50);
            this.name.TabIndex = 28;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.id.Location = new System.Drawing.Point(29, 100);
            this.id.Margin = new System.Windows.Forms.Padding(5);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(198, 50);
            this.id.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 428);
            this.dataGridView1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 428);
            this.textBox2.TabIndex = 25;
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.key.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.key.Location = new System.Drawing.Point(237, 100);
            this.key.Margin = new System.Windows.Forms.Padding(5);
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(198, 50);
            this.key.TabIndex = 24;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(445, 34);
            this.ButtonTest.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(193, 56);
            this.ButtonTest.TabIndex = 23;
            this.ButtonTest.Text = "Add ALT_Key";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // ButtonWhere
            // 
            this.ButtonWhere.Location = new System.Drawing.Point(237, 34);
            this.ButtonWhere.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonWhere.Name = "ButtonWhere";
            this.ButtonWhere.Size = new System.Drawing.Size(198, 56);
            this.ButtonWhere.TabIndex = 22;
            this.ButtonWhere.Text = "開啟綁定功能";
            this.ButtonWhere.UseVisualStyleBackColor = true;
            this.ButtonWhere.Click += new System.EventHandler(this.ButtonWhere_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.Location = new System.Drawing.Point(29, 34);
            this.ButtonAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.Size = new System.Drawing.Size(198, 56);
            this.ButtonAll.TabIndex = 21;
            this.ButtonAll.Text = "查詢全部";
            this.ButtonAll.UseVisualStyleBackColor = true;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 56);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add ALT_Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 56);
            this.button2.TabIndex = 30;
            this.button2.Text = "Add ALT_Key";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonWhere);
            this.Controls.Add(this.ButtonAll);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button ButtonWhere;
        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

