using API.Entities;

namespace API.Data
{
    public static class Dbinitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var sizes = GenerateSizes(36.5f, 46f, 0.5f);

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Air Jordan 1 Retro High OG 'Chicago Lost & Found'",
                    Description = "The Air Jordan 1 Retro High OG 'Chicago Lost & Found' is a sneaker that pays homage to the original Air Jordan 1 'Chicago' colorway from 1985. The shoe features a red, white and black leather upper with a vintage-inspired finish that mimics the aging of a pair of sneakers that were lost in a warehouse for decades. The shoe also has a mismatched box lid that references the old inventory system that often led to errors and confusion. The Air Jordan 1 Retro High OG 'Chicago Lost & Found' is a limited edition release that celebrates the history and legacy of Michael Jordan's first signature shoe and his iconic rookie season with the Chicago Bulls.",
                    Price = 200000,
                    PictureUrl = "/images/products/Air Jordan 1 Retro High OG Chicago lost & found.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 11, 20),
                    Condition = "Brand new",
                    Style = "DZ5485-612"
                },
                new Product
                {
                    Name = "Jordan 1 low Travis Scott 'Black Phantom'",
                    Description = "The Air Jordan 1 Low x Travis Scott Black Phantom is a collaboration between the rapper and the iconic sneaker brand that was released in December 2022. The shoe features a black nubuck upper with a reverse Nike Swoosh on the lateral side and a contrast stitch design on the medial side. The shoe also has a Nike Air logo on the tongue, an Air Jordan Wings logo on the right heel tab, and an embroidered Bee on the left heel tab inspired by Travis' daughter, Stormi. The shoe comes with two black bandanas, red laces, black and white laces, and a black Cactus Jack box sleeve. The shoe retails is one of the most sought-after sneakers of 2022.",
                    Price = 310000,
                    PictureUrl = "/images/products/Jordan 1 low Travis Scott Black Phantom.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "42.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 12, 16),
                    Condition = "Brand  new",
                    Style = "DM7866-001"
                },
                new Product
                {
                    Name = "Jordan 1 low 'Cherrywood Red'",
                    Description = "The Air Jordan 1 Low 'Cherrywood Red' is a new colorway of the iconic sneaker that debuted in 1985. The low-top version of the Air Jordan 1 features a cherrywood red leather upper with white accents on the Swoosh, tongue and heel. The midsole is cement grey, while the outsole is cherrywood red. The shoe also has the signature Air technology in the heel for cushioning and comfort. The Air Jordan 1 Low 'Cherrywood Red' is a versatile and stylish sneaker that can complement any outfit.",
                    Price = 70000,
                    PictureUrl = "/images/products/Jordan 1 low cherrywood red.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "44.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 11, 16),
                    Condition = "Brand  new",
                    Style = "553558-615"
                },
                new Product
                {
                    Name = "Jordan 1 Mid 'Reverse Yellow Toe'",
                    Description ="The Air Jordan 1 Mid 'Reverse Yellow Toe' is a vibrant colorway of the classic basketball sneaker that draws inspiration from the original 'Yellow Toe' released in 2018. This version features a yellow leather upper with black overlays and a white Swoosh on the sides. The mid-top silhouette also has a black nylon tongue, a white Jumpman logo on the tongue tag, and a white Wings logo on the collar. The Air Jordan 1 Mid 'Reverse Yellow Toe' sits on a white midsole and a yellow rubber outsole that provides traction and durability.",
                    Price = 80000,
                    PictureUrl = "/images/products/Jordan 1 mid reverse yellow toe.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "43" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 08, 20),
                    Condition = "Brand  new",
                    Style = "554724-701"
                },
                new Product
                {
                    Name = "Jordan 1 low 'New Emerald' (W)",
                    Description ="The Jordan 1 Low New Emerald (W) is a women's sneaker that features a unique color scheme inspired by the turbo green of 2019. The shoe has a white suede upper with a polished leather layer in light green, creating a contrast between textures and shades. The outsole and the Jumpman logos on the tongue and heel are light gray with gold accents, adding some elegance and flair to the design. The sneaker is a low-top version of the iconic Air Jordan 1 High, which debuted in 1985 and revolutionized the basketball shoe industry. The Jordan 1 Low New Emerald (W) is a stylish and comfortable option for women who love the classic silhouette and want to stand out with a fresh and vibrant colorway.",
                    Price = 70000,
                    PictureUrl = "/images/products/Jordan 1 low new emerald (w).webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "39" }, new Size { Value = "40" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 08, 06),
                    Condition = "Brand  new",
                    Style = "DC0774-132"
                },
                new Product
                {
                    Name = "Jordan 1 low 'Marina Blue' (W)",
                    Description ="The Jordan 1 Low Marina Blue (W) is a women's exclusive sneaker that features a classic colorway and a low-top silhouette. The shoe is inspired by the original Air Jordan 1 that debuted in 1985 and changed the game of basketball and fashion. The shoe has a smooth white leather upper with Marina Blue overlays and Swooshes on the sides. The heel has an embroidered Jordan Wings logo that pays homage to the high-top collar of the first Air Jordan 1. The shoe also has a white and Marina Blue Air sole unit that provides cushioning and comfort. The Jordan 1 Low Marina Blue (W) is a must-have for fans of the Jordan brand and the iconic Air Jordan 1 model.",
                    Price = 70000,
                    PictureUrl = "/images/products/Jordan 1 low marina blue (w).webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "39" }, new Size { Value = "38" }, new Size { Value = "37.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 01, 29),
                    Condition = "Brand  new",
                    Style = "DC0774-114"
                },
                new Product
                {
                    Name = "Jordan 1 low Travis Scott 'Reverse Mocha'",
                    Price = 520000,
                    PictureUrl = "/images/products/Jordan 1 low travis scott reverse mocha.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 07, 21),
                    Condition = "Brand  new",
                    Style = "DM7866-162"
                },
                new Product
                {
                    Name = "Jordan 1 high 'Bordeaux'",
                    Price = 100000,
                    PictureUrl = "/images/products/Jordan 1 high bordeaux.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "45" }, new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 11 , 20),
                    Condition = "Brand  new",
                    Style = "555088-611"
                },
                new Product
                {
                    Name = "Jordan 1 low 'Starfish'",
                    Description = "The Air Jordan 1 Low Starfish is a sneaker that pays homage to one of Michael Jordan's most iconic moments: the shattered backboard. In 1985, during an exhibition game in Italy, Jordan dunked so hard that he broke the glass of the hoop. The sneaker's colorway reflects the orange and black jersey that Jordan wore that day, contrasted with a white leather base. The low-top version of the Air Jordan 1 features a classic silhouette with a Nike Air logo on the tongue and a Jordan Wings logo on the heel. The Air Jordan 1 Low Starfish is a must-have for fans of MJ and his legacy.",
                    Price = 115000,
                    PictureUrl = "/images/products/Jordan 1 low starfish.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size>{new Size { Value = "42.5" }, new Size { Value = "43" }, new Size { Value = "44" }},
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 08 , 26),
                    Condition = "Brand  new",
                    Style = "CZ0790-801"
                },
                new Product
                {
                    Name = "Jordan 1 Low 'UNC'",
                    Price = 100000,
                    PictureUrl = "/images/products/Jordan 1 low unc.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "45.5" }, new Size { Value = "44" }, new Size { Value = "44.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 07 , 29),
                    Condition = "Brand  new",
                    Style = "CZ0790-104"
                },
                new Product
                {
                    Name = "Jordan 1 High 'Atmosphere'",
                    Description = "The Air Jordan 1 High 'Atmosphere' is a women's exclusive sneaker that combines classic style with a modern twist. The shoe features a white and obsidian leather base with laser pink patent leather accents on the toe box and collar. The pink color is inspired by the bubblegum that Michael Jordan used to chew during his games. The shoe also comes with a pink leather hangtag that adds a touch of flair. The Air Jordan 1 High 'Atmosphere' is a must-have for fans of the iconic silhouette and the legendary basketball player.",
                    Price = 100000,
                    PictureUrl = "/images/products/Jordan 1 high atmosphere.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "37" }, new Size { Value = "38.5" }, new Size { Value = "39" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 12 , 22),
                    Condition = "Brand  new",
                    Style = "DD9335-641"
                },
                new Product
                {
                    Name = "Jordan 1 Low 'Bred Toe'",
                    Description = "The Air Jordan 1 Low 'Bred Toe' is a new colorway of the iconic sneaker that draws inspiration from a previous high-top version. The shoe features a classic combination of white, black, and red leather on the upper, with a red toe box and heel that contrast with the black Swoosh and forefoot. The shoe also has a white midsole and a red outsole, as well as an embroidered Wings logo on the heel and a Jumpman logo on the tongue. The Air Jordan 1 Low 'Bred Toe' is a must-have for fans of the original Air Jordan 1.",
                    Price = 70000,
                    PictureUrl = "/images/products/Jordan 1 low bred toe.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "45" }, new Size { Value = "41" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 12 , 08),
                    Condition = "Brand  new",
                    Style = "553558-612"
                },
                new Product
                {
                    Name = "Jordan 1 low 'Shadow Toe'",
                    Description = "The Air Jordan 1 Low 'Shadow Toe' is a new variation of the iconic sneaker that combines elements of the original 'Shadow' and 'Bred Toe' colorways. The shoe features a white leather base with black leather overlays on the toe box, eyelets, Swooshes, and heel. The Light Smoke Grey hue adds a subtle contrast on the collar, heel tab, and tongue label. The shoe also has a Jumpman logo on the tongue and a Wings logo on the heel for a classic touch.",
                    Price = 75000,
                    PictureUrl = "/images/products/Jordan  1 low shadow toe.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "45" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 03 , 01),
                    Condition = "Brand  new",
                    Style = "553558-052"
                },
                new Product
                {
                    Name = "Jordan 1 high 'Stage Haze'",
                    Description = "The Air Jordan 1 High OG 'Stage Haze' is a new colorway of the iconic sneaker that was released in July 2022. The shoe features a white leather base with black and grey overlays, creating a classic and versatile look. The black leather on the toe box and eyelets has a cracked texture, giving the shoe a vintage feel. The grey suede on the heel adds some contrast and softness to the design. The shoe also comes with two sets of laces, one in white and one in coral, to match the Nike tongue label and the outsole. The Air Jordan 1 High OG 'Stage Haze' is a must-have for fans of the original silhouette and its timeless style.",
                    Price = 100000,
                    PictureUrl = "/images/products/Jordan 1 high stage haze.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "45" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 07 , 02),
                    Condition = "Brand  new",
                    Style = "555088-108"
                },
                new Product
                {
                    Name = "Jordan 1 high 'University Blue'",
                    Description = "The Air Jordan 1 Retro High OG 'University Blue' is one of the most anticipated sneakers of 2021. Inspired by Michael Jordan's college days at the University of North Carolina, this colorway features a white leather base with university blue durabuck overlays and a black Nike Swoosh. The shoe also has a black tongue tag with a Nike Air logo, a black Wings logo on the ankle, and a university blue rubber outsole. This sneaker is a must-have for any Jordan fan or collector who appreciates the history and heritage of the iconic model.",
                    Price = 200000,
                    PictureUrl = "/images/products/Jordan 1 high university blue.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "42" }, new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 03 , 06),
                    Condition = "Brand  new",
                    Style = "555088-134"
                },
                new Product
                {
                    Name = "Jordan 1 high 'Ma Maniare'",
                    Description = "The Air Jordan 1 x A Ma Maniére is a collaboration between the Atlanta-based boutique and the iconic sneaker brand. The shoe features a premium suede upper in a sail colorway, with burgundy accents on the collar and Swoosh. The shoe also has a quilted satin lining, a yellowed midsole and a burgundy outsole. The shoe is inspired by Michael Jordan's quote 'You have to expect things of yourself before you can do the', which is printed on the inside of the collar flap.",
                    Price = 140000,
                    PictureUrl = "/images/products/Jordan 1 high ma maniare.webp",
                    Collection = "Jordan 1",
                    Sizes = new List<Size> { new Size { Value = "42" }, new Size { Value = "43" }, new Size { Value = "44" }, new Size { Value = "45" }, new Size { Value = "46" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 12 , 03),
                    Condition = "Brand  new",
                    Style = "DO7097-100"
                },
                new Product
                {
                    Name = "Jordan 4 Retro 'Midnight Navy'",
                    Description = "The Jordan 4 Retro 'Midnight Navy' is a classic sneaker that combines style and performance. The shoe features a white leather upper with navy and gold accents, inspired by the colors of Michael Jordan's alma mater, the University of North Carolina. The shoe also has a visible Air unit in the heel, a mesh panel on the tongue, and a rubber outsole with a herringbone pattern for traction. The Jordan 4 Retro 'Midnight Navy' was originally released in 2006 as part of the 'Mars' pack, which paid tribute to Spike Lee's character Mars Blackmon from the iconic Air Jordan commercials. The shoe was re-released in 2020 to celebrate the 30th anniversary of the Jordan 4 model, which debuted in 1989. The Jordan 4 Retro 'Midnight Navy' is a must-have for any sneaker fan who appreciates the legacy and history of the Air Jordan brand.",
                    Price = 140000,
                    PictureUrl = "/images/products/Jordan 4 retro  midnight navy.webp",
                    Collection = "Jordan 4",
                    Sizes = new List<Size> { new Size { Value = "46" }, new Size { Value = "43" }, new Size { Value = "45" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 10 , 29),
                    Condition = "Brand  new",
                    Style = "DH6927-140"
                },
                new Product
                {
                    Name = "Jordan 4 Retro 'Canyon Purple'",
                    Description = "The Jordan 4 Retro'Canyon Purple' is a women's exclusive colorway of the iconic sneaker that debuted in 2022. The shoe features a shaggy suede upper in a vibrant purple hue, contrasted by black accents on the wings, heel tab, and outsole. Lime green speckles adorn the eyelets and midsole, while a safety orange Jumpman logo pops on the tongue. The design is inspired by Tinker Hatfield's original 1989 creation, which was worn by Michael Jordan when he made 'The Shot' in the playoffs. The Jordan 4 Retro 'Canyon Purple' is a stylish and eye-catching addition to any sneaker collection.",
                    Price = 110000,
                    PictureUrl = "/images/products/Jordan 4 retro canyon purple.webp",
                    Collection = "Jordan 4",
                    Sizes = new List<Size> { new Size { Value = "45" }, new Size { Value = "41" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 10 , 15),
                    Condition = "Brand  new",
                    Style = "AQ9129-500"
                },
                new Product
                {
                    Name = "Nike Dunk Low 'Purple Pulse' (W)",
                    Description = "The Nike Dunk Low Purple Pulse is a women's sneaker that features a white leather base with purple tie-dye-like overlays. The shoe also has purple suede Swooshes and heel tabs, as well as a white midsole and a purple outsole. The Nike Dunk Low Purple Pulse was released in August 2021 as part of a series of colorful Dunks for women. The shoe has a retro style that pays homage to the original Nike Dunk from 1985, but with a modern twist. The Nike Dunk Low Purple Pulse is a versatile and eye-catching sneaker that can add some flair to any outfit.",
                    Price = 90000,
                    PictureUrl = "/images/products/Nike dunk low purple pulse  (w).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "39" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 08 , 18),
                    Condition = "Brand  new",
                    Style = "DM9467-500"
                },
                new Product
                {
                    Name = "HUF x Nike Dunk Low SB 'San Francisco'",
                    Description = "The HUF x Nike Dunk Low SB 'San Francisco' is a special edition sneaker that celebrates the 20th anniversary of HUF, a streetwear brand founded by the late skater Keith Hufnagel in San Francisco. The shoe pays tribute to Hufnagel's love for the city and its baseball team, the SF Giants, with a black and white tumbled leather upper that features a HUF logo and a mini-Swoosh on the toe box, a skyline graphic on the heel, and 'Keith Forever' on the heel tabs. The shoe also has a hidden tie-dye print on the quarter panels that nods to HUF's previous Dunk High collaboration from 2004.",
                    Price = 120000,
                    PictureUrl = "/images/products/HUF x Nike dunk low sb san francisco.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "42.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 11 , 17),
                    Condition = "Brand  new",
                    Style = "FD8775-001"
                },
                new Product
                {
                    Name = "Nike dunk low 'Aura Clear' (GS)",
                    Description = "Nike dunk low 'Aura Clear' is a new colorway of the iconic sneaker that features a white leather base with light blue overlays and a clear Swoosh. The shoe also has a white midsole, a light blue outsole, and a clear tongue label with Nike branding. The'Aura Clear' colorway is inspired by the sky and the clouds, creating a fresh and airy look for the spring season. The Nike dunk low 'Aura Clear' is a must-have for fans of the dunk low silhouette and those who appreciate a clean and simple design with a touch of transparency.",
                    Price = 70000,
                    PictureUrl = "/images/products/Nike dunk low aura clear  (gs).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "40" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 04 , 23),
                    Condition = "Brand  new",
                    Style = "DH9765-401"
                },
                new Product
                {
                    Name = "Concepts x Nike SB Dunk Low 'Orange Lobster'",
                    Description = "The Concepts x Nike SB Dunk Low 'Orange Lobster' is a unique sneaker that draws inspiration from the rare crustacean of the same name. The shoe features a nubuck upper with orange hues and speckled details, a white Swoosh with an orange outline, and a plaid pattern on the lining that resembles a lobster bib. The shoe also comes with a special box that includes a lobster telephone inspired by Salvador Dali's art, and a toy with orange speckles. The sneaker is a highly sought-after collector's item that showcases the creativity and collaboration between Concepts and Nike SB.",
                    Price = 250000,
                    PictureUrl = "/images/products/Concepts x Nike sb dunk low orange lobster.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 12 , 23),
                    Condition = "Brand  new",
                    Style = "FD8776-800"
                },
                new Product
                {
                    Name = "Nike SB Dunk Low Pro Premium 'Paisley'",
                    Price = 120000,
                    PictureUrl = "/images/products/Nike SB Dunk Low Pro Premium Paisley.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 03 , 31),
                    Condition = "Brand  new",
                    Style = "DH7534-200"
                },
                new Product
                {
                    Name = "Nike dunk low 'Dark Driftwood'",
                    Description = "The Nike Dunk Low 'Dark Driftwood' is a sneaker that features a smooth leather upper with a beige base and dark tan overlays. The black Swoosh, tongue label, heel tab, and outsole contrast with the earthy tones of the shoe. The Nike Dunk Low 'Dark Driftwood' is a versatile and stylish option for fans of the classic silhouette.",
                    Price = 75000,
                    PictureUrl = "/images/products/Nike dunk low Dark Driftwood.webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "39" }, new Size { Value = "40.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 11 , 23),
                    Condition = "Brand  new",
                    Style = "DD1503-200"
                },
                new Product
                {
                    Name = "Nike Dunk High 'Pink Prime' (W)",
                    Price = 90000,
                    PictureUrl = "/images/products/Nike Dunk High Pink Prime (W).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "38" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 05 , 05),
                    Condition = "Brand  new",
                    Style = "DD1869-110"
                },
                new Product
                {
                    Name = "Nike Dunk Low 'Next Nature Pale Coral' (W)",
                    Description = "Nike Dunk Low Next Nature Pale Coral is a new colorway of the iconic sneaker that is inspired by nature and sustainability. The shoe features a recycled canvas upper with a coral hue that resembles the ocean reefs. The Swoosh logo and heel tab are made from cork, a natural material that is renewable and biodegradable. The midsole and outsole are also made from recycled rubber, reducing the environmental impact of the shoe. The Nike Dunk Low Next Nature Pale Coral is part of the Next Nature collection, which aims to create products that are more in harmony with the planet.",
                    Price = 65000,
                    PictureUrl = "/images/products/Nike Dunk Low Next Nature Pale Coral (W).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "36.5" }, new Size { Value = "38" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 11 , 03),
                    Condition = "Brand  new",
                    Style = "DD1873-100"
                },
                new Product
                {
                    Name = "Nike dunk low 'Coconut Milk' (W)",
                    Price = 80000,
                    PictureUrl = "/images/products/Nike dunk low Coconut Milk (W).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "38.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 03 , 01),
                    Condition = "Brand  new",
                    Style = "DJ6188-100"
                },
                new Product
                {
                    Name = "Nike dunk low 'Easter 2022' (W)",
                    Description = "Nike is celebrating Easter with a new colorway of its popular Dunk Low silhouette. The Nike Dunk Low 'Easter 2022' features a light grey leather base with pastel purple, pink and blue accents on the overlays, Swooshes, tongue and heel tabs. The shoe also has a white midsole and a purple outsole for a contrast. The Nike Dunk Low 'Easter 2022' is inspired by the colors of Easter eggs and spring flowers, making it a perfect choice for the season.  The Nike Dunk Low 'Easter 2022' is a fresh and fun addition to the Dunk family, which has been one of Nike's most iconic and versatile models since its debut in 1985.",
                    Price = 70000,
                    PictureUrl = "/images/products/Nike dunk low Easter 2022 (W).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "37.5" }, new Size { Value = "38.5" }, new Size { Value = "39" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 04 , 17),
                    Condition = "Brand  new",
                    Style = "DD1503-001"
                },
                new Product
                {
                    Name = "Nike Off White dunk low 'Lot 25'",
                    Price = 230000,
                    PictureUrl = "/images/products/Nike Off White dunk low Lot 25.webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "42" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 08 , 09),
                    Condition = "Brand  new",
                    Style = "DM1602-116"
                },
                new Product
                {
                    Name = "Nike dunk low 'Lottery Pack Grey'",
                    Price = 90000,
                    PictureUrl = "/images/products/Nike dunk low Lottery Pack Grey.webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "44.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 08 , 31),
                    Condition = "Brand  new",
                    Style = "DR9654-001"
                },
                new Product
                {
                    Name = "Nike dunk low 'USC'",
                    Description = "The Nike Dunk Low 'US' is a sneaker that pays homage to the University of Southern California Trojans, one of the most successful college sports teams in the US. The shoe features a leather upper with a white base and red and yellow overlays, matching the colors of the USC logo. The Nike Swoosh on the side panels is also red, while the tongue and heel tabs are yellow with Nike branding. The midsole is white and the outsole is red, completing the simple but striking design. The Nike Dunk Low 'USC' was part of a series of Dunk Lows inspired by various college teams. The shoe is a must-have for fans of USC or anyone who appreciates a classic colorway on a retro silhouette.",
                    Price = 85000,
                    PictureUrl = "/images/products/Nike dunk low USC.webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "42" }, new Size { Value = "43" }, new Size { Value = "44" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 08 , 09),
                    Condition = "Brand  new",
                    Style = "DD1391-602"
                },
                new Product
                {
                    Name = "Nike dunk low 'White Pink' (GS)",
                    Description = "Nike dunk low 'White Pink' is a new colorway of the iconic sneaker that combines a clean white leather upper with pink accents on the Swoosh, tongue, heel tab and outsole. The shoe is part of the Nike Dunk Low Spring 2023 collection, which features various pastel hues inspired by the season. The Nike dunk low 'White Pin' is a versatile and stylish option for both men and women who want to add some freshness to their wardrobe.",
                    Price = 65000,
                    PictureUrl = "/images/products/Nike dunk low White Pink (GS).webp",
                    Collection = "Dunks",
                    Sizes = new List<Size> { new Size { Value = "38.5" }, new Size { Value = "39" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2022, 01 , 15),
                    Condition = "Brand  new",
                    Style = "DH9765-100"
                },
                new Product
                {
                    Name = "Nike SB dunk low 'FTC'",
                    Price = 135000,
                    PictureUrl = "/images/products/Nike SB dunk low FTC.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "42.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 07 , 21),
                    Condition = "Brand  new",
                    Style = "DH7687-400"
                },
                new Product
                {
                    Name = "Nike SB dunk low 'Parra'",
                    Price = 170000,
                    PictureUrl = "/images/products/Nike SB dunk low Parra.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "42.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 07 , 31),
                    Condition = "Brand  new",
                    Style = "DH7695-600"
                },
                new Product
                {
                    Name = "Nike SB dunk low 'Street Hawker'",
                    Price = 220000,
                    PictureUrl = "/images/products/Nike SB dunk low Street Hawker.webp",
                    Collection = "Dunks SB",
                    Sizes = new List<Size> { new Size { Value = "42.5" } },
                    QuantityInStock = 100,
                    ReleaseDate = new DateTime(2021, 01 , 22),
                    Condition = "Brand  new",
                    Style = "CV1628-800"
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }

        private static List<Size> GenerateSizes(float startSize, float endSize, float step)
        {
            var sizes = new List<Size>();
            for (float size = startSize; size <= endSize; size += step)
            {
                sizes.Add(new Size { Value = size.ToString() });
            }
            return sizes;
        }
    }
}