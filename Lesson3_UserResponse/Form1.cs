using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Lesson3_UserResponse
{
    public partial class UR_MainForm : Form
    {
        /// <summary>
        ///     Меньшее число сотен миллисекунд для генерации рандома
        /// </summary>
        private const int MinRandom = 5;

        /// <summary>
        ///     Большее число сотен миллисекунд для генерации рандома
        /// </summary>
        private const int MaxRandom = 50;

        /// <summary>
        ///     отступ пикселей от краёв экрана
        /// </summary>
        private const int indent = 30;

        /// <summary>
        ///     Высота текущего экрана, пикселей
        /// </summary>
        private readonly int _screenHeight = Screen.PrimaryScreen.Bounds.Size.Height;

        /// <summary>
        ///     Ширина текущего экрана, пикселей
        /// </summary>
        private readonly int _screenWidth = Screen.PrimaryScreen.Bounds.Size.Width;

        /// <summary>
        ///     List временных интервалов между кликами
        /// </summary>
        private readonly List<TimeSpan> DblClicks = new List<TimeSpan>();

        /// <summary>
        ///     Время первого клика из двух
        /// </summary>
        private DateTime _firstClick;

        /// <summary>
        ///     Булева переменная - был ли уже первй клик - true=был, ожидается второй, false=не было (ни разу не кликали или кликнут второй)
        /// </summary>
        private bool _firstClickWas;

        /// <summary>
        ///     время второго клика из двух, сбрасывается каждый раз, присваивается на 2й клик, считается TimeSpan и снова
        ///     сбрасывается
        /// </summary>
        private DateTime _secondClick;

        /// <summary>
        ///     Окончание "секундомера" реакции на мессадж-бокс
        /// </summary>
        private DateTime _timerEnd;

        /// <summary>
        ///     Начало "секундомера" реакции на мессадж-бокс
        /// </summary>
        private DateTime _timerStart;

        /// <summary>
        ///     Пременная рандома
        /// </summary>
        public Random Rnd = new Random();

        public UR_MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Генератор события простоя, рандомизации положения курсора, показа мессадж-бокса, по которому кликнуть надо и
        ///     возвращение "реакции" пользователя
        /// </summary>
        /// <returns></returns>
        private TimeSpan SleepGenerator()
        {
            Thread.Sleep(Rnd.Next(MinRandom, MaxRandom) * 100);
            _timerStart = DateTime.Now;
            //чтоб жизнь мёдом не казалась
            Cursor.Position = new Point(Rnd.Next(indent, _screenWidth - indent),
                Rnd.Next(indent, _screenHeight - indent));

            DialogResult res = MessageBox.Show("Кликни ОК", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK) _timerEnd = DateTime.Now;

            return _timerEnd - _timerStart;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<TimeSpan> Results = new List<TimeSpan>();
            int NumberTests = (int) numericUpDown.Value;
            for (int i = NumberTests; i > 0; i--) Results.Add(SleepGenerator());

            MessageBox.Show(string.Join("\n", Results), "Test time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalculateClicks_Click(object sender, EventArgs e)
        {
            //490 в минуту мой рекорд с кнопкой х3 клика ))
            if (!_firstClickWas) _firstClick = DateTime.Now;
            else _secondClick = DateTime.Now;

            if (_secondClick != default(DateTime))
            {
                DblClicks.Add(_secondClick - _firstClick);
                double avg = DblClicks.Select(ts => ts.TotalMilliseconds).Average();
                textBoxClicksPerMin.Text = (TimeSpan.FromMinutes(1).TotalMilliseconds / avg).ToString();
            }

            _secondClick = default(DateTime);
            _firstClickWas = !_firstClickWas;
        }
    }
}