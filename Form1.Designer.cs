namespace TempConversionWindowsForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_K = new System.Windows.Forms.RadioButton();
            this.radio_C = new System.Windows.Forms.RadioButton();
            this.radio_F = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.radio_toK = new System.Windows.Forms.RadioButton();
            this.radio_toC = new System.Windows.Forms.RadioButton();
            this.radio_toF = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_K);
            this.groupBox1.Controls.Add(this.radio_C);
            this.groupBox1.Controls.Add(this.radio_F);
            this.groupBox1.Location = new System.Drawing.Point(45, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base Temp Scale";
            // 
            // radio_K
            // 
            this.radio_K.AutoSize = true;
            this.radio_K.Location = new System.Drawing.Point(22, 152);
            this.radio_K.Name = "radio_K";
            this.radio_K.Size = new System.Drawing.Size(110, 36);
            this.radio_K.TabIndex = 2;
            this.radio_K.Text = "Kelvin";
            this.radio_K.UseVisualStyleBackColor = true;
            // 
            // radio_C
            // 
            this.radio_C.AutoSize = true;
            this.radio_C.Location = new System.Drawing.Point(22, 94);
            this.radio_C.Name = "radio_C";
            this.radio_C.Size = new System.Drawing.Size(119, 36);
            this.radio_C.TabIndex = 1;
            this.radio_C.Text = "Celsius";
            this.radio_C.UseVisualStyleBackColor = true;
            // 
            // radio_F
            // 
            this.radio_F.AutoSize = true;
            this.radio_F.Checked = true;
            this.radio_F.Location = new System.Drawing.Point(22, 39);
            this.radio_F.Name = "radio_F";
            this.radio_F.Size = new System.Drawing.Size(186, 36);
            this.radio_F.TabIndex = 0;
            this.radio_F.TabStop = true;
            this.radio_F.Text = "Fahrenheight";
            this.radio_F.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature:";
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(215, 264);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(200, 39);
            this.txt_temp.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(67, 346);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(150, 46);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer:";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(363, 346);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(27, 32);
            this.label_answer.TabIndex = 5;
            this.label_answer.Text = "0";
            // 
            // radio_toK
            // 
            this.radio_toK.AutoSize = true;
            this.radio_toK.Location = new System.Drawing.Point(22, 152);
            this.radio_toK.Name = "radio_toK";
            this.radio_toK.Size = new System.Drawing.Size(110, 36);
            this.radio_toK.TabIndex = 2;
            this.radio_toK.Text = "Kelvin";
            this.radio_toK.UseVisualStyleBackColor = true;
            // 
            // radio_toC
            // 
            this.radio_toC.AutoSize = true;
            this.radio_toC.Location = new System.Drawing.Point(22, 94);
            this.radio_toC.Name = "radio_toC";
            this.radio_toC.Size = new System.Drawing.Size(119, 36);
            this.radio_toC.TabIndex = 1;
            this.radio_toC.Text = "Celsius";
            this.radio_toC.UseVisualStyleBackColor = true;
            // 
            // radio_toF
            // 
            this.radio_toF.AutoSize = true;
            this.radio_toF.Checked = true;
            this.radio_toF.Location = new System.Drawing.Point(22, 39);
            this.radio_toF.Name = "radio_toF";
            this.radio_toF.Size = new System.Drawing.Size(186, 36);
            this.radio_toF.TabIndex = 0;
            this.radio_toF.TabStop = true;
            this.radio_toF.Text = "Fahrenheight";
            this.radio_toF.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_toK);
            this.groupBox2.Controls.Add(this.radio_toC);
            this.groupBox2.Controls.Add(this.radio_toF);
            this.groupBox2.Location = new System.Drawing.Point(285, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Temp Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_K;
        private System.Windows.Forms.RadioButton radio_C;
        private System.Windows.Forms.RadioButton radio_F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.RadioButton radio_toK;
        private System.Windows.Forms.RadioButton radio_toC;
        private System.Windows.Forms.RadioButton radio_toF;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

