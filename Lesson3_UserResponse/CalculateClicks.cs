using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3_UserResponse
{
    class CalculateClicks
    {
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
        ///     List временных интервалов между кликами
        /// </summary>
        private readonly List<TimeSpan> DblClicks = new List<TimeSpan>();

        /// <summary>
        ///     Метод вычисления попарных кликов по кнопке
        /// </summary>
        /// <returns></returns>
        public string CalculateMyClicks()
        {
            if (!_firstClickWas) _firstClick = DateTime.Now;
            else _secondClick = DateTime.Now;
            string message = DblClicks.Count>0? (TimeSpan.FromMinutes(1).TotalMilliseconds / DblClicks.Select(ts => ts.TotalMilliseconds).Average()).ToString() : null;
            if (_secondClick != default(DateTime))
            {
                DblClicks.Add(_secondClick - _firstClick);
                message = (TimeSpan.FromMinutes(1).TotalMilliseconds / DblClicks.Select(ts => ts.TotalMilliseconds).Average()).ToString();
            }

            //вот тут сбрасываем значение времени второго клика на дефолтное
            _secondClick = default(DateTime);
            //тут инвертируем значение, был ли первый клик
            _firstClickWas = !_firstClickWas;
            return message;
        }

    }
}
