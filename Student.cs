//Create and initialize the collections:
using OOPTask6B;

AllStudents allStudents = new AllStudents();

AllUserNames allUserNames = new AllUserNames();

//Joe has forgotten the passwork. Find it
List<Result> results1 = allUserNames.FindPassword(allUserNames, allStudents, "Joe");

if (results1.Count() > 0)
    foreach (var item in results1)
    {
        Console.WriteLine("Student name: {0}, username: {1}, password: {2}",
            item.Studentname, item.Username, item.Password);
    }
else
    Console.WriteLine("No hit was found.");



//Whose username is "morning..."
List<Result> results2 = allStudents.FindStudent(allUserNames, allStudents, "morning");

if (results2.Count() > 0)
    foreach (var item in results2)
    {
        Console.WriteLine("Student name: {0}, username: {1}, password: {2}",
            item.Studentname, item.Username, item.Password);
    }
else
    Console.WriteLine("No hit was found.");
