using Microsoft.EntityFrameworkCore;

namespace Final.Models {
    public static class SeedData {
        public static void initalize(IServiceProvider serviceProvider) {
            using (var context = new FinalDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<FinalDbContext>>())) {
                    if (context.Admins.Any()) {
                        return;
                    }

                    context.Workers.AddRange(
                        new Worker {
                            UserName = "LordOfDiamonds",
                            Password = "Diam0nd",
                            FullName = "Toby Blue",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Polish Diamonds",
                                    Description = "Polish the Diamonds in the display"
                                },
                                new WorkerTask {
                                    Title = "Watch Tv",
                                    Description = "Sit in the display and watch the tv for the event"
                                },
                                new WorkerTask {
                                    Title = "Finish Lunch",
                                    Description = "Prepare Lunch for the event"
                                }
                            }
                        },
                        new Worker {
                            UserName = "Protector",
                            Password = "Shield2024",
                            FullName = "Frank Security",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Finish Filling Forms",
                                    Description = "Fill the paperwork so that payment can be set up"
                                },
                                new WorkerTask {
                                    Title = "Attend Event",
                                    Description = "Serve as security for the event"
                                }
                            }
                        },
                        new Worker {
                            UserName = "DogMan",
                            Password = "W0lfStar",
                            FullName = "Dan Janil",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Clean Door",
                                    Description = "Clean the door of the office"
                                }
                            }
                        },
                        new Worker {
                            UserName = "Earth",
                            Password = "Sun",
                            FullName = "Susan Eight"
                        },
                        new Worker {
                            UserName = "Chef",
                            Password = "SuperC0w",
                            FullName = "Jane Brick",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Accounting",
                                    Description = "Do all accounting work for the store for the past month"
                                },
                                new WorkerTask {
                                    Title = "Host",
                                    Description = "Host the event"
                                },
                                new WorkerTask {
                                    Title = "Remind Admin",
                                    Description = "Remind one of the Admins to assign new tasks for Susan"
                                }
                            }
                        }
                    );
                    context.Admins.AddRange(
                        new Admin {
                            UserName = "Overlord",
                            Password = "0verlordS33sA11",
                            FullName = "Sam Compu"
                        },
                        new Admin {
                            UserName = "Watcher",
                            Password = "R3m3mb3r",
                            FullName = "Kate Zulimi"
                        }
                    );
                    context.SaveChanges();
                }
        }
    }
}