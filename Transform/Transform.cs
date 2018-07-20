using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] num,Func<int,int> Double)
        {
            List<int> newNum = new List<int>();
            foreach (int item in num)
            {
                newNum.Add(Double(item));
            }   
            return newNum;
            throw new NotImplementedException();

        }
    }
}
