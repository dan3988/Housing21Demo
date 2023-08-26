﻿using Demo.Website.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Newtonsoft.Json;

namespace Demo.Website.Data.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
	private const string SampleData = "[{\"Id\":1,\"FirstName\":\"Raimondo\",\"LastName\":\"Schrader\",\"DateOfBirth\":\"1998-07-16\",\"EmailAddress\":\"rschrader0@php.net\",\"Telephone\":\"+62 902 262 5292\"},{\"Id\":2,\"FirstName\":\"Berty\",\"LastName\":\"Hilliam\",\"DateOfBirth\":\"1912-07-08\",\"EmailAddress\":\"bhilliam1@myspace.com\",\"Telephone\":\"+51 986 441 8160\"},{\"Id\":3,\"FirstName\":\"Jerrilyn\",\"LastName\":\"Konke\",\"DateOfBirth\":\"1956-01-03\",\"EmailAddress\":\"jkonke2@bloomberg.com\",\"Telephone\":\"+62 551 746 6178\"},{\"Id\":4,\"FirstName\":\"Katha\",\"LastName\":\"Tendahl\",\"DateOfBirth\":\"1988-09-15\",\"EmailAddress\":\"ktendahl3@spiegel.de\",\"Telephone\":\"+212 694 360 6985\"},{\"Id\":5,\"FirstName\":\"Maurita\",\"LastName\":\"Fritchley\",\"DateOfBirth\":\"1986-07-02\",\"EmailAddress\":\"mfritchley4@plala.or.jp\",\"Telephone\":\"+234 967 538 4108\"},{\"Id\":6,\"FirstName\":\"Jeralee\",\"LastName\":\"Kelcey\",\"DateOfBirth\":\"1969-05-06\",\"EmailAddress\":\"jkelcey5@angelfire.com\",\"Telephone\":\"+63 308 341 5269\"},{\"Id\":7,\"FirstName\":\"Hamel\",\"LastName\":\"Dyott\",\"DateOfBirth\":\"1961-01-03\",\"EmailAddress\":\"hdyott6@ezinearticles.com\",\"Telephone\":\"+86 127 614 5543\"},{\"Id\":8,\"FirstName\":\"Harrie\",\"LastName\":\"Dorgon\",\"DateOfBirth\":\"2000-02-23\",\"EmailAddress\":\"hdorgon7@de.vu\",\"Telephone\":\"+54 208 740 5477\"},{\"Id\":9,\"FirstName\":\"Basilio\",\"LastName\":\"Heaps\",\"DateOfBirth\":\"2001-10-08\",\"EmailAddress\":\"bheaps8@noaa.gov\",\"Telephone\":\"+63 956 371 7412\"},{\"Id\":10,\"FirstName\":\"Lani\",\"LastName\":\"Faithfull\",\"DateOfBirth\":\"1951-07-13\",\"EmailAddress\":\"lfaithfull9@rakuten.co.jp\",\"Telephone\":\"+86 706 298 4155\"},{\"Id\":11,\"FirstName\":\"Oriana\",\"LastName\":\"Charle\",\"DateOfBirth\":\"1983-08-24\",\"EmailAddress\":\"ocharlea@ebay.com\",\"Telephone\":\"+57 940 604 4834\"},{\"Id\":12,\"FirstName\":\"Jelene\",\"LastName\":\"Brister\",\"DateOfBirth\":\"1967-05-24\",\"EmailAddress\":\"jbristerb@tamu.edu\",\"Telephone\":\"\"},{\"Id\":13,\"FirstName\":\"Nobe\",\"LastName\":\"Sigward\",\"DateOfBirth\":\"1904-05-24\",\"EmailAddress\":\"nsigwardc@chronoengine.com\",\"Telephone\":\"+1 370 112 2088\"},{\"Id\":14,\"FirstName\":\"Meta\",\"LastName\":\"Beauman\",\"DateOfBirth\":\"1969-11-27\",\"EmailAddress\":\"mbeaumand@mozilla.org\",\"Telephone\":\"+63 993 312 9156\"},{\"Id\":15,\"FirstName\":\"Ari\",\"LastName\":\"Roantree\",\"DateOfBirth\":\"1960-08-17\",\"EmailAddress\":\"aroantreee@techcrunch.com\",\"Telephone\":\"+55 446 190 3704\"},{\"Id\":16,\"FirstName\":\"Robinett\",\"LastName\":\"Dowding\",\"DateOfBirth\":\"1953-08-31\",\"EmailAddress\":\"rdowdingf@hhs.gov\",\"Telephone\":\"\"},{\"Id\":17,\"FirstName\":\"Amitie\",\"LastName\":\"Jako\",\"DateOfBirth\":\"1903-08-16\",\"EmailAddress\":\"ajakog@example.com\",\"Telephone\":\"+7 404 858 2968\"},{\"Id\":18,\"FirstName\":\"Fidelia\",\"LastName\":\"Stormonth\",\"DateOfBirth\":\"1950-08-03\",\"EmailAddress\":\"fstormonthh@1688.com\",\"Telephone\":\"+976 562 493 2663\"},{\"Id\":19,\"FirstName\":\"Chlo\",\"LastName\":\"Greig\",\"DateOfBirth\":\"1967-12-30\",\"EmailAddress\":\"cgreigi@webs.com\",\"Telephone\":\"+7 831 396 7081\"},{\"Id\":20,\"FirstName\":\"Beverlie\",\"LastName\":\"Spencers\",\"DateOfBirth\":\"1919-03-05\",\"EmailAddress\":\"bspencersj@uol.com.br\",\"Telephone\":\"+86 239 716 4825\"},{\"Id\":21,\"FirstName\":\"Chico\",\"LastName\":\"Garrattley\",\"DateOfBirth\":\"1950-09-15\",\"EmailAddress\":\"cgarrattleyk@miibeian.gov.cn\",\"Telephone\":\"+502 918 317 6571\"},{\"Id\":22,\"FirstName\":\"Noak\",\"LastName\":\"Cobbin\",\"DateOfBirth\":\"1970-08-28\",\"EmailAddress\":\"ncobbinl@yale.edu\",\"Telephone\":\"+223 865 769 7812\"},{\"Id\":23,\"FirstName\":\"Madalyn\",\"LastName\":\"Nyssen\",\"DateOfBirth\":\"1914-05-23\",\"EmailAddress\":\"mnyssenm@sciencedirect.com\",\"Telephone\":\"+55 413 322 8299\"},{\"Id\":24,\"FirstName\":\"Andonis\",\"LastName\":\"Gibling\",\"DateOfBirth\":\"1921-10-08\",\"EmailAddress\":\"agiblingn@360.cn\",\"Telephone\":\"+62 708 533 2017\"},{\"Id\":25,\"FirstName\":\"Gale\",\"LastName\":\"Elacoate\",\"DateOfBirth\":\"1933-12-10\",\"EmailAddress\":\"gelacoateo@noaa.gov\",\"Telephone\":\"+30 577 440 0552\"},{\"Id\":26,\"FirstName\":\"Maribel\",\"LastName\":\"Risdale\",\"DateOfBirth\":\"1904-01-02\",\"EmailAddress\":\"mrisdalep@desdev.cn\",\"Telephone\":\"+7 635 324 5719\"},{\"Id\":27,\"FirstName\":\"Lionel\",\"LastName\":\"Dochon\",\"DateOfBirth\":\"1919-11-18\",\"EmailAddress\":\"ldochonq@hibu.com\",\"Telephone\":\"+57 290 571 2109\"},{\"Id\":28,\"FirstName\":\"Candi\",\"LastName\":\"Vondrys\",\"DateOfBirth\":\"1956-03-02\",\"EmailAddress\":\"cvondrysr@wikipedia.org\",\"Telephone\":\"+55 962 518 8471\"},{\"Id\":29,\"FirstName\":\"Herby\",\"LastName\":\"Jesse\",\"DateOfBirth\":\"1961-01-23\",\"EmailAddress\":\"hjesses@mapy.cz\",\"Telephone\":\"+380 567 163 9206\"},{\"Id\":30,\"FirstName\":\"Reinhard\",\"LastName\":\"MacCosty\",\"DateOfBirth\":\"1901-07-18\",\"EmailAddress\":\"rmaccostyt@4shared.com\",\"Telephone\":\"+380 968 576 0210\"},{\"Id\":31,\"FirstName\":\"Janice\",\"LastName\":\"Pedroni\",\"DateOfBirth\":\"1979-05-19\",\"EmailAddress\":\"jpedroniu@cdc.gov\",\"Telephone\":\"+51 742 906 1935\"},{\"Id\":32,\"FirstName\":\"Spense\",\"LastName\":\"Maroney\",\"DateOfBirth\":\"1928-09-06\",\"EmailAddress\":\"smaroneyv@ucoz.ru\",\"Telephone\":\"+62 522 171 4877\"},{\"Id\":33,\"FirstName\":\"Connie\",\"LastName\":\"Tregidgo\",\"DateOfBirth\":\"1994-09-08\",\"EmailAddress\":\"ctregidgow@ca.gov\",\"Telephone\":\"+47 586 392 6223\"},{\"Id\":34,\"FirstName\":\"Shermie\",\"LastName\":\"Cretney\",\"DateOfBirth\":\"1942-10-02\",\"EmailAddress\":\"scretneyx@stanford.edu\",\"Telephone\":\"+54 405 388 7430\"},{\"Id\":35,\"FirstName\":\"Mel\",\"LastName\":\"Brion\",\"DateOfBirth\":\"1989-05-03\",\"EmailAddress\":\"mbriony@princeton.edu\",\"Telephone\":\"+62 945 169 6174\"},{\"Id\":36,\"FirstName\":\"Esta\",\"LastName\":\"Jannasch\",\"DateOfBirth\":\"1913-05-28\",\"EmailAddress\":\"ejannaschz@arstechnica.com\",\"Telephone\":\"+33 216 530 0485\"},{\"Id\":37,\"FirstName\":\"Linc\",\"LastName\":\"Castangia\",\"DateOfBirth\":\"1978-04-12\",\"EmailAddress\":\"lcastangia10@economist.com\",\"Telephone\":\"+385 888 878 1806\"},{\"Id\":38,\"FirstName\":\"Humbert\",\"LastName\":\"Regelous\",\"DateOfBirth\":\"2002-04-04\",\"EmailAddress\":\"hregelous11@engadget.com\",\"Telephone\":\"+998 391 616 6178\"},{\"Id\":39,\"FirstName\":\"Kellen\",\"LastName\":\"Schimank\",\"DateOfBirth\":\"1932-09-28\",\"EmailAddress\":\"kschimank12@instagram.com\",\"Telephone\":\"+86 242 141 1499\"},{\"Id\":40,\"FirstName\":\"Sax\",\"LastName\":\"Sore\",\"DateOfBirth\":\"1909-10-27\",\"EmailAddress\":\"ssore13@ox.ac.uk\",\"Telephone\":\"+351 134 716 0893\"},{\"Id\":41,\"FirstName\":\"Orbadiah\",\"LastName\":\"Shank\",\"DateOfBirth\":\"1914-12-10\",\"EmailAddress\":\"oshank14@ovh.net\",\"Telephone\":\"+356 946 978 4485\"},{\"Id\":42,\"FirstName\":\"Brok\",\"LastName\":\"Ronald\",\"DateOfBirth\":\"1917-08-26\",\"EmailAddress\":\"bronald15@youtu.be\",\"Telephone\":\"\"},{\"Id\":43,\"FirstName\":\"Hendrick\",\"LastName\":\"Braddick\",\"DateOfBirth\":\"1965-05-30\",\"EmailAddress\":\"hbraddick16@domainmarket.com\",\"Telephone\":\"+592 715 336 9142\"},{\"Id\":44,\"FirstName\":\"Gilberto\",\"LastName\":\"Lilford\",\"DateOfBirth\":\"1913-06-05\",\"EmailAddress\":\"glilford17@pbs.org\",\"Telephone\":\"+82 109 639 2236\"},{\"Id\":45,\"FirstName\":\"Tod\",\"LastName\":\"Dani\",\"DateOfBirth\":\"1971-04-19\",\"EmailAddress\":\"tdani18@mozilla.org\",\"Telephone\":\"+46 899 360 1490\"},{\"Id\":46,\"FirstName\":\"Andie\",\"LastName\":\"Buttrey\",\"DateOfBirth\":\"1981-01-10\",\"EmailAddress\":\"abuttrey19@msu.edu\",\"Telephone\":\"+1 159 688 7848\"},{\"Id\":47,\"FirstName\":\"Rozella\",\"LastName\":\"Scholer\",\"DateOfBirth\":\"1963-11-02\",\"EmailAddress\":\"rscholer1a@answers.com\",\"Telephone\":\"+86 586 849 1225\"},{\"Id\":48,\"FirstName\":\"Beniamino\",\"LastName\":\"Nail\",\"DateOfBirth\":\"1985-02-05\",\"EmailAddress\":\"bnail1b@miibeian.gov.cn\",\"Telephone\":\"+86 542 449 8195\"},{\"Id\":49,\"FirstName\":\"Jermaine\",\"LastName\":\"Rieger\",\"DateOfBirth\":\"2001-04-27\",\"EmailAddress\":\"jrieger1c@si.edu\",\"Telephone\":\"+380 344 492 7224\"},{\"Id\":50,\"FirstName\":\"Ruperta\",\"LastName\":\"Stoner\",\"DateOfBirth\":\"1967-12-14\",\"EmailAddress\":\"rstoner1d@amazonaws.com\",\"Telephone\":\"+967 983 679 7384\"}]";

	public void Configure(EntityTypeBuilder<User> builder)
	{
		var sampleData = JsonConvert.DeserializeObject<User[]>(SampleData)!;
		builder.Property(v => v.DateOfBirth).FixDataType();
		builder.HasData(sampleData);
	}
}