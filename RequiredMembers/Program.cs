using RequiredMembers;


//this now give error because of the required
//var  newStudent = new Student();

Student newStudent = new Student()
{
    Name = "Andropov",
};

Console.WriteLine($" what is your name {newStudent.Name}");


