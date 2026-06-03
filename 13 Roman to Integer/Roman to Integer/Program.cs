using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace Roman_to_Integer
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IIII"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.ReadKey();

        }

        static public int RomanToInt(string s)
        {

            int result = 0;
            char[] romanChar = s.ToCharArray();

            int[] value = new int[romanChar.Length];

            for (int i = 0; i <= value.Length - 1; i++)
            {

                    // To populate the index for what is their value
                    switch (romanChar[i])
                    {

                        case 'I':

                            value[i] = 1;
                            break;

                        case 'V':

                            value[i] = 5;
                            break;

                        case 'X':

                            value[i] = 10;
                            break;

                        case 'L':

                            value[i] = 50;
                            break;

                        case 'C':

                            value[i] = 100;
                            break;

                        case 'D':

                            value[i] = 500;
                            break;

                        case 'M':

                            value[i] = 1000;
                            break;

                        default:

                            value[i] = 0;
                            break;

                }

            }

            // Reverse calculate 
            for (int i = value.Length - 1; i >= 0; i--)
            {
                int temp1 = value[i];
                int temp2 = (i + 1 < value.Length) ? value[i + 1] : 0; // To prevent out of range

                // if index 0 is less than index 1 need to subtract || if index 0 is greater than > index 1 they will add
                if (temp1 < temp2)
                {
                    result -= temp1;
                }
                else
                {
                    result += temp1;
                }

            }

                return result;

        }

        //static public int RomanToInt(string s)
        //{

        //    int result = 0;
        //    char[] romanChar = s.ToCharArray();

        //    int[] value1 = new int[romanChar.Length];
        //    int[] value2 = new int[romanChar.Length];
        //    int count1 = 0;
        //    int count2 = 0;

        //    for (int i = 0; i <= value1.Length - 1; i++)
        //    {

        //        value1[i] = 0;
        //        value2[i] = 0;

        //    };


        //    //for (int i = 0; i <= value1.Length - 1;i++)
        //    //{

        //    //    Console.WriteLine($" value1: {value1[i]}");
        //    //    Console.WriteLine($" value2: {value2[i]}");

        //    //}



        //    for (int i = 0; i <= value1.Length - 1; i++)
        //    {

        //        if (i % 2 == 0)
        //        {

        //            switch (romanChar[i])
        //            {

        //                case 'I':

        //                    value1[count1] = 1;
        //                    break;

        //                case 'V':

        //                    value1[count1] = 5;
        //                    break;

        //                case 'X':

        //                    value1[count1] = 10;
        //                    break;

        //                case 'L':

        //                    value1[count1] = 50;
        //                    break;

        //                case 'C':

        //                    value1[count1] = 100;
        //                    break;

        //                case 'D':

        //                    value1[count1] = 500;
        //                    break;

        //                case 'M':

        //                    value1[count1] = 1000;
        //                    break;

        //                default:

        //                    value1[count1] = 0;
        //                    break;

        //            };

        //            count1 += 1;

        //        }
        //        else
        //        {

        //            switch (romanChar[i])
        //            {

        //                case 'I':

        //                    value2[count2] = 1;
        //                    break;

        //                case 'V':

        //                    value2[count2] = 5;
        //                    break;

        //                case 'X':

        //                    value2[count2] = 10;
        //                    break;

        //                case 'L':

        //                    value2[count2] = 50;
        //                    break;

        //                case 'C':

        //                    value2[count2] = 100;
        //                    break;

        //                case 'D':

        //                    value2[count2] = 500;
        //                    break;

        //                case 'M':

        //                    value2[count2] = 1000;
        //                    break;

        //                default:

        //                    value2[count2] = 0;
        //                    break;

        //            };

        //            count2 += 1;

        //        }

        //    }


        //    // Debug

        //    for (int i = 0; i <= value1.Length - 1; i++)
        //    {

        //        Console.WriteLine($" value1: {value1[i]}");
        //        Console.WriteLine($" value2: {value2[i]}");

        //    }


        //    int ZeroCount1 = 0;
        //    int ZeroCount2 = 0;

        //    for (int i = value1.Length - 1; i >= 0; i--)
        //    {

        //        // Counting the zeros
        //        if (value1[i] == 0)
        //        {

        //            ZeroCount1 += 1;

        //        };

        //        if (value2[i] == 0)
        //        {

        //            ZeroCount2 += 1;

        //        }

        //    }

        //    Console.WriteLine($"Zero1 Counts {ZeroCount1}");
        //    Console.WriteLine($"Zero2 Counts {ZeroCount2}");

        //    for (int i = value1.Length - 1; i >= 0; i--)
        //    {

        //        if (ZeroCount1 > ZeroCount2)
        //        {

        //            if (value2[i] >= value1[i])
        //            {

        //                result += value2[i] + value1[i];
        //                Console.WriteLine($"result: {result} += {value2[i]} + {value1[i]}");

        //            }
        //            else
        //            {

        //                result += value2[i] - value1[i];
        //                Console.WriteLine($"result: {result} += {value2[i]} - {value1[i]}");

        //            }

        //        }
        //        else if (ZeroCount2 > ZeroCount1)
        //        {

        //            if (value1[i] >= value2[i])
        //            {

        //                result += value1[i] + value2[i];
        //                Console.WriteLine($"result: {result} += {value1[i]} + {value2[i]}");

        //            }
        //            else
        //            {

        //                result += value1[i] - value2[i];
        //                Console.WriteLine($"result: {result} += {value1[i]} - {value2[i]}");

        //            }

        //        }
        //        else
        //        {

        //            if (value1[i] >= value2[i])
        //            {

        //                result += value1[i] + value2[i];

        //            }
        //            else
        //            {

        //                result += value1[i] - value2[i];

        //            }

        //        }

        //    }

        //    return Math.Abs(result);

        //}

    }
}
