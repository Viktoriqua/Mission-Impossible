using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mision_Impossible
{
    public partial class Kinopoisk : Form
    {
        private Search search = new Search();
        public Kinopoisk()
        {
            InitializeComponent();
            AddOwnedForm(search);
            
        }

        private void FindFilm_Click(object sender, EventArgs e)
        {
            if (search.Visible == true)
            {
                search.TopMost = true;

            }
            else
            {
                search.Show(this);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kinopoisk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = DialogResult.Yes != MessageBox.Show("Вы действительно хотите выйти ?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Kinopoisk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmsDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.filmsDataSet.Film);

        }
    }
}
