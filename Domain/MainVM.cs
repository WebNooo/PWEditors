using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace Domain
{
    class MainVM : VM
    {
        public ObservableCollection<SquareVM> Squares { get; } =
            new ObservableCollection<SquareVM>()
            {
                new SquareVM() { Position = new Point( 30,  30) },
                new SquareVM() { Position = new Point(100,  70) },
                new SquareVM() { Position = new Point( 80,   0) },
                new SquareVM() { Position = new Point( 90, 180) },
                new SquareVM() { Position = new Point( 0, 0) },
                new SquareVM() { Position = new Point(200, 200) }
            };
    }
}
