using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            GenerateArray((int)arraySize.Value);
            initialList.DataSource = _array;
        }

        private void sortBubble_Click(object sender, EventArgs e)
        {
            _array.CopyTo(_sorted, 0);
            Enabled = false;
            SortBubble(_sorted);
            sortedList.DataSource = null;
            sortedList.DataSource = _sorted;
            Enabled = true;
        }

        private void sortSelection_Click(object sender, EventArgs e)
        {
            _array.CopyTo(_sorted, 0);
            Enabled = false;
            SortSelection(_sorted);
            sortedList.DataSource = null;
            sortedList.DataSource = _sorted;
            Enabled = true;
        }

        private void sortParallel_Click(object sender, EventArgs e)
        {
            _array.CopyTo(_parallelSorted, 0);
            Enabled = false;
            SortParallel();
            parallelSortedList.DataSource = null;
            parallelSortedList.DataSource = _parallelSorted;
            Enabled = true;
        }

        private void sortDecreasing_Click(object sender, EventArgs e)
        {
            _array.CopyTo(_sorted, 0);
            Enabled = false;
            SortBubble(_sorted, false);
            sortedList.DataSource = null;
            sortedList.DataSource = _sorted;
            Enabled = true;
        }

        private void sortIncDec_Click(object sender, EventArgs e)
        {
            _array.CopyTo(_parallelSorted, 0);
            Enabled = false;
            SortIncDec();
            parallelSortedList.DataSource = null;
            parallelSortedList.DataSource = _parallelSorted;
            Enabled = true;
        }
    }
}
