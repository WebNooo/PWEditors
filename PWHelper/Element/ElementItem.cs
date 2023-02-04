using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PWHelper.Element
{
    public class ElementItem
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public ID_SPACE Space { get; set; }
        public dynamic Fields { get; set; }
        public ImageSource Icon { get; set; }
    }
}
