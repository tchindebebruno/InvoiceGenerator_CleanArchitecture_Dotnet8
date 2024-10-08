# Générateur de Factures

Ce programme permet de générer des factures au format PNG en utilisant SkiaSharp. 
Il crée une facture visuelle à partir de données définies dans le code, incluant un logo, un titre, une description et divers attributs.

## Prérequis

- .NET Core 3.1 ou version ultérieure (.NET 8 recommandé)
- [SkiaSharp](https://github.com/mono/SkiaSharp) : bibliothèque graphique pour le rendu 2D.

## Installation

1. Clonez le dépôt :

   ```bash
   git clone https://github.com/tchindebebruno/InvoiceGenerator_CleanArchitecture_Dotnet8.git
   cd votre-repo
   ```

2. Ouvrez le projet dans votre IDE (comme Visual Studio ou tout autre).

3. Restaurez les dépendances :

   ```bash
   dotnet restore
   ```

4. Assurez-vous d'avoir un fichier `logo.png` dans le même répertoire que l'exécutable ou spécifiez un chemin alternatif dans le code.

## Utilisation

Pour générer une facture, exécutez le programme :

```bash
dotnet run
```

Le programme créera une facture nommée `facture.png` dans le répertoire de travail.

### Personnalisation

Vous pouvez personnaliser les éléments suivants dans le code :

- **Dimensions de la facture** : Modifiez `width` et `height` pour changer la taille de la facture.
- **Logo** : Remplacez `logo.png` par votre propre logo en ajustant le chemin d'accès.
- **Données de la facture** : Mettez à jour le titre, la description et les attributs de la facture selon vos besoins.

## Architecture

Le programme est organisé selon une architecture clean, avec les couches suivantes :

- **Domain** : Contient les modèles et la logique métier.
- **Application** : Contient les services et la logique de génération de la facture.
- **Infrastructure** : Gère l'accès aux fichiers et les opérations d'entrée/sortie.
- **Presentation** : Gère les interactions utilisateur et la présentation des résultats.

## License

Ce projet est sous la licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Acknowledgments

- [SkiaSharp](https://github.com/mono/SkiaSharp) pour le rendu graphique.

---
