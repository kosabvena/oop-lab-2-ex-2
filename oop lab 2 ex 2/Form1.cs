using System;
using System.Windows.Forms;

namespace oop_lab_2_ex_2
{
    public partial class frmMass : Form
    {
        public frmMass()
        {
            InitializeComponent();

            cmdStart.Click += cmdStart_Click;
            cmdClear.Click += cmdClear_Click;
            cmdExit.Click += cmdExit_Click;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            int n;
            int m;

            if (!int.TryParse(txtn.Text, out n) ||
                !int.TryParse(txtm.Text, out m))
            {
                MessageBox.Show(
                    "Введіть правильну кількість рядків та стовпців!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (n <= 0 || m <= 0)
            {
                MessageBox.Show(
                    "Кількість рядків та стовпців повинна бути більше 0!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int[,] A = new int[n, m];

            Random rnd = new Random();

            int nn = 0;

            float summ = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(-50, 50);
                }
            }

            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();

            dgvMass.ColumnCount = m;
            dgvMass.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dgvMass.Rows[i].Cells[j].Value = A[i, j];
                }
            }

            for (int j = 0; j < m; j++)
            {
                dgvMass.Columns[j].Width = 50;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] > 0)
                    {
                        summ += A[i, j];
                        nn++;
                    }
                }
            }

            if (nn > 0)
            {
                float sr = summ / nn;

                txtRez.Text =
                    "Середнє арифметичне = " +
                    Math.Round(sr, 5).ToString() +
                    Environment.NewLine +
                    "Кількість додатних елементів = " +
                    nn.ToString();
            }
            else
            {
                txtRez.Text = "Додатних елементів немає.";
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtn.Text = "";
            txtm.Text = "";
            txtRez.Text = "";

            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
