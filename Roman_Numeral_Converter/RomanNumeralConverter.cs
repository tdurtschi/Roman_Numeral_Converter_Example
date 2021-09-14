using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RomanNumeral
{
    public class RomanNumeralConverter
    {
        static public ulong Convert(in string input)
        {
            if(!IsValid(input))
            {
                throw new ArgumentException();
            }

            var integer_stack = new Queue<ulong>();

            foreach (var character in input)
            {
                if (character == 'I')
                {
                    integer_stack.Enqueue(1);
                }
                else if (character == 'V')
                {
                    integer_stack.Enqueue(5);
                }
                else if (character == 'X')
                {
                    integer_stack.Enqueue(10);
                }
                else if (character == 'L')
                {
                    integer_stack.Enqueue(50);
                }
                else if (character == 'C')
                {
                    integer_stack.Enqueue(100);
                }
                else if (character == 'D')
                {
                    integer_stack.Enqueue(500);
                }
                else if (character == 'M')
                {
                    integer_stack.Enqueue(1000);
                }
                //else
                //{
                //}

                //Anything larger than 3,999 (MMMCMXCIX) is not possible here
            }

            ulong result = 0;

            while (integer_stack.Count > 0)
            {
                ulong current_number = integer_stack.Dequeue();
                ulong next_number = 0;

                if (integer_stack.Count >= 1)
                {
                    next_number = integer_stack.Peek();
                }

                if (current_number < next_number)
                {
                    result -= current_number;
                }
                else
                {
                    result += current_number;
                }
            }

            return result;
        }

        static public bool IsValid(string test_string)
        {
            Regex valid_template = new Regex(@"^[IVXLCDM]{1,15}$");

            return valid_template.IsMatch(test_string);
        }
    }
}
