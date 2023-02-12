/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Random rand=new Random(); 
int[,] create_array(int count){
    int[,] ret =new int[count,count];
    for (int i=0;i<count;i++){
        for (int j=0; j<count; j++){
            ret[i,j]=rand.Next(10);
        }
    }
    return ret;
}
void print_array(int[,] arr){
    for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0; j<arr.GetLength(1);j++){
            System.Console.Write(arr[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}

int small_summ_rows_array(int[,] arr){
     int summ=0;
     int min_summ=-1;
     int index_sum=-1;
     for (int i=0; i<arr.GetLength(0);i++){
        summ=0;
        for (int j=0; j<arr.GetLength(1);j++){
            summ=summ+arr[i,j];
        }
        if (min_summ==-1){
            min_summ=summ;
            index_sum=i;
        }else if (summ<min_summ){
            min_summ=summ;
            index_sum=i;
        }
     }
     return index_sum+1;
}
int[,] arr=create_array(4);

System.Console.WriteLine("Первоначальный массив");
print_array(arr);
System.Console.WriteLine($"Наименьшая сумма эллементов в {small_summ_rows_array(arr)} строке");