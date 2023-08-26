namespace Pokedex
{
    partial class frmAltaPokemon
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNumero = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label4 = new Label();
            cboTipo = new ComboBox();
            cboDebilidad = new ComboBox();
            label5 = new Label();
            txtImagen = new TextBox();
            label6 = new Label();
            pbxPokemon = new PictureBox();
            btnAgregaImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 123);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 126);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 16;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 78);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(164, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Número:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(347, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(188, 316);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 205);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 23;
            label4.Text = "Tipo:";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(164, 205);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(125, 28);
            cboTipo.TabIndex = 4;
            // 
            // cboDebilidad
            // 
            cboDebilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDebilidad.FormattingEnabled = true;
            cboDebilidad.Location = new Point(164, 256);
            cboDebilidad.Name = "cboDebilidad";
            cboDebilidad.Size = new Size(125, 28);
            cboDebilidad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 259);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 25;
            label5.Text = "Debilidad:";
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(164, 165);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(125, 27);
            txtImagen.TabIndex = 3;
            txtImagen.TextChanged += txtImagen_TextChanged;
            txtImagen.Leave += txtImagen_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 165);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 27;
            label6.Text = "Imagen:";
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(347, 36);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(276, 248);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 28;
            pbxPokemon.TabStop = false;
            // 
            // btnAgregaImagen
            // 
            btnAgregaImagen.Location = new Point(295, 164);
            btnAgregaImagen.Name = "btnAgregaImagen";
            btnAgregaImagen.Size = new Size(46, 29);
            btnAgregaImagen.TabIndex = 29;
            btnAgregaImagen.Text = "+";
            btnAgregaImagen.UseVisualStyleBackColor = true;
            btnAgregaImagen.Click += btnAgregaImagen_Click;
            // 
            // frmAltaPokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 371);
            Controls.Add(btnAgregaImagen);
            Controls.Add(pbxPokemon);
            Controls.Add(txtImagen);
            Controls.Add(label6);
            Controls.Add(cboDebilidad);
            Controls.Add(label5);
            Controls.Add(cboTipo);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "frmAltaPokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Pokemon";
            Load += frmAltaPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label2;
        private TextBox txtNumero;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label4;
        private ComboBox cboTipo;
        private ComboBox cboDebilidad;
        private Label label5;
        private TextBox txtImagen;
        private Label label6;
        private PictureBox pbxPokemon;
        private Button btnAgregaImagen;
    }
}