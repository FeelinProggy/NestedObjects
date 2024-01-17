using NestedObjects;

Advisor compSciAdvisor = new()
{
    FullName = "Annemarie Smith",
    Email = "Annemarie@potc.edu",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
    FirstName = "Joe",
    LastName = "Smith",
    SchoolEmail = "joe.smith@cptc.edu",
    DateOfBirth = new DateOnly(1999, 1, 1),
    PhoneNumber = "555-1212",
    AssignedAdvisor = compSciAdvisor
};

Console.WriteLine($"Student: {stu1.FirstName} {stu1.LastName} can be reached at {stu1.SchoolEmail}.");
Console.WriteLine($"Advisor: {stu1.AssignedAdvisor.FullName}.");