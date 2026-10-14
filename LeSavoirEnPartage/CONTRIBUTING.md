# Contribuer à Le Savoir en partage

Merci de vouloir rendre la curiosité plus accessible. Les contributions doivent aider les visiteurs à apprendre, vérifier et remonter aux sources.

## Avant de proposer une modification

1. Ouvre une issue pour expliquer le problème ou l’idée, surtout si elle change le fonctionnement éditorial.
2. Pour une correction directe, propose une pull request courte et ciblée.
3. Décris ce qui change, pourquoi, et comment tu l’as vérifié.

## Règles éditoriales

- Chaque découverte factuelle doit renvoyer à une source précise et consultable, pas seulement à une page d’accueil générique.
- Pour les affirmations surprenantes, controversées ou médicales, privilégie des sources primaires, des publications scientifiques, des organismes publics ou des institutions reconnues.
- Distingue les faits établis, les hypothèses, les désaccords et les anecdotes. N’invente jamais une citation, une source ou un résultat.
- Vérifie que le lien mène bien au sujet annoncé et qu’il est accessible.
- Évite les généralisations culturelles, les stéréotypes et les formulations qui prétendent lire les pensées.
- Les contenus doivent rester compréhensibles, respectueux et adaptés à un large public.

## Français, anglais et espagnol

Toute nouvelle fonctionnalité visible doit être traduite en français, anglais et espagnol. Si une traduction n’est pas prête, signale-le dans la pull request plutôt que de présenter une langue comme entièrement prise en charge.

## Sources, droits et marques

- N’intègre pas de longs extraits copiés d’articles externes. Privilégie les liens et les résumés originaux.
- Vérifie les licences avant d’ajouter du texte, une image, une vidéo ou une police. Les médias peuvent avoir des licences différentes du code.
- Conserve les attributions et mentions de licence requises.
- N’utilise pas les marques ou logos de Wikipédia/Wikimedia d’une façon qui suggère une affiliation, un soutien ou une validation officielle.

## Tests attendus

Avant une pull request, vérifie au minimum :

- `dotnet restore` puis `dotnet build` avec le SDK .NET 10 ;
- les liens externes ajoutés ;
- les vues mobile et ordinateur ;
- le changement de langue sur les pages concernées ;
- l’absence de secrets, de clés API et de données personnelles dans le dépôt.

## Licence

Le code est soumis à la PolyForm Noncommercial License 1.0.0, disponible dans `LICENSE`. Elle autorise les usages non commerciaux selon ses termes, mais ne constitue pas une autorisation d’usage commercial. Toute contribution est proposée sous les mêmes conditions, sauf accord écrit distinct.
