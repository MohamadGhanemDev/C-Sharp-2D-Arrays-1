

int[] nums = { 1 , 10 , 2 , 20, 3 ,  30 , 4 , 40 }; // 1D array , works on x-axis only
                                                    // 

int[,] numbers =
{               /*y-axis*/
/* x axis */    {1 , 2 , 3 },   // the same idea of this int[] nums = { 1 , 10 , 2 , 20, 3 ,  30 , 4 , 40 };
                {4 , 5 , 6 },   // but  here we use intead of numbers we put array nums = { {}, 10 , 2 , 20, 3 ,  30 , 4 , 40 };
                {7 , 8 , 9 }    
};

//                     index of the array , index of the element inside the array
Console.WriteLine(numbers[0, 0]);
Console.WriteLine( numbers[0, 1] );

Console.WriteLine(numbers[2, 2]);
