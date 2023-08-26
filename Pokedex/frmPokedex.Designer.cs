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
            btnEliminarLogico = new Button();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            btnBuscar = new Button();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblFiltroAvanzado = new Label();
            cboCampo = new ComboBox();
            cboCriterio = new ComboBox();
            txtFiltroAvanzado = new TextBox();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPokemon.Location = new Point(11, 52);
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
            pbxPokemon.Location = new Point(833, 52);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(325, 347);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(43, 429);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(152, 429);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(264, 429);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(150, 29);
            btnEliminarFisico.TabIndex = 4;
            btnEliminarFisico.Text = "Eliminación Física";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Location = new Point(437, 429);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new Size(150, 29);
            btnEliminarLogico.TabIndex = 5;
            btnEliminarLogico.Text = "Eliminación Lógica";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(11, 15);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(98, 20);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtro Rápido:";
            lblFiltro.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(117, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(202, 27);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(719, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(14, 485);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(60, 20);
            lblCampo.TabIndex = 8;
            lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(227, 485);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(61, 20);
            lblCriterio.TabIndex = 9;
            lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            lblFiltroAvanzado.AutoSize = true;
            lblFiltroAvanzado.Location = new Point(467, 485);
            lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            lblFiltroAvanzado.Size = new Size(46, 20);
            lblFiltroAvanzado.TabIndex = 10;
            lblFiltroAvanzado.Text = "Filtro:";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(77, 479);
            cboCampo.Margin = new Padding(3, 4, 3, 4);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(138, 28);
            cboCampo.TabIndex = 11;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(290, 479);
            cboCriterio.Margin = new Padding(3, 4, 3, 4);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(138, 28);
            cboCriterio.TabIndex = 12;
            // 
            // txtFiltroAvanzado
            // 
            txtFiltroAvanzado.Location = new Point(517, 479);
            txtFiltroAvanzado.Margin = new Padding(3, 4, 3, 4);
            txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            txtFiltroAvanzado.Size = new Size(114, 27);
            txtFiltroAvanzado.TabIndex = 13;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(659, 476);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 31);
            btnFiltrar.TabIndex = 14;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // frmPokedex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 525);
            Controls.Add(btnFiltrar);
            Controls.Add(txtFiltroAvanzado);
            Controls.Add(cboCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblFiltroAvanzado);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnEliminarLogico);
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
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPokemon;
        private PictureBox pbxPokemon;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminarFisico;
        private Button btnEliminarLogico;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Button btnBuscar;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltroAvanzado;
        private ComboBox cboCampo;
        private ComboBox cboCriterio;
        private TextBox txtFiltroAvanzado;
        private Button btnFiltrar;
    }
}