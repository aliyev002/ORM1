using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Dapper.Models;

internal class Book
{
    public int BusinessEntityID { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Suffix { get; set; }
    public string JobTitle { get; set; }
    public string PhoneNumber { get; set; }
    public string PhoneNumberType { get; set; }
    public string EmailAddress{ get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string StateProvinceName { get; set; }
    public string PostalCode { get; set; }
    public string CountryRegionName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
