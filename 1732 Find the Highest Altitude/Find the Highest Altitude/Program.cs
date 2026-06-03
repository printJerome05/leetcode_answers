// See https://aka.ms/new-console-template for more information



/*

There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.

Example 1:

Input: gain = [-5,1,5,0,-7]
Output: 1
Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
Example 2:

Input: gain = [-4,-3,-2,-1,4,3,2]
Output: 0
Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.

*/

Console.WriteLine("Hello, World!");

int[] example1 = { -5,1,5,0,-7};
int[] example2 = {-4,-3,-2,-1,4,3,2};
int[] example3 = {52,-91,72};
int[] example4 = {44,32,-9,52,23,-50,50,33,-84,47,-14,84,36,-62,37,81,-36,-85,-39,67,-63,64,-47,95,91,-40,65,67,92,-28,97,100,81};

Console.WriteLine(LargestAltitude(example1)); // Should be 1
Console.WriteLine(LargestAltitude(example2)); // Should be 0
Console.WriteLine(LargestAltitude(example3)); // Should be 52
Console.WriteLine(LargestAltitude(example4)); // Should be 781


Console.ReadKey();

int LargestAltitude(int[] gain) {
        
    int i = 0;
    int temp = 0;
    int x = 0;

    do
    {
        
        x += gain[i];
        //Console.WriteLine($"{i}: {x}");
        i++;
        if(x > temp) temp = x;
        //Console.WriteLine(temp);

    }while(i <= gain.Length - 1);

    return temp;

};
