using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace TestGrilleEvenementWinforms
{
    public class MultipleBandSelectionUltraGrid : UltraGrid
    {
        private readonly HashSet<UltraGridRow> _selectedRows = new HashSet<UltraGridRow>();

        protected override void OnAfterSelectChange(AfterSelectChangeEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == 0)
            {
                _selectedRows.Clear();
            }

            foreach (UltraGridRow row in Selected.Rows)
            {
                if (!_selectedRows.Contains(row))
                {
                    _selectedRows.Add(row);
                }
            }

            base.OnAfterSelectChange(e);
        }

        protected override void OnClickCell(ClickCellEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) != 0)
            {
                _selectedRows.Add(e.Cell.Row);
                RedrawSelectedRow(null, null);
            }

            base.OnClickCell(e);
        }

        private void RedrawSelectedRow(object sender, RunWorkerCompletedEventArgs e)
        {
            Selected.Rows.Clear();
            foreach (IGrouping<UltraGridBand, UltraGridRow> grouping in _selectedRows.GroupBy(r => r.Band))
            {
                Selected.Rows.AddRange(grouping.ToArray());
            }
        }
    }
}