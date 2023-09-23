using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class Queen 
    {
        public Queen() 
        {
            move_dist = 20;
            diagonal = true;
            horizontal = true;
        }
        private int move_dist;
        private bool diagonal;
        private bool horizontal;
    }
   
}
