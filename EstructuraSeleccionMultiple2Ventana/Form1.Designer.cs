namespace EstructuraSeleccionMultiple2Ventana
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
            label1 = new Label();
            label2 = new Label();
            txtcat = new TextBox();
            label3 = new Label();
            txtestadia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txttotal = new TextBox();
            txtdesayuno = new TextBox();
            txttotalneto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(184, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese que categoria desea: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(147, 57);
            label2.TabIndex = 1;
            label2.Text = "1: Categoria 3 estrellas\r\n\r\n2: Categoria 5 estrellas\r\n";
            // 
            // txtcat
            // 
            txtcat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcat.Location = new Point(252, 33);
            txtcat.Name = "txtcat";
            txtcat.Size = new Size(131, 26);
            txtcat.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(234, 19);
            label3.TabIndex = 3;
            label3.Text = "Ingrese los dias que desea la estadia: ";
            // 
            // txtestadia
            // 
            txtestadia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtestadia.Location = new Point(252, 139);
            txtestadia.Name = "txtestadia";
            txtestadia.Size = new Size(131, 26);
            txtestadia.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 216);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 5;
            label4.Text = "El total por su estadia es :\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 6;
            label5.Text = "Agregamos el desayuno :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 306);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 7;
            label6.Text = "Total a pagar : ";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(228, 213);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(131, 26);
            txttotal.TabIndex = 8;
            // 
            // txtdesayuno
            // 
            txtdesayuno.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdesayuno.Location = new Point(228, 256);
            txtdesayuno.Name = "txtdesayuno";
            txtdesayuno.Size = new Size(131, 26);
            txtdesayuno.TabIndex = 9;
            // 
            // txttotalneto
            // 
            txttotalneto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalneto.Location = new Point(228, 299);
            txttotalneto.Name = "txttotalneto";
            txttotalneto.Size = new Size(131, 26);
            txttotalneto.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(290, 356);
            button1.Name = "button1";
            button1.Size = new Size(93, 35);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 356);
            button2.Name = "button2";
            button2.Size = new Size(93, 35);
            button2.TabIndex = 12;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(153, 356);
            button3.Name = "button3";
            button3.Size = new Size(93, 35);
            button3.TabIndex = 13;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 414);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txttotalneto);
            Controls.Add(txtdesayuno);
            Controls.Add(txttotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtestadia);
            Controls.Add(label3);
            Controls.Add(txtcat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcat;
        private Label label3;
        private TextBox txtestadia;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txttotal;
        private TextBox txtdesayuno;
        private TextBox txttotalneto;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}