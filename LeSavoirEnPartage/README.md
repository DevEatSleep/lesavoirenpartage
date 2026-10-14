# Le Savoir en partage — Le Voyageur du savoir

Application web progressive (PWA) en Blazor WebAssembly / .NET 10. Son objectif est de rendre la découverte amusante et de donner envie de vérifier les faits auprès de sources consultables.

> **Indépendance :** ce projet n’est ni développé, ni approuvé, ni sponsorisé par Wikipédia ou la Wikimedia Foundation. Les liens de don ouvrent le site officiel de Wikimedia et ne font transiter aucun paiement par l’application.

## Les huit univers

1. Mystères & énigmes
2. Cinéma, séries & pop culture
3. Jeux de cerveau
4. Voyages & cultures étonnantes
5. Animaux extraordinaires
6. Inventions folles & échecs célèbres
7. Incroyable… mais vrai ?
8. Amour, relations & comportements

## Fonctions de cette version 1.1

- Accueil responsive et huit univers de découverte
- Quatre mini-enquêtes par univers, chacune avec un lien vers un article Wikipédia lié au sujet
- Liens documentaires en français, anglais et espagnol pour chaque univers
- Une source complémentaire par univers pour encourager le recoupement
- Carte des découvertes et carnet personnel stocké localement dans le navigateur
- Sélecteur de langue français / anglais / espagnol avec détection initiale de la langue du navigateur et mémorisation du choix
- Page « Sources, crédits et licences » et page « À propos » expliquant l’indépendance du projet
- Liens facultatifs vers le don officiel Wikimedia ; aucun paiement n’est collecté dans l’application
- Workflow GitHub Actions pour construire le projet

### Limite importante sur la traduction

Cette version comprend une première couche de traduction côté navigateur pour les textes de l’interface et le catalogue. La couverture peut ne pas être exhaustive pour chaque libellé dynamique ou futur contenu : toute contribution visible doit être traduite et testée dans les trois langues. La solution actuelle est une étape de transition, pas un système complet de localisation .NET fondé sur des fichiers `.resx`.

## Licence du code

Le code est proposé sous **PolyForm Noncommercial License 1.0.0**. Les usages non commerciaux sont autorisés selon les termes de la licence ; les usages commerciaux nécessitent une autorisation distincte. Cette licence est à usage non commercial et **n’est pas une licence open source approuvée par l’OSI**. Lire le fichier `LICENSE` et les mentions `NOTICE.md`.

La licence du code ne change pas les licences des contenus externes. Les textes de Wikipédia sont généralement sous CC BY-SA, tandis que les images et autres médias peuvent avoir des licences distinctes. Vérifier les notices des sources avant toute réutilisation.

## Contribuer

Lire [`CONTRIBUTING.md`](CONTRIBUTING.md) avant de proposer un changement. Les découvertes factuelles doivent renvoyer à une source précise ; ne jamais inventer de référence ni présenter une hypothèse comme un fait établi.

## Lancer en local

Installer le SDK .NET 10, puis exécuter depuis le dossier du projet :

```bash
dotnet restore
dotnet run
```

Le workflow GitHub Actions lance une compilation à chaque push. L’assistant IA n’est pas activé dans cette version. Les liens documentaires restent visibles pour encourager la vérification des faits.
