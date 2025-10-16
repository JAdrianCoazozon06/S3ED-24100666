namespace Ejercicio3o4ExpresionValidarCode
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
            txtExpresion = new TextBox();
            btnEvaluarExpresion = new Button();
            lblProposito = new Label();
            SuspendLayout();
            // 
            // txtExpresion
            // 
            txtExpresion.Location = new Point(370, 78);
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(100, 23);
            txtExpresion.TabIndex = 0;
            // 
            // btnEvaluarExpresion
            // 
            btnEvaluarExpresion.Location = new Point(411, 146);
            btnEvaluarExpresion.Name = "btnEvaluarExpresion";
            btnEvaluarExpresion.Size = new Size(75, 23);
            btnEvaluarExpresion.TabIndex = 1;
            btnEvaluarExpresion.Text = "Evaluar Expresion";
            btnEvaluarExpresion.UseVisualStyleBackColor = true;
            btnEvaluarExpresion.Click += btnEvaluarExpresion_Click;
            // 
            // lblProposito
            // 
            lblProposito.AutoSize = true;
            lblProposito.Location = new Point(144, 24);
            lblProposito.Name = "lblProposito";
            lblProposito.Size = new Size(559, 15);
            lblProposito.TabIndex = 2;
            lblProposito.Text = "Codigo para detectar si los parentesis, corchetes y llaves en una expresion matematica estan balanceados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProposito);
            Controls.Add(btnEvaluarExpresion);
            Controls.Add(txtExpresion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpresion;
        private Button btnEvaluarExpresion;
        private Label lblProposito;
    }
}
