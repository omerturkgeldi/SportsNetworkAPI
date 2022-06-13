using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SportsNetwork.Repository.Migrations
{
    public partial class initialmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "iliski_statuleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tip = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iliski_statuleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loglar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Application = table.Column<string>(type: "text", nullable: true),
                    MachineName = table.Column<string>(type: "text", nullable: true),
                    Logged = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Logger = table.Column<string>(type: "text", nullable: true),
                    Callsite = table.Column<string>(type: "text", nullable: true),
                    Exception = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loglar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlakaNo = table.Column<string>(type: "text", nullable: false),
                    SehirIsmi = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sehirler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sporlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Isim = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sporlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bildirimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BildirimBasligi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    BildirimTip = table.Column<string>(type: "text", nullable: true),
                    BildirimIcerik = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    EkleyenKullaniciFk = table.Column<string>(type: "text", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bildirimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bildirimler_AspNetUsers_EkleyenKullaniciFk",
                        column: x => x.EkleyenKullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gruplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OlusturanKullaniciFk = table.Column<string>(type: "text", nullable: false),
                    GrupIsmi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    KullaniciFk = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gruplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gruplar_AspNetUsers_OlusturanKullaniciFk",
                        column: x => x.OlusturanKullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ozel_mesajlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kullanici1Fk = table.Column<string>(type: "text", nullable: false),
                    Kullanici2Fk = table.Column<string>(type: "text", nullable: false),
                    Mesaj = table.Column<string>(type: "text", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ozel_mesajlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ozel_mesajlar_AspNetUsers_Kullanici1Fk",
                        column: x => x.Kullanici1Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ozel_mesajlar_AspNetUsers_Kullanici2Fk",
                        column: x => x.Kullanici2Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "puanlamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kullanici1Fk = table.Column<string>(type: "text", nullable: false),
                    Kullanici2Fk = table.Column<string>(type: "text", nullable: false),
                    Puan = table.Column<byte>(type: "smallint", nullable: false),
                    Yorum = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puanlamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_puanlamalar_AspNetUsers_Kullanici1Fk",
                        column: x => x.Kullanici1Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_puanlamalar_AspNetUsers_Kullanici2Fk",
                        column: x => x.Kullanici2Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRefreshTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Expiration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshTokens", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserRefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "iliskiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kullanici1Fk = table.Column<string>(type: "text", nullable: false),
                    Kullanici2Fk = table.Column<string>(type: "text", nullable: false),
                    IliskiStatuFk = table.Column<int>(type: "integer", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iliskiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_iliskiler_AspNetUsers_Kullanici1Fk",
                        column: x => x.Kullanici1Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_iliskiler_AspNetUsers_Kullanici2Fk",
                        column: x => x.Kullanici2Fk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_iliskiler_iliski_statuleri_IliskiStatuFk",
                        column: x => x.IliskiStatuFk,
                        principalTable: "iliski_statuleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tesisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Isim = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    TesisSahibiFk = table.Column<string>(type: "text", nullable: false),
                    SehirFk = table.Column<int>(type: "integer", nullable: false),
                    Konum = table.Column<string>(type: "text", nullable: true),
                    KonumAdres = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tesisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tesisler_AspNetUsers_TesisSahibiFk",
                        column: x => x.TesisSahibiFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tesisler_sehirler_SehirFk",
                        column: x => x.SehirFk,
                        principalTable: "sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OlusturanKullaniciFk = table.Column<string>(type: "text", nullable: false),
                    Isim = table.Column<string>(type: "text", nullable: false),
                    SporFk = table.Column<int>(type: "integer", nullable: false),
                    SehirFk = table.Column<int>(type: "integer", nullable: false),
                    Durum = table.Column<byte>(type: "smallint", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etkinlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etkinlikler_AspNetUsers_OlusturanKullaniciFk",
                        column: x => x.OlusturanKullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlikler_sehirler_SehirFk",
                        column: x => x.SehirFk,
                        principalTable: "sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlikler_sporlar_SporFk",
                        column: x => x.SporFk,
                        principalTable: "sporlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kullanici_bildirimleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BildirimFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    OkunduMu = table.Column<bool>(type: "boolean", nullable: false),
                    IletilmeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OkunmaTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanici_bildirimleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kullanici_bildirimleri_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kullanici_bildirimleri_bildirimler_BildirimFk",
                        column: x => x.BildirimFk,
                        principalTable: "bildirimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grup_kullanicilari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrupFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    AdminMi = table.Column<bool>(type: "boolean", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grup_kullanicilari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_grup_kullanicilari_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_grup_kullanicilari_gruplar_GrupFk",
                        column: x => x.GrupFk,
                        principalTable: "gruplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grup_mesajlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrupFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    Mesaj = table.Column<string>(type: "text", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grup_mesajlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_grup_mesajlari_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_grup_mesajlari_gruplar_GrupFk",
                        column: x => x.GrupFk,
                        principalTable: "gruplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EgitmenFk = table.Column<string>(type: "text", nullable: false),
                    SehirFk = table.Column<int>(type: "integer", nullable: false),
                    TesisFk = table.Column<int>(type: "integer", nullable: false),
                    SporFk = table.Column<int>(type: "integer", nullable: false),
                    Baslik = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Aciklama = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Konum = table.Column<string>(type: "text", nullable: true),
                    KonumIsmi = table.Column<string>(type: "text", nullable: true),
                    SaatlikUcret = table.Column<decimal>(type: "numeric", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dersler_AspNetUsers_EgitmenFk",
                        column: x => x.EgitmenFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dersler_sehirler_SehirFk",
                        column: x => x.SehirFk,
                        principalTable: "sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dersler_sporlar_SporFk",
                        column: x => x.SporFk,
                        principalTable: "sporlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dersler_tesisler_TesisFk",
                        column: x => x.TesisFk,
                        principalTable: "tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tesis_rezervasyonlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TesisFk = table.Column<int>(type: "integer", nullable: false),
                    RezerveEdenKullaniciFk = table.Column<string>(type: "text", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Onay = table.Column<bool>(type: "boolean", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tesis_rezervasyonlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tesis_rezervasyonlari_AspNetUsers_RezerveEdenKullaniciFk",
                        column: x => x.RezerveEdenKullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tesis_rezervasyonlari_tesisler_TesisFk",
                        column: x => x.TesisFk,
                        principalTable: "tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tesis_yorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TesisFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    Yorum = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tesis_yorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tesis_yorumlari_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tesis_yorumlari_tesisler_TesisFk",
                        column: x => x.TesisFk,
                        principalTable: "tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etkinlik_detaylari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EtkinlikFk = table.Column<int>(type: "integer", nullable: false),
                    TesisFk = table.Column<int>(type: "integer", nullable: false),
                    Konum = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    Seviye = table.Column<byte>(type: "smallint", nullable: false),
                    KonumIsmi = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etkinlik_detaylari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etkinlik_detaylari_etkinlikler_EtkinlikFk",
                        column: x => x.EtkinlikFk,
                        principalTable: "etkinlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlik_detaylari_tesisler_TesisFk",
                        column: x => x.TesisFk,
                        principalTable: "tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etkinlik_katilimcilari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EtkinlikFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etkinlik_katilimcilari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etkinlik_katilimcilari_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlik_katilimcilari_etkinlikler_EtkinlikFk",
                        column: x => x.EtkinlikFk,
                        principalTable: "etkinlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etkinlik_yorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EtkinlikFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    Yorum = table.Column<string>(type: "text", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etkinlik_yorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etkinlik_yorumlari_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlik_yorumlari_etkinlikler_EtkinlikFk",
                        column: x => x.EtkinlikFk,
                        principalTable: "etkinlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sonuclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    EtkinlikFk = table.Column<int>(type: "integer", nullable: false),
                    SporFk = table.Column<int>(type: "integer", nullable: false),
                    SonucJson = table.Column<string>(type: "jsonb", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sonuclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sonuclar_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sonuclar_etkinlikler_EtkinlikFk",
                        column: x => x.EtkinlikFk,
                        principalTable: "etkinlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sonuclar_sporlar_SporFk",
                        column: x => x.SporFk,
                        principalTable: "sporlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ders_rezervasyonlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DersFk = table.Column<int>(type: "integer", nullable: false),
                    KursiyerKullaniciFk = table.Column<string>(type: "text", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Onay = table.Column<bool>(type: "boolean", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ders_rezervasyonlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ders_rezervasyonlari_AspNetUsers_KursiyerKullaniciFk",
                        column: x => x.KursiyerKullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ders_rezervasyonlari_dersler_DersFk",
                        column: x => x.DersFk,
                        principalTable: "dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tesis_yorum_begenileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TesisYorumFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tesis_yorum_begenileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tesis_yorum_begenileri_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tesis_yorum_begenileri_tesis_yorumlari_TesisYorumFk",
                        column: x => x.TesisYorumFk,
                        principalTable: "tesis_yorumlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etkinlik_yorum_begenileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EtkinlikFk = table.Column<int>(type: "integer", nullable: false),
                    KullaniciFk = table.Column<string>(type: "text", nullable: false),
                    EtkinlikYorumId = table.Column<int>(type: "integer", nullable: true),
                    OlusturulanTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SilindiMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etkinlik_yorum_begenileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etkinlik_yorum_begenileri_AspNetUsers_KullaniciFk",
                        column: x => x.KullaniciFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etkinlik_yorum_begenileri_etkinlik_yorumlari_EtkinlikYorumId",
                        column: x => x.EtkinlikYorumId,
                        principalTable: "etkinlik_yorumlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_etkinlik_yorum_begenileri_etkinlikler_EtkinlikFk",
                        column: x => x.EtkinlikFk,
                        principalTable: "etkinlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_bildirimler_EkleyenKullaniciFk",
                table: "bildirimler",
                column: "EkleyenKullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_ders_rezervasyonlari_DersFk",
                table: "ders_rezervasyonlari",
                column: "DersFk");

            migrationBuilder.CreateIndex(
                name: "IX_ders_rezervasyonlari_KursiyerKullaniciFk",
                table: "ders_rezervasyonlari",
                column: "KursiyerKullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_dersler_EgitmenFk",
                table: "dersler",
                column: "EgitmenFk");

            migrationBuilder.CreateIndex(
                name: "IX_dersler_SehirFk",
                table: "dersler",
                column: "SehirFk");

            migrationBuilder.CreateIndex(
                name: "IX_dersler_SporFk",
                table: "dersler",
                column: "SporFk");

            migrationBuilder.CreateIndex(
                name: "IX_dersler_TesisFk",
                table: "dersler",
                column: "TesisFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_detaylari_EtkinlikFk",
                table: "etkinlik_detaylari",
                column: "EtkinlikFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_detaylari_TesisFk",
                table: "etkinlik_detaylari",
                column: "TesisFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_katilimcilari_EtkinlikFk",
                table: "etkinlik_katilimcilari",
                column: "EtkinlikFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_katilimcilari_KullaniciFk",
                table: "etkinlik_katilimcilari",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_yorum_begenileri_EtkinlikFk",
                table: "etkinlik_yorum_begenileri",
                column: "EtkinlikFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_yorum_begenileri_EtkinlikYorumId",
                table: "etkinlik_yorum_begenileri",
                column: "EtkinlikYorumId");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_yorum_begenileri_KullaniciFk",
                table: "etkinlik_yorum_begenileri",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_yorumlari_EtkinlikFk",
                table: "etkinlik_yorumlari",
                column: "EtkinlikFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlik_yorumlari_KullaniciFk",
                table: "etkinlik_yorumlari",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlikler_OlusturanKullaniciFk",
                table: "etkinlikler",
                column: "OlusturanKullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlikler_SehirFk",
                table: "etkinlikler",
                column: "SehirFk");

            migrationBuilder.CreateIndex(
                name: "IX_etkinlikler_SporFk",
                table: "etkinlikler",
                column: "SporFk");

            migrationBuilder.CreateIndex(
                name: "IX_grup_kullanicilari_GrupFk",
                table: "grup_kullanicilari",
                column: "GrupFk");

            migrationBuilder.CreateIndex(
                name: "IX_grup_kullanicilari_KullaniciFk",
                table: "grup_kullanicilari",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_grup_mesajlari_GrupFk",
                table: "grup_mesajlari",
                column: "GrupFk");

            migrationBuilder.CreateIndex(
                name: "IX_grup_mesajlari_KullaniciFk",
                table: "grup_mesajlari",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_gruplar_OlusturanKullaniciFk",
                table: "gruplar",
                column: "OlusturanKullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_iliskiler_IliskiStatuFk",
                table: "iliskiler",
                column: "IliskiStatuFk");

            migrationBuilder.CreateIndex(
                name: "IX_iliskiler_Kullanici1Fk",
                table: "iliskiler",
                column: "Kullanici1Fk");

            migrationBuilder.CreateIndex(
                name: "IX_iliskiler_Kullanici2Fk",
                table: "iliskiler",
                column: "Kullanici2Fk");

            migrationBuilder.CreateIndex(
                name: "IX_kullanici_bildirimleri_BildirimFk",
                table: "kullanici_bildirimleri",
                column: "BildirimFk");

            migrationBuilder.CreateIndex(
                name: "IX_kullanici_bildirimleri_KullaniciFk",
                table: "kullanici_bildirimleri",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_ozel_mesajlar_Kullanici1Fk",
                table: "ozel_mesajlar",
                column: "Kullanici1Fk");

            migrationBuilder.CreateIndex(
                name: "IX_ozel_mesajlar_Kullanici2Fk",
                table: "ozel_mesajlar",
                column: "Kullanici2Fk");

            migrationBuilder.CreateIndex(
                name: "IX_puanlamalar_Kullanici1Fk",
                table: "puanlamalar",
                column: "Kullanici1Fk");

            migrationBuilder.CreateIndex(
                name: "IX_puanlamalar_Kullanici2Fk",
                table: "puanlamalar",
                column: "Kullanici2Fk");

            migrationBuilder.CreateIndex(
                name: "IX_sehirler_PlakaNo",
                table: "sehirler",
                column: "PlakaNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sonuclar_EtkinlikFk",
                table: "sonuclar",
                column: "EtkinlikFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sonuclar_KullaniciFk",
                table: "sonuclar",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_sonuclar_SporFk",
                table: "sonuclar",
                column: "SporFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_rezervasyonlari_RezerveEdenKullaniciFk",
                table: "tesis_rezervasyonlari",
                column: "RezerveEdenKullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_rezervasyonlari_TesisFk",
                table: "tesis_rezervasyonlari",
                column: "TesisFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_yorum_begenileri_KullaniciFk",
                table: "tesis_yorum_begenileri",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_yorum_begenileri_TesisYorumFk",
                table: "tesis_yorum_begenileri",
                column: "TesisYorumFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_yorumlari_KullaniciFk",
                table: "tesis_yorumlari",
                column: "KullaniciFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesis_yorumlari_TesisFk",
                table: "tesis_yorumlari",
                column: "TesisFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesisler_SehirFk",
                table: "tesisler",
                column: "SehirFk");

            migrationBuilder.CreateIndex(
                name: "IX_tesisler_TesisSahibiFk",
                table: "tesisler",
                column: "TesisSahibiFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ders_rezervasyonlari");

            migrationBuilder.DropTable(
                name: "etkinlik_detaylari");

            migrationBuilder.DropTable(
                name: "etkinlik_katilimcilari");

            migrationBuilder.DropTable(
                name: "etkinlik_yorum_begenileri");

            migrationBuilder.DropTable(
                name: "grup_kullanicilari");

            migrationBuilder.DropTable(
                name: "grup_mesajlari");

            migrationBuilder.DropTable(
                name: "iliskiler");

            migrationBuilder.DropTable(
                name: "kullanici_bildirimleri");

            migrationBuilder.DropTable(
                name: "Loglar");

            migrationBuilder.DropTable(
                name: "ozel_mesajlar");

            migrationBuilder.DropTable(
                name: "puanlamalar");

            migrationBuilder.DropTable(
                name: "sonuclar");

            migrationBuilder.DropTable(
                name: "tesis_rezervasyonlari");

            migrationBuilder.DropTable(
                name: "tesis_yorum_begenileri");

            migrationBuilder.DropTable(
                name: "UserRefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "dersler");

            migrationBuilder.DropTable(
                name: "etkinlik_yorumlari");

            migrationBuilder.DropTable(
                name: "gruplar");

            migrationBuilder.DropTable(
                name: "iliski_statuleri");

            migrationBuilder.DropTable(
                name: "bildirimler");

            migrationBuilder.DropTable(
                name: "tesis_yorumlari");

            migrationBuilder.DropTable(
                name: "etkinlikler");

            migrationBuilder.DropTable(
                name: "tesisler");

            migrationBuilder.DropTable(
                name: "sporlar");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "sehirler");
        }
    }
}
