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
                            Password = "Sunshine2022!",
                            FullName = "Lucius Odlin",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Research Market Trends",
                                    Description = "Investigate current market trends in our industry to identify opportunities for growth."
                                }
                            }
                        },
                        new Worker {
                            UserName = "idmitr1",
                            Password = "PurpleRain$567",
                            FullName = "Isacco Dmitr",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Update Website Content",
                                    Description = "Review and update website content to ensure accuracy and relevance."
                                }
                            }
                        },
                        new Worker {
                            UserName = "mpiercy2",
                            Password = "ChocolateDreams#88",
                            FullName = "Maren Piercy",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Create Social Media Calendar",
                                    Description = " Develop a social media calendar outlining content and posting schedule for the next month."
                                }
                            }
                        },
                        new Worker {
                            UserName = "cmccunn3",
                            Password = "SoccerStar!21",
                            FullName = "Christie McCunn",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Conduct Customer Surveys",
                                    Description = "Design and distribute customer surveys to gather feedback on our products and services."
                                },
                                new WorkerTask {
                                    Title = "Organize Team Training",
                                    Description = "Coordinate training sessions for team members to enhance skills and knowledge."
                                }
                            }
                        },
                        new Worker {
                            UserName = "cchippindale4",
                            Password = "BeachBreeze$123",
                            FullName = "Carolina Chippindale"
                        },
                        new Worker {
                            UserName = "cjude5",
                            Password = "SecretGarden@99",
                            FullName = "Caz Jude",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Analyze Competitor Strategies",
                                    Description = "Analyze competitor strategies to identify areas where we can improve and differentiate ourselves."
                                }
                            }
                        },
                        new Worker {
                            UserName = "aspearett6",
                            Password = "MountainView#22",
                            FullName = "Austina Spearett",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Optimize Email Campaigns",
                                    Description = "Review and optimize email marketing campaigns to improve engagement and conversion rates."
                                }
                            }
                        },
                        new Worker {
                            UserName = "lminichillo7",
                            Password = "HappyDay$2022",
                            FullName = "Lenci Minichillo",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Draft Blog Posts",
                                    Description = "Write engaging blog posts on industry-related topics to attract and engage our audience."
                                }
                            }
                        },
                        new Worker {
                            UserName = "dcalvey8",
                            Password = "StarlightSky!333",
                            FullName = "Debor Calvey"
                        },
                        new Worker {
                            UserName = "ebunker9",
                            Password = "OceanWave@777",
                            FullName = "Elmira Bunker"
                        },
                        new Worker {
                            UserName = "jmorbeya",
                            Password = "AdventureTime$55",
                            FullName = "Jenine Morbey",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Plan Product Launch",
                                    Description = "Develop a comprehensive plan for an upcoming product launch, including marketing strategies and timelines."
                                },
                                new WorkerTask {
                                    Title = "Create Promotional Materials",
                                    Description = "Design promotional materials such as flyers, brochures, and banners for upcoming events or promotions."
                                }
                            }
                        },
                        new Worker {
                            UserName = "kalenshevb",
                            Password = "LovelyDay#123",
                            FullName = "Kelsy Alenshev",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Conduct Product Testing",
                                    Description = "Coordinate product testing sessions with target customers to gather feedback and identify areas for improvement."
                                },
                                new WorkerTask {
                                    Title = "Implement SEO Strategies",
                                    Description = "Optimize website content and structure to improve search engine rankings and drive organic traffic."
                                }
                            }
                        },
                        new Worker {
                            UserName = "ckelsoc",
                            Password = "PeacefulNight!89",
                            FullName = "Christiano Kelso",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Evaluate Customer Service",
                                    Description = "Evaluate current customer service processes and identify opportunities for improvement."
                                },
                                new WorkerTask {
                                    Title = "Streamline Order Fulfillment",
                                    Description = "Review order fulfillment processes and implement measures to streamline operations and reduce errors."
                                },
                                new WorkerTask {
                                    Title = "Develop Content Calendar",
                                    Description = "Create a content calendar for blog posts, social media posts, and email newsletters for the next quarter."
                                }
                            }
                        },
                        new Worker {
                            UserName = "lguerolad",
                            Password = "DreamCatcher@444",
                            FullName = "Lonee Guerola"
                        },
                        new Worker {
                            UserName = "nbattricke",
                            Password = "MagicForest$2022",
                            FullName = "Nada Battrick",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Monitor Online Reviews",
                                    Description = "Monitor online review platforms to track customer feedback and address any issues or concerns."
                                }
                            }
                        },
                        new Worker {
                            UserName = "aphebeyf",
                            Password = "SummerBreeze#77",
                            FullName = "Alecia Phebey",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Research New Suppliers",
                                    Description = "Research and evaluate potential new suppliers to ensure quality and reliability."
                                }
                            }
                        },
                        new Worker {
                            UserName = "acaistorg",
                            Password = "RainbowDreams!66",
                            FullName = "Arnie Caistor"
                        },
                        new Worker {
                            UserName = "alambourneh",
                            Password = "SunnyDay@1234",
                            FullName = "Ashlan Lambourne"
                        },
                        new Worker {
                            UserName = "tpepperilli",
                            Password = "MoonlightMagic$11",
                            FullName = "Tonya Pepperill",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Create Training Manuals",
                                    Description = "Develop training manuals and resources for new hires to facilitate onboarding and skill development."
                                },
                                new WorkerTask {
                                    Title = "Optimize PPC Campaigns",
                                    Description = "Review and optimize pay-per-click advertising campaigns to maximize ROI and reach target audiences."
                                }
                            }
                        },
                        new Worker {
                            UserName = "opirtj",
                            Password = "ButterflyWings#999",
                            FullName = "Olin Pirt",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Update Product Documentation",
                                    Description = "Revise and update product documentation to ensure accuracy and clarity for customers."
                                }
                            }
                        },
                        new Worker {
                            UserName = "mginglellk",
                            Password = "SweetMemories!2022",
                            FullName = "Marketa Ginglell",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Develop Customer Loyalty Program",
                                    Description = "Design a customer loyalty program to reward repeat purchases and encourage customer retention."
                                },
                                new WorkerTask {
                                    Title = "Analyze Financial Performance",
                                    Description = "Review financial statements and performance metrics to assess the company's financial health and identify areas for improvement."
                                }
                            }
                        },
                        new Worker {
                            UserName = "bpollicottl",
                            Password = "WhisperingWinds@88",
                            FullName = "Brynne Pollicott",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Conduct Market Research",
                                    Description = "Conduct market research to identify new opportunities and emerging trends in the industry."
                                }
                            }
                        },
                        new Worker {
                            UserName = "mlatheem",
                            Password = "DancingFlowers$777",
                            FullName = "Malina Lathee",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Implement Email Automation",
                                    Description = "Set up email automation workflows to deliver targeted and personalized communications to customers."
                                },
                                new WorkerTask {
                                    Title = "Improve Website Navigation",
                                    Description = " Enhance website navigation and user experience to make it easier for visitors to find information and make purchases."
                                },
                                new WorkerTask {
                                    Title = "Create Video Tutorials",
                                    Description = "Produce instructional video tutorials to demonstrate product features and provide support to customers."
                                }
                            }
                        },
                        new Worker {
                            UserName = "ldugalln",
                            Password = "TwilightZone#55",
                            FullName = "Laurie Dugall",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Develop Sales Collateral",
                                    Description = "Create sales collateral such as presentations, case studies, and sales scripts to support the sales team."
                                }
                            }
                        },
                        new Worker {
                            UserName = "lherniko",
                            Password = "EnchantedForest!333",
                            FullName = "Lianna Hernik",
                            WorkerTasks = new List<WorkerTask> {
                                new WorkerTask {
                                    Title = "Optimize Supply Chain",
                                    Description = " Evaluate and optimize the supply chain to reduce costs, improve efficiency, and ensure timely delivery of products."
                                },
                                new WorkerTask {
                                    Title = "Monitor Social Media Engagement",
                                    Description = "Track social media engagement metrics and respond to comments and messages from followers."
                                },
                                new WorkerTask {
                                    Title = "Review Customer Feedback",
                                    Description = "Review customer feedback and testimonials to identify areas of strength and areas for improvement."
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