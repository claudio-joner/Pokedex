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
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.Location = new Point(58, 52);
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.RowTemplate.Height = 29;
            dgvPokemon.Size = new Size(620, 347);
            dgvPokemon.TabIndex = 0;
            // 
            // frmPokedex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPokemon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPokedex";
            Text = "Pokedex";
            Load += frmPokedex_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemon;
    }
}