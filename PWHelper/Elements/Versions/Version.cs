using System;
using System.Collections.Generic;
using System.Text;

namespace PWHelper.Elements.Versions
{
    public interface IStructure
    {
        int ConversionIndex { get; set; }
        int ComputerNameIndex { get; set; }
        int HardInfoIndex { get; set; }
    }
}
