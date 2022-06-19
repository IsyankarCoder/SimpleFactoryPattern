namespace IocDip {
    public class DataAccessFactory {
        public static EmployeeDataAccess GetEmployeeDataAccessObj () {
            return new EmployeeDataAccess ();
        }
    }
}