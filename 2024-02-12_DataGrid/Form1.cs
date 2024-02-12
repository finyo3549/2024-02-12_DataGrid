namespace _2024_02_12_DataGrid
{
    public partial class Form1 : Form
    {
        Adatbazis db = new Adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Mertekegyseg.Text = "km\x00B2";
            AdattablaBeallitasa();
            AdattablaFrissitese();
        }

        private void AdattablaBeallitasa()
        {
            dataGridView_Adatok.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Italic);
            dataGridView_Adatok.SelectionMode=DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn column_kontinens = new DataGridViewColumn();
            {
                column_kontinens.Name ="Kontinens";
                column_kontinens.DataPropertyName = "kontinens";
                column_kontinens.CellTemplate = new DataGridViewTextBoxCell();
                }
            dataGridView_Adatok.Columns.Add(column_kontinens);
            DataGridViewColumn column_orszag = new DataGridViewColumn();
            {
                column_orszag.Name = "Ország Neve";
                column_orszag.DataPropertyName = "orszag";
                column_orszag.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_orszag);
            DataGridViewColumn column_fovaros = new DataGridViewColumn();
            {
                column_fovaros.Name = "Fõváros Neve";
                column_fovaros.DataPropertyName = "fovaros";
                column_fovaros.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_fovaros);
            DataGridViewColumn column_terulet = new DataGridViewColumn();
            {
                column_terulet.Name = "Terület";
                column_terulet.DataPropertyName = "terulet";
                column_terulet.ValueType = typeof(decimal);
                column_terulet.CellTemplate = new DataGridViewTextBoxCell();
                column_terulet.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dataGridView_Adatok.Columns.Add(column_terulet);
        }

        private void AdattablaFrissitese()
        {
            dataGridView_Adatok.Rows.Clear();
            foreach (Orszag orszag in db.orszagok())
            {
                int sorszam = dataGridView_Adatok.Rows.Add();
                DataGridViewRow sor = dataGridView_Adatok.Rows[sorszam];
                sor.Cells["Kontinens"].Value = orszag.Kontinens;
                sor.Cells["Ország Neve"].Value = orszag.Orszagnev;
                sor.Cells["Fõváros Neve"].Value = orszag.Fovaros;
                sor.Cells["Terület"].Value = orszag.Terulet;
            }
        }
    }
}
