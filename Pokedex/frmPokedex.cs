namespace Pokedex
{
    public partial class frmPokedex : Form
    {
        public frmPokedex()
        {
            InitializeComponent();
        }

        private void frmPokedex_Load(object sender, EventArgs e)
        {
            PokemonDatos datos = new PokemonDatos();
            dgvPokemon.DataSource = datos.Listar();
        }
    }
}