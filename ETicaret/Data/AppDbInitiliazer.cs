using ETicaret.Models;

namespace ETicaret.Data
{
    public class AppDbInitiliazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                _ = context.Database.EnsureCreated();


                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>
                    {
                        new Actor
                        {
                            FullName = "Actor 1",
                            ProfilePictureUrl= "https://d.neoldu.com/gallery/1863_1.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 2",
                            ProfilePictureUrl= "https://im.haberturk.com/galeri/2013/07/18/ver1374138619/429440/c21b5a8eeeab146cd39b02d265eb473b_k.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 3",
                            ProfilePictureUrl= "https://i.cnnturk.com/i/cnnturk/75/0x555/5614389d496783211c180768",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 4",
                            ProfilePictureUrl= "https://i4.hurimg.com/i/hurriyet/75/866x494/5d79011545d2a023a0d6da63.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 5",
                            ProfilePictureUrl= "https://cdn1.ntv.com.tr/gorsel/TL9EolV1S0ikO8Jad1u17g.jpg?width=1000&mode=crop&scale=both",
                            Bio = "Actor 1 biyografisi "
                        }
                    });
                }

                context.SaveChanges();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>
                    {
                        new Cinema
                        {
                            Name = "Cinema 1",
                            Logo = "https://cdn.odatv4.com/images/2022_10/2022_10_17/odatv_image_87__927e7279ad6a4b.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 2",
                            Logo = "http://ozdemirpark.com/wp-content/uploads/2016/08/Avsar-Sinema-1.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 3",
                            Logo = "https://agorasinemalari.com/assets/images/agora-izmir.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 4",
                            Logo = "https://antalyacityzone.com/images/cityguideplaces/antalya-erasta-aksin-sinemalari/sinema1578985430.jpg",
                            Description = "Sinema hakkında bilgi"
                        }

                    });
                }

                context.SaveChanges();

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>
                    {
                        new Producer
                        {
                            FullName = "Producer 1",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://cdn.britannica.com/81/220481-050-55413025/Quentin-Tarantino-2020.jpg"
                        },
                        new Producer
                        {
                            FullName = "Producer 2",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://flxt.tmsimg.com/assets/74068_v9_bb.jpg"
                        },
                        new Producer
                        {
                            FullName = "Producer 3",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ab/Festival_de_cinema_de_Sitges_2018_%2831305141408%29_%28cropped4%29.jpg"
                        }

                    });
                }

                context.SaveChanges();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    {
                        new Movie
                        {
                            Name = "Movie 1",
                            Description = "Movie hakkında bilgi",
                            Price = 10,
                            ImageUrl = "https://tr.web.img3.acsta.net/pictures/bzp/03/4063.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 1006,
                            ProducerId=1007,
                            MovieCategory = Enum.MovieCategory.Action
                        },
                        new Movie
                        {
                            Name = "Movie 2",
                            Description = "Movie hakkında bilgi",
                            Price = 20,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(7),
                            EndDate= DateTime.Now.AddDays(14),
                            CinemaId = 1007,
                             ProducerId=1007,
                            MovieCategory = Enum.MovieCategory.Horror
                        },new Movie
                        {
                            Name = "Movie 3",
                            Description = "Movie hakkında bilgi",
                            Price = 50,
                            ImageUrl = "https://tr.web.img4.acsta.net/pictures/22/09/26/14/06/5474398.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(14),
                            CinemaId = 1008,
                            ProducerId=1007,
                            MovieCategory = Enum.MovieCategory.Documentary
                        },new Movie
                        {
                            Name = "Movie 4",
                            Description = "Movie hakkında bilgi",
                            Price = 100,
                            ImageUrl = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/8AB1525C077AD6579FB1F0EBEC477B5531DF466FB9705BA36C7FF84A56E8FD16/scale?width=1200&aspectRatio=1.78&format=jpeg",
                            StartDate = DateTime.Now.AddMonths(1),
                            EndDate= DateTime.Now.AddMonths(1).AddDays(7),
                            CinemaId = 1009,
                            ProducerId = 1006,
                            MovieCategory = Enum.MovieCategory.Comedy
                        },new Movie
                        {
                            Name = "Movie 5",
                            Description = "Movie hakkında bilgi",
                            Price = 10,
                            ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001784668001-1.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 1006,
                            ProducerId=1005,
                            MovieCategory = Enum.MovieCategory.Drama
                        },new Movie
                        {
                            Name = "Movie 6",
                            Description = "Movie hakkında bilgi",
                            Price = 10,
                            ImageUrl = "https://www.tampabay.com/resizer/F7MU44mlGIH5xaPKO0Zg8Y_6vGA=/1200x675/smart/cloudfront-us-east-1.images.arcpublishing.com/tbt/LEHNEUGHAQI6TBKNIBWI6S7HAY.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 1007,
                            ProducerId = 1007,
                            MovieCategory = Enum.MovieCategory.Action
                        },new Movie
                        {
                            Name = "Movie 7",
                            Description = "Movie hakkında bilgi",
                            Price = 10,
                            ImageUrl = "https://images.justwatch.com/poster/265835203/s592/yesil-yol",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 1008,
                            ProducerId=1006,
                            MovieCategory = Enum.MovieCategory.Documentary
                        }
                        ,new Movie
                        {
                            Name = "Movie 8",
                            Description = "Ne Olacak Şimdi",
                            Price = 10,
                            ImageUrl = "https://i.ytimg.com/vi/nz9Z7Et_bbk/maxresdefault.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 1009,
                            ProducerId=1005,
                            MovieCategory = Enum.MovieCategory.Documentary
                        }

                    });
                }

                context.SaveChanges();

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>
                    {
                        new Actor_Movie
                        {
                           ActorId = 1007,
                           MovieId = 5
                        },
                        new Actor_Movie
                        {
                           ActorId = 1008,
                           MovieId = 5
                        },
                        new Actor_Movie
                        {
                           ActorId = 1009,
                           MovieId = 5
                        },
                        new Actor_Movie
                        {
                           ActorId = 1010,
                           MovieId = 6
                        },
                        new Actor_Movie
                        {
                           ActorId = 1011,
                           MovieId = 6
                        },
                        new Actor_Movie
                        {
                           ActorId = 1007,
                           MovieId = 7
                        },
                        new Actor_Movie
                        {
                           ActorId = 1008,
                           MovieId = 7
                        },
                        new Actor_Movie
                        {
                           ActorId = 1009,
                           MovieId = 8
                        },
                        new Actor_Movie
                        {
                           ActorId = 1010,
                           MovieId = 8
                        },
                        new Actor_Movie
                        {
                           ActorId = 1011,
                           MovieId = 9
                        },
                        new Actor_Movie
                        {
                           ActorId = 1007,
                           MovieId = 9
                        },
                        new Actor_Movie
                        {
                           ActorId = 1008,
                           MovieId = 10
                        },
                        new Actor_Movie
                        {
                           ActorId = 1009,
                           MovieId = 10
                        },new Actor_Movie
                        {
                           ActorId = 1010,
                           MovieId = 11
                        },
                        new Actor_Movie
                        {
                           ActorId = 1011,
                           MovieId = 11
                        },
                        new Actor_Movie
                        {
                           ActorId = 1007,
                           MovieId = 12
                        },
                        new Actor_Movie
                        {
                           ActorId = 1008,
                           MovieId = 12
                        }
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
