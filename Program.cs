//int[] numbers = {35,64,28,94,56,81};
//for (int i = 0; i < numbers.Length; i++) 
//{
//    Console.WriteLine(numbers[i]);
//}


//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);


//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//for (int i = 5; i < numbers.Length; i--)
//{
//    Console.WriteLine(numbers[i]);
//}



//int[] arr = { 1, 2, 3, 4, 5 };

//Array.Reverse(arr);

//foreach (int num in arr)
//{
//    Console.Write(num + " ");
//}




//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//int max = numbers[0];
//for (int i = 0; i<numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    { max = numbers[i]; }
//}
//Console.WriteLine($"arraydaki en boyuk eded {max}");



//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    count++;
//}
//Console.WriteLine($"arraydaki ededlerin sayi {count}");




//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//int n = 5, i, j, deyer;
//Console.WriteLine("Insertion Sort");
//Console.Write("Initial array is: ");
//for (i = 0; i < n; i++)
//{
//    Console.Write(numbers[i] + " ");
//}
//for (i = 1; i < n; i++)
//{
//    deyer = numbers[i];
//    j = i - 1;
//    while (j >= 0 && numbers[j] > deyer)
//    {
//        numbers[j + 1] = numbers[j];
//        j = j - 1;
//    }
//    numbers[j + 1] = deyer;
//}
//Console.Write("Sorted Array is: ");
//for (i = 0; i < n; i++)
//{
//    Console.Write(numbers[i] + " ");
//}



//int[] numbers = { 35, 64, 28, 94, 56, 81,0 };
//int sifirsayi = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 0 )
//    {
//        sifirsayi++;
//    }
//}
//Console.WriteLine($"sifirlarin sayi:  {sifirsayi}");




//int[] numbers = { 35, 64, -28, 94, 56, -81, 0 };
//int menfisayi = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0 )
//    {
//        menfisayi++;
//    }
//}
//Console.WriteLine($"menfilerin sayi:  {menfisayi}");





//int[] numbers = { 35, 64, -28, 94, 56, -81, 0 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        sum += numbers[i];
//    }
//}
//Console.WriteLine($"musbetlerin cemi:  {sum}");


//int[] numbers = { 35, 64, -28, 94, 56, -81, 0 };
//int power = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    power = numbers[i] * numbers[i];
//    Console.WriteLine(power);
//}




//int[] arr = { 30, 50, 90, 40, 70 };

//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = 0; j < arr.Length - i - 1; j++)
//    {
//        if (arr[j] < arr[j + 1])
//        {
//            arr[j] = arr[j] + arr[j + 1];
//            arr[j + 1] = arr[j] - arr[j + 1];
//            arr[j] = arr[j] - arr[j + 1];
//        }
//    }
//}

//foreach (int num in arr)
//{
//    Console.Write(num + " ");
//}