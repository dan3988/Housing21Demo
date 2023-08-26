using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Website.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "FirstName", "LastName", "Modified", "ModifiedBy", "Telephone" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "rschrader0@php.net", "Raimondo", "Schrader", null, null, "+449022625292" },
                    { 2, new DateTime(1912, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "bhilliam1@myspace.com", "Berty", "Hilliam", null, null, "+449864418160" },
                    { 3, new DateTime(1956, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jkonke2@bloomberg.com", "Jerrilyn", "Konke", null, null, "+445517466178" },
                    { 4, new DateTime(1988, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ktendahl3@spiegel.de", "Katha", "Tendahl", null, null, "+446943606985" },
                    { 5, new DateTime(1986, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mfritchley4@plala.or.jp", "Maurita", "Fritchley", null, null, "+449675384108" },
                    { 6, new DateTime(1969, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jkelcey5@angelfire.com", "Jeralee", "Kelcey", null, null, "+443083415269" },
                    { 7, new DateTime(1961, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hdyott6@ezinearticles.com", "Hamel", "Dyott", null, null, "+441276145543" },
                    { 8, new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hdorgon7@de.vu", "Harrie", "Dorgon", null, null, "+442087405477" },
                    { 9, new DateTime(2001, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "bheaps8@noaa.gov", "Basilio", "Heaps", null, null, "+449563717412" },
                    { 10, new DateTime(1951, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "lfaithfull9@rakuten.co.jp", "Lani", "Faithfull", null, null, "+447062984155" },
                    { 11, new DateTime(1983, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ocharlea@ebay.com", "Oriana", "Charle", null, null, "+449406044834" },
                    { 12, new DateTime(1967, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbristerb@tamu.edu", "Jelene", "Brister", null, null, "" },
                    { 13, new DateTime(1904, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "nsigwardc@chronoengine.com", "Nobe", "Sigward", null, null, "+443701122088" },
                    { 14, new DateTime(1969, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbeaumand@mozilla.org", "Meta", "Beauman", null, null, "+449933129156" },
                    { 15, new DateTime(1960, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "aroantreee@techcrunch.com", "Ari", "Roantree", null, null, "+444461903704" },
                    { 16, new DateTime(1953, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "rdowdingf@hhs.gov", "Robinett", "Dowding", null, null, "" },
                    { 17, new DateTime(1903, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ajakog@example.com", "Amitie", "Jako", null, null, "+444048582968" },
                    { 18, new DateTime(1950, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstormonthh@1688.com", "Fidelia", "Stormonth", null, null, "+445624932663" },
                    { 19, new DateTime(1967, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cgreigi@webs.com", "Chlo", "Greig", null, null, "+448313967081" },
                    { 20, new DateTime(1919, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bspencersj@uol.com.br", "Beverlie", "Spencers", null, null, "+442397164825" },
                    { 21, new DateTime(1950, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "cgarrattleyk@miibeian.gov.cn", "Chico", "Garrattley", null, null, "+449183176571" },
                    { 22, new DateTime(1970, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ncobbinl@yale.edu", "Noak", "Cobbin", null, null, "+448657697812" },
                    { 23, new DateTime(1914, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mnyssenm@sciencedirect.com", "Madalyn", "Nyssen", null, null, "+444133228299" },
                    { 24, new DateTime(1921, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "agiblingn@360.cn", "Andonis", "Gibling", null, null, "+447085332017" },
                    { 25, new DateTime(1933, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gelacoateo@noaa.gov", "Gale", "Elacoate", null, null, "+445774400552" },
                    { 26, new DateTime(1904, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mrisdalep@desdev.cn", "Maribel", "Risdale", null, null, "+446353245719" },
                    { 27, new DateTime(1919, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ldochonq@hibu.com", "Lionel", "Dochon", null, null, "+442905712109" },
                    { 28, new DateTime(1956, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cvondrysr@wikipedia.org", "Candi", "Vondrys", null, null, "+449625188471" },
                    { 29, new DateTime(1961, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hjesses@mapy.cz", "Herby", "Jesse", null, null, "+445671639206" },
                    { 30, new DateTime(1901, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmaccostyt@4shared.com", "Reinhard", "MacCosty", null, null, "+449685760210" },
                    { 31, new DateTime(1979, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpedroniu@cdc.gov", "Janice", "Pedroni", null, null, "+447429061935" },
                    { 32, new DateTime(1928, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "smaroneyv@ucoz.ru", "Spense", "Maroney", null, null, "+445221714877" },
                    { 33, new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ctregidgow@ca.gov", "Connie", "Tregidgo", null, null, "+445863926223" },
                    { 34, new DateTime(1942, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "scretneyx@stanford.edu", "Shermie", "Cretney", null, null, "+444053887430" },
                    { 35, new DateTime(1989, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbriony@princeton.edu", "Mel", "Brion", null, null, "+449451696174" },
                    { 36, new DateTime(1913, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ejannaschz@arstechnica.com", "Esta", "Jannasch", null, null, "+442165300485" },
                    { 37, new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lcastangia10@economist.com", "Linc", "Castangia", null, null, "+448888781806" },
                    { 38, new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "hregelous11@engadget.com", "Humbert", "Regelous", null, null, "+443916166178" },
                    { 39, new DateTime(1932, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "kschimank12@instagram.com", "Kellen", "Schimank", null, null, "+442421411499" },
                    { 40, new DateTime(1909, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssore13@ox.ac.uk", "Sax", "Sore", null, null, "+441347160893" },
                    { 41, new DateTime(1914, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oshank14@ovh.net", "Orbadiah", "Shank", null, null, "+449469784485" },
                    { 42, new DateTime(1917, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "bronald15@youtu.be", "Brok", "Ronald", null, null, "" },
                    { 43, new DateTime(1965, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hbraddick16@domainmarket.com", "Hendrick", "Braddick", null, null, "+447153369142" },
                    { 44, new DateTime(1913, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "glilford17@pbs.org", "Gilberto", "Lilford", null, null, "+441096392236" },
                    { 45, new DateTime(1971, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "tdani18@mozilla.org", "Tod", "Dani", null, null, "+448993601490" },
                    { 46, new DateTime(1981, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "abuttrey19@msu.edu", "Andie", "Buttrey", null, null, "+441596887848" },
                    { 47, new DateTime(1963, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "rscholer1a@answers.com", "Rozella", "Scholer", null, null, "+445868491225" },
                    { 48, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bnail1b@miibeian.gov.cn", "Beniamino", "Nail", null, null, "+445424498195" },
                    { 49, new DateTime(2001, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jrieger1c@si.edu", "Jermaine", "Rieger", null, null, "+443444927224" },
                    { 50, new DateTime(1967, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "rstoner1d@amazonaws.com", "Ruperta", "Stoner", null, null, "+449836797384" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
