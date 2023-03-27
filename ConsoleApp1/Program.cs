using System;
using System.Collections.Generic;

class GFG
{
    
    public static int getMaxArea(int[] hist, int n)
    {
       
        Stack<int> s = new Stack<int>();

        int max_area = 0; 
        int tp; 
        int area_with_top; 

       
        int i = 0;
        while (i < n)
        {
         
            if (s.Count == 0 || hist[s.Peek()] <= hist[i])
            {
                s.Push(i++);
            }

         
            else
            {
                tp = s.Peek(); 
                s.Pop(); 

                area_with_top
                    = hist[tp]
                      * (s.Count == 0 ? i
                                      : i - s.Peek() - 1);

               
                if (max_area < area_with_top)
                {
                    max_area = area_with_top;
                }
            }
        }

  
        while (s.Count > 0)
        {
            tp = s.Peek();
            s.Pop();
            area_with_top
                = hist[tp]
                  * (s.Count == 0 ? i : i - s.Peek() - 1);

            if (max_area < area_with_top)
            {
                max_area = area_with_top;
            }
        }

        return max_area;
    }

    public static void Main(string[] args)
    {
        int[] hist = new int[] { 6, 2, 5, 4, 5, 1, 6 };

        
        Console.WriteLine("en buyuk alan "
                          + getMaxArea(hist, hist.Length));
    }
}
