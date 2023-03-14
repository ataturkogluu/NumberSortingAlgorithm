class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = new int[] { 50, 4, 2, 9, 15, 6, 0, 7, 11, 12, 25, 14, 25, 14, 25, 14 };
        int[] oddNumbers = new int[numbers1.Length];
        int oddCount = 0;

        foreach (int number in numbers1)
        {
            if (number % 2 == 1)
            {
                oddNumbers[oddCount] = number;
                oddCount++;
            }
        }

        for (int i = 0; i < oddCount - 1; i++)
        {
            for (int j = i + 1; j < oddCount; j++)
            {
                if (oddNumbers[i] > oddNumbers[j])
                {
                    int temp = oddNumbers[i];
                    oddNumbers[i] = oddNumbers[j];
                    oddNumbers[j] = temp;
                }
            }
        }

        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(oddNumbers[i]);

            if (i != oddCount - 1)
            {
                Console.Write("-");
            }
        }

        int[] evenNumbers = new int[numbers1.Length];
        int evenCount = 0;

        foreach (int number in numbers1)
        {
            if (number % 2 == 0)
            {
                evenNumbers[evenCount] = number;
                evenCount++;
            }
        }

        for (int i = 0; i < evenCount - 1; i++)
        {
            for (int j = i + 1; j < evenCount; j++)
            {
                if (evenNumbers[i] > evenNumbers[j])
                {
                    int temp = evenNumbers[i];
                    evenNumbers[i] = evenNumbers[j];
                    evenNumbers[j] = temp;
                }
            }
        }

        for (int i = 0; i < evenCount; i++)
        {
            Console.Write("-" + evenNumbers[i]);
        }

        Console.ReadLine();
    }
}
