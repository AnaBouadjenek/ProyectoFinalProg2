namespace SistemaEscolar.Tools
{
    partial class LaSumadoraForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.PrimerValorTextBox = new System.Windows.Forms.TextBox();
            this.SegundoValorTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DividirButton = new System.Windows.Forms.Button();
            this.RestaButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo valor";
            // 
            // PrimerValorTextBox
            // 
            this.PrimerValorTextBox.Location = new System.Drawing.Point(184, 100);
            this.PrimerValorTextBox.Name = "PrimerValorTextBox";
            this.PrimerValorTextBox.Size = new System.Drawing.Size(139, 20);
            this.PrimerValorTextBox.TabIndex = 4;
            // 
            // SegundoValorTextBox
            // 
            this.SegundoValorTextBox.Location = new System.Drawing.Point(184, 154);
            this.SegundoValorTextBox.Name = "SegundoValorTextBox";
            this.SegundoValorTextBox.Size = new System.Drawing.Size(139, 20);
            this.SegundoValorTextBox.TabIndex = 5;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(184, 207);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(139, 20);
            this.ResultadoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // SumaButton
            // 
            this.SumaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumaButton.Location = new System.Drawing.Point(546, 79);
            this.SumaButton.Name = "SumaButton";
            this.SumaButton.Size = new System.Drawing.Size(110, 39);
            this.SumaButton.TabIndex = 8;
            this.SumaButton.Text = "Sumar";
            this.SumaButton.UseVisualStyleBackColor = true;
            this.SumaButton.Click += new System.EventHandler(this.SumaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "La Sumadora";
            // 
            // DividirButton
            // 
            this.DividirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividirButton.Location = new System.Drawing.Point(546, 214);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(110, 39);
            this.DividirButton.TabIndex = 10;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // RestaButton
            // 
            this.RestaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaButton.Location = new System.Drawing.Point(546, 124);
            this.RestaButton.Name = "RestaButton";
            this.RestaButton.Size = new System.Drawing.Size(110, 39);
            this.RestaButton.TabIndex = 11;
            this.RestaButton.Text = "Restar";
            this.RestaButton.UseVisualStyleBackColor = true;
            this.RestaButton.Click += new System.EventHandler(this.RestaButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicarButton.Location = new System.Drawing.Point(546, 169);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(113, 39);
            this.MultiplicarButton.TabIndex = 12;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(546, 372);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(110, 39);
            this.CerrarButton.TabIndex = 13;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // LaSumadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestaButton);
            this.Controls.Add(this.DividirButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SumaButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegundoValorTextBox);
            this.Controls.Add(this.PrimerValorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LaSumadoraForm";
            this.Text = "La Sumadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimerValorTextBox;
        private System.Windows.Forms.TextBox SegundoValorTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SumaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.Button RestaButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}