using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Domain
{
    class SquareVM : VM
    {
        public SquareVM()
        {
            RequestMove = new SimpleCommand<Point>(MoveTo);
        }

        // стандартное свойство
        Point position;
        public Point Position
        {
            get { return position; }
            set { if (position != value) { position = value; NotifyPropertyChanged(); } }
        }

        // выставляем команду, которая занимается перемещением
        public ICommand RequestMove { get; }

        void MoveTo(Point newPosition)
        {
            // в реальности тут могут быть всякие проверки, конечно
            Position = newPosition;
        }
    }
}
