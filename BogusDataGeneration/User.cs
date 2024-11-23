using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusDataGeneration
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(FullName)}: {FullName},{nameof(Email)}: {Email}," +
                $" {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(DateOfBirth)}: {DateOfBirth}, " +
                $"{nameof(Address)}: {Address}";
        }
    }
}
