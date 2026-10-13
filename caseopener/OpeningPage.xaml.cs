using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace caseopener
{
    /// <summary>
    /// Logika interakcji dla klasy OpeningPage.xaml
    /// </summary>
    public partial class OpeningPage : Page
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        public class Program
        {

            public class Skin
            {
                public string? Name { get; set; }
                public string? Rarity { get; set; }

                public decimal? Price { get; set; }
                public string? ImagePath { get; set; }
            }

            public static void Main()
            {
                // 2. Deklarujemy stałą wielowymiarową tablicę 2D (np. 2 wiersze na 2 kolumny)
                // Wiersze mogą oznaczać np. kategorie (0 = noże, 1 = karabiny), a kolumny konkretne przedmioty.
                Skin[,] ekwipunekCS = new Skin[2, 2];

                // 3. Przypisywanie obiektów do konkretnych indeksów w tablicy
                ekwipunekCS[0, 0] = new Skin
                {
                    Name = "Karambit | Fade",
                    Price = 1500.50m,
                    ImagePath = "https://example.com"
                };

                ekwipunekCS[0, 1] = new Skin
                {
                    Name = "M9 Bayonet | Doppler",
                    Price = 1200.00m,
                    ImagePath = "https://example.com"
                };

                ekwipunekCS[1, 0] = new Skin
                {
                    Name = "AK-47 | Case Hardened",
                    Price = 350.00m,
                    ImagePath = "https://example.com"
                };

                ekwipunekCS[1, 1] = new Skin
                {
                    Name = "AWP | Asiimov",
                    Price = 180.25m,
                    ImagePath = "https://example.com"
                };

                // 4. Przykład odczytu danych z konkretnego miejsca
                Skin wybranySkin = ekwipunekCS[0, 0];
                Console.WriteLine($"Wybrany skin: {wybranySkin.Name} kosztuje {wybranySkin.Price} USD.");

                // 5. Przechodzenie przez całą tablicę za pomocą pętli
                Console.WriteLine("\nCała zawartość tablicy:");
                for (int i = 0; i < ekwipunekCS.GetLength(0); i++) // GetLength(0) zwraca liczbę wierszy
                {
                    for (int j = 0; j < ekwipunekCS.GetLength(1); j++) // GetLength(1) zwraca liczbę kolumn
                    {
                        Skin s = ekwipunekCS[i, j];
                        Console.WriteLine($"[{i},{j}] {s.Name} | Cena: {s.Price} | URL: {s.ImagePath}");
                    }
                }
            }
        }
    }
}
