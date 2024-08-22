using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Dapper.Models.DTOs;

internal record BookDto
{
    public string Name { get; }
    public string MiddleName { get; }
    public string LastName { get; }
}
