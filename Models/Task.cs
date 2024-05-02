namespace Final.Models {
    public class Task {
        public int TID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UID { get; set; }
        public User? User { get; set; }
    }
}