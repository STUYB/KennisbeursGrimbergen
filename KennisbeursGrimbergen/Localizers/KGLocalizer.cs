using KennisbeursGrimbergen.Entities;

namespace KennisbeursGrimbergen.Localizers;

public class KGLocalizer
{
    public static Translation[] DefaultTranslations()
    {
        var translations = new Translation[]
        {
            //**************************************************//
            new Translation
            {
                Id = 1,
                Key = "Welcome",
                Value = "Welkom",
                Language = "nl"
            },
            new Translation
            {
                Id = 2,
                Key = "Welcome",
                Value = "Bienvenue",
                Language = "fr"
            },
            new Translation
            {
                Id = 3,
                Key = "Welcome",
                Value = "Welcome",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 4,
                Key = "Username",
                Value = "Gebruikersnaam",
                Language = "nl"
            },
            new Translation
            {
                Id = 5,
                Key = "Username",
                Value = "Nom d'utilisateur",
                Language = "fr"
            },
            new Translation
            {
                Id = 6,
                Key = "Username",
                Value = "Username",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 7,
                Key = "Email",
                Value = "E-mail",
                Language = "nl"
            },
            new Translation
            {
                Id = 8,
                Key = "E-mail",
                Value = "E-mail",
                Language = "fr"
            },
            new Translation
            {
                Id = 9,
                Key = "Email",
                Value = "Email",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 10,
                Key = "Password",
                Value = "Wachtwoord",
                Language = "nl"
            },
            new Translation
            {
                Id = 11,
                Key = "Password",
                Value = "Mot de passe",
                Language = "fr"
            },
            new Translation
            {
                Id = 12,
                Key = "Password",
                Value = "Password",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 13,
                Key = "Register",
                Value = "Registreren",
                Language = "nl"
            },
            new Translation
            {
                Id = 14,
                Key = "Register",
                Value = "S'inscrire",
                Language = "fr"
            },
            new Translation
            {
                Id = 15,
                Key = "Register",
                Value = "Register",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 16,
                Key = "A user already exist with the same email address.",
                Value = "Er bestaat al een gebruiker met hetzelfde e-mailadres.",
                Language = "nl"
            },
            new Translation
            {
                Id = 17,
                Key = "A user already exist with the same email address.",
                Value = "Un utilisateur existe déjà avec la même adresse e-mail.",
                Language = "fr"
            },
            new Translation
            {
                Id = 18,
                Key = "A user already exist with the same email address.",
                Value = "A user already exist with the same email address.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 19,
                Key = "Registration sent for approval.",
                Value = "Registratie verzonden en in afwachting op goedkeuring.",
                Language = "nl"
            },
            new Translation
            {
                Id = 20,
                Key = "Registration sent for approval.",
                Value = "Inscription envoyée pour approbation.",
                Language = "fr"
            },
            new Translation
            {
                Id = 21,
                Key = "Registration sent for approval.",
                Value = "Registration sent for approval.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 22,
                Key = "Registration failed",
                Value = "Registratie mislukt",
                Language = "nl"
            },
            new Translation
            {
                Id = 23,
                Key = "Registration failed",
                Value = "Échec de l'enregistrement",
                Language = "fr"
            },
            new Translation
            {
                Id = 24,
                Key = "Registration failed",
                Value = "Registration failed",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 25,
                Key = "User not found.",
                Value = "Gebruiker niet gevonden.",
                Language = "nl"
            },
            new Translation
            {
                Id = 26,
                Key = "User not found.",
                Value = "Utilisateur non trouvé.",
                Language = "fr"
            },
            new Translation
            {
                Id = 27,
                Key = "User not found.",
                Value = "User not found.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 28,
                Key = "User registration still processing..",
                Value = "Gebruikersregistratie wordt nog verwerkt..",
                Language = "nl"
            },
            new Translation
            {
                Id = 29,
                Key = "User registration still processing..",
                Value = "L'enregistrement de l'utilisateur est toujours en cours..",
                Language = "fr"
            },
            new Translation
            {
                Id = 30,
                Key = "User registration still processing..",
                Value = "User registration still processing..",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 31,
                Key = "Login failed, make sure to provide the right credentials.",
                Value = "Inloggen mislukt, zorg ervoor dat u de juiste inloggegevens opgeeft.",
                Language = "nl"
            },
            new Translation
            {
                Id = 32,
                Key = "Login failed, make sure to provide the right credentials.",
                Value = "La connexion a échoué, assurez-vous de fournir les bons identifiants.",
                Language = "fr"
            },
            new Translation
            {
                Id = 33,
                Key = "Login failed, make sure to provide the right credentials.",
                Value = "Login failed, make sure to provide the right credentials.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 34,
                Key = "Sign in",
                Value = "Log in",
                Language = "nl"
            },
            new Translation
            {
                Id = 35,
                Key = "Sign in",
                Value = "S'identifier",
                Language = "fr"
            },
            new Translation
            {
                Id = 36,
                Key = "Sign in",
                Value = "Sign in",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 37,
                Key = "Home",
                Value = "Home",
                Language = "nl"
            },
            new Translation
            {
                Id = 38,
                Key = "Home",
                Value = "Accueil",
                Language = "fr"
            },
            new Translation
            {
                Id = 39,
                Key = "Home",
                Value = "Home",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 40,
                Key = "Manage Users",
                Value = "Gebruikers Beheren",
                Language = "nl"
            },
            new Translation
            {
                Id = 41,
                Key = "Manage Users",
                Value = "Gérer Les Utilisateurs",
                Language = "fr"
            },
            new Translation
            {
                Id = 42,
                Key = "Manage Users",
                Value = "Manage Users",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 43,
                Key = "English",
                Value = "Engels",
                Language = "nl"
            },
            new Translation
            {
                Id = 44,
                Key = "English",
                Value = "Anglais",
                Language = "fr"
            },
            new Translation
            {
                Id = 45,
                Key = "English",
                Value = "English",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 46,
                Key = "Dutch",
                Value = "Nederlands",
                Language = "nl"
            },
            new Translation
            {
                Id = 47,
                Key = "Dutch",
                Value = "Néerlandais",
                Language = "fr"
            },
            new Translation
            {
                Id = 48,
                Key = "Dutch",
                Value = "Dutch",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 49,
                Key = "French",
                Value = "Frans",
                Language = "nl"
            },
            new Translation
            {
                Id = 50,
                Key = "French",
                Value = "Français",
                Language = "fr"
            },
            new Translation
            {
                Id = 51,
                Key = "French",
                Value = "French",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 52,
                Key = "Logout",
                Value = "Uitloggen",
                Language = "nl"
            },
            new Translation
            {
                Id = 53,
                Key = "Logout",
                Value = "Se déconnecter",
                Language = "fr"
            },
            new Translation
            {
                Id = 54,
                Key = "Logout",
                Value = "Logout",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 55,
                Key = "Passwords must have at least one non alphanumeric character.",
                Value = "Wachtwoorden moeten ten minste één niet-alfanumeriek teken bevatten.",
                Language = "nl"
            },
            new Translation
            {
                Id = 56,
                Key = "Passwords must have at least one non alphanumeric character.",
                Value = "Les mots de passe doivent comporter au moins un caractère non alphanumérique.",
                Language = "fr"
            },
            new Translation
            {
                Id = 57,
                Key = "Passwords must have at least one non alphanumeric character.",
                Value = "Passwords must have at least one non alphanumeric character.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 58,
                Key = "Approve",
                Value = "Goedkeuren",
                Language = "nl"
            },
            new Translation
            {
                Id = 59,
                Key = "Approve",
                Value = "Approuver",
                Language = "fr"
            },
            new Translation
            {
                Id = 60,
                Key = "Approve",
                Value = "Approve",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 61,
                Key = "Reject",
                Value = "Afwijzen",
                Language = "nl"
            },
            new Translation
            {
                Id = 62,
                Key = "Reject",
                Value = "Rejeter",
                Language = "fr"
            },
            new Translation
            {
                Id = 63,
                Key = "Reject",
                Value = "Reject",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 64,
                Key = "User has been approved.",
                Value = "Gebruiker is goedgekeurd.",
                Language = "nl"
            },
            new Translation
            {
                Id = 65,
                Key = "User has been approved.",
                Value = "L'utilisateur a été approuvé.",
                Language = "fr"
            },
            new Translation
            {
                Id = 66,
                Key = "User has been approved.",
                Value = "User has been approved.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 67,
                Key = "Failed to approve user.",
                Value = "Kan gebruiker niet goedkeuren.",
                Language = "nl"
            },
            new Translation
            {
                Id = 68,
                Key = "Failed to approve user.",
                Value = "Échec de l'approbation de l'utilisateur.",
                Language = "fr"
            },
            new Translation
            {
                Id = 69,
                Key = "Failed to approve user.",
                Value = "Failed to approve user.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 70,
                Key = "User has been rejected.",
                Value = "Gebruiker is afgewezen.",
                Language = "nl"
            },
            new Translation
            {
                Id = 71,
                Key = "User has been rejected.",
                Value = "L'utilisateur a été rejeté.",
                Language = "fr"
            },
            new Translation
            {
                Id = 72,
                Key = "User has been rejected.",
                Value = "User has been rejected.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 73,
                Key = "Failed to reject user.",
                Value = "Kan gebruiker niet weigeren.",
                Language = "nl"
            },
            new Translation
            {
                Id = 74,
                Key = "Failed to reject user.",
                Value = "Échec du rejet de l'utilisateur.",
                Language = "fr"
            },
            new Translation
            {
                Id = 75,
                Key = "Failed to reject user.",
                Value = "Failed to approve user.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 76,
                Key = "Manager Dashboard",
                Value = "Beheerdersdashboard",
                Language = "nl"
            },
            new Translation
            {
                Id = 77,
                Key = "Manager Dashboard",
                Value = "Tableau de bord du gestionnaire",
                Language = "fr"
            },
            new Translation
            {
                Id = 78,
                Key = "Manager Dashboard",
                Value = "Manager Dashboard",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 79,
                Key = "Approve new users and/or set permissions.",
                Value = "Nieuwe gebruikers goedkeuren en/of machtigingen instellen.",
                Language = "nl"
            },
            new Translation
            {
                Id = 80,
                Key = "Approve new users and/or set permissions.",
                Value = "Approuver de nouveaux utilisateurs et/ou définir des autorisations.",
                Language = "fr"
            },
            new Translation
            {
                Id = 81,
                Key = "Approve new users and/or set permissions.",
                Value = "Approve new users and/or set permissions.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 82,
                Key = "Permissions",
                Value = "Rechten",
                Language = "nl"
            },
            new Translation
            {
                Id = 83,
                Key = "Permissions",
                Value = "Autorisations",
                Language = "fr"
            },
            new Translation
            {
                Id = 84,
                Key = "Permissions",
                Value = "Permissions",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 85,
                Key = "Approved",
                Value = "Goedgekeurd",
                Language = "nl"
            },
            new Translation
            {
                Id = 86,
                Key = "Approved",
                Value = "Approuvée",
                Language = "fr"
            },
            new Translation
            {
                Id = 87,
                Key = "Approved",
                Value = "Approved",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 88,
                Key = "User",
                Value = "Gebruiker",
                Language = "nl"
            },
            new Translation
            {
                Id = 89,
                Key = "User",
                Value = "Utilisateur/Utilisatrice",
                Language = "fr"
            },
            new Translation
            {
                Id = 90,
                Key = "User",
                Value = "User",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 91,
                Key = "Manager",
                Value = "Beheerder",
                Language = "nl"
            },
            new Translation
            {
                Id = 92,
                Key = "Manager",
                Value = "Gestionnaire",
                Language = "fr"
            },
            new Translation
            {
                Id = 93,
                Key = "Manager",
                Value = "Manager",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 94,
                Key = "Admin",
                Value = "Admin",
                Language = "nl"
            },
            new Translation
            {
                Id = 95,
                Key = "Admin",
                Value = "Admin",
                Language = "fr"
            },
            new Translation
            {
                Id = 96,
                Key = "Admin",
                Value = "Admin",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 97,
                Key = "Update",
                Value = "Update",
                Language = "nl"
            },
            new Translation
            {
                Id = 98,
                Key = "Update",
                Value = "Modifier",
                Language = "fr"
            },
            new Translation
            {
                Id = 99,
                Key = "Update",
                Value = "Update",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 100,
                Key = "User's permissions has been updated.",
                Value = "De machtigingen van de gebruiker zijn bijgewerkt.",
                Language = "nl"
            },
            new Translation
            {
                Id = 101,
                Key = "User's permissions has been updated.",
                Value = "Les autorisations de l'utilisateur ont été mises à jour.",
                Language = "fr"
            },
            new Translation
            {
                Id = 102,
                Key = "User's permissions has been updated.",
                Value = "User's permissions has been updated.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 103,
                Key = "Failed to update user's permissions.",
                Value = "Kan gebruikersrechten niet updaten.",
                Language = "nl"
            },
            new Translation
            {
                Id = 104,
                Key = "Failed to update user's permissions.",
                Value = "Échec de la mise à jour des autorisations de l'utilisateur.",
                Language = "fr"
            },
            new Translation
            {
                Id = 105,
                Key = "Failed to update user's permissions.",
                Value = "Update",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 106,
                Key = "User (Read Only)",
                Value = "Gebruiker (Read Only)",
                Language = "nl"
            },
            new Translation
            {
                Id = 107,
                Key = "User (Read Only)",
                Value = "Utilisateur/Utilisatrice (lecture seule)",
                Language = "fr"
            },
            new Translation
            {
                Id = 108,
                Key = "User (Read Only)",
                Value = "User (Read Only)",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 109,
                Key = "Cancel",
                Value = "Annuleren",
                Language = "nl"
            },
            new Translation
            {
                Id = 110,
                Key = "Cancel",
                Value = "Annuler",
                Language = "fr"
            },
            new Translation
            {
                Id = 111,
                Key = "Cancel",
                Value = "Cancel",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 112,
                Key = "Objectives",
                Value = "Doelstellingen",
                Language = "nl"
            },
            new Translation
            {
                Id = 113,
                Key = "Objectives",
                Value = "Objectifs",
                Language = "fr"
            },
            new Translation
            {
                Id = 114,
                Key = "Objectives",
                Value = "Objectives",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 115,
                Key = "Management",
                Value = "Bestuur",
                Language = "nl"
            },
            new Translation
            {
                Id = 116,
                Key = "Management",
                Value = "Gestion",
                Language = "fr"
            },
            new Translation
            {
                Id = 117,
                Key = "Management",
                Value = "Management",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 118,
                Key = "Activities",
                Value = "Activiteiten",
                Language = "nl"
            },
            new Translation
            {
                Id = 119,
                Key = "Activities",
                Value = "Activités",
                Language = "fr"
            },
            new Translation
            {
                Id = 120,
                Key = "Activities",
                Value = "Activities",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 121,
                Key = "Links",
                Value = "Links",
                Language = "nl"
            },
            new Translation
            {
                Id = 122,
                Key = "Links",
                Value = "Liens",
                Language = "fr"
            },
            new Translation
            {
                Id = 123,
                Key = "Links",
                Value = "Links",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 124,
                Key = "Objectives and method",
                Value = "Doelstellingen en werkwijze",
                Language = "nl"
            },
            new Translation
            {
                Id = 125,
                Key = "Objectives and method",
                Value = "Objectifs et méthode",
                Language = "fr"
            },
            new Translation
            {
                Id = 126,
                Key = "Objectives and method",
                Value = "Objectives and method",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 127,
                Key = "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.",
                Value = "Iedereen die uit het actieve beroepsleven stapt doet dit met een pak kennis en vaardigheden. Het is de bedoeling van de Kennisbeurs om dit uit te wisselen : wat men weet doorgeven aan anderen en van die anderen interessante kennis of kunde capteren. Er wordt ook ruimschoots de mogelijkheid geboden om nieuwe sociale contacten op te bouwen na het wegvallen van de beroepsactiviteiten.",
                Language = "nl"
            },
            new Translation
            {
                Id = 128,
                Key = "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.",
                Value = "Quiconque quitte la vie professionnelle active le fait avec beaucoup de connaissances et de compétences. Le but de l'échange de connaissances est d'échanger cela : transmettre ce que l'on sait à d'autres et capter des connaissances ou des compétences intéressantes de ces autres. Il existe également de nombreuses possibilités de nouer de nouveaux contacts sociaux après la cessation des activités professionnelles.",
                Language = "fr"
            },
            new Translation
            {
                Id = 129,
                Key = "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.",
                Value = "Anyone who leaves active professional life does so with a lot of knowledge and skills. The aim of the Knowledge Exchange is to exchange this: to pass on what one knows to others and to capture interesting knowledge or skills from those others. There is also ample opportunity to build up new social contacts after the cessation of professional activities.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 130,
                Key = "Our motto is therefore",
                Value = "Ons motto is dan ook",
                Language = "nl"
            },
            new Translation
            {
                Id = 131,
                Key = "Our motto is therefore",
                Value = "Notre devise est donc",
                Language = "fr"
            },
            new Translation
            {
                Id = 132,
                Key = "Our motto is therefore",
                Value = "Our motto is therefore",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 133,
                Key = "Giving Knowledge, Taking Knowledge and Making Acquaintances.",
                Value = "Kennis geven, Kennis nemen en Kennissen maken.",
                Language = "nl"
            },
            new Translation
            {
                Id = 134,
                Key = "Giving Knowledge, Taking Knowledge and Making Acquaintances.",
                Value = "Donner des connaissances, prendre des connaissances et faire des connaissances.",
                Language = "fr"
            },
            new Translation
            {
                Id = 135,
                Key = "Giving Knowledge, Taking Knowledge and Making Acquaintances.",
                Value = "Giving Knowledge, Taking Knowledge and Making Acquaintances.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 136,
                Key = "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.",
                Value = "De lezingen niet te na gesproken, gebeuren de activiteiten in kleine groepen, zodat iedereen actief kan deelnemen. Elke groep staat onder de leiding van een animator die de deelnemers bijeenroept, begeleidt en zorgt voor de faciliteiten. Het programma bepalen de leden in grote mate zelf. Het welslagen hangt dus niet alleen af van de animatoren maar ook van de deelnemers, waarvan verwacht wordt dat ze een actieve inbreng leveren. Wordt een groep te talrijk, dan wordt overgegaan tot splitsing ervan. Aldus zorgt men ervoor dat elkeen aan bod komt.",
                Language = "nl"
            },
            new Translation
            {
                Id = 137,
                Key = "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.",
                Value = "En dehors des conférences, les activités se déroulent en petits groupes, afin que chacun puisse participer activement. Chaque groupe est animé par un animateur qui convoque les participants, encadre et entretient les installations. Le programme est largement déterminé par les membres eux-mêmes. Le succès dépend donc non seulement des animateurs mais aussi des participants, dont on attend une contribution active. Si un groupe devient trop nombreux, il est divisé. Cela garantit que tout le monde est couvert.",
                Language = "fr"
            },
            new Translation
            {
                Id = 138,
                Key = "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.",
                Value = "Apart from the lectures, the activities take place in small groups, so that everyone can participate actively. Each group is led by an animator who convenes the participants, supervises and takes care of the facilities. The program is largely determined by the members themselves. Success therefore depends not only on the animators but also on the participants, who are expected to make an active contribution. If a group becomes too numerous, it is split up. This ensures that everyone is covered.",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 139,
                Key = "Sister Associations",
                Value = "Zusterverenigingen",
                Language = "nl"
            },
            new Translation
            {
                Id = 140,
                Key = "Sister Associations",
                Value = "Associations Sœurs",
                Language = "fr"
            },
            new Translation
            {
                Id = 141,
                Key = "Sister Associations",
                Value = "Sister Associations",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 142,
                Key = "Executive Committee",
                Value = "Zusterverenigingen",
                Language = "nl"
            },
            new Translation
            {
                Id = 143,
                Key = "Executive Committee",
                Value = "Associations Sœurs",
                Language = "fr"
            },
            new Translation
            {
                Id = 144,
                Key = "Executive Committee",
                Value = "Executive Committee",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 145,
                Key = "Function",
                Value = "Functie",
                Language = "nl"
            },
            new Translation
            {
                Id = 146,
                Key = "Function",
                Value = "Fonction",
                Language = "fr"
            },
            new Translation
            {
                Id = 147,
                Key = "Function",
                Value = "Function",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 148,
                Key = "Information",
                Value = "Informatie",
                Language = "nl"
            },
            new Translation
            {
                Id = 149,
                Key = "Information",
                Value = "Information",
                Language = "fr"
            },
            new Translation
            {
                Id = 150,
                Key = "Information",
                Value = "Information",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 151,
                Key = "Chair",
                Value = "Voorzitter",
                Language = "nl"
            },
            new Translation
            {
                Id = 152,
                Key = "Chair",
                Value = "Président",
                Language = "fr"
            },
            new Translation
            {
                Id = 153,
                Key = "Chair",
                Value = "Chair",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 154,
                Key = "Secretary",
                Value = "Secretaris",
                Language = "nl"
            },
            new Translation
            {
                Id = 155,
                Key = "Secretary",
                Value = "Secrétaire",
                Language = "fr"
            },
            new Translation
            {
                Id = 156,
                Key = "Secretary",
                Value = "Secretary",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 157,
                Key = "Treasurer",
                Value = "Penningmeester",
                Language = "nl"
            },
            new Translation
            {
                Id = 158,
                Key = "Treasurer",
                Value = "Trésorière/Trésorier",
                Language = "fr"
            },
            new Translation
            {
                Id = 159,
                Key = "Treasurer",
                Value = "Treasurer",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 160,
                Key = "Send mail",
                Value = "Verzend mail",
                Language = "nl"
            },
            new Translation
            {
                Id = 161,
                Key = "Send mail",
                Value = "Envoyer un mail",
                Language = "fr"
            },
            new Translation
            {
                Id = 162,
                Key = "Send mail",
                Value = "Send mail",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 163,
                Key = "Activity",
                Value = "Activiteit",
                Language = "nl"
            },
            new Translation
            {
                Id = 164,
                Key = "Activity",
                Value = "Activité",
                Language = "fr"
            },
            new Translation
            {
                Id = 165,
                Key = "Activity",
                Value = "Activity",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 166,
                Key = "Title",
                Value = "Titel",
                Language = "nl"
            },
            new Translation
            {
                Id = 167,
                Key = "Title",
                Value = "Titre",
                Language = "fr"
            },
            new Translation
            {
                Id = 168,
                Key = "Title",
                Value = "Title",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 169,
                Key = "Description",
                Value = "Beschrijving",
                Language = "nl"
            },
            new Translation
            {
                Id = 170,
                Key = "Description",
                Value = "Description",
                Language = "fr"
            },
            new Translation
            {
                Id = 171,
                Key = "Description",
                Value = "Description",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 172,
                Key = "Animator",
                Value = "Animator",
                Language = "nl"
            },
            new Translation
            {
                Id = 173,
                Key = "Animator",
                Value = "Animateur",
                Language = "fr"
            },
            new Translation
            {
                Id = 174,
                Key = "Animator",
                Value = "Animator",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 175,
                Key = "Date",
                Value = "Datum",
                Language = "nl"
            },
            new Translation
            {
                Id = 176,
                Key = "Date",
                Value = "Date",
                Language = "fr"
            },
            new Translation
            {
                Id = 177,
                Key = "Date",
                Value = "Date",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 178,
                Key = "Location",
                Value = "Plaats",
                Language = "nl"
            },
            new Translation
            {
                Id = 179,
                Key = "Location",
                Value = "Lieu",
                Language = "fr"
            },
            new Translation
            {
                Id = 180,
                Key = "Location",
                Value = "Location",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 181,
                Key = "Create",
                Value = "Creëren",
                Language = "nl"
            },
            new Translation
            {
                Id = 182,
                Key = "Create",
                Value = "Créer",
                Language = "fr"
            },
            new Translation
            {
                Id = 183,
                Key = "Create",
                Value = "Create",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 184,
                Key = "Create new",
                Value = "Maak nieuw",
                Language = "nl"
            },
            new Translation
            {
                Id = 185,
                Key = "Create new",
                Value = "Créer une nouvelle",
                Language = "fr"
            },
            new Translation
            {
                Id = 186,
                Key = "Create new",
                Value = "Create new",
                Language = "en"
            },
            //**************************************************//
            new Translation
            {
                Id = 187,
                Key = "Read more..",
                Value = "Lees verder..",
                Language = "nl"
            },
            new Translation
            {
                Id = 188,
                Key = "Read more..",
                Value = "Lire la suite..",
                Language = "fr"
            },
            new Translation
            {
                Id = 189,
                Key = "Read more..",
                Value = "Read more..",
                Language = "en"
            },
            //**************************************************//
        };
        return translations;
    }
}
