using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2
{
    public static class TriangleResolver
    {
        public static string Analyze(int s1, int s2, int s3)
        {
            string result = "invalid";
            if (s1 > 0 && s2 > 0 && s3 > 0)
            {
                if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
                {
                    if (s1 == s2 || s2 == s3 || s1 == s3)
                    {
                        result = "isosceles";
                        if (s1 == s2 && s2 == s3)
                        {
                            result = "equilateral";
                        }
                    }
                    else
                    {
                        return "scalene";
                    }
                }
            }
            return result;
        }
    }
}
