using System;

public class Computer
{
    public string CPU { get; private set; }
    public string GPU { get; private set; }
    public int RAM { get; private set; }

    private Computer() { }

    public class Builder
    {
        private string cpu;
        private string gpu;
        private int ram;

        public Builder SetCPU(string cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public Builder SetGPU(string gpu)
        {
            this.gpu = gpu;
            return this;
        }

        public Builder SetRAM(int ram)
        {
            this.ram = ram;
            return this;
        }

        public Computer Build()
        {
            return new Computer
            {
                CPU = this.cpu,
                GPU = this.gpu,
                RAM = this.ram
            };
        }
    }
}

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    private Student() { }

    public class Builder
    {
        private string firstName;
        private string lastName;
        private int age;

        public Builder SetFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public Builder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public Student Build()
        {
            return new Student
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                Age = this.age,
            };
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student student = new Student.Builder()
                            .SetFirstName("Norbert")
                            .SetLastName("Pytel")
                            .SetAge(23)
                            .Build();
        Console.WriteLine($"Student: Imię={student.FirstName}, Nazwisko={student.LastName}, Wiek={student.Age}");

        Computer computer = new Computer.Builder()
                            .SetCPU("AMD RYZEN 1600")
                            .SetRAM(16)
                            .Build();
        Console.WriteLine($"Komputer: CPU={computer.CPU}, GPU={computer.GPU}, RAM={computer.RAM}GB");
    }
}