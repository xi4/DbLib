using System;
namespace DbLib.Models
{
    public class Login
    {
        public string errMessage { get; set; }
        public User user { get; set; }
        public string token { get; set; }
        public bool error { get; set; }
    }
    public class RoleU
    {
        public int Id { get; set; }
        public string txt { get; set; }
        public bool state { get; set; }
    }
}
