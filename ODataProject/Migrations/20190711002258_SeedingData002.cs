using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ODataProject.Migrations
{
    public partial class SeedingData002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("04f4a022-04c9-42a4-973a-755d0c0b767d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("244ddff1-22b2-414c-800a-621543d5794d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2f428cd4-4799-409f-98d2-256e8e669138"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2f8053cb-e6fb-4400-a575-79136994f942"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3380e0a1-1d3b-4dc8-a429-9ad5471c8ba0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4a424406-82b3-49d1-8c18-e4effb717c9a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("582b4746-3ad2-42c4-b408-de1692e1cc2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5baca2fc-f61e-43b0-b934-27c39d5f4642"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5d8979de-44f0-41f5-8dc1-e3aad107f682"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6d2eefec-d6dd-453c-b100-92668496cac8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("77739b69-cabd-4275-9bbc-d770add33272"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("97dedf40-0ea1-46b1-95ca-51d1c923262a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a3d563cd-a358-408c-aa73-238917489bae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d659adc7-2b2e-41d9-b783-f86e27ca2540"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("dbda2ce8-5611-4273-a64f-be6d6c4c1f10"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e2b702bb-5ce4-4c32-9d47-200ea3a6c0d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e3fc4cd8-d773-48d9-85d4-f2f8c93cc345"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e742406e-6e5f-495f-b375-587234b3302f"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3aea756e-5203-4811-b290-746d392ade83"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"));

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "City", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), "Mexicali", "UABC - Mexicali", "Baja California" },
                    { new Guid("a5c63668-6dd7-421a-98f7-795862054eea"), "Mexicali", "TECNOLOGICO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("69636bb0-c211-4e83-bbed-d6b7682bd6c9"), "Ensenada", "UABC - Ensenada", "Baja California" },
                    { new Guid("ed5331c6-3cef-46b3-9b34-c23a19dccc80"), "Mexicali", "XOCHICALCO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("4172f41d-f7a3-4db9-bdb3-4b7709a31831"), "Mexicali", "CETYS UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("c80f1741-b017-4ff7-87f6-d48c8f326fdc"), "Tijuana", "CETYS UNIVERSIDAD - Tijuana", "Baja California" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "SchoolId", "Score" },
                values: new object[,]
                {
                    { new Guid("71a8ab9e-d7ca-4d8e-9a2d-dd5e573ac853"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("098efda6-b3da-42bb-bc44-f6c159ca99ae"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("98bad47e-5f0a-4267-9e54-ab5f9ff36428"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("ad768339-8a0d-469f-b3e7-4097b89138d6"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("01b355bc-ad47-4d65-a5bb-736a18168534"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("e8d8fe1e-1c32-4cc0-8eb6-84433d7b7a62"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("4ad160da-564d-4f49-8c21-d9fc6343f9df"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("27eb8880-2c6c-48fa-9c83-aa77b478884b"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("b7768a0e-d84a-4b15-8a32-061ded7c003e"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("d2f45bc7-db47-4744-aed2-edfc5f0a4ab5"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("49e7076e-b9ac-4c5f-b7c0-5e7d0f813814"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("19878e3d-94d9-4a2e-a483-344e5b09e847"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("62406b6a-746a-47c5-a9e4-cc853d55fe0d"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("2b3f393b-b68a-4ded-97c4-036998612fdc"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("0e09ccda-ee21-4be8-9762-a4b46c535621"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("9434ff19-d8a4-48df-9d8a-8bff8425ff7a"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("1eced42d-4322-400c-a10b-a65f029e56d7"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("a1bb89de-af33-404b-9ab7-758aa0e4b571"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("31d35fe0-630d-41f7-9dd8-86c97fd40ee9"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("8d5d42d4-ce00-4f7d-9414-632aa38d86f4"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("5b95cc0b-0c33-4437-a2d6-774b214c0bd0"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("e65539a4-68cc-48ea-be47-07f8340c3097"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("4ee98f82-6535-4207-a56a-f80b491782eb"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("e1de7ce1-1834-469f-9d9d-59fa0a11a7d7"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("013e31e5-b97a-4147-847e-7d22941e62f8"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("15b01b1d-b026-4718-ac70-8cdae5974b42"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("6b57356f-7c0d-483d-ae3f-23e8e0d3efc2"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("4a90bfd5-1763-42a9-b776-5b8b2937a2ab"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("d7804ff3-d242-4593-a424-016cb779b67a"), "Jose Osuna", new Guid("c80f1741-b017-4ff7-87f6-d48c8f326fdc"), 88 },
                    { new Guid("83340d01-954d-44a6-b6ff-a399676c0ec1"), "Omar Reyes", new Guid("4172f41d-f7a3-4db9-bdb3-4b7709a31831"), 67 },
                    { new Guid("3012ca8a-dd46-4e80-abe1-e2fb083f653b"), "Cristina Gutierrez", new Guid("4172f41d-f7a3-4db9-bdb3-4b7709a31831"), 96 },
                    { new Guid("69b2368b-0387-4b47-a93a-2ef14043d2ca"), "Guadalupe Ortiz", new Guid("4172f41d-f7a3-4db9-bdb3-4b7709a31831"), 70 },
                    { new Guid("421e86c5-1781-45c3-93f7-3dd172e22f6f"), "Manuel Lopez", new Guid("ed5331c6-3cef-46b3-9b34-c23a19dccc80"), 80 },
                    { new Guid("7ba8e0b1-f626-432e-9ddd-3867c17756b9"), "Raul Farias", new Guid("ed5331c6-3cef-46b3-9b34-c23a19dccc80"), 86 },
                    { new Guid("32a64337-4a2f-4c7b-8c51-e57d4053699e"), "Santiago Ojeda", new Guid("ed5331c6-3cef-46b3-9b34-c23a19dccc80"), 90 },
                    { new Guid("60946ab3-0ecf-4e3c-bcd1-34d989fe12b5"), "Francisco Mendoza", new Guid("69636bb0-c211-4e83-bbed-d6b7682bd6c9"), 54 },
                    { new Guid("754823d0-6848-4ad5-909b-c3bd229617b2"), "Samanta Lopez", new Guid("69636bb0-c211-4e83-bbed-d6b7682bd6c9"), 75 },
                    { new Guid("78f4c612-58db-4893-b373-b1884571425d"), "Pedro Jimenez", new Guid("69636bb0-c211-4e83-bbed-d6b7682bd6c9"), 87 },
                    { new Guid("44e2df3b-ebbb-4a50-890e-02cb2ac2578e"), "Alberto Medina", new Guid("a5c63668-6dd7-421a-98f7-795862054eea"), 77 },
                    { new Guid("aaed901b-aee6-4da9-aab7-1f82cbd07339"), "Felipe Gonzalez", new Guid("a5c63668-6dd7-421a-98f7-795862054eea"), 92 },
                    { new Guid("65a349c1-0395-47f7-a272-53e99971304f"), "Saul Rodriguez", new Guid("a5c63668-6dd7-421a-98f7-795862054eea"), 95 },
                    { new Guid("425dc878-d283-4a71-b5ba-8c40a8a82819"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("29436514-e9d5-4477-b72f-22369927c456"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("98b1fe32-29fa-4d8c-84e6-91bb63b4370d"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("9901c235-5f88-4644-81ab-27b3b2ff9364"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("440aeec9-33ef-4866-a6af-9ec4b0cac22e"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("87b3d6c9-20f9-40d2-ad41-5502ad335671"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("c3d0d27b-14c3-42e6-b412-104138b41ad0"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("cfe6574d-989d-4ef9-b949-4c266715b912"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("4ef158e8-bd9c-415c-92bf-99495521bbe3"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("ad7a93e1-3602-4fe2-959d-2bb626cfb882"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("5aa18edd-5055-40c5-94dd-302068721b26"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("f168dc03-3842-4e14-a7ee-d32d0c5a87f3"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("717ebb7b-f24d-4b81-96cc-546fb0691117"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("0c1cd051-56f8-4afd-a2ed-b0b37b2ae3cb"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("2d9000c8-a723-4645-9adb-ac87c8e77f84"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("d41e5c7f-fb7b-4533-b8d0-bcb1f32c8e32"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("bf2354ff-2829-4fb6-9e15-93f1c8db8790"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("9fd013ad-6d06-49e7-bd4b-9a8de838c185"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("50d0ddfc-a996-4e6f-87f9-08873005b799"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("e1f7ec4f-df2f-4e43-8eb4-7e5dae6e8f8d"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("0277e8b7-ec32-4fc4-b017-e644a77f1b2c"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("587897bb-c675-4699-be71-b2f8a2796ca9"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("501d58de-528d-49cd-87db-e9b12d9da6bc"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("70a34efd-93d6-40f8-b84f-1712954cfd71"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("16da7ab2-17d8-4000-8965-2506bf0a931e"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("e078145d-5ce9-4ef8-96a0-ee42bd36c550"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("64b53884-59d1-41f7-80fb-ac0831281b76"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("13ca4336-39eb-4746-8eea-b1d2954a5986"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("6531918c-1553-45fd-86a5-ffe8ec014bae"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("9ec31dc0-60ca-425e-938b-acbad8e3df46"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("256fd748-ca30-48f8-90a5-d18346526d27"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("2242d119-a26d-4531-b640-45c97848dd0f"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("a3f038cf-a74c-4ce8-8a16-267263e6b748"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("68cbdc50-3d13-456d-b61a-919bea62fa12"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("3a2f4d0d-97f6-475d-9f1f-7e522d7a199f"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("b7035118-abff-4262-b5a6-8a2e1e44ef6b"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("6cf35254-a385-4457-96e4-ee6f10b9c306"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("c5219878-1c10-456d-aad3-ae89c6d22f20"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("e49ebdb3-a411-486c-8770-9d061a4a66e5"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("bb79b7a4-c00f-45f2-85b2-3e5efa8e60dd"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("ea3a0a8b-7399-4d63-8414-7dd9e7913909"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("40d093c5-b2bf-417c-8cc0-494dca63300a"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("11ab4b0a-b59f-4cb3-9280-df680e5072d4"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("67bd2bd5-2a92-4c2f-b067-730ed48d3720"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("d63d1007-293b-4ff9-8cc3-9c8a4d5214e6"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("91285bfc-f2ca-411c-9e44-e02d176868dc"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("314bd449-4ab2-42df-a661-b7314a779d24"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("aa71c5ef-4fc3-4744-94a2-f717d298b431"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("af9d3c50-bbd4-4cd8-97c4-f71a5a3fd302"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("a676aef6-6238-461d-87ee-be361ef3f9b4"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("5d700fac-f890-4880-ad4d-ae54301b842a"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("976ddae6-d479-4356-ae9a-6f005fbd0be0"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("00ed3edf-f828-47de-bbaf-9ef93b8720aa"), "Patricia Acosta", new Guid("c80f1741-b017-4ff7-87f6-d48c8f326fdc"), 87 },
                    { new Guid("5a47f162-d30c-4f9c-9f6c-c6c4a834f16c"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("133a177c-558d-413f-9b0e-0a9cb32e41b5"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("2beb4b83-3554-449f-9ffa-fb7f69874d7e"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("7dde5c5c-6b1e-4d48-9aff-2ee32cdc10e8"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("9ba6a968-b467-4cfa-ae7d-795cc31e75ca"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("6a71eabe-0d36-49b0-b74b-e04272bfdd81"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("7013b1fb-39f9-4051-abbf-b9319f5ff96f"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("0b963e83-82c9-455f-b6e1-ec15efd5a123"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("753d3adb-c3a5-4745-ae58-26901da322fa"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("b790ef25-a5b9-4c2b-bce6-d8b999e5a79c"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("8a419eed-440a-4cf2-92c5-6210ed1ba56a"), "Ricardo Beltran", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 89 },
                    { new Guid("f4565d0f-114b-4ba3-9594-3177f390ebc6"), "Claudia Rosales", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 85 },
                    { new Guid("7376c8ee-c5a8-42a2-bbfb-044831d0c30c"), "Jorge Apodaca", new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"), 100 },
                    { new Guid("594c387a-43f4-450b-bf05-0ef2e1436dfd"), "Alma Lopez", new Guid("c80f1741-b017-4ff7-87f6-d48c8f326fdc"), 94 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("00ed3edf-f828-47de-bbaf-9ef93b8720aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("013e31e5-b97a-4147-847e-7d22941e62f8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("01b355bc-ad47-4d65-a5bb-736a18168534"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("0277e8b7-ec32-4fc4-b017-e644a77f1b2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("098efda6-b3da-42bb-bc44-f6c159ca99ae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("0b963e83-82c9-455f-b6e1-ec15efd5a123"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("0c1cd051-56f8-4afd-a2ed-b0b37b2ae3cb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("0e09ccda-ee21-4be8-9762-a4b46c535621"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("11ab4b0a-b59f-4cb3-9280-df680e5072d4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("133a177c-558d-413f-9b0e-0a9cb32e41b5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("13ca4336-39eb-4746-8eea-b1d2954a5986"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("15b01b1d-b026-4718-ac70-8cdae5974b42"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("16da7ab2-17d8-4000-8965-2506bf0a931e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("19878e3d-94d9-4a2e-a483-344e5b09e847"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("1eced42d-4322-400c-a10b-a65f029e56d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2242d119-a26d-4531-b640-45c97848dd0f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("256fd748-ca30-48f8-90a5-d18346526d27"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("27eb8880-2c6c-48fa-9c83-aa77b478884b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("29436514-e9d5-4477-b72f-22369927c456"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2b3f393b-b68a-4ded-97c4-036998612fdc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2beb4b83-3554-449f-9ffa-fb7f69874d7e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2d9000c8-a723-4645-9adb-ac87c8e77f84"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3012ca8a-dd46-4e80-abe1-e2fb083f653b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("314bd449-4ab2-42df-a661-b7314a779d24"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("31d35fe0-630d-41f7-9dd8-86c97fd40ee9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("32a64337-4a2f-4c7b-8c51-e57d4053699e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3a2f4d0d-97f6-475d-9f1f-7e522d7a199f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("40d093c5-b2bf-417c-8cc0-494dca63300a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("421e86c5-1781-45c3-93f7-3dd172e22f6f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("425dc878-d283-4a71-b5ba-8c40a8a82819"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("440aeec9-33ef-4866-a6af-9ec4b0cac22e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("44e2df3b-ebbb-4a50-890e-02cb2ac2578e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("49e7076e-b9ac-4c5f-b7c0-5e7d0f813814"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4a90bfd5-1763-42a9-b776-5b8b2937a2ab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4ad160da-564d-4f49-8c21-d9fc6343f9df"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4ee98f82-6535-4207-a56a-f80b491782eb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4ef158e8-bd9c-415c-92bf-99495521bbe3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("501d58de-528d-49cd-87db-e9b12d9da6bc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("50d0ddfc-a996-4e6f-87f9-08873005b799"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("587897bb-c675-4699-be71-b2f8a2796ca9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("594c387a-43f4-450b-bf05-0ef2e1436dfd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5a47f162-d30c-4f9c-9f6c-c6c4a834f16c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5aa18edd-5055-40c5-94dd-302068721b26"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5b95cc0b-0c33-4437-a2d6-774b214c0bd0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5d700fac-f890-4880-ad4d-ae54301b842a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("60946ab3-0ecf-4e3c-bcd1-34d989fe12b5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("62406b6a-746a-47c5-a9e4-cc853d55fe0d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("64b53884-59d1-41f7-80fb-ac0831281b76"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6531918c-1553-45fd-86a5-ffe8ec014bae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("65a349c1-0395-47f7-a272-53e99971304f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("67bd2bd5-2a92-4c2f-b067-730ed48d3720"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("68cbdc50-3d13-456d-b61a-919bea62fa12"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("69b2368b-0387-4b47-a93a-2ef14043d2ca"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6a71eabe-0d36-49b0-b74b-e04272bfdd81"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6b57356f-7c0d-483d-ae3f-23e8e0d3efc2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6cf35254-a385-4457-96e4-ee6f10b9c306"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7013b1fb-39f9-4051-abbf-b9319f5ff96f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("70a34efd-93d6-40f8-b84f-1712954cfd71"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("717ebb7b-f24d-4b81-96cc-546fb0691117"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("71a8ab9e-d7ca-4d8e-9a2d-dd5e573ac853"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7376c8ee-c5a8-42a2-bbfb-044831d0c30c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("753d3adb-c3a5-4745-ae58-26901da322fa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("754823d0-6848-4ad5-909b-c3bd229617b2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("78f4c612-58db-4893-b373-b1884571425d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7ba8e0b1-f626-432e-9ddd-3867c17756b9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7dde5c5c-6b1e-4d48-9aff-2ee32cdc10e8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("83340d01-954d-44a6-b6ff-a399676c0ec1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("87b3d6c9-20f9-40d2-ad41-5502ad335671"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("8a419eed-440a-4cf2-92c5-6210ed1ba56a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("8d5d42d4-ce00-4f7d-9414-632aa38d86f4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("91285bfc-f2ca-411c-9e44-e02d176868dc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9434ff19-d8a4-48df-9d8a-8bff8425ff7a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("976ddae6-d479-4356-ae9a-6f005fbd0be0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("98b1fe32-29fa-4d8c-84e6-91bb63b4370d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("98bad47e-5f0a-4267-9e54-ab5f9ff36428"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9901c235-5f88-4644-81ab-27b3b2ff9364"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9ba6a968-b467-4cfa-ae7d-795cc31e75ca"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9ec31dc0-60ca-425e-938b-acbad8e3df46"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9fd013ad-6d06-49e7-bd4b-9a8de838c185"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a1bb89de-af33-404b-9ab7-758aa0e4b571"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a3f038cf-a74c-4ce8-8a16-267263e6b748"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a676aef6-6238-461d-87ee-be361ef3f9b4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("aa71c5ef-4fc3-4744-94a2-f717d298b431"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("aaed901b-aee6-4da9-aab7-1f82cbd07339"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("ad768339-8a0d-469f-b3e7-4097b89138d6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("ad7a93e1-3602-4fe2-959d-2bb626cfb882"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("af9d3c50-bbd4-4cd8-97c4-f71a5a3fd302"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b7035118-abff-4262-b5a6-8a2e1e44ef6b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b7768a0e-d84a-4b15-8a32-061ded7c003e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b790ef25-a5b9-4c2b-bce6-d8b999e5a79c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("bb79b7a4-c00f-45f2-85b2-3e5efa8e60dd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("bf2354ff-2829-4fb6-9e15-93f1c8db8790"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("c3d0d27b-14c3-42e6-b412-104138b41ad0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("c5219878-1c10-456d-aad3-ae89c6d22f20"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("cfe6574d-989d-4ef9-b949-4c266715b912"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d2f45bc7-db47-4744-aed2-edfc5f0a4ab5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d41e5c7f-fb7b-4533-b8d0-bcb1f32c8e32"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d63d1007-293b-4ff9-8cc3-9c8a4d5214e6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d7804ff3-d242-4593-a424-016cb779b67a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e078145d-5ce9-4ef8-96a0-ee42bd36c550"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e1de7ce1-1834-469f-9d9d-59fa0a11a7d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e1f7ec4f-df2f-4e43-8eb4-7e5dae6e8f8d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e49ebdb3-a411-486c-8770-9d061a4a66e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e65539a4-68cc-48ea-be47-07f8340c3097"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e8d8fe1e-1c32-4cc0-8eb6-84433d7b7a62"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("ea3a0a8b-7399-4d63-8414-7dd9e7913909"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("f168dc03-3842-4e14-a7ee-d32d0c5a87f3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("f4565d0f-114b-4ba3-9594-3177f390ebc6"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3d00f3af-30f2-48aa-9a45-07333d9ac9ea"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("4172f41d-f7a3-4db9-bdb3-4b7709a31831"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("69636bb0-c211-4e83-bbed-d6b7682bd6c9"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("a5c63668-6dd7-421a-98f7-795862054eea"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("c80f1741-b017-4ff7-87f6-d48c8f326fdc"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("ed5331c6-3cef-46b3-9b34-c23a19dccc80"));

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "City", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), "Mexicali", "UABC - Mexicali", "Baja California" },
                    { new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), "Mexicali", "TECNOLOGICO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), "Ensenada", "UABC - Ensenada", "Baja California" },
                    { new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), "Mexicali", "XOCHICALCO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("3aea756e-5203-4811-b290-746d392ade83"), "Mexicali", "CETYS UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), "Tijuana", "CETYS UNIVERSIDAD - Tijuana", "Baja California" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "SchoolId", "Score" },
                values: new object[,]
                {
                    { new Guid("dbda2ce8-5611-4273-a64f-be6d6c4c1f10"), "Jorge Apodaca", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 100 },
                    { new Guid("97dedf40-0ea1-46b1-95ca-51d1c923262a"), "Jose Osuna", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 88 },
                    { new Guid("e2b702bb-5ce4-4c32-9d47-200ea3a6c0d7"), "Omar Reyes", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 67 },
                    { new Guid("2f428cd4-4799-409f-98d2-256e8e669138"), "Cristina Gutierrez", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 96 },
                    { new Guid("4a424406-82b3-49d1-8c18-e4effb717c9a"), "Guadalupe Ortiz", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 70 },
                    { new Guid("3380e0a1-1d3b-4dc8-a429-9ad5471c8ba0"), "Manuel Lopez", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 80 },
                    { new Guid("5baca2fc-f61e-43b0-b934-27c39d5f4642"), "Raul Farias", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 86 },
                    { new Guid("582b4746-3ad2-42c4-b408-de1692e1cc2c"), "Santiago Ojeda", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 90 },
                    { new Guid("6d2eefec-d6dd-453c-b100-92668496cac8"), "Francisco Mendoza", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 54 },
                    { new Guid("e3fc4cd8-d773-48d9-85d4-f2f8c93cc345"), "Samanta Lopez", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 75 },
                    { new Guid("77739b69-cabd-4275-9bbc-d770add33272"), "Pedro Jimenez", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 87 },
                    { new Guid("e742406e-6e5f-495f-b375-587234b3302f"), "Alberto Medina", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 77 },
                    { new Guid("d659adc7-2b2e-41d9-b783-f86e27ca2540"), "Felipe Gonzalez", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 92 },
                    { new Guid("2f8053cb-e6fb-4400-a575-79136994f942"), "Saul Rodriguez", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 95 },
                    { new Guid("5d8979de-44f0-41f5-8dc1-e3aad107f682"), "Ricardo Beltran", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 89 },
                    { new Guid("04f4a022-04c9-42a4-973a-755d0c0b767d"), "Claudia Rosales", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 85 },
                    { new Guid("a3d563cd-a358-408c-aa73-238917489bae"), "Patricia Acosta", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 87 },
                    { new Guid("244ddff1-22b2-414c-800a-621543d5794d"), "Alma Lopez", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 94 }
                });
        }
    }
}
