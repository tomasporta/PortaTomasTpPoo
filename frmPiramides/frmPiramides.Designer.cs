namespace frmPiramides
{
    partial class frmPiramides
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lblCantidad = new Label();
            btoOk = new Button();
            btnCancelar = new Button();
            lstPiramides = new ListBox();
            txtLado = new TextBox();
            txtAltura = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa Un Lado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa La Altura";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 421);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(107, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "CantidadPiramides";
            // 
            // btoOk
            // 
            btoOk.Location = new Point(67, 294);
            btoOk.Name = "btoOk";
            btoOk.Size = new Size(75, 23);
            btoOk.TabIndex = 3;
            btoOk.Text = "Ok";
            btoOk.UseVisualStyleBackColor = true;
            btoOk.Click += btoOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstPiramides
            // 
            lstPiramides.FormattingEnabled = true;
            lstPiramides.ItemHeight = 15;
            lstPiramides.Location = new Point(45, 138);
            lstPiramides.Name = "lstPiramides";
            lstPiramides.Size = new Size(251, 94);
            lstPiramides.TabIndex = 5;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(138, 23);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 6;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(138, 71);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAltura);
            Controls.Add(txtLado);
            Controls.Add(lstPiramides);
            Controls.Add(btnCancelar);
            Controls.Add(btoOk);
            Controls.Add(lblCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Piramides";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCantidad;
        private Button btoOk;
        private Button btnCancelar;
        private ListBox lstPiramides;
        private TextBox txtLado;
        private TextBox txtAltura;
        private ErrorProvider errorProvider1;
    }
}
