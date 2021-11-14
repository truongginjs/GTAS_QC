using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QCService.Migrations
{
    public partial class ChangeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D01_QCTicket");

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("01deded7-8bb4-4c96-9c8d-c32bb80b0462"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("045e8638-b3e7-4080-8449-7c0d771b0484"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("069e37b1-f461-4719-a82e-3b598a808791"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("07e2a384-ab87-4665-91da-9468ecfde3a6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0afd7554-766d-4840-946c-410999bf02e4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0c0f1ecb-15ef-4af5-82d6-8fd762676801"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0d9c544c-0731-407f-ada7-5c44f4b76958"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("16105a5b-ede9-40ca-be3f-2f231788756b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("17ada600-8da8-4bff-90c6-ed79ab826464"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1a883053-243a-42de-8b6c-d171fc6d6f7b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1b39f44b-efdd-40d8-ba85-eda61cc9995c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1bcaf0a2-3f51-40f4-8ec2-7ee6f8e70dd0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1c72e192-0ea7-4783-8e22-b0bf16b42f33"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1c87db3c-eb53-4cd8-88d2-248eaebe478c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("20cee637-7118-477d-bdfa-74e3af01eb6f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("238d92d2-1c2d-4c12-9065-c6979717acec"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("26e28075-3e78-49cf-836a-95d1c00e98f4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("279cd72b-7890-4138-8784-32388b6c7707"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2e2f1f15-6e66-42e8-8b00-26359dd0e872"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("30586bf0-fd5e-4947-8f4d-e6a97c8f3f2e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("32a2d088-8b1d-4c6b-90d8-89c8bb2bed71"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3367affc-832b-4275-9edd-f2131f65e0cb"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("34b65be1-9b79-4ca6-958b-b87044b582d8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("34f723c7-195e-45c7-9fca-360126937eae"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("355ebafc-b42f-45c9-b2bd-814dd89f8007"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("35d6c6fc-9968-48ef-beb5-cb5d39323ef5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("36ce0a13-defd-44f8-a480-d4a3e3554657"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("37011093-8723-4a26-ae4e-14b01b5e1a05"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("38974d29-8c0d-4cd0-8bc1-c7183607022e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("38f9abe1-3f6e-4483-8a64-dc42ee4f41bc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("39d81a78-3318-4c85-a56a-3c2063ae8cf7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3a6d0624-c652-4f3d-b4c0-206a18284b0b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3b7258f8-5800-486b-9ec9-35b984127e41"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3c2f3646-bf8f-42d2-9346-73bd31ab2f8d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3caf8826-413b-4c1b-b62f-f1e0798b64d6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3ebd05f7-937e-4614-b42e-873fc8250835"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3fc17845-2a6c-4436-948e-18a48ef15f30"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("40f97108-5974-4fe0-8e33-4cec7eb77ce3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4333aa09-9046-450d-9f9a-fe40cc010917"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("43c5b47d-5646-4166-9e4a-3c9978562d87"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("45b81239-bd35-4d96-882a-3a3aa54aa01a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4952acc7-634f-4e50-9695-6a4c9d23a253"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4a09d734-727c-410e-bf6f-e5c2d99f869e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4a299ef7-24dd-4b20-af12-bf459169d8ab"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4a980e50-1b49-4a9d-ba5e-6cbf6fe95d18"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4b494719-2791-434f-9bd6-5f2c5bd47ca2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4c60c131-644e-4688-86cd-4a4574cc6423"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4cec5855-674b-4907-bbc2-f38fa0bc9471"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4e600f20-b0ba-4b90-b0af-688d14f9b532"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4f8f9c69-45bd-4194-b50b-3b4b276fa12c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4fa3cc0d-5ce2-4b49-b98e-af0d62388744"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("50402e19-ad5e-49c5-ba8d-a0fb37aed7d7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("504f14ee-848e-4eed-8408-4fc984a53c11"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("50946400-436d-4ab8-85bf-ac4af81d5b49"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("54001dc6-c2a2-4989-a3d8-df02f8792764"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("54b5629d-68a4-4f2b-82e7-e79a2dbf91fb"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("56aa3ea7-0af1-4667-994d-6599c7d13619"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("57fa98e9-029a-444b-8d6f-84fbb4df52b8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("58030543-9367-4afa-b766-e26fed54bdc3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("58cd94f2-c12b-4587-a44a-a466bff68ff7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5ae55e7e-de8e-4ed7-8648-306ff624a4fd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5d47fb20-91a5-4952-9b31-ebd7d9213e8a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5f180049-2ef3-4343-9348-44fc7134ddf5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("60ab6992-99c4-4bd7-ae2f-56d601c9676f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("61acf4e1-9ad2-4a22-9233-53994eebe6cf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("622d3363-19c7-4417-b39e-9506ec28d7dd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6326f19b-805a-4de8-9ec1-d9eb0be9ed5e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("63de8f42-d865-4e99-b762-10d7988f6c29"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("64d20d00-5c0c-44d8-875f-a0e29adf700a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("64f8806e-abc4-4f22-8ac5-adcaad7b6c1d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("65340e98-339d-4de5-9279-9caa453806f7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("662d4c1d-3b40-4010-a485-c4ae42188348"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("66ab9e59-10c3-4df2-9cdc-865db50b47e3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("66b2e2d9-5a07-4c41-9f19-bea8d0bd725c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("66cefae1-00e3-4ed1-8e34-fe78f4253a20"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6ca13ad1-b736-4ba7-9e4c-ae1de41b252b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6e7aaa0e-c0fb-4d24-920d-3d58fb53549d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6f9c48c6-4354-4548-a198-db5234870ce4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("70c057fb-f28e-4760-9ea7-cd4a71aa8cdd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("78df6ca3-42f6-42db-b0f8-4fcd6a8ee017"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7addf940-532a-40a9-82d9-87fddb211db1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7ba80220-9c93-492c-951a-7cc02db179a1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7c1fe452-9d68-4b80-8825-56f9ee43d619"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7cdb9389-1eba-449f-9b37-3ba2b2581fb3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7fa1f18f-f0c8-4985-8500-7144066c9fd7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("827fb69d-497b-4944-bbba-6c0c5299f6d7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("82f07a11-f010-4638-8987-c7becd98204e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("858c6327-d5f3-48f2-a56b-0788b2b3b2b6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("86a16a68-8ac2-4e07-bbd3-2f4855051c11"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("88c150d0-69ca-4dd6-b90a-f9a1d0d14e26"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8a0f2ab9-efeb-43d9-abea-5d3d39089895"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8ae4b8d7-ff5a-464e-a8f5-b4dd637560a5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8c061da7-0e60-4fae-ac2c-044df74af968"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8de24d18-979b-4c8e-bcdf-8e2c266259e2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8e72f5e9-d726-45cb-8dde-f0c5eda4f283"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8f3b9041-1f8e-4546-99f6-5f23de51dbf1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("90251432-fd35-45bc-b16a-14da5f31dd55"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("90b51902-9284-4304-b74c-7e77f4886a8e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9152c4e7-a58f-4f2c-9c3e-1ac996728657"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("917756ec-b234-4a19-b09e-410c9b2fdefc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("92e7253b-9727-421b-9fdb-7fa87aa67bcf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("986d920f-2cb8-43f4-9276-7829af5ae501"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("99ca7737-3688-4452-808b-370bbd08a932"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9a29c4e9-f124-432f-9055-33af75eb80fe"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9c99e162-c505-4c33-9284-a81a45c49d9d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a0996bac-0885-4831-b51a-e56308647d64"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a39ec8aa-dc75-4971-9906-465bb7647759"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a44c869e-c29c-4a0d-b128-fd08ab5c2e1b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a4ad7fea-2fe1-484e-a791-c917e7b7b20f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a598a17a-2bf9-4141-9216-6b325bd194d6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a90900d1-60b7-4cc5-8d45-7726e8e474c5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("aa672cc7-00b3-45d3-ac6f-d47640bc1e4e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("aa92c421-d45b-43b4-8560-016d447b1764"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ac1104fc-1a84-4b4e-9952-a9a133b09e29"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ad217eef-99e4-4896-8a47-75ed66191aaf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("aee94b17-12e9-4e1e-8dcb-aa44893fba4c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("af1d11d4-2c2a-4852-be3e-6782f40954a2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b0f7f411-0409-4ed6-afc1-23e0c44327bd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b1746717-364e-40d0-a7e5-99482b365ff0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b2e79f1f-02c7-4fdf-af12-313dd8d78969"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b34f6142-6703-474a-99e6-ae6fe78b9183"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b5188132-0f73-4a0d-bff4-f4d51ef811f6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b53b9fcb-4b2d-4d6d-a915-dcef9d4585e5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ba0e8eff-c376-4d12-a173-7626e1984e41"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ba4ade46-2179-43d7-a359-4dad62ad5027"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ba644192-1550-4422-8518-82a549c35ceb"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bbf39b6e-9c41-4e6a-8f96-3c2d5c50bc7a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bc1cae34-926c-4d44-a714-204fba921b42"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bc6daa95-154f-4703-a470-541f74119771"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bf07b4f8-ee36-4f39-9d98-0d5d23c94d90"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bf3c82f4-0d17-46e3-90ac-799d0c13f488"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bfd6b73a-b7e3-4cc6-b5c7-97c9b96fc27c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c002ae35-3712-4474-a465-b2363268f0e2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c1010406-8bb4-4a94-8b8f-fe06391643c5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c488ab91-c490-431b-9ebe-d27b8b02a8ee"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c496eaba-4c88-4188-a97b-f2579d25af0d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c742a330-3b39-4ee4-bd2e-cb0a5b9b21a4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c7aafb86-6632-44e2-b14b-170a1087d1bc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c8622718-c526-4ab6-ac30-ef98bbc5a937"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c9495e2d-368d-4037-9e41-15835f27ad1b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ca0b6575-1aae-4fff-a130-8a7f29354e41"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ca78dcf9-075d-4c24-b43a-70bfa26076a1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("cde57016-554c-422f-b362-d3bfb2045091"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("cec9346d-58fd-456b-b1b3-61fcc875b0df"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d02af94b-ed5c-4b57-908a-5c6734dc288a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d2f3eafb-a6e3-42e1-8c6e-0e417eabb64c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d6d90f95-025a-4d3d-b086-8abf42950077"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d73c2b17-a178-4e3e-a479-00766590adbc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d81de1c7-78ca-4c12-b06e-c03e538efb3b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d94f034a-32a7-4525-91a4-e1bc6e3b3e47"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("dc186850-35da-426d-9d2b-27d99a1be988"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ddd7bc31-9678-4001-be4c-87acd5e5340a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("defb0658-e456-427b-b34b-073ca097a2cd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("df514617-71aa-41e4-88da-617853dc96f0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e0bd35d2-58a6-4606-936d-d941657cb59c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e0cf80a4-8f15-4455-8bd0-e80b0377faa3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e3f9c953-183a-4580-b369-d71d1f8e83d0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e4a2fb8a-5189-4f8f-9f59-856ccea26883"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e75d4361-2f2e-4465-a1e6-4b8580d70cde"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e78b4d2c-add2-43a4-998b-a4279525bc49"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e999334c-afbf-4e31-8e4c-dc434c2ce41b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ebf5e325-b9e6-43b9-bd57-8cf7f8ee4194"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ee756c46-792f-43fb-b8b5-69153821cf03"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f0e5f7ef-edb4-42a2-b533-40641a682e21"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f12bf2df-2e65-4634-bdac-45005b999f70"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f1cf198e-5e0a-4567-b517-38c52fa0aae5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f21522bd-dbca-4f92-bc89-b3c39de9a61d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f5776f04-52bb-42e6-86d8-1fdc59eadb66"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f5b381e5-83d0-4157-8130-969f2a9a14a1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f5cb8969-97a4-47fe-9b5b-7df6ee04c687"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f7fd49e5-1fd5-4348-8cba-cca708c73677"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f84061cf-7998-4411-abca-e06b5627acd4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fb1e8c43-a2b2-400f-b9a3-e87a7f5283e3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fb2449f2-d08b-4c9d-a1d2-abdf171e79f0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fbde8163-54e4-4d5f-9c3a-06c28a1d1c88"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fc655a0e-ce4a-4dbc-b396-582b0920539b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fd2fceaa-0f1e-452d-a07d-a2290b3a14a6"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fd342c1e-8256-448c-a64f-31671662a8e8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fd66b978-a3b5-4c4c-808a-6e59c2bb7979"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ff3befb6-293a-4304-83bd-123627417228"));

            migrationBuilder.CreateTable(
                name: "D01_QCDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionBySizesJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D01_QCDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D01_QCDetail_D01_QCRequest_Id",
                        column: x => x.Id,
                        principalTable: "D01_QCRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JsonBinaryData",
                columns: table => new
                {
                    JsbData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "JsonResponse",
                columns: table => new
                {
                    jsbData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("02884a90-921e-44fe-a6f3-4d56bc660d98"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4872), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("20307cd9-7775-437b-b56f-3decd98ba56e"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4882), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("2bf9a034-9773-4763-b45a-62cb64b4fe60"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4878), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("3f11283f-d11b-4266-b658-16e82b01d991"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4867), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("4facb93b-a39d-4941-858b-6955b5e90eca"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4902), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("7680f05d-5794-454c-85b1-2291e4882828"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4898), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("81c393a2-6188-4012-8f42-85fd197f273b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4894), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4839), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("a008c1d5-bea1-4790-aa14-d37e300593f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4890), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("ac1c939d-2ef6-42c5-a953-d535af0a0475"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4863), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("baf4f214-b6d4-4f59-ba03-c642d3806299"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4906), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("c0619a96-4bc9-4036-8699-7f29ba9f035c"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4886), new DateTime(2021, 11, 14, 23, 21, 23, 301, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("b76bb2a9-7d1d-4eff-96a9-964bce19cb38"), "F06", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(5861), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(5865), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("eefa4a1c-a26e-43d9-9ada-15dbe826dd09"), "F05", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(4412), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(4416), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("8ab23a00-283c-40db-a712-74fe11e37040"), "F04", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(3049), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(3053), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("88b2cd95-b728-444a-aded-9002a45aaf22"), "M01", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(3538), 0, "BROKEN END", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(3568), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("d6da786e-fcf5-4b83-8628-b69330d18c62"), "F02", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(270), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(274), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("b58d26fd-6dfa-46b6-b8b6-44179188dc3c"), "F01", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(8803), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(8808), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("4aab6a01-213d-4a90-a515-0434fe122fd9"), "F07", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(7248), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(7254), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("4a164bb9-8625-4d0a-b080-538511f48732"), "F03", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(1640), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 335, DateTimeKind.Local).AddTicks(1644), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("e386b74b-c7e8-4b5b-9bf4-ee4e6e109b8b"), "F08", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(1967), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(1991), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("8c776de9-f632-4b97-b524-b138f2356efc"), "F15", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(6887), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(6891), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("b58a3f4d-fbc9-4396-9006-df8339335eb7"), "F10", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(7027), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dò kim loại không đạt ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(7048), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("c1bae76b-9e4a-46b6-bf8d-69a691414888"), "F11", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(8951), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(8969), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("733e3025-aa87-4eeb-a26f-2a7cfef09d34"), "F12", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(2181), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng, thời trang wash ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(2191), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("fa3e42cd-1e07-44b7-8350-0d8f7f356bf9"), "F13", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(3996), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Gấp xếp, dán thùng, đai thùng không đạt chất lượng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(4001), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("e229fc85-7b7d-4a83-927a-c452a1efc1db"), "F14", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(5492), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai tỷ lệ và số lượng trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(5496), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("2074a8c7-5b80-4cf7-9aa6-b6eef4542833"), "W20", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(7017), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(7021), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("0206762a-1360-43cd-bc3b-b0e23668d09b"), "F16", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(8253), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 337, DateTimeKind.Local).AddTicks(8257), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("1921dba9-7339-4c06-91a8-2db4e0ffe307"), "F17", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(176), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(181), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("ff83821a-20ff-4bfb-adb8-8cff3e39cba8"), "F09", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(3871), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 336, DateTimeKind.Local).AddTicks(3881), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("0fcf4317-4a99-4ac8-b0c4-c6d4985a1192"), "W19", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(5595), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(5599), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("4b340f81-a569-484f-8e57-52ace1766d07"), "W13", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(6898), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi dơ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(6903), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("d81347c8-a2b1-4d45-a0dc-055daa3bf9f3"), "W17", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(2681), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(2686), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("1612a00a-d19a-493a-b8bf-4c09ae0ee193"), "S19", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(6501), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(6505), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("71b42573-95c0-4469-8286-b4083b3b85d8"), "S20", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(8109), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(8114), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("582116f9-dbbc-42d6-88de-c23e2658822e"), "W01", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(9524), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(9528), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("7b9b1b31-89f8-4377-a6d2-831b03c1765f"), "W03", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(2310), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "PP không đạt, đốm PP, cấn wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(2314), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("301f96fd-6b7d-4273-8e4d-951d168a6b58"), "W04", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(3658), 0, "whishkers, grinding,..", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng thời trang không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(3662), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("8e950af8-7029-4278-9842-0fcbbc29da63"), "W05", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(5292), 0, " handsands, destroys,..", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(5297), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("31d63a05-5fcb-4a65-967e-734e08bf421b"), "W06", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(6666), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "3D thiếu hoặc mạnh/yếu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(6670), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("332f9919-e6fe-4592-92da-df2712bb60de"), "W07", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(8325), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(8330), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("1e81c3cd-18db-4bb4-ae74-66ac9f87a5a5"), "W08", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(9694), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ mềm không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(9698), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("80095eaf-9315-4562-8271-f9a57b812b84"), "W09", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(1116), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(1120), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("cbbc1d43-4f62-4c32-b2a1-702825ba0f9d"), "W10", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(2519), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục rách", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(2523), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("2c4a135a-b919-4bcd-8bc0-fbfea76548e8"), "W11", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(3978), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(3982), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("79c37312-6026-4cd0-903c-8a3ef4c977f1"), "W12", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(5347), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi May", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(5350), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("134162c7-9837-4d63-9149-c361445405ed"), "F18", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(1554), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(1558), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("953cd733-761f-42df-bce1-f850833f8bc7"), "W14", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(8574), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn/ gãy, sờn hoặc cấn bóng bề mặt vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(8578), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("0fc4dd00-ae6e-4086-be34-584e95a6133e"), "W15", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(9913), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 333, DateTimeKind.Local).AddTicks(9917), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("347f3bb8-343e-40af-b705-0993be61fa60"), "W16", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(1327), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(1331), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("089f68a1-4840-4779-a5f2-52e23591525f"), "W18", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(4215), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 334, DateTimeKind.Local).AddTicks(4219), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("5972a19c-89e8-4280-bd2a-840de40a62e4"), "F19", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(3032), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(3037), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("f9757069-d68a-477a-8d97-871ab74b3c69"), "PP06", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(3485), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(3502), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("dba8d8c6-223d-4088-847c-f107e628c848"), "PP01", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(5962), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(5966), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("d00fc8f5-a0c8-4478-9291-8d382a38c298"), "P04", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(9848), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(9852), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("831e6006-4146-4f7d-a24a-4a1a4800e670"), "P05", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(1182), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(1186), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("8057f707-b3a4-4f93-a2f2-c73681cddf0e"), "P06", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(2599), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(2603), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("49a47802-3add-4890-8870-a092ed14ef53"), "P07", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(4337), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(4341), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("51d5a92e-a67d-4652-b03c-31bd89274d86"), "P08", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(5789), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(5793), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("4481ee85-c5e7-4543-9c4c-0eea877c8efb"), "P09", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(7148), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(7153), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("53fe18d9-ee8d-4dfc-ab4d-eade88b2577f"), "P10", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(8569), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 342, DateTimeKind.Local).AddTicks(8573), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("8406214a-5eb9-4f7c-8e3e-cdd576ed7876"), "P11", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(125), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(130), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("73754a74-28a4-4be5-9be5-0c2b3e8c49ec"), "P12", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(1595), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(1600), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("ffe1f321-7e14-487a-9634-65ef1f5ca35c"), "P13", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(2950), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(2954), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("b6d7cb1e-eda6-479f-8b68-79a62d7b6e5f"), "P14", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(4497), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai số lượng và tỷ lệ trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(4502), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("7a7c93b8-3d8f-423d-be92-95d72116f8be"), "P15", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(5868), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(5873), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("66e9fce5-4813-4102-b02b-0e14ac605d90"), "P16", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(7253), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mặc thử không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(7258), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("33958911-bdd4-4038-8afa-8f0fa27bdb99"), "P17", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(8627), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Kỹ thuật may xấu, không phù hợp", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 343, DateTimeKind.Local).AddTicks(8631), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("fc4c2300-2dee-413d-aa07-53957e338edb"), "P18", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(23), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(27), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("304447a5-e078-4e85-bf6c-083b852ed675"), "P19", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(1683), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(1687), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("22805596-b549-4a93-8d04-037a221fdcfd"), "P20", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(3113), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 344, DateTimeKind.Local).AddTicks(3118), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("d1b7c10d-9a57-4687-927d-a2f4daf3f31f"), "P03", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(8418), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(8423), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("001eebcc-8263-4431-89e2-9466f8fad4d1"), "P02", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(6875), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(6879), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("0fcb95fb-d3a5-4d16-a186-e25800083aff"), "P01", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(5452), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(5457), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("c60f1ff1-0031-4808-b265-c06f3cb00c16"), "PP20", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(4009), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(4014), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("0f0d637d-30a9-4285-9c19-ce30375d72f7"), "PP02", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(7329), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(7333), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("d200cc99-bd9d-4b99-a91c-dc8676d3d7da"), "PP03", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(8751), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(8755), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("b682dd95-90be-47f4-966e-5aa624fea12c"), "PP04", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(115), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(119), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("6d9c0493-3bba-4418-917d-f7209d46a5e7"), "PP05", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(1831), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(1836), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("440e7bcb-0011-4b54-a7f3-61339ce7fa3d"), "S18", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(5062), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(5066), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("eb528707-40e6-4551-b275-c9ac5180090d"), "PP07", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(4987), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(4991), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("2c6989fc-60e4-45f5-badb-e7eab563ff4b"), "PP08", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(6361), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(6365), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("e9e473bd-7961-4969-a38b-4945f6cbbb8d"), "PP09", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(7780), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(7784), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("874e47c0-1b1f-44de-9381-74b6ed048b92"), "F20", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(4525), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 338, DateTimeKind.Local).AddTicks(4529), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("b2c4efe5-b3fe-4bd9-8eba-f4f432a7e2a9"), "PP10", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(9115), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 339, DateTimeKind.Local).AddTicks(9120), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("f366cff2-9d87-48bf-89ae-7c4cfd59529a"), "PP12", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(1843), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(1847), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("8861bc9b-948f-479f-9cc5-24c920e7053c"), "PP13", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(3567), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(3572), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("81c4e41b-bd0c-48df-a4ac-d71aa8707f39"), "PP14", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(4992), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai số lượng và tỷ lệ trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(4996), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("cb9538eb-e1e5-45af-9421-43933c5159d7"), "PP15", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(6415), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(6420), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("c118c704-6c73-46a1-b7e6-d6e1e4ab48fc"), "PP16", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(7878), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mặc thử không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(7882), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("ca99bcbf-c3bc-4d02-be97-1759770eb74a"), "PP17", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(9276), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Kỹ thuật may xấu, không phù hợp", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(9281), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("5d89f2b0-54f7-402a-b932-9cef2edbcf8e"), "PP18", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(660), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(665), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("3a937911-7aa3-4495-a3d1-b6d4964d2fd2"), "PP19", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(2017), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 341, DateTimeKind.Local).AddTicks(2021), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("54414a1c-7654-4ec9-a22a-f4930e7150e1"), "PP11", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(486), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 340, DateTimeKind.Local).AddTicks(491), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("bb0a57e8-304a-4647-af85-866dcb1ef0f0"), "S17", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(3702), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(3706), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("86b09867-0f9f-44d8-9491-948b2ecbcf62"), "W02", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(869), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu, loang màu trong cùng sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 332, DateTimeKind.Local).AddTicks(873), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("cdb080fe-8604-4b2e-bead-cdd659f19f99"), "S15", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(759), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(763), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("a3d7908f-11bd-42ea-849b-eb122b6d8826"), "MO07", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(1409), 0, "COLOR / WHITE SPOT", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỐM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(1414), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("bc4a09b2-ff4c-462f-85e7-fd2aeb4c8055"), "MO08", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(2823), 0, " KNOT/NAP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "NỐI SỢI , BÔNG TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(2827), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("4070b6e0-532a-4b59-bb3d-d76850e4d99c"), "MO09", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(4195), 0, "LOOSE WARP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "LỎNG SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(4200), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("c6d46365-25ac-4d76-851c-7409ea0b326b"), "MO10", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(5639), 0, "MISPICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "MẤT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(5643), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("3a104995-5b79-4ab0-8942-67fd4985ae1b"), "MO11", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(7096), 0, "STOP MARK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "DỪNG MÁY", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(7101), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("ab3034d6-5d69-404a-a493-41a3df4181e1"), "MO12", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(8813), 0, "CREASE MARK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "GÃY MẶT VẢI", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 321, DateTimeKind.Local).AddTicks(8818), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("305d9f54-253a-46b1-8ea0-71b38e02dc26"), "MO13", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(471), 0, " HOLE ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "THỦNG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(476), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("26925173-536a-4ad8-b9a6-5bafa58fb0b4"), "MO14", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(1904), 0, "Print off layout ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LÊCH KHUÔN", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(1908), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("5d458013-0244-49d3-9b3f-9302316decc9"), "MO15", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(3274), 0, " PRINT COLOR SMEAR", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LEM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(3278), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("77ceacc6-ba06-413d-b3e1-e7f0877ce031"), "MO06", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(9956), 0, "STAIN / DIRTY ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "BIẾN MÀU /DƠ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(9960), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("825d27ef-1dcd-47ad-9a26-a0a6f40201bf"), "MO16", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(4736), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu biên ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(4740), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("f7d405a9-b213-4d11-89b5-fe2b92239e5a"), "MO18", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(7735), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sọc ngang, dọc, sọc nhuộm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(7739), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("43e69cdb-95c1-41a3-8e2d-e8166076bc5b"), "MO19", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(9093), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(9098), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("27f3c81f-ed49-4bf4-b3fb-d84ce6641d89"), "MO20", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(508), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(513), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("f345b11f-c727-4df2-85b8-e597d22c8d5f"), "T01", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(2095), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai từ ngữ, ký hiệu, Logo,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(2099), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("9f7c7a68-2ff7-4de7-85dd-c71bed1b38ee"), "T02", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(3572), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai chủng loại, chất liệu, hình dạng, kích thước, màu sắc,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(3576), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("f3cd1635-e1a5-4ad2-b8ba-21ed2334e85e"), "T03", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(4964), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nét chữ trên phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(4968), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("5c6a5e0e-c989-4123-97ec-a562e97c47d3"), "S16", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(2114), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 331, DateTimeKind.Local).AddTicks(2118), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("171dfc83-1bca-431c-8e8c-601e18c073b0"), "T05", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(7765), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu kim loại rà kim không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(7769), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("a6de6cee-176a-468d-a5e2-63293b22f2bf"), "T06", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(9173), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu  nứt, lủng rách, biến dạng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(9178), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("8b538a54-fa22-49e5-820c-4655f3aa5e9b"), "MO17", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(6087), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "khác màu đầu cuối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 322, DateTimeKind.Local).AddTicks(6091), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("9fab1f2a-4fc6-479b-bd6c-3338aa96302c"), "MO05", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(8407), 0, "FOREIGN FIBER ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(8421), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("68f498aa-d08d-41b4-8c61-bc4380b1bf1d"), "MO04", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(5225), 0, "COARSE PICK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 320, DateTimeKind.Local).AddTicks(5260), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("98df42db-1b0e-495e-ab17-e52745732739"), "MO03", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(6030), 0, "COARSE END ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(6035), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("82ab6a5b-7cb9-44a7-bd1a-44834a82beb5"), "M02", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(5325), 0, "BROKEN PICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(5330), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("a64df969-d663-4e57-b78b-8f3ab44084e3"), "M03", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(6959), 0, "COARSE END ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(6968), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("2f9c96f1-1c42-4fb3-ae60-9228687fec97"), "M04", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(8486), 0, "COARSE PICK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(8490), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("69f745c4-13d6-4194-b87f-a9b1e6b8e3c0"), "M05", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(9894), 0, "FOREIGN FIBER ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 316, DateTimeKind.Local).AddTicks(9898), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("1d233f9d-eed1-4db8-b830-165d903fdc22"), "M06", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(1265), 0, "STAIN / DIRTY ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "BIẾN MÀU /DƠ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(1270), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("ee3192e7-b603-4011-9073-7d6d9df4ce2e"), "M07", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(2693), 0, "COLOR / WHITE SPOT", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỐM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(2697), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("a9f07d65-4c72-4601-9fbe-8d5cad7fa7ad"), "M08", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(4102), 0, " KNOT/NAP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "NỐI SỢI , BÔNG TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(4107), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("bf8dbee1-a01f-4304-b66f-c903d2b96e1d"), "M09", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(5825), 0, "LOOSE WARP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "LỎNG SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(5830), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("d8e90503-b2ad-41ce-9246-5b8c094181f7"), "M10", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(7322), 0, "MISPICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "MẤT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(7326), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("c0de61b0-a269-49ce-b709-a1f47fb1e667"), "M11", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(8759), 0, "STOP MARK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "DỪNG MÁY", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 317, DateTimeKind.Local).AddTicks(8764), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("41357ff9-43d4-48a7-bd9e-5b36a86b46a1"), "M12", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(100), 0, "CREASE MARK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "GÃY MẶT VẢI", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(104), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("75fe4005-8b4b-4851-aebe-d3c821d5bc5d"), "M13", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(1525), 0, " HOLE ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "THỦNG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(1530), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("550164a2-fa93-475b-9cb9-da77ab3568fe"), "M14", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(2872), 0, "Print off layout ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LÊCH KHUÔN", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(2876), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("fa216f35-232a-46a1-9872-3da111a23929"), "M15", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(4301), 0, " PRINT COLOR SMEAR", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LEM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(4306), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("37ce6733-bd34-4a32-9a2b-e268afdef36e"), "M16", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(5673), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu biên ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(5677), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("b3df4c1f-71a2-4362-b17f-38fdee90b924"), "M17", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(7427), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "khác màu đầu cuối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(7431), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("5e1d6f70-0144-4ea4-b478-f9f4d09ee5f2"), "M18", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(8805), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sọc ngang, dọc, sọc nhuộm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 318, DateTimeKind.Local).AddTicks(8810), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("e1b41df2-7605-4eeb-bc33-adf9f3686124"), "M19", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(227), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(232), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("dc617bfb-9c6a-4c88-80c3-80fa50b42873"), "M20", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(1655), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(1660), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("5e379d18-05e4-4d5b-b4ae-3914a17d9bfa"), "MO01", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(3266), 0, "BROKEN END", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(3270), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("d1775f64-a69b-48e8-8d5a-e4413ab75933"), "MO02", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(4642), 0, "BROKEN PICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 319, DateTimeKind.Local).AddTicks(4646), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("732a6da7-51bd-487e-b79d-974ceeadab86"), "T07", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(534), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ mềm phụ liệu, ẩm/mốc, mùi hôi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(538), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("2f2c7806-e75c-4a46-970e-dbc6d589a66b"), "T08", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(2160), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu gỉ sét, trầy xước bề mặt, tróc in, dơ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(2165), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("669dbd30-9431-4c0e-8af8-a54e7261cd3a"), "T04", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(6362), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 323, DateTimeKind.Local).AddTicks(6366), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("4e839aae-1794-4686-9b4c-36426461ffa2"), "T10", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(5156), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đầu và răng khóa dây kéo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(5161), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("99591a0e-dde9-45d4-9f2b-ed5015c75905"), "C15", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(1791), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(1795), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("4b76e899-94a8-4890-8347-c43cba8a2885"), "C16", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(3203), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(3208), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("0cb19782-57a2-4d95-bbe9-73995b7e57f2"), "C17", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(4638), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(4643), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("e1afae0c-df96-4959-a840-0307f8c323ce"), "T09", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(3750), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Loang màu, đổi màu, không đồng màu trong lô", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(3755), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("dbebf639-d6e9-499e-b195-bc46b6096dd8"), "C19", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(7629), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(7633), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("496dcc9b-2207-4a6d-9279-985d4a1a949e"), "C20", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(9036), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(9040), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("f3162c64-0079-47bb-9225-23b11c584ba1"), "S01", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(578), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nối chỉ không trùng, chỉ thừa, lộ chỉ lược, vệ sinh công nghiệp không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(583), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("47ea02a2-ff38-4eaa-892b-05d180c90f9c"), "S02", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(1997), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(2001), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("3e755542-9ae0-4540-9b77-2e7e588c5035"), "S03", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(3350), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, vặn, gợn sóng, bai giãn, sụp mí, le mí, xì mép,xếp ly", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(3354), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("97e03c83-9766-4774-8338-2a773c72e8b8"), "C14", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(431), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(435), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("bb32c545-7b18-409d-b1e7-b92be9bcafe3"), "S04", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(4762), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cao/thấp, không đồng đều đường may, không đối xứng, không đúng dấu/rập", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(4766), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("4f494092-7aa9-41d0-8994-270b5005e97d"), "S06", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(7809), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính gỉ-sét, dầu máy", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(7813), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("d3c90403-78f9-4aae-8be4-3a524f3ca061"), "S07", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(9157), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dơ, dấu phấn, mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(9161), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("1c7565c2-94b1-45e7-a994-bd9e10917c42"), "S08", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(612), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu chi tiết, ráp lộn số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(617), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("99b7c96d-1dc6-4f12-88fc-fd9e2c9adf06"), "S09", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(2176), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi ủi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(2181), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("a7243f7e-3758-4d71-a66f-b790be8c5569"), "S10", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(3586), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi kỹ thuật, biến dạng form, không phù hợp,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(3590), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("a7a36f5c-3b4e-415b-beac-2819130324af"), "S11", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(4965), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thiếu/ Sai: Phụ liệu, nhãn, bán thành phẩm In, thêu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(4970), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("d9332900-d233-40bd-8ddd-1bb82b1063af"), "S12", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(6367), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(6372), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("9c9edff8-5211-42c3-bdd9-a09fe10b6500"), "S13", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(7979), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(7984), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("b8328347-c632-4a79-a338-d12191281631"), "S14", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(9381), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 330, DateTimeKind.Local).AddTicks(9385), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("1b058fcf-4f39-4b29-b61c-137a470abd05"), "S05", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(6112), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 329, DateTimeKind.Local).AddTicks(6116), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("e387b626-1044-45c6-abf8-c4070df3b75d"), "C13", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(9045), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(9050), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("5c331b10-d666-48ac-8984-988146249c15"), "C18", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(6047), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 328, DateTimeKind.Local).AddTicks(6051), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("25c997a3-ea81-4288-acaa-8bb532bdfd4e"), "C11", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(5829), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thêu bỏ mũi, đứt chỉ, không khóa mũi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(5833), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("75525318-393b-448d-9f5b-ad23fd8d061c"), "T11", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(6535), 0, "kéo trượt 10 lần", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ trượt khóa kéo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(6539), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("81fa80d9-ed6b-4081-b409-7d9b90e050ce"), "T12", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(8117), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vặn, xoắn, có nhiều mối nối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(8121), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("93f6ff15-027f-4b82-ac8f-f272c919d03e"), "T13", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(9582), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mối dán ép bao bì không bền chắc", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 324, DateTimeKind.Local).AddTicks(9586), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("392cb9d2-c2a1-4612-9b0e-94fb4c7b3de5"), "T14", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(1012), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(1017), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("2ffff173-0ec8-41fe-97f5-194dbdc5e61a"), "C12", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(7221), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng rách bán thành phẩm vải/ keo", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(7268), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("a491f29e-fe12-480a-89f4-1137e242b568"), "T16", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(3790), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(3794), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("f4294656-5d0e-4a69-849d-c70a97cbf0b2"), "T17", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(5398), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(5402), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("095a4666-0d51-4cc7-876f-7b3535610a96"), "T18", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(6758), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(6762), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("8f2147d5-9a82-491a-bec5-954508bae81f"), "T19", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(8431), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(8436), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("8aaa1a5f-963e-4b7a-8099-09cccd3dd4e3"), "T20", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(9776), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(9780), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("3a63824a-dd05-492c-bfa9-8aac63c066bf"), "T15", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(2448), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 325, DateTimeKind.Local).AddTicks(2452), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("7d86543a-c3b2-42c3-9613-77188ef02f1d"), "C02", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(2544), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bán thành phẩm cắt lớn hoặc nhỏ hơn rập ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(2548), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("03aa0a5a-57c5-4c42-a57f-39fcbf7bfa97"), "C03", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(3955), 0, "vải chính, vải lót, keo,…", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Biến dạng, sai hình dáng, canh sợi, bề mặt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(3959), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("89d963a9-a00f-4df2-9499-9a41a3342a3c"), "C04", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(5309), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thiếu dấu bấm, dấu bấm ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(5313), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("2ef1260e-b189-462a-b253-9d80aa2a3f8b"), "C05", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(6941), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi đánh số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(6946), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("fbb7e9d6-8087-414c-9373-605bcae134b9"), "C06", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(8587), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Loang màu chi tiết, dơ, ố", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(8591), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("c16e75a4-f56c-4049-93ca-737a5a1d6a73"), "C07", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ép keo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(5), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("57178f56-f2e2-43fa-ad11-9b20f073430c"), "C01", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(1182), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi hoặc sai sơ đồ cắt, rập cứng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 326, DateTimeKind.Local).AddTicks(1186), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("6971e818-8447-4de0-a505-286630680d41"), "C08", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(1397), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai màu thêu, màu in", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(1400), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("f7e74277-4789-458a-8ffe-708621060292"), "C09", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(3023), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "In, thêu thiếu nét, thiếu chữ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(3028), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("5d6c4b7d-2a93-4d5d-b5d1-bb69795715a3"), "C10", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(4429), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "In, thêu sai vị trí", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 14, 23, 21, 23, 327, DateTimeKind.Local).AddTicks(4433), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") }
                });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 299, DateTimeKind.Local).AddTicks(2228), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("1bc43632-e605-4489-8030-f7dad305f00c"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3970), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("3fe931f7-728b-48e6-b37c-828f683f9229"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3978), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3957), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3943), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3986), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3982), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("cd6aac51-979f-499b-a9bc-55681caf2956"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3974), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("de72a6a9-bd09-48e3-b48e-19494d3ddb43"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3961), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("f34e7928-c4f0-4f84-95f7-335d73196358"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3952), new DateTime(2021, 11, 14, 23, 21, 23, 300, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.CreateIndex(
                name: "IX_D01_QCDetail_Code_Name",
                table: "D01_QCDetail",
                columns: new[] { "Code", "Name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D01_QCDetail");

            migrationBuilder.DropTable(
                name: "JsonBinaryData");

            migrationBuilder.DropTable(
                name: "JsonResponse");

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("001eebcc-8263-4431-89e2-9466f8fad4d1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0206762a-1360-43cd-bc3b-b0e23668d09b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("03aa0a5a-57c5-4c42-a57f-39fcbf7bfa97"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("089f68a1-4840-4779-a5f2-52e23591525f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("095a4666-0d51-4cc7-876f-7b3535610a96"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0cb19782-57a2-4d95-bbe9-73995b7e57f2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0f0d637d-30a9-4285-9c19-ce30375d72f7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0fc4dd00-ae6e-4086-be34-584e95a6133e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0fcb95fb-d3a5-4d16-a186-e25800083aff"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("0fcf4317-4a99-4ac8-b0c4-c6d4985a1192"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("134162c7-9837-4d63-9149-c361445405ed"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1612a00a-d19a-493a-b8bf-4c09ae0ee193"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("171dfc83-1bca-431c-8e8c-601e18c073b0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1921dba9-7339-4c06-91a8-2db4e0ffe307"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1b058fcf-4f39-4b29-b61c-137a470abd05"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1c7565c2-94b1-45e7-a994-bd9e10917c42"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1d233f9d-eed1-4db8-b830-165d903fdc22"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("1e81c3cd-18db-4bb4-ae74-66ac9f87a5a5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2074a8c7-5b80-4cf7-9aa6-b6eef4542833"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("22805596-b549-4a93-8d04-037a221fdcfd"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("25c997a3-ea81-4288-acaa-8bb532bdfd4e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("26925173-536a-4ad8-b9a6-5bafa58fb0b4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("27f3c81f-ed49-4bf4-b3fb-d84ce6641d89"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2c4a135a-b919-4bcd-8bc0-fbfea76548e8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2c6989fc-60e4-45f5-badb-e7eab563ff4b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2ef1260e-b189-462a-b253-9d80aa2a3f8b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2f2c7806-e75c-4a46-970e-dbc6d589a66b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2f9c96f1-1c42-4fb3-ae60-9228687fec97"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("2ffff173-0ec8-41fe-97f5-194dbdc5e61a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("301f96fd-6b7d-4273-8e4d-951d168a6b58"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("304447a5-e078-4e85-bf6c-083b852ed675"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("305d9f54-253a-46b1-8ea0-71b38e02dc26"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("31d63a05-5fcb-4a65-967e-734e08bf421b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("332f9919-e6fe-4592-92da-df2712bb60de"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("33958911-bdd4-4038-8afa-8f0fa27bdb99"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("347f3bb8-343e-40af-b705-0993be61fa60"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("37ce6733-bd34-4a32-9a2b-e268afdef36e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("392cb9d2-c2a1-4612-9b0e-94fb4c7b3de5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3a104995-5b79-4ab0-8942-67fd4985ae1b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3a63824a-dd05-492c-bfa9-8aac63c066bf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3a937911-7aa3-4495-a3d1-b6d4964d2fd2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("3e755542-9ae0-4540-9b77-2e7e588c5035"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4070b6e0-532a-4b59-bb3d-d76850e4d99c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("41357ff9-43d4-48a7-bd9e-5b36a86b46a1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("43e69cdb-95c1-41a3-8e2d-e8166076bc5b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("440e7bcb-0011-4b54-a7f3-61339ce7fa3d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4481ee85-c5e7-4543-9c4c-0eea877c8efb"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("47ea02a2-ff38-4eaa-892b-05d180c90f9c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("496dcc9b-2207-4a6d-9279-985d4a1a949e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("49a47802-3add-4890-8870-a092ed14ef53"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4a164bb9-8625-4d0a-b080-538511f48732"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4aab6a01-213d-4a90-a515-0434fe122fd9"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4b340f81-a569-484f-8e57-52ace1766d07"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4b76e899-94a8-4890-8347-c43cba8a2885"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4e839aae-1794-4686-9b4c-36426461ffa2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("4f494092-7aa9-41d0-8994-270b5005e97d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("51d5a92e-a67d-4652-b03c-31bd89274d86"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("53fe18d9-ee8d-4dfc-ab4d-eade88b2577f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("54414a1c-7654-4ec9-a22a-f4930e7150e1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("550164a2-fa93-475b-9cb9-da77ab3568fe"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("57178f56-f2e2-43fa-ad11-9b20f073430c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("582116f9-dbbc-42d6-88de-c23e2658822e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5972a19c-89e8-4280-bd2a-840de40a62e4"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5c331b10-d666-48ac-8984-988146249c15"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5c6a5e0e-c989-4123-97ec-a562e97c47d3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5d458013-0244-49d3-9b3f-9302316decc9"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5d6c4b7d-2a93-4d5d-b5d1-bb69795715a3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5d89f2b0-54f7-402a-b932-9cef2edbcf8e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5e1d6f70-0144-4ea4-b478-f9f4d09ee5f2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("5e379d18-05e4-4d5b-b4ae-3914a17d9bfa"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("669dbd30-9431-4c0e-8af8-a54e7261cd3a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("66e9fce5-4813-4102-b02b-0e14ac605d90"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("68f498aa-d08d-41b4-8c61-bc4380b1bf1d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6971e818-8447-4de0-a505-286630680d41"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("69f745c4-13d6-4194-b87f-a9b1e6b8e3c0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("6d9c0493-3bba-4418-917d-f7209d46a5e7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("71b42573-95c0-4469-8286-b4083b3b85d8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("732a6da7-51bd-487e-b79d-974ceeadab86"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("733e3025-aa87-4eeb-a26f-2a7cfef09d34"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("73754a74-28a4-4be5-9be5-0c2b3e8c49ec"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("75525318-393b-448d-9f5b-ad23fd8d061c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("75fe4005-8b4b-4851-aebe-d3c821d5bc5d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("77ceacc6-ba06-413d-b3e1-e7f0877ce031"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("79c37312-6026-4cd0-903c-8a3ef4c977f1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7a7c93b8-3d8f-423d-be92-95d72116f8be"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7b9b1b31-89f8-4377-a6d2-831b03c1765f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("7d86543a-c3b2-42c3-9613-77188ef02f1d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("80095eaf-9315-4562-8271-f9a57b812b84"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8057f707-b3a4-4f93-a2f2-c73681cddf0e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("81c4e41b-bd0c-48df-a4ac-d71aa8707f39"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("81fa80d9-ed6b-4081-b409-7d9b90e050ce"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("825d27ef-1dcd-47ad-9a26-a0a6f40201bf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("82ab6a5b-7cb9-44a7-bd1a-44834a82beb5"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("831e6006-4146-4f7d-a24a-4a1a4800e670"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8406214a-5eb9-4f7c-8e3e-cdd576ed7876"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("86b09867-0f9f-44d8-9491-948b2ecbcf62"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("874e47c0-1b1f-44de-9381-74b6ed048b92"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8861bc9b-948f-479f-9cc5-24c920e7053c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("88b2cd95-b728-444a-aded-9002a45aaf22"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("89d963a9-a00f-4df2-9499-9a41a3342a3c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8aaa1a5f-963e-4b7a-8099-09cccd3dd4e3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8ab23a00-283c-40db-a712-74fe11e37040"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8b538a54-fa22-49e5-820c-4655f3aa5e9b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8c776de9-f632-4b97-b524-b138f2356efc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8e950af8-7029-4278-9842-0fcbbc29da63"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("8f2147d5-9a82-491a-bec5-954508bae81f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("93f6ff15-027f-4b82-ac8f-f272c919d03e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("953cd733-761f-42df-bce1-f850833f8bc7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("97e03c83-9766-4774-8338-2a773c72e8b8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("98df42db-1b0e-495e-ab17-e52745732739"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("99591a0e-dde9-45d4-9f2b-ed5015c75905"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("99b7c96d-1dc6-4f12-88fc-fd9e2c9adf06"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9c9edff8-5211-42c3-bdd9-a09fe10b6500"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9f7c7a68-2ff7-4de7-85dd-c71bed1b38ee"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("9fab1f2a-4fc6-479b-bd6c-3338aa96302c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a3d7908f-11bd-42ea-849b-eb122b6d8826"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a491f29e-fe12-480a-89f4-1137e242b568"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a64df969-d663-4e57-b78b-8f3ab44084e3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a6de6cee-176a-468d-a5e2-63293b22f2bf"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a7243f7e-3758-4d71-a66f-b790be8c5569"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a7a36f5c-3b4e-415b-beac-2819130324af"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("a9f07d65-4c72-4601-9fbe-8d5cad7fa7ad"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ab3034d6-5d69-404a-a493-41a3df4181e1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b2c4efe5-b3fe-4bd9-8eba-f4f432a7e2a9"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b3df4c1f-71a2-4362-b17f-38fdee90b924"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b58a3f4d-fbc9-4396-9006-df8339335eb7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b58d26fd-6dfa-46b6-b8b6-44179188dc3c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b682dd95-90be-47f4-966e-5aa624fea12c"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b6d7cb1e-eda6-479f-8b68-79a62d7b6e5f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b76bb2a9-7d1d-4eff-96a9-964bce19cb38"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("b8328347-c632-4a79-a338-d12191281631"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bb0a57e8-304a-4647-af85-866dcb1ef0f0"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bb32c545-7b18-409d-b1e7-b92be9bcafe3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bc4a09b2-ff4c-462f-85e7-fd2aeb4c8055"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("bf8dbee1-a01f-4304-b66f-c903d2b96e1d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c0de61b0-a269-49ce-b709-a1f47fb1e667"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c118c704-6c73-46a1-b7e6-d6e1e4ab48fc"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c16e75a4-f56c-4049-93ca-737a5a1d6a73"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c1bae76b-9e4a-46b6-bf8d-69a691414888"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c60f1ff1-0031-4808-b265-c06f3cb00c16"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("c6d46365-25ac-4d76-851c-7409ea0b326b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ca99bcbf-c3bc-4d02-be97-1759770eb74a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("cb9538eb-e1e5-45af-9421-43933c5159d7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("cbbc1d43-4f62-4c32-b2a1-702825ba0f9d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("cdb080fe-8604-4b2e-bead-cdd659f19f99"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d00fc8f5-a0c8-4478-9291-8d382a38c298"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d1775f64-a69b-48e8-8d5a-e4413ab75933"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d1b7c10d-9a57-4687-927d-a2f4daf3f31f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d200cc99-bd9d-4b99-a91c-dc8676d3d7da"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d3c90403-78f9-4aae-8be4-3a524f3ca061"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d6da786e-fcf5-4b83-8628-b69330d18c62"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d81347c8-a2b1-4d45-a0dc-055daa3bf9f3"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d8e90503-b2ad-41ce-9246-5b8c094181f7"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("d9332900-d233-40bd-8ddd-1bb82b1063af"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("dba8d8c6-223d-4088-847c-f107e628c848"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("dbebf639-d6e9-499e-b195-bc46b6096dd8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("dc617bfb-9c6a-4c88-80c3-80fa50b42873"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e1afae0c-df96-4959-a840-0307f8c323ce"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e1b41df2-7605-4eeb-bc33-adf9f3686124"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e229fc85-7b7d-4a83-927a-c452a1efc1db"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e386b74b-c7e8-4b5b-9bf4-ee4e6e109b8b"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e387b626-1044-45c6-abf8-c4070df3b75d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("e9e473bd-7961-4969-a38b-4945f6cbbb8d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("eb528707-40e6-4551-b275-c9ac5180090d"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ee3192e7-b603-4011-9073-7d6d9df4ce2e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("eefa4a1c-a26e-43d9-9ada-15dbe826dd09"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f3162c64-0079-47bb-9225-23b11c584ba1"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f345b11f-c727-4df2-85b8-e597d22c8d5f"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f366cff2-9d87-48bf-89ae-7c4cfd59529a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f3cd1635-e1a5-4ad2-b8ba-21ed2334e85e"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f4294656-5d0e-4a69-849d-c70a97cbf0b2"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f7d405a9-b213-4d11-89b5-fe2b92239e5a"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f7e74277-4789-458a-8ffe-708621060292"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("f9757069-d68a-477a-8d97-871ab74b3c69"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fa216f35-232a-46a1-9872-3da111a23929"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fa3e42cd-1e07-44b7-8350-0d8f7f356bf9"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fbb7e9d6-8087-414c-9373-605bcae134b9"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("fc4c2300-2dee-413d-aa07-53957e338edb"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ff83821a-20ff-4bfb-adb8-8cff3e39cba8"));

            migrationBuilder.DeleteData(
                table: "L01_DefectLib",
                keyColumn: "Id",
                keyValue: new Guid("ffe1f321-7e14-487a-9634-65ef1f5ca35c"));

            migrationBuilder.CreateTable(
                name: "D01_QCTicket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DefectAQLJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectSizeBreakDownJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectsReasonAndSolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PrivateDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D01_QCTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D01_QCTicket_D01_QCRequest_Id",
                        column: x => x.Id,
                        principalTable: "D01_QCRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("02884a90-921e-44fe-a6f3-4d56bc660d98"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8778), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("20307cd9-7775-437b-b56f-3decd98ba56e"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8787), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("2bf9a034-9773-4763-b45a-62cb64b4fe60"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8782), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("3f11283f-d11b-4266-b658-16e82b01d991"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8773), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("4facb93b-a39d-4941-858b-6955b5e90eca"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8810), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("7680f05d-5794-454c-85b1-2291e4882828"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8805), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("81c393a2-6188-4012-8f42-85fd197f273b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8801), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8739), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("a008c1d5-bea1-4790-aa14-d37e300593f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8796), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("ac1c939d-2ef6-42c5-a953-d535af0a0475"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8768), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("baf4f214-b6d4-4f59-ba03-c642d3806299"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8814), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "L01_AQLLib",
                keyColumn: "Id",
                keyValue: new Guid("c0619a96-4bc9-4036-8699-7f29ba9f035c"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8792), new DateTime(2021, 11, 4, 15, 8, 45, 713, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("1b39f44b-efdd-40d8-ba85-eda61cc9995c"), "F06", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(2996), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(3001), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("827fb69d-497b-4944-bbba-6c0c5299f6d7"), "F05", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(1590), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(1595), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("38f9abe1-3f6e-4483-8a64-dc42ee4f41bc"), "F04", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(230), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(235), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("6ca13ad1-b736-4ba7-9e4c-ae1de41b252b"), "M01", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(5436), 0, "BROKEN END", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(5466), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("40f97108-5974-4fe0-8e33-4cec7eb77ce3"), "F02", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(7311), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(7316), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("4c60c131-644e-4688-86cd-4a4574cc6423"), "F01", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(5853), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(5858), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("35d6c6fc-9968-48ef-beb5-cb5d39323ef5"), "F07", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(4348), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(4353), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("4e600f20-b0ba-4b90-b0af-688d14f9b532"), "F03", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(8774), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(8779), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("a39ec8aa-dc75-4971-9906-465bb7647759"), "F08", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(5747), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(5751), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("e4a2fb8a-5189-4f8f-9f59-856ccea26883"), "F15", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(5936), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(5941), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("57fa98e9-029a-444b-8d6f-84fbb4df52b8"), "F10", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(8803), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dò kim loại không đạt ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(8808), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("ca0b6575-1aae-4fff-a130-8a7f29354e41"), "F11", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(188), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(193), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("f5cb8969-97a4-47fe-9b5b-7df6ee04c687"), "F12", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(1769), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng, thời trang wash ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(1775), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("d6d90f95-025a-4d3d-b086-8abf42950077"), "F13", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(3132), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Gấp xếp, dán thùng, đai thùng không đạt chất lượng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(3137), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("3ebd05f7-937e-4614-b42e-873fc8250835"), "F14", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(4571), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai tỷ lệ và số lượng trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(4576), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("ba644192-1550-4422-8518-82a549c35ceb"), "W20", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(4360), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(4364), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("ebf5e325-b9e6-43b9-bd57-8cf7f8ee4194"), "F16", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(7458), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(7463), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("8a0f2ab9-efeb-43d9-abea-5d3d39089895"), "F17", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(9086), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 747, DateTimeKind.Local).AddTicks(9091), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("986d920f-2cb8-43f4-9276-7829af5ae501"), "F09", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(7233), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 746, DateTimeKind.Local).AddTicks(7238), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("b1746717-364e-40d0-a7e5-99482b365ff0"), "W19", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(2841), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(2845), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("b5188132-0f73-4a0d-bff4-f4d51ef811f6"), "W13", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(4423), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi dơ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(4429), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("60ab6992-99c4-4bd7-ae2f-56d601c9676f"), "W17", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(121), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(126), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("f21522bd-dbca-4f92-bc89-b3c39de9a61d"), "S19", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(4174), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(4179), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("4fa3cc0d-5ce2-4b49-b98e-af0d62388744"), "S20", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(5533), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(5538), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("07e2a384-ab87-4665-91da-9468ecfde3a6"), "W01", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(7013), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(7018), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("65340e98-339d-4de5-9279-9caa453806f7"), "W03", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(26), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "PP không đạt, đốm PP, cấn wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(32), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("1c87db3c-eb53-4cd8-88d2-248eaebe478c"), "W04", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(1391), 0, "whishkers, grinding,..", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng thời trang không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(1395), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("504f14ee-848e-4eed-8408-4fc984a53c11"), "W05", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(2983), 0, " handsands, destroys,..", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(2988), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("5ae55e7e-de8e-4ed7-8648-306ff624a4fd"), "W06", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(4402), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "3D thiếu hoặc mạnh/yếu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(4406), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("43c5b47d-5646-4166-9e4a-3c9978562d87"), "W07", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(5817), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(5821), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("3b7258f8-5800-486b-9ec9-35b984127e41"), "W08", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(7173), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ mềm không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(7178), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("16105a5b-ede9-40ca-be3f-2f231788756b"), "W09", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(8694), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 743, DateTimeKind.Local).AddTicks(8699), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("ddd7bc31-9678-4001-be4c-87acd5e5340a"), "W10", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(76), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục rách", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(81), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("0afd7554-766d-4840-946c-410999bf02e4"), "W11", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(1485), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(1490), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("9152c4e7-a58f-4f2c-9c3e-1ac996728657"), "W12", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(2828), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi May", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(2833), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("f5b381e5-83d0-4157-8130-969f2a9a14a1"), "F18", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(546), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(551), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("bf3c82f4-0d17-46e3-90ac-799d0c13f488"), "W14", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(5846), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn/ gãy, sờn hoặc cấn bóng bề mặt vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(5851), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("7fa1f18f-f0c8-4985-8500-7144066c9fd7"), "W15", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(7221), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(7226), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("7ba80220-9c93-492c-951a-7cc02db179a1"), "W16", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(8711), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 744, DateTimeKind.Local).AddTicks(8716), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("4a09d734-727c-410e-bf6f-e5c2d99f869e"), "W18", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(1495), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 745, DateTimeKind.Local).AddTicks(1500), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("0c0f1ecb-15ef-4af5-82d6-8fd762676801"), "F19", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(1931), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(1936), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("b34f6142-6703-474a-99e6-ae6fe78b9183"), "PP06", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(1941), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(1945), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("61acf4e1-9ad2-4a22-9233-53994eebe6cf"), "PP01", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(4751), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(4756), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("4a980e50-1b49-4a9d-ba5e-6cbf6fe95d18"), "P04", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(7573), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(7578), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("3a6d0624-c652-4f3d-b4c0-206a18284b0b"), "P05", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(9024), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(9030), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("0d9c544c-0731-407f-ada7-5c44f4b76958"), "P06", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(445), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sử dụng sai phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(451), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("a90900d1-60b7-4cc5-8d45-7726e8e474c5"), "P07", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(1782), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(1786), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("aee94b17-12e9-4e1e-8dcb-aa44893fba4c"), "P08", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(3227), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(3232), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("56aa3ea7-0af1-4667-994d-6599c7d13619"), "P09", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(4582), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(4586), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("82f07a11-f010-4638-8987-c7becd98204e"), "P10", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(6061), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(6065), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("c7aafb86-6632-44e2-b14b-170a1087d1bc"), "P11", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(7388), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(7393), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("78df6ca3-42f6-42db-b0f8-4fcd6a8ee017"), "P12", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(9139), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 752, DateTimeKind.Local).AddTicks(9148), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("6326f19b-805a-4de8-9ec1-d9eb0be9ed5e"), "P13", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(1063), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(1074), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("7c1fe452-9d68-4b80-8825-56f9ee43d619"), "P14", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(2539), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai số lượng và tỷ lệ trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(2544), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("ba4ade46-2179-43d7-a359-4dad62ad5027"), "P15", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(4203), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(4208), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("c8622718-c526-4ab6-ac30-ef98bbc5a937"), "P16", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(5628), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mặc thử không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(5633), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("fd2fceaa-0f1e-452d-a07d-a2290b3a14a6"), "P17", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(6985), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Kỹ thuật may xấu, không phù hợp", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(6990), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("e0cf80a4-8f15-4455-8bd0-e80b0377faa3"), "P18", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(8500), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(8505), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("c496eaba-4c88-4188-a97b-f2579d25af0d"), "P19", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(9874), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 753, DateTimeKind.Local).AddTicks(9878), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("1a883053-243a-42de-8b6c-d171fc6d6f7b"), "P20", new DateTime(2021, 11, 4, 15, 8, 45, 754, DateTimeKind.Local).AddTicks(1270), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 754, DateTimeKind.Local).AddTicks(1275), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("01deded7-8bb4-4c96-9c8d-c32bb80b0462"), "P03", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(6184), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(6189), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("c002ae35-3712-4474-a465-b2363268f0e2"), "P02", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(4791), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(4796), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("8ae4b8d7-ff5a-464e-a8f5-b4dd637560a5"), "P01", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(3428), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vệ sinh công nghiệp, chỉ thừa không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(3433), 0, new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24") },
                    { new Guid("a4ad7fea-2fe1-484e-a791-c917e7b7b20f"), "PP20", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(1949), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(1955), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("df514617-71aa-41e4-88da-617853dc96f0"), "PP02", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(6091), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính dầu máy, dơ, dấu phấn, dấu mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(6096), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("e78b4d2c-add2-43a4-998b-a4279525bc49"), "PP03", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(7493), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(7498), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("66ab9e59-10c3-4df2-9cdc-865db50b47e3"), "PP04", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(8965), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(8971), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("e999334c-afbf-4e31-8e4c-dc434c2ce41b"), "PP05", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(524), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(529), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("dc186850-35da-426d-9d2b-27d99a1be988"), "S18", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(2670), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(2675), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("a44c869e-c29c-4a0d-b128-fd08ab5c2e1b"), "PP07", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(3400), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(3405), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("b53b9fcb-4b2d-4d6d-a915-dcef9d4585e5"), "PP08", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(4748), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(4753), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("37011093-8723-4a26-ae4e-14b01b5e1a05"), "PP09", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(6166), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(6171), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("d73c2b17-a178-4e3e-a479-00766590adbc"), "F20", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(3373), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 748, DateTimeKind.Local).AddTicks(3378), 0, new Guid("cd6aac51-979f-499b-a9bc-55681caf2956") },
                    { new Guid("bbf39b6e-9c41-4e6a-8f96-3c2d5c50bc7a"), "PP10", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(7517), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ánh màu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(7522), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("f7fd49e5-1fd5-4348-8cba-cca708c73677"), "PP12", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(439), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hiệu ứng wash, nhuộm không đồng đều", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(445), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("ba0e8eff-c376-4d12-a173-7626e1984e41"), "PP13", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(1976), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Hình dáng, kích thước, vị trí thời trang wash không đúng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(1982), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("6f9c48c6-4354-4548-a198-db5234870ce4"), "PP14", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(3444), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai số lượng và tỷ lệ trong thùng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(3449), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("50946400-436d-4ab8-85bf-ac4af81d5b49"), "PP15", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(4839), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(4844), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("ac1104fc-1a84-4b4e-9952-a9a133b09e29"), "PP16", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(6190), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mặc thử không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(6194), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("36ce0a13-defd-44f8-a480-d4a3e3554657"), "PP17", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(7602), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Kỹ thuật may xấu, không phù hợp", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(7606), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("622d3363-19c7-4417-b39e-9506ec28d7dd"), "PP18", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(9114), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Chất lượng phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 750, DateTimeKind.Local).AddTicks(9119), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("4333aa09-9046-450d-9f9a-fe40cc010917"), "PP19", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(547), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi Thông số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 751, DateTimeKind.Local).AddTicks(553), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("c488ab91-c490-431b-9ebe-d27b8b02a8ee"), "PP11", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(9065), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cấn wash, đốm wash", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 749, DateTimeKind.Local).AddTicks(9071), 0, new Guid("3fe931f7-728b-48e6-b37c-828f683f9229") },
                    { new Guid("aa92c421-d45b-43b4-8560-016d447b1764"), "S17", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(1197), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(1204), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("54b5629d-68a4-4f2b-82e7-e79a2dbf91fb"), "W02", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(8506), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu, loang màu trong cùng sản phẩm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 742, DateTimeKind.Local).AddTicks(8512), 0, new Guid("1bc43632-e605-4489-8030-f7dad305f00c") },
                    { new Guid("c9495e2d-368d-4037-9e41-15835f27ad1b"), "S15", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(7805), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(7814), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("45b81239-bd35-4d96-882a-3a3aa54aa01a"), "MO07", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(3747), 0, "COLOR / WHITE SPOT", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỐM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(3752), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("6e7aaa0e-c0fb-4d24-920d-3d58fb53549d"), "MO08", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(5132), 0, " KNOT/NAP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "NỐI SỢI , BÔNG TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(5137), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("70c057fb-f28e-4760-9ea7-cd4a71aa8cdd"), "MO09", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(6483), 0, "LOOSE WARP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "LỎNG SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(6488), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("defb0658-e456-427b-b34b-073ca097a2cd"), "MO10", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(7885), 0, "MISPICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "MẤT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(7890), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("d2f3eafb-a6e3-42e1-8c6e-0e417eabb64c"), "MO11", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(9236), 0, "STOP MARK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "DỪNG MÁY", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(9240), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("64d20d00-5c0c-44d8-875f-a0e29adf700a"), "MO12", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(627), 0, "CREASE MARK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "GÃY MẶT VẢI", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(631), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("f84061cf-7998-4411-abca-e06b5627acd4"), "MO13", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(2131), 0, " HOLE ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "THỦNG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(2136), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("54001dc6-c2a2-4989-a3d8-df02f8792764"), "MO14", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(3805), 0, "Print off layout ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LÊCH KHUÔN", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(3811), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("9c99e162-c505-4c33-9284-a81a45c49d9d"), "MO15", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(5385), 0, " PRINT COLOR SMEAR", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LEM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(5391), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("fc655a0e-ce4a-4dbc-b396-582b0920539b"), "MO06", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(2172), 0, "STAIN / DIRTY ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "BIẾN MÀU /DƠ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(2176), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("5f180049-2ef3-4343-9348-44fc7134ddf5"), "MO16", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(6867), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu biên ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(6872), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("f12bf2df-2e65-4634-bdac-45005b999f70"), "MO18", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(9684), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sọc ngang, dọc, sọc nhuộm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(9689), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("f5776f04-52bb-42e6-86d8-1fdc59eadb66"), "MO19", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(1052), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(1057), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("aa672cc7-00b3-45d3-ac6f-d47640bc1e4e"), "MO20", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(2582), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(2587), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("069e37b1-f461-4719-a82e-3b598a808791"), "T01", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(4147), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai từ ngữ, ký hiệu, Logo,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(4152), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("cde57016-554c-422f-b362-d3bfb2045091"), "T02", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(5664), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai chủng loại, chất liệu, hình dạng, kích thước, màu sắc,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(5669), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("bc6daa95-154f-4703-a470-541f74119771"), "T03", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(7016), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nét chữ trên phụ liệu không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(7021), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("8c061da7-0e60-4fae-ac2c-044df74af968"), "S16", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(9350), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(9355), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("b2e79f1f-02c7-4fdf-af12-313dd8d78969"), "T05", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(9859), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu kim loại rà kim không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(9864), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("30586bf0-fd5e-4947-8f4d-e6a97c8f3f2e"), "T06", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(1251), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu  nứt, lủng rách, biến dạng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(1256), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("7cdb9389-1eba-449f-9b37-3ba2b2581fb3"), "MO17", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(8217), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "khác màu đầu cuối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 732, DateTimeKind.Local).AddTicks(8222), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("1c72e192-0ea7-4783-8e22-b0bf16b42f33"), "MO05", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(739), 0, "FOREIGN FIBER ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 731, DateTimeKind.Local).AddTicks(744), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("b0f7f411-0409-4ed6-afc1-23e0c44327bd"), "MO04", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(9157), 0, "COARSE PICK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(9161), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("917756ec-b234-4a19-b09e-410c9b2fdefc"), "MO03", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(7774), 0, "COARSE END ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(7779), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("fb1e8c43-a2b2-400f-b9a3-e87a7f5283e3"), "M02", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(7245), 0, "BROKEN PICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(7252), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("d94f034a-32a7-4525-91a4-e1bc6e3b3e47"), "M03", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(8687), 0, "COARSE END ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 727, DateTimeKind.Local).AddTicks(8691), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("63de8f42-d865-4e99-b762-10d7988f6c29"), "M04", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(98), 0, "COARSE PICK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI THÔ NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(103), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("5d47fb20-91a5-4952-9b31-ebd7d9213e8a"), "M05", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(1487), 0, "FOREIGN FIBER ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "SỢI TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(1492), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("3caf8826-413b-4c1b-b62f-f1e0798b64d6"), "M06", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(2954), 0, "STAIN / DIRTY ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "BIẾN MÀU /DƠ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(2959), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("fd342c1e-8256-448c-a64f-31671662a8e8"), "M07", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(4416), 0, "COLOR / WHITE SPOT", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỐM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(4422), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("50402e19-ad5e-49c5-ba8d-a0fb37aed7d7"), "M08", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(5770), 0, " KNOT/NAP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "NỐI SỢI , BÔNG TẠP", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(5775), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("a598a17a-2bf9-4141-9216-6b325bd194d6"), "M09", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(7423), 0, "LOOSE WARP ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "LỎNG SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(7428), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("4cec5855-674b-4907-bbc2-f38fa0bc9471"), "M10", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(8886), 0, "MISPICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "MẤT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 728, DateTimeKind.Local).AddTicks(8891), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("fd66b978-a3b5-4c4c-808a-6e59c2bb7979"), "M11", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(339), 0, "STOP MARK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "DỪNG MÁY", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(344), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("045e8638-b3e7-4080-8449-7c0d771b0484"), "M12", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(1686), 0, "CREASE MARK ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "GÃY MẶT VẢI", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(1691), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("a0996bac-0885-4831-b51a-e56308647d64"), "M13", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(3244), 0, " HOLE ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "THỦNG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(3250), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("17ada600-8da8-4bff-90c6-ed79ab826464"), "M14", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(4603), 0, "Print off layout ", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LÊCH KHUÔN", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(4608), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("f1cf198e-5e0a-4567-b517-38c52fa0aae5"), "M15", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(6050), 0, " PRINT COLOR SMEAR", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "IN LEM MÀU", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(6055), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("58cd94f2-c12b-4587-a44a-a466bff68ff7"), "M16", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(7407), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu biên ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(7412), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("3c2f3646-bf8f-42d2-9346-73bd31ab2f8d"), "M17", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(9017), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "khác màu đầu cuối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 729, DateTimeKind.Local).AddTicks(9022), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("1bcaf0a2-3f51-40f4-8ec2-7ee6f8e70dd0"), "M18", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(446), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sọc ngang, dọc, sọc nhuộm", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(451), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("ff3befb6-293a-4304-83bd-123627417228"), "M19", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(1919), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(1924), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("38974d29-8c0d-4cd0-8bc1-c7183607022e"), "M20", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(3395), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(3399), 0, new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3") },
                    { new Guid("ad217eef-99e4-4896-8a47-75ed66191aaf"), "MO01", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(4907), 0, "BROKEN END", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI DỌC", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(4912), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("bc1cae34-926c-4d44-a714-204fba921b42"), "MO02", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(6359), 0, "BROKEN PICK", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "ĐỨT SỢI NGANG", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 730, DateTimeKind.Local).AddTicks(6364), 0, new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4") },
                    { new Guid("d02af94b-ed5c-4b57-908a-5c6734dc288a"), "T07", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(2700), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ mềm phụ liệu, ẩm/mốc, mùi hôi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(2706), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("92e7253b-9727-421b-9fdb-7fa87aa67bcf"), "T08", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(4152), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu gỉ sét, trầy xước bề mặt, tróc in, dơ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(4157), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("7addf940-532a-40a9-82d9-87fddb211db1"), "T04", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(8421), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Phụ liệu không an toàn khi sử dụng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 733, DateTimeKind.Local).AddTicks(8426), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("88c150d0-69ca-4dd6-b90a-f9a1d0d14e26"), "T10", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(7106), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Đầu và răng khóa dây kéo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(7110), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("86a16a68-8ac2-4e07-bbd3-2f4855051c11"), "C15", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(3528), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(3533), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("34f723c7-195e-45c7-9fca-360126937eae"), "C16", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(5002), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(5007), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("c742a330-3b39-4ee4-bd2e-cb0a5b9b21a4"), "C17", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(6363), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(6367), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("cec9346d-58fd-456b-b1b3-61fcc875b0df"), "T09", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(5665), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Loang màu, đổi màu, không đồng màu trong lô", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(5670), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("32a2d088-8b1d-4c6b-90d8-89c8bb2bed71"), "C19", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(9216), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(9220), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("e75d4361-2f2e-4465-a1e6-4b8580d70cde"), "C20", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(646), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(651), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("af1d11d4-2c2a-4852-be3e-6782f40954a2"), "S01", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(2156), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nối chỉ không trùng, chỉ thừa, lộ chỉ lược, vệ sinh công nghiệp không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(2161), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("662d4c1d-3b40-4010-a485-c4ae42188348"), "S02", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(3732), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bung chỉ, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(3738), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("fb2449f2-d08b-4c9d-a1d2-abdf171e79f0"), "S03", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(5104), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Nhăn nhíu, vặn, gợn sóng, bai giãn, sụp mí, le mí, xì mép,xếp ly", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(5109), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("8e72f5e9-d726-45cb-8dde-f0c5eda4f283"), "C14", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(2053), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(2058), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("d81de1c7-78ca-4c12-b06e-c03e538efb3b"), "S04", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(6689), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Cao/thấp, không đồng đều đường may, không đối xứng, không đúng dấu/rập", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(6694), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("ee756c46-792f-43fb-b8b5-69153821cf03"), "S06", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(9482), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dính gỉ-sét, dầu máy", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(9486), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("20cee637-7118-477d-bdfa-74e3af01eb6f"), "S07", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(880), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Dơ, dấu phấn, mực", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(884), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("bfd6b73a-b7e3-4cc6-b5c7-97c9b96fc27c"), "S08", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(2285), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Khác màu chi tiết, ráp lộn số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(2289), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("34b65be1-9b79-4ca6-958b-b87044b582d8"), "S09", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(3891), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi ủi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(3896), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("4b494719-2791-434f-9bd6-5f2c5bd47ca2"), "S10", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(5404), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi kỹ thuật, biến dạng form, không phù hợp,..", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(5408), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("e0bd35d2-58a6-4606-936d-d941657cb59c"), "S11", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(6769), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thiếu/ Sai: Phụ liệu, nhãn, bán thành phẩm In, thêu", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 740, DateTimeKind.Local).AddTicks(6774), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("8de24d18-979b-4c8e-bcdf-8e2c266259e2"), "S12", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(427), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(447), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("66b2e2d9-5a07-4c41-9f19-bea8d0bd725c"), "S13", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(3136), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(3156), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("66cefae1-00e3-4ed1-8e34-fe78f4253a20"), "S14", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(5671), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 741, DateTimeKind.Local).AddTicks(5684), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") },
                    { new Guid("4952acc7-634f-4e50-9695-6a4c9d23a253"), "S05", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(8056), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng, rách, lỗ kim", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 739, DateTimeKind.Local).AddTicks(8060), 0, new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087") }
                });

            migrationBuilder.InsertData(
                table: "L01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "IsDeleted", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("64f8806e-abc4-4f22-8ac5-adcaad7b6c1d"), "C13", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(634), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi vải", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(639), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("279cd72b-7890-4138-8784-32388b6c7707"), "C18", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(7809), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 738, DateTimeKind.Local).AddTicks(7814), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("ca78dcf9-075d-4c24-b43a-70bfa26076a1"), "C11", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(7725), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thêu bỏ mũi, đứt chỉ, không khóa mũi", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(7729), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("4a299ef7-24dd-4b20-af12-bf459169d8ab"), "T11", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(8489), 0, "kéo trượt 10 lần", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Độ trượt khóa kéo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(8494), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("9a29c4e9-f124-432f-9055-33af75eb80fe"), "T12", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(9835), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Vặn, xoắn, có nhiều mối nối", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 734, DateTimeKind.Local).AddTicks(9840), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("c1010406-8bb4-4a94-8b8f-fe06391643c5"), "T13", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(1267), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Mối dán ép bao bì không bền chắc", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(1272), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("3fc17845-2a6c-4436-948e-18a48ef15f30"), "T14", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(2784), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(2790), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("2e2f1f15-6e66-42e8-8b00-26359dd0e872"), "C12", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(9110), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lủng rách bán thành phẩm vải/ keo", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(9115), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("bf07b4f8-ee36-4f39-9d98-0d5d23c94d90"), "T16", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(6046), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(6051), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("e3f9c953-183a-4580-b369-d71d1f8e83d0"), "T17", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(7633), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(7638), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("f0e5f7ef-edb4-42a2-b533-40641a682e21"), "T18", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(9057), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(9062), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("3367affc-832b-4275-9edd-f2131f65e0cb"), "T19", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(512), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(517), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("58030543-9367-4afa-b766-e26fed54bdc3"), "T20", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(1866), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Những lỗi khác", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(1871), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("90b51902-9284-4304-b74c-7e77f4886a8e"), "T15", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(4485), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "0", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 735, DateTimeKind.Local).AddTicks(4493), 0, new Guid("f34e7928-c4f0-4f84-95f7-335d73196358") },
                    { new Guid("4f8f9c69-45bd-4194-b50b-3b4b276fa12c"), "C02", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(4797), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Bán thành phẩm cắt lớn hoặc nhỏ hơn rập ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(4802), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("858c6327-d5f3-48f2-a56b-0788b2b3b2b6"), "C03", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(6235), 0, "vải chính, vải lót, keo,…", "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Biến dạng, sai hình dáng, canh sợi, bề mặt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(6240), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("8f3b9041-1f8e-4546-99f6-5f23de51dbf1"), "C04", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(7576), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Thiếu dấu bấm, dấu bấm ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(7582), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("39d81a78-3318-4c85-a56a-3c2063ae8cf7"), "C05", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(9116), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi đánh số", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(9121), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("90251432-fd35-45bc-b16a-14da5f31dd55"), "C06", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(528), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Loang màu chi tiết, dơ, ố", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(533), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("26e28075-3e78-49cf-836a-95d1c00e98f4"), "C07", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(1974), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Ép keo không đạt", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(1979), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("238d92d2-1c2d-4c12-9065-c6979717acec"), "C01", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(3421), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Lỗi hoặc sai sơ đồ cắt, rập cứng", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 736, DateTimeKind.Local).AddTicks(3427), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("99ca7737-3688-4452-808b-370bbd08a932"), "C08", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(3541), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "Sai màu thêu, màu in", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(3546), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("355ebafc-b42f-45c9-b2bd-814dd89f8007"), "C09", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(4956), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "In, thêu thiếu nét, thiếu chữ", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(4961), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") },
                    { new Guid("fbde8163-54e4-4d5f-9c3a-06c28a1d1c88"), "C10", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(6343), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", false, "In, thêu sai vị trí", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 11, 4, 15, 8, 45, 737, DateTimeKind.Local).AddTicks(6348), 0, new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964") }
                });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 711, DateTimeKind.Local).AddTicks(5766), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("1bc43632-e605-4489-8030-f7dad305f00c"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7328), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("3fe931f7-728b-48e6-b37c-828f683f9229"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7336), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7316), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7299), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7344), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7340), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7324), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("cd6aac51-979f-499b-a9bc-55681caf2956"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7332), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("de72a6a9-bd09-48e3-b48e-19494d3ddb43"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7320), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "L01_QCZoneTypeLib",
                keyColumn: "Id",
                keyValue: new Guid("f34e7928-c4f0-4f84-95f7-335d73196358"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7310), new DateTime(2021, 11, 4, 15, 8, 45, 712, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.CreateIndex(
                name: "IX_D01_QCTicket_Code_Name",
                table: "D01_QCTicket",
                columns: new[] { "Code", "Name" });
        }
    }
}
