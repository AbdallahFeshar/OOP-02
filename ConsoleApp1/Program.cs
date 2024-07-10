namespace ConsoleApp1
{
    internal class Program
    {
        #region 01
        //public class Employee
        //{
        //    public int EmpId { get; set; }
        //    public string Name { get; set; }
        //    public int SecurityLevel { get; set; }
        //    public decimal Salary { get; set; }
        //    public DateTime HireDate { get; set; }
        //    public string Gender { get; set; }

        //    public Employee(int empId, string name, int securityLevel, decimal salary, DateTime hireDate, string gender)
        //    {
        //        EmpId = empId;
        //        Name = name;
        //        SecurityLevel = securityLevel;
        //        Salary = salary;
        //        HireDate = hireDate;
        //        Gender = gender;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Employee[ID={EmpId}, Name={Name}, Security Level={SecurityLevel}, Salary=${Salary}, Hire Date={HireDate.ToShortDateString()}, Gender={Gender}]";
        //    }

        //    public void RaiseSalary(decimal amount)
        //    {
        //        Salary += amount;
        //    }

        //    public void ChangeSecurityLevel(int newLevel)
        //    {
        //        SecurityLevel = newLevel;
        //    }
        //}
        #endregion


        #region 02
        //public class HiringDate
        //{
        //    public int Day { get; set; }
        //    public int Month { get; set; }
        //    public int Year { get; set; }

        //    public HiringDate(int day, int month, int year)
        //    {
        //        Day = day;
        //        Month = month;
        //        Year = year;
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Day:D2}/{Month:D2}/{Year}";
        //    }
        //}

        #endregion

        #region 03

        //public enum Gender
        //{
        //    M,
        //    F
        //}

        //public class Person
        //{
        //    private Gender _gender;

        //    public Gender Gender
        //    {
        //        get { return _gender; }
        //        set
        //        {
        //            if (!Enum.IsDefined(typeof(Gender), value))
        //            {
        //                throw new ArgumentException("Invalid gender value. Only 'M' or 'F' are allowed.");
        //            }
        //            _gender = value;
        //        }
        //    }

        //    public string Name { get; set; }

        //    public Person(string name, Gender gender)
        //    {
        //        Name = name;
        //        Gender = gender; // This will use the property setter and perform validation
        //    }
        //}

        #endregion

        #region 04

        //[Flags]
        //public enum SecurityPrivileges
        //{

        //    Guest = 1,
        //    Developer = 2,
        //    Secretary =  4,
        //    DBA =8
        //}

        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public SecurityPrivileges Privileges { get; set; }

        //    public Employee(string name, SecurityPrivileges privileges)
        //    {
        //        Name = name;
        //        Privileges = privileges;
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name} has the following privileges: {Privileges}";
        //    }
        //}

        #endregion

        #region 05

        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public int Id { get; set; }
        //    public decimal Salary { get; set; }

        //    public Employee(string name, int id, decimal salary)
        //    {
        //        Name = name;
        //        Id = id;
        //        Salary = salary;
        //    }

        //    public override string ToString()
        //    {
        //        return String.Format("Employee Name: {0}, ID: {1}, Salary: {2:C}", Name, Id, Salary);
        //    }
        //}


        #endregion

        #region 06
        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public string Role { get; set; }
        //    public string Permissions { get; set; }

        //    public Employee(string name, string role, string permissions)
        //    {
        //        Name = name;
        //        Role = role;
        //        Permissions = permissions;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Name: {Name}, Role: {Role}, Permissions: {Permissions}";
        //    }
        //}

        #endregion
        static void Main(string[] args)
        {
            #region 01
            //Employee emp1 = new Employee(1, "Ali", 5, 70000m, new DateTime(2024, 7, 5), "male");
            //Console.WriteLine(emp1);
            //emp1.RaiseSalary(5000m);
            //emp1.ChangeSecurityLevel(7);
            //Console.WriteLine(emp1);
            #endregion

            #region 02
            //HiringDate hireDate = new HiringDate(5, 7, 2024);
            //Console.WriteLine(hireDate);
            #endregion

            #region 03
            //Person person1 = new Person("Abdallah", Gender.M);
            //Console.WriteLine($"{person1.Name}'s gender is {person1.Gender}");

            //Person person2 = new Person("Salma", Gender.F);
            //Console.WriteLine($"{person2.Name}'s gender is {person2.Gender}");

            #endregion

            #region 04
            //Employee employee1 = new Employee("Ali", SecurityPrivileges.Guest);
            //Employee employee2 = new Employee("mohamed", SecurityPrivileges.Developer);
            //Employee employee3 = new Employee("asam", SecurityPrivileges.Secretary);
            //Employee employee4 = new Employee("loka", SecurityPrivileges.DBA);
            //Employee employee5 = new Employee("CR7", SecurityPrivileges.Developer | SecurityPrivileges.DBA);

            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);
            //Console.WriteLine(employee3);
            //Console.WriteLine(employee4);
            //Console.WriteLine(employee5);
            #endregion

            #region 05
            //Employee employee = new Employee("Ali, 12345, 65000.50m);
            //Console.WriteLine(employee.ToString());

            #endregion

            #region 06

            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee("Ali", "DBA", "Read, Write, Execute");
            //EmpArr[1] = new Employee("kareem", "Guest", "Read");
            //EmpArr[2] = new Employee("Barkat", "Security Officer", "Full Permissions");

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion
        }
    }
}
