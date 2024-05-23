using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Library.Models
{
    public partial class Book
    {

        //условие цвета серый в колонке на стр книг (все копии на руках)
        public string ColorNoCopiess
        {
            get
            {
                if (CountCopies == 0)
                    return "#808080";
                else
                    return "#000000";
            }
        }
        public string NoCopies
        {
            get
            {

                if (CountCopies == 0)
                    return "Все копии на руках";
                else
                    return "";
            }
        }
    }
}
