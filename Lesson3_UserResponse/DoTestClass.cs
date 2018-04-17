using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lesson3_UserResponse
{
    internal class DoTestClass
    {
        /// <summary>
        ///     отступ пикселей от краёв экрана
        /// </summary>
        const int indent = 30;

        /// <summary>
        ///     Высота текущего экрана, пикселей
        /// </summary>
        private readonly int _screenHeight = Screen.PrimaryScreen.Bounds.Size.Height;

        /// <summary>
        ///     Ширина текущего экрана, пикселей
        /// </summary>
        private readonly int _screenWidth = Screen.PrimaryScreen.Bounds.Size.Width;
        /// <summary>
        ///     Меньшее число сотен миллисекунд для генерации рандома
        /// </summary>
        protected const int MinRandom = 5;

        /// <summary>
        ///     Большее число сотен миллисекунд для генерации рандома
        /// </summary>
        protected const int MaxRandom = 50;
        /// <summary>
        ///     Пременная рандома
        /// </summary>
        protected Random Rnd = new Random();
        /// <summary>
        ///     Окончание "секундомера" реакции на мессадж-бокс
        /// </summary>
        protected DateTime _timerEnd;

        /// <summary>
        ///     Начало "секундомера" реакции на мессадж-бокс
        /// </summary>
        protected DateTime _timerStart;


        /// <summary>
        ///     Сделать необходимое число тестов и вернуть List<TimeSpan> реакций пользователя
        /// </summary>
        /// <returns></returns>
        public virtual List<TimeSpan> DoMeasure(int numTests)
        {
            List<TimeSpan> Results = new List<TimeSpan>();

            for (int i = numTests; i > 0; i--)
            {

                Thread.Sleep(Rnd.Next(MinRandom, MaxRandom) * 100);
                _timerStart = DateTime.Now;
                //чтоб жизнь мёдом не казалась
                Cursor.Position = new Point(Rnd.Next(indent, _screenWidth - indent),
                    Rnd.Next(indent, _screenHeight - indent));

                DialogResult res = MessageBox.Show("Кликни ОК", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK) _timerEnd = DateTime.Now;

                Results.Add(_timerEnd - _timerStart);
            }

            return Results;
        }
    }
}
