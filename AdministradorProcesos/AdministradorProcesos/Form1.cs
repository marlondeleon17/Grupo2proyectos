using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AdministradorProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }









        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProcesos();
        }


        private void CargarProcesos()
        {
            dgvProcesos.Rows.Clear();

            Process[] procesos = Process.GetProcesses();

            double memoriaTotalMB = 0;

            foreach (Process proceso in procesos)
            {
                try
                {
                    double memoriaMB =
                        proceso.WorkingSet64 / (1024.0 * 1024.0);

                    memoriaTotalMB += memoriaMB;

                    dgvProcesos.Rows.Add(
                        proceso.Id,
                        proceso.ProcessName,
                        memoriaMB.ToString("F2") + " MB",
                        "Ejecutando"
                    );
                }
                catch
                {
                    // Algunos procesos pueden no permitir
                    // consultar toda su información.
                }
            }

            // Cantidad de procesos
            lblCantidad.Text =
                "Procesos encontrados: " +
                dgvProcesos.Rows.Count;

            // Memoria total
            if (memoriaTotalMB >= 1024)
            {
                double memoriaGB = memoriaTotalMB / 1024;

                lblMemoriaTotal.Text =
                    "Memoria utilizada: " +
                    memoriaGB.ToString("F2") +
                    " GB";
            }
            else
            {
                lblMemoriaTotal.Text =
                    "Memoria utilizada: " +
                    memoriaTotalMB.ToString("F2") +
                    " MB";
            }

            // Fecha y hora
            lblUltimaActualizacion.Text =
                "Última actualización: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProcesos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            dgvProcesos.Rows.Clear();

            Process[] procesos = Process.GetProcesses();

            foreach (Process proceso in procesos)
            {
                try
                {
                    if (proceso.ProcessName.ToLower().Contains(texto))
                    {
                        double memoriaMB =
                            proceso.WorkingSet64 / (1024.0 * 1024.0);

                        dgvProcesos.Rows.Add(
                            proceso.Id,
                            proceso.ProcessName,
                            memoriaMB.ToString("F2") + " MB",
                            "Ejecutando"
                        );
                    }
                }
                catch
                {
                    // Ignorar procesos que no permitan consultar información.
                }
            }

            lblCantidad.Text = "Procesos encontrados: " +
                               dgvProcesos.Rows.Count;
        }




        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvProcesos.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un proceso.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int pid = Convert.ToInt32(
                dgvProcesos.SelectedRows[0].Cells["colPID"].Value);

            try
            {
                Process proceso = Process.GetProcessById(pid);

                double memoriaMB =
                    proceso.WorkingSet64 / (1024.0 * 1024.0);

                string mensaje =
                    "PID: " + proceso.Id + Environment.NewLine +
                    "Nombre: " + proceso.ProcessName + Environment.NewLine +
                    "Memoria: " + memoriaMB.ToString("F2") + " MB";

                MessageBox.Show(
                    mensaje,
                    "Detalles del proceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible obtener la información del proceso.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvProcesos.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un proceso.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int pid = Convert.ToInt32(
                dgvProcesos.SelectedRows[0].Cells["colPID"].Value);

            string nombre = dgvProcesos.SelectedRows[0]
                .Cells["colNombre"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Desea finalizar el proceso seleccionado?\n\n" +
                "Proceso: " + nombre + "\n" +
                "PID: " + pid,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Process proceso = Process.GetProcessById(pid);

                proceso.Kill();

                MessageBox.Show(
                    "El proceso fue finalizado.",
                    "Administrador de procesos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProcesos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo finalizar el proceso.\n\n" +
                    "Es posible que Windows requiera permisos " +
                    "o que el proceso ya haya terminado.\n\n" +
                    ex.Message,
                    "No se pudo completar la operación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarProcesos();
        }
    }

}
