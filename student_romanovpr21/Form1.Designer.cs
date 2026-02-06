
namespace student_romanovpr21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.foodWeight_sel = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weight_sel = new System.Windows.Forms.NumericUpDown();
            this.height_sel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.foodWeight_sel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_sel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_sel)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(509, 123);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(428, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "еда, кг";
            // 
            // foodWeight_sel
            // 
            this.foodWeight_sel.DecimalPlaces = 2;
            this.foodWeight_sel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodWeight_sel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.foodWeight_sel.Location = new System.Drawing.Point(428, 203);
            this.foodWeight_sel.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.foodWeight_sel.Name = "foodWeight_sel";
            this.foodWeight_sel.Size = new System.Drawing.Size(120, 29);
            this.foodWeight_sel.TabIndex = 17;
            this.foodWeight_sel.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(273, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "расчет веса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя, фамилия";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(273, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите фамилию и имя";
            this.textBox1.Size = new System.Drawing.Size(184, 29);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(273, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "вес, кг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "рост, см";
            // 
            // weight_sel
            // 
            this.weight_sel.DecimalPlaces = 2;
            this.weight_sel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight_sel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weight_sel.Location = new System.Drawing.Point(273, 261);
            this.weight_sel.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.weight_sel.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.weight_sel.Name = "weight_sel";
            this.weight_sel.Size = new System.Drawing.Size(120, 29);
            this.weight_sel.TabIndex = 11;
            this.weight_sel.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // height_sel
            // 
            this.height_sel.DecimalPlaces = 2;
            this.height_sel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height_sel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.height_sel.Location = new System.Drawing.Point(273, 203);
            this.height_sel.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.height_sel.Minimum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.height_sel.Name = "height_sel";
            this.height_sel.Size = new System.Drawing.Size(120, 29);
            this.height_sel.TabIndex = 10;
            this.height_sel.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foodWeight_sel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight_sel);
            this.Controls.Add(this.height_sel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.foodWeight_sel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_sel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_sel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown foodWeight_sel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown weight_sel;
        private System.Windows.Forms.NumericUpDown height_sel;
    }
}

