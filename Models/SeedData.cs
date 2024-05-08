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
                        },
                        new Worker {
                            UserName = "lodlin0",
                            Password = "lodlin0",
                            FullName = "Lucius Odlin",
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
                        },
                        new Worker {
                            UserName = "idmitr1",
                            Password = "idmitr1",
                            FullName = "Isacco Dmitr",
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
                        },
                        new Worker {
                            UserName = "mpiercy2",
                            Password = "mpiercy2",
                            FullName = "Maren Piercy",
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
                        },
                        new Worker {
                            UserName = "cmccunn3",
                            Password = "Christie McCunn",
                            FullName = "Christie McCunn",
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
                        },
                        new Worker {
                            UserName = "cchippindale4",
                            Password = "cchippindale4",
                            FullName = "Carolina Chippindale",
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
                        },
                        new Worker {
                            UserName = "cjude5",
                            Password = "cjude5",
                            FullName = "Caz Jude",
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
                        },
                        new Worker {
                            UserName = "aspearett6",
                            Password = "aspearett6",
                            FullName = "Austina Spearett",
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
                        },
                        new Worker {
                            UserName = "lminichillo7",
                            Password = "lminichillo7",
                            FullName = "Lenci Minichillo",
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
                        },
                        new Worker {
                            UserName = "dcalvey8",
                            Password = "dcalvey8",
                            FullName = "Debor Calvey",
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
                        },
                        new Worker {
                            UserName = "ebunker9",
                            Password = "ebunker9",
                            FullName = "Elmira Bunker",
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
                        },
                        new Worker {
                            UserName = "jmorbeya",
                            Password = "jmorbeya",
                            FullName = "Jenine Morbey",
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
                        },
                        new Worker {
                            UserName = "kalenshevb",
                            Password = "kalenshevb",
                            FullName = "Kelsy Alenshev",
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
                        },
                        new Worker {
                            UserName = "ckelsoc",
                            Password = "ckelsoc",
                            FullName = "Christiano Kelso",
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
                        },
                        new Worker {
                            UserName = "lguerolad",
                            Password = "lguerolad",
                            FullName = "Lonee Guerola",
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
                        },
                        new Worker {
                            UserName = "nbattricke",
                            Password = "nbattricke",
                            FullName = "Nada Battrick",
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
                        },
                        new Worker {
                            UserName = "aphebeyf",
                            Password = "aphebeyf",
                            FullName = "Alecia Phebey",
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
                        },
                        new Worker {
                            UserName = "acaistorg",
                            Password = "acaistorg",
                            FullName = "Arnie Caistor",
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
                        },
                        new Worker {
                            UserName = "alambourneh",
                            Password = "alambourneh",
                            FullName = "Ashlan Lambourne",
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
                        },
                        new Worker {
                            UserName = "tpepperilli",
                            Password = "tpepperilli",
                            FullName = "Tonya Pepperill",
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
                        },
                        new Worker {
                            UserName = "opirtj",
                            Password = "opirtj",
                            FullName = "Olin Pirt",
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
                        },
                        new Worker {
                            UserName = "mginglellk",
                            Password = "mginglellk",
                            FullName = "Marketa Ginglell",
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
                        },
                        new Worker {
                            UserName = "bpollicottl",
                            Password = "bpollicottl",
                            FullName = "Brynne Pollicott",
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
                        },
                        new Worker {
                            UserName = "mlatheem",
                            Password = "mlatheem",
                            FullName = "Malina Lathee",
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
                        },
                        new Worker {
                            UserName = "ldugalln",
                            Password = "Laurie Dugall",
                            FullName = "Laurie Dugall",
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
                        },
                        new Worker {
                            UserName = "lherniko",
                            Password = "lherniko",
                            FullName = "Lianna Hernik",
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