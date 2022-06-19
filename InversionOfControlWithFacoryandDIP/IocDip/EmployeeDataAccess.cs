namespace IocDip {
    public class EmployeeDataAccess : IEmployeeDataAccess {
        public Employee GetEmployeeDetails (int Id) {
            return new Employee () {
                Id = 1,
                    Name = "Volkan",
                    Salary = 50,
                    Department = "It"
            };
        }

        public Employee GetEmployeeDetails2 (int Id) =>
            new Employee () {
                Id = 1,
                Name = "Volkan",
                Salary = 50,
                Department = "It"
            };

    }
}