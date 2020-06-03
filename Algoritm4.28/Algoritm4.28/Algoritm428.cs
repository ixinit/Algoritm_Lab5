using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm4._28
{
    public partial class Algoritm428 : Form
    {
        //  перменные для создания и вывода массива
        private static int N = 15;
        private static int minEl = -50;
        private static int maxEl = 50;
        private static int[] A;

        private static bool count = true;

        public Algoritm428()
        {
            InitializeComponent();
            ArrGen();
            Show(dgArr);
        }
        
        // основной код
        public void mainFunc()
        {
            if (count)
            {
                for (int i = 1; i < N; i += 2)
                        A[i] = A[i] / A[0];
                Show(dgArr);
                count = false;
            }
        }

        // нажатие на кнопку
        private void btnClick_Click(object sender, EventArgs e)
        {
                mainFunc();
        }

        // генерация массива
        public void ArrGen()
        {
            int i;
            A = new int[N];
            Random Aval = new Random();
            for (i = 0; i < N; i++)
                A[i] = Aval.Next(minEl, maxEl);
        }
        
        // вывод массива
        public void Show(DataGridView _dgArr)
        {
            int i;
            _dgArr.RowCount = N + 1;
            for (i = 0; i < N; i++)
                _dgArr.Rows[i].Cells[0].Value = A[i].ToString();
        }
    }
}
