//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные. 

string newstring = "AhAbRa CaDaHaBrA";
string Lowstring(string str){
    return str.ToLower();
} 

Console.WriteLine(Lowstring(newstring));
