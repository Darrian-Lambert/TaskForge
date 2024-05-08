namespace Final.Models {
    public class WorkerTask {
        public int WorkerTaskID { get; set; } // Primary Key
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UID { get; set; }
        public Worker Worker { get; set; } = default!;
    }
}