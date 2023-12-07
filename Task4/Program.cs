//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

string str = "Well, well, well mister Freeman";

string GetReversWordPosition(string str){
    string res = "";
    char space = ' ';
    int lastSpasePos = str.Length;
    for (int i = 0; i < str.Length; i++){
        if (str[str.Length-i-1] == space){
            for (int j = 0; str.Length-i + j < lastSpasePos; j++){
                res += str[str.Length-i+j];
            }
            res += " ";
            lastSpasePos = str.Length-i-1;
        }     
   }
   if (str[0] != space){
            for (int i=0; i < lastSpasePos; i++){
                res += str[i];
            }
        }
    return res;
}
Console.WriteLine(GetReversWordPosition(str));