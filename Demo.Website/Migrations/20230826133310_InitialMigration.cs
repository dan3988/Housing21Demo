using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Website.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "CURRENT_USER"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "FirstName", "LastName", "Modified", "ModifiedBy", "Telephone" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "rschrader0@php.net", "Raimondo", "Schrader", null, null, "+62 902 262 5292" },
                    { 2, new DateTime(1912, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "bhilliam1@myspace.com", "Berty", "Hilliam", null, null, "+51 986 441 8160" },
                    { 3, new DateTime(1956, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jkonke2@bloomberg.com", "Jerrilyn", "Konke", null, null, "+62 551 746 6178" },
                    { 4, new DateTime(1988, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ktendahl3@spiegel.de", "Katha", "Tendahl", null, null, "+212 694 360 6985" },
                    { 5, new DateTime(1986, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mfritchley4@plala.or.jp", "Maurita", "Fritchley", null, null, "+234 967 538 4108" },
                    { 6, new DateTime(1969, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jkelcey5@angelfire.com", "Jeralee", "Kelcey", null, null, "+63 308 341 5269" },
                    { 7, new DateTime(1961, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hdyott6@ezinearticles.com", "Hamel", "Dyott", null, null, "+86 127 614 5543" },
                    { 8, new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hdorgon7@de.vu", "Harrie", "Dorgon", null, null, "+54 208 740 5477" },
                    { 9, new DateTime(2001, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "bheaps8@noaa.gov", "Basilio", "Heaps", null, null, "+63 956 371 7412" },
                    { 10, new DateTime(1951, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "lfaithfull9@rakuten.co.jp", "Lani", "Faithfull", null, null, "+86 706 298 4155" },
                    { 11, new DateTime(1983, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ocharlea@ebay.com", "Oriana", "Charle", null, null, "+57 940 604 4834" },
                    { 12, new DateTime(1967, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbristerb@tamu.edu", "Jelene", "Brister", null, null, "" },
                    { 13, new DateTime(1904, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "nsigwardc@chronoengine.com", "Nobe", "Sigward", null, null, "+1 370 112 2088" },
                    { 14, new DateTime(1969, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbeaumand@mozilla.org", "Meta", "Beauman", null, null, "+63 993 312 9156" },
                    { 15, new DateTime(1960, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "aroantreee@techcrunch.com", "Ari", "Roantree", null, null, "+55 446 190 3704" },
                    { 16, new DateTime(1953, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "rdowdingf@hhs.gov", "Robinett", "Dowding", null, null, "" },
                    { 17, new DateTime(1903, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ajakog@example.com", "Amitie", "Jako", null, null, "+7 404 858 2968" },
                    { 18, new DateTime(1950, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstormonthh@1688.com", "Fidelia", "Stormonth", null, null, "+976 562 493 2663" },
                    { 19, new DateTime(1967, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cgreigi@webs.com", "Chlo", "Greig", null, null, "+7 831 396 7081" },
                    { 20, new DateTime(1919, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bspencersj@uol.com.br", "Beverlie", "Spencers", null, null, "+86 239 716 4825" },
                    { 21, new DateTime(1950, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "cgarrattleyk@miibeian.gov.cn", "Chico", "Garrattley", null, null, "+502 918 317 6571" },
                    { 22, new DateTime(1970, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ncobbinl@yale.edu", "Noak", "Cobbin", null, null, "+223 865 769 7812" },
                    { 23, new DateTime(1914, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mnyssenm@sciencedirect.com", "Madalyn", "Nyssen", null, null, "+55 413 322 8299" },
                    { 24, new DateTime(1921, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "agiblingn@360.cn", "Andonis", "Gibling", null, null, "+62 708 533 2017" },
                    { 25, new DateTime(1933, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gelacoateo@noaa.gov", "Gale", "Elacoate", null, null, "+30 577 440 0552" },
                    { 26, new DateTime(1904, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mrisdalep@desdev.cn", "Maribel", "Risdale", null, null, "+7 635 324 5719" },
                    { 27, new DateTime(1919, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ldochonq@hibu.com", "Lionel", "Dochon", null, null, "+57 290 571 2109" },
                    { 28, new DateTime(1956, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cvondrysr@wikipedia.org", "Candi", "Vondrys", null, null, "+55 962 518 8471" },
                    { 29, new DateTime(1961, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hjesses@mapy.cz", "Herby", "Jesse", null, null, "+380 567 163 9206" },
                    { 30, new DateTime(1901, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmaccostyt@4shared.com", "Reinhard", "MacCosty", null, null, "+380 968 576 0210" },
                    { 31, new DateTime(1979, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpedroniu@cdc.gov", "Janice", "Pedroni", null, null, "+51 742 906 1935" },
                    { 32, new DateTime(1928, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "smaroneyv@ucoz.ru", "Spense", "Maroney", null, null, "+62 522 171 4877" },
                    { 33, new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ctregidgow@ca.gov", "Connie", "Tregidgo", null, null, "+47 586 392 6223" },
                    { 34, new DateTime(1942, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "scretneyx@stanford.edu", "Shermie", "Cretney", null, null, "+54 405 388 7430" },
                    { 35, new DateTime(1989, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbriony@princeton.edu", "Mel", "Brion", null, null, "+62 945 169 6174" },
                    { 36, new DateTime(1913, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ejannaschz@arstechnica.com", "Esta", "Jannasch", null, null, "+33 216 530 0485" },
                    { 37, new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lcastangia10@economist.com", "Linc", "Castangia", null, null, "+385 888 878 1806" },
                    { 38, new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "hregelous11@engadget.com", "Humbert", "Regelous", null, null, "+998 391 616 6178" },
                    { 39, new DateTime(1932, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "kschimank12@instagram.com", "Kellen", "Schimank", null, null, "+86 242 141 1499" },
                    { 40, new DateTime(1909, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssore13@ox.ac.uk", "Sax", "Sore", null, null, "+351 134 716 0893" },
                    { 41, new DateTime(1914, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oshank14@ovh.net", "Orbadiah", "Shank", null, null, "+356 946 978 4485" },
                    { 42, new DateTime(1917, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "bronald15@youtu.be", "Brok", "Ronald", null, null, "" },
                    { 43, new DateTime(1965, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hbraddick16@domainmarket.com", "Hendrick", "Braddick", null, null, "+592 715 336 9142" },
                    { 44, new DateTime(1913, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "glilford17@pbs.org", "Gilberto", "Lilford", null, null, "+82 109 639 2236" },
                    { 45, new DateTime(1971, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "tdani18@mozilla.org", "Tod", "Dani", null, null, "+46 899 360 1490" },
                    { 46, new DateTime(1981, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "abuttrey19@msu.edu", "Andie", "Buttrey", null, null, "+1 159 688 7848" },
                    { 47, new DateTime(1963, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "rscholer1a@answers.com", "Rozella", "Scholer", null, null, "+86 586 849 1225" },
                    { 48, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bnail1b@miibeian.gov.cn", "Beniamino", "Nail", null, null, "+86 542 449 8195" },
                    { 49, new DateTime(2001, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jrieger1c@si.edu", "Jermaine", "Rieger", null, null, "+380 344 492 7224" },
                    { 50, new DateTime(1967, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "rstoner1d@amazonaws.com", "Ruperta", "Stoner", null, null, "+967 983 679 7384" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
