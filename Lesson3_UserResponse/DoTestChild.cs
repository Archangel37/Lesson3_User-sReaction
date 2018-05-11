using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Lesson3_UserResponse
{
    internal class DoTestChild: DoTest
    {
        /// <summary>
        ///     Окончание "секундомера" реакции на мессадж-бокс
        /// </summary>
        private DateTime _timerEnd;

        /// <summary>
        ///     Начало "секундомера" реакции на мессадж-бокс
        /// </summary>
        private DateTime _timerStart;


        //https://habrahabr.ru/post/304520/
        public override List<TimeSpan> DoMeasure(int numTests)
        {
            List<TimeSpan> Results = new List<TimeSpan>();

            for (int i = numTests; i > 0; i--)
            {
                Thread.Sleep(GetRandom().Next(GetMinRandom(), GetMaxRandom()) * 100);
                _timerStart = DateTime.Now;
                //тут курсор бешено не прыгает по экрану, упрощённый тест, часть переменных стала protected в родителе,
                //ненужная часть - так и осталась приватной
                DialogResult res =
                    MessageBox.Show("Кликни ОК", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK) _timerEnd = DateTime.Now;

                Results.Add(_timerEnd - _timerStart);
            }

            return Results;
        }
    }
}