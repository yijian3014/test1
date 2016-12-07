using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public  string return_str(int i)
       {
            
            if (Convert.ToInt32(i) < 10)
                return "我知道你输了一个小于10的数";
            else
                return "我知道你输入了一个大于10的数";
            if (Convert.ToInt32(i) == 10)
                return "你输入了个10！！！";
            else
                return "你输入了垃圾！";
        }

    }
}
