using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise7
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };


        var m = from x in nums
                group x by x into y
                select y;
       

        foreach (var arrEle in m)
        {
            Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
        }
        
    }
}