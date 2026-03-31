using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartTradeHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Country", "CreatedAt", "CreditScore", "Email", "IsCompany", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "France", new DateTime(2025, 1, 15, 9, 12, 0, 0, DateTimeKind.Utc), 720, "marie.dupont@example.com", false, "Marie Dupont" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "France", new DateTime(2025, 2, 20, 11, 30, 0, 0, DateTimeKind.Utc), 820, "contact@technova.fr", true, "Société TechNova" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Maroc", new DateTime(2025, 3, 5, 14, 0, 0, 0, DateTimeKind.Utc), 610, "a.benali@example.ma", false, "Ahmed Benali" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "France", new DateTime(2025, 3, 22, 8, 45, 0, 0, DateTimeKind.Utc), 760, "laura.martin@example.com", false, "Laura Martin" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Belgique", new DateTime(2025, 4, 10, 10, 20, 0, 0, DateTimeKind.Utc), 790, "hello@lumina.com", true, "Entreprise Lumina" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "France", new DateTime(2025, 5, 2, 16, 10, 0, 0, DateTimeKind.Utc), 680, "julien.lefevre@example.com", false, "Julien Lefevre" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "France", new DateTime(2025, 6, 18, 9, 0, 0, 0, DateTimeKind.Utc), 740, "contact@horizon.agency", true, "Agence Horizon" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "France", new DateTime(2025, 7, 4, 12, 0, 0, 0, DateTimeKind.Utc), 700, "samantha.roy@example.com", false, "Samantha Roy" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Suisse", new DateTime(2025, 8, 12, 15, 30, 0, 0, DateTimeKind.Utc), 835, "contact@mille1.com", true, "Mille et Une Solutions" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "Côte d'Ivoire", new DateTime(2025, 9, 1, 10, 5, 0, 0, DateTimeKind.Utc), 590, "oumar.traore@example.ci", false, "Oumar Traoré" },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "France", new DateTime(2025, 9, 20, 11, 11, 0, 0, DateTimeKind.Utc), 715, "isabelle.moreau@example.com", false, "Isabelle Moreau" },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "France", new DateTime(2025, 10, 5, 9, 45, 0, 0, DateTimeKind.Utc), 670, "contact@papeterielocale.fr", true, "Papeterie Locale" },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "Portugal", new DateTime(2025, 10, 28, 13, 0, 0, 0, DateTimeKind.Utc), 730, "c.mendes@example.pt", false, "Carlos Mendes" },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "France", new DateTime(2025, 11, 15, 8, 30, 0, 0, DateTimeKind.Utc), 650, "atelier@bois-artisan.fr", true, "Atelier Bois" },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "Tunisie", new DateTime(2025, 12, 2, 17, 20, 0, 0, DateTimeKind.Utc), 605, "nadia.haddad@example.com", false, "Nadia Haddad" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Luxembourg", new DateTime(2026, 1, 8, 10, 10, 0, 0, DateTimeKind.Utc), 780, "events@global-events.com", true, "Global Events SA" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "France", new DateTime(2026, 1, 25, 14, 40, 0, 0, DateTimeKind.Utc), 695, "pierre.gauthier@example.com", false, "Pierre Gauthier" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "France", new DateTime(2026, 2, 11, 9, 0, 0, 0, DateTimeKind.Utc), 710, "admin@les-tilleuls.fr", true, "Ecole Primaire Les Tilleuls" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "France", new DateTime(2026, 3, 1, 8, 0, 0, 0, DateTimeKind.Utc), 725, "valerie.petit@example.com", false, "Valérie Petit" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "France", new DateTime(2026, 3, 15, 18, 30, 0, 0, DateTimeKind.Utc), 760, "studio@lumiere.photo", true, "Studio Photo Lumière" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IsActive", "Name", "PriceHT", "StockQuantity", "VatRate" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Licence 1 an.", true, "Logiciel Antivirus Pro", 39.00m, 1000, 0.20m },
                    { new Guid("11111111-1111-1111-1111-000000000101"), "Clavier mécanique rétroéclairé, switch tactile.", true, "Clavier mécanique K120", 59.90m, 120, 0.20m },
                    { new Guid("12121212-1212-1212-1212-000000000111"), "Kit 32 pièces aimanté.", true, "Coffret tournevis 32 pcs", 22.00m, 180, 0.20m },
                    { new Guid("13131313-1313-1313-1313-000000000112"), "Éclairage LED basse consommation.", true, "Réglette LED 120cm", 34.90m, 65, 0.20m },
                    { new Guid("14141414-1414-1414-1414-000000000113"), "Routeur double bande, parental control.", true, "Routeur Wi-Fi AC1200", 59.00m, 55, 0.20m },
                    { new Guid("15151515-1515-1515-1515-000000000114"), "Table pliante 180x80cm, transport facile.", true, "Table de réunion pliable", 129.00m, 10, 0.20m },
                    { new Guid("22222222-2222-2222-2222-000000000102"), "Souris ergonomique, 2.4GHz et Bluetooth.", true, "Souris sans fil M55", 24.50m, 200, 0.20m },
                    { new Guid("33333333-3333-3333-3333-000000000103"), "Moniteur 24 pouces, 1080p, 75Hz.", true, "Écran 24\" Full HD", 129.00m, 45, 0.20m },
                    { new Guid("44444444-4444-4444-4444-000000000104"), "Casque circum-aural, réduction de bruit.", true, "Casque audio XPro", 89.99m, 60, 0.20m },
                    { new Guid("55555555-5555-5555-5555-000000000105"), "Stockage NVMe haute performance 1TB.", true, "SSD 1To NVMe", 109.00m, 80, 0.20m },
                    { new Guid("66666666-6666-6666-6666-000000000106"), "Lampe de bureau LED dimmable.", true, "Lampe de bureau LED", 29.90m, 150, 0.20m },
                    { new Guid("77777777-7777-7777-7777-000000000107"), "Impression, scan et copie.", true, "Imprimante A4 multifonction", 149.50m, 30, 0.20m },
                    { new Guid("88888888-8888-8888-8888-000000000108"), "Webcam avec micro intégré.", true, "Webcam HD 1080p", 39.95m, 90, 0.20m },
                    { new Guid("99999999-9999-9999-9999-000000000109"), "Chaise de bureau ergonomique avec support lombaire.", true, "Chaise ergonomique Série B", 199.00m, 25, 0.20m },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-00000000010a"), "Hub aluminium, USB-C PD support.", true, "Hub USB-C 7 ports", 49.00m, 70, 0.20m },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-00000000010b"), "Dock Thunderbolt pour 4K et charge.", true, "Station d'accueil 4K", 229.00m, 15, 0.20m },
                    { new Guid("cccccccc-cccc-cccc-cccc-00000000010c"), "Pad Qi rapide 15W.", true, "Chargeur sans fil 15W", 19.90m, 140, 0.20m },
                    { new Guid("dddddddd-dddd-dddd-dddd-00000000010d"), "Sangle résistante pour sport.", true, "Sangle fitness", 12.50m, 300, 0.20m },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-00000000010e"), "Câble haute vitesse 2 mètres.", true, "Câble HDMI 2.1 - 2m", 14.99m, 220, 0.20m },
                    { new Guid("ffffffff-ffff-ffff-ffff-00000000010f"), "Microphone cardioïde pour podcast.", true, "Microphone USB Studio", 79.90m, 40, 0.20m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000101"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12121212-1212-1212-1212-000000000111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13131313-1313-1313-1313-000000000112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14141414-1414-1414-1414-000000000113"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15151515-1515-1515-1515-000000000114"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000102"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-000000000103"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-000000000104"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-000000000105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-000000000106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-000000000107"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-000000000108"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000109"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-00000000010a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-00000000010b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-00000000010c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-00000000010d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-00000000010e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-00000000010f"));
        }
    }
}
