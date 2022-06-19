using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KennisbeursGrimbergen.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Animator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
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
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
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
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Animator", "Date", "Description", "Email", "Location", "Title", "UserId" },
                values: new object[,]
                {
                    { 1L, "Francis Aelbers", "donderdag 07/07/2022	14 - 16.30", "", "f.aelbers@scarlet.be", "Dienstencentrum Ter Borre", "Activiteit Bridge (samenwerking Ter Borre)", 2L },
                    { 2L, "Edwin Van Geert", "Maandag 07/09/2022	14 - 16.30", "", "edwin.van.geert@skynet.be", "Dienstencentrum Ter Borre", "Activiteit Lezingen", 2L },
                    { 3L, "Ivan Van Malderen", "Vrijdag 27/07/2022	14 - 16.30", "", "ivan.van.malderen@telenet.be", "Dienstencentrum Ter Borre", "Activiteit Schaken", 2L }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { 1L, "Welcome", "nl", "Welkom" },
                    { 2L, "Welcome", "fr", "Bienvenue" },
                    { 3L, "Welcome", "en", "Welcome" },
                    { 4L, "Username", "nl", "Gebruikersnaam" },
                    { 5L, "Username", "fr", "Nom d'utilisateur" },
                    { 6L, "Username", "en", "Username" },
                    { 7L, "Email", "nl", "E-mail" },
                    { 8L, "E-mail", "fr", "E-mail" },
                    { 9L, "Email", "en", "Email" },
                    { 10L, "Password", "nl", "Wachtwoord" },
                    { 11L, "Password", "fr", "Mot de passe" },
                    { 12L, "Password", "en", "Password" },
                    { 13L, "Register", "nl", "Registreren" },
                    { 14L, "Register", "fr", "S'inscrire" },
                    { 15L, "Register", "en", "Register" },
                    { 16L, "A user already exist with the same email address.", "nl", "Er bestaat al een gebruiker met hetzelfde e-mailadres." },
                    { 17L, "A user already exist with the same email address.", "fr", "Un utilisateur existe déjà avec la même adresse e-mail." },
                    { 18L, "A user already exist with the same email address.", "en", "A user already exist with the same email address." },
                    { 19L, "Registration sent for approval.", "nl", "Registratie verzonden en in afwachting op goedkeuring." },
                    { 20L, "Registration sent for approval.", "fr", "Inscription envoyée pour approbation." },
                    { 21L, "Registration sent for approval.", "en", "Registration sent for approval." },
                    { 22L, "Registration failed", "nl", "Registratie mislukt" },
                    { 23L, "Registration failed", "fr", "Échec de l'enregistrement" },
                    { 24L, "Registration failed", "en", "Registration failed" },
                    { 25L, "User not found.", "nl", "Gebruiker niet gevonden." },
                    { 26L, "User not found.", "fr", "Utilisateur non trouvé." },
                    { 27L, "User not found.", "en", "User not found." },
                    { 28L, "User registration still processing..", "nl", "Gebruikersregistratie wordt nog verwerkt.." },
                    { 29L, "User registration still processing..", "fr", "L'enregistrement de l'utilisateur est toujours en cours.." },
                    { 30L, "User registration still processing..", "en", "User registration still processing.." },
                    { 31L, "Login failed, make sure to provide the right credentials.", "nl", "Inloggen mislukt, zorg ervoor dat u de juiste inloggegevens opgeeft." },
                    { 32L, "Login failed, make sure to provide the right credentials.", "fr", "La connexion a échoué, assurez-vous de fournir les bons identifiants." },
                    { 33L, "Login failed, make sure to provide the right credentials.", "en", "Login failed, make sure to provide the right credentials." },
                    { 34L, "Sign in", "nl", "Log in" },
                    { 35L, "Sign in", "fr", "S'identifier" },
                    { 36L, "Sign in", "en", "Sign in" },
                    { 37L, "Home", "nl", "Home" },
                    { 38L, "Home", "fr", "Accueil" },
                    { 39L, "Home", "en", "Home" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { 40L, "Manage Users", "nl", "Gebruikers Beheren" },
                    { 41L, "Manage Users", "fr", "Gérer Les Utilisateurs" },
                    { 42L, "Manage Users", "en", "Manage Users" },
                    { 43L, "English", "nl", "Engels" },
                    { 44L, "English", "fr", "Anglais" },
                    { 45L, "English", "en", "English" },
                    { 46L, "Dutch", "nl", "Nederlands" },
                    { 47L, "Dutch", "fr", "Néerlandais" },
                    { 48L, "Dutch", "en", "Dutch" },
                    { 49L, "French", "nl", "Frans" },
                    { 50L, "French", "fr", "Français" },
                    { 51L, "French", "en", "French" },
                    { 52L, "Logout", "nl", "Uitloggen" },
                    { 53L, "Logout", "fr", "Se déconnecter" },
                    { 54L, "Logout", "en", "Logout" },
                    { 55L, "Passwords must have at least one non alphanumeric character.", "nl", "Wachtwoorden moeten ten minste één niet-alfanumeriek teken bevatten." },
                    { 56L, "Passwords must have at least one non alphanumeric character.", "fr", "Les mots de passe doivent comporter au moins un caractère non alphanumérique." },
                    { 57L, "Passwords must have at least one non alphanumeric character.", "en", "Passwords must have at least one non alphanumeric character." },
                    { 58L, "Approve", "nl", "Goedkeuren" },
                    { 59L, "Approve", "fr", "Approuver" },
                    { 60L, "Approve", "en", "Approve" },
                    { 61L, "Reject", "nl", "Afwijzen" },
                    { 62L, "Reject", "fr", "Rejeter" },
                    { 63L, "Reject", "en", "Reject" },
                    { 64L, "User has been approved.", "nl", "Gebruiker is goedgekeurd." },
                    { 65L, "User has been approved.", "fr", "L'utilisateur a été approuvé." },
                    { 66L, "User has been approved.", "en", "User has been approved." },
                    { 67L, "Failed to approve user.", "nl", "Kan gebruiker niet goedkeuren." },
                    { 68L, "Failed to approve user.", "fr", "Échec de l'approbation de l'utilisateur." },
                    { 69L, "Failed to approve user.", "en", "Failed to approve user." },
                    { 70L, "User has been rejected.", "nl", "Gebruiker is afgewezen." },
                    { 71L, "User has been rejected.", "fr", "L'utilisateur a été rejeté." },
                    { 72L, "User has been rejected.", "en", "User has been rejected." },
                    { 73L, "Failed to reject user.", "nl", "Kan gebruiker niet weigeren." },
                    { 74L, "Failed to reject user.", "fr", "Échec du rejet de l'utilisateur." },
                    { 75L, "Failed to reject user.", "en", "Failed to approve user." },
                    { 76L, "Manager Dashboard", "nl", "Beheerdersdashboard" },
                    { 77L, "Manager Dashboard", "fr", "Tableau de bord du gestionnaire" },
                    { 78L, "Manager Dashboard", "en", "Manager Dashboard" },
                    { 79L, "Approve new users and/or set permissions.", "nl", "Nieuwe gebruikers goedkeuren en/of machtigingen instellen." },
                    { 80L, "Approve new users and/or set permissions.", "fr", "Approuver de nouveaux utilisateurs et/ou définir des autorisations." },
                    { 81L, "Approve new users and/or set permissions.", "en", "Approve new users and/or set permissions." }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { 82L, "Permissions", "nl", "Rechten" },
                    { 83L, "Permissions", "fr", "Autorisations" },
                    { 84L, "Permissions", "en", "Permissions" },
                    { 85L, "Approved", "nl", "Goedgekeurd" },
                    { 86L, "Approved", "fr", "Approuvée" },
                    { 87L, "Approved", "en", "Approved" },
                    { 88L, "User", "nl", "Gebruiker" },
                    { 89L, "User", "fr", "Utilisateur/Utilisatrice" },
                    { 90L, "User", "en", "User" },
                    { 91L, "Manager", "nl", "Beheerder" },
                    { 92L, "Manager", "fr", "Gestionnaire" },
                    { 93L, "Manager", "en", "Manager" },
                    { 94L, "Admin", "nl", "Admin" },
                    { 95L, "Admin", "fr", "Admin" },
                    { 96L, "Admin", "en", "Admin" },
                    { 97L, "Update", "nl", "Update" },
                    { 98L, "Update", "fr", "Modifier" },
                    { 99L, "Update", "en", "Update" },
                    { 100L, "User's permissions has been updated.", "nl", "De machtigingen van de gebruiker zijn bijgewerkt." },
                    { 101L, "User's permissions has been updated.", "fr", "Les autorisations de l'utilisateur ont été mises à jour." },
                    { 102L, "User's permissions has been updated.", "en", "User's permissions has been updated." },
                    { 103L, "Failed to update user's permissions.", "nl", "Kan gebruikersrechten niet updaten." },
                    { 104L, "Failed to update user's permissions.", "fr", "Échec de la mise à jour des autorisations de l'utilisateur." },
                    { 105L, "Failed to update user's permissions.", "en", "Update" },
                    { 106L, "User (Read Only)", "nl", "Gebruiker (Read Only)" },
                    { 107L, "User (Read Only)", "fr", "Utilisateur/Utilisatrice (lecture seule)" },
                    { 108L, "User (Read Only)", "en", "User (Read Only)" },
                    { 109L, "Cancel", "nl", "Annuleren" },
                    { 110L, "Cancel", "fr", "Annuler" },
                    { 111L, "Cancel", "en", "Cancel" },
                    { 112L, "Objectives", "nl", "Doelstellingen" },
                    { 113L, "Objectives", "fr", "Objectifs" },
                    { 114L, "Objectives", "en", "Objectives" },
                    { 115L, "Management", "nl", "Bestuur" },
                    { 116L, "Management", "fr", "Gestion" },
                    { 117L, "Management", "en", "Management" },
                    { 118L, "Activities", "nl", "Activiteiten" },
                    { 119L, "Activities", "fr", "Activités" },
                    { 120L, "Activities", "en", "Activities" },
                    { 121L, "Links", "nl", "Links" },
                    { 122L, "Links", "fr", "Liens" },
                    { 123L, "Links", "en", "Links" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { 124L, "Objectives and method", "nl", "Doelstellingen en werkwijze" },
                    { 125L, "Objectives and method", "fr", "Objectifs et méthode" },
                    { 126L, "Objectives and method", "en", "Objectives and method" },
                    { 127L, "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.", "nl", "Iedereen die uit het actieve beroepsleven stapt doet dit met een pak kennis en vaardigheden. Het is de bedoeling van de Kennisbeurs om dit uit te wisselen : wat men weet doorgeven aan anderen en van die anderen interessante kennis of kunde capteren. Er wordt ook ruimschoots de mogelijkheid geboden om nieuwe sociale contacten op te bouwen na het wegvallen van de beroepsactiviteiten." },
                    { 128L, "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.", "fr", "Quiconque quitte la vie professionnelle active le fait avec beaucoup de connaissances et de compétences. Le but de l'échange de connaissances est d'échanger cela : transmettre ce que l'on sait à d'autres et capter des connaissances ou des compétences intéressantes de ces autres. Il existe également de nombreuses possibilités de nouer de nouveaux contacts sociaux après la cessation des activités professionnelles." },
                    { 129L, "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.", "en", "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities." },
                    { 130L, "Our motto is therefore", "nl", "Ons motto is dan ook" },
                    { 131L, "Our motto is therefore", "fr", "Notre devise est donc" },
                    { 132L, "Our motto is therefore", "en", "Our motto is therefore" },
                    { 133L, "Giving Knowledge, Taking Knowledge and Making Acquaintances.", "nl", "Kennis geven, Kennis nemen en Kennissen maken." },
                    { 134L, "Giving Knowledge, Taking Knowledge and Making Acquaintances.", "fr", "Donner des connaissances, prendre des connaissances et faire des connaissances." },
                    { 135L, "Giving Knowledge, Taking Knowledge and Making Acquaintances.", "en", "Giving Knowledge, Taking Knowledge and Making Acquaintances." },
                    { 136L, "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.", "nl", "De lezingen niet te na gesproken, gebeuren de activiteiten in kleine groepen, zodat iedereen actief kan deelnemen. Elke groep staat onder de leiding van een animator die de deelnemers bijeenroept, begeleidt en zorgt voor de faciliteiten. Het programma bepalen de leden in grote mate zelf. Het welslagen hangt dus niet alleen af van de animatoren maar ook van de deelnemers, waarvan verwacht wordt dat ze een actieve inbreng leveren. Wordt een groep te talrijk, dan wordt overgegaan tot splitsing ervan. Aldus zorgt men ervoor dat elkeen aan bod komt." },
                    { 137L, "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.", "fr", "En dehors des conférences, les activités se déroulent en petits groupes, afin que chacun puisse participer activement. Chaque groupe est animé par un animateur qui convoque les participants, encadre et entretient les installations. Le programme est largement déterminé par les membres eux-mêmes. Le succès dépend donc non seulement des animateurs mais aussi des participants, dont on attend une contribution active. Si un groupe devient trop nombreux, il est divisé. Cela garantit que tout le monde est couvert." },
                    { 138L, "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.", "en", "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered." },
                    { 139L, "Sister Associations", "nl", "Zusterverenigingen" },
                    { 140L, "Sister Associations", "fr", "Associations Sœurs" },
                    { 141L, "Sister Associations", "en", "Sister Associations" },
                    { 142L, "Executive Committee", "nl", "Zusterverenigingen" },
                    { 143L, "Executive Committee", "fr", "Associations Sœurs" },
                    { 144L, "Executive Committee", "en", "Executive Committee" },
                    { 145L, "Function", "nl", "Functie" },
                    { 146L, "Function", "fr", "Fonction" },
                    { 147L, "Function", "en", "Function" },
                    { 148L, "Information", "nl", "Informatie" },
                    { 149L, "Information", "fr", "Information" },
                    { 150L, "Information", "en", "Information" },
                    { 151L, "Chair", "nl", "Voorzitter" },
                    { 152L, "Chair", "fr", "Président" },
                    { 153L, "Chair", "en", "Chair" },
                    { 154L, "Secretary", "nl", "Secretaris" },
                    { 155L, "Secretary", "fr", "Secrétaire" },
                    { 156L, "Secretary", "en", "Secretary" },
                    { 157L, "Treasurer", "nl", "Penningmeester" },
                    { 158L, "Treasurer", "fr", "Trésorière/Trésorier" },
                    { 159L, "Treasurer", "en", "Treasurer" },
                    { 160L, "Send mail", "nl", "Verzend mail" },
                    { 161L, "Send mail", "fr", "Envoyer un mail" },
                    { 162L, "Send mail", "en", "Send mail" },
                    { 163L, "Activity", "nl", "Activiteit" },
                    { 164L, "Activity", "fr", "Activité" },
                    { 165L, "Activity", "en", "Activity" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { 166L, "Title", "nl", "Titel" },
                    { 167L, "Title", "fr", "Titre" },
                    { 168L, "Title", "en", "Title" },
                    { 169L, "Description", "nl", "Beschrijving" },
                    { 170L, "Description", "fr", "Description" },
                    { 171L, "Description", "en", "Description" },
                    { 172L, "Animator", "nl", "Animator" },
                    { 173L, "Animator", "fr", "Animateur" },
                    { 174L, "Animator", "en", "Animator" },
                    { 175L, "Date", "nl", "Datum" },
                    { 176L, "Date", "fr", "Date" },
                    { 177L, "Date", "en", "Date" },
                    { 178L, "Location", "nl", "Plaats" },
                    { 179L, "Location", "fr", "Lieu" },
                    { 180L, "Location", "en", "Location" },
                    { 181L, "Create", "nl", "Creëren" },
                    { 182L, "Create", "fr", "Créer" },
                    { 183L, "Create", "en", "Create" },
                    { 184L, "Create new", "nl", "Maak nieuw" },
                    { 185L, "Create new", "fr", "Créer une nouvelle" },
                    { 186L, "Create new", "en", "Create new" },
                    { 187L, "Read more..", "nl", "Lees verder.." },
                    { 188L, "Read more..", "fr", "Lire la suite.." },
                    { 189L, "Read more..", "en", "Read more.." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

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
                name: "Translations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
