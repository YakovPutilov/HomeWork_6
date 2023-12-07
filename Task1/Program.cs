//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char [,] stringToLine = {{'H','a','l','l','o',' '},{'w','o','r','l','d','!'}};

string StringFromChar(char [,] chars){
    string res = "";
    foreach (char elem in chars){
        res += elem;
    }
    return res;
    
}



void Show2dChar(char [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Show2dChar(stringToLine);
Console.WriteLine(StringFromChar(stringToLine));