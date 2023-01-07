//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System.Xml.Linq;
//using System.Diagnostics;

using System.Diagnostics;
using System.Xml.Linq;

Console.WriteLine("Здравтсвуйте!");

string? nameCompany = null;
do
{
    Console.WriteLine("\nНапишите название фирмы:");
    nameCompany = Console.ReadLine();
}
while (String.IsNullOrEmpty(nameCompany));


int count = 0;
string? answer = null;
do
{
    Console.WriteLine("Вы хотите добавить сотрудника?(да/нет)");
    answer = Console.ReadLine();
}
while (answer == null || (answer != "да" && answer != "нет"));


while (answer == "да")
{
    
    string? surname = null;
    do
    {
        Console.WriteLine("Напишите вашу фамилию");
        surname = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(surname));

    string? name = null;
    do
    {
        Console.WriteLine("Напишите ваше имя");
        name = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(name));

    string? patronymic = null;
    do
    {
        Console.WriteLine("Напишите ваше отчество");
        patronymic = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(patronymic));

   
    int number;
    do
    {
        Console.WriteLine("Напишите ваш возраст цифрой");
        var strNumber = Console.ReadLine();
        
        if (int.TryParse(strNumber, out number))
        {
            Console.WriteLine($"Введено число {number}");
            break;
        }
    } while (true);


    
    string ? gender = null;
    do
    {
        Console.WriteLine("напишите ваш пол (м/ж)");
        gender = Console.ReadLine();    
    }
    while(String.IsNullOrEmpty(gender) || (gender !="м" && gender != "ж"));

    var pos = "";
    do
    {
        Console.WriteLine("Выберите вашу профессию из списка: \nменеджер \nпрограммист \nтестеровщик \nруководитель проекта \nдиректор");
        var position = Console.ReadLine();
        position = position.ToLower();
        pos = position switch
        {
            "менеджер" => "менеджер",
            "программист" => "программист",
            "тестеровщик" => "тестеровщик",
            "руководитель проекта" => "руководитель проекта",
            "директор" => "директор",
            _ => "ошибка",
        };
        
    }
    while (pos == "ошибка");
    

    string prefix = "";
    if (gender == "м")
        prefix = "Уважаемый";
    else if (gender == "ж")
        prefix = "Уважаемая";
   
    Console.WriteLine($"\n{prefix}, {surname} {name} {patronymic}, " +
        $"\nВам {number} лет/года, \nВаша должность: {pos} \nСпасибо за заполнение данных о себе!");

    count++;

    if (answer == "нет")
    {
        break;
    }

    do
    {
        Console.WriteLine("Вы хотите добавить сотрудника?(да/нет)");
        answer = Console.ReadLine();
    }
    while (answer == null || (answer != "да" && answer != "нет"));
}
Console.WriteLine($"В фирму {nameCompany} было добавлено {count} сотрудников." +
        $"\nСпасибо за использование нашей программы!!!");



