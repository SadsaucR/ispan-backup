namespace NETOBJ
{
    partial class Cockulator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.padminus = new System.Windows.Forms.Button();
            this.padplus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.padequal = new System.Windows.Forms.Button();
            this.padreset = new System.Windows.Forms.Button();
            this.pad9 = new System.Windows.Forms.Button();
            this.pad8 = new System.Windows.Forms.Button();
            this.pad7 = new System.Windows.Forms.Button();
            this.pad6 = new System.Windows.Forms.Button();
            this.pad5 = new System.Windows.Forms.Button();
            this.pad4 = new System.Windows.Forms.Button();
            this.pad3 = new System.Windows.Forms.Button();
            this.pad2 = new System.Windows.Forms.Button();
            this.pad1 = new System.Windows.Forms.Button();
            this.pad0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.padminus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.padplus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.padequal, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.padreset, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pad9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pad8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pad7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pad6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pad5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pad4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pad3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pad2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pad1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pad0, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 186);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(429, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 97);
            this.button4.TabIndex = 18;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.oper);
            // 
            // padminus
            // 
            this.padminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padminus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.padminus.Location = new System.Drawing.Point(429, 209);
            this.padminus.Name = "padminus";
            this.padminus.Size = new System.Drawing.Size(138, 97);
            this.padminus.TabIndex = 17;
            this.padminus.Text = "-";
            this.padminus.UseVisualStyleBackColor = true;
            this.padminus.Click += new System.EventHandler(this.oper);
            // 
            // padplus
            // 
            this.padplus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padplus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.padplus.Location = new System.Drawing.Point(429, 106);
            this.padplus.Name = "padplus";
            this.padplus.Size = new System.Drawing.Size(138, 97);
            this.padplus.TabIndex = 16;
            this.padplus.Text = "+";
            this.padplus.UseVisualStyleBackColor = true;
            this.padplus.Click += new System.EventHandler(this.oper);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(429, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 97);
            this.button1.TabIndex = 15;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.oper);
            // 
            // padequal
            // 
            this.padequal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padequal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.padequal.Location = new System.Drawing.Point(287, 312);
            this.padequal.Name = "padequal";
            this.padequal.Size = new System.Drawing.Size(136, 97);
            this.padequal.TabIndex = 14;
            this.padequal.Text = "=";
            this.padequal.UseVisualStyleBackColor = true;
            this.padequal.Click += new System.EventHandler(this.padequal_Click);
            // 
            // padreset
            // 
            this.padreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padreset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.padreset.Location = new System.Drawing.Point(3, 312);
            this.padreset.Name = "padreset";
            this.padreset.Size = new System.Drawing.Size(136, 97);
            this.padreset.TabIndex = 13;
            this.padreset.Text = "RS";
            this.padreset.UseVisualStyleBackColor = true;
            // 
            // pad9
            // 
            this.pad9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad9.Location = new System.Drawing.Point(287, 209);
            this.pad9.Name = "pad9";
            this.pad9.Size = new System.Drawing.Size(136, 97);
            this.pad9.TabIndex = 11;
            this.pad9.Text = "9";
            this.pad9.UseVisualStyleBackColor = true;
            this.pad9.Click += new System.EventHandler(this.num_input);
            // 
            // pad8
            // 
            this.pad8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad8.Location = new System.Drawing.Point(145, 209);
            this.pad8.Name = "pad8";
            this.pad8.Size = new System.Drawing.Size(136, 97);
            this.pad8.TabIndex = 10;
            this.pad8.Text = "8";
            this.pad8.UseVisualStyleBackColor = true;
            this.pad8.Click += new System.EventHandler(this.num_input);
            // 
            // pad7
            // 
            this.pad7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad7.Location = new System.Drawing.Point(3, 209);
            this.pad7.Name = "pad7";
            this.pad7.Size = new System.Drawing.Size(136, 97);
            this.pad7.TabIndex = 9;
            this.pad7.Text = "7";
            this.pad7.UseVisualStyleBackColor = true;
            this.pad7.Click += new System.EventHandler(this.num_input);
            // 
            // pad6
            // 
            this.pad6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad6.Location = new System.Drawing.Point(287, 106);
            this.pad6.Name = "pad6";
            this.pad6.Size = new System.Drawing.Size(136, 97);
            this.pad6.TabIndex = 7;
            this.pad6.Text = "6";
            this.pad6.UseVisualStyleBackColor = true;
            this.pad6.Click += new System.EventHandler(this.num_input);
            // 
            // pad5
            // 
            this.pad5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad5.Location = new System.Drawing.Point(145, 106);
            this.pad5.Name = "pad5";
            this.pad5.Size = new System.Drawing.Size(136, 97);
            this.pad5.TabIndex = 6;
            this.pad5.Text = "5";
            this.pad5.UseVisualStyleBackColor = true;
            this.pad5.Click += new System.EventHandler(this.num_input);
            // 
            // pad4
            // 
            this.pad4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad4.Location = new System.Drawing.Point(3, 106);
            this.pad4.Name = "pad4";
            this.pad4.Size = new System.Drawing.Size(136, 97);
            this.pad4.TabIndex = 5;
            this.pad4.Text = "4";
            this.pad4.UseVisualStyleBackColor = true;
            this.pad4.Click += new System.EventHandler(this.num_input);
            // 
            // pad3
            // 
            this.pad3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad3.Location = new System.Drawing.Point(287, 3);
            this.pad3.Name = "pad3";
            this.pad3.Size = new System.Drawing.Size(136, 97);
            this.pad3.TabIndex = 3;
            this.pad3.Text = "3";
            this.pad3.UseVisualStyleBackColor = true;
            this.pad3.Click += new System.EventHandler(this.num_input);
            // 
            // pad2
            // 
            this.pad2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad2.Location = new System.Drawing.Point(145, 3);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(136, 97);
            this.pad2.TabIndex = 2;
            this.pad2.Text = "2";
            this.pad2.UseVisualStyleBackColor = true;
            this.pad2.Click += new System.EventHandler(this.num_input);
            // 
            // pad1
            // 
            this.pad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad1.Location = new System.Drawing.Point(3, 3);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(136, 97);
            this.pad1.TabIndex = 1;
            this.pad1.Text = "1";
            this.pad1.UseVisualStyleBackColor = true;
            this.pad1.Click += new System.EventHandler(this.num_input);
            // 
            // pad0
            // 
            this.pad0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad0.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pad0.Location = new System.Drawing.Point(145, 312);
            this.pad0.Name = "pad0";
            this.pad0.Size = new System.Drawing.Size(136, 97);
            this.pad0.TabIndex = 0;
            this.pad0.Text = "0";
            this.pad0.UseVisualStyleBackColor = true;
            this.pad0.Click += new System.EventHandler(this.num_input);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 76);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(564, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 75);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(567, 151);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Cockulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 620);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Cockulator";
            this.Text = "Cockulator";
            this.Load += new System.EventHandler(this.Cockulator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button pad0;
        private System.Windows.Forms.Button padequal;
        private System.Windows.Forms.Button padreset;
        private System.Windows.Forms.Button pad9;
        private System.Windows.Forms.Button pad8;
        private System.Windows.Forms.Button pad7;
        private System.Windows.Forms.Button pad6;
        private System.Windows.Forms.Button pad5;
        private System.Windows.Forms.Button pad4;
        private System.Windows.Forms.Button pad3;
        private System.Windows.Forms.Button pad2;
        private System.Windows.Forms.Button pad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button padminus;
        private System.Windows.Forms.Button padplus;
        private System.Windows.Forms.Button button1;
    }
}