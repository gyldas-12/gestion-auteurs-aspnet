# Gestion d'Auteurs — ASP.NET MVC & Entity Framework

## Description

Application web de gestion d'auteurs développée avec ASP.NET MVC et Entity Framework Core. Permet de gérer une base de données d'auteurs avec toutes les opérations CRUD via une interface web complète.

## Fonctionnalités

- Liste complète des auteurs
- Création d'un nouvel auteur avec validation des données
- Modification des informations d'un auteur
- Suppression d'un auteur
- Validation côté serveur avec DataAnnotations

## Technologies utilisées

- **C# / .NET 8** — langage et framework principal
- **ASP.NET MVC** — architecture Model-View-Controller
- **Entity Framework Core** — ORM pour la base de données
- **SQL Server** — base de données relationnelle
- **Razor Views** — moteur de templates HTML
- **Migrations EF** — gestion des versions de la base de données

## Structure du projet

NembotKamgueGyldas/
│
├── Controllers/
│   ├── AuteurController.cs   # CRUD complet des auteurs
│   └── HomeController.cs
│
├── Models/
│   ├── Auteur.cs             # Modèle avec validations
│   └── AuteurContext.cs      # Contexte Entity Framework
│
├── Views/
│   └── Auteur/
│       ├── Index.cshtml      # Liste des auteurs
│       ├── Create.cshtml     # Formulaire création
│       ├── Edit.cshtml       # Formulaire modification
│       ├── Details.cshtml    # Détails d'un auteur
│       └── Delete.cshtml     # Confirmation suppression
│
├── Migrations/               # Historique des migrations EF
└── Program.cs                # Configuration de l'application

## Comment exécuter le projet

1. Cloner le repository :

```bash
git clone https://github.com/gyldas-12/gestion-auteurs-aspnet.git
cd gestion-auteurs-aspnet
2. Configurer la base de données dans `appsettings.json`

3. Appliquer les migrations :
```bash
dotnet ef database update
```

4. Lancer l'application :
```bash
dotnet run
```

##  Auteur

**Gyldas Nembot Kamgue**
gnembot9@gmail.com
Longueuil, Québec
