using System;
using System.Collections.Generic;

// Перечисление для представления пола студента
public enum Gender
{
    Male,
    Female
}

// Перечисление для формы обучения
public enum EducationForm
{
    FullTime,
    PartTime
}

public class Student
{
    public string FullName { get; set; }
    public string Group { get; set; }
    public double AverageGrade { get; set; }
    public decimal FamilyIncome { get; set; }
    public List<string> FamilyMembers { get; set; }
    public Gender Gender { get; set; }
    public EducationForm EducationForm { get; set; }

    // Конструктор для создания объекта Student
    public Student(
        string fullName,
        string group,
        double averageGrade,
        decimal familyIncome,
        List<string> familyMembers,
        Gender gender,
        EducationForm educationForm)
    {
        FullName = fullName;
        Group = group;
        AverageGrade = averageGrade;
        FamilyIncome = familyIncome;
        FamilyMembers = familyMembers;
        Gender = gender;
        EducationForm = educationForm;
    }

    // Метод для вывода информации о студенте
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Ф.И.О. студента: {FullName}");
        Console.WriteLine($"Группа: {Group}");
        Console.WriteLine($"Средний балл: {AverageGrade}");
        Console.WriteLine($"Доход на члена семьи: {FamilyIncome:C}");
        Console.WriteLine($"Состав семьи: {string.Join(", ", FamilyMembers)}");
        Console.WriteLine($"Пол: {Gender}");
        Console.WriteLine($"Форма обучения: {EducationForm}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Пример использования
        List<Student> studentsDatabase = new List<Student>();

        // Заполнение базы данных студентов
        studentsDatabase.Add(new Student(
            "Иванов Иван Иванович",
            "Группа 1",
            4.5,
            15000,
            new List<string> { "Мать", "Отец" },
            Gender.Male,
            EducationForm.FullTime));

        studentsDatabase.Add(new Student(
            "Петрова Анна Сергеевна",
            "Группа 2",
            4.2,
            12000,
            new List<string> { "Мать", "Брат" },
            Gender.Female,
            EducationForm.PartTime));

        // Вывод информации о студентах
        foreach (var student in studentsDatabase)
        {
            student.PrintStudentInfo();
        }
    }
}
