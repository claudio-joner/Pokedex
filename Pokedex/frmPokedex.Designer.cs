namespace Pokedex
{
    partial class frmPokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokedex));
            dgvPokemon = new DataGridView();
            pbxPokemon = new PictureBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminarFisico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPokemon.Location = new Point(12, 52);
            dgvPokemon.MultiSelect = false;
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.RowTemplate.Height = 29;
            dgvPokemon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPokemon.Size = new Size(801, 347);
            dgvPokemon.TabIndex = 0;
            dgvPokemon.CellContentClick += dgvPokemon_CellContentClick;
            dgvPokemon.SelectionChanged += dgvPokemon_SelectionChanged;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(847, 52);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(324, 347);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(43, 430);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(152, 430);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(264, 430);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(94, 29);
            btnEliminarFisico.TabIndex = 4;
            btnEliminarFisico.Text = "Eliminar";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // frmPokedex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 480);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(pbxPokemon);
            Controls.Add(dgvPokemon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPokedex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokedex";
            Load += frmPokedex_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemon;
        private PictureBox pbxPokemon;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminarFisico;
    }
}