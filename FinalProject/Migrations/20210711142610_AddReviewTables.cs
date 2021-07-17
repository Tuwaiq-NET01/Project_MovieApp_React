using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddReviewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spoiler = table.Column<bool>(type: "bit", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReview_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShowReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spoiler = table.Column<bool>(type: "bit", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    TvShowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShowReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShowReview_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShowReview_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-02", "https://image.tmdb.org/t/p/w300/xipF6XqfSYV8DxLqfLN6aWlwuRp.jpg", 8, "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest to rewrite the fate of the planet.", "The Tomorrow War" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-09-08", "https://image.tmdb.org/t/p/w300/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg", 0, "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, revealing that his memories are real.", "Infinite" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/jTswp6KyDYKtvC52GbHagrZbGvD.jpg", "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.", "Luca" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-01", "https://image.tmdb.org/t/p/w300/5dExO5G2iaaTxYnLIFKLWofDzyI.jpg", 8, "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.", "The Boss Baby: Family Business" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-19", "https://image.tmdb.org/t/p/w300/qIicLxr7B7gIt5hxZxo423BJLlK.jpg", 8, "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.", "F9" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-07", "https://image.tmdb.org/t/p/w300/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg", 8, "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long before she became an Avenger.", "Black Widow" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-25", "https://image.tmdb.org/t/p/w300/cycDz68DtTjJrDJ1fV8EBq2Xdpb.jpg", 7, "Bea, Thomas, and the rabbits have created a makeshift family, but despite his best efforts, Peter can’t seem to shake his mischievous reputation. Adventuring out of the garden, Peter finds himself in a world where his mischief is appreciated, but when his family risks everything to come looking for him, Peter must figure out what kind of bunny he wants to be.", "Peter Rabbit 2: The Runaway" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-21", "https://image.tmdb.org/t/p/w300/4q2hz2m8hubgvijz8Ez0T2Os2Yv.jpg", 8, "Following the events at home, the Abbott family now face the terrors of the outside world. Forced to venture into the unknown, they realize that the creatures that hunt by sound are not the only threats that lurk beyond the sand path.", "A Quiet Place Part II" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-22", "https://image.tmdb.org/t/p/w300/M7SUK85sKjaStg4TKhlAVyGlz3.jpg", "A cold and mysterious new security guard for a Los Angeles cash truck company surprises his co-workers when he unleashes precision skills during a heist. The crew is left wondering who he is and where he came from. Soon, the marksman's ultimate motive becomes clear as he takes dramatic and irrevocable steps to settle a score.", "Wrath of Man" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-26", "https://image.tmdb.org/t/p/w300/rTh4K5uw9HypmpGslcKd4QfHl93.jpg", 8, "In 1970s London amidst the punk rock revolution, a young grifter named Estella is determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. One day, Estella’s flair for fashion catches the eye of the Baroness von Hellman, a fashion legend who is devastatingly chic and terrifyingly haute. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.", "Cruella" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2023-02-01", "https://image.tmdb.org/t/p/w300/2DyEk84XnbJEdPlGF43crxfdtHH.jpg", 0, "The tenth installment in the Fast Saga.", "Fast & Furious 10" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-12", "https://image.tmdb.org/t/p/w300/nxxuWC32Y6TULj4VnVwMPUFLIpK.jpg", 8, "A former intelligence agent gets involved with the first human clone, Seo Bok, who others seek, causing trouble.", "Seobok" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-09", "https://image.tmdb.org/t/p/w300/uZkNbB8isWXHMDNoIbqXvmslBMC.jpg", 6, "After a sudden global event wipes out all electronics and takes away humankind’s ability to sleep, chaos quickly begins to consume the world. Only Jill, an ex-soldier with a troubled past, may hold the key to a cure in the form of her own daughter. The question is, can Jill safely deliver her daughter and save the world before she herself loses her mind.", "Awake" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/z8CExJekGrEThbpMXAmCFvvgoJR.jpg", "Following a zombie outbreak in Las Vegas, a group of mercenaries take the ultimate gamble: venturing into the quarantine zone to pull off the greatest heist ever attempted.", "Army of the Dead" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-25", "https://image.tmdb.org/t/p/w300/xbSuFiJbbBWCkyCCKIMfuDCA4yV.jpg", 8, "Paranormal investigators Ed and Lorraine Warren encounter what would become one of the most sensational cases from their files. The fight for the soul of a young boy takes them beyond anything they'd ever seen before, to mark the first time in U.S. history that a murder suspect would claim demonic possession as a defense.", "The Conjuring: The Devil Made Me Do It" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-07", "https://image.tmdb.org/t/p/w300/nkayOAUBUu4mMvyNf9iHSUiPjF1.jpg", 8, "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against the enemies of Outworld in a high stakes battle for the universe.", "Mortal Kombat" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-20", "https://image.tmdb.org/t/p/w300/5cbGVDmRMYVzkq5cItZ7cYlDdDR.jpg", "Lucky Prescott's life is changed forever when she moves from her home in the city to a small frontier town and befriends a wild mustang named Spirit.", "Spirit Untamed" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-28", "https://image.tmdb.org/t/p/w300/9J9Wy39ZjrVmfk7yMkulpcI5sy0.jpg", "In 1994, a group of teenagers discovers that the terrifying events which have haunted their town for generations ​are all connected — and that they may be the next targets.", "Fear Street Part One: 1994" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-24", "https://image.tmdb.org/t/p/w300/pgqgaUx1cJb5oZQQ5v0tNARCeBp.jpg", "In a time when monsters walk the Earth, humanity’s fight for its future sets Godzilla and Kong on a collision course that will see the two most powerful forces of nature on the planet collide in a spectacular battle for the ages.", "Godzilla vs. Kong" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-30", "https://image.tmdb.org/t/p/w300/j0HnLa6FtGcslbqClKOIyvCXfpe.jpg", 6, "A chainsaw-wielding George Washington teams with beer-loving bro Sam Adams to take down the Brits in a tongue-in-cheek riff on the American Revolution.", "America: The Motion Picture" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-30", "https://image.tmdb.org/t/p/w300/uHA5COgDzcxjpYSHHulrKVl6ByL.jpg", 7, "All the rules are broken as a sect of lawless marauders decides that the annual Purge does not stop at daybreak and instead should never end.", "The Forever Purge" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-27", "https://image.tmdb.org/t/p/w300/ccsSqbpEqr2KK9eMvoeF8ERFCd5.jpg", 7, "Jack Halsey takes his wife, their adult kids, and a friend for a dream vacation in Kenya. But as they venture off alone into a wilderness park, their safari van is flipped over by an angry rhino, leaving them injured and desperate. Then, as two of them go in search of rescue, a bloody, vicious encounter with a leopard and a clan of hyenas incites a desperate fight for survival.", "Endangered Species" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-04", "https://image.tmdb.org/t/p/w300/qQ0VKsGRQ2ofAmswGNzZnvC1xPE.jpg", "On school break, Marinette heads to Shanghai to meet Adrien. But after arriving, Marinette loses all her stuff, including the Miraculous that allows her to turn into Ladybug!", "Miraculous World: Shanghai – The Legend of Ladydragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-29", "https://image.tmdb.org/t/p/w300/rEm96ib0sPiZBADNKBHKBv5bve9.jpg", 7, "An elite Navy SEAL uncovers an international conspiracy while seeking justice for the murder of his pregnant wife.", "Tom Clancy's Without Remorse" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-12", "https://image.tmdb.org/t/p/w300/lcyKve7nXRFgRyms9M1bndNkKOx.jpg", 6, "Working in the shadow of an esteemed police veteran, brash Detective Ezekiel “Zeke” Banks and his rookie partner take charge of a grisly investigation into murders that are eerily reminiscent of the city’s gruesome past.  Unwittingly entrapped in a deepening mystery, Zeke finds himself at the center of the killer’s morbid game.", "Spiral: From the Book of Saw" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/lnPf6hzANL6pVQTxUlsNYSuhT5l.jpg", "Determined teen Din is longing to reconnect with his childhood best friend when he meets a wish-granting dragon who shows him the magic of possibilities.", "Wish Dragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/6vcDalR50RWa309vBH1NLmG2rjQ.jpg", "Jim Hanson’s quiet life is suddenly disturbed by two people crossing the US/Mexico border – a woman and her young son – desperate to flee a Mexican cartel. After a shootout leaves the mother dead, Jim becomes the boy’s reluctant defender. He embraces his role as Miguel’s protector and will stop at nothing to get him to safety, as they go on the run from the relentless assassins.\r Stars...Liam Neeson", "The Marksman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-27", "https://image.tmdb.org/t/p/w300/qmddUxRwbsxHa7oEXm4PWh1KZe8.jpg", "Sara is a teen girl who is looking forward to her 18th birthday to move away from her controlling father Don. But before she could even blow out the candles, Don imprisons her in the basement of their home.", "Girl in the Basement" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-01-14", "https://image.tmdb.org/t/p/w300/iB8rf8FYHGlrbmLybCo6Mpg8hNt.jpg", 5, "After a divorce, Sophia moves to the south of Italy with her daughter, Helena. Their new home, an apartment within an austere building of the fascist age, is a chance for them to start a new life. But inside an old storage room hides a mysterious closet and a buried secret. After the loss of Helena’s first baby tooth, a chilling obsession begins and an apparition haunts her sleep...", "The Haunting of Helena" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-18", "https://image.tmdb.org/t/p/w300/tnAuB8q5vv7Ax9UAEje5Xi4BXik.jpg", "Determined to ensure Superman's ultimate sacrifice was not in vain, Bruce Wayne aligns forces with Diana Prince with plans to recruit a team of metahumans to protect the world from an approaching threat of catastrophic proportions.", "Zack Snyder's Justice League" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-10-16", "https://image.tmdb.org/t/p/w300/h8Rb9gBr48ODIwYUttZNYeMWeUU.jpg", "Tanjirō Kamado, joined with Inosuke Hashibira, a boy raised by boars who wears a boar's head, and Zenitsu Agatsuma, a scared boy who reveals his true power when he sleeps, boards the Infinity Train on a new mission with the Fire Hashira, Kyōjurō Rengoku, to defeat a demon who has been tormenting the people and killing the demon slayers who oppose it!", "Demon Slayer -Kimetsu no Yaiba- The Movie: Mugen Train" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-04", "https://image.tmdb.org/t/p/w300/cwUhVcDeMYYeu8fq5q1OPOoSbZ7.jpg", "Two years after the murder of his son and father, a retired hitman sets in motion a carefully crafted revenge plan against the killer: his own brother.", "Xtreme" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-31", "https://image.tmdb.org/t/p/w300/bShgiEQoPnWdw4LBrYT5u18JF34.jpg", "Alice, a young hearing-impaired girl who, after a supposed visitation from the Virgin Mary, is inexplicably able to hear, speak and heal the sick. As word spreads and people from near and far flock to witness her miracles, a disgraced journalist hoping to revive his career visits the small New England town to investigate. When terrifying events begin to happen all around, he starts to question if these phenomena are the works of the Virgin Mary or something much more sinister.", "The Unholy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/srYGZ1rd9rvzwAltcKREUdS1JSQ.jpg", "Before he built a drug empire, Ferry Bouman returns to his hometown on a revenge mission that finds his loyalty tested — and a love that alters his life.", "Ferry" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-30", "https://image.tmdb.org/t/p/w300/vXHzO26mJaOt4VO7ZFiM6No5ScT.jpg", 6, "A lonesome stranger with nerves of steel must track down and kill a rogue hitman to satisfy an outstanding debt. But the only information he's been given is a time and location where to find his quarry. No name. No description. Nothing.", "The Virtuoso" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-02", "https://image.tmdb.org/t/p/w300/dkokENeY5Ka30BFgWAqk14mbnGs.jpg", 8, "Drac tries out some new monster pets to help occupy Tinkles for playtime.", "Monster Pets: A Hotel Transylvania Short" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-26", "https://image.tmdb.org/t/p/w300/dtt2dfMdmlCcgaJZkPPQsIY5oR6.jpg", "A renowned exorcist teams up with a rookie priest for his first day of training. As they plunge deeper into hell on earth, the lines between good and evil blur, and their own demons emerge.", "The Seventh Day" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-08-01", "https://image.tmdb.org/t/p/w300/qRyy2UmjC5ur9bDi3kpNNRCc5nc.jpg", "Ever since US Diplomatic Security Service Agent Hobbs and lawless outcast Shaw first faced off, they just have traded smack talk and body blows. But when cyber-genetically enhanced anarchist Brixton's ruthless actions threaten the future of humanity, they join forces to defeat him.", "Fast & Furious Presents: Hobbs & Shaw" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-26", "https://image.tmdb.org/t/p/w300/oBgWY00bEFeZ9N25wWVyuQddbAo.jpg", 8, "Hutch Mansell, a suburban dad, overlooked husband, nothing neighbor — a \"nobody.\" When two thieves break into his home one night, Hutch's unknown long-simmering rage is ignited and propels him on a brutal path that will uncover dark secrets he fought to leave behind.", "Nobody" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-03", "https://image.tmdb.org/t/p/w300/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg", 8, "Long ago, in the fantasy world of Kumandra, humans and dragons lived together in harmony. But when an evil force threatened the land, the dragons sacrificed themselves to save humanity. Now, 500 years later, that same evil has returned and it’s up to a lone warrior, Raya, to track down the legendary last dragon to restore the fractured land and its divided people.", "Raya and the Last Dragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-18", "https://image.tmdb.org/t/p/w300/pR2fzm82fl0giommpo310LBOMbV.jpg", "A widowed new dad copes with doubts, fears, heartache and dirty diapers as he sets out to raise his daughter on his own. Inspired by a true story.", "Fatherhood" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-16", "https://image.tmdb.org/t/p/w300/AoWY1gkcNzabh229Icboa1Ff0BM.jpg", 6, "Victoria is a young mother trying to put her dark past as a Russian drug courier behind her, but retired cop Damon forces Victoria to do his bidding by holding her daughter hostage. Now, Victoria must use guns, guts and a motorcycle to take out a series of violent gangsters—or she may never see her child again.", "Vanquish" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-05", "https://image.tmdb.org/t/p/w300/xCEg6KowNISWvMh8GvPSxtdf9TO.jpg", 7, "A young boy finds himself pursued by two assassins in the Montana wilderness, with a survival expert determined to protect him, and a forest fire threatening to consume them all.", "Those Who Wish Me Dead" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-12-19", "https://image.tmdb.org/t/p/w300/8WzoEWgwsaPuUuu7XhInFV3YCxy.jpg", 6, "A group of unlikely heroes from across the Korean peninsula try to save the day after a volcano erupts on the mythical and majestic Baekdu Mountain.", "Ashfall" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-25", "https://image.tmdb.org/t/p/w300/iM5kNvZzcMSmWv7CFTxnTu5zfoa.jpg", "Sofia, an insecure young woman, begins babysitting two troublesome siblings that turn her job into a complete living hell. That is until a devilish presence starts messing with the trio and they must band together to fight the demon away.", "Come Play With Me" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-03", "https://image.tmdb.org/t/p/w300/1UCOF11QCw8kcqvce8LKOO6pimh.jpg", 7, "A portal transports Cpt. Artemis and an elite unit of soldiers to a strange world where powerful monsters rule with deadly ferocity. Faced with relentless danger, the team encounters a mysterious hunter who may be their only hope to find a way home.", "Monster Hunter" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/m6bUeV4mczG3z2YXXr5XDKPsQzv.jpg", 7, "A special crimes investigator forms an unlikely bond with a serial killer to bring down a global child sex trafficking syndicate.", "I Am All Girls" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-12-16", "https://image.tmdb.org/t/p/w300/8UlWHLMpgZm9bx6QYh0NFoq67TZ.jpg", "A botched store robbery places Wonder Woman in a global battle against a powerful and mysterious ancient force that puts her powers in jeopardy.", "Wonder Woman 1984" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-23", "https://image.tmdb.org/t/p/w300/nzbwTwSo8aKuvAytaPG6s0xGVE8.jpg", 9, "The De La Mora siblings concoct a mischievous plan to break into their old family home to retrieve a hidden treasure of significant importance.", "The House of Flowers: The Movie" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-11-25", "https://image.tmdb.org/t/p/w300/tbVZ3Sq88dZaCANlUcewQuHQOaE.jpg", 8, "Searching for a safer habitat, the prehistoric Crood family discovers an idyllic, walled-in paradise that meets all of its needs. Unfortunately, they must also learn to live with the Bettermans -- a family that's a couple of steps above the Croods on the evolutionary ladder. As tensions between the new neighbors start to rise, a new threat soon propels both clans on an epic adventure that forces them to embrace their differences, draw strength from one another, and survive together.", "The Croods: A New Age" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-07-09", "https://image.tmdb.org/t/p/w300/dbPKu7GrA0bDzwaKv7RxpXyU2bU.jpg", "In 1978, two rival groups at Camp Nightwing must band together to solve a terrifying mystery when horrors from their towns' history come alive.", "Fear Street Part Two: 1978" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/yCTo0s8xzQplZY5h70cRy2OA4Pt.jpg", "Having just returned home, decorated U.S. Marine Captain Brad Paxton's wife, Kate, is kidnapped by a terrorist group while working in Morocco. He is forced back into action for a daring and deadly operation to save the woman he loves.", "Redemption Day" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-21", "https://image.tmdb.org/t/p/w300/fvaB0jrzFXq07bUpox03k6qOAJu.jpg", 8, "Following a brutal series of murders taking place on Halloween, Thanksgiving, and Christmas, Gotham City's young vigilante known as the Batman sets out to pursue the mysterious serial killer alongside police officer James Gordon and district attorney Harvey Dent.", "Batman: The Long Halloween, Part One" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-11", "https://image.tmdb.org/t/p/w300/8XZI9QZ7Pm3fVkigWJPbrXCMzjq.jpg", "Tom the cat and Jerry the mouse get kicked out of their home and relocate to a fancy New York hotel, where a scrappy employee named Kayla will lose her job if she can’t evict Jerry before a high-class wedding at the hotel. Her solution? Hiring Tom to get rid of the pesky mouse.", "Tom & Jerry" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-04-23", "https://image.tmdb.org/t/p/w300/mWL4lyP4DhEkg73rjUoALXguIXh.jpg", 7, "In the middle of a mysterious insomnia epidemic that slowly takes on catastrophic dimensions, Laura (39) and Augusto (42) flee the city in their motorhome to get away from the chaos. As they move down the route, the world becomes an increasingly strange and dangerous place. Finally, Laura reveals a story that changes everything. The road is depopulating, the silence grows and it is increasingly difficult to differentiate the reality from the dream.", "Toxic" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2017-04-12", "https://image.tmdb.org/t/p/w300/dImWM7GJqryWJO9LHa3XQ8DD5NH.jpg", 7, "When a mysterious woman seduces Dom into the world of crime and a betrayal of those closest to him, the crew face trials that will test them as never before.", "The Fate of the Furious" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-07-09", "https://image.tmdb.org/t/p/w300/95S6PinQIvVe4uJAd82a2iGZ0rA.jpg", 5, "An adventure-loving couple convince their friends to explore a remote, uncharted cave system in the forests of Northern Australia. With a tropical storm approaching, they abseil into the mouth of the cave, but when the caves start to flood, tensions rise as oxygen levels fall and the friends find themselves trapped. Unknown to them, the storm has also brought in a pack of dangerous and hungry crocodiles.", "Black Water: Abyss" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-30", "https://image.tmdb.org/t/p/w300/32vLDKSzcCMh55zqqaSqqUA8naz.jpg", "Set before the events of ‘Soul’, 22 refuses to go to Earth, enlisting a gang of 5 new souls in attempt of rebellion. However, 22’s subversive plot leads to a surprising revelation about the meaning of life.", "22 vs. Earth" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-07-08", "https://image.tmdb.org/t/p/w300/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg", "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes challenge of his life.", "Space Jam: A New Legacy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-26", "https://image.tmdb.org/t/p/w300/gvigDk4IZREJubLcQ2D9IwqelHQ.jpg", 6, "Three stories about the world of opioids collide: a drug trafficker arranges a multi-cartel Fentanyl smuggling operation between Canada and the U.S., an architect recovering from an OxyContin addiction tracks down the truth behind her son's involvement with narcotics, and a university professor battles unexpected revelations about his research employer, a drug company with deep government influence bringing a new \"non-addictive\" painkiller to market.", "Crisis" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-02", "https://image.tmdb.org/t/p/w300/gQcwwHXMn0AiMEE5i6TjOrzzHPW.jpg", 7, "With prayer beads in one hand and an ax in the other, a monk hunts down a millennia-old spirit that's possessing humans and unleashing hell on Earth.", "The 8th Night" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-25", "https://image.tmdb.org/t/p/w300/hm58Jw4Lw8OIeECIq5qyPYhAeRJ.jpg", 8, "Joe Gardner is a middle school teacher with a love for jazz music. After a successful gig at the Half Note Club, he suddenly gets into an accident that separates his soul from his body and is transported to the You Seminar, a center in which souls develop and gain passions before being transported to a newborn child. Joe must enlist help from the other souls-in-training, like 22, a soul who has spent eons in the You Seminar, in order to get back to Earth.", "Soul" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-09-26", "https://image.tmdb.org/t/p/w300/19kfvGktytDZInUmpv3WlaHoTxP.jpg", 8, "During a school field trip, Ladybug and Cat Noir meet the American superheroes, whom they have to save from an akumatised super-villain. They discover that Miraculous exist in the United States too.", "Miraculous World: New York, United HeroeZ" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-03", "https://image.tmdb.org/t/p/w300/prffYgzc7xYWXBiFoFfsgzgrNfj.jpg", 7, "Frederick Fitzell is living his best life—until he starts having horrific visions of Cindy, a girl who vanished in high school. After reaching out to old friends with whom he used to take a mystery drug called Mercury, Fredrick realizes the only way to stop the visions lies deep within his own memories, so he embarks on a terrifying mental odyssey to learn the truth.", "Flashback" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-02-05", "https://image.tmdb.org/t/p/w300/h4VB6m0RwcicVEZvzftYZyKXs6K.jpg", 7, "Harley Quinn joins forces with a singer, an assassin and a police detective to help a young girl who had a hit placed on her after she stole a rare diamond from a crime lord.", "Birds of Prey (and the Fantabulous Emancipation of One Harley Quinn)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-24", "https://image.tmdb.org/t/p/w300/9kg73Mg8WJKlB9Y2SAJzeDKAnuB.jpg", "Two unlikely companions embark on a perilous adventure through the badlands of an unexplored planet as they try to escape a dangerous and disorienting reality, where all inner thoughts are seen and heard by everyone.", "Chaos Walking" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-12", "https://image.tmdb.org/t/p/w300/keEnkeAvifw8NSEC4f6WsqeLJgF.jpg", 7, "When his car breaks down, a quiet loner agrees to clean an abandoned family fun center in exchange for repairs. He soon finds himself waging war against possessed animatronic mascots while trapped inside Willy's Wonderland.", "Willy's Wonderland" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-09", "https://image.tmdb.org/t/p/w300/3mKMWP5OokB7QpcOMA1yl8BXFAF.jpg", "In a world where supervillains are commonplace, two estranged childhood best friends reunite after one devises a treatment that gives them powers to protect their city.", "Thunder Force" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/esS12yF3CDuk5juvdFvi4PIwOuW.jpg", 7, "Enjoy high-sea thrills as Barbie, Chelsea and the rest of the Roberts family set sail on an adventure cruise.  \"Barbie & Chelsea The Lost Birthday\" tells the story of Chelsea, Barbie’s precocious youngest sister, and the rest of the Roberts family as they set sail on an adventure cruise for her seventh birthday. When they cross the International Date Line, Chelsea discovers her actual birthday has been lost and she embarks on a fantastical journey through an enchanted jungle island in order to save it.", "Barbie & Chelsea the Lost Birthday" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-01-15", "https://image.tmdb.org/t/p/w300/y95lQLnuNKdPAzw9F9Ab8kJ80c3.jpg", 7, "Marcus and Mike are forced to confront new threats, career changes, and midlife crises as they join the newly created elite team AMMO of the Miami police department to take down the ruthless Armando Armas, the vicious leader of a Miami drug cartel.", "Bad Boys for Life" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-10-02", "https://image.tmdb.org/t/p/w300/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg", 8, "During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming an infamous psychopathic crime figure.", "Joker" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-07", "https://image.tmdb.org/t/p/w300/wLjN3vIw63GJ6m1J2fhGL3D2VXd.jpg", 6, "After the assault of a young woman in their seaside town, a security expert and his family get caught in a powerful riptide of secrets and lies.", "Security" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-04", "https://image.tmdb.org/t/p/w300/2xnf2ZaGXudvgBKPtVXMkNeooh1.jpg", "In a daycare far, far away… but still in Springfield, Maggie is on an epic quest for her stolen pacifier. Her adventure brings her face-to-face with young Padawans, Sith Lords, familiar droids, Rebel scum, and an ultimate battle against the dark side, in this original short celebrating the Star Wars galaxy.", "Maggie Simpson in The Force Awakens from Its Nap" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-16", "https://image.tmdb.org/t/p/w300/9UnFhKtmKHq1pQDKLK3BA5OLkmE.jpg", 0, "In 1666, a colonial town is gripped by a hysterical witch-hunt that has deadly consequences for centuries to come, and it's up to teenagers in 1994 to try and finally put an end to their town's curse, before it's too late.", "Fear Street Part Three: 1666" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-12-20", "https://image.tmdb.org/t/p/w300/zGVbrulkupqpbwgiNedkJPyQum4.jpg", 8, "Class 1-A visits Nabu Island where they finally get to do some real hero work. The place is so peaceful that it's more like a vacation … until they're attacked by a villain with an unfathomable Quirk! His power is eerily familiar, and it looks like Shigaraki had a hand in the plan. But with All Might retired and citizens' lives on the line, there's no time for questions. Deku and his friends are the next generation of heroes, and they're the island's only hope.", "My Hero Academia: Heroes Rising" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/6XYLiMxHAaCsoyrVo38LBWMw2p8.jpg", 6, "In the near future, a drone pilot is sent into a deadly militarized zone and must work with an android officer to locate a doomsday device.", "Outside the Wire" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-09-30", "https://image.tmdb.org/t/p/w300/mKvw1Ic9enfFlCPBNJGiejRPMUO.jpg", 6, "Covert security company Vanguard is the last hope of survival for an accountant after he is targeted by the world's deadliest mercenary organization.", "Vanguard" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-08", "https://image.tmdb.org/t/p/w300/jDwZavHo99JtGsCyRzp4epeeBHx.jpg", 8, "In the aftermath of the Fourth Impact, stranded without their Evangelions, Shinji, Asuka, and Rei search for refuge in the desolate red remains of Tokyo-3. But the danger to the world is far from over. A new impact is looming on the horizon—one that will prove to be the true end of Evangelion.", "Evangelion: 3.0+1.0 Thrice Upon a Time" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-05", "https://image.tmdb.org/t/p/w300/p9YDHJKvUoi7v2SCd3vLGPae1Xp.jpg", "When the crew of a space junk collector ship called The Victory discovers a humanoid robot named Dorothy that's known to be a weapon of mass destruction, they get involved in a risky business deal which puts their lives at stake.", "Space Sweepers" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-25", "https://image.tmdb.org/t/p/w300/2ST6l4WP7ZfqAetuttBqx8F3AAH.jpg", 7, "A woman's daring sexual past collides with her married-with-kids present when the bad-boy ex she can't stop fantasizing about crashes back into her life.", "Sex/Life" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-12-02", "https://image.tmdb.org/t/p/w300/8kOWDBK6XlPUzckuHDo3wwVRFwt.jpg", 9, "Rick is a mentally-unbalanced but scientifically-gifted old man who has recently reconnected with his family. He spends most of his time involving his young grandson Morty in dangerous, outlandish adventures throughout space and alternate universes. Compounded with Morty's already unstable family life, these events cause Morty much distress at home and school.", "Rick and Morty" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-25", "https://image.tmdb.org/t/p/w300/ztyJqTdS7RApGgl6ZXmFdGZX3g0.jpg", 10, "", "Café con aroma de mujer" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-10-05", "https://image.tmdb.org/t/p/w300/3NTAbAiao4JLzFQw6YxP1YZppM8.jpg", 8, "When three working class kids enroll in the most exclusive school in Spain, the clash between the wealthy and the poor students leads to tragedy.", "Elite" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2014-10-07", "https://image.tmdb.org/t/p/w300/lJA2RCMfsWoskqlQhXPSLFQGXEJ.jpg", "After a particle accelerator causes a freak storm, CSI Investigator Barry Allen is struck by lightning and falls into a coma. Months later he awakens with the power of super speed, granting him the ability to move through Central City like an unseen guardian angel. Though initially excited by his newfound powers, Barry is shocked to discover he is not the only \"meta-human\" who was created in the wake of the accelerator explosion -- and not everyone is using their new powers for good. Barry partners with S.T.A.R. Labs and dedicates his life to protect the innocent. For now, only a few close friends and associates know that Barry is literally the fastest man alive, but it won't be long before the world learns what Barry Allen has become...The Flash.", "The Flash" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/s5k4GqTUGXeUdScNrjpYfiQLKHI.jpg", "Ten years after signing off of one of TV's most iconic shows, Carly, Spencer, and Freddie are back, navigating the next chapter of their lives, facing the uncertainties of life in their twenties.", "iCarly" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2016-01-25", "https://image.tmdb.org/t/p/w300/4EYPN5mVIhKLfxGruy7Dy41dTVn.jpg", "Bored and unhappy as the Lord of Hell, Lucifer Morningstar abandoned his throne and retired to Los Angeles, where he has teamed up with LAPD detective Chloe Decker to take down criminals. But the longer he's away from the underworld, the greater the threat that the worst of humanity could escape.", "Lucifer" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2017-09-25", "https://image.tmdb.org/t/p/w300/6tfT03sGp9k4c0J3dypjrI8TSAI.jpg", 9, "A young surgeon with Savant syndrome is recruited into the surgical unit of a prestigious hospital. The question will arise: can a person who doesn't have the ability to relate to people actually save their lives", "The Good Doctor" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-20", "https://image.tmdb.org/t/p/w300/caHPX2aaWTzhcvjO877IO4c2yer.jpg", "", "La muchacha que limpia" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-10", "https://image.tmdb.org/t/p/w300", 2, "", "De Oranjezomer (Veronica Inside Oranje)" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2015-06-07", "https://image.tmdb.org/t/p/w300/6qwUvkopDFHQq4xYBVXJixYQIRp.jpg", 6, "A stunning cast engages in the ultimate game of love, as they land in a sunshine paradise in search of passion and romance. Each of the glamorous members of the public will live like celebrities in a luxury villa, but in order to stay there, they will not only have to win over the hearts of each other, but also the hearts of the public.", "Love Island" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2005-03-27", "https://image.tmdb.org/t/p/w300/clnyhPqj1SNgpAdeSS6a6fwE6Bo.jpg", 8, "Follows the personal and professional lives of a group of doctors at Seattle’s Grey Sloan Memorial Hospital.", "Grey's Anatomy" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-19", "https://image.tmdb.org/t/p/w300/6kbAMLteGO8yyewYau6bJ683sw7.jpg", "Following the events of “Avengers: Endgame”, the Falcon, Sam Wilson and the Winter Soldier, Bucky Barnes team up in a global adventure that tests their abilities, and their patience.", "The Falcon and the Winter Soldier" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-06-12", "https://image.tmdb.org/t/p/w300/fuVuDYrs8sxvEolnYr0wCSvtyTi.jpg", 8, "After spending seventeen years in prison unfairly, a talented songwriter seeks revenge on the men who sank her and killed her family.", "The Queen of Flow" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2017-01-26", "https://image.tmdb.org/t/p/w300/wRbjVBdDo5qHAEOVYoMWpM58FSA.jpg", 9, "Set in the present, the series offers a bold, subversive take on Archie, Betty, Veronica and their friends, exploring the surreality of small-town life, the darkness and weirdness bubbling beneath Riverdale’s wholesome facade.", "Riverdale" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-23", "https://image.tmdb.org/t/p/w300/vlv1gn98GqMnKHLSh0dNciqGfBl.jpg", "After years of facing megalomaniacal supervillains, monsters wreaking havoc on Metropolis, and alien invaders intent on wiping out the human race, The Man of Steel aka Clark Kent and Lois Lane come face to face with one of their greatest challenges ever: dealing with all the stress, pressures and complexities that come with being working parents in today's society.", "Superman & Lois" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-30", "https://image.tmdb.org/t/p/w300/opHopqkLzkftwUl4jTLcwckjuu.jpg", 8, "The lives of the people of Allende, a Mexican border town, are overtaken by a powerful cartel's operations, leading to tragedy. Inspired by true events.", "Somos." });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2006-05-02", "https://image.tmdb.org/t/p/w300/3pR3ofV14hyeAxkxBdYjZM7Npc4.jpg", 2, " ", "Supervivientes" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-22", "https://image.tmdb.org/t/p/w300/rlMHXRqFaViJSznN53VXv8VW3nq.jpg", 0, "The stories of seven women, whose destinies intersect. Seven Lisbon couples live different moments in their relationships. Everyone has problems to solve. The challenges that each couple face are different - some more serious, others more common and predictable... and some purely selfish.", "Mulheres" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/kTs2WNZOukpWdNhoRlH94pSJ3xf.jpg", 9, "Before eradicating humankind from the world, the gods give them one last chance to prove themselves worthy of survival. Let the Ragnarok battles begin.", "Record of Ragnarok" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2011-04-17", "https://image.tmdb.org/t/p/w300/u3bZgnGQ9T01sWNhyveQz0wH0Hl.jpg", "Seven noble families fight for control of the mythical land of Westeros. Friction between the houses leads to full-scale war. All while a very ancient evil awakens in the farthest north. Amidst the war, a neglected military order of misfits, the Night's Watch, is all that stands between the realms of men and icy horrors beyond.", "Game of Thrones" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/glKDfE6btIRcVB5zrjspRIs4r52.jpg", "Wanda Maximoff and Vision—two super-powered beings living idealized suburban lives—begin to suspect that everything is not as it seems.", "WandaVision" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1989-12-17", "https://image.tmdb.org/t/p/w300/zLudbPueg8CxGhMS2tyDh3p0TdK.jpg", 8, "Set in Springfield, the average American town, the show focuses on the antics and everyday adventures of the Simpson family; Homer, Marge, Bart, Lisa and Maggie, as well as a virtual cast of thousands. Since the beginning, the series has been a pop culture icon, attracting hundreds of celebrities to guest star. The show has also made name for itself in its fearless satirical take on politics, media and American life in general.", "The Simpsons" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-04", "https://image.tmdb.org/t/p/w300/rgMfhcrVZjuy5b7Pn0KzCRCEnMX.jpg", "On a perilous adventure across a post-apocalyptic world, a lovable boy who's half-human and half-deer searches for a new beginning with a gruff protector.", "Sweet Tooth" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-04", "https://image.tmdb.org/t/p/w300/WjQmEWFrOf98nT5aEfUfVYz9N2.jpg", "The 'Bad Batch' of elite and experimental clones make their way through an ever-changing galaxy in the immediate aftermath of the Clone Wars.", "The Bad Batch" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-01-31", "https://image.tmdb.org/t/p/w300/xUtOM1QO4r8w8yeE00QvBdq58N5.jpg", "A small Norwegian town experiencing warm winters and violent downpours seems to be headed for another Ragnarök -- unless someone intervenes in time.", "Ragnarok" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-10-25", "https://image.tmdb.org/t/p/w300/qTZIgXrBKURBK1KrsT7fe3qwtl9.jpg", 9, "In a place where young witches, vampires, and werewolves are nurtured to be their best selves in spite of their worst impulses, Klaus Mikaelson’s daughter, 17-year-old Hope Mikaelson, Alaric Saltzman’s twins, Lizzie and Josie Saltzman, among others, come of age into heroes and villains at The Salvatore School for the Young and Gifted.", "Legacies" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1999-09-20", "https://image.tmdb.org/t/p/w300/jDCgWVlejIo8sQYxw3Yf1cVQUIL.jpg", 8, "In the criminal justice system, sexually-based offenses are considered especially heinous. In New York City, the dedicated detectives who investigate these vicious felonies are members of an elite squad known as the Special Victims Unit. These are their stories.", "Law & Order: Special Victims Unit" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2010-10-31", "https://image.tmdb.org/t/p/w300/rqeYMLryjcawh2JeRpCVUDXYM5b.jpg", 8, "Sheriff's deputy Rick Grimes awakens from a coma to find a post-apocalyptic world dominated by flesh-eating zombies. He sets out to find his family and encounters many other survivors along the way.", "The Walking Dead" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-11", "https://image.tmdb.org/t/p/w300/qSEKyf0fWhrCEQ3LTwLqe41eSvR.jpg", 8, "Takemichi Hanagaki is a freelancer that’s reached the absolute pits of despair in his life. He finds out that the only girlfriend he ever had, in middle school, Hinata Tachibana, had been killed by the ruthless Tokyo Manji Gang. The day after hearing about her death, he’s standing on the station platform and ends up being pushed over onto the tracks by a herd of people. He closes his eyes thinking he’s about to die, but when he opens his eyes back up, he somehow had gone back in time 12 years. Now that he’s back living the best days of his life, Takemichi decides to get revenge on his life.", "Tokyo Revengers" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2009-09-10", "https://image.tmdb.org/t/p/w300/kLEha9zVVv8acGFKTX4gjvSR2Q0.jpg", 8, "The story of two vampire brothers obsessed with the same girl, who bears a striking resemblance to the beautiful but ruthless vampire they knew and loved in 1864.", "The Vampire Diaries" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/dDZsbsqMEP0JZ6MYhuqliICUWPh.jpg", 7, "A year after a subglacial volcano erupts, mysterious elements from prehistoric times emerge from the melting ice, bringing unforeseen consequences.", "Katla" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-03-10", "https://image.tmdb.org/t/p/w300/yoRTuyC2cYLXJzKct9Iql0gcCL1.jpg", 0, "Five farmers look for love. The suitors will have to carry out various tests related to the world of agriculture in order to win the heart of each farmer.", "Quem Quer Namorar Com o Agricultor?" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2015-10-19", "https://image.tmdb.org/t/p/w300/qxbW47zmgFyBVmZSIqD9NA1DEjT.jpg", "Normal high school kids by day, protectors of Paris by night! Miraculous follows the heroic adventures of Marinette and Adrien as they transform into Ladybug and Cat Noir and set out to capture akumas, creatures responsible for turning the people of Paris into villains. But neither hero knows the other’s true identity – or that they’re classmates!", "Miraculous: Tales of Ladybug & Cat Noir" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2004-11-16", "https://image.tmdb.org/t/p/w300/lkvhReTBZ2Ksl0Dl5Oplsf6UYkF.jpg", 9, "Dr. Gregory House, a drug-addicted, unconventional, misanthropic medical genius, leads a team of diagnosticians at the fictional Princeton–Plainsboro Teaching Hospital in New Jersey.", "House" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-10-03", "https://image.tmdb.org/t/p/w300/g1rK2nRXSidcMwNliWDIroWWGTn.jpg", "With his days numbered, high schooler Yuji decides to hunt down and consume the remaining 19 fingers of a deadly curse so it can die with him.", "Jujutsu Kaisen" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-26", "https://image.tmdb.org/t/p/w300/yDWJYRAwMNKbIYT8ZB33qy84uzO.jpg", 9, "Mark Grayson is a normal teenager except for the fact that his father is the most powerful superhero on the planet. Shortly after his seventeenth birthday, Mark begins to develop powers of his own and enters into his father’s tutelage.", "Invincible" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2016-07-19", "https://image.tmdb.org/t/p/w300/7lBJ6lOS0uQqsH13U9iMTikawQS.jpg", 8, "A young woman born in a mafia-controlled town seeks revenge on those who wrongfully harmed and imprisoned her family.", "Sin senos sí hay paraíso" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2002-10-03", "https://image.tmdb.org/t/p/w300/vauCEnR7CiyBDzRCeElKkCaXIYu.jpg", "In another world, ninja are the ultimate power, and in the Village Hidden in the Leaves live the stealthiest ninja in the land. Twelve years earlier, the fearsome Nine-Tailed Fox terrorized the village and claimed many lives before it was subdued and its spirit sealed within the body of a baby boy. That boy, Naruto Uzumaki, has grown up to become a ninja-in-training who's more interested in pranks than in studying ninjutsu.. but Naruto is determined to become the greatest ninja ever!", "Naruto" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2011-06-05", "https://image.tmdb.org/t/p/w300/vY2vfAskJTiWsQSv6bdbNCQhPLm.jpg", 9, "Scott McCall, a high school student living in the town of Beacon Hills has his life drastically changed when he's bitten by a werewolf, becoming one himself. He must henceforth learn to balance his problematic new identity with his day-to-day teenage life. The following characters are instrumental to his struggle: Stiles, his best friend; Allison, his love interest who comes from a family of werewolf hunters; and Derek, a mysterious werewolf with a dark past. Throughout the series, he strives to keep his loved ones safe while maintaining normal relationships with them.", "Teen Wolf" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2013-04-15", "https://image.tmdb.org/t/p/w300/Ag7VUdnrRz5Qpq3Yn3E5OCvFnu0.jpg", "Set in the 1990s, these are the life and times of Amado Carrillo Fuentes, a man who became the head of the Juárez cartel. Nicknamed “El Señor de los Cielos” (Lord of the Skies) because of the large fleet of airplanes he used to transport drugs, he was also known for washing more than $200 million through Colombia to finance his huge fleet. He is described as the most powerful drug trafficker of his time.", "The Lord of the Skies" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2014-03-19", "https://image.tmdb.org/t/p/w300/wcaDIAG1QdXQLRaj4vC1EFdBT2.jpg", "100 years in the future, when the Earth has been abandoned due to radioactivity, the last surviving humans live on an ark orbiting the planet — but the ark won't last forever. So the repressive regime picks 100 expendable juvenile delinquents to send down to Earth to see if the planet is still habitable.", "The 100" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-05-02", "https://image.tmdb.org/t/p/w300/4CkQvdUAtoLW3qkjWi7t1MTnW7R.jpg", "This Karate Kid sequel series picks up 30 years after the events of the 1984 All Valley Karate Tournament and finds Johnny Lawrence on the hunt for redemption by reopening the infamous Cobra Kai karate dojo. This reignites his old rivalry with the successful Daniel LaRusso, who has been working to maintain the balance in his life without mentor Mr. Miyagi.", "Cobra Kai" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2015-08-23", "https://image.tmdb.org/t/p/w300/4UjiPdFKJGJYdxwRs2Rzg7EmWqr.jpg", "What did the world look like as it was transforming into the horrifying apocalypse depicted in \"The Walking Dead\"? This spin-off set in Los Angeles, following new characters as they face the beginning of the end of the world, will answer that question.", "Fear the Walking Dead" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-07", "https://image.tmdb.org/t/p/w300/s2L0tGpnWJMfaX1y0xUFcfKyX9p.jpg", 7, "Six months after the events of Monsters, Inc., the city of Monstropolis is now fueled with the sound of laughter. Tylor Tuskmon, a mechanic on the Facilities Team, dreams of working alongside his idols Mike Wazowski and James P. 'Sulley' Sullivan.", "Monsters at Work" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-07-23", "https://image.tmdb.org/t/p/w300/oogunE22HDTcTxFakKQbwqfw1qo.jpg", 5, "Each hour-long film follows a different women as they experience “moments that are emotionally raw, thought-provoking and utterly personal”.", "I Am..." });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2005-09-13", "https://image.tmdb.org/t/p/w300/KoYWXbnYuS3b0GyQPkbuexlVK9.jpg", "When they were boys, Sam and Dean Winchester lost their mother to a mysterious and demonic supernatural force. Subsequently, their father raised them to be soldiers. He taught them about the paranormal evil that lives in the dark corners and on the back roads of America ... and he taught them how to kill it. Now, the Winchester brothers crisscross the country in their '67 Chevy Impala, battling every kind of supernatural threat they encounter along the way. ", "Supernatural" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2017-04-26", "https://image.tmdb.org/t/p/w300/oIkxqt6ug5zT5ZSUUyc1Iqopf02.jpg", "Set in a dystopian future, a woman is forced to live as a concubine under a fundamentalist theocratic dictatorship. A TV adaptation of Margaret Atwood's novel.", "The Handmaid's Tale" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2008-01-20", "https://image.tmdb.org/t/p/w300/ggFHVNu6YYI5L9pCfOacjizRGt.jpg", 9, "When Walter White, a New Mexico chemistry teacher, is diagnosed with Stage III cancer and given a prognosis of only two years left to live. He becomes filled with a sense of fearlessness and an unrelenting desire to secure his family's financial future at any cost as he enters the dangerous world of drugs and crime.", "Breaking Bad" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-16", "https://image.tmdb.org/t/p/w300/hUmSMg5KHJkgeOk9AvbTINYOuEf.jpg", 7, "As Dwayne Johnson runs for president in 2032, he takes a comedic look back at his extraordinary life through the outrageous stories of his family and youth that shaped him into the man he is today. He explores his childhood years living amid influential wrestling icons while his dad rose to fame in the business, his rebellious teenage years attending high school in Pennsylvania, and his football years teamed up with powerhouse players at the University of Miami. In his telling, Johnson explains that while his experiences have been larger than life, he remains a down-to-earth guy who still relates to the American people.", "Young Rock" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-07-08", "https://image.tmdb.org/t/p/w300/nzBenFJ2D2MCWTwTt2uc4BGWLtA.jpg", 8, "Connecting all her hopes in her life to her education, Eda comes face to face with Serkan Bolat, who unknowingly cuts her scholarship abroad and caused her to remain a high school graduate. Serkan Bolat offers to give Eda her scholarship back if she pretends to be engaged to him for two months. Eda first rejects the offer due to her hatred for him, but when circumstances change, she has no choice but to accept the offer. While pretending to be engaged, Serkan and Eda begin to have a passionate, challenging relationship that will make you forget all they know right, because love is hard. And that's why it's amazing!!", "You Knock on My Door" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/EpDuYIK81YtCUT3gH2JDpyj8Qk.jpg", "Revisit the epic heroes, villains and moments from across the MCU in preparation for the stories still to come. Each dynamic segment feeds directly into the upcoming series — setting the stage for future events. This series weaves together the many threads that constitute the unparalleled Marvel Cinematic Universe.", "Marvel Studios: Legends" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/onPkMMtzcJs9A6vKljNBa3ujI8g.jpg", "Samuel attempts a big, romantic gesture at the airport in order to persuade Carla not to board her flight to London.", "Elite Short Stories: Carla Samuel" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2014-09-22", "https://image.tmdb.org/t/p/w300/hzeirSF6bRjssDh5JFrm5WRwFLd.jpg", "Based on a true story, Scorpion is a high-octane drama about eccentric genius Walter O’Brien and his team of brilliant misfits who comprise the last line of defense against complex, high-tech threats of the modern age. As Homeland Security’s new think tank, O’Brien’s “Scorpion” team includes Toby Curtis, an expert behaviorist who can read anyone; Happy Quinn, a mechanical prodigy; and Sylvester Dodd, a statistics guru.", "Scorpion" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2007-02-15", "https://image.tmdb.org/t/p/w300/zAYRe2bJxpWTVrwwmBc00VFkAf4.jpg", 9, "Naruto Shippuuden is the continuation of the original animated TV series Naruto.The story revolves around an older and slightly more matured Uzumaki Naruto and his quest to save his friend Uchiha Sasuke from the grips of the snake-like Shinobi, Orochimaru. After 2 and a half years Naruto finally returns to his village of Konoha, and sets about putting his ambitions to work, though it will not be easy, as He has amassed a few (more dangerous) enemies, in the likes of the shinobi organization; Akatsuki.", "Naruto Shippūden" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "1989-04-26", "https://image.tmdb.org/t/p/w300/dMB9UaXKUx7OnYlAgFfoixnRXgP.jpg", "After learning that he is from another planet, a warrior named Goku and his friends are prompted to defend it from an onslaught of extraterrestrial enemies.", "Dragon Ball Z" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2013-03-03", "https://image.tmdb.org/t/p/w300/bQLrHIRNEkE3PdIWQrZHynQZazu.jpg", "The adventures of Ragnar Lothbrok, the greatest hero of his age. The series tells the sagas of Ragnar's band of Viking brothers and his family, as he rises to become King of the Viking tribes. As well as being a fearless warrior, Ragnar embodies the Norse traditions of devotion to the gods. Legend has it that he was a direct descendant of Odin, the god of war and warriors.", "Vikings" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2016-07-15", "https://image.tmdb.org/t/p/w300/x2LSRK2Cm7MZhjluni1msVJ3wDF.jpg", "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supernatural forces, and one strange little girl.", "Stranger Things" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2016-01-21", "https://image.tmdb.org/t/p/w300/uzQpQGISbtxc047IOssFo5AiDwU.jpg", 7, "When heroes alone are not enough ... the world needs legends. Having seen the future, one he will desperately try to prevent from happening, time-traveling rogue Rip Hunter is tasked with assembling a disparate group of both heroes and villains to confront an unstoppable threat — one in which not only is the planet at stake, but all of time itself. Can this ragtag team defeat an immortal threat unlike anything they have ever known?", "DC's Legends of Tomorrow" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2001-10-16", "https://image.tmdb.org/t/p/w300/pUhJGETy2sec4vEkiqJ9eGeIywc.jpg", "The origins of the world’s greatest hero–from Krypton refugee Kal-el’s arrival on Earth through his tumultuous teen years to Clark Kent’s final steps toward embracing his destiny as the Man of Steel.", "Smallville" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1995-08-14", "https://image.tmdb.org/t/p/w300/17iXdZ7muzMefCtPz0LuFnjQqcC.jpg", 7, "María la del barrio, the third telenovela in the Las Tres Marías trilogy, is a Mexican telenovela starring Thalía, Fernando Colunga, Itatí Cantoral, Ricardo Blume, Irán Eory and the young actors Ludwika Paleta &amp; Osvaldo Benavides. It was produced and broadcast on Televisa in 1995–1996.\n\nThe series is a remake of Los Ricos También Lloran, which featured Verónica Castro, Rogelio Guerra and Rocío Banquells. María la del barrio is considered one of the most popular and successful telenovelas ever, having been broadcast in over 180 countries and watched by more than two billion people.", "María la del Barrio" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-11-12", "https://image.tmdb.org/t/p/w300/sWgBv7LV2PRoQgkxwlibdGXKz1S.jpg", "After the fall of the Galactic Empire, lawlessness has spread throughout the galaxy. A lone gunfighter makes his way through the outer reaches, earning his keep as a bounty hunter.", "The Mandalorian" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "1994-09-22", "https://image.tmdb.org/t/p/w300/f496cm9enuEsZkSPzCwnTESEK5s.jpg", "The misadventures of a group of friends as they navigate the pitfalls of work, life and love in Manhattan.", "Friends" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-16", "https://image.tmdb.org/t/p/w300/42bFOkD1eBDjyqn0uHSyAYuL2qv.jpg", 8, "After getting ousted from his job in the NCAA for throwing a chair at a referee, a hothead men’s basketball coach Marvyn Korn must take a job at Westbrook School for Girls, a private all-girls high school, in an effort to redeem what's left of his career and reputation.", "Big Shot" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-07-01", "https://image.tmdb.org/t/p/w300/jYeTfpxS3IzgqKkYCjmdCKwq8PW.jpg", "Trunks returns from the future to train with Goku and Vegeta. However, it disappears without warning. Then the mysterious Fu bursts in, telling them that Trunks has been imprisoned in the Prison Planet, a mysterious complex in an unknown place in the universes. The group seeks the dragon balls to free Trunks, but an endless battle awaits them! Will Goku and the others rescue Trunks and escape the Prison Planet?", "Super Dragon Ball Heroes" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2011-06-23", "https://image.tmdb.org/t/p/w300/vQiryp6LioFxQThywxbC6TuoDjy.jpg", "While running from a drug deal gone bad, Mike Ross, a brilliant young college-dropout, slips into a job interview with one of New York City's best legal closers, Harvey Specter. Tired of cookie-cutter law school grads, Harvey takes a gamble by hiring Mike on the spot after he recognizes his raw talent and photographic memory.", "Suits" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-24", "https://image.tmdb.org/t/p/w300/o7uk5ChRt3quPIv8PcvPfzyXdMw.jpg", "Hell-bent on exacting revenge and proving he was framed for his sister's murder, Álex sets out to unearth much more than the crime's real culprit.", "Who Killed Sara?" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2005-09-13", "https://image.tmdb.org/t/p/w300/eyTu5c8LniVciRZIOSHTvvkkgJa.jpg", "Dr. Temperance Brennan and her colleagues at the Jeffersonian's Medico-Legal Lab assist Special Agent Seeley Booth with murder investigations when the remains are so badly decomposed, burned or destroyed that the standard identification methods are useless.", "Bones" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-07-08", "https://image.tmdb.org/t/p/w300/wWwTjKER5a8LRUGHrw86VU0gUy1.jpg", "Years after the horrors Raccoon City, Leon and Claire find themselves consumed by a dark conspiracy when a viral attack ravages the White House.", "RESIDENT EVIL: Infinite Darkness" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2008-09-23", "https://image.tmdb.org/t/p/w300/acYXu4KaDj1NIkMgObnhe4C4a0T.jpg", "Patrick Jane, a former celebrity psychic medium, uses his razor sharp skills of observation and expertise at \"reading\" people to solve serious crimes with the California Bureau of Investigation.", "The Mentalist" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/sgxawbFB5Vi5OkPWQLNfl3dvkNJ.jpg", "Inspired by the adventures of Arsène Lupin, gentleman thief Assane Diop sets out to avenge his father for an injustice inflicted by a wealthy family.", "Lupin" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2003-09-23", "https://image.tmdb.org/t/p/w300/fi8EvaWtL5CvoielOjjVvTr7ux3.jpg", "From murder and espionage to terrorism and stolen submarines, a team of special agents investigates any crime that has a shred of evidence connected to Navy and Marine Corps personnel, regardless of rank or position.", "NCIS" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-07-01", "https://image.tmdb.org/t/p/w300/6CHznbr0BF78ar16zJwTVRYLLOX.jpg", 10, "Prince Wilhelm adjusts to life at his prestigious new boarding school, Hillerska, but following his heart proves more challenging than anticipated.", "Young Royals" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-09-23", "https://image.tmdb.org/t/p/w300/htJzeRcYI2ewMm4PTrg98UMXShe.jpg", 7, "Raymond \"Red\" Reddington, one of the FBI's most wanted fugitives, surrenders in person at FBI Headquarters in Washington, D.C. He claims that he and the FBI have the same interests: bringing down dangerous criminals and terrorists. In the last two decades, he's made a list of criminals and terrorists that matter the most but the FBI cannot find because it does not know they exist. Reddington calls this \"The Blacklist\". Reddington will co-operate, but insists that he will speak only to Elizabeth Keen, a rookie FBI profiler.", "The Blacklist" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2004-10-04", "https://image.tmdb.org/t/p/w300/iehrrb9CmYCiV1hXp5pdGQQmGNe.jpg", 8, "The series is set at the Elite Way School, a prestigious private boarding high school in Mexico City with a major plot line revolving around a group of students forming a pop band. Additional subplots involve the school's faculty and the students' parents. One trademark of the show is the random use of English words and phrases, often used by fresa characters.", "Rebelde" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2012-10-10", "https://image.tmdb.org/t/p/w300/6AccYL0eb7uzHn98IKaNjvJbyuA.jpg", "An edge-of-your-seat view into the lives of everyday heroes committed to one of America's noblest professions. For the firefighters, rescue squad and paramedics of Chicago Firehouse 51, no occupation is more stressful or dangerous, yet so rewarding and exhilarating. These courageous men and women are among the elite who forge headfirst into danger when everyone else is running the other way and whose actions make the difference between life and death.", "Chicago Fire" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-07-25", "https://image.tmdb.org/t/p/w300/mY7SeH4HFFxW1hiI6cWuwCRKptN.jpg", 8, "A group of vigilantes known informally as “The Boys” set out to take down corrupt superheroes with no more than blue-collar grit and a willingness to fight dirty.", "The Boys" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2005-09-22", "https://image.tmdb.org/t/p/w300/7TCwgX7oQKxcWYEhSPRmaHe6ULN.jpg", 8, "An elite team of FBI profilers analyze the country's most twisted criminal minds, anticipating their next moves before they strike again. The Behavioral Analysis Unit's most experienced agent is David Rossi, a founding member of the BAU who returns to help the team solve new cases.", "Criminal Minds" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieId",
                table: "MovieReview",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_ProfileId",
                table: "MovieReview",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowReview_ProfileId",
                table: "TvShowReview",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowReview_TvShowId",
                table: "TvShowReview",
                column: "TvShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "TvShowReview");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-26", "https://image.tmdb.org/t/p/w300/rTh4K5uw9HypmpGslcKd4QfHl93.jpg", 9, "In 1970s London amidst the punk rock revolution, a young grifter named Estella is determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. One day, Estella’s flair for fashion catches the eye of the Baroness von Hellman, a fashion legend who is devastatingly chic and terrifyingly haute. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.", "Cruella" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-25", "https://image.tmdb.org/t/p/w300/xbSuFiJbbBWCkyCCKIMfuDCA4yV.jpg", 8, "Paranormal investigators Ed and Lorraine Warren encounter what would become one of the most sensational cases from their files. The fight for the soul of a young boy takes them beyond anything they'd ever seen before, to mark the first time in U.S. history that a murder suspect would claim demonic possession as a defense.", "The Conjuring: The Devil Made Me Do It" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-22", "https://image.tmdb.org/t/p/w300/M7SUK85sKjaStg4TKhlAVyGlz3.jpg", "A cold and mysterious new security guard for a Los Angeles cash truck company surprises his co-workers when he unleashes precision skills during a heist. The crew is left wondering who he is and where he came from. Soon, the marksman's ultimate motive becomes clear as he takes dramatic and irrevocable steps to settle a score.", "Wrath of Man" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/w6n1pu9thpCVHILejsuhKf3tNCV.jpg", 7, "Before he built a drug empire, Ferry Bouman returns to his hometown on a revenge mission that finds his loyalty tested — and a love that alters his life.", "Ferry" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-16", "https://image.tmdb.org/t/p/w300/AoWY1gkcNzabh229Icboa1Ff0BM.jpg", 6, "Victoria is a young mother trying to put her dark past as a Russian drug courier behind her, but retired cop Damon forces Victoria to do his bidding by holding her daughter hostage. Now, Victoria must use guns, guts and a motorcycle to take out a series of violent gangsters—or she may never see her child again.", "Vanquish" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-04", "https://image.tmdb.org/t/p/w300/cwUhVcDeMYYeu8fq5q1OPOoSbZ7.jpg", 7, "Two years after the murder of his son and father, a retired hitman sets in motion a carefully crafted revenge plan against the killer: his own brother.", "Xtreme" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-07", "https://image.tmdb.org/t/p/w300/nkayOAUBUu4mMvyNf9iHSUiPjF1.jpg", 8, "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against the enemies of Outworld in a high stakes battle for the universe.", "Mortal Kombat" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/z8CExJekGrEThbpMXAmCFvvgoJR.jpg", 6, "Following a zombie outbreak in Las Vegas, a group of mercenaries take the ultimate gamble: venturing into the quarantine zone to pull off the greatest heist ever attempted.", "Army of the Dead" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-24", "https://image.tmdb.org/t/p/w300/pgqgaUx1cJb5oZQQ5v0tNARCeBp.jpg", "In a time when monsters walk the Earth, humanity’s fight for its future sets Godzilla and Kong on a collision course that will see the two most powerful forces of nature on the planet collide in a spectacular battle for the ages.", "Godzilla vs. Kong" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-27", "https://image.tmdb.org/t/p/w300/ccsSqbpEqr2KK9eMvoeF8ERFCd5.jpg", 7, "Jack Halsey takes his wife, their adult kids, and a friend for a dream vacation in Kenya. But as they venture off alone into a wilderness park, their safari van is flipped over by an angry rhino, leaving them injured and desperate. Then, as two of them go in search of rescue, a bloody, vicious encounter with a leopard and a clan of hyenas incites a desperate fight for survival.", "Endangered Species" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-21", "https://image.tmdb.org/t/p/w300/4q2hz2m8hubgvijz8Ez0T2Os2Yv.jpg", 7, "Following the events at home, the Abbott family now face the terrors of the outside world. Forced to venture into the unknown, they realize that the creatures that hunt by sound are not the only threats that lurk beyond the sand path.", "A Quiet Place Part II" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-29", "https://image.tmdb.org/t/p/w300/rEm96ib0sPiZBADNKBHKBv5bve9.jpg", 7, "An elite Navy SEAL uncovers an international conspiracy while seeking justice for the murder of his pregnant wife.", "Tom Clancy's Without Remorse" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-31", "https://image.tmdb.org/t/p/w300/bShgiEQoPnWdw4LBrYT5u18JF34.jpg", 7, "Alice, a young hearing-impaired girl who, after a supposed visitation from the Virgin Mary, is inexplicably able to hear, speak and heal the sick. As word spreads and people from near and far flock to witness her miracles, a disgraced journalist hoping to revive his career visits the small New England town to investigate. When terrifying events begin to happen all around, he starts to question if these phenomena are the works of the Virgin Mary or something much more sinister.", "The Unholy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-12", "https://image.tmdb.org/t/p/w300/lcyKve7nXRFgRyms9M1bndNkKOx.jpg", "Working in the shadow of an esteemed police veteran, brash Detective Ezekiel “Zeke” Banks and his rookie partner take charge of a grisly investigation into murders that are eerily reminiscent of the city’s gruesome past.  Unwittingly entrapped in a deepening mystery, Zeke finds himself at the center of the killer’s morbid game.", "Spiral: From the Book of Saw" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-30", "https://image.tmdb.org/t/p/w300/vXHzO26mJaOt4VO7ZFiM6No5ScT.jpg", 6, "A lonesome stranger with nerves of steel must track down and kill a rogue hitman to satisfy an outstanding debt. But the only information he's been given is a time and location where to find his quarry. No name. No description. Nothing.", "The Virtuoso" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-05", "https://image.tmdb.org/t/p/w300/xCEg6KowNISWvMh8GvPSxtdf9TO.jpg", 7, "A young boy finds himself pursued by two assassins in the Montana wilderness with a survival expert determined to protecting him - and a forest fire threatening to consume them all.", "Those Who Wish Me Dead" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-26", "https://image.tmdb.org/t/p/w300/oBgWY00bEFeZ9N25wWVyuQddbAo.jpg", "Hutch Mansell, a suburban dad, overlooked husband, nothing neighbor — a \"nobody.\" When two thieves break into his home one night, Hutch's unknown long-simmering rage is ignited and propels him on a brutal path that will uncover dark secrets he fought to leave behind.", "Nobody" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-14", "https://image.tmdb.org/t/p/w300/m6bUeV4mczG3z2YXXr5XDKPsQzv.jpg", "A special crimes investigator forms an unlikely bond with a serial killer to bring down a global child sex trafficking syndicate.", "I Am All Girls" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-18", "https://image.tmdb.org/t/p/w300/tnAuB8q5vv7Ax9UAEje5Xi4BXik.jpg", "Determined to ensure Superman's ultimate sacrifice was not in vain, Bruce Wayne aligns forces with Diana Prince with plans to recruit a team of metahumans to protect the world from an approaching threat of catastrophic proportions.", "Zack Snyder's Justice League" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-10-16", "https://image.tmdb.org/t/p/w300/h8Rb9gBr48ODIwYUttZNYeMWeUU.jpg", 8, "Tanjirō Kamado, joined with Inosuke Hashibira, a boy raised by boars who wears a boar's head, and Zenitsu Agatsuma, a scared boy who reveals his true power when he sleeps, boards the Infinity Train on a new mission with the Fire Hashira, Kyōjurō Rengoku, to defeat a demon who has been tormenting the people and killing the demon slayers who oppose it!", "Demon Slayer -Kimetsu no Yaiba- The Movie: Mugen Train" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-09", "https://image.tmdb.org/t/p/w300/uZkNbB8isWXHMDNoIbqXvmslBMC.jpg", 6, "After a sudden global event wipes out all electronics and takes away humankind’s ability to sleep, chaos quickly begins to consume the world. Only Jill, an ex-soldier with a troubled past, may hold the key to a cure in the form of her own daughter. The question is, can Jill safely deliver her daughter and save the world before she herself loses her mind.", "Awake" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-09", "https://image.tmdb.org/t/p/w300/3mKMWP5OokB7QpcOMA1yl8BXFAF.jpg", 6, "In a world where supervillains are commonplace, two estranged childhood best friends reunite after one devises a treatment that gives them powers to protect their city.", "Thunder Force" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-03", "https://image.tmdb.org/t/p/w300/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg", "Long ago, in the fantasy world of Kumandra, humans and dragons lived together in harmony. But when an evil force threatened the land, the dragons sacrificed themselves to save humanity. Now, 500 years later, that same evil has returned and it’s up to a lone warrior, Raya, to track down the legendary last dragon to restore the fractured land and its divided people.", "Raya and the Last Dragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/7rhzEufovmmUqVjcbzMHTBQ2SCG.jpg", 8, "Two young boys experience an unforgettable Italian summer filled with gelato, pasta and endless scooter rides. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.", "Luca" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-09-08", "https://image.tmdb.org/t/p/w300/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg", 0, "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, revealing that his memories are real.", "Infinite" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-02", "https://image.tmdb.org/t/p/w300/dkokENeY5Ka30BFgWAqk14mbnGs.jpg", "Drac tries out some new monster pets to help occupy Tinkles for playtime.", "Monster Pets: A Hotel Transylvania Short" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-03", "https://image.tmdb.org/t/p/w300/nc7szo7ChOknEk8qCkABJyNgl5y.jpg", "Frederick Fitzell is living his best life—until he starts having horrific visions of Cindy, a girl who vanished in high school. After reaching out to old friends with whom he used to take a mystery drug called Mercury, Fredrick realizes the only way to stop the visions lies deep within his own memories, so he embarks on a terrifying mental odyssey to learn the truth.", "Flashback" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-04", "https://image.tmdb.org/t/p/w300/msI5a9TPnepx47JUb2vl88hb80R.jpg", "On school break, Marinette heads to Shanghai to meet Adrien. But after arriving, Marinette loses all her stuff, including the Miraculous that allows her to turn into Ladybug!", "Miraculous World: Shanghai – The Legend of Ladydragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/y1Tk1LUwS3nRlugiXnag6Bu1ToG.jpg", 7, "Having just returned home, decorated U.S. Marine Captain Brad Paxton's wife, Kate, is kidnapped by a terrorist group while working in Morocco. He is forced back into action for a daring and deadly operation to save the woman he loves.", "Redemption Day" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-19", "https://image.tmdb.org/t/p/w300/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg", "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.", "F9" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-12", "https://image.tmdb.org/t/p/w300/nxxuWC32Y6TULj4VnVwMPUFLIpK.jpg", "A former intelligence agent gets involved with the first human clone, Seo Bok, who others seek, causing trouble.", "Seobok" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-12-16", "https://image.tmdb.org/t/p/w300/8UlWHLMpgZm9bx6QYh0NFoq67TZ.jpg", "A botched store robbery places Wonder Woman in a global battle against a powerful and mysterious ancient force that puts her powers in jeopardy.", "Wonder Woman 1984" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-04-03", "https://image.tmdb.org/t/p/w300/nAU74GmpUk7t5iklEp3bufwDq4n.jpg", "A family is forced to live in silence while hiding from creatures that hunt by sound.", "A Quiet Place" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-30", "https://image.tmdb.org/t/p/w300/32vLDKSzcCMh55zqqaSqqUA8naz.jpg", "Set before the events of ‘Soul’, 22 refuses to go to Earth, enlisting a gang of 5 new souls in attempt of rebellion. However, 22’s subversive plot leads to a surprising revelation about the meaning of life.", "22 vs. Earth" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { null, "https://image.tmdb.org/t/p/w300/2DyEk84XnbJEdPlGF43crxfdtHH.jpg", 0, "The penultimate installment of the Fast and Furious franchise.", "Fast & Furious 10" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/6vcDalR50RWa309vBH1NLmG2rjQ.jpg", 7, "Jim Hanson’s quiet life is suddenly disturbed by two people crossing the US/Mexico border – a woman and her young son – desperate to flee a Mexican cartel. After a shootout leaves the mother dead, Jim becomes the boy’s reluctant defender. He embraces his role as Miguel’s protector and will stop at nothing to get him to safety, as they go on the run from the relentless assassins.", "The Marksman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-05", "https://image.tmdb.org/t/p/w300/AmUGn1rJ9XDDP6DYn9OA2uV8MIg.jpg", "Transferred home after a traumatizing combat mission, a highly trained French soldier uses her lethal skills to hunt down the man who hurt her sister.", "Sentinelle" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-26", "https://image.tmdb.org/t/p/w300/ao4JajLcPITivfstlzENge3MPkq.jpg", "Three stories about the world of opioids collide: a drug trafficker arranges a multi-cartel Fentanyl smuggling operation between Canada and the U.S., an architect recovering from an OxyContin addiction tracks down the truth behind her son's involvement with narcotics, and a university professor battles unexpected revelations about his research employer, a drug company with deep government influence bringing a new \"non-addictive\" painkiller to market.", "Crisis" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-11", "https://image.tmdb.org/t/p/w300/8XZI9QZ7Pm3fVkigWJPbrXCMzjq.jpg", 7, "Tom the cat and Jerry the mouse get kicked out of their home and relocate to a fancy New York hotel, where a scrappy employee named Kayla will lose her job if she can’t evict Jerry before a high-class wedding at the hotel. Her solution? Hiring Tom to get rid of the pesky mouse.", "Tom & Jerry" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-03", "https://image.tmdb.org/t/p/w300/1UCOF11QCw8kcqvce8LKOO6pimh.jpg", 7, "A portal transports Cpt. Artemis and an elite unit of soldiers to a strange world where powerful monsters rule with deadly ferocity. Faced with relentless danger, the team encounters a mysterious hunter who may be their only hope to find a way home.", "Monster Hunter" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-11", "https://image.tmdb.org/t/p/w300/f91rtk8dODezNLT3grQrELyzFwA.jpg", "While under the care of the Outer Sailor Guardians, Hotaru begins to age rapidly. Then, the time comes for all the Sailor Guardians to reunite!", "Pretty Guardian Sailor Moon Eternal The Movie Part 2" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-10", "https://image.tmdb.org/t/p/w300/RO4KoJyoQMQzh9z76d4v4FJMmJ.jpg", 8, "The story of Usnavi, a bodega owner who has mixed feelings about closing his store and retiring to the Dominican Republic or staying in Washington Heights.", "In the Heights" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-12-19", "https://image.tmdb.org/t/p/w300/arHW8z3uHVknHc24dvc1pQvxjw.jpg", 6, "A group of unlikely heroes from across the Korean peninsula try to save the day after a volcano erupts on the mythical and majestic Baekdu Mountain.", "Ashfall" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-04", "https://image.tmdb.org/t/p/w300/1tpuwM9fZFcMNkkGU0WwqPAEaFz.jpg", 7, "To rekindle their marriages, best friends-turned-in-laws Shanthi and Jennifer plan a couples' getaway. But it comes with all kinds of surprises.", "Trippin’ with the Kandasamys" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2016-05-13", "https://image.tmdb.org/t/p/w300/zEqyD0SBt6HL7W9JQoWwtd5Do1T.jpg", "Lorraine and Ed Warren travel to north London to help a single mother raising four children alone in a house plagued by malicious spirits.", "The Conjuring 2" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-25", "https://image.tmdb.org/t/p/w300/hm58Jw4Lw8OIeECIq5qyPYhAeRJ.jpg", 8, "Joe Gardner is a middle school teacher with a love for jazz music. After a successful gig at the Half Note Club, he suddenly gets into an accident that separates his soul from his body and is transported to the You Seminar, a center in which souls develop and gain passions before being transported to a newborn child. Joe must enlist help from the other souls-in-training, like 22, a soul who has spent eons in the You Seminar, in order to get back to Earth.", "Soul" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-03-20", "https://image.tmdb.org/t/p/w300/wVYREutTvI2tmxr6ujrHT704wGF.jpg", 8, "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse. Forced to confront a powerful entity, the Warrens find themselves caught in the most terrifying case of their lives.", "The Conjuring" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-07", "https://image.tmdb.org/t/p/w300/tMS2qcbhbkFpcwLnbUE9o9IK4HH.jpg", "When Maya, a headstrong little bee, and her best friend Willi, rescue an ant princess they find themselves in the middle of an epic bug battle that will take them to strange new worlds and test their friendship to its limits.", "Maya the Bee: The Golden Orb" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-27", "https://image.tmdb.org/t/p/w300/bT3c4TSOP8vBmMoXZRDPTII6eDa.jpg", 8, "The cast of Friends reunites for a once-in-a-lifetime celebration of the hit series, an unforgettable evening filled with iconic memories, uncontrollable laughter, happy tears, and special guests.", "Friends: The Reunion" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-29", "https://image.tmdb.org/t/p/w300/xD9mc8JCVXA8T8u4Od7qOUBuGH4.jpg", 6, "In the 1930s, a young reverend and his family are forced to confront their worst fears when they discover their new home holds a horrifying secret.", "The Banishing" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-24", "https://image.tmdb.org/t/p/w300/9kg73Mg8WJKlB9Y2SAJzeDKAnuB.jpg", "Two unlikely companions embark on a perilous adventure through the badlands of an unexplored planet as they try to escape a dangerous and disorienting reality, where all inner thoughts are seen and heard by everyone.", "Chaos Walking" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-08", "https://image.tmdb.org/t/p/w300/jDwZavHo99JtGsCyRzp4epeeBHx.jpg", "In the aftermath of the Fourth Impact, stranded without their Evangelions, Shinji, Asuka, and Rei search for refuge in the desolate red remains of Tokyo-3. But the danger to the world is far from over. A new impact is looming on the horizon—one that will prove to be the true end of Evangelion.", "Evangelion: 3.0+1.0 Thrice Upon a Time" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-22", "https://image.tmdb.org/t/p/w300/foQnDv051kQ7satMQkbkPsUxzkD.jpg", 6, "Siblings Mimi and Luke unwittingly resurrect an ancient alien overlord. Using a magical amulet, they force the monster to obey their childish whims, and accidentally attract a rogues’ gallery of intergalactic assassins to small-town suburbia.", "Psycho Goreman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-08-01", "https://image.tmdb.org/t/p/w300/qRyy2UmjC5ur9bDi3kpNNRCc5nc.jpg", "Ever since US Diplomatic Security Service Agent Hobbs and lawless outcast Shaw first faced off, they just have traded smack talk and body blows. But when cyber-genetically enhanced anarchist Brixton's ruthless actions threaten the future of humanity, they join forces to defeat him.", "Fast & Furious Presents: Hobbs & Shaw" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-07-09", "https://image.tmdb.org/t/p/w300/95S6PinQIvVe4uJAd82a2iGZ0rA.jpg", 5, "An adventure-loving couple convince their friends to explore a remote, uncharted cave system in the forests of Northern Australia. With a tropical storm approaching, they abseil into the mouth of the cave, but when the caves start to flood, tensions rise as oxygen levels fall and the friends find themselves trapped. Unknown to them, the storm has also brought in a pack of dangerous and hungry crocodiles.", "Black Water: Abyss" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-11-25", "https://image.tmdb.org/t/p/w300/tbVZ3Sq88dZaCANlUcewQuHQOaE.jpg", 8, "Searching for a safer habitat, the prehistoric Crood family discovers an idyllic, walled-in paradise that meets all of its needs. Unfortunately, they must also learn to live with the Bettermans -- a family that's a couple of steps above the Croods on the evolutionary ladder. As tensions between the new neighbors start to rise, a new threat soon propels both clans on an epic adventure that forces them to embrace their differences, draw strength from one another, and survive together.", "The Croods: A New Age" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-06", "https://image.tmdb.org/t/p/w300/6goDkAD6J3br81YMQf0Gat8Bqjy.jpg", 9, "3000 years after the boy-god Nezha conquers the Dragon King then disappears in mythological times, he returns as an ordinary man to find his own path to becoming a true hero.", "New Gods: Nezha Reborn" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-12", "https://image.tmdb.org/t/p/w300/keEnkeAvifw8NSEC4f6WsqeLJgF.jpg", "When his car breaks down, a quiet loner agrees to clean an abandoned family fun center in exchange for repairs. He soon finds himself waging war against possessed animatronic mascots while trapped inside Willy's Wonderland.", "Willy's Wonderland" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-05-04", "https://image.tmdb.org/t/p/w300/2xnf2ZaGXudvgBKPtVXMkNeooh1.jpg", "In a daycare far, far away… but still in Springfield, Maggie is on an epic quest for her stolen pacifier. Her adventure brings her face-to-face with young Padawans, Sith Lords, familiar droids, Rebel scum, and an ultimate battle against the dark side, in this original short celebrating the Star Wars galaxy.", "Maggie Simpson in The Force Awakens from Its Nap" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-27", "https://image.tmdb.org/t/p/w300/e4REOC6CZW8J6FslA4nRvdQXFXR.jpg", 8, "While speeding off to help in an impromptu battle, The Flash blazes and rips through time, only to find himself dropped into the middle of World War II. It’s here that The Flash meets Wonder Woman and her top secret team, known as the Justice Society of America. Amidst the raging tides of war, gripping combat and the velocity of valor, The Flash must fight to return to his own timeline.", "Justice Society: World War II" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-09-26", "https://image.tmdb.org/t/p/w300/19kfvGktytDZInUmpv3WlaHoTxP.jpg", 8, "During a school field trip, Ladybug and Cat Noir meet the American superheroes, whom they have to save from an akumatised super-villain. They discover that Miraculous exist in the United States too.", "Miraculous World: New York, United HeroeZ" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/6XYLiMxHAaCsoyrVo38LBWMw2p8.jpg", 6, "In the near future, a drone pilot is sent into a deadly militarized zone and must work with an android officer to locate a doomsday device.", "Outside the Wire" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-03", "https://image.tmdb.org/t/p/w300/xq2pkQZV5Yt1METvy5S0QjmCpsn.jpg", 6, "The story of Dylan Pettersson, a 23-year-old girl from a small island in the Swedish archipelago with big dancing aspirations.", "Dancing Queens" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-12-20", "https://image.tmdb.org/t/p/w300/zGVbrulkupqpbwgiNedkJPyQum4.jpg", 8, "Class 1-A visits Nabu Island where they finally get to do some real hero work. The place is so peaceful that it's more like a vacation … until they're attacked by a villain with an unfathomable Quirk! His power is eerily familiar, and it looks like Shigaraki had a hand in the plan. But with All Might retired and citizens' lives on the line, there's no time for questions. Deku and his friends are the next generation of heroes, and they're the island's only hope.", "My Hero Academia: Heroes Rising" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-29", "https://image.tmdb.org/t/p/w300/dWSnsAGTfc8U27bWsy2RfwZs0Bs.jpg", 6, "When a prisoner transfer van is attacked, the cop in charge must fight those inside and outside while dealing with a silent foe: the icy temperatures.", "Below Zero" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-02-05", "https://image.tmdb.org/t/p/w300/h4VB6m0RwcicVEZvzftYZyKXs6K.jpg", "Harley Quinn joins forces with a singer, an assassin and a police detective to help a young girl who had a hit placed on her after she stole a rare diamond from a crime lord.", "Birds of Prey (and the Fantabulous Emancipation of One Harley Quinn)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-11-21", "https://image.tmdb.org/t/p/w300/mQ8vALvqA0z0qglG3gI6xpVcslo.jpg", 6, "Jack, a man desperate to improve his life, throws away his beloved childhood plush, Benny. It’s a move that has disastrous consequences when Benny springs to life with deadly intentions!", "Benny Loves You" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-09-30", "https://image.tmdb.org/t/p/w300/mKvw1Ic9enfFlCPBNJGiejRPMUO.jpg", "Covert security company Vanguard is the last hope of survival for an accountant after he is targeted by the world's deadliest mercenary organization.", "Vanguard" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-10-02", "https://image.tmdb.org/t/p/w300/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg", 8, "During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming an infamous psychopathic crime figure.", "Joker" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-07-02", "https://image.tmdb.org/t/p/w300/qzA87Wf4jo1h8JMk9GilyIYvwsA.jpg", 6, "A black ops assassin is forced to fight for her own survival after a job goes dangerously wrong.", "Ava" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-01", "https://image.tmdb.org/t/p/w300/unIkHTdCEIdHdtmWjEwfv7Ifllk.jpg", 7, "From Goldilocks to Hansel and Gretel, the Super Monsters reimagine classic fairy tales and favorite nursery rhymes with a musical, magical spin!", "Super Monsters: Once Upon a Rhyme" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-02-26", "https://image.tmdb.org/t/p/w300/pwDvkDyaHEU9V7cApQhbcSJMG1w.jpg", 8, "Cherry drifts from college dropout to army medic in Iraq - anchored only by his true love, Emily. But after returning from the war with PTSD, his life spirals into drugs and crime as he struggles to find his place in the world.", "Cherry" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-05", "https://image.tmdb.org/t/p/w300/p9YDHJKvUoi7v2SCd3vLGPae1Xp.jpg", "When the crew of a space junk collector ship called The Victory discovers a humanoid robot named Dorothy that's known to be a weapon of mass destruction, they get involved in a risky business deal which puts their lives at stake.", "Space Sweepers" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-04-08", "https://image.tmdb.org/t/p/w300/vX1XLbrHxpryX9EOWI3akbasz6c.jpg", 8, "Su, a woman whose friends are only men, finds herself forced to follow a series of absurd instructions to overcome the unexpected death of her fiancé.", "Instructions for Su" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-26", "https://image.tmdb.org/t/p/w300/vdMsMYfkHJ6mLht5QCg7Hl8hnEp.jpg", 6, "After witnessing a haunting in their hospital, two doctors become dangerously obsessed with obtaining scientific proof that ghosts exist.", "Ghost Lab" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-10-25", "https://image.tmdb.org/t/p/w300/b1C0FuXp4wiPmHLVKq4kwtDMgK6.jpg", 7, "In late 1967, a young orphaned boy goes to live with his loving grandma in the rural Alabama town of Demopolis. As the boy and his grandmother encounter some deceptively glamorous but thoroughly diabolical witches, she wisely whisks him away to a seaside resort. Regrettably, they arrive at precisely the same time that the world's Grand High Witch has gathered.", "Roald Dahl's The Witches" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-04-25", "https://image.tmdb.org/t/p/w300/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", 8, "As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain.", "Avengers: Infinity War" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-17", "https://image.tmdb.org/t/p/w300/13B6onhL6FzSN2KaNeQeMML05pS.jpg", 4, "A hardened mechanic must stay awake and maintain an interstellar ark fleeing the dying planet Earth with a few thousand lucky souls on board... the last of humanity. Unfortunately, humans are not the only passengers. A shapeshifting alien creature has taken residence, its only goal is to kill as many people as possible. The crew must think quickly to stop this menace before it destroys mankind.", "Breach" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2008-10-17", "https://image.tmdb.org/t/p/w300/cYl39kCMjP37e39CbJqxWHvf1ez.jpg", "Loki brings the trajectory of Arnaldo Baptista from childhood, passing through the most successful phase as leader of the Mutantes, marriage to singer Rita Lee and then separation. He also goes through the depression that devastated his life after the group ended and that led him to attempt suicide, his solo career, rapprochement with his brother and member of the Mutantes, Sérgio Dias, culminating in the band's return in 2006.", "Loki - Arnaldo Baptista" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-04", "https://image.tmdb.org/t/p/w300/rgMfhcrVZjuy5b7Pn0KzCRCEnMX.jpg", 8, "On a perilous adventure across a post-apocalyptic world, a lovable boy who's half-human and half-deer searches for a new beginning with a gruff protector.", "Sweet Tooth" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2016-01-25", "https://image.tmdb.org/t/p/w300/4EYPN5mVIhKLfxGruy7Dy41dTVn.jpg", 8, "Bored and unhappy as the Lord of Hell, Lucifer Morningstar abandoned his throne and retired to Los Angeles, where he has teamed up with LAPD detective Chloe Decker to take down criminals. But the longer he's away from the underworld, the greater the threat that the worst of humanity could escape.", "Lucifer" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2014-10-07", "https://image.tmdb.org/t/p/w300/lJA2RCMfsWoskqlQhXPSLFQGXEJ.jpg", 8, "After a particle accelerator causes a freak storm, CSI Investigator Barry Allen is struck by lightning and falls into a coma. Months later he awakens with the power of super speed, granting him the ability to move through Central City like an unseen guardian angel. Though initially excited by his newfound powers, Barry is shocked to discover he is not the only \"meta-human\" who was created in the wake of the accelerator explosion -- and not everyone is using their new powers for good. Barry partners with S.T.A.R. Labs and dedicates his life to protect the innocent. For now, only a few close friends and associates know that Barry is literally the fastest man alive, but it won't be long before the world learns what Barry Allen has become...The Flash.", "The Flash" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2017-09-25", "https://image.tmdb.org/t/p/w300/6tfT03sGp9k4c0J3dypjrI8TSAI.jpg", 9, "A young surgeon with Savant syndrome is recruited into the surgical unit of a prestigious hospital. The question will arise: can a person who doesn't have the ability to relate to people actually save their lives", "The Good Doctor" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-10-05", "https://image.tmdb.org/t/p/w300/3NTAbAiao4JLzFQw6YxP1YZppM8.jpg", "When three working class kids enroll in the most exclusive school in Spain, the clash between the wealthy and the poor students leads to tragedy.", "Elite" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-03-19", "https://image.tmdb.org/t/p/w300/6kbAMLteGO8yyewYau6bJ683sw7.jpg", "Following the events of “Avengers: Endgame”, the Falcon, Sam Wilson and the Winter Soldier, Bucky Barnes team up in a global adventure that tests their abilities, and their patience.", "The Falcon and the Winter Soldier" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-02-23", "https://image.tmdb.org/t/p/w300/vlv1gn98GqMnKHLSh0dNciqGfBl.jpg", "After years of facing megalomaniacal supervillains, monsters wreaking havoc on Metropolis, and alien invaders intent on wiping out the human race, The Man of Steel aka Clark Kent and Lois Lane come face to face with one of their greatest challenges ever: dealing with all the stress, pressures and complexities that come with being working parents in today's society.", "Superman & Lois" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2005-03-27", "https://image.tmdb.org/t/p/w300/clnyhPqj1SNgpAdeSS6a6fwE6Bo.jpg", 8, "Follows the personal and professional lives of a group of doctors at Seattle’s Grey Sloan Memorial Hospital.", "Grey's Anatomy" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-01-31", "https://image.tmdb.org/t/p/w300/xUtOM1QO4r8w8yeE00QvBdq58N5.jpg", "A small Norwegian town experiencing warm winters and violent downpours seems to be headed for another Ragnarök -- unless someone intervenes in time.", "Ragnarok" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/sgxawbFB5Vi5OkPWQLNfl3dvkNJ.jpg", 8, "Inspired by the adventures of Arsène Lupin, gentleman thief Assane Diop sets out to avenge his father for an injustice inflicted by a wealthy family.", "Lupin" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2015-08-23", "https://image.tmdb.org/t/p/w300/4UjiPdFKJGJYdxwRs2Rzg7EmWqr.jpg", 8, "What did the world look like as it was transforming into the horrifying apocalypse depicted in \"The Walking Dead\"? This spin-off set in Los Angeles, following new characters as they face the beginning of the end of the world, will answer that question.", "Fear the Walking Dead" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2017-01-26", "https://image.tmdb.org/t/p/w300/wRbjVBdDo5qHAEOVYoMWpM58FSA.jpg", 9, "Set in the present, the series offers a bold, subversive take on Archie, Betty, Veronica and their friends, exploring the surreality of small-town life, the darkness and weirdness bubbling beneath Riverdale’s wholesome facade.", "Riverdale" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2017-04-26", "https://image.tmdb.org/t/p/w300/oIkxqt6ug5zT5ZSUUyc1Iqopf02.jpg", "Set in a dystopian future, a woman is forced to live as a concubine under a fundamentalist theocratic dictatorship. A TV adaptation of Margaret Atwood's novel.", "The Handmaid's Tale" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-26", "https://image.tmdb.org/t/p/w300/yDWJYRAwMNKbIYT8ZB33qy84uzO.jpg", 9, "Mark Grayson is a normal teenager except for the fact that his father is the most powerful superhero on the planet. Shortly after his seventeenth birthday, Mark begins to develop powers of his own and enters into his father’s tutelage.", "Invincible" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-06-12", "https://image.tmdb.org/t/p/w300/fuVuDYrs8sxvEolnYr0wCSvtyTi.jpg", 8, "After spending seventeen years in prison unfairly, a talented songwriter seeks revenge on the men who sank her and killed her family.", "The Queen of Flow" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-01-15", "https://image.tmdb.org/t/p/w300/glKDfE6btIRcVB5zrjspRIs4r52.jpg", "Wanda Maximoff and Vision—two super-powered beings living idealized suburban lives—begin to suspect that everything is not as it seems.", "WandaVision" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-10-25", "https://image.tmdb.org/t/p/w300/qTZIgXrBKURBK1KrsT7fe3qwtl9.jpg", 9, "In a place where young witches, vampires, and werewolves are nurtured to be their best selves in spite of their worst impulses, Klaus Mikaelson’s daughter, 17-year-old Hope Mikaelson, Alaric Saltzman’s twins, Lizzie and Josie Saltzman, among others, come of age into heroes and villains at The Salvatore School for the Young and Gifted.", "Legacies" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-03-24", "https://image.tmdb.org/t/p/w300/o7uk5ChRt3quPIv8PcvPfzyXdMw.jpg", 8, "Hell-bent on exacting revenge and proving he was framed for his sister's murder, Álex sets out to unearth much more than the crime's real culprit.", "Who Killed Sara?" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1999-09-20", "https://image.tmdb.org/t/p/w300/jDCgWVlejIo8sQYxw3Yf1cVQUIL.jpg", 8, "In the criminal justice system, sexually-based offenses are considered especially heinous. In New York City, the dedicated detectives who investigate these vicious felonies are members of an elite squad known as the Special Victims Unit. These are their stories.", "Law & Order: Special Victims Unit" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2011-04-17", "https://image.tmdb.org/t/p/w300/u3bZgnGQ9T01sWNhyveQz0wH0Hl.jpg", 8, "Seven noble families fight for control of the mythical land of Westeros. Friction between the houses leads to full-scale war. All while a very ancient evil awakens in the farthest north. Amidst the war, a neglected military order of misfits, the Night's Watch, is all that stands between the realms of men and icy horrors beyond.", "Game of Thrones" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-18", "https://image.tmdb.org/t/p/w300/78aK4Msbr22A5PGa6PZV0pAvdwf.jpg", "A detective in a small Pennsylvania town investigates a local murder while trying to keep her life from falling apart.", "Mare of Easttown" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2010-10-31", "https://image.tmdb.org/t/p/w300/rqeYMLryjcawh2JeRpCVUDXYM5b.jpg", "Sheriff's deputy Rick Grimes awakens from a coma to find a post-apocalyptic world dominated by flesh-eating zombies. He sets out to find his family and encounters many other survivors along the way.", "The Walking Dead" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-04", "https://image.tmdb.org/t/p/w300/WjQmEWFrOf98nT5aEfUfVYz9N2.jpg", 9, "The 'Bad Batch' of elite and experimental clones make their way through an ever-changing galaxy in the immediate aftermath of the Clone Wars.", "The Bad Batch" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "1989-12-17", "https://image.tmdb.org/t/p/w300/zLudbPueg8CxGhMS2tyDh3p0TdK.jpg", "Set in Springfield, the average American town, the show focuses on the antics and everyday adventures of the Simpson family; Homer, Marge, Bart, Lisa and Maggie, as well as a virtual cast of thousands. Since the beginning, the series has been a pop culture icon, attracting hundreds of celebrities to guest star. The show has also made name for itself in its fearless satirical take on politics, media and American life in general.", "The Simpsons" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2013-12-02", "https://image.tmdb.org/t/p/w300/8kOWDBK6XlPUzckuHDo3wwVRFwt.jpg", "Rick is a mentally-unbalanced but scientifically-gifted old man who has recently reconnected with his family. He spends most of his time involving his young grandson Morty in dangerous, outlandish adventures throughout space and alternate universes. Compounded with Morty's already unstable family life, these events cause Morty much distress at home and school.", "Rick and Morty" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2009-09-10", "https://image.tmdb.org/t/p/w300/kLEha9zVVv8acGFKTX4gjvSR2Q0.jpg", "The story of two vampire brothers obsessed with the same girl, who bears a striking resemblance to the beautiful but ruthless vampire they knew and loved in 1864.", "The Vampire Diaries" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-05-07", "https://image.tmdb.org/t/p/w300/9yxep7oJdkj3Pla9TD9gKflRApY.jpg", 7, "As the world's first generation of superheroes (who received their powers in the 1930s) become the revered elder guard in the present, their superpowered children struggle to live up to the legendary feats of their parents.", "Jupiter's Legacy" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-07-23", "https://image.tmdb.org/t/p/w300/oogunE22HDTcTxFakKQbwqfw1qo.jpg", 5, "Each hour-long film follows a different women as they experience “moments that are emotionally raw, thought-provoking and utterly personal”.", "I Am..." });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2004-11-16", "https://image.tmdb.org/t/p/w300/lkvhReTBZ2Ksl0Dl5Oplsf6UYkF.jpg", 9, "Dr. Gregory House, a drug-addicted, unconventional, misanthropic medical genius, leads a team of diagnosticians at the fictional Princeton–Plainsboro Teaching Hospital in New Jersey.", "House" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2016-09-23", "https://image.tmdb.org/t/p/w300/r8ODGmfNbZQlNhiJl2xQENE2jsk.jpg", 7, "Vanessa Helsing, the daughter of famous vampire hunter and Dracula nemesis Abraham Van Helsing is resurrected five years in the future to find out that vampires have taken over the world and that she possesses unique power over them. She is humanity’s last hope to lead an offensive to take back what has been lost.", "Van Helsing" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-09-23", "https://image.tmdb.org/t/p/w300/htJzeRcYI2ewMm4PTrg98UMXShe.jpg", 7, "Raymond \"Red\" Reddington, one of the FBI's most wanted fugitives, surrenders in person at FBI Headquarters in Washington, D.C. He claims that he and the FBI have the same interests: bringing down dangerous criminals and terrorists. In the last two decades, he's made a list of criminals and terrorists that matter the most but the FBI cannot find because it does not know they exist. Reddington calls this \"The Blacklist\". Reddington will co-operate, but insists that he will speak only to Elizabeth Keen, a rookie FBI profiler.", "The Blacklist" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-10-03", "https://image.tmdb.org/t/p/w300/g1rK2nRXSidcMwNliWDIroWWGTn.jpg", 8, "With his days numbered, high schooler Yuji decides to hunt down and consume the remaining 19 fingers of a deadly curse so it can die with him.", "Jujutsu Kaisen" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2002-10-03", "https://image.tmdb.org/t/p/w300/vauCEnR7CiyBDzRCeElKkCaXIYu.jpg", 8, "In another world, ninja are the ultimate power, and in the Village Hidden in the Leaves live the stealthiest ninja in the land. Twelve years earlier, the fearsome Nine-Tailed Fox terrorized the village and claimed many lives before it was subdued and its spirit sealed within the body of a baby boy. That boy, Naruto Uzumaki, has grown up to become a ninja-in-training who's more interested in pranks than in studying ninjutsu.. but Naruto is determined to become the greatest ninja ever!", "Naruto" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2014-03-19", "https://image.tmdb.org/t/p/w300/wcaDIAG1QdXQLRaj4vC1EFdBT2.jpg", "100 years in the future, when the Earth has been abandoned due to radioactivity, the last surviving humans live on an ark orbiting the planet — but the ark won't last forever. So the repressive regime picks 100 expendable juvenile delinquents to send down to Earth to see if the planet is still habitable.", "The 100" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-07-25", "https://image.tmdb.org/t/p/w300/mY7SeH4HFFxW1hiI6cWuwCRKptN.jpg", 8, "A group of vigilantes known informally as “The Boys” set out to take down corrupt superheroes with no more than blue-collar grit and a willingness to fight dirty.", "The Boys" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2001-10-16", "https://image.tmdb.org/t/p/w300/pUhJGETy2sec4vEkiqJ9eGeIywc.jpg", "The origins of the world’s greatest hero–from Krypton refugee Kal-el’s arrival on Earth through his tumultuous teen years to Clark Kent’s final steps toward embracing his destiny as the Man of Steel.", "Smallville" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-12-06", "https://image.tmdb.org/t/p/w300/xWJZjIKPeEZhK3JRYKOe06yW6IU.jpg", 8, "New Orleans judge Michael Desiato is forced to confront his own deepest convictions when his son is involved in a hit and run that embroils an organized crime family.", "Your Honor" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2011-06-05", "https://image.tmdb.org/t/p/w300/vY2vfAskJTiWsQSv6bdbNCQhPLm.jpg", 9, "Scott McCall, a high school student living in the town of Beacon Hills has his life drastically changed when he's bitten by a werewolf, becoming one himself. He must henceforth learn to balance his problematic new identity with his day-to-day teenage life. The following characters are instrumental to his struggle: Stiles, his best friend; Allison, his love interest who comes from a family of werewolf hunters; and Derek, a mysterious werewolf with a dark past. Throughout the series, he strives to keep his loved ones safe while maintaining normal relationships with them.", "Teen Wolf" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2008-09-23", "https://image.tmdb.org/t/p/w300/acYXu4KaDj1NIkMgObnhe4C4a0T.jpg", "Patrick Jane, a former celebrity psychic medium, uses his razor sharp skills of observation and expertise at \"reading\" people to solve serious crimes with the California Bureau of Investigation.", "The Mentalist" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2013-03-03", "https://image.tmdb.org/t/p/w300/bQLrHIRNEkE3PdIWQrZHynQZazu.jpg", 8, "The adventures of Ragnar Lothbrok, the greatest hero of his age. The series tells the sagas of Ragnar's band of Viking brothers and his family, as he rises to become King of the Viking tribes. As well as being a fearless warrior, Ragnar embodies the Norse traditions of devotion to the gods. Legend has it that he was a direct descendant of Odin, the god of war and warriors.", "Vikings" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-05-02", "https://image.tmdb.org/t/p/w300/4CkQvdUAtoLW3qkjWi7t1MTnW7R.jpg", "This Karate Kid sequel series picks up 30 years after the events of the 1984 All Valley Karate Tournament and finds Johnny Lawrence on the hunt for redemption by reopening the infamous Cobra Kai karate dojo. This reignites his old rivalry with the successful Daniel LaRusso, who has been working to maintain the balance in his life without mentor Mr. Miyagi.", "Cobra Kai" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2012-10-10", "https://image.tmdb.org/t/p/w300/6AccYL0eb7uzHn98IKaNjvJbyuA.jpg", "An edge-of-your-seat view into the lives of everyday heroes committed to one of America's noblest professions. For the firefighters, rescue squad and paramedics of Chicago Firehouse 51, no occupation is more stressful or dangerous, yet so rewarding and exhilarating. These courageous men and women are among the elite who forge headfirst into danger when everyone else is running the other way and whose actions make the difference between life and death.", "Chicago Fire" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2013-04-15", "https://image.tmdb.org/t/p/w300/Ag7VUdnrRz5Qpq3Yn3E5OCvFnu0.jpg", "Set in the 1990s, these are the life and times of Amado Carrillo Fuentes, a man who became the head of the Juárez cartel. Nicknamed “El Señor de los Cielos” (Lord of the Skies) because of the large fleet of airplanes he used to transport drugs, he was also known for washing more than $200 million through Colombia to finance his huge fleet. He is described as the most powerful drug trafficker of his time.", "The Lord of the Skies" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2011-06-23", "https://image.tmdb.org/t/p/w300/vQiryp6LioFxQThywxbC6TuoDjy.jpg", "While running from a drug deal gone bad, Mike Ross, a brilliant young college-dropout, slips into a job interview with one of New York City's best legal closers, Harvey Specter. Tired of cookie-cutter law school grads, Harvey takes a gamble by hiring Mike on the spot after he recognizes his raw talent and photographic memory.", "Suits" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2008-01-20", "https://image.tmdb.org/t/p/w300/ggFHVNu6YYI5L9pCfOacjizRGt.jpg", 9, "When Walter White, a New Mexico chemistry teacher, is diagnosed with Stage III cancer and given a prognosis of only two years left to live. He becomes filled with a sense of fearlessness and an unrelenting desire to secure his family's financial future at any cost as he enters the dangerous world of drugs and crime.", "Breaking Bad" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2018-04-22", "https://image.tmdb.org/t/p/w300/34FaY8qpjBAVysSfrJ1l7nrAQaD.jpg", 8, "The series dramatizes the life story of Mexican superstar singer Luis Miguel, who has captivated audiences in Latin America and beyond for decades.", "Luis Miguel: The Series" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-06-17", "https://image.tmdb.org/t/p/w300/onPkMMtzcJs9A6vKljNBa3ujI8g.jpg", "Samuel attempts a big, romantic gesture at the airport in order to persuade Carla not to board her flight to London.", "Elite Short Stories: Carla Samuel" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2014-09-22", "https://image.tmdb.org/t/p/w300/hzeirSF6bRjssDh5JFrm5WRwFLd.jpg", "Based on a true story, Scorpion is a high-octane drama about eccentric genius Walter O’Brien and his team of brilliant misfits who comprise the last line of defense against complex, high-tech threats of the modern age. As Homeland Security’s new think tank, O’Brien’s “Scorpion” team includes Toby Curtis, an expert behaviorist who can read anyone; Happy Quinn, a mechanical prodigy; and Sylvester Dodd, a statistics guru.", "Scorpion" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-07-08", "https://image.tmdb.org/t/p/w300/nzBenFJ2D2MCWTwTt2uc4BGWLtA.jpg", 8, "Connecting all her hopes in her life to her education, Eda comes face to face with Serkan Bolat, who unknowingly cuts her scholarship abroad and caused her to remain a high school graduate. Serkan Bolat offers to give Eda her scholarship back if she pretends to be engaged to him for two months. Eda first rejects the offer due to her hatred for him, but when circumstances change, she has no choice but to accept the offer. While pretending to be engaged, Serkan and Eda begin to have a passionate, challenging relationship that will make you forget all they know right, because love is hard. And that's why it's amazing!!", "You Knock on My Door" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2010-04-05", "https://image.tmdb.org/t/p/w300/qk3eQ8jW4opJ48gFWYUXWaMT4l.jpg", 8, "Hook up with Finn and Jake as they travel the Land of Ooo searching for adventure. But remember, adventure isn’t always easy. Sometimes you’ve got to battle fire gnomes that torture old ladies, save a smelly hot dog princess from the Ice King, and thaw out a bunch of frozen businessmen. What the cabbage?!", "Adventure Time" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1999-01-31", "https://image.tmdb.org/t/p/w300/eWWCRjBfLyePh2tfZdvNcIvKSJe.jpg", 7, "Sick, twisted, politically incorrect and Freakin' Sweet animated series featuring the adventures of the dysfunctional Griffin family. Bumbling Peter and long-suffering Lois have three kids. Stewie (a brilliant but sadistic baby bent on killing his mother and taking over the world), Meg (the oldest, and is the most unpopular girl in town) and Chris (the middle kid, he's not very bright but has a passion for movies). The final member of the family is Brian - a talking dog and much more than a pet, he keeps Stewie in check whilst sipping Martinis and sorting through his own life issues.", "Family Guy" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2005-09-13", "https://image.tmdb.org/t/p/w300/KoYWXbnYuS3b0GyQPkbuexlVK9.jpg", "When they were boys, Sam and Dean Winchester lost their mother to a mysterious and demonic supernatural force. Subsequently, their father raised them to be soldiers. He taught them about the paranormal evil that lives in the dark corners and on the back roads of America ... and he taught them how to kill it. Now, the Winchester brothers crisscross the country in their '67 Chevy Impala, battling every kind of supernatural threat they encounter along the way. ", "Supernatural" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-01-19", "https://image.tmdb.org/t/p/w300/mrzE6bXc8g9NQd8IBKB25louWq8.jpg", "Nearly 20 years ago, Owen Strand was the lone survivor of his Manhattan firehouse on 9/11. In the wake of the attack, Owen had the unenviable task of rebuilding his station. After a similar tragedy happens to a firehouse in Austin, Owen, along with his troubled firefighter son, T.K., takes his progressive philosophies of life and firefighting down to Texas, where he helps them start anew. On the surface, Owen is all about big-city style and swagger, but underneath he struggles with a secret he hides from the world - one that could very well end his life.", "9-1-1: Lone Star" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2005-09-13", "https://image.tmdb.org/t/p/w300/eyTu5c8LniVciRZIOSHTvvkkgJa.jpg", "Dr. Temperance Brennan and her colleagues at the Jeffersonian's Medico-Legal Lab assist Special Agent Seeley Booth with murder investigations when the remains are so badly decomposed, burned or destroyed that the standard identification methods are useless.", "Bones" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1994-09-22", "https://image.tmdb.org/t/p/w300/f496cm9enuEsZkSPzCwnTESEK5s.jpg", 8, "The misadventures of a group of friends as they navigate the pitfalls of work, life and love in Manhattan.", "Friends" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-11-12", "https://image.tmdb.org/t/p/w300/sWgBv7LV2PRoQgkxwlibdGXKz1S.jpg", "After the fall of the Galactic Empire, lawlessness has spread throughout the galaxy. A lone gunfighter makes his way through the outer reaches, earning his keep as a bounty hunter.", "The Mandalorian" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2016-07-19", "https://image.tmdb.org/t/p/w300/7lBJ6lOS0uQqsH13U9iMTikawQS.jpg", "A young woman born in a mafia-controlled town seeks revenge on those who wrongfully harmed and imprisoned her family.", "Sin senos sí hay paraíso" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2007-02-15", "https://image.tmdb.org/t/p/w300/zAYRe2bJxpWTVrwwmBc00VFkAf4.jpg", "Naruto Shippuuden is the continuation of the original animated TV series Naruto.The story revolves around an older and slightly more matured Uzumaki Naruto and his quest to save his friend Uchiha Sasuke from the grips of the snake-like Shinobi, Orochimaru. After 2 and a half years Naruto finally returns to his village of Konoha, and sets about putting his ambitions to work, though it will not be easy, as He has amassed a few (more dangerous) enemies, in the likes of the shinobi organization; Akatsuki.", "Naruto Shippūden" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-01-08", "https://image.tmdb.org/t/p/w300/EpDuYIK81YtCUT3gH2JDpyj8Qk.jpg", 8, "Revisit the epic heroes, villains and moments from across the MCU in preparation for the stories still to come. Each dynamic segment feeds directly into the upcoming series — setting the stage for future events. This series weaves together the many threads that constitute the unparalleled Marvel Cinematic Universe.", "Marvel Studios: Legends" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2021-04-11", "https://image.tmdb.org/t/p/w300/qSEKyf0fWhrCEQ3LTwLqe41eSvR.jpg", "Takemichi Hanagaki is a freelancer that’s reached the absolute pits of despair in his life. He finds out that the only girlfriend he ever had, in middle school, Hinata Tachibana, had been killed by the ruthless Tokyo Manji Gang. The day after hearing about her death, he’s standing on the station platform and ends up being pushed over onto the tracks by a herd of people. He closes his eyes thinking he’s about to die, but when he opens his eyes back up, he somehow had gone back in time 12 years. Now that he’s back living the best days of his life, Takemichi decides to get revenge on his life.", "Tokyo Revengers" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2021-06-15", "https://image.tmdb.org/t/p/w300/1ekhk1W6vfVU25GN4AspQ9zXqIN.jpg", 9, "Nadia feels conflicted about whether or not to see her long distance boyfriend, Guzmán, when she returns to Spain for her sister's wedding.", "Elite Short Stories: Nadia Guzmán" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2015-10-19", "https://image.tmdb.org/t/p/w300/qxbW47zmgFyBVmZSIqD9NA1DEjT.jpg", "Normal high school kids by day, protectors of Paris by night! Miraculous follows the heroic adventures of Marinette and Adrien as they transform into Ladybug and Cat Noir and set out to capture akumas, creatures responsible for turning the people of Paris into villains. But neither hero knows the other’s true identity – or that they’re classmates!", "Miraculous: Tales of Ladybug & Cat Noir" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2003-09-23", "https://image.tmdb.org/t/p/w300/fi8EvaWtL5CvoielOjjVvTr7ux3.jpg", "From murder and espionage to terrorism and stolen submarines, a team of special agents investigates any crime that has a shred of evidence connected to Navy and Marine Corps personnel, regardless of rank or position.", "NCIS" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2012-10-10", "https://image.tmdb.org/t/p/w300/gKG5QGz5Ngf8fgWpBsWtlg5L2SF.jpg", 7, "Spoiled billionaire playboy Oliver Queen is missing and presumed dead when his yacht is lost at sea. He returns five years later a changed man, determined to clean up the city as a hooded vigilante armed with a bow.", "Arrow" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "1989-04-26", "https://image.tmdb.org/t/p/w300/6VKOfL6ihwTiB5Vibq6QTfzhxA6.jpg", "After learning that he is from another planet, a warrior named Goku and his friends are prompted to defend it from an onslaught of extraterrestrial enemies.", "Dragon Ball Z" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-12-04", "https://image.tmdb.org/t/p/w300/mYsWyfiIMxx4HDm0Wck7oJ9ckez.jpg", "As Mexican-American Tejano singer Selena comes of age and realizes her dreams, she and her family make tough choices to hold on to love and music.", "Selena: The Series" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2020-09-18", "https://image.tmdb.org/t/p/w300/jWTDtbp2TnUGw1OJoDqq2O9IS0M.jpg", "Six teens attending an adventure camp on the opposite side of Isla Nublar must band together to survive when dinosaurs wreak havoc on the island.", "Jurassic World: Camp Cretaceous" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2000-10-06", "https://image.tmdb.org/t/p/w300/t6hnMaWMuX2brNL6Dq52dDLxZMt.jpg", "A Las Vegas team of forensic investigators are trained to solve criminal cases by scouring the crime scene, collecting irrefutable evidence and finding the missing pieces that solve the mystery.", "CSI: Crime Scene Investigation" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-03-15", "https://image.tmdb.org/t/p/w300/asDqvkE66EegtKJJXIRhBJPxscr.jpg", "Terrifying creatures, wicked surprises and dark comedy converge in this NSFW anthology of animated stories presented by Tim Miller and David Fincher.", "Love, Death & Robots" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2005-09-22", "https://image.tmdb.org/t/p/w300/7TCwgX7oQKxcWYEhSPRmaHe6ULN.jpg", "An elite team of FBI profilers analyze the country's most twisted criminal minds, anticipating their next moves before they strike again. The Behavioral Analysis Unit's most experienced agent is David Rossi, a founding member of the BAU who returns to help the team solve new cases.", "Criminal Minds" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2019-11-12", "https://image.tmdb.org/t/p/w300/9S3BS5oS9a8sNiTWuZi9aveE4bR.jpg", "A group of East High students countdown to the opening night of their school’s first-ever production of “High School Musical.” Showmances blossom; friendships are tested while new ones are made; rivalries flare and lives are changed forever as these young people discover the transformative power that only a high school drama club can provide.", "High School Musical: The Musical: The Series" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-01-03", "https://image.tmdb.org/t/p/w300/wP9Ho6PCmmrFHLK1VjSAwZKVKtX.jpg", "Explore the high-pressure experiences of police officers, paramedics and firefighters who are thrust into the most frightening, shocking and heart-stopping situations. These emergency responders must try to balance saving those who are at their most vulnerable with solving the problems in their own lives.", "9-1-1" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2016-01-21", "https://image.tmdb.org/t/p/w300/uzQpQGISbtxc047IOssFo5AiDwU.jpg", 7, "When heroes alone are not enough ... the world needs legends. Having seen the future, one he will desperately try to prevent from happening, time-traveling rogue Rip Hunter is tasked with assembling a disparate group of both heroes and villains to confront an unstoppable threat — one in which not only is the planet at stake, but all of time itself. Can this ragtag team defeat an immortal threat unlike anything they have ever known?", "DC's Legends of Tomorrow" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "1997-08-13", "https://image.tmdb.org/t/p/w300/iiCY2QIGSnmtVkIdjkKAfwDs0KF.jpg", 8, "Follows the misadventures of four irreverent grade-schoolers in the quiet, dysfunctional town of South Park, Colorado.", "South Park" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2020-06-17", "https://image.tmdb.org/t/p/w300/pcT1vivabBnBk0tZgVBO1I8aK75.jpg", 9, "Victor is a new student at Creekwood High School on his own journey of self-discovery, facing challenges at home, adjusting to a new city, and struggling with his sexual orientation. When it all seems too much, he reaches out to Simon to help him navigate the ups and downs of high school.", "Love, Victor" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Poster", "Summary", "Title" },
                values: new object[] { "2018-03-22", "https://image.tmdb.org/t/p/w300/lcuCED5Ky2uM5VE6wILOwt5FEb0.jpg", "A group of heroic firefighters at Seattle Fire Station 19—from captain to newest recruit—risk their lives and hearts both in the line of duty and off the clock. These brave men and women are like family, literally and figuratively, and together they put their own lives in jeopardy as first responders to save the lives of others.", "Station 19" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2010-09-06", "https://image.tmdb.org/t/p/w300/mS5SLxMYcKfUxA0utBSR5MOAWWr.jpg", 9, "Two bored groundskeepers, Mordecai (a six-foot-tall blue jay) and Rigby (a hyperactive raccoon) are best friends who spend their days trying to entertain themselves by any means necessary, much to the displeasure of their boss. Their everyday pursuits often lead to things spiraling out of control and into the surreal.", "Regular Show" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "Poster", "Rating", "Summary", "Title" },
                values: new object[] { "2019-10-06", "https://image.tmdb.org/t/p/w300/xjyEpcuDbB1jy0ehNQMBiO8KOdr.jpg", 7, "Kate Kane, armed with a passion for social justice and a flair for speaking her mind, soars onto the streets of Gotham as Batwoman, an out lesbian and highly trained street fighter primed to snuff out the failing city's criminal resurgence. But don't call her a hero yet. In a city desperate for a savior, Kate must overcome her own demons before embracing the call to be Gotham's symbol of hope", "Batwoman" });
        }
    }
}
