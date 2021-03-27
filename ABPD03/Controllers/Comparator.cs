using ABPD03.Models;
using System;
using System.Collections.Generic;

namespace ABPD03.Controllers
{    class Comparator : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase.Equals($"{x.fname} {x.lname} {x.indexNumber}", $"{y.fname} {y.lname} {y.indexNumber}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.InvariantCultureIgnoreCase.GetHashCode($"{obj.fname} {obj.lname} {obj.indexNumber}");
        }
    }
}