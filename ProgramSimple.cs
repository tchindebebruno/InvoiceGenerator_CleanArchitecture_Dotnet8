using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Generator
{
    using System;
    using System.IO;
    using SkiaSharp;

    class ProgramSimple
    {
        public void Main()
        {
            int width = 400;
            int height = 620;
            int margin = 20; // Marges pour les côtés
            int topMargin = margin * 6; // Marge supérieure augmentée
            int logoSize = 50;
            float cornerRadius = 20; // Rayon des coins arrondis
            float textSizeAttribute = 12;

            using (var bitmap = new SKBitmap(width, height, true))
            {
                using (var canvas = new SKCanvas(bitmap))
                {
                    // Définir le fond de la facture
                    canvas.Clear(SKColors.White);

                    // Charger le logo dynamiquement
                    string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");
                    SKBitmap logo = null;

                    try
                    {
                        logo = SKBitmap.Decode(logoPath);

                        if (logo != null)
                        {
                            // Redimensionner le logo
                            using (var resizedLogo = new SKBitmap(logoSize, logoSize))
                            using (var logoCanvas = new SKCanvas(resizedLogo))
                            {
                                logoCanvas.DrawBitmap(logo, new SKRect(0, 0, logoSize, logoSize));
                                // Calculer la position pour centrer le logo
                                int logoX = (width - logoSize) / 2;
                                canvas.DrawBitmap(resizedLogo, new SKPoint(logoX, topMargin - logoSize - 10)); // Position du logo
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors du chargement de l'image : " + ex.Message);
                        return; // Sortir si l'image ne peut pas être chargée
                    }

                    // Dessiner un rectangle bleu clair avec des coins arrondis pour le contenu
                    var backgroundPaint = new SKPaint { Color = SKColors.LightBlue };
                    canvas.DrawRoundRect(new SKRect(margin, topMargin, width - margin, height - margin), cornerRadius, cornerRadius, backgroundPaint);

                    // Ajouter le texte de la facture
                    using (var titleFont = SKTypeface.FromFamilyName("Roboto", SKFontStyle.Bold))
                    using (var textFont = SKTypeface.FromFamilyName("Roboto", SKFontStyle.Normal))
                    using (var attributeFont = SKTypeface.FromFamilyName("Roboto", SKFontStyle.Normal))
                    {
                        var titlePaint = new SKPaint { Typeface = titleFont, Color = new SKColor(30, 30, 30), TextSize = 22, IsAntialias = true, FakeBoldText = true };
                        var textPaint = new SKPaint { Typeface = textFont, Color = new SKColor(30, 30, 30), TextSize = 16, IsAntialias = true, FakeBoldText = true };
                        var attributePaint = new SKPaint { Typeface = attributeFont, Color = new SKColor(100, 100, 100), TextSize = textSizeAttribute, IsAntialias = true, FakeBoldText = true };

                        // Écrire le titre centré
                        string title = "Facture #122334";
                        var titleBounds = new SKRect();
                        titlePaint.MeasureText(title, ref titleBounds);
                        canvas.DrawText(title, (width - titleBounds.Width) / 2, topMargin + 30, titlePaint);

                        // Ajouter une description
                        string description = "Cette facture a été réglée avec succès.";
                        var descriptionBounds = new SKRect();
                        attributePaint.MeasureText(description, ref descriptionBounds);
                        canvas.DrawText(description, (width - descriptionBounds.Width) / 2, topMargin + 50, attributePaint);

                        //// Informations de la facture
                        float yPosition = topMargin + 60 + descriptionBounds.Height; // Réduit l'espace après la description

                        // Attributs et valeurs
                        string[] attributes = {
                        "Montant:", "100 000 FCFA",
                        "Service:", "Airtel Money",
                        "Bénéficiaire:", "Mahamat Idriss",
                        "Numéro du bénéficiaire:", "+235 65 123 456",
                        "Date:", DateTime.Now.ToString("dd MMMM yyyy"),
                        "Référence de la transaction:", "ABC123"
                    };

                        // Dessiner les attributs et les valeurs
                        for (int i = 0; i < attributes.Length; i++)
                        {
                            canvas.DrawText(attributes[i], margin + 20, yPosition, i % 2 == 0 ? attributePaint : textPaint);
                            yPosition += 20; // Espacement accru
                        }

                        // Informations supplémentaires ou notes
                        canvas.DrawText("Chaque transfert, un lien renforcé...", margin + 20, yPosition + 30, attributePaint);
                    }

                    // Enregistrer l'image
                    using (var image = SKImage.FromBitmap(bitmap))
                    using (var stream = File.OpenWrite("facture.png"))
                    {
                        image.Encode(SKEncodedImageFormat.Png, 100).SaveTo(stream);
                    }
                }
            }

            Console.WriteLine("Facture créée avec succès !");
        }
    }
}
