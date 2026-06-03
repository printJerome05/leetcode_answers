using System.ComponentModel;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));
Console.WriteLine(GcdOfStrings("ABABAB", "ABAB"));
Console.WriteLine(GcdOfStrings("LEET", "CODE"));
Console.WriteLine(GcdOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"));
Console.WriteLine(GcdOfStrings("ABCDEF", "ABC"));
Console.WriteLine(GcdOfStrings("AA", "A"));
Console.WriteLine(GcdOfStrings("AAAAAAAAA", "AAACCC"));
Console.WriteLine(GcdOfStrings("ABABABAB", "ABAB"));
Console.WriteLine(GcdOfStrings("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                               "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
Console.WriteLine(GcdOfStrings("BABABA", "ABAB"));                            
Console.ReadKey();

string GcdOfStrings(string str1, string str2)
{

    int Gdc = 0;
    int Length1 = str1.Length - 1;
    int Length2 = str2.Length - 1;
    string TempResult = string.Empty;

    // Compute the gdc from 1 to 100
    for (int i = 1; i <= 100; i++)
    {

        if ((str1.Length % i == 0) && (str2.Length % i == 0))
        {

            Gdc = i;

        }

    }
    
    int Length1Gdc = Length1 / Gdc;
    int Length2Gdc = Length2 / Gdc;

    string ShouldBeAnswer1 = str1.Substring(0, Gdc);
    string ShouldBeAnswer2 = str2.Substring(0, Gdc);
    
    int TempGdc = Gdc;


    // compute base on the leght of the string
    if (Length1 > Length2 || Length1 == Length2)
    {

        // Length to of the strign 2 divided by gdc to get the number of times of the substring to be check

        ShouldBeAnswer1 = str1.Substring(0, Gdc);
        ShouldBeAnswer2 = str2.Substring(0, Gdc);
        //Console.WriteLine($"GDC {Length2Gdc}");
        //Console.WriteLine($"LEGNT2 {ShouldBeAnswer}");

       if (Length1 == Length2)
        {

            if (str1 == str2)
            {

                return str1;

            }
            else
            {

                   // Temp 
            if (ShouldBeAnswer2 != str1.Substring(0, Gdc))
            {

                // empty because strng is not symeterical if diveded to each other
                return String.Empty;

            }

                                // Temp 
                if (ShouldBeAnswer1 != str2.Substring(0, Gdc))
                {

                    // empty because strng is not symeterical if diveded to each other
                    return String.Empty;

                }

            TempGdc = Gdc; //Reset the temp

            }

        }
        

        for (int i = 0; i <= Length1Gdc - 1; i++)
            {

                // Temp 
                if (ShouldBeAnswer1 != str1.Substring(TempGdc, Gdc))
                {

                    // empty because strng is not symeterical if diveded to each other
                    return String.Empty;

                }

                TempGdc += Gdc;

            }

        TempGdc = Gdc; //Reset the temp

        for (int i = 0; i <= Length2Gdc - 1; i++)
        {

            // Temp 
            if (ShouldBeAnswer2 != str2.Substring(TempGdc, Gdc))
            {

                // empty because strng is not symeterical if diveded to each other
                return String.Empty;

            }

            TempGdc += Gdc;

        }

        // loop for the least str length
        for (int i = 0; i <= Length2; i++)
        {

            // loop for the higher count of length
            for (int j = 0; j <= Length1; j++)
            {

                // i remains the same while j adds. If == true it will execute
                if (str2[i] == str1[j])
                {

                    // To get the limit of the string
                    if (TempResult.Length != Gdc)
                    {

                        // Result will be added to itself
                        TempResult += str2[i];
                        break;

                    }

                }

            }

        }

    }
    else if (Length1 < Length2)
    {

        // Length to of the strign 2 divided by gdc to get the number of times of the substring to be check

        ShouldBeAnswer1 = str1.Substring(0, Gdc);
        ShouldBeAnswer2 = str2.Substring(0, Gdc);

        TempGdc = Gdc; //Reset the temp

        for (int i = 0; i <= Length2Gdc - 1; i++)
        {

            // Temp 
            if (ShouldBeAnswer2 != str2.Substring(TempGdc, Gdc))
            {

                // empty because strng is not symeterical if diveded to each other
                return String.Empty;

            }

            TempGdc += Gdc;

        }

        TempGdc = Gdc; //Reset the temp

        for (int i = 0; i <= Length1Gdc - 1; i++)
        {

            // Temp 
            if (ShouldBeAnswer1 != str1.Substring(TempGdc, Gdc))
            {

                // empty because strng is not symeterical if diveded to each other
                return String.Empty;

            }

            TempGdc += Gdc;

        }

        for (int i = 0; i <= Length1; i++)
        {

            for (int j = 0; j <= Length2; j++)
            {

                if (str1[i] == str2[j])
                {

                    if (TempResult.Length != Gdc)
                    {

                        TempResult += str1[i];
                        break;

                    }

                }

            }

        }

    }

    // result length is not one 
    if (TempResult.Length != 0)
    {

        if (Length1 > Length2 || Length1 == Length2)
        {

            // TempResult need to be the same as the both str1 and str2
            if (TempResult != str1.Substring(0, TempResult.Length))
            {

                return string.Empty;

            }

        }
        else
        {

            if (TempResult != str2.Substring(0, TempResult.Length))
            {

                return string.Empty;

            }

        }
 
        return TempResult;

    }
    else // Length of the str is only 1 
    {

        return string.Empty;

    }
    
}