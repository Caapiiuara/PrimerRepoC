using Prueba1908.Algoritmos;

namespace Prueba1908
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Paso 0: Condici�n de vac�o
            if (textBox1.Text.Equals("") ||
                    textBox2.Text.Equals("") ||
                        textBox3.Text.Equals("") ||
                            textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            //Paso1: Inicializaci�n de par�metros
            int a = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            int m = Convert.ToInt32(textBox4.Text);
            int x0 = Convert.ToInt32(textBox3.Text);

            //Paso 1.2 condicion para x0
            if (a <= 0 || c <= 0 || x0 <= 0)
            {
                MessageBox.Show("Los valores a, c y x0 deben de ser mayores o iguales que CERO.");
                return;
            }
            if (m <= a || m <= c || m <= x0)
            {
                MessageBox.Show("m debe de ser mayor a todos los dem�s par�metros.");
                return;
            }
            //Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            //Paso 3: Llamar m�todo principal
            //List<int> listaEnteros = algoritmo.GeneradorCongruencialnoLineal(a, c, m, x0);
            List<int> listaEnteros = algoritmo.GeneradorCongruencial(a,c,m,x0);
            // Paso 4: Llenar el grid 
            llenarGrid(listaEnteros);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenarGrid(List<int> lista)
        {
            //Paso 0: Indicas el n�mero de columnas 
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            //Paso 1: Determinas la cantidad de columnas 
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");
            //Paso 2: Recorrer el grid para cada fila y llenar de valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }
        }
        public void DescargaExcel(DataGridView data)
        {
            //Paso 0: Instalar el complemento de excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            //Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            //Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            //Paso 3: visibilidad
            exportarExcel.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Paso 0: Condici�n de vac�o
            if (textBox1.Text.Equals("") ||
                    textBox2.Text.Equals("") ||
                        textBox3.Text.Equals("") ||
                            textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            //Paso1: Inicializaci�n de par�metros
            int a = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            int m = Convert.ToInt32(textBox4.Text);
            int x0 = Convert.ToInt32(textBox3.Text);

            //Paso 1.2 condicion para x0
            if (a <= 0 || c <= 0 || x0 <= 0)
            {
                MessageBox.Show("Los valores a, c, x0, n y x1 deben de ser mayores o iguales que CERO.");
                return;
            }
            if (m <= a || m <= c || m <= x0)
            {
                MessageBox.Show("m debe de ser mayor a todos los dem�s par�metros.");
                return;
            }
            //Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            //Paso 3: Llamar m�todo principal
            //List<int> listaEnteros = algoritmo.GeneradorCongruencialnoLineal(a, c, m, x0);
            List<int> listaEnteros = algoritmo.GeneradorCongruencialnoLineal(a,c,m,x0);
            // Paso 4: Llenar el grid 
            llenarGrid(listaEnteros);

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Paso 0: Condici�n de vac�o
            if (textBox3.Text.Equals("") ||
                                textBox5.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            //Paso1: Inicializaci�n de par�metros
            int x0 = Convert.ToInt32(textBox3.Text);
            int n = Convert.ToInt32(textBox5.Text);

            //Paso 1.2 condicion para x0
            if (x0 <= 0 || n <= 0)
            {
                MessageBox.Show("Los valores x0 y n deben de ser mayores o iguales que CERO.");
                return;
            }
            //Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            //Paso 3: Llamar m�todo principal
            //List<int> listaEnteros = algoritmo.GeneradorCongruencialnoLineal(a, c, m, x0);
            List<int> listaEnteros = algoritmo.GeneradorCuadradoMedio(n, x0);
            // Paso 4: Llenar el grid 
            llenarGrid(listaEnteros);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Paso 0: Condici�n de vac�o
            if (textBox3.Text.Equals("") ||
                                textBox5.Text.Equals("") ||
                                    textBox6.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            //Paso1: Inicializaci�n de par�metros
            int x0 = Convert.ToInt32(textBox3.Text);
            int n = Convert.ToInt32(textBox5.Text);
            int x1 = Convert.ToInt32(textBox6.Text);

            //Paso 1.2 condicion para x0
            if (x0 <= 0 || n <= 0 || x1 <= 0)
            {
                MessageBox.Show("Los valores x0, n y x1 deben de ser mayores o iguales que CERO.");
                return;
            }
            //Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            //Paso 3: Llamar m�todo principal
            //List<int> listaEnteros = algoritmo.GeneradorCongruencialnoLineal(a, c, m, x0);
            List<int> listaEnteros = algoritmo.GeneradorProductoMedio(n, x0, x1);
            // Paso 4: Llenar el grid 
            llenarGrid(listaEnteros);
        }
    }
}
