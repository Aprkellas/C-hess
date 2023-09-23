using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class King
    {
        public King() 
        {
            move_dist = 1;
            diagonal = false;
            horizontal = true;


        }
        private int move_dist;
        private bool diagonal;
        private bool horizontal;
    }
}
