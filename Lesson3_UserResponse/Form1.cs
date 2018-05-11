using System;
using System.Windows.Forms;

namespace Lesson3_UserResponse
{
    public partial class UR_MainForm : Form
    {
        public UR_MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Переменная нового объекта класса вычисления кликов для использования при калькуляции
        /// </summary>
        CalculateClicks CalcClicks = new CalculateClicks();
        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Новая переменная класса DoTestClass, создаётся каждый раз при клике на кнопку Start
            DoTest doTest = checkBoxHardcoreOn.Checked ? new DoTest() : new DoTestChild();
            //Выдать результаты в MessageBox'e
            MessageBox.Show(string.Join("\n", doTest.DoMeasure((int)numericUpDown.Value)), "Test time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalculateClicks_Click(object sender, EventArgs e)
        {
            //Присвоение результата тексту с запуском метода вычисления средних кликов
            textBoxClicksPerMin.Text = CalcClicks.CalculateMyClicks();
        }
    }
}