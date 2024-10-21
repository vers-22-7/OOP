using System;

class Animal
{
    private string name;
    private int age;
    private string species;

    public Animal(string name, int age, string species)
    {   this.name = name;
        this.age = age;
        this.species = species;}

    // Метод для виведення даних про тварину
    public void DisplayInfo(){
        Console.WriteLine($"Ім'я тварини: {name}");
        Console.WriteLine($"Вік тварини: {age} років");
        Console.WriteLine($"Вид тварини: {species}");}
}

class Program
{
    static void Main(string[] args)
    {   Animal myAnimal = new Animal("Барсик", 5, "Кіт");
        myAnimal.DisplayInfo();}
}
