using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Devon4Net.WebAPI.Implementation.Migrations
{
    public partial class _17012021_Ael_SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Taxes",
                columns: new[] { "Id", "TaxDeadlineDate", "TaxName", "Year" },
                values: new object[,]
                {
                    { new Guid("8b3293b9-991a-4d2a-991a-1009af56f085"), new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ibi", 2021 },
                    { new Guid("cb855976-d21d-42f6-92e7-d0c988b915b1"), new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ibi", 2022 },
                    { new Guid("b244e7fe-db00-4191-bffc-b8aab5e0c930"), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ibi", 2023 },
                    { new Guid("1b861525-098a-4acb-ad83-f3a2572cea09"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "vehiculos", 2021 },
                    { new Guid("113a2bc0-78e9-4699-bf5c-db2a14b3e651"), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "vehiculos", 2022 },
                    { new Guid("5264fa44-a6a4-4cb7-8c22-772af147a91b"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "vehiculos", 2023 },
                    { new Guid("6f2edd78-9233-43fd-92a8-b3d106b8fcc9"), new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "basura", 2021 },
                    { new Guid("d48716b4-def8-412a-8c9f-6df2f82fad7b"), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "basura", 2022 },
                    { new Guid("620f0961-04aa-4ac7-9882-4372b329eca7"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "basura", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Community", "TownName" },
                values: new object[,]
                {
                    { new Guid("ea71bc06-fc94-4297-b5e1-226e0f23f0e5"), " Comunidad Valenciana", "montroy" },
                    { new Guid("82a2ee7d-0489-4129-9032-aafbf7645f46"), " Comunidad Valenciana", "montichelvo" },
                    { new Guid("e408da6f-6f03-4a48-9979-87616992ce45"), " Comunidad Valenciana", "montesa" },
                    { new Guid("e498984e-cbb0-4c68-9a05-ccc29a62b779"), " Comunidad Valenciana", "montaberner" },
                    { new Guid("f4f234d2-27b9-41dd-93a3-788bf2727ba8"), " Comunidad Valenciana", "moncada" },
                    { new Guid("1d876f35-f321-49ad-9aab-297e6346ff94"), " Comunidad Valenciana", "mogente" },
                    { new Guid("cfdaf29a-ba4d-4c90-b624-3dffa6e2bd90"), " Comunidad Valenciana", "meliana" },
                    { new Guid("6f828e0c-75ca-4062-8fac-b559ded2f125"), " Comunidad Valenciana", "miramar" },
                    { new Guid("c167b944-fda3-4a8c-a2dc-f5fa595bb7c9"), " Comunidad Valenciana", "millares" },
                    { new Guid("b1f9ba50-1ea4-4daa-83e6-d0b73850619c"), " Comunidad Valenciana", "montserrat" },
                    { new Guid("3885dca2-7fb8-4f54-ba33-f5ca46cfb75b"), " Comunidad Valenciana", "masanasa" },
                    { new Guid("c3f2f59a-7d0b-4ccd-b85c-00823d3bb0ae"), " Comunidad Valenciana", "masamagrell" },
                    { new Guid("47e4ac16-031a-403b-9945-78c9af0345fd"), " Comunidad Valenciana", "mislata" },
                    { new Guid("7369aaac-a350-4413-a27c-5b03054f917c"), " Comunidad Valenciana", "museros" },
                    { new Guid("6bdb78f9-4851-4d62-aef0-110d8ab60de2"), " Comunidad Valenciana", "ollería" },
                    { new Guid("d271e7ce-6c90-4010-a594-b9bedb74cbbb"), " Comunidad Valenciana", "navarrés" },
                    { new Guid("4755899f-dd37-4064-9ac7-1a1501a0b370"), " Comunidad Valenciana", "novelé" },
                    { new Guid("59f1d4e8-0c23-497e-b51c-fb2b805c0100"), " Comunidad Valenciana", "oliva" },
                    { new Guid("13fa07f7-fab8-4067-a52b-3d72a4b65060"), " Comunidad Valenciana", "masalfasar" },
                    { new Guid("2c76f35b-c87a-47cf-b83a-79594c95c0ae"), " Comunidad Valenciana", "olocau" },
                    { new Guid("41bef719-940c-44a7-95e4-c24b0bc06b06"), " Comunidad Valenciana", "onteniente" },
                    { new Guid("ceb3a92a-9c71-4c68-93b8-f7e4e9f608d1"), " Comunidad Valenciana", "otos" },
                    { new Guid("df1dcb3a-4e0e-4202-bc4b-40a669a5bd19"), " Comunidad Valenciana", "paiporta" },
                    { new Guid("dc86168e-861a-46dd-9b34-2eb7762a2fee"), " Comunidad Valenciana", "palma de gandía" },
                    { new Guid("144f51a7-7efb-4441-bff2-66e6a3de1417"), " Comunidad Valenciana", "palmera" },
                    { new Guid("345a84b6-30a6-4d92-8733-110459e86ef2"), " Comunidad Valenciana", "palomar" },
                    { new Guid("2b898b7e-2a8a-4eab-912e-364062c46bae"), " Comunidad Valenciana", "paterna" },
                    { new Guid("7c693936-d090-4d62-acb1-0955c9f575d1"), " Comunidad Valenciana", "pedralba" },
                    { new Guid("068c3ef6-dfaf-41b2-8ce8-8eafb43e95e0"), " Comunidad Valenciana", "petrés" },
                    { new Guid("2fbaebda-d34e-43f8-8300-87d65139beea"), " Comunidad Valenciana", "náquera" },
                    { new Guid("b956bf93-7e42-4002-bf7f-b182b23672b0"), " Comunidad Valenciana", "masalavés" },
                    { new Guid("9acec518-dcd4-4e19-ba24-8aabab4bf1d5"), " Comunidad Valenciana", "lugar nuevo de san jerónimo" },
                    { new Guid("a99bff99-49d5-452a-b870-8381cbaf349e"), " Comunidad Valenciana", "manuel" },
                    { new Guid("91098712-2877-4771-9239-bf52ced81af2"), " Comunidad Valenciana", "gestalgar" },
                    { new Guid("105570c6-20fd-43b4-8ff1-bf19c5dfec60"), " Comunidad Valenciana", "gilet" },
                    { new Guid("d214c971-aa04-4041-9a7a-087dc1249aea"), " Comunidad Valenciana", "godella" },
                    { new Guid("d31b5a93-791c-44bf-939a-ef4711920a58"), " Comunidad Valenciana", "godelleta" },
                    { new Guid("49f27a9e-a146-457f-a2a2-7c8046c518de"), " Comunidad Valenciana", "guadasequies" },
                    { new Guid("d75e137e-b24d-4534-bf03-7f97b4ce2d41"), " Comunidad Valenciana", "guadasuar" },
                    { new Guid("4cff2a08-891e-4b57-9282-aed4c8af2102"), " Comunidad Valenciana", "guardamar de la safor" },
                    { new Guid("52f16894-faad-4917-8613-d27715291315"), " Comunidad Valenciana", "higueruelas" },
                    { new Guid("98ba6fa3-d109-4b5e-85b6-c288902e81ef"), " Comunidad Valenciana", "jalance" },
                    { new Guid("f7873a04-3e9b-4eed-9c3e-f64bd9de5199"), " Comunidad Valenciana", "jaraco" },
                    { new Guid("2c05a8a8-418b-44ae-9fdb-8a261b73c3b4"), " Comunidad Valenciana", "jarafuel" },
                    { new Guid("2ff326f5-1f81-49d0-888a-b459d6946879"), " Comunidad Valenciana", "játiva" },
                    { new Guid("9dfecc53-d417-4f39-9598-e4ed4fd51400"), " Comunidad Valenciana", "jeresa" },
                    { new Guid("5abcb3c3-dbd4-47ae-b165-559ebc74067d"), " Comunidad Valenciana", "la alcudia" },
                    { new Guid("541d41f2-1d48-4d59-96a4-86b959a4a034"), " Comunidad Valenciana", "marines" },
                    { new Guid("4164cd95-0c9f-4ba3-a8fe-7659b6864c5a"), " Comunidad Valenciana", "la eliana" },
                    { new Guid("22c9f0da-dcaa-400b-af65-834c7df99d60"), " Comunidad Valenciana", "la yesa" },
                    { new Guid("a97a08e2-41b3-40c2-8362-07e3a330830e"), " Comunidad Valenciana", "líria" },
                    { new Guid("5470485a-2135-47a7-b8c1-272d728c2d29"), " Comunidad Valenciana", "llanera de ranes" },
                    { new Guid("96e24080-3394-40b2-96bc-2b9910563c14"), " Comunidad Valenciana", "llaurí" },
                    { new Guid("37ce3498-fd5a-481d-9bbc-ac3845a37137"), " Comunidad Valenciana", "llombay" },
                    { new Guid("ef8538b9-4ff1-4640-b63f-42b5d9334925"), " Comunidad Valenciana", "llosa de ranes" },
                    { new Guid("84b44b34-c986-4bfe-99d7-bf7280c2d50b"), " Comunidad Valenciana", "loriguilla" },
                    { new Guid("5ddb3184-0798-4372-a192-6853fe7b0387"), " Comunidad Valenciana", "losa del obispo" },
                    { new Guid("b0e3c018-ff2c-4916-913e-34803b5be7d1"), " Comunidad Valenciana", "luchente" },
                    { new Guid("4c245ffd-a900-4586-8d05-535ae6b189cc"), " Comunidad Valenciana", "lugar nuevo de fenollet" },
                    { new Guid("4399f130-d478-40dc-8472-663882661b49"), " Comunidad Valenciana", "lugar nuevo de la corona" },
                    { new Guid("f9bf7790-4aba-4c88-977e-43d1653c47f2"), " Comunidad Valenciana", "picaña" },
                    { new Guid("fafd2b1a-0e02-40c9-84ab-cc42e3472ce0"), " Comunidad Valenciana", "macastre" },
                    { new Guid("ddf5741d-bb27-4375-9193-480217177f5f"), " Comunidad Valenciana", "manises" },
                    { new Guid("575e0992-6bcf-41b9-b3ef-0b3278da44a2"), " Comunidad Valenciana", "la granja de la costera" },
                    { new Guid("48635b15-e51d-4a53-b3d2-5e37cef8714c"), " Comunidad Valenciana", "picasent" },
                    { new Guid("7e2e6fd3-3fe9-411d-abd4-bc50916d1ecd"), " Comunidad Valenciana", "potríes" },
                    { new Guid("39e3c4fd-6060-492f-8212-543228a0a0d9"), " Comunidad Valenciana", "pinet" },
                    { new Guid("6e1b601d-5836-4832-8427-ffa5d6895943"), " Comunidad Valenciana", "simat de valldigna" },
                    { new Guid("9de5516f-9500-4c57-a616-e8ee7213fa19"), " Comunidad Valenciana", "sinarcas" },
                    { new Guid("3a87f18c-0cf7-4c29-91b8-299f02c97202"), " Comunidad Valenciana", "sollana" },
                    { new Guid("bac8e02b-3507-473c-8d11-6c75190daa1c"), " Comunidad Valenciana", "sot de chera" },
                    { new Guid("97852ef0-8c30-4b24-b5b1-737f44ef751c"), " Comunidad Valenciana", "sueca" },
                    { new Guid("1d6c2d03-5345-4d63-846a-0ad055f813cd"), " Comunidad Valenciana", "sumacárcel" },
                    { new Guid("0ed5ff46-d70c-403f-81b2-a84fb4be7190"), " Comunidad Valenciana", "tabernes blanques" },
                    { new Guid("49067672-052c-48b3-8e64-913cd6803c66"), " Comunidad Valenciana", "tabernes de valldigna" },
                    { new Guid("510248ab-797d-4e18-bb20-ad78aa900553"), " Comunidad Valenciana", "teresa de cofrentes" },
                    { new Guid("22030132-4c62-4250-8d65-6d85e5ca4ad1"), " Comunidad Valenciana", "terrateig" },
                    { new Guid("f8f57c8b-cc29-4618-941d-704a9773ed52"), " Comunidad Valenciana", "titaguas" },
                    { new Guid("0328d588-2f62-4a4b-8e2b-f0d1149e4c7a"), " Comunidad Valenciana", "torrebaja" },
                    { new Guid("7f814d62-4b46-4f66-a7d4-42f53d372d94"), " Comunidad Valenciana", "torrella" },
                    { new Guid("44cc929b-9494-4249-9a52-154042c1b348"), " Comunidad Valenciana", "torrente" },
                    { new Guid("d9aff0f3-35bb-46f5-a028-db7c44b061fe"), " Comunidad Valenciana", "torres torres" },
                    { new Guid("37395cd3-a350-487b-86f3-0993df3f8aad"), " Comunidad Valenciana", "tous" },
                    { new Guid("15607528-1f10-47af-b3ed-22eb5942ede2"), " Comunidad Valenciana", "tuéjar" },
                    { new Guid("942a987b-2875-42ac-8bb5-cf37ab71db5d"), " Comunidad Valenciana", "turís" },
                    { new Guid("1c1776ec-b828-4bad-baf6-f942c1107ef8"), " Comunidad Valenciana", "utiel" },
                    { new Guid("d7dad211-13ed-4b32-aebf-7060f81040e4"), " Comunidad Valenciana", "vallada" },
                    { new Guid("f0e6eedd-6354-4654-9bc7-f84372bf7587"), " Comunidad Valenciana", "vallanca" },
                    { new Guid("7a668df6-bdba-4ddb-83c0-7f26ea01986b"), " Comunidad Valenciana", "vallés" },
                    { new Guid("bfb02abf-0dd5-412d-b969-b8d40382ef34"), " Comunidad Valenciana", "venta del moro" },
                    { new Guid("bfb69b27-937b-4faf-9aeb-13c0e30b0f42"), " Comunidad Valenciana", "villalonga" },
                    { new Guid("6b6fc680-a1a5-40ed-99f9-3b07776b8403"), " Comunidad Valenciana", "villamarchante" },
                    { new Guid("8464183b-dfec-44ad-8ed3-2954ddd01530"), " Comunidad Valenciana", "villanueva de castellón" },
                    { new Guid("8f8e2329-1867-4858-a5a0-30be865ae636"), " Comunidad Valenciana", "villar del arzobispo" },
                    { new Guid("0b4b54fc-f83d-43b0-8355-447bbb6a4726"), " Comunidad Valenciana", "villargordo del cabriel" },
                    { new Guid("ceb64fb7-476f-408c-b678-8f36baa9a277"), " Comunidad Valenciana", "vinalesa" },
                    { new Guid("b247da68-700b-481c-b880-3b5c5a1f2729"), " Comunidad Valenciana", "silla" },
                    { new Guid("54aaf3de-87c2-4b08-b1fa-56555aa75b38"), " Comunidad Valenciana", "siete aguas" },
                    { new Guid("43b31003-4633-495c-8331-c83834959e1f"), " Comunidad Valenciana", "serra" },
                    { new Guid("5687d155-6613-40c1-bb8d-d65e767860b9"), " Comunidad Valenciana", "señera" },
                    { new Guid("97e7938d-d8c1-4eab-9675-82f5d0c90c45"), " Comunidad Valenciana", "poliñá de júcar" },
                    { new Guid("6a1f9d48-c7cd-4f26-9bea-5f91759b30e6"), " Comunidad Valenciana", "genovés" },
                    { new Guid("850c7ca0-6d48-4a3a-9460-fb7fc1fcfc27"), " Comunidad Valenciana", "puebla de farnals" },
                    { new Guid("b45247ce-f5d2-44d3-94d3-6c93ade6d66a"), " Comunidad Valenciana", "puebla de san miguel" },
                    { new Guid("741f6ef5-c6a4-4bbf-b744-f65b039cc40d"), " Comunidad Valenciana", "puebla de vallbona" },
                    { new Guid("67c042e6-11fc-4743-934f-44e9e8dd858e"), " Comunidad Valenciana", "puebla del duc" },
                    { new Guid("aab41ec8-6068-499d-9a65-aa635c4dc027"), " Comunidad Valenciana", "puebla larga" },
                    { new Guid("ce641785-b363-4927-93a3-f1aec39aeb54"), " Comunidad Valenciana", "puzol" },
                    { new Guid("2bc46324-c059-4468-a00e-f56ed0d94c3f"), " Comunidad Valenciana", "quesa" },
                    { new Guid("01324847-fa45-4bb1-ab26-c678d9af2e58"), " Comunidad Valenciana", "rafelbuñol" },
                    { new Guid("f37d0b59-a85c-4762-a54c-abcd159865bc"), " Comunidad Valenciana", "rafelcofer" },
                    { new Guid("40030518-f8d4-4039-891b-9a1b9c28d9ee"), " Comunidad Valenciana", "rafelguaraf" },
                    { new Guid("b67f783a-639b-4a13-a750-eb029c739759"), " Comunidad Valenciana", "ráfol de salem" },
                    { new Guid("571e7e3d-5dfd-4ec5-aa90-b709f05d3d6a"), " Comunidad Valenciana", "real" },
                    { new Guid("955828bb-e864-4504-b163-3ffdf16a79d8"), " Comunidad Valenciana", "piles" },
                    { new Guid("805d8131-dbb6-4ebc-bde0-f7a962555187"), " Comunidad Valenciana", "real de gandía" },
                    { new Guid("6fc772af-baf9-44da-b58c-554f3b3b3186"), " Comunidad Valenciana", "ribarroja del turia" },
                    { new Guid("b089f329-4b2f-43cf-8295-49dc30e81fc4"), " Comunidad Valenciana", "riola" },
                    { new Guid("e324d66e-5c70-4526-8e24-bd8e1cf4f647"), " Comunidad Valenciana", "rocafort" },
                    { new Guid("155181c1-e7a8-4250-bd2d-f84e105ee1ca"), " Comunidad Valenciana", "rotglá y corberà" },
                    { new Guid("5339a698-9487-4cda-b32b-fe4ecf19a0c8"), " Comunidad Valenciana", "rótova" },
                    { new Guid("9b3a1cba-a066-4f1a-a711-bf0794645e3a"), " Comunidad Valenciana", "rugat" },
                    { new Guid("4a978b5c-9c88-4b1c-92fa-ee27f68af818"), " Comunidad Valenciana", "sagunto" },
                    { new Guid("b78fda29-84ca-4cf3-a5cf-4fa54cb1d38d"), " Comunidad Valenciana", "salem" },
                    { new Guid("076072f5-2db3-41db-b428-6e568130478a"), " Comunidad Valenciana", "san antonio de benagéber" },
                    { new Guid("a3a5c73b-d048-40a1-8efd-04cdb3e9552e"), " Comunidad Valenciana", "san juan de énova" },
                    { new Guid("981b4475-12af-4c33-8365-1bcba5973145"), " Comunidad Valenciana", "sedaví" },
                    { new Guid("d1399795-5a9a-4ae9-9e30-bed2ddaf05a5"), " Comunidad Valenciana", "segart" },
                    { new Guid("52ad3fd1-8e21-4677-8a7e-0951c9365f7d"), " Comunidad Valenciana", "sellent" },
                    { new Guid("2ea54269-9476-43be-a067-05e65ef22a5d"), " Comunidad Valenciana", "sempere" },
                    { new Guid("754f43bb-a340-4ecc-9f6d-69624045fa2d"), " Comunidad Valenciana", "requena" },
                    { new Guid("499ee244-5105-4f59-a2b6-449760bb9543"), " Comunidad Valenciana", "gátova" },
                    { new Guid("94fcc6f2-55f1-4d56-8d44-f16ccc4dcbf7"), " Comunidad Valenciana", "fuente la higuera" },
                    { new Guid("15b680c9-7215-4107-98d4-7d809bf3a9c2"), " Comunidad Valenciana", "gabarda" },
                    { new Guid("e3f33976-e9d1-414d-aa31-99e11ab64660"), " Comunidad Valenciana", "almusafes" },
                    { new Guid("f1bf088e-2834-4125-a433-b25dc11bb875"), " Comunidad Valenciana", "alpuente" },
                    { new Guid("f7e17ef8-9012-4080-a48a-7361e74f284b"), " Comunidad Valenciana", "alquería de la condesa" },
                    { new Guid("44f6d13e-0b12-4e1b-859f-2c15f4d1438c"), " Comunidad Valenciana", "andilla" },
                    { new Guid("1edec53c-f167-413b-83a7-96d21cf83e59"), " Comunidad Valenciana", "anna" },
                    { new Guid("dd5f4e23-a65a-4892-a89a-8fd603e701d6"), " Comunidad Valenciana", "antella" },
                    { new Guid("2dabf263-0105-41ca-ac86-d83c35a2ebe4"), " Comunidad Valenciana", "aras de los olmos" },
                    { new Guid("ad467f30-775b-45ba-a24a-c925b28fbf29"), " Comunidad Valenciana", "ayelo de malferit" },
                    { new Guid("51d93462-c909-40a1-8e7d-ea621b668f15"), " Comunidad Valenciana", "ayelo de rugat" },
                    { new Guid("72f85452-a015-4c3c-83fc-bf07116b8ac0"), " Comunidad Valenciana", "ayora" },
                    { new Guid("9563d586-8ad0-47af-a2a2-cbe45db23333"), " Comunidad Valenciana", "barcheta" },
                    { new Guid("b0e135e0-999a-4a85-8572-ad8515c00c68"), " Comunidad Valenciana", "bárig" },
                    { new Guid("bc3df222-99e1-4894-a9d0-a9bbd825c55c"), " Comunidad Valenciana", "bélgida" },
                    { new Guid("ed7d0125-7bdf-4767-80e2-2abd0bdd0370"), " Comunidad Valenciana", "bellreguart" },
                    { new Guid("9e8f11ac-cd0c-4245-9ce8-bf6e28548e19"), " Comunidad Valenciana", "bellús" },
                    { new Guid("2a3fd21d-5482-4f14-b71d-37c54c2dccae"), " Comunidad Valenciana", "benagéber" },
                    { new Guid("9bf15731-c016-4c56-925d-40d235405b0f"), " Comunidad Valenciana", "benaguacil" },
                    { new Guid("52374818-a511-489a-b266-b94732ce8b8f"), " Comunidad Valenciana", "benavites" },
                    { new Guid("3fc6f074-8839-47ff-a4fb-93ae78bd7514"), " Comunidad Valenciana", "benegida" },
                    { new Guid("3e84ca30-8778-4db4-847d-e24b0710392b"), " Comunidad Valenciana", "benetúser" },
                    { new Guid("a1fa541a-1c15-463c-b13b-8aaa10494dc8"), " Comunidad Valenciana", "beniarjó" },
                    { new Guid("8c8dcbd6-94a6-493c-94c4-c5ad93abb700"), " Comunidad Valenciana", "beniatjar" },
                    { new Guid("40b1b872-3539-40a5-bfc9-6167e50a148f"), " Comunidad Valenciana", "benicolet" },
                    { new Guid("1cc39fd3-c8ee-46aa-87b3-c0fd1f3b154e"), " Comunidad Valenciana", "benicull" },
                    { new Guid("7b8e8250-e236-4aeb-8783-06d5c14485fc"), " Comunidad Valenciana", "benifairó de la valldigna" },
                    { new Guid("009ae27c-eeba-4a7c-8241-04aafc5980b4"), " Comunidad Valenciana", "benifairó de los valles" },
                    { new Guid("43678739-7454-4e2c-ba88-7b4ba9ec053b"), " Comunidad Valenciana", "benifayó" },
                    { new Guid("0fe17274-ad68-4945-8fb9-8fbcf514b8cf"), " Comunidad Valenciana", "beniflá" },
                    { new Guid("82ac4a12-782b-45e2-b236-51ac92c5689c"), " Comunidad Valenciana", "benigánim" },
                    { new Guid("ae6feeba-293d-48a5-afe3-84b31afa0a19"), " Comunidad Valenciana", "almoines" },
                    { new Guid("ed340c34-6285-4faf-9f14-66f539d50f27"), " Comunidad Valenciana", "almiserat" },
                    { new Guid("6c259f9b-9f27-480d-9af5-f1d4e9d5abda"), " Comunidad Valenciana", "almácera" },
                    { new Guid("1f2b0bfb-2808-4d42-ab69-c37bb1c8ef54"), " Comunidad Valenciana", "alginet" },
                    { new Guid("ef6c18d5-9271-4ca2-97f1-1f99038e1d0a"), " Comunidad Valenciana", "valencia" },
                    { new Guid("ef9c2b13-0421-4643-a67e-e62804844640"), " Comunidad Valenciana", "ademuz" },
                    { new Guid("39451542-5bbe-458b-a7d7-3efa42298172"), " Comunidad Valenciana", "ador" },
                    { new Guid("c8f0d793-575d-4dbe-80f4-baa2457e3875"), " Comunidad Valenciana", "adzaneta de albaida" },
                    { new Guid("0179a51d-f88f-4015-915e-d62fd3a0224d"), " Comunidad Valenciana", "agullent" },
                    { new Guid("fbee1302-9161-47bc-911b-3b160acdc42f"), " Comunidad Valenciana", "alacuás" },
                    { new Guid("791bc3fc-9edd-406b-8e1e-f9cb09cb1a9d"), " Comunidad Valenciana", "albaida" },
                    { new Guid("34ebf472-6e43-44e0-b9e4-b9424148062f"), " Comunidad Valenciana", "albal" },
                    { new Guid("4cc415d3-6157-4a91-b15a-e073685f20e5"), " Comunidad Valenciana", "albalat de la ribera" },
                    { new Guid("54bca052-05a1-459e-9f1c-3a28b5b7e6da"), " Comunidad Valenciana", "albalat dels sorells" },
                    { new Guid("3ed070c7-1f8b-454f-bf99-b5868d1a0b69"), " Comunidad Valenciana", "albalat dels tarongers" },
                    { new Guid("9d6b86cf-0aef-4fdb-85f6-83b26600525e"), " Comunidad Valenciana", "alberique" },
                    { new Guid("ca1290bc-70b2-4358-9db2-fab341ff8b59"), " Comunidad Valenciana", "alborache" },
                    { new Guid("411b19b2-3bcc-44a4-a4e2-4335a7765741"), " Comunidad Valenciana", "alboraya" },
                    { new Guid("7f071ea8-d035-4a38-bfac-fd381450fa75"), " Comunidad Valenciana", "benimodo" },
                    { new Guid("16250800-4258-4999-ad58-aa2c44f2f8ec"), " Comunidad Valenciana", "albuixech" },
                    { new Guid("2dd131ea-aa81-4246-a4f8-7dbaa25f1f9d"), " Comunidad Valenciana", "alcántara de júcar" },
                    { new Guid("4b0ced01-4b90-4af6-84be-ab1e40489804"), " Comunidad Valenciana", "alcira" },
                    { new Guid("d9ac0e3f-c234-4827-8ec9-7900915904ae"), " Comunidad Valenciana", "alcublas" },
                    { new Guid("66caf3e4-fb6d-46f2-acf8-e037a30e5fe9"), " Comunidad Valenciana", "alcudia de crespins" },
                    { new Guid("105b7671-fee1-4843-830a-95d0e8d8e478"), " Comunidad Valenciana", "aldaya" },
                    { new Guid("975ed7ce-688a-47e4-b54c-4d06f558d278"), " Comunidad Valenciana", "alfafar" },
                    { new Guid("984bbc93-3f73-4f08-8928-af2b67fdce40"), " Comunidad Valenciana", "alfahuir" },
                    { new Guid("273757c9-8e5f-431e-82af-182d435761be"), " Comunidad Valenciana", "alfara de la baronía" },
                    { new Guid("dcfe9cd4-66e7-4bda-b506-708ec59816f4"), " Comunidad Valenciana", "alfara del patriarca" },
                    { new Guid("76ac8ff1-630f-40bc-b70c-fd439742c8ea"), " Comunidad Valenciana", "alfarp" },
                    { new Guid("7f4498c1-6105-4f52-bc2e-3fda62f5c227"), " Comunidad Valenciana", "alfarrasí" },
                    { new Guid("06ba071b-dce5-4877-8d62-e878f39fbec1"), " Comunidad Valenciana", "algar de palancia" },
                    { new Guid("b7bd5805-35bc-47c7-a687-f3c5f02f08b9"), " Comunidad Valenciana", "algemesí" },
                    { new Guid("68a0479e-c42f-4e91-927f-6fd7522fed98"), " Comunidad Valenciana", "algimia de alfara" },
                    { new Guid("99f50c01-77e6-44f8-a48d-174662a2fd7c"), " Comunidad Valenciana", "alcácer" },
                    { new Guid("9c006a86-6858-487b-8846-7cb9e2783325"), " Comunidad Valenciana", "gandía" },
                    { new Guid("27beb1be-22d9-4fe6-b19f-ea94287d8cbe"), " Comunidad Valenciana", "benimuslem" },
                    { new Guid("57606c04-38f9-496d-b757-0800df360c60"), " Comunidad Valenciana", "benirredrá" },
                    { new Guid("245143d3-fc04-44b9-b197-17c63e4568d1"), " Comunidad Valenciana", "chirivella" },
                    { new Guid("f0939e85-f8c1-4b59-97bc-66594c8eb35b"), " Comunidad Valenciana", "chiva" },
                    { new Guid("f4468327-e6fa-44f0-8f41-25b7d862a37d"), " Comunidad Valenciana", "chulilla" },
                    { new Guid("427d4445-101b-4619-a6f6-19ec6346f53f"), " Comunidad Valenciana", "cofrentes" },
                    { new Guid("fd8cfa02-9228-4bc8-86e9-84e18c2c129e"), " Comunidad Valenciana", "corbera" },
                    { new Guid("83707b67-2ee3-4d00-ae35-12c6bfe974f5"), " Comunidad Valenciana", "cortes de pallás" },
                    { new Guid("da1e70f7-79eb-4b0a-a471-28769fb153d7"), " Comunidad Valenciana", "cotes" },
                    { new Guid("1705dff6-5010-4004-8559-358b3f5bdec8"), " Comunidad Valenciana", "cuart de les valls" },
                    { new Guid("6a1b99cc-8da0-4798-bad4-553478949a04"), " Comunidad Valenciana", "cuart de poblet" },
                    { new Guid("5f155eff-7555-405a-9a4f-a9271c42b574"), " Comunidad Valenciana", "cuartell" },
                    { new Guid("6c0d43b3-085f-4465-9929-47b25bec8498"), " Comunidad Valenciana", "cuatretonda" },
                    { new Guid("c0437d07-89c8-476c-a517-f96d67ffc30e"), " Comunidad Valenciana", "cullera" },
                    { new Guid("6c11e225-0066-474a-a0ec-1e0b2e76794a"), " Comunidad Valenciana", "daimuz" },
                    { new Guid("6958ebaa-3072-4fd4-9a9d-806e0e5594c4"), " Comunidad Valenciana", "domeño" },
                    { new Guid("580f3568-f213-47e5-9fa5-8e543efb0b41"), " Comunidad Valenciana", "dos aguas" },
                    { new Guid("494fa2bc-f5ff-44da-98bf-ec2521a678a2"), " Comunidad Valenciana", "el puig" },
                    { new Guid("f26b79d4-4500-4328-b09b-555822650cc8"), " Comunidad Valenciana", "emperador" },
                    { new Guid("97a6006e-6cfc-4ace-bd55-f328efd7339c"), " Comunidad Valenciana", "enguera" },
                    { new Guid("53433edc-788d-4cbf-aa1f-380b35a90317"), " Comunidad Valenciana", "énova" },
                    { new Guid("9c35ab70-d6cb-4e75-867d-183b2b381920"), " Comunidad Valenciana", "estivella" },
                    { new Guid("efb5553b-e272-4d25-b8ef-95f3f53b6e17"), " Comunidad Valenciana", "estubeny" },
                    { new Guid("f57540b9-84af-4344-abf0-f6ba06836c5f"), " Comunidad Valenciana", "faura" },
                    { new Guid("eb57d985-6bd8-4428-96c7-93cf56e8df7f"), " Comunidad Valenciana", "favareta" },
                    { new Guid("681e1e70-ce38-42fd-9ae5-a0ede6f512b9"), " Comunidad Valenciana", "fontanares" },
                    { new Guid("719416a8-47f0-4f31-a2b6-f53aa1661366"), " Comunidad Valenciana", "fortaleny" },
                    { new Guid("68b90d73-f6b8-4b21-9d6c-1ee385bd4df3"), " Comunidad Valenciana", "foyos" },
                    { new Guid("1edbbdc7-8ecb-4ec9-9fce-697221092adc"), " Comunidad Valenciana", "fuente encarroz" },
                    { new Guid("32b6a538-5eb6-4df8-a08c-a068dc99bfaf"), " Comunidad Valenciana", "yátova" },
                    { new Guid("2e8121aa-1564-44a6-b989-5ba782d7188e"), " Comunidad Valenciana", "fuenterrobles" },
                    { new Guid("70090a72-76e6-49bc-a0a5-1651b6668acb"), " Comunidad Valenciana", "cheste" },
                    { new Guid("30bd26e1-74ea-4d25-835a-7d053da28856"), " Comunidad Valenciana", "chera" },
                    { new Guid("d52cd3a4-00fc-43f8-b436-fc29f6df73ae"), " Comunidad Valenciana", "chelva" },
                    { new Guid("fbb2ed60-e633-442d-878f-337d6d34f177"), " Comunidad Valenciana", "chella" },
                    { new Guid("354f03a3-baf0-4dc4-bcce-7195b805c6df"), " Comunidad Valenciana", "benisanó" },
                    { new Guid("ec45fc01-d9c5-4f48-8d85-036fea5c3b61"), " Comunidad Valenciana", "benisoda" },
                    { new Guid("35fe89c0-02f1-48c3-93a9-fb68b2428c5b"), " Comunidad Valenciana", "benisuera" },
                    { new Guid("424fb2a5-418a-46f1-aff8-ca37ea3a3a17"), " Comunidad Valenciana", "bétera" },
                    { new Guid("7bcec92e-0673-4dc7-846b-bebd090e30df"), " Comunidad Valenciana", "bicorp" },
                    { new Guid("edcd39aa-1376-41c9-b064-6956fc06d99d"), " Comunidad Valenciana", "bocairente" },
                    { new Guid("4a4fa7d1-5186-497a-8b14-2a88b72fa7c4"), " Comunidad Valenciana", "bolbaite" },
                    { new Guid("3c362f94-e358-45f8-8c68-d091094ba823"), " Comunidad Valenciana", "bonrepós y mirambell" },
                    { new Guid("781b1cd8-fd8a-4196-80ca-4e027f62cede"), " Comunidad Valenciana", "bufali" },
                    { new Guid("0ab7e7ad-d089-4cb7-afee-ae83e4b7ae9c"), " Comunidad Valenciana", "bugarra" },
                    { new Guid("28ac11ee-5ae1-42c9-8650-ec6bb547a0e0"), " Comunidad Valenciana", "buñol" },
                    { new Guid("100bf7ce-9d9f-42dc-913a-7cd4269dda74"), " Comunidad Valenciana", "burjasot" },
                    { new Guid("903c0f22-7065-4017-abca-ac653b95d986"), " Comunidad Valenciana", "calles" },
                    { new Guid("0845b03e-2744-4766-bca7-fa072715ab57"), " Comunidad Valenciana", "camporrobles" },
                    { new Guid("a8b7e4bb-361b-4fec-b0ca-f7a03d84236a"), " Comunidad Valenciana", "beniparrell" },
                    { new Guid("a2ece2fc-baf3-433b-95de-4912c6498ae5"), " Comunidad Valenciana", "canals" },
                    { new Guid("e2413215-0fd2-4cd0-8485-b4ff0111c80c"), " Comunidad Valenciana", "carcagente" },
                    { new Guid("500ce6cf-9d86-4502-a932-c265f1caae05"), " Comunidad Valenciana", "cárcer" },
                    { new Guid("ec3747f5-716a-4dc9-8535-f6bed43df856"), " Comunidad Valenciana", "carlet" },
                    { new Guid("0fb92c02-3e21-4900-838d-355eb17cecf0"), " Comunidad Valenciana", "carrícola" },
                    { new Guid("ce876221-89d1-4dc7-9f8b-427ed87aded5"), " Comunidad Valenciana", "casas altas" },
                    { new Guid("93c643d7-2a48-48f2-9b2a-9417fe75d71d"), " Comunidad Valenciana", "casas bajas" },
                    { new Guid("3bc4a148-d207-40e4-b55e-1e38bf6cb87b"), " Comunidad Valenciana", "casinos" },
                    { new Guid("96687198-5cd9-4cc5-a972-d91276442290"), " Comunidad Valenciana", "castellón de rugat" },
                    { new Guid("6e544cfc-9c4b-439a-b4b6-bb2a74dd62d0"), " Comunidad Valenciana", "castellonet" },
                    { new Guid("ef862563-a286-49aa-9f16-19a3810749e6"), " Comunidad Valenciana", "castielfabib" },
                    { new Guid("537342e0-3a47-42ce-8352-a838d3dfe0ed"), " Comunidad Valenciana", "catadau" },
                    { new Guid("f5bd89b2-f4cb-492c-8ea3-697c985b5bc3"), " Comunidad Valenciana", "catarroja" },
                    { new Guid("7eff3718-309f-4f25-906e-1d473ae37f1e"), " Comunidad Valenciana", "caudete de las fuentes" },
                    { new Guid("34971ece-6135-4c9f-88e5-90b2a878d941"), " Comunidad Valenciana", "cerdá" },
                    { new Guid("465277cd-7417-46f1-892f-18f81068f719"), " Comunidad Valenciana", "canet de berenguer" },
                    { new Guid("9bbbed71-e392-4737-bcb2-513e4090f364"), " Comunidad Valenciana", "zarra" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("113a2bc0-78e9-4699-bf5c-db2a14b3e651"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("1b861525-098a-4acb-ad83-f3a2572cea09"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("5264fa44-a6a4-4cb7-8c22-772af147a91b"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("620f0961-04aa-4ac7-9882-4372b329eca7"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("6f2edd78-9233-43fd-92a8-b3d106b8fcc9"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("8b3293b9-991a-4d2a-991a-1009af56f085"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("b244e7fe-db00-4191-bffc-b8aab5e0c930"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("cb855976-d21d-42f6-92e7-d0c988b915b1"));

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: new Guid("d48716b4-def8-412a-8c9f-6df2f82fad7b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("009ae27c-eeba-4a7c-8241-04aafc5980b4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("01324847-fa45-4bb1-ab26-c678d9af2e58"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0179a51d-f88f-4015-915e-d62fd3a0224d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0328d588-2f62-4a4b-8e2b-f0d1149e4c7a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("068c3ef6-dfaf-41b2-8ce8-8eafb43e95e0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("06ba071b-dce5-4877-8d62-e878f39fbec1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("076072f5-2db3-41db-b428-6e568130478a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0845b03e-2744-4766-bca7-fa072715ab57"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0ab7e7ad-d089-4cb7-afee-ae83e4b7ae9c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0b4b54fc-f83d-43b0-8355-447bbb6a4726"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0ed5ff46-d70c-403f-81b2-a84fb4be7190"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0fb92c02-3e21-4900-838d-355eb17cecf0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0fe17274-ad68-4945-8fb9-8fbcf514b8cf"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("100bf7ce-9d9f-42dc-913a-7cd4269dda74"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("105570c6-20fd-43b4-8ff1-bf19c5dfec60"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("105b7671-fee1-4843-830a-95d0e8d8e478"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("13fa07f7-fab8-4067-a52b-3d72a4b65060"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("144f51a7-7efb-4441-bff2-66e6a3de1417"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("155181c1-e7a8-4250-bd2d-f84e105ee1ca"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("15607528-1f10-47af-b3ed-22eb5942ede2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("15b680c9-7215-4107-98d4-7d809bf3a9c2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("16250800-4258-4999-ad58-aa2c44f2f8ec"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1705dff6-5010-4004-8559-358b3f5bdec8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1c1776ec-b828-4bad-baf6-f942c1107ef8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1cc39fd3-c8ee-46aa-87b3-c0fd1f3b154e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1d6c2d03-5345-4d63-846a-0ad055f813cd"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1d876f35-f321-49ad-9aab-297e6346ff94"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1edbbdc7-8ecb-4ec9-9fce-697221092adc"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1edec53c-f167-413b-83a7-96d21cf83e59"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1f2b0bfb-2808-4d42-ab69-c37bb1c8ef54"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("22030132-4c62-4250-8d65-6d85e5ca4ad1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("22c9f0da-dcaa-400b-af65-834c7df99d60"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("245143d3-fc04-44b9-b197-17c63e4568d1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("273757c9-8e5f-431e-82af-182d435761be"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("27beb1be-22d9-4fe6-b19f-ea94287d8cbe"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("28ac11ee-5ae1-42c9-8650-ec6bb547a0e0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2a3fd21d-5482-4f14-b71d-37c54c2dccae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2b898b7e-2a8a-4eab-912e-364062c46bae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2bc46324-c059-4468-a00e-f56ed0d94c3f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2c05a8a8-418b-44ae-9fdb-8a261b73c3b4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2c76f35b-c87a-47cf-b83a-79594c95c0ae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2dabf263-0105-41ca-ac86-d83c35a2ebe4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2dd131ea-aa81-4246-a4f8-7dbaa25f1f9d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2e8121aa-1564-44a6-b989-5ba782d7188e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2ea54269-9476-43be-a067-05e65ef22a5d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2fbaebda-d34e-43f8-8300-87d65139beea"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("2ff326f5-1f81-49d0-888a-b459d6946879"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("30bd26e1-74ea-4d25-835a-7d053da28856"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("32b6a538-5eb6-4df8-a08c-a068dc99bfaf"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("345a84b6-30a6-4d92-8733-110459e86ef2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("34971ece-6135-4c9f-88e5-90b2a878d941"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("34ebf472-6e43-44e0-b9e4-b9424148062f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("354f03a3-baf0-4dc4-bcce-7195b805c6df"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("35fe89c0-02f1-48c3-93a9-fb68b2428c5b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("37395cd3-a350-487b-86f3-0993df3f8aad"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("37ce3498-fd5a-481d-9bbc-ac3845a37137"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3885dca2-7fb8-4f54-ba33-f5ca46cfb75b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("39451542-5bbe-458b-a7d7-3efa42298172"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("39e3c4fd-6060-492f-8212-543228a0a0d9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3a87f18c-0cf7-4c29-91b8-299f02c97202"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3bc4a148-d207-40e4-b55e-1e38bf6cb87b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3c362f94-e358-45f8-8c68-d091094ba823"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3e84ca30-8778-4db4-847d-e24b0710392b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3ed070c7-1f8b-454f-bf99-b5868d1a0b69"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3fc6f074-8839-47ff-a4fb-93ae78bd7514"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("40030518-f8d4-4039-891b-9a1b9c28d9ee"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("40b1b872-3539-40a5-bfc9-6167e50a148f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("411b19b2-3bcc-44a4-a4e2-4335a7765741"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4164cd95-0c9f-4ba3-a8fe-7659b6864c5a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("41bef719-940c-44a7-95e4-c24b0bc06b06"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("424fb2a5-418a-46f1-aff8-ca37ea3a3a17"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("427d4445-101b-4619-a6f6-19ec6346f53f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("43678739-7454-4e2c-ba88-7b4ba9ec053b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4399f130-d478-40dc-8472-663882661b49"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("43b31003-4633-495c-8331-c83834959e1f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("44cc929b-9494-4249-9a52-154042c1b348"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("44f6d13e-0b12-4e1b-859f-2c15f4d1438c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("465277cd-7417-46f1-892f-18f81068f719"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4755899f-dd37-4064-9ac7-1a1501a0b370"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("47e4ac16-031a-403b-9945-78c9af0345fd"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("48635b15-e51d-4a53-b3d2-5e37cef8714c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("49067672-052c-48b3-8e64-913cd6803c66"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("494fa2bc-f5ff-44da-98bf-ec2521a678a2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("499ee244-5105-4f59-a2b6-449760bb9543"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("49f27a9e-a146-457f-a2a2-7c8046c518de"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4a4fa7d1-5186-497a-8b14-2a88b72fa7c4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4a978b5c-9c88-4b1c-92fa-ee27f68af818"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4b0ced01-4b90-4af6-84be-ab1e40489804"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4c245ffd-a900-4586-8d05-535ae6b189cc"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4cc415d3-6157-4a91-b15a-e073685f20e5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4cff2a08-891e-4b57-9282-aed4c8af2102"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("500ce6cf-9d86-4502-a932-c265f1caae05"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("510248ab-797d-4e18-bb20-ad78aa900553"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("51d93462-c909-40a1-8e7d-ea621b668f15"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("52374818-a511-489a-b266-b94732ce8b8f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("52ad3fd1-8e21-4677-8a7e-0951c9365f7d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("52f16894-faad-4917-8613-d27715291315"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5339a698-9487-4cda-b32b-fe4ecf19a0c8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("53433edc-788d-4cbf-aa1f-380b35a90317"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("537342e0-3a47-42ce-8352-a838d3dfe0ed"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("541d41f2-1d48-4d59-96a4-86b959a4a034"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5470485a-2135-47a7-b8c1-272d728c2d29"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("54aaf3de-87c2-4b08-b1fa-56555aa75b38"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("54bca052-05a1-459e-9f1c-3a28b5b7e6da"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5687d155-6613-40c1-bb8d-d65e767860b9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("571e7e3d-5dfd-4ec5-aa90-b709f05d3d6a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("575e0992-6bcf-41b9-b3ef-0b3278da44a2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("57606c04-38f9-496d-b757-0800df360c60"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("580f3568-f213-47e5-9fa5-8e543efb0b41"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("59f1d4e8-0c23-497e-b51c-fb2b805c0100"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5abcb3c3-dbd4-47ae-b165-559ebc74067d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5ddb3184-0798-4372-a192-6853fe7b0387"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5f155eff-7555-405a-9a4f-a9271c42b574"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("66caf3e4-fb6d-46f2-acf8-e037a30e5fe9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("67c042e6-11fc-4743-934f-44e9e8dd858e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("681e1e70-ce38-42fd-9ae5-a0ede6f512b9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("68a0479e-c42f-4e91-927f-6fd7522fed98"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("68b90d73-f6b8-4b21-9d6c-1ee385bd4df3"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6958ebaa-3072-4fd4-9a9d-806e0e5594c4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6a1b99cc-8da0-4798-bad4-553478949a04"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6a1f9d48-c7cd-4f26-9bea-5f91759b30e6"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6b6fc680-a1a5-40ed-99f9-3b07776b8403"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6bdb78f9-4851-4d62-aef0-110d8ab60de2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6c0d43b3-085f-4465-9929-47b25bec8498"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6c11e225-0066-474a-a0ec-1e0b2e76794a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6c259f9b-9f27-480d-9af5-f1d4e9d5abda"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6e1b601d-5836-4832-8427-ffa5d6895943"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6e544cfc-9c4b-439a-b4b6-bb2a74dd62d0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6f828e0c-75ca-4062-8fac-b559ded2f125"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6fc772af-baf9-44da-b58c-554f3b3b3186"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("70090a72-76e6-49bc-a0a5-1651b6668acb"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("719416a8-47f0-4f31-a2b6-f53aa1661366"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("72f85452-a015-4c3c-83fc-bf07116b8ac0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7369aaac-a350-4413-a27c-5b03054f917c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("741f6ef5-c6a4-4bbf-b744-f65b039cc40d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("754f43bb-a340-4ecc-9f6d-69624045fa2d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("76ac8ff1-630f-40bc-b70c-fd439742c8ea"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("781b1cd8-fd8a-4196-80ca-4e027f62cede"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("791bc3fc-9edd-406b-8e1e-f9cb09cb1a9d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7a668df6-bdba-4ddb-83c0-7f26ea01986b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7b8e8250-e236-4aeb-8783-06d5c14485fc"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7bcec92e-0673-4dc7-846b-bebd090e30df"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7c693936-d090-4d62-acb1-0955c9f575d1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7e2e6fd3-3fe9-411d-abd4-bc50916d1ecd"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7eff3718-309f-4f25-906e-1d473ae37f1e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7f071ea8-d035-4a38-bfac-fd381450fa75"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7f4498c1-6105-4f52-bc2e-3fda62f5c227"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7f814d62-4b46-4f66-a7d4-42f53d372d94"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("805d8131-dbb6-4ebc-bde0-f7a962555187"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("82a2ee7d-0489-4129-9032-aafbf7645f46"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("82ac4a12-782b-45e2-b236-51ac92c5689c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("83707b67-2ee3-4d00-ae35-12c6bfe974f5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("8464183b-dfec-44ad-8ed3-2954ddd01530"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("84b44b34-c986-4bfe-99d7-bf7280c2d50b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("850c7ca0-6d48-4a3a-9460-fb7fc1fcfc27"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("8c8dcbd6-94a6-493c-94c4-c5ad93abb700"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("8f8e2329-1867-4858-a5a0-30be865ae636"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("903c0f22-7065-4017-abca-ac653b95d986"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("91098712-2877-4771-9239-bf52ced81af2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("93c643d7-2a48-48f2-9b2a-9417fe75d71d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("942a987b-2875-42ac-8bb5-cf37ab71db5d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("94fcc6f2-55f1-4d56-8d44-f16ccc4dcbf7"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("955828bb-e864-4504-b163-3ffdf16a79d8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9563d586-8ad0-47af-a2a2-cbe45db23333"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("96687198-5cd9-4cc5-a972-d91276442290"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("96e24080-3394-40b2-96bc-2b9910563c14"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("975ed7ce-688a-47e4-b54c-4d06f558d278"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("97852ef0-8c30-4b24-b5b1-737f44ef751c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("97a6006e-6cfc-4ace-bd55-f328efd7339c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("97e7938d-d8c1-4eab-9675-82f5d0c90c45"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("981b4475-12af-4c33-8365-1bcba5973145"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("984bbc93-3f73-4f08-8928-af2b67fdce40"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("98ba6fa3-d109-4b5e-85b6-c288902e81ef"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("99f50c01-77e6-44f8-a48d-174662a2fd7c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9acec518-dcd4-4e19-ba24-8aabab4bf1d5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9b3a1cba-a066-4f1a-a711-bf0794645e3a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9bbbed71-e392-4737-bcb2-513e4090f364"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9bf15731-c016-4c56-925d-40d235405b0f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9c006a86-6858-487b-8846-7cb9e2783325"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9c35ab70-d6cb-4e75-867d-183b2b381920"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9d6b86cf-0aef-4fdb-85f6-83b26600525e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9de5516f-9500-4c57-a616-e8ee7213fa19"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9dfecc53-d417-4f39-9598-e4ed4fd51400"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9e8f11ac-cd0c-4245-9ce8-bf6e28548e19"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a1fa541a-1c15-463c-b13b-8aaa10494dc8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a2ece2fc-baf3-433b-95de-4912c6498ae5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a3a5c73b-d048-40a1-8efd-04cdb3e9552e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a8b7e4bb-361b-4fec-b0ca-f7a03d84236a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a97a08e2-41b3-40c2-8362-07e3a330830e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a99bff99-49d5-452a-b870-8381cbaf349e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("aab41ec8-6068-499d-9a65-aa635c4dc027"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ad467f30-775b-45ba-a24a-c925b28fbf29"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ae6feeba-293d-48a5-afe3-84b31afa0a19"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b089f329-4b2f-43cf-8295-49dc30e81fc4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b0e135e0-999a-4a85-8572-ad8515c00c68"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b0e3c018-ff2c-4916-913e-34803b5be7d1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b1f9ba50-1ea4-4daa-83e6-d0b73850619c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b247da68-700b-481c-b880-3b5c5a1f2729"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b45247ce-f5d2-44d3-94d3-6c93ade6d66a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b67f783a-639b-4a13-a750-eb029c739759"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b78fda29-84ca-4cf3-a5cf-4fa54cb1d38d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b7bd5805-35bc-47c7-a687-f3c5f02f08b9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b956bf93-7e42-4002-bf7f-b182b23672b0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bac8e02b-3507-473c-8d11-6c75190daa1c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bc3df222-99e1-4894-a9d0-a9bbd825c55c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bfb02abf-0dd5-412d-b969-b8d40382ef34"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bfb69b27-937b-4faf-9aeb-13c0e30b0f42"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c0437d07-89c8-476c-a517-f96d67ffc30e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c167b944-fda3-4a8c-a2dc-f5fa595bb7c9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c3f2f59a-7d0b-4ccd-b85c-00823d3bb0ae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c8f0d793-575d-4dbe-80f4-baa2457e3875"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ca1290bc-70b2-4358-9db2-fab341ff8b59"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ce641785-b363-4927-93a3-f1aec39aeb54"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ce876221-89d1-4dc7-9f8b-427ed87aded5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ceb3a92a-9c71-4c68-93b8-f7e4e9f608d1"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ceb64fb7-476f-408c-b678-8f36baa9a277"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("cfdaf29a-ba4d-4c90-b624-3dffa6e2bd90"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d1399795-5a9a-4ae9-9e30-bed2ddaf05a5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d214c971-aa04-4041-9a7a-087dc1249aea"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d271e7ce-6c90-4010-a594-b9bedb74cbbb"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d31b5a93-791c-44bf-939a-ef4711920a58"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d52cd3a4-00fc-43f8-b436-fc29f6df73ae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d75e137e-b24d-4534-bf03-7f97b4ce2d41"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d7dad211-13ed-4b32-aebf-7060f81040e4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0e3f-c234-4827-8ec9-7900915904ae"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d9aff0f3-35bb-46f5-a028-db7c44b061fe"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("da1e70f7-79eb-4b0a-a471-28769fb153d7"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("dc86168e-861a-46dd-9b34-2eb7762a2fee"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("dcfe9cd4-66e7-4bda-b506-708ec59816f4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("dd5f4e23-a65a-4892-a89a-8fd603e701d6"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ddf5741d-bb27-4375-9193-480217177f5f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("df1dcb3a-4e0e-4202-bc4b-40a669a5bd19"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e2413215-0fd2-4cd0-8485-b4ff0111c80c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e324d66e-5c70-4526-8e24-bd8e1cf4f647"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e3f33976-e9d1-414d-aa31-99e11ab64660"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e408da6f-6f03-4a48-9979-87616992ce45"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e498984e-cbb0-4c68-9a05-ccc29a62b779"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ea71bc06-fc94-4297-b5e1-226e0f23f0e5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("eb57d985-6bd8-4428-96c7-93cf56e8df7f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ec3747f5-716a-4dc9-8535-f6bed43df856"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ec45fc01-d9c5-4f48-8d85-036fea5c3b61"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ed340c34-6285-4faf-9f14-66f539d50f27"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ed7d0125-7bdf-4767-80e2-2abd0bdd0370"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("edcd39aa-1376-41c9-b064-6956fc06d99d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ef6c18d5-9271-4ca2-97f1-1f99038e1d0a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ef8538b9-4ff1-4640-b63f-42b5d9334925"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ef862563-a286-49aa-9f16-19a3810749e6"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ef9c2b13-0421-4643-a67e-e62804844640"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("efb5553b-e272-4d25-b8ef-95f3f53b6e17"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f0939e85-f8c1-4b59-97bc-66594c8eb35b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f0e6eedd-6354-4654-9bc7-f84372bf7587"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f1bf088e-2834-4125-a433-b25dc11bb875"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f26b79d4-4500-4328-b09b-555822650cc8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f37d0b59-a85c-4762-a54c-abcd159865bc"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f4468327-e6fa-44f0-8f41-25b7d862a37d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f4f234d2-27b9-41dd-93a3-788bf2727ba8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f57540b9-84af-4344-abf0-f6ba06836c5f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f5bd89b2-f4cb-492c-8ea3-697c985b5bc3"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f7873a04-3e9b-4eed-9c3e-f64bd9de5199"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f7e17ef8-9012-4080-a48a-7361e74f284b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f8f57c8b-cc29-4618-941d-704a9773ed52"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f9bf7790-4aba-4c88-977e-43d1653c47f2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("fafd2b1a-0e02-40c9-84ab-cc42e3472ce0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("fbb2ed60-e633-442d-878f-337d6d34f177"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("fbee1302-9161-47bc-911b-3b160acdc42f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("fd8cfa02-9228-4bc8-86e9-84e18c2c129e"));
        }
    }
}
