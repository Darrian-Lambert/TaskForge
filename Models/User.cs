namespace Final.Models {
    public class User {
        public int UserID { get; set; } // Primary Key
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}