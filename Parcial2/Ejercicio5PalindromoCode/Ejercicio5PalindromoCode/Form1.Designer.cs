namespace Ejercicio5PalindromoCode
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
            btnVerificar = new Button();
            txtPalabra = new TextBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(298, 210);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(287, 135);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(100, 23);
            txtPalabra.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(264, 74);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(259, 15);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Escribe la palabra para verificar si es palindromo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(txtPalabra);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox txtPalabra;
        private Label lblMensaje;
    }
}
