namespace CALCULADORA_C_
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
            tbDisplay = new TextBox();
            btnN8 = new Button();
            btnN7 = new Button();
            btnN9 = new Button();
            btnN4 = new Button();
            btnN5 = new Button();
            btnN6 = new Button();
            btnN1 = new Button();
            btnN2 = new Button();
            btnN3 = new Button();
            button10 = new Button();
            signoIgual = new Button();
            division = new Button();
            suma = new Button();
            resta = new Button();
            multiplicacion = new Button();
            btnBorrar = new Button();
            btnPunto = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(12, 24);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(263, 40);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnN8
            // 
            btnN8.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN8.Location = new Point(84, 79);
            btnN8.Name = "btnN8";
            btnN8.Size = new Size(66, 48);
            btnN8.TabIndex = 1;
            btnN8.Text = "8";
            btnN8.UseVisualStyleBackColor = true;
            btnN8.Click += button1_Click;
            // 
            // btnN7
            // 
            btnN7.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN7.Location = new Point(12, 79);
            btnN7.Name = "btnN7";
            btnN7.Size = new Size(66, 48);
            btnN7.TabIndex = 2;
            btnN7.Text = "7";
            btnN7.UseVisualStyleBackColor = true;
            btnN7.Click += button2_Click;
            // 
            // btnN9
            // 
            btnN9.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN9.Location = new Point(156, 78);
            btnN9.Name = "btnN9";
            btnN9.Size = new Size(66, 49);
            btnN9.TabIndex = 3;
            btnN9.Text = "9";
            btnN9.UseVisualStyleBackColor = true;
            btnN9.Click += button3_Click;
            // 
            // btnN4
            // 
            btnN4.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN4.Location = new Point(12, 131);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(66, 48);
            btnN4.TabIndex = 4;
            btnN4.Text = "4";
            btnN4.UseVisualStyleBackColor = true;
            btnN4.Click += button4_Click;
            // 
            // btnN5
            // 
            btnN5.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN5.Location = new Point(84, 131);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(66, 48);
            btnN5.TabIndex = 5;
            btnN5.Text = "5";
            btnN5.UseVisualStyleBackColor = true;
            btnN5.Click += button5_Click;
            // 
            // btnN6
            // 
            btnN6.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN6.Location = new Point(156, 131);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(66, 48);
            btnN6.TabIndex = 6;
            btnN6.Text = "6";
            btnN6.UseVisualStyleBackColor = true;
            btnN6.Click += button6_Click;
            // 
            // btnN1
            // 
            btnN1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN1.Location = new Point(12, 181);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(66, 48);
            btnN1.TabIndex = 7;
            btnN1.Text = "1";
            btnN1.UseVisualStyleBackColor = true;
            btnN1.Click += button7_Click;
            // 
            // btnN2
            // 
            btnN2.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN2.Location = new Point(84, 181);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(66, 48);
            btnN2.TabIndex = 8;
            btnN2.Text = "2";
            btnN2.UseVisualStyleBackColor = true;
            btnN2.Click += button8_Click;
            // 
            // btnN3
            // 
            btnN3.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnN3.Location = new Point(156, 181);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(66, 48);
            btnN3.TabIndex = 9;
            btnN3.Text = "3";
            btnN3.UseVisualStyleBackColor = true;
            btnN3.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(12, 235);
            button10.Name = "button10";
            button10.Size = new Size(66, 48);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // signoIgual
            // 
            signoIgual.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            signoIgual.Location = new Point(156, 235);
            signoIgual.Name = "signoIgual";
            signoIgual.Size = new Size(66, 48);
            signoIgual.TabIndex = 11;
            signoIgual.Text = "=";
            signoIgual.UseVisualStyleBackColor = true;
            signoIgual.Click += button11_Click;
            // 
            // division
            // 
            division.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            division.Location = new Point(228, 235);
            division.Name = "division";
            division.Size = new Size(47, 48);
            division.TabIndex = 12;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += button12_Click;
            // 
            // suma
            // 
            suma.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            suma.Location = new Point(228, 78);
            suma.Name = "suma";
            suma.Size = new Size(47, 48);
            suma.TabIndex = 13;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = true;
            suma.Click += button13_Click;
            // 
            // resta
            // 
            resta.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            resta.Location = new Point(228, 131);
            resta.Name = "resta";
            resta.Size = new Size(47, 48);
            resta.TabIndex = 14;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = true;
            resta.Click += button14_Click;
            // 
            // multiplicacion
            // 
            multiplicacion.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicacion.Location = new Point(228, 181);
            multiplicacion.Name = "multiplicacion";
            multiplicacion.Size = new Size(47, 48);
            multiplicacion.TabIndex = 15;
            multiplicacion.Text = "x";
            multiplicacion.UseVisualStyleBackColor = true;
            multiplicacion.Click += button15_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(12, 318);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(263, 26);
            btnBorrar.TabIndex = 16;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += button16_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(84, 235);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(66, 48);
            btnPunto.TabIndex = 17;
            btnPunto.Text = ".";
            btnPunto.TextAlign = ContentAlignment.TopCenter;
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += button17_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(13, 286);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(263, 26);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 357);
            Controls.Add(btnLimpiar);
            Controls.Add(btnPunto);
            Controls.Add(btnBorrar);
            Controls.Add(multiplicacion);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(division);
            Controls.Add(signoIgual);
            Controls.Add(button10);
            Controls.Add(btnN3);
            Controls.Add(btnN2);
            Controls.Add(btnN1);
            Controls.Add(btnN6);
            Controls.Add(btnN5);
            Controls.Add(btnN4);
            Controls.Add(btnN9);
            Controls.Add(btnN7);
            Controls.Add(btnN8);
            Controls.Add(tbDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button btnN8;
        private Button btnN7;
        private Button btnN9;
        private Button btnN4;
        private Button btnN5;
        private Button btnN6;
        private Button btnN1;
        private Button btnN2;
        private Button btnN3;
        private Button button10;
        private Button signoIgual;
        private Button division;
        private Button suma;
        private Button resta;
        private Button multiplicacion;
        private Button btnBorrar;
        private Button btnPunto;
        private Button btnLimpiar;
    }
}