# G�n�rateur de Factures

Ce programme permet de g�n�rer des factures au format PNG en utilisant SkiaSharp. 
Il cr�e une facture visuelle � partir de donn�es d�finies dans le code, incluant un logo, un titre, une description et divers attributs.

## Pr�requis

- .NET Core 3.1 ou version ult�rieure (.NET 8 recommand�)
- [SkiaSharp](https://github.com/mono/SkiaSharp) : biblioth�que graphique pour le rendu 2D.

## Installation

1. Clonez le d�p�t :

   ```bash
   git clone https://github.com/tchindebebruno/InvoiceGenerator_CleanArchitecture_Dotnet8.git
   cd votre-repo
   ```

2. Ouvrez le projet dans votre IDE (comme Visual Studio ou tout autre).

3. Restaurez les d�pendances :

   ```bash
   dotnet restore
   ```

4. Assurez-vous d'avoir un fichier `logo.png` dans le m�me r�pertoire que l'ex�cutable ou sp�cifiez un chemin alternatif dans le code.

## Utilisation

Pour g�n�rer une facture, ex�cutez le programme :

```bash
dotnet run
```

Le programme cr�era une facture nomm�e `facture.png` dans le r�pertoire de travail.

### Personnalisation

Vous pouvez personnaliser les �l�ments suivants dans le code :

- **Dimensions de la facture** : Modifiez `width` et `height` pour changer la taille de la facture.
- **Logo** : Remplacez `logo.png` par votre propre logo en ajustant le chemin d'acc�s.
- **Donn�es de la facture** : Mettez � jour le titre, la description et les attributs de la facture selon vos besoins.

## Architecture

Le programme est organis� selon une architecture clean, avec les couches suivantes :

- **Domain** : Contient les mod�les et la logique m�tier.
- **Application** : Contient les services et la logique de g�n�ration de la facture.
- **Infrastructure** : G�re l'acc�s aux fichiers et les op�rations d'entr�e/sortie.
- **Presentation** : G�re les interactions utilisateur et la pr�sentation des r�sultats.

## License

Ce projet est sous la licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de d�tails.

## Acknowledgments

- [SkiaSharp](https://github.com/mono/SkiaSharp) pour le rendu graphique.
- [OpenAI](https://openai.com) pour l'assistance dans la cr�ation de code et d'architecture.

---