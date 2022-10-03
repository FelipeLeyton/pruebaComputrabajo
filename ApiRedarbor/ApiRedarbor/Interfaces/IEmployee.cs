using ApiRedarbor.Modelos;

namespace ApiRedarbor.Interfaces
{
    public interface IEmployee
    {
        Response GetEmployees();
        Response GetEmployee(int id);
        Response PostEmployee(Employee employee);
        Response PutEmployee(int id, Employee employee);
        Response DeleteEmployee(int id);
    }
}
