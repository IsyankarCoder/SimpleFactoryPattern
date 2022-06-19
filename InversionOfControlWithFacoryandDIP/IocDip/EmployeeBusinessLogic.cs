namespace IocDip {
    public class EmployeeBusinessLogic {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic (IEmployeeDataAccess EmployeeDataAccess) {
            this._EmployeeDataAccess = EmployeeDataAccess;
            // _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj ();
        }

        public Employee GetEmployeeDetails (int id) {
            return _EmployeeDataAccess.GetEmployeeDetails (id);
        }

    }
}