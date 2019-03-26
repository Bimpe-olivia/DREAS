using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    HouseNo = table.Column<string>(nullable: false),
                    StreetName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    LGA = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CAC = table.Column<string>(nullable: true),
                    ContactPersonnel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enquiries",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PropertyID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    FAQ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquiries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    ServiceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PropertyID = table.Column<Guid>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategories",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Duplex = table.Column<string>(nullable: true),
                    HalfDuplex = table.Column<string>(nullable: true),
                    Terrace = table.Column<string>(nullable: true),
                    Flat = table.Column<string>(nullable: true),
                    RoomNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Referals",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    ReferalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Settlements",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PropertyID = table.Column<Guid>(nullable: false),
                    ReferenceNo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 128, nullable: false),
                    PasswordHash = table.Column<byte[]>(maxLength: 8, nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsBlocked = table.Column<bool>(nullable: false),
                    BlockedDate = table.Column<DateTime>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    AddressID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyLists",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PropertyCategoryID = table.Column<Guid>(nullable: true),
                    PropertyID = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyLists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PropertyLists_PropertyCategories_PropertyCategoryID",
                        column: x => x.PropertyCategoryID,
                        principalTable: "PropertyCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    ActionType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Logs_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EmailID = table.Column<Guid>(nullable: true),
                    PropertyID = table.Column<int>(nullable: false),
                    MessageID = table.Column<Guid>(nullable: true),
                    UserID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notifications_Contacts_EmailID",
                        column: x => x.EmailID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Enquiries_MessageID",
                        column: x => x.MessageID,
                        principalTable: "Enquiries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OwnerID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    ContactID = table.Column<Guid>(nullable: true),
                    CategoryID = table.Column<Guid>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Property_PropertyCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "PropertyCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Users_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryBy = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ContactID = table.Column<Guid>(nullable: true),
                    ReferalCode = table.Column<int>(nullable: false),
                    BVN = table.Column<string>(nullable: true),
                    NIN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressID",
                table: "Contacts",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserID",
                table: "Logs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_EmailID",
                table: "Notifications",
                column: "EmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_MessageID",
                table: "Notifications",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_CategoryID",
                table: "Property",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ContactID",
                table: "Property",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_OwnerID",
                table: "Property",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyLists_PropertyCategoryID",
                table: "PropertyLists",
                column: "PropertyCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_ContactID",
                table: "UserProfiles",
                column: "ContactID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "PropertyLists");

            migrationBuilder.DropTable(
                name: "Referals");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settlements");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Enquiries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PropertyCategories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
