namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZoneNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZoneNum2 = new System.Windows.Forms.NumericUpDown();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ZoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoneNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZoneNum
            // 
            this.ZoneNum.Location = new System.Drawing.Point(29, 130);
            this.ZoneNum.Name = "ZoneNum";
            this.ZoneNum.Size = new System.Drawing.Size(120, 20);
            this.ZoneNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuantas zonas desea ver";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sensor de zonas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cuantos sensores quieres ver en esta zona:";
            // 
            // ZoneNum2
            // 
            this.ZoneNum2.Location = new System.Drawing.Point(29, 237);
            this.ZoneNum2.Name = "ZoneNum2";
            this.ZoneNum2.Size = new System.Drawing.Size(120, 20);
            this.ZoneNum2.TabIndex = 5;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(495, 163);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1013, 223);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPromedio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 309);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Promedio de temperatura";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(758, 117);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(159, 20);
            this.txtPromedio.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.ZoneNum2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoneNum);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ZoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoneNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ZoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ZoneNum2;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label3;
    }
}

