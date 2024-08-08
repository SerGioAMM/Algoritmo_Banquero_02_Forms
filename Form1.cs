namespace Algoritmo_Banquero_02_Forms
{
    public partial class Form1 : Form
    {
        readonly int recurso1 = 10;
        readonly int recurso2 = 25;
        readonly int recurso3 = 20;

        int acumulador1 = 0;
        int acumulador2 = 0;
        int acumulador3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Verificar si hay elementos en el ListView
            if (list_EstadoInicial.Items.Count > 0)
            {
                // Iterar sobre cada ListViewItem en el ListView
                foreach (ListViewItem item in list_EstadoInicial.Items)
                {

                    // Verificar que el item tenga al menos 2 subitems
                    if (item.SubItems.Count >= 3)
                    {
                        // Obtener los valores de los subitems
                        if (int.TryParse(item.SubItems[1].Text, out int valor1) && int.TryParse(item.SubItems[2].Text, out int valor2) && int.TryParse(item.SubItems[3].Text, out int valor3))
                        {
                            // Verificar que los valores estén dentro del rango permitido por las ProgressBars
                            if (valor1 >= PBar_Recurso1.Minimum && valor1 <= PBar_Recurso1.Maximum)
                            {
                                acumulador1 += valor1 * recurso1;

                            }
                            else
                            {
                                MessageBox.Show($"El valor {valor1} de la columna 2 está fuera del rango de la ProgressBar1.");
                            }

                            if (valor2 >= PBar_Recurso2.Minimum && valor2 <= PBar_Recurso2.Maximum)
                            {
                                acumulador2 += valor2 * recurso2;
                            }
                            else
                            {
                                MessageBox.Show($"El valor {valor2} de la columna 3 está fuera del rango de la ProgressBar2.");
                            }
                            if (valor3 >= PBar_Recurso3.Minimum && valor3 <= PBar_Recurso3.Maximum)
                            {
                                acumulador3 += valor3 * recurso3;
                            }
                            else
                            {
                                MessageBox.Show($"El valor {valor3} de la columna 4 está fuera del rango de la ProgressBar3.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los valores de los subítems no son números válidos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El item no tiene suficientes subítems.");
                    }

                }

                PBar_Recurso1.Value = Math.Min(PBar_Recurso1.Maximum, acumulador1);
                PBar_Recurso2.Value = Math.Min(PBar_Recurso2.Maximum, acumulador2);
                PBar_Recurso3.Value = Math.Min(PBar_Recurso3.Maximum, acumulador3);

                // Actualizar etiquetas con el progreso
                labelProgreso1.Text = $"{PBar_Recurso1.Value} / {PBar_Recurso1.Maximum}";
                labelProgreso2.Text = $"{PBar_Recurso2.Value} / {PBar_Recurso2.Maximum}";
                labelProgreso3.Text = $"{PBar_Recurso3.Value} / {PBar_Recurso3.Maximum}";

            }
            else
            {
                MessageBox.Show("El ListView no tiene elementos.");
            }


            button2.Enabled = false;


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void list_EstadoFinal_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            // Obtener el item que ha sido (des)seleccionado
            ListViewItem item = e.Item;


            // Verificar que el item tenga al menos 2 subitems
            if (item.SubItems.Count >= 4)
            {
                // Obtener los valores de los subitems
                if ((int.TryParse(item.SubItems[1].Text, out int valor1)) && (int.TryParse(item.SubItems[2].Text, out int valor2)) && (int.TryParse(item.SubItems[3].Text, out int valor3)))
                {

                    if ((((PBar_Recurso1.Value + (valor1 * recurso1)) > PBar_Recurso1.Maximum) || ((PBar_Recurso2.Value + (valor2 * recurso2)) > PBar_Recurso2.Maximum) || ((PBar_Recurso3.Value + (valor3 * recurso3)) > PBar_Recurso3.Maximum)))
                    {

                        if (item.Checked == true)
                        {
                            MessageBox.Show("El proceso excede la cantidad de recursos disponibles");
                        }
                        item.Checked = false;
                    }
                    else
                    {
                        // Si el item está seleccionado, sumar los valores a las ProgressBars
                        if (item.Checked)
                        {
                            UpdateProgressBar(PBar_Recurso1, valor1 * recurso1, true);
                            UpdateProgressBar(PBar_Recurso2, valor2 * recurso2, true);
                            UpdateProgressBar(PBar_Recurso3, valor3 * recurso3, true);
                        }
                        // Si el item ha sido deseleccionado, restar los valores de las ProgressBars
                        else
                        {
                            UpdateProgressBar(PBar_Recurso1, valor1 * recurso1, false);
                            UpdateProgressBar(PBar_Recurso2, valor2 * recurso2, false);
                            UpdateProgressBar(PBar_Recurso3, valor3 * recurso3, false);
                        }
                        // Actualizar etiquetas con el progreso
                        labelProgreso1.Text = $"{PBar_Recurso1.Value} / {PBar_Recurso1.Maximum}";
                        labelProgreso2.Text = $"{PBar_Recurso2.Value} / {PBar_Recurso2.Maximum}";
                        labelProgreso3.Text = $"{PBar_Recurso3.Value} / {PBar_Recurso3.Maximum}";
                    }
                }
                else
                {
                    MessageBox.Show("Los valores de los subítems no son números válidos.");
                }

            }
            else
            {
                MessageBox.Show("El item no tiene suficientes subítems.");
            }
        }



        private void UpdateProgressBar(ProgressBar progressBar, int value, bool isAdding)
        {
            // Obtener el valor actual de la ProgressBar
            int currentValue = progressBar.Value;

            // Calcular el nuevo valor
            int newValue = isAdding ? currentValue + value : currentValue - value;

            // Asegurarse de que el nuevo valor esté dentro del rango permitido
            progressBar.Value = Math.Max(progressBar.Minimum, Math.Min(progressBar.Maximum, newValue));
        }

        private void list_EstadoFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("SelectedIndex works");
        }

        private void list_EstadoFinal_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("MouseDown works");



        }

        private void list_EstadoFinal_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
