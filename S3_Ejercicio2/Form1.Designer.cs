namespace S3_Ejercicio2
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
            button1 = new Button();
            txtCat = new TextBox();
            txtDias = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 53);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Categoría del hotel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 109);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 1;
            label2.Text = "Días de estadía:";
            // 
            // button1
            // 
            button1.Location = new Point(207, 158);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 2;
            button1.Text = "Calcular costo del hospedaje + desayuno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCat
            // 
            txtCat.Location = new Point(230, 55);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(100, 23);
            txtCat.TabIndex = 3;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(230, 111);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 252);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 5;
            label3.Text = "Costo del hospedaje:";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(230, 254);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtDias);
            Controls.Add(txtCat);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txtCat;
        private TextBox txtDias;
        private Label label3;
        private TextBox txtCosto;
    }
}