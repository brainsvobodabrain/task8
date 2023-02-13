/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Random rand=new Random(); 
int[,,] create_array(int p1, int p2,int p3){
    int[,,] ret =new int[p1,p2,p3];
    for (int i=0;i<p1;i++){
        for (int j=0; j<p2; j++){
            for (int k=0;k<p3;k++){
                ret[i,j,k]=rand.Next(10);
            }
        }
    }
    return ret;
}


void print_array(int[,,] arr){
    for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0; j<arr.GetLength(1);j++){
            for (int k=0; k<arr.GetLength(2);k++){
                System.Console.WriteLine($"{arr[i,j,k]} ({i},{j},{k})");
            }
        }
    }
}

int[,,] arr=create_array(2,2,2);
print_array(arr);
