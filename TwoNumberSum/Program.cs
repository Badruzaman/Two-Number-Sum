

int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
int targetSum = 10;
int[] result = TwoNumberSumV02(array, targetSum);
foreach (int item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

//Time O(n^2) Space O(1)
int[] TwoNumberSum(int[] array, int targetSum)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int firstNum = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            int secondNum = array[j];
            if (firstNum + secondNum == targetSum)
            {
                return new int[] { firstNum, secondNum };
            }
        }
    }
    return new int[0];
}
//Time O(n) Space O(n)
int[] TwoNumberSumV01(int[] array, int targetSum)
{
    HashSet<int> hashset = new HashSet<int>();
    for (int i = 0; i < array.Length; i++)
    {
        int potentialMatch = targetSum - array[i];
        if (hashset.Contains(potentialMatch))
        {
            return new int[] { potentialMatch, array[i] };
        }
        else
        {
            hashset.Add(array[i]);
        }
    }
    return new int[0];
}
//Time O(nlog(n)) Space O(1)
int[] TwoNumberSumV02(int[] array, int targetSum)
{
    Array.Sort(array);
    int left = 0;
    int right = array.Length - 1;
    while (left < right)
    {
        int twoSum = array[left] + array[right];
        if (twoSum == targetSum)
        {
            return new int[] { array[right], array[left] };
        }
        if (twoSum < targetSum)
        {
            left++;
        }
        else
        {
            right--;
        }

    }
    return new int[0];
}