using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm4._5
{
    public partial class Algoritm45 : Form
    {
        //  перменные для создания и вывода массива
        private static int N = 15;
        private static int minEl = -50;
        private static int maxEl = 50;
        private static int[] A;

        public Algoritm45()
        {
            InitializeComponent();
            ArrGen();
            Show(dgArr);
        }
        
        // основной код
        public void mainFunc()
        {
            int id = -1;
            for (int i = 0; i < N; i++)
                if (A[i] < 0)
                    id = i;
            if (id != -1)
            {
                id++;
                lblResult.Text = id.ToString();
            }
            else
                lblResult.Text = "Нет отрицательных элементов";
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
