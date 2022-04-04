using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsedCars.DAL.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Latitude", "Location", "Longitude", "Name" },
                values: new object[] { 1, 47.13111m, "West wing", -61.54801m, "Warehouse A" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Latitude", "Location", "Longitude", "Name" },
                values: new object[] { 2, 15.95386m, "East wing", 7.06246m, "Warehouse B" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Latitude", "Location", "Longitude", "Name" },
                values: new object[] { 3, 39.12788m, "Suid wing", -2.71398m, "Warehouse C" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Latitude", "Location", "Longitude", "Name" },
                values: new object[] { 4, -70.84354m, "Suid wing", 132.22345m, "Warehouse D" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 1, new DateTime(2018, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Volkswagen", "Jetta III", 12947.52m, 1, 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 2, new DateTime(2018, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chevrolet", "Corvette", 20019.64m, 1, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 3, new DateTime(2018, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ford", "Expedition EL", 27323.42m, 1, 2008 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 4, new DateTime(2018, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Infiniti", "FX", 8541.62m, 1, 2010 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 5, new DateTime(2018, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "GMC", "Safari", 14772.5m, 1, 1998 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 6, new DateTime(2018, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Plymouth", "Colt Vista", 6642.45m, 1, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 7, new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cadillac", "Escalade ESV", 24925.75m, 1, 2008 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 8, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mitsubishi", "Pajero", 28619.45m, 1, 2002 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 9, new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Infiniti", "Q", 6103.4m, 1, 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 10, new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ford", "Mustang", 18992.7m, 1, 1993 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 11, new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chevrolet", "G-Series 1500", 23362.41m, 1, 1997 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 12, new DateTime(2018, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cadillac", "DeVille", 18371.53m, 1, 1993 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 13, new DateTime(2018, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Acura", "NSX", 23175.76m, 1, 2001 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 14, new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Ford", "Econoline E250", 26605.54m, 1, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 15, new DateTime(2017, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lexus", "GX", 27395.26m, 1, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 16, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dodge", "Ram Van 3500", 6244.51m, 1, 1999 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 17, new DateTime(2017, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dodge", "Caravan", 16145.27m, 1, 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 18, new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dodge", "Dynasty", 15103.84m, 1, 1992 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 19, new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dodge", "Ram 1500", 9977.65m, 1, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 20, new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Maserati", "Coupe", 19957.71m, 2, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 21, new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Isuzu", "Rodeo", 6303.99m, 2, 1998 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 22, new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Infiniti", "I", 6910.16m, 2, 2002 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 23, new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nissan", "Altima", 8252.66m, 2, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 24, new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Toyota", "Corolla", 23732.11m, 2, 2009 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 25, new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Acura", "MDX", 8487.19m, 2, 2011 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 26, new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "BMW", "7 Series", 29069.52m, 2, 1998 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 27, new DateTime(2018, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nissan", "Maxima", 11187.68m, 2, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 28, new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Audi", "A8", 16047.9m, 2, 1999 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 29, new DateTime(2018, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nissan", "Murano", 25859.78m, 2, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 30, new DateTime(2017, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Acura", "RL", 13232.13m, 2, 2010 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 31, new DateTime(2018, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mitsubishi", "Chariot", 15665.23m, 2, 1987 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 32, new DateTime(2018, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "GMC", "3500 Club Coupe", 18129.37m, 2, 1992 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 33, new DateTime(2017, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dodge", "Dakota", 14479.37m, 2, 2009 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 34, new DateTime(2018, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mercury", "Grand Marquis", 20614.72m, 2, 1996 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 35, new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kia", "Sportage", 27106.47m, 2, 2001 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 36, new DateTime(2017, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chevrolet", "Blazer", 14835.48m, 2, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 37, new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mercedes-Benz", "SL-Class", 27717.28m, 2, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 38, new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Honda", "Civic Si", 18569.86m, 2, 2003 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 39, new DateTime(2018, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mercedes-Benz", "CL-Class", 23494.78m, 2, 2002 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 40, new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Volkswagen", "Jetta", 25469.49m, 2, 2006 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 41, new DateTime(2018, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pontiac", "Grand Prix", 11600.74m, 2, 1975 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 42, new DateTime(2018, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Infiniti", "FX", 22000.62m, 2, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 43, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Jaguar", "XK", 10260.79m, 2, 2006 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 44, new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cadillac", "STS", 13740.2m, 2, 2007 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 45, new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Pontiac", "Sunfire", 28489.1m, 2, 1997 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 46, new DateTime(2018, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Cadillac", "SRX", 26750.38m, 2, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 47, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Land Rover", "Freelander", 21770.59m, 2, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 48, new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Suzuki", "Forenza", 28834.26m, 2, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 49, new DateTime(2018, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Saab", "9-7X", 25975.68m, 2, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 50, new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ford", "Fusion", 28091.96m, 2, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 51, new DateTime(2018, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Cadillac", "Escalade", 7429.18m, 3, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 52, new DateTime(2017, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Porsche", "Cayenne", 17066.31m, 3, 2011 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 53, new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mercedes-Benz", "SL-Class", 14066.06m, 3, 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 54, new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mitsubishi", "RVR", 22560.18m, 3, 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 55, new DateTime(2017, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Volvo", "850", 25762.08m, 3, 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 56, new DateTime(2017, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Honda", "del Sol", 18840.96m, 3, 1994 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 57, new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Infiniti", "Q", 28773.14m, 3, 1996 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 58, new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mercedes-Benz", "500E", 17141.08m, 3, 1992 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 59, new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "GMC", "Envoy XL", 18983.52m, 3, 2002 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 60, new DateTime(2018, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Volkswagen", "Touareg 2", 15611.22m, 3, 2008 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 61, new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Saab", "900", 8771m, 4, 1987 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 62, new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mazda", "B-Series", 23407.59m, 4, 1998 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 63, new DateTime(2018, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "GMC", "Sierra 3500", 5869.23m, 4, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 64, new DateTime(2018, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chevrolet", "Corvette", 16630.67m, 4, 1964 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 65, new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Toyota", "Tacoma", 11597.18m, 4, 1997 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 66, new DateTime(2018, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "GMC", "Sonoma", 18248.21m, 4, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 67, new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bugatti", "Veyron", 8051.64m, 4, 2009 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 68, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dodge", "Ram 1500 Club", 14008.3m, 4, 1996 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 69, new DateTime(2018, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Land Rover", "Discovery Series II", 18620.19m, 4, 2001 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 70, new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Volvo", "960", 7316.93m, 4, 1993 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 71, new DateTime(2017, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chrysler", "LHS", 29444.71m, 4, 2001 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 72, new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Porsche", "944", 7396.95m, 4, 1984 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 73, new DateTime(2017, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Subaru", "Legacy", 24491.8m, 4, 2010 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 74, new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Volvo", "XC90", 29009.65m, 4, 2003 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 75, new DateTime(2018, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Buick", "Skyhawk", 10567.27m, 4, 1985 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 76, new DateTime(2018, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "GMC", "Envoy XUV", 20997.71m, 4, 2004 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 77, new DateTime(2018, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Volvo", "S60", 28614.95m, 4, 2009 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 78, new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Pontiac", "Montana", 11221.14m, 4, 2000 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 79, new DateTime(2018, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lexus", "RX", 23194.01m, 4, 2002 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "Year" },
                values: new object[] { 80, new DateTime(2018, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lexus", "RX", 17805.45m, 4, 2000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
