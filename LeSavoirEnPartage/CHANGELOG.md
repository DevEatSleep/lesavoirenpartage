# Historique des versions

## Non publié (déploiement)

- Déploiement sur GitHub Pages via GitHub Actions (`.github/workflows/deploy-pages.yml`) : publication .NET, base href adapté au sous-chemin du dépôt, `404.html` pour les routes Blazor, `.nojekyll`.
- Tous les liens internes, la navigation, le manifeste et l’enregistrement du service worker sont relatifs au `<base href>` (ils pointaient vers la racine du domaine et auraient été cassés sous `/lesavoirenpartage/`).

## Non publié (liens)

- Liens génériques remplacés par des articles précis, vérifiés dans les trois langues : « Culture populaire » (au lieu de « Cinéma »), « Patrimoine culturel immatériel » (au lieu de « Culture »), « Post-it » (au lieu de « Innovation »).
- Liens cassés corrigés : « Fête traditionnelle » (fr, inexistant) → « Fête » ; « Cine biográfico » (es) → « Película biográfica » ; « Ciencia elástica » (es, faute de frappe) → « Ciencia ficción ».

## Non publié (carte)

- Carte des découvertes : le compteur est calculé à partir des données (8 univers · 13 connexions) au lieu d’afficher « 8 connexions » en dur pour 14 liens.
- Lien en double supprimé (« Vrai ou faux » → « Mystères » existait déjà dans l’autre sens).
- Nœud « Relations » déplacé : il était posé exactement sur la ligne Mystères–Vrai ou faux, et la ligne Relations–Voyages passait au centre de « Vrai ou faux ». Plus aucun lien ne traverse un autre nœud (distance minimale de 10 px au bord des cercles, vérifiée par script).

### Vérifications

- Géométrie contrôlée par script sur les coordonnées du fichier. La compilation .NET et le test navigateur restent à effectuer.

## Non publié (suite)

- L’hypothèse saisie sur une page d’univers ou de piste est enregistrée dans le navigateur, préremplie à la visite suivante, et affichée dans le carnet sous l’entrée correspondante. Retirer une entrée du carnet efface aussi son hypothèse.
- Données stockées localement (clé `lsp-notes-v1`), jamais envoyées : 2 000 caractères maximum par hypothèse.

### Vérifications

- Fonctions de stockage testées sous Node avec un `localStorage` simulé. La compilation .NET et le test navigateur restent à effectuer.

## Non publié

- Chaque mini-enquête affiche maintenant une réponse courte et sourcée (32 au total), révélée après la saisie d’une hypothèse. Chaque fait renvoie à l’article précis qui l’appuie.
- Les 32 réponses, les noms de sources et les libellés de la nouvelle section sont traduits en anglais et en espagnol, avec le même mécanisme que le reste de l’interface (dictionnaire dans `wwwroot/js/app.js`). Les liens de source restent ceux des articles français ou anglais cités ; le nom du lien précise la langue de l’article.
- Cache PWA passé en `lsp-v1.2` pour que le nouveau dictionnaire soit pris en compte à la mise à jour.
- Le carnet affiche les pistes enregistrées (voir le correctif précédent).

### Vérifications

- Faits contrôlés un par un sur l’article Wikipédia cité (français, ou anglais quand l’article français ne contient pas le détail).
- Longueurs des tableaux contrôlées par script (8 univers × 4 pistes). La compilation .NET et le test navigateur restent à effectuer : le SDK .NET n’est pas disponible dans l’environnement de préparation.

## 1.1.0 — 2026-10-13

- Ajout de la licence PolyForm Noncommercial 1.0.0, du fichier NOTICE et des règles de contribution.
- Ajout d’une page À propos précisant que le projet est indépendant de Wikipédia et de Wikimedia.
- Ajout d’un lien Wikipédia plus spécifique pour chacune des 32 mini-enquêtes, avec liens FR/EN/ES.
- Première couche de traduction de l’interface et du catalogue en français, anglais et espagnol ; détection de la langue du navigateur et mémorisation du choix.
- Invalidation du cache PWA afin que les nouveaux fichiers soient pris en compte après mise à jour.
- Mise à jour du README et des informations de version.

### Vérifications

- Syntaxe JavaScript vérifiée avec `node --check`.
- Structure XML du fichier projet et présence des huit jeux de liens par langue vérifiées.
- La compilation .NET et le test navigateur restent à effectuer : le SDK .NET n’était pas disponible dans l’environnement de préparation.
