void print_mas_string(string[] mas){
    
     Console.Write("[");
     if (mas.Length > 0){
     for(int i = 0; i < mas.Length - 1; i++){
             System.Console.Write($"{mas[i], 3}, ");
     }
     System.Console.Write($"{mas[mas.GetLength(0) - 1], 3}");}
     System.Console.WriteLine($"]");}



string[] get_mas_str_len3(string[] mas){
    int k = mas.Length;
    int count = 0;
    int j = 0;
    string[] mas1 = new string[k];
    for(int i = 0; i < k; i++){
        if (mas[i].Length <= 3){
            count += 1;
            mas1[j] = mas[i];
            j += 1;
        }   
    }

        string[] res = new string[count];
        for(int m = 0; m < count; m++) res[m] = mas1[m];
        return res;   
    }




string[] mas1 = new string[] {"Hello", "2", "world", ":-)"};
System.Console.WriteLine($"Исходный массив 1: ");
print_mas_string(mas1);
System.Console.WriteLine($"Изменённый массив 1: ");
print_mas_string(get_mas_str_len3(mas1));

string[] mas2 = new string[] {"1234", "1567", "-2", "computer science"};
System.Console.WriteLine($"Исходный массив 2: ");
print_mas_string(mas2);
System.Console.WriteLine($"Изменённый массив 2: ");
print_mas_string(get_mas_str_len3(mas2));

string[] mas3 = new string[] {"Russia", "Denmark", "Kazan"};
System.Console.WriteLine($"Исходный массив 3: ");
print_mas_string(mas3);
System.Console.WriteLine($"Изменённый массив 3: ");
print_mas_string(get_mas_str_len3(mas3));
