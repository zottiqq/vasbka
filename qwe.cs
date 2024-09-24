using Calculator;
Console.WriteLine("Выберите число, оператор, число");
double number_one = double.Parse(Console.ReadLine());
string operatorr = Console.ReadLine();
double number_two = double.Parse(Console.ReadLine());
Osnov mathemat = new Osnov();
Funct functi = new Funct();

{
    switch (operatorr)    
    {
        case "+":            
            mathemat.pls(number_one, number_two);
            break;
        case "-":
            mathemat.minus(number_one, number_two);            
            break;
        case "*":            
            mathemat.ymn(number_one, number_two);
            break;
        case "/":
            mathemat.del(number_one, number_two);            
            break;      
        default:
            Console.WriteLine("Неудачное действие");             
            break;
    }



    Console.WriteLine("Хотите выбрать функцию?");    
    string choose_funct = Console.ReadLine();
    if (choose_funct == "да")
    {        
        Console.WriteLine("Выберите одну из функций: min - минимльное, max - максимальное, sqrt - корень числа, pow - степень, sin - синус, tan - тангенс.");
        string cchoose = Console.ReadLine();
        Console.WriteLine("Заново выберите числа");
        switch (cchoose)        
        {
            case "pow":                
                functi.pow();
                break;            
            case "max":
                functi.max();                
                break;
            case "sqrt":                
                functi.sqrt();
                break;            
            case "min":
                functi.min();                
                break;
            case "sin":                
                functi.sin();
                break;            
            case "tan":
                functi.tan();             
                break;
            default:                
                Console.WriteLine("Нет такого");
                break;        
        }
    }
    
}
