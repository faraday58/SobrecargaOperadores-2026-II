namespace SobrecargaOperadores_2026_II
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
            this.txtbOperando1 = new TextBox();
            label1 = new Label();
            this.txtbOperando2 = new TextBox();
            label2 = new Label();
            this.lbResultado = new Label();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // txtbOperando1
            // 
            this.txtbOperando1.Location = new Point(95, 188);
            this.txtbOperando1.Name = "txtbOperando1";
            this.txtbOperando1.Size = new Size(170, 31);
            this.txtbOperando1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 194);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 1;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtbOperando2
            // 
            this.txtbOperando2.Location = new Point(434, 188);
            this.txtbOperando2.Name = "txtbOperando2";
            this.txtbOperando2.Size = new Size(170, 31);
            this.txtbOperando2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(645, 194);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 1;
            label2.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new Point(750, 194);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new Size(48, 25);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "1+1j";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(932, 188);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(177, 54);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 360);
            Controls.Add(btnSumar);
            Controls.Add(this.lbResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(this.txtbOperando2);
            Controls.Add(this.txtbOperando1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btnSumar;
    }
}
