using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAFTA5_Nesne_İlkUyg
{
    internal class işçi
    {
        private int kimlikno;
      public int KimlikNo
        {
            set {

                kimlikno=value;  }
            get { return kimlikno; }

        }
    }
}
