namespace Final.Models {
    public class Admin {
        public int AdminID {get; set;} // Primary Key
        public string UserName {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;
        public string FullName {get; set;} = string.Empty;
    }
}