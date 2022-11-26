using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.Helpers
{
    public static  class Mymessage
    {
        public static void success(string Name)
        {
            MessageBox.Show(Name+" Saved Successfully!","Success Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

    }
}
