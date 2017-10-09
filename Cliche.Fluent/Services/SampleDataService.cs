using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Cliche.Fluent.Models;

namespace Cliche.Fluent.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class SampleDataService
    {
        private const string LoremIpsum =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non nisl felis. Cras gravida turpis magna, et pharetra ligula viverra at. Sed nec orci justo. Quisque eu nisi convallis, vulputate enim sed, tincidunt dui. Vivamus ullamcorper ut felis vel viverra. Proin id tortor id ex dignissim facilisis vitae et orci. Mauris tempor massa eu egestas consequat. Pellentesque vitae finibus ligula. Vivamus et pellentesque neque. Nullam at arcu at enim vulputate elementum. Sed in nisl sodales, finibus purus sed, tristique purus. Sed non ullamcorper lectus.\r\nSed fermentum justo nec placerat eleifend.Donec ac quam tellus.Sed nisi nibh, dapibus vel ultricies et, tempus id ligula.Fusce elementum elit ipsum, eget ultricies sem ullamcorper ac.Nunc tempus fringilla facilisis. Vestibulum dolor arcu, finibus eu massa bibendum, faucibus sodales mauris.Fusce maximus, nisi ac porttitor rhoncus, est purus sodales ex, eget consequat libero ante ac nibh. Ut aliquam ultricies purus, ut cursus urna euismod id.Nullam pellentesque purus semper ante lacinia aliquet.Fusce eu posuere dolor. Nunc tincidunt mauris ac efficitur pharetra. Fusce elementum tincidunt nibh, eu facilisis eros.In hac habitasse platea dictumst.Sed non sapien venenatis eros dignissim tincidunt vel in nulla.\r\nUt eget justo felis. Mauris vulputate, odio vitae tempor suscipit, ipsum quam convallis nulla, id aliquam lorem ex sit amet nulla.Morbi risus velit, tincidunt in sagittis et, accumsan nec risus.Sed egestas ipsum sem. Integer consectetur augue eu semper posuere. Pellentesque sit amet iaculis libero.Integer sapien eros, sollicitudin at dui nec, aliquet vehicula ex.Proin auctor sed sapien nec congue. Phasellus venenatis est nec felis iaculis pulvinar."
            ;

        private static IEnumerable<Author> Authors()
        {
            // The following is order summary data
            var data = new ObservableCollection<Author>
            {
                new Author
                {
                    Name = "Benjamin LAUNAY",
                    Description = "Designer UX",
                    Thumbnail=$"ms-appx:///Assets/Images/benjamin.png"
                },
                new Author
                {
                    Name = "Christopher MANEU",
                    Description = "Premier Field Engineer",
                    Thumbnail=$"ms-appx:///Assets/Images/christopher.png"
                },
                new Author
                {
                    Name = "Michaël FERY",
                    Description = "Coach technique .Net",
                    Thumbnail=$"ms-appx:///Assets/Images/michael.jpg"
                }
            };
            return data;
        }

        private static IEnumerable<Character> AllCharacters()
        {
            // The following is order summary data
            var data = new ObservableCollection<Character>
            {
                new Character
                {
                    CharacterId = 0,
                    Name = "FRODON SACQUET",
                    Description = LoremIpsum,
                    DejaVuRatio = 75,
                    Tags = new List<string>() {"élu", "1m15", "hobbit fragile"},
                    Thumbnail=$"ms-appx:///Assets/Picto/perso-(1).jpg",
                    Category = Character.Type.Hero,
                    Movie="Le seigneur des anneaux"
                },
                new Character
                {
                    CharacterId = 1,
                    Name = "MARTY MC FLY",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(2).jpg",
                    Category = Character.Type.Hero,
                    Movie="Retour vers le futur"
                },
                new Character
                {
                    CharacterId = 2,
                    Name = "DANIEL LARUSSO",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(3).jpg",
                    Category = Character.Type.Hero,
                    Movie="Karaté Kid"
                },
                new Character
                {
                    CharacterId = 3,
                    Name = "LUKE SKYWALKER",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(4).jpg",
                    Category = Character.Type.Hero,
                    Movie="Star Wars"
                },
                new Character
                {
                    CharacterId = 4,
                    Name = "ALEX ROGAN",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(5).jpg",
                    Category = Character.Type.Hero,
                    Movie="The last starfighter"
                },
                new Character
                {
                    CharacterId = 5,
                    Name = "HARRY POTTER",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(10).jpg",
                    Category = Character.Type.Hero,
                    Movie="Harry Potter"
                },
                new Character
                {
                    CharacterId = 6,
                    Name = "JAKE SCULLY",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(9).jpg",
                    Category = Character.Type.Hero,
                    Movie="Avatar"
                },
                new Character
                {
                    CharacterId = 7,
                    Name = "NEO",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(8).jpg",
                    Category = Character.Type.Hero,
                    Movie="Matrix"
                },
                new Character
                {
                    CharacterId = 8,
                    Name = "JOHN CONNOR",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(7).jpg",
                    Category = Character.Type.Hero,
                    Movie="Terminator"
                },
                new Character
                {
                    CharacterId = 9,
                    Name = "CONNOR MC LEOD",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(6).jpg",
                    Category = Character.Type.Hero,
                    Movie="Highlander"
                },
                new Character
                {
                    CharacterId = 10,
                    Name = "CLARK KENT",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(11).jpg",
                    Category = Character.Type.Hero,
                    Movie="Superman"
                },
                new Character
                {
                    CharacterId = 11,
                    Name = "SAM WITWICKY",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(12).jpg",
                    Category = Character.Type.Hero,
                    Movie="Transformers"
                },
                new Character
                {
                    CharacterId = 12,
                    Name = "Danny Madigan",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(13).jpg",
                    Category = Character.Type.Hero,
                    Movie="Last Action Hero"
                },
                new Character
                {
                    CharacterId = 13,
                    Name = "Percy Jackson",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {},
                    Thumbnail="ms-appx:///Assets/Picto/perso-(14).jpg",
                    Category = Character.Type.Hero,
                    Movie="Percy Jackson"
                },
                new Character
                {
                    CharacterId = 99,
                    Name = "GANDALF LE GRIS",
                    Description = LoremIpsum,
                    DejaVuRatio = 82,
                    Tags = new List<string>() {"BALROG SLAYER", "MAGNETO"},
                    Thumbnail="ms-appx:///Assets/Images/gandalf.jpg",
                    Category = Character.Type.Mentor,
                    Movie="Le seigneur des anneaux"
                },
            };

            return data;
        }

        private static IEnumerable<Movie> AllMovies()
        {
            // The following is order summary data
            var data = new ObservableCollection<Movie>
            {
                new Movie
                {
                    MovieId = 0,
                    Name = "KARATÉ KID",
                    Subtitle = "le moment de vérité",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 75,
                    Tags = new List<string>() {"BAGARRE", "KARATE"},
                    Poster = "ms-appx:///Assets/Images/karate-kid-affiche.jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(2).jpg"
                },
                new Movie
                {
                    Name = "LE SEIGNEUR DES ANNEAUX",
                    Subtitle = "La communauté de l'anneau",
                    Duration = 75,
                    Description = LoremIpsum + LoremIpsum,
                    Tags = new List<string>() {"COMMUNAUTÉ", "TOLKIEN", "PASSE-PARTOUT"},
                    Poster=$"ms-appx:///Assets/Images/Le_Seigneur_des_Anneaux_La_Communaute_de_l_anneau.jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(3).jpg"
                },
                new Movie
                {
                    Name = "RETOUR VERS LE FUTUR",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 75,
                    Tags = new List<string>() {"PASSÉ", "PRESENT", "FUTUR"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(6).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(4).jpg"
                },
                new Movie
                {
                    Name = "STAR WARS",
                    Subtitle = "Le retour du Jedi",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 134,
                    Tags = new List<string>() {"LUKE", "JE SUIS TON PÈRE"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(10).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(5).jpg"
                },
                new Movie
                {
                    Name = "THE LAST STARFIGHTER",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 86,
                    Tags = new List<string>() {"JEUX VIDEOS", "ESPACE", "PILOTE"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(2).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(6).jpg"
                },
                new Movie
                {
                    Name = "HARRY POTTER",
                    Subtitle = "L'école des sorciers",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 110,
                    Tags = new List<string>() {"POUDLARD", "GERARD MAJAX"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(9).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(11).jpg"
                },
                new Movie
                {
                    Name = "AVATAR",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 132,
                    Tags = new List<string>() {"3D", "SCHTROUMPF"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(1).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(10).jpg"
                },
                new Movie
                {
                    Name = "MATRIX",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 112,
                    Tags = new List<string>() {"REALITÉ VIRTUELLE", "IA", "L'ÉLU"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(7).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(9).jpg"
                },
                new Movie
                {
                    Name = "TERMINATOR",
                    Description = "Description",
                    Duration = 89,
                    Tags = new List<string>() {"IA", "ROBOT", "FUTUR"},
                    Poster=$"ms-appx:///Assets/Picto/filmAffiche-(3).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(8).jpg"
                },
                new Movie
                {
                    Name = "HIGHLANDER",
                    Subtitle = "il n'en restera qu'un",
                    Description = LoremIpsum + LoremIpsum,
                    Duration = 147,
                    Tags = new List<string>() {"MC LEOD", "QUICKENING"},
                    Poster=$"ms-appx:///Assets/Picto/filmThumb-(7).jpg",
                    Thumbnail = "ms-appx:///Assets/Picto/filmThumb-(7).jpg"
                },
            };

            return data;
        }

        public static async Task<IEnumerable<Character>> GetAllCharactersAsync()
        {
            await Task.CompletedTask;

            return AllCharacters();
        }

        public static async Task<IEnumerable<Movie>> GetAllMovies()
        {
            await Task.CompletedTask;

            return AllMovies();
        }

        public static async Task<IEnumerable<Author>> GetAllAuthors()
        {
            await Task.CompletedTask;

            return Authors();
        }
    }
}
