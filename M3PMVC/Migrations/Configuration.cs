namespace M3PMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using M3PMVC.PartyModels;

    internal sealed class Configuration : DbMigrationsConfiguration<M3PMVC.Models.PartyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(M3PMVC.Models.PartyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.PReals.AddOrUpdate(pr => pr.CiqPrID,
                //  1
                new M3PPartyReal { CiqPrID = 1, CiqPrtitle = "Dr.", CiqPrname = "Kerem", CiqPrmidname = "Ali", CiqPrsurname = "Ercoskun", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1974-01-14 00:00:00.000"), CiqPrdy = "Ankara", CiqPrbabaad = "Metin Ali", CiqPrannead = "Selen", CiqPrkimlikmaster = "57655510958" },
                //  2
                new M3PPartyReal { CiqPrID = 2, CiqPrtitle = "Mr.", CiqPrname = "Mesut", CiqPrsurname = "Isworking1", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1980-01-01 00:00:00.000"), CiqPrdy = "Türkiye", CiqPrbabaad = "BabasıB", CiqPrannead = "AnasıB", CiqPrkimlikmaster = "55511100222" },
                //  3
                new M3PPartyReal { CiqPrID = 3, CiqPrtitle = "Mr.", CiqPrname = "Nizamettin", CiqPrsurname = "Özdemir", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1962-01-28 00:00:00.000"), CiqPrdy = "Çat", CiqPrbabaad = "BabasıC", CiqPrannead = "AnasıC", CiqPrkimlikmaster = "55511100333" },
                //  4 *DELETED: Calismakartisure= DateTime.Parse("2009-09-05 00:00:00.000"), 
                new M3PPartyReal { CiqPrID = 4, CiqPrtitle = "Mr.", CiqPrname = "Mustafa", CiqPrsurname = "Doðan", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1968-01-19 00:00:00.000"), CiqPrdy = "Manisa", CiqPrbabaad = "BabasıD", CiqPrannead = "AnasıD", CiqPrkimlikmaster = "55511100444" },
                //  5
                new M3PPartyReal { CiqPrID = 5, CiqPrtitle = "Mr.", CiqPrname = "Hikmet", CiqPrsurname = "Yaran", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1969-04-29 00:00:00.000"), CiqPrdy = "Fatsa", CiqPrbabaad = "BabasıE", CiqPrannead = "AnasıE", CiqPrkimlikmaster = "55511100555" },
                //  6
                new M3PPartyReal { CiqPrID = 6, CiqPrtitle = "Mr.", CiqPrname = "Mustafa", CiqPrsurname = "Kotaman", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1979-02-06 00:00:00.000"), CiqPrdy = "Araklı", CiqPrbabaad = "BabasıF", CiqPrannead = "AnasıF", CiqPrkimlikmaster = "55511100666" },
                //  7
                new M3PPartyReal { CiqPrID = 7, CiqPrtitle = "Mr.", CiqPrname = "Ersin", CiqPrsurname = "Büyükkaya", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1983-01-17 00:00:00.000"), CiqPrdy = "Malazgirt", CiqPrbabaad = "BabasıG", CiqPrannead = "AnasıG", CiqPrkimlikmaster = "55511100777" },
                //  8
                new M3PPartyReal { CiqPrID = 8, CiqPrtitle = "Mr.", CiqPrname = "Kadir", CiqPrsurname = "Erdal", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1967-05-11 00:00:00.000"), CiqPrdy = "Balıkesir", CiqPrbabaad = "BabasıH", CiqPrannead = "AnasıH", CiqPrkimlikmaster = "55511100888" },
                //  9
                new M3PPartyReal { CiqPrID = 9, CiqPrtitle = "Mr.", CiqPrname = "Ali", CiqPrsurname = "Pak", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1978-12-10 00:00:00.000"), CiqPrdy = "Vezirköprü", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100999" },
                // 10 *DELETED: Calismakartisure= DateTime.Parse("2009-09-05 00:00:00.000"), 
                new M3PPartyReal { CiqPrID = 10, CiqPrtitle = "Mr.", CiqPrname = "Muharrem", CiqPrsurname = "Aktas", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1965-06-10 00:00:00.000"), CiqPrdy = "Vezirköprü", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100201" },
                // 11 *DELETED: Calismakartisure= DateTime.Parse("2009-09-05 00:00:00.000"), 
                new M3PPartyReal { CiqPrID = 11, CiqPrtitle = "Mr.", CiqPrname = "Mehmet", CiqPrsurname = "Canbolat", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1982-06-01 00:00:00.000"), CiqPrdy = "Vezirköprü", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100301" },
                // 12
                new M3PPartyReal { CiqPrID = 12, CiqPrtitle = "Mr.", CiqPrname = "Ali", CiqPrsurname = "Bakkal", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1989-04-08 00:00:00.000"), CiqPrdy = "ıkizdere", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100401" },
                // 13 * Calismakartisure= DateTime.Parse("2008-12-14 00:00:00.000"), 
                new M3PPartyReal { CiqPrID = 13, CiqPrtitle = "Mr.", CiqPrname = "Köksal", CiqPrsurname = "Abdülazizoðlu", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1988-10-25 00:00:00.000"), CiqPrdy = "Hasanoðlan", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100501" },
                // 14 * Calismakartisure= DateTime.Parse("2008-12-14 00:00:00.000"), 
                new M3PPartyReal { CiqPrID = 14, CiqPrtitle = "Mr.", CiqPrname = "Gökhan", CiqPrsurname = "Birinci", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1990-01-10 00:00:00.000"), CiqPrdy = "ıkizdere", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100601" },
                // 15
                new M3PPartyReal { CiqPrID = 15, CiqPrtitle = "Mr.", CiqPrname = "Eser", CiqPrsurname = "Tas", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1976-07-11 00:00:00.000"), CiqPrdy = "Develi", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100701" },
                // 16
                new M3PPartyReal { CiqPrID = 16, CiqPrtitle = "Mr.", CiqPrname = "Regaip", CiqPrsurname = "sahbudak", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1962-08-12 00:00:00.000"), CiqPrdy = "Develi", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100801" },
                // 17
                new M3PPartyReal { CiqPrID = 17, CiqPrtitle = "Mr.", CiqPrname = "Vurul", CiqPrsurname = "Aplan", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1982-09-10 00:00:00.000"), CiqPrdy = "Domaniç", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100901" },
                // 18
                new M3PPartyReal { CiqPrID = 18, CiqPrtitle = "Mr.", CiqPrname = "Salih", CiqPrsurname = "Çetin", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1981-05-20 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "12345600999" },
                // 19
                new M3PPartyReal { CiqPrID = 19, CiqPrtitle = "Mr.", CiqPrname = "Mehmet", CiqPrsurname = "Çetin", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1984-02-17 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "22211100999" },
                // 20
                new M3PPartyReal { CiqPrID = 20, CiqPrtitle = "Mr.", CiqPrname = "Fevzi", CiqPrsurname = "Karakuzu", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1964-05-20 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "33311100999" },
                // 21
                new M3PPartyReal { CiqPrID = 21, CiqPrtitle = "Mr.", CiqPrname = "Yasar", CiqPrsurname = "Taskın", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1965-12-12 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "44411100999" },
                // 22
                new M3PPartyReal { CiqPrID = 22, CiqPrtitle = "Mr.", CiqPrname = "Fahrettin", CiqPrsurname = "Çitin", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1965-12-12 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "34511100999" },
                // 23
                new M3PPartyReal { CiqPrID = 23, CiqPrtitle = "Mr.", CiqPrname = "Ömer", CiqPrsurname = "Birinci", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1965-12-12 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100303" },
                // 24
                new M3PPartyReal { CiqPrID = 24, CiqPrtitle = "Mr.", CiqPrname = "Mehmet", CiqPrsurname = "sahin", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1965-12-12 00:00:00.000"), CiqPrdy = "Turkiye", CiqPrbabaad = "Babası", CiqPrannead = "Anası", CiqPrkimlikmaster = "55511100403" },
                // 25
                new M3PPartyReal { CiqPrID = 25, CiqPrtitle = "Mr.", CiqPrname = "Em1", CiqPrsurname = "Isworking1", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1970-01-01 00:00:00.000"), CiqPrdy = "Türkiye", CiqPrbabaad = "BabasıJ", CiqPrannead = "AnasıJ", CiqPrkimlikmaster = "55511100503" },
                // 26
                new M3PPartyReal { CiqPrID = 26, CiqPrtitle = "Mr.", CiqPrname = "Dahaönce", CiqPrsurname = "Ekincilerdecalısmıs", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("1970-01-01 00:00:00.000"), CiqPrdy = "Türkiye", CiqPrbabaad = "BabasıK", CiqPrannead = "AnasıK", CiqPrkimlikmaster = "55511100123" },
                // 27
                new M3PPartyReal { CiqPrID = 27, CiqPrtitle = "Mr.", CiqPrname = "Lemi", CiqPrsurname = "Tunçer", CiqPruyruk = "TC", CiqPrdt = DateTime.Parse("2009-12-01 00:00:00.000"), CiqPrdy = "ızmir", CiqPrbabaad = "İbrahim", CiqPrannead = "Anneadı", CiqPrkimlikmaster = "36205607738" }
                );

            //PartyRealadd.ForEach(s => context.PReals.AddOrUpdate(p => p.CiqPrkimlikmaster, s));
            context.SaveChanges();

            //  PARTIES - LEGAL ENTITIES
            //_______________________________________________________________________

            //var PartyLegaladd = new List<PartyLegal>
            //{
            //    //  1
            //    new PartyLegal {CiqPartyTuzelTicariUnvan="OOO Trimorya Construction & Trade Company", CiqPartTuzelvalfrom=DateTime.Parse("2005-01-01 00:00:00.000"), CiqPartyvalto=DateTime.Parse("2005-01-01"), CiqPartyvergid="Moskova", CiqPartyTuzelvergino="1111199999", CiqPartyTuzelintype="LLC;LTD"},
            //    //  2
            //    new PartyLegal {CiqPartyTuzelTicariUnvan="International Centre for Applied Thermodynamics", CiqPartTuzelvalfrom=DateTime.Parse("1997-01-01 00:00:00.000"), CiqPartyvalto=DateTime.Parse("1997-01-01"), CiqPartyvergid="Erenköy", CiqPartyTuzelvergino="8900232067", CiqPartyTuzelintype="Association;Dernek"},
            //    //  3
            //    new PartyLegal {CiqPartyTuzelTicariUnvan="Ekinciler ınsaat A.s.", CiqPartTuzelvalfrom=DateTime.Parse("1980-01-01 00:00:00.000"), CiqPartyvalto=DateTime.Parse("1980-01-01 00:00:00.000"), CiqPartyvergid="Diyarbakır", CiqPartyTuzelvergino="000000000", CiqPartyTuzelintype="Company;A.s."},
            //};

            //PartyLegaladd.ForEach(s => context.PartyLegals.AddOrUpdate(p => p.CiqPartyTuzelTicariUnvan, s));
            //context.SaveChanges();


            //  EMPLOYMENT
            //_______________________________________________________________________

            //var Employments = new List<PartyEmployment>
            //{
            ////  1
            //new PartyEmployment {Isegiris=DateTime.Parse("2013-07-09 00:00:00.000"), Istencikis=DateTime.Parse("2013-07-09 00:00:00.000"), Isegirisnedeni="ılk baslama", Istencikisnedeni="Halen Çalısıyor", CiqPartypersonelgorev="Yardımcı Koordinatör", Calistigiprojekodu="M3PCEN001", Personelkademesi=2, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =1, MigrationID="Y"},
            ////  2
            //new PartyEmployment {Isegiris=DateTime.Parse("2013-07-15 00:00:00.000"), Isegirisnedeni="ılk baslama", Istencikis=DateTime.Parse("2013-08-30 00:00:00.000"), Istencikisnedeni="Soçi santiye Atama", CiqPartypersonelgorev="Yardımcı Proje Müdürü", Calistigiprojekodu="M3PCEN001", Personelkademesi=3, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =2, MigrationID="A"},
            //new PartyEmployment {Isegiris=DateTime.Parse("2013-08-30 00:00:00.000"), Isegirisnedeni="Soçi santiye Destek", Istencikis=DateTime.Parse("2029-12-31 00:00:00.000"), CiqPartypersonelgorev="Saha Mühendisi", Calistigiprojekodu="M3PSOC001", Personelkademesi=4, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =2, MigrationID="Z"},
            ////  3
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kamp Amiri", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=5, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =3, MigrationID="B"},
            ////  4
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Ambar Sorumlusu", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=6, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =4, MigrationID="C"},
            ////  5
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalite Kontrol", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=5, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =5, MigrationID="D"},
            ////  6
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Personel sefi", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=4, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =6, MigrationID="E"},
            ////  7
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Elektrikçi", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =7, MigrationID="F"},
            ////  8
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kaynakçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =8, MigrationID="G"},
            ////  9
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =9, MigrationID="H"},
            //// 10
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =10, MigrationID="I"},
            //// 11
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =11, MigrationID="J"},
            //// 12
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =11, MigrationID="K"},
            //// 13
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =13, MigrationID="L"},
            //// 14
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =14, MigrationID="M"},
            //// 15
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =15, MigrationID="N"},
            //// 16
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =16, MigrationID="O"},
            //// 17
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =17, MigrationID="P"},
            //// 18
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Betoncu", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =18, MigrationID="Q"},
            //// 19
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Betoncu", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =19, MigrationID="R"},
            //// 20
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Demirci", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=8, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =20, MigrationID="S"},
            //// 21
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Demirci Usta Bası", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=7, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =21, MigrationID="T"},
            //// 22
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Betoncu Usta Bası", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=7, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =22, MigrationID="U"},
            //// 23
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı Usta Bası", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=7, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =23, MigrationID="V"},
            //// 24
            //new PartyEmployment {Isegiris=DateTime.Parse("2007-01-01 00:00:00.000"), Isegirisnedeni="Moskova Shatura santiyesi Mobilizasyonu", Istencikis=DateTime.Parse("2010-07-01 00:00:00.000"), Istencikisnedeni="ınsaat Bitimi", CiqPartypersonelgorev="Kalıpçı Usta Bası", Calistigiprojekodu="M3PMOSSHA001", Personelkademesi=7, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =24, MigrationID="W"},
            //// 25
            //new PartyEmployment {Isegiris=DateTime.Parse("2012-01-01 00:00:00.000"), Isegirisnedeni="ılk baslama", Istencikis=DateTime.Parse("2029-12-31 00:00:00.000"), CiqPartypersonelgorev="Kesif Metraj Uzmanı", Calistigiprojekodu="M3PCEN001", Personelkademesi=3, Calistigiulke="Rusya Federasyonu", Notlar = "dummy", CiqPrID =25, MigrationID="X"},
            //};

            //Employments.ForEach(s => context.PartyEmployments.AddOrUpdate(p => p.MigrationID, s));
            //context.SaveChanges();

            //  AFFILIATION
            //_______________________________________________________________________
            //var Affiliations = new List<PartyAffiliation>
            //{
            ////  1
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "57655510958").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "57655510958").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "International Centre for Applied Thermodynamics").CiqPartyTuzelID},    
            ////  2
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100222").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  3
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100333").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  4
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100444").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  5
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100555").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  6
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100666").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  7
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100777").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  8
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100888").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            ////  9
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 10
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100201").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 11
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100301").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 12
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100401").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 13
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100501").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 14
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100601").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 15
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100701").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 16
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100801").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 17
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100901").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 18
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "12345600999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 19
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "22211100999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 20
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "33311100999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 21
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "44411100999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 22
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "34511100999").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 23
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100303").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 24
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100403").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 25
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100503").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "OOO Trimorya Construction & Trade Company").CiqPartyTuzelID},
            //// 26
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100123").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "Ekinciler ınsaat A.s.").CiqPartyTuzelID},               
            //// 27
            //new PartyAffiliation {
            //CiqPrID = PartyRealadd.Single(s => s.CiqPrkimlikmaster == "36205607738").CiqPrID,
            //CiqPartyTuzel_ciaPartyTuzelID = PartyLegaladd.Single(c => c.CiqPartyTuzelTicariUnvan == "International Centre for Applied Thermodynamics").CiqPartyTuzelID},                       
            //};

            //foreach (PartyAffiliation e in Affiliations)
            //{
            //var affiliationInDatabase = context.PartyAffiliations.Where(
            //s =>
            //s.PartyReals.CiqPrID == e.CiqPrID  &&
            //s.PartyLegals.CiqPartyTuzelID == e.CiqPartyTuzel_ciaPartyTuzelID).SingleOrDefault();
            //if (affiliationInDatabase == null)
            //{
            //context.PartyAffiliations.Add(e);
            //}
            //}
            //context.SaveChanges();

            //  PASAPORT BıLGıLERı
            //_______________________________________________________________________

            context.PPassports.AddOrUpdate(pp => pp.CiqPartyPasno,
            //  1
            new PartyPassport
            {
                CiqPrID = 1, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "57655510958").CiqPrID,
                CiqPartyPasno = "U 02060730",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2021-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  2
            new PartyPassport
            {
                CiqPrID = 2, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100222").CiqPrID,
                CiqPartyPasno = "TR-M 976198",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2014-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  3
            new PartyPassport
            {
                CiqPrID = 3, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100333").CiqPrID,
                CiqPartyPasno = "TR-M 443611",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2013-09-30 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  4
            new PartyPassport
            {
                CiqPrID = 4, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100444").CiqPrID,
                CiqPartyPasno = "TR-G 795396",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2014-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  5
            new PartyPassport
            {
                CiqPrID = 5, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100555").CiqPrID,
                CiqPartyPasno = "TR-P 779276",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2013-10-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  6
            new PartyPassport
            {
                CiqPrID = 6, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100666").CiqPrID,
                CiqPartyPasno = "TR-U 906094",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2014-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  7
            new PartyPassport
            {
                CiqPrID = 7, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100777").CiqPrID,
                CiqPartyPasno = "TR-P 543443",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2014-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  8
            new PartyPassport
            {
                CiqPrID = 8, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100888").CiqPrID,
                CiqPartyPasno = "TR-U 105847",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2014-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            //  9
            new PartyPassport
            {
                CiqPrID = 9, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100999").CiqPrID,
                CiqPartyPasno = "TR-U 251340",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2016-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 10
            new PartyPassport
            {
                CiqPrID = 10, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100201").CiqPrID,
                CiqPartyPasno = "TR-N 050769",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2018-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 11
            new PartyPassport
            {
                CiqPrID = 11, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100301").CiqPrID,
                CiqPartyPasno = "TR-L 897320",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 12
            new PartyPassport
            {
                CiqPrID = 12, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100401").CiqPrID,
                CiqPartyPasno = "TR-U 106862",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 13
            new PartyPassport
            {
                CiqPrID = 13, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100501").CiqPrID,
                CiqPartyPasno = "TR-U 106893",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 14
            new PartyPassport
            {
                CiqPrID = 14, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100601").CiqPrID,
                CiqPartyPasno = "TR-U 106863",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 15
            new PartyPassport
            {
                CiqPrID = 15, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100701").CiqPrID,
                CiqPartyPasno = "TR-U 979859",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 16
            new PartyPassport
            {
                CiqPrID = 16, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100801").CiqPrID,
                CiqPartyPasno = "TR-P 919668",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 17
            new PartyPassport
            {
                CiqPrID = 17, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100901").CiqPrID,
                CiqPartyPasno = "TR-U 978122",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 18
            new PartyPassport
            {
                CiqPrID = 18, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "12345600999").CiqPrID,
                CiqPartyPasno = "TR-U 969161",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 19
            new PartyPassport
            {
                CiqPrID = 19, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "22211100999").CiqPrID,
                CiqPartyPasno = "TR-P 097970",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 20
            new PartyPassport
            {
                CiqPrID = 20, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "33311100999").CiqPrID,
                CiqPartyPasno = "TR-T 463591",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 21
            new PartyPassport
            {
                CiqPrID = 21, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "44411100999").CiqPrID,
                CiqPartyPasno = "TR-U 142533",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 22
            new PartyPassport
            {
                CiqPrID = 22, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "34511100999").CiqPrID,
                CiqPartyPasno = "TR-T 361300",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 23
            new PartyPassport
            {
                CiqPrID = 23, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100303").CiqPrID,
                CiqPartyPasno = "TR-U 791079",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 24
            new PartyPassport
            {
                CiqPrID = 24, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100403").CiqPrID,
                CiqPartyPasno = "TR-U 790259",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 25
            new PartyPassport
            {
                CiqPrID = 25, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100503").CiqPrID,
                CiqPartyPasno = "TR-T 632607",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            },
            // 26
            new PartyPassport
            {
                CiqPrID = 26, //PartyRealadd.Single(s => s.CiqPrkimlikmaster == "55511100123").CiqPrID,
                CiqPartyPasno = "TR-T 434042",
                CiqPartyPasvert = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasgec = DateTime.Parse("2011-04-25 00:00:00.000"),
                CiqPartyPasvery = "PENDıK"
            }
            // 27
            );

            //Passports.ForEach(s => context.PPassports.AddOrUpdate(p => p.CiqPartyPasno, s));

            //foreach (PartyPassport p in Passports)
            //{
            //    var passportsInDataBase = context.PartyPassports.Where(
            //        t =>
            //             p.CiqPrID == t.PartyReal.CiqPrID);

            //    if (passportsInDataBase == null)
            //    {
            //        context.PartyPassports.Add(p);
            //    }
            //}

            context.SaveChanges();

            //  VıZELER
            //_______________________________________________________________________

            context.PVisas.AddOrUpdate(pv => pv.CiqPartyVizeno,
            //  1
            new PartyVisa
            {
                CiqPartyPasno = "U 02060730",
                CiqPrID = 1,
                CiqPartyVizeno = "AHT55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  2
            new PartyVisa
            {
                CiqPartyPasno = "TR-M 976198",
                CiqPrID = 2,
                CiqPartyVizeno = "AHT11111",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  3
            new PartyVisa
            {
                CiqPartyPasno = "TR-M 443611",
                CiqPrID = 3,
                CiqPartyVizeno = "AHT22222",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  4
            new PartyVisa
            {
                CiqPartyPasno = "TR-G 795396",
                CiqPrID = 4,
                CiqPartyVizeno = "AHT33333",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  5
            new PartyVisa
            {
                CiqPartyPasno = "TR-P 779276",
                CiqPrID = 5,
                CiqPartyVizeno = "AHT44444",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  6
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 906094",
                CiqPrID = 6,
                CiqPartyVizeno = "AHT55555",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  7
            new PartyVisa
            {
                CiqPartyPasno = "TR-P 543443",
                CiqPrID = 7,
                CiqPartyVizeno = "AHT66666",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  8
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 105847",
                CiqPrID = 8,
                CiqPartyVizeno = "AHT77777",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            //  9
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 251340",
                CiqPrID = 9,
                CiqPartyVizeno = "AHT88888",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 10
            new PartyVisa
            {
                CiqPartyPasno = "TR-N 050769",
                CiqPrID = 10,
                CiqPartyVizeno = "AHT99999",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 11
            new PartyVisa
            {
                CiqPartyPasno = "TR-L 897320",
                CiqPrID = 11,
                CiqPartyVizeno = "AHT12345",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 12
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 106862",
                CiqPrID = 12,
                CiqPartyVizeno = "AHT23456",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 13
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 106893",
                CiqPrID = 13,
                CiqPartyVizeno = "AHT34567",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 14
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 106863",
                CiqPrID = 14,
                CiqPartyVizeno = "AHT45678",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 15
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 979859",
                CiqPrID = 15,
                CiqPartyVizeno = "AHT56789",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 16
            new PartyVisa
            {
                CiqPartyPasno = "TR-P 919668",
                CiqPrID = 16,
                CiqPartyVizeno = "AHT87654",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 17
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 978122",
                CiqPrID = 17,
                CiqPartyVizeno = "AHT76543",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 18
            new PartyVisa
            {
                CiqPartyPasno = "TR-P 097970",
                CiqPrID = 18,
                CiqPartyVizeno = "AHT65432",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 19
            new PartyVisa
            {
                CiqPartyPasno = "TR-T 463591",
                CiqPrID = 19,
                CiqPartyVizeno = "AHT54321",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 20
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 142533",
                CiqPrID = 20,
                CiqPartyVizeno = "AHT98765",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 21
            new PartyVisa
            {
                CiqPartyPasno = "TR-T 361300",
                CiqPrID = 21,
                CiqPartyVizeno = "AAA55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 22
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 791079",
                CiqPrID = 22,
                CiqPartyVizeno = "BBB55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 23
            new PartyVisa
            {
                CiqPartyPasno = "TR-U 790259",
                CiqPrID = 23,
                CiqPartyVizeno = "CCC55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 24
            new PartyVisa
            {
                CiqPartyPasno = "TR-T 632607",
                CiqPrID = 24,
                CiqPartyVizeno = "DDD55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            },
            // 25
            new PartyVisa
            {
                CiqPartyPasno = "TR-T 434042",
                CiqPrID = 25,
                CiqPartyVizeno = "EEE55016",
                CiqPartyVizebas = DateTime.Parse("2013-07-09 00:00:00.000"),
                CiqPartyVizeson = DateTime.Parse("2013-09-05 00:00:00.000"),
                CiqPartyVizecnt = "RUSYA",
                CiqPartyVizeEnt = "1",
                CiqPartyVizetipi = "TEKNıK"
            }
            );

            //Visas.ForEach(s => context.PVisas.AddOrUpdate(p => p.CiqPartyVizeno, s));
            context.SaveChanges();
        }
    }
}
