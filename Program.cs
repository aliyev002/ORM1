using System.Data.SqlClient;
using System.Net;
using Dapper;
using Lesson1Dapper.Models;
using Lesson1Dapper.Models.DTOs;

var conStr = "Data Source=DESKTOP-VKCKL67\\MSSQLSERVER02;Initial Catalog=Employees;Integrated Security=true"; // for windows auth
using var sqlConnection = new SqlConnection(conStr);

//1
//var SqlQuery = "SELECT MAX(PostalCode) FROM employees";

//var max = sqlConnection.ExecuteScalar(SqlQuery);

//Console.WriteLine($"Max from Postal Codes: {max}");


//2
//var SqlQuery = "SELECT FirstName FROM Employees WHERE BusinessEntityID = 101";
//var employee = sqlConnection.QuerySingle(SqlQuery);
//Console.WriteLine($"101st Employee: {employee}");

//3
//var SqlQuery = "select FirstName from Employees where MiddleName ='S'";

//var FirstMidName = sqlConnection.QueryFirst(SqlQuery);
//Console.WriteLine($"1st mid name with s: {FirstMidName}");

//4
var query = "select * from Employees";

//var books = sqlConnection.Query<Book>(query);
var employees = sqlConnection.Query<Book>(query);

foreach (var book in employees)
{
    Console.WriteLine(book.FirstName);
}

//5
//var query = "SELECT FirstName, MiddleName, LastName FROM Employees";

//var result = sqlConnection.Query<BookDto>(query);
//foreach (var i in result)
//{
//    Console.WriteLine(i.Name);
//    Console.WriteLine(i.LastName);
//    Console.WriteLine(i.MiddleName);
//}