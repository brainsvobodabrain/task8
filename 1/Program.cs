/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Random rand=new Random(); 
int[,] create_array(int cols, int rows){
    int[,] ret =new int[cols,rows];
    for (int i=0;i<cols;i++){
        for (int j=0; j<rows; j++){
            ret[i,j]=rand.Next(10);
        }
    }
    return ret;
}

int[,] sort_array(int[,] arr){
    for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0;j<arr.GetLength(1);j++){
            for (int k=0;k<arr.GetLength(1);k++){
                if (arr[i,j]>arr[i,k]){
                    arr[i,j]=arr[i,j]+arr[i,k];
                    arr[i,k]=arr[i,j]-arr[i,k];
                    arr[i,j]=arr[i,j]-arr[i,k];
                }
            }
        }
    }
    return arr;
}

void print_array(int[,] arr){
    for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0; j<arr.GetLength(1);j++){
            System.Console.Write(arr[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}
int[,] arr=create_array(4,4);
System.Console.WriteLine("Первоначальный массив");
print_array(arr);
System.Console.WriteLine("Отсортированный массив");
print_array(sort_array(arr));
