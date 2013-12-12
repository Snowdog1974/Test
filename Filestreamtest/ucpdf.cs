using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Filestreamtest
{
    public partial class ucpdf : UserControl
    {
        public ucpdf(string filename)
        {
            InitializeComponent();
            this.axAcroPDF1.LoadFile(filename);

        }
    }
}
