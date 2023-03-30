using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFStamper
{
    [Serializable]

    class StampSettings
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Scale { get; set; }
        public int Rotation { get; set; }
        public string StampImagePath { get; set; }
    }
}
