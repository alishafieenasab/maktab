Console.WriteLine("Enter your integer array : ");
var input = Console.ReadLine();
string[] inputArray = input.Split(',');
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = inputArray[i].Trim();
}
int[] inputNumber = new int[inputArray.Length];
for (int i = 0; i < inputArray.Length; i++)
{
    inputNumber[i] = Convert.ToInt32(inputArray[i]);
}
Console.WriteLine("Enter your Method : ");
Console.WriteLine("1- SearchMin ");
Console.WriteLine("2- Reverse ");
Console.WriteLine("3- CustomSort ");
Console.WriteLine("4- RepeatedIndex ");
Console.WriteLine("5- Subscription ");
int title = Convert.ToInt32(Console.ReadLine());
switch (title)
{
    case 1:
        Console.WriteLine(SearchMin(inputNumber));
        break;
    case 2:
        PrintArray(Reverse(inputNumber));
        break;
    case 3:
        PrintArray(CustomSort(inputNumber));
        break;
    case 4:
        RepeatedIndex(inputNumber);
        break;
    case 5:
        Subscription(inputNumber);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;

}
int SearchMin(int[] inputArray)
{
    int min = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] < min)
            min = inputArray[i];
    }
    return min;
}
int[] Reverse(int[] inputArray)
{
    int[] ReverseInputArray = new int[inputArray.Length];
    int j = 0;
    for (int i = inputArray.Length - 1; i >= 0; i--)
    {
        ReverseInputArray[j] = inputArray[i];
        j++;
    }
    
    return ReverseInputArray;
}
int[] CustomSort(int[] inputArray)
{
    int minIndex;
    int temp;
    for (int i = 0; i < inputArray.Length; i++)
    {
        minIndex = i;
        for (int j = i + 1; j < inputArray.Length; j++)
            if (inputArray[j] < inputArray[minIndex])
                minIndex = j;
        if (minIndex != i)
        {
            temp = inputArray[i];
            inputArray[i] = inputArray[minIndex];
            inputArray[minIndex] = temp;
        }
    }
    return inputArray;
}
void RepeatedIndex(int[] inputArray)
{
    int[] repeatedArray = new int[inputArray.Length];
    int[] countRepeated = new int[inputArray.Length];
    int count = 0;
    int temp = 0;
    bool check = true;
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j <= inputArray.Length - 1; j++)
        {
            if (inputArray[i] == inputArray[j])
            {
                count++;
            }
        }
        if (count >= 2)
        {
            for (int k = 0; k < repeatedArray.Length; k++)
            {
                if (inputArray[i] == repeatedArray[k] && countRepeated[k] != 0)
                    check = false;
            }
            if (check)
            {
                repeatedArray[temp] = inputArray[i];
                countRepeated[temp] = count;
                temp++;
            }

        }
        check = true;
        count = 0;
    }
    for (int i = 0; i < repeatedArray.Length; i++)
    {
        if (countRepeated[i] != 0)
        {
            Console.WriteLine(repeatedArray[i]);
            Console.WriteLine(countRepeated[i]);
        }

    }
}
void Subscription(int[] inputArray)
{
    int[] temp = new int[inputArray.Length];
    Console.WriteLine("Enter your second integer array : ");
    var input = Console.ReadLine();
    string[] inputArray2 = input.Split(',');
    int countTemp = 0;
    for (int i = 0; i < inputArray2.Length; i++)
    {
        inputArray2[i] = inputArray2[i].Trim();
    }
    int[] inputNumber2 = new int[inputArray2.Length];

    for (int i = 0; i < inputArray2.Length; i++)
    {
        inputNumber2[i] = Convert.ToInt32(inputArray2[i]);
    }
    for (int i = 0; i < inputNumber2.Length; i++)
    {
        for (int j = 0; j < inputNumber2.Length; j++)
        {
            if (inputArray[i] == inputNumber2[j])
            {
                temp[countTemp] = inputNumber2[j];
                countTemp++;
            }
        }
    }
    for (int i = 0; i < temp.Length; i++)
    {
        Console.WriteLine(temp[i]);
    }
}
void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.WriteLine(inputArray[i]);
    }
}
