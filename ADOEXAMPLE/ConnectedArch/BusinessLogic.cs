using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleAppWithAdo
{
    internal class BusinessLogic
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        DataTable data;
        public BusinessLogic()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=empdb;Integrated Security=True;Encrypt=False");
            command = new SqlCommand();
            command.Connection = connection;
            connection.Close();
        }
        public bool AddEmployee(Employee emp)
        {
            command.CommandText = $"insert into emp_table values({emp.eid},'{emp.ename}',{emp.esal})";
            connection.Open();
            int res = command.ExecuteNonQuery();
            return res > 0;
        }

        public bool UpdateEmployee(Employee emp)
        {
            command.CommandText = $"update emp_table set ename = '{emp.ename}',esal = {emp.esal} where eid = {emp.eid}";
            connection.Open();
            int res = command.ExecuteNonQuery();
            return res > 0;
        }
        public bool DeleteEmployee(int eid)
        {
            command.CommandText = $"delete from emp_table  where eid = {eid}";
            connection.Open();
            int res = command.ExecuteNonQuery();
            return res > 0;
        }
        public Employee GetEmployee(int eid)
        {
            command.CommandText = $"select * from emp_table where eid = {eid}";
            connection.Open();
            reader = command.ExecuteReader();
            Employee emp = new Employee();
            if (reader.Read())
            {
                emp.eid = Convert.ToInt32(reader[0]);
                emp.ename = reader[1].ToString();
                emp.esal = Convert.ToInt32(reader[2]);
            }
            connection.Close ();
            return emp;
        }
        public List<Employee> GetEmployeeList()
        {
            command.CommandText = "select * from emp_table";
            connection.Open();
            reader = command.ExecuteReader();
            List<Employee> empList = new List<Employee>();
            Employee emp;
            while (reader.Read())
            {
                emp = new Employee();
                emp.eid = Convert.ToInt32(reader[0]);
                emp.ename = reader[1].ToString();
                emp.esal = Convert.ToInt32(reader[2]);
                empList.Add( emp );
            }
            connection.Close ();
            return empList;
            
        }
    }
}
