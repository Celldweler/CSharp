using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nasled_37_c_sharp_GUI
{
    public partial class Form1 : Form
    {
        Square[] squares;
        SquarePrizm[] squarePrizms;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            squares = new Square[0];
            squarePrizms = new SquarePrizm[0];
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int max = 0;
            for (int i = 1; i < squares.Length - 1; i++)
                if (squares[max].GetSquare() < squares[i].GetSquare())
                    max = i;
            richTextBoxSquare.Text += $"\n---------------------\nSquare number with max square is: {max + 1}, it's square is: {squares[max].GetSquare()}";
            SquarePrizm squarePrizm = new SquarePrizm();
            squarePrizm.Title = txtSqaurePrizmTitle.Text;
             squarePrizm.Side = Convert.ToDouble(txtSqaurePrizmSide.Text==""?"0": txtSqaurePrizmSide.Text);
            squarePrizm.Height = Convert.ToDouble(txtSquarePrizmHeight.Text==""?"0": txtSquarePrizmHeight.Text);
           richTextBoxSqaurePrizm.Text = squarePrizm.ToString();
          MessageBox.Show("!!!");
        }

        private void btnAddSquare_Click(object sender, EventArgs e)
        {
            Array.Resize(ref squares, squares.Length + 1);
            squares[squares.Length - 1] = new Square(txtSquareTitle.Text, Convert.ToDouble(txtSquareSide.Text == "" ? "0" : txtSquareSide.Text));
            richTextBoxSquare.Text += squares[squares.Length - 1].ToString();
            labelSquaresCounter.Text = squares.Length.ToString();
        }

     

        private void open1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBoxSquare.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
        private void Save1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBoxSquare.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void Open2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBoxSqaurePrizm.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
        private void Save2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBoxSqaurePrizm.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
