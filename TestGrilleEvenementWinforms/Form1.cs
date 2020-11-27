using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGrilleEvenement.Data;

namespace TestGrilleEvenementWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Evenement> items = await Task.Run(() => EvenementService.FakeEvements(100).ToList());

            //MessageBox.Show($"affichage de {items.Count} évènements");

            evenementBindingSource.SuspendBinding();
            foreach (Evenement evenement in items)
            {
                evenementBindingSource.Add(evenement);
            }

            evenementBindingSource.ResumeBinding();
        }

        private void ultraGrid1_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            if (e.Row.ListObject is IEvenement rowListObject)
            {
                e.Row.Appearance.BackColor = rowListObject.Color;
            }
        }
    }
}
