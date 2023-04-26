
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
        {
            Name = "Mercury",
            Subtitle = "The smallest planet",
            HeroImage = "mercury.png",
            Description = "Mercury is the first of the four terrestrial planets. This means it is a planet made mostly of rock. The planets closest to the Sun—Venus, Earth, and Mars—are the other three.",
            AccentColorStart = Color.FromArgb("#353535"),
            AccentColorEnd = Color.FromArgb("#8d9098"),
            Images = new()
            {
                "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
            }
        },
            new()
        {
            Name = "Venus",
            Subtitle = "The pressure cooker",
            HeroImage = "venus.png",
            Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others.",
            AccentColorStart = Color.FromArgb("#a6393b"),
            AccentColorEnd = Color.FromArgb("#d17f21"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
            }
        },
        new()
        {
            Name = "Earth",
            Subtitle = "The cradle of life",
            HeroImage = "earth.png",
            Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere.",
            AccentColorStart = Color.FromArgb("#0e3d68"),
            AccentColorEnd = Color.FromArgb("#2e97c7"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
            }
        },
        new()
        {
            Name = "Mars",
            Subtitle = "The red beauty",
            HeroImage = "mars.png",
            Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars?",
            AccentColorStart = Color.FromArgb("#a23036"),
            AccentColorEnd = Color.FromArgb("#eb3333"),
            Images = new()
            {
                "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
            }
        },
        new()
        {
            Name = "Jupiter",
            Subtitle = "The gas giant",
            HeroImage = "jupiter.png",
            Description = "The planet Jupiter is the first of the gas giant planets. Made mostly of gas, they include Jupiter, Saturn, Uranus, and Neptune.\n\nJupiter is first among the planets in terms of size and mass. Its diameter is 11 times bigger than Earth, and its mass is 2.5 times greater than all the other planets combined. The “Great Red Spot” on Jupiter is actually a raging storm.",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#cd8026"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
            }
        },
        new()
        {
            Name = "Saturn",
            Subtitle = "The ring planet",
            HeroImage = "saturn.png",
            Description = "Most people know about the rings around Saturn, because they are the brightest and most colorful. These rings are made mainly out of ice particles orbiting the planet. While the rings themselves seem big, the particles are very small, usually no more than 10 feet (3 meters) wide.",
            AccentColorStart = Color.FromArgb("#996237"),
            AccentColorEnd = Color.FromArgb("#c6502f"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
            }
        },
        new()
        {
            Name = "Uranus",
            Subtitle = "The cold ball",
            HeroImage = "uranus.png",
            Description = "Uranus is the first planet so far away from the Earth that it can only be seen with the use of a telescope. When it was first discovered in 1781, scientists didn't know what they had found. As astronomers studied the object more closely, they discovered that it had a circular orbit around the Sun. They had found the seventh planet.",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#996237"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
            }
        },
        new()
        {
            Name = "Neptune",
            Subtitle = "Eighth & fathest-away",
            HeroImage = "neptune.png",
            Description = "Imagine being so good at math that you could figure out the location of a planet you had never even seen! That is what John C. Adams did in 1843 when he discovered Neptune.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
            }
        },
        new()
        {
            Name = "Pluto",
            Subtitle = "The abandoned one",
            HeroImage = "pluto.png",
            Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. There may be millions of these icy objects, collectively referred to as Kuiper Belt objects (KBOs) or trans-Neptunian objects (TNOs), in this distant region of our solar system.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc3dGIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1bb4e43c4ffeb97994ee48daf607bce47f0feb77/BIG_P_COLOR_2_TRUE_COLOR1_1980.jpg?disposition=attachment",
                "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0lEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--bee6b7a89c66eda9b0cbc2845bf0045cd964590c/PIA20038.jpg?disposition=attachment",
                "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBcWdEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--76b09be0e83342cc73b4701d5bf43d22e00c0c35/PIA21590.jpg?disposition=attachment"
            }
        },
        new()
        {
            Name = "Ceres",
            Subtitle = "Magnetodeficient",
            HeroImage = "Ceres.png",
            Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it\'s the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. And when NASA\'s Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fsystem%2Fstellar_items%2Fimage_files%2F704_feature_1600x900_ceres.jpg&tbnid=qbMKS0AbRmukiM&vet=12ahUKEwiBoPiF_Mf-AhWKsSoKHaH4AzwQMygBegUIARDnAQ..i&imgrefurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fplanets%2Fdwarf-planets%2Fceres%2Foverview%2F&docid=lfrj99n0uwsV8M&w=1600&h=900&q=ceres&ved=2ahUKEwiBoPiF_Mf-AhWKsSoKHaH4AzwQMygBegUIARDnAQ",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F7%2F76%2FCeres_-_RC3_-_Haulani_Crater_%252822381131691%2529_%2528cropped%2529.jpg&tbnid=mBsu1wRWhQw2lM&vet=12ahUKEwiBoPiF_Mf-AhWKsSoKHaH4AzwQMygAegUIARDlAQ..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FCeres_(dwarf_planet)&docid=59PvnYnvzANMoM&w=852&h=836&q=ceres&ved=2ahUKEwiBoPiF_Mf-AhWKsSoKHaH4AzwQMygAegUIARDlAQ",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsolarsystem.nasa.gov%2Fplanets%2Fdwarf-planets%2Fceres%2Foverview%2F&psig=AOvVaw2SBPVVNxKiouLeJSgCP3tD&ust=1682613035790000&source=images&cd=vfe&ved=2ahUKEwi0m86T_Mf-AhXQwSoKHT8lChMQjRx6BAgAEAw"
            }
        },
        new()
        {
            Name = "Haumea",
            Subtitle = "The Hawaiian goddess of fertility.",
            HeroImage = "Haumea.png",
            Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fsystem%2Fstellar_items%2Fimage_files%2F723_feature_1600x900_haumea.jpg&tbnid=5U728bOLTMXt8M&vet=12ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygBegUIARDtAQ..i&imgrefurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fplanets%2Fdwarf-planets%2Fhaumea%2Fin-depth%2F&docid=NQxU-LFjiRRYgM&w=1600&h=900&q=haumea&ved=2ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygBegUIARDtAQ",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.sci.news%2Fimages%2Fenlarge10%2Fimage_11303e-Haumea.jpg&tbnid=y_I2eiuS9WcifM&vet=12ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygCegUIARDvAQ..i&imgrefurl=https%3A%2F%2Fwww.sci.news%2Fastronomy%2Fdwarf-planet-haumea-formation-evolution-11303.html&docid=6Z1StCpUaKn41M&w=1500&h=1500&q=haumea&ved=2ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygCegUIARDvAQ",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.wikia.nocookie.net%2Fexpanse%2Fimages%2F1%2F1f%2FHaumea_in_Celestia.jpg%2Frevision%2Flatest%3Fcb%3D20200206143331&tbnid=pXZrI2QC04t43M&vet=12ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygPegUIARCLAg..i&imgrefurl=https%3A%2F%2Fexpanse.fandom.com%2Fwiki%2FHaumea&docid=M3roBp3DqBXvqM&w=850&h=686&q=haumea&ved=2ahUKEwjh--vI_Mf-AhXGyyoKHRfdD7kQMygPegUIARCLAg"
            }
        },
        new()
        {
            Name = "MakeMake",
            Subtitle = "The Rapanui god of fertility",
            HeroImage = "MakeMake.png",
            Description = "Makemake holds an important place in the history of solar system studies because it – along with Eris – was one of the objects whose discovery prompted the International Astronomical Union to reconsider the definition of a planet and to create the new group of dwarf planets.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBcWdEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--76b09be0e83342cc73b4701d5bf43d22e00c0c35/PIA21590.jpg?disposition=attachment",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.universetoday.com%2Fwp-content%2Fuploads%2F2008%2F07%2FMakemake-1280x720.jpg&tbnid=NBqRS4JX-jLcNM&vet=12ahUKEwid1Z-s_cf-AhVStSoKHUjkDP4QMygHegUIARD7AQ..i&imgrefurl=https%3A%2F%2Fwww.universetoday.com%2F15535%2Fnewest-dwarf-planet-and-plutoid-makemake%2F&docid=Ehx8YhPP1YupOM&w=1280&h=720&q=makemake&ved=2ahUKEwid1Z-s_cf-AhVStSoKHUjkDP4QMygHegUIARD7AQ",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fsystem%2Fstellar_items%2Fimage_files%2F705_feature_1600x900_makemake.jpg&tbnid=xBrVqgcLsiWlnM&vet=12ahUKEwid1Z-s_cf-AhVStSoKHUjkDP4QMygMegUIARCFAg..i&imgrefurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fplanets%2Fdwarf-planets%2Fmakemake%2Fin-depth%2F&docid=wWlpDN-xZAsS3M&w=1600&h=900&q=makemake&ved=2ahUKEwid1Z-s_cf-AhVStSoKHUjkDP4QMygMegUIARCFAg"
            }
        },
        new()
        {
            Name = "Eris",
            Subtitle = "Greek Goddess of discord and strife",
            HeroImage = "Eris.png",
            Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBcWdEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--76b09be0e83342cc73b4701d5bf43d22e00c0c35/PIA21590.jpg?disposition=attachment",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Frails%2Factive_storage%2Fblobs%2FeyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBaUFSIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1f24a5d7e143ef1d68416edb76a51ec065c1019c%2Feris_th.jpg%3Fdisposition%3Dattachment&tbnid=siqtE89Zsk1jLM&vet=12ahUKEwj0iaqT_sf-AhXYsCoKHU-ZBIEQMygCegUIARDmAQ..i&imgrefurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fplanets%2Fdwarf-planets%2Feris%2Fin-depth%2F&docid=MBr2Ue7qS7BiEM&w=320&h=240&q=eris&ved=2ahUKEwj0iaqT_sf-AhXYsCoKHU-ZBIEQMygCegUIARDmAQ",
                "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.scienceabc.com%2Fwp-content%2Fuploads%2F2020%2F01%2FEris-dwarf-planet-in-the-outer-spaceLarichs.jpg&tbnid=WxwrB9Lcv8gcDM&vet=12ahUKEwj0iaqT_sf-AhXYsCoKHU-ZBIEQMygGegUIARDuAQ..i&imgrefurl=https%3A%2F%2Fwww.scienceabc.com%2Fnature%2Funiverse%2Fwhat-is-eris.html&docid=bMBTcVhAvB3a7M&w=1000&h=563&q=eris&ved=2ahUKEwj0iaqT_sf-AhXYsCoKHU-ZBIEQMygGegUIARDuAQ"
            }
        }
        };
        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }
        public static List<Planet> GetAllPlanets()
        => planets;

        public static Planet GetPlanet(string planetName)
            => planets.Where(_planet => _planet.Name == planetName).FirstOrDefault();

    }
}
