// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] prices = { 7, 1, 5, 3, 6, 4 }; 
int[] prices1 = {7,6,4,3,1}; 
Console.WriteLine(MaxProfit(prices)); // returns 5 because 6 - 1
Console.WriteLine(MaxProfit(prices1)); // returns 0
Console.ReadKey();

int MaxProfit(int[] prices)
{

    //List<int> pricesTemp = prices.ToList();
    //int result = pricesTemp.FindIndex(0, x => x == pricesTemp.Min());
    //Console.WriteLine(result);
    //return result;

    int highestProfit = 0;

    int i = 0;

    int maxValue = prices.Max();
    int buyValue = 0;

    do
    {

        if (prices[i] < maxValue)
        {

            maxValue = prices[i];
            buyValue = prices[i];

    
             int y = prices.Length - 1;

            while (y != i)
            {

                if (prices[y] > buyValue)
                {

                    //Console.WriteLine($"Buy value: {buyValue} - Sell Value {prices[y]}");

                    int tempProfit = prices[y] - buyValue;

                    if (tempProfit > highestProfit)
                    {

                        highestProfit = tempProfit;

                    }

                }

                y--;

            }

        }

        if (i != prices.Length - 1)
            i++;
        else
            break;

    } while (i <= prices.Length - 1);

    return highestProfit;

}