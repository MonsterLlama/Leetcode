using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterLlama.Leetcode
{
    public class Problem806
    {
        private const int LINE_WIDTH = 100;
        public int[] NumberOfLines(int[] widths, string s)
        {
            int current_width = 0, lines_used = 1;

            foreach (char letter in s)
            {
                int width = widths[letter - 'a'];

                current_width += width;

                if (current_width > LINE_WIDTH)
                {
                    current_width = width;
                    lines_used++;
                }
            }

            return [lines_used, current_width];
        }


        public bool Test1()
        {
            int[] widths = [10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10];
            string s     = "abcdefghijklmnopqrstuvwxyz";

            var result = NumberOfLines(widths, s);

            return result[0] == 3 && result[1] == 60;
        }

    }


}
