namespace SistemaEscolar.Tools
{
    partial class CasaDeCambioForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.PrimerValorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsdToDopLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EurToDopLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DopToUsdLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Casa de Cambio";
            // 
            // PrimerValorTextBox
            // 
            this.PrimerValorTextBox.Location = new System.Drawing.Point(84, 121);
            this.PrimerValorTextBox.Name = "PrimerValorTextBox";
            this.PrimerValorTextBox.Size = new System.Drawing.Size(153, 20);
            this.PrimerValorTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad de moneda";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(84, 213);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(153, 20);
            this.ResultadoTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DopToUsdLinkLabel);
            this.groupBox1.Controls.Add(this.EurToDopLinkLabel);
            this.groupBox1.Controls.Add(this.UsdToDopLinkLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(418, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 202);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escoja una opcion";
            // 
            // UsdToDopLinkLabel
            // 
            this.UsdToDopLinkLabel.AutoSize = true;
            this.UsdToDopLinkLabel.Location = new System.Drawing.Point(6, 41);
            this.UsdToDopLinkLabel.Name = "UsdToDopLinkLabel";
            this.UsdToDopLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.UsdToDopLinkLabel.TabIndex = 0;
            this.UsdToDopLinkLabel.TabStop = true;
            this.UsdToDopLinkLabel.Text = "USD a DOP";
            this.UsdToDopLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UsdToDopLinkLabel_LinkClicked);
            // 
            // EurToDopLinkLabel
            // 
            this.EurToDopLinkLabel.AutoSize = true;
            this.EurToDopLinkLabel.Location = new System.Drawing.Point(80, 93);
            this.EurToDopLinkLabel.Name = "EurToDopLinkLabel";
            this.EurToDopLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.EurToDopLinkLabel.TabIndex = 1;
            this.EurToDopLinkLabel.TabStop = true;
            this.EurToDopLinkLabel.Text = "EUR a DOP";
            this.EurToDopLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EurToDopLinkLabel_LinkClicked);
            // 
            // DopToUsdLinkLabel
            // 
            this.DopToUsdLinkLabel.AutoSize = true;
            this.DopToUsdLinkLabel.Location = new System.Drawing.Point(153, 154);
            this.DopToUsdLinkLabel.Name = "DopToUsdLinkLabel";
            this.DopToUsdLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.DopToUsdLinkLabel.TabIndex = 2;
            this.DopToUsdLinkLabel.TabStop = true;
            this.DopToUsdLinkLabel.Text = "DOP a USD";
            this.DopToUsdLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DopToUsdLinkLabel_LinkClicked);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(418, 365);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(89, 43);
            this.CerrarButton.TabIndex = 25;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(571, 365);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 43);
            this.NuevoButton.TabIndex = 26;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CasaDeCambioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrimerValorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CasaDeCambioForm";
            this.Text = "Casa de Cambio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrimerValorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel DopToUsdLinkLabel;
        private System.Windows.Forms.LinkLabel EurToDopLinkLabel;
        private System.Windows.Forms.LinkLabel UsdToDopLinkLabel;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}