namespace ADONET4
{
    partial class Form3
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
            this.ButtonAll = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.ButtonMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAll
            // 
            this.ButtonAll.Location = new System.Drawing.Point(12, 25);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.Size = new System.Drawing.Size(141, 59);
            this.ButtonAll.TabIndex = 0;
            this.ButtonAll.Text = "All";
            this.ButtonAll.UseVisualStyleBackColor = true;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(187, 25);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(141, 59);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(361, 25);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(141, 59);
            this.ButtonTest.TabIndex = 2;
            this.ButtonTest.Text = "Test";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 384);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 99);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(141, 54);
            this.txtID.TabIndex = 4;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(187, 99);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(141, 54);
            this.txtKey.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(361, 99);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(664, 54);
            this.txtName.TabIndex = 6;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(633, 171);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(392, 384);
            this.result.TabIndex = 7;
            // 
            // ButtonMod
            // 
            this.ButtonMod.Location = new System.Drawing.Point(526, 25);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(141, 59);
            this.ButtonMod.TabIndex = 8;
            this.ButtonMod.Text = "Test";
            this.ButtonMod.UseVisualStyleBackColor = true;
            this.ButtonMod.Click += new System.EventHandler(this.ButtonMod_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 663);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAll);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button ButtonMod;
    }
}