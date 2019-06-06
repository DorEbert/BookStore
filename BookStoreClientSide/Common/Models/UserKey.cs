namespace Common.Models
{
    public class UserKey
    {
        public string smartspace { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "UserKey [smartspace=" + smartspace + ", email=" + email + "]";
        }
    }

}