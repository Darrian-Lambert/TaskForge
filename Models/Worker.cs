//I changed the name to Worker and WorkerTask because both User and Task was having naming conflict issues

namespace Final.Models {
    public class Worker {
        public int WorkerID { get; set; } // Primary Key
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public List<WorkerTask> WorkerTasks { get; set; } = new List<WorkerTask>();
    }
}