namespace PractiaFiguraHerencia
{
    partial class Form1
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
            this.figurebox = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.value1lbl = new System.Windows.Forms.Label();
            this.value2lbl = new System.Windows.Forms.Label();
            this.value1box = new System.Windows.Forms.TextBox();
            this.value2box = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.figuralbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona una figura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // figurebox
            // 
            this.figurebox.FormattingEnabled = true;
            this.figurebox.Items.AddRange(new object[] {
            "Triángulo",
            "Rectángulo",
            "Círculo"});
            this.figurebox.Location = new System.Drawing.Point(146, 26);
            this.figurebox.Name = "figurebox";
            this.figurebox.Size = new System.Drawing.Size(121, 21);
            this.figurebox.TabIndex = 1;
            this.figurebox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(61, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(273, 24);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // value1lbl
            // 
            this.value1lbl.AutoSize = true;
            this.value1lbl.Location = new System.Drawing.Point(15, 82);
            this.value1lbl.Name = "value1lbl";
            this.value1lbl.Size = new System.Drawing.Size(40, 13);
            this.value1lbl.TabIndex = 4;
            this.value1lbl.Text = "Value1";
            this.value1lbl.Visible = false;
            // 
            // value2lbl
            // 
            this.value2lbl.AutoSize = true;
            this.value2lbl.Location = new System.Drawing.Point(15, 122);
            this.value2lbl.Name = "value2lbl";
            this.value2lbl.Size = new System.Drawing.Size(40, 13);
            this.value2lbl.TabIndex = 5;
            this.value2lbl.Text = "Value2";
            this.value2lbl.Visible = false;
            // 
            // value1box
            // 
            this.value1box.Location = new System.Drawing.Point(61, 79);
            this.value1box.Name = "value1box";
            this.value1box.Size = new System.Drawing.Size(214, 20);
            this.value1box.TabIndex = 6;
            this.value1box.Visible = false;
            // 
            // value2box
            // 
            this.value2box.Location = new System.Drawing.Point(61, 119);
            this.value2box.Name = "value2box";
            this.value2box.Size = new System.Drawing.Size(214, 20);
            this.value2box.TabIndex = 7;
            this.value2box.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(200, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(58, 196);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(35, 13);
            this.resultlbl.TabIndex = 9;
            this.resultlbl.Text = "label2";
            this.resultlbl.Visible = false;
            // 
            // figuralbl
            // 
            this.figuralbl.AutoSize = true;
            this.figuralbl.Location = new System.Drawing.Point(146, 60);
            this.figuralbl.Name = "figuralbl";
            this.figuralbl.Size = new System.Drawing.Size(36, 13);
            this.figuralbl.TabIndex = 10;
            this.figuralbl.Text = "Figura";
            this.figuralbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 236);
            this.Controls.Add(this.figuralbl);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.value2box);
            this.Controls.Add(this.value1box);
            this.Controls.Add(this.value2lbl);
            this.Controls.Add(this.value1lbl);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.figurebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox figurebox;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label value1lbl;
        private System.Windows.Forms.Label value2lbl;
        private System.Windows.Forms.TextBox value1box;
        private System.Windows.Forms.TextBox value2box;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label figuralbl;
    }
}

