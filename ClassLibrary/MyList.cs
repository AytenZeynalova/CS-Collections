using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyList<T>
    {
        public MyList(T Num)
        {
            this.num = Num;
        }

        public T num;
        public T no;
    }
}
