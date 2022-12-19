using System.Windows;

namespace FridgeApp
{
    public partial class MainWindow : Window
    {
        public Fridge Fridge { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Fridge = new Fridge();
            RefreshList();
        }

        private void AddFoodButton_Click(object sender, RoutedEventArgs e)
        {
            Fridge.AddFood(FoodTextBox.Text);
            RefreshList();
        }

        private void RemoveFoodButton_Click(object sender, RoutedEventArgs e)
        {
            Fridge.RemoveFood(FoodListBox.SelectedItem as string);
            RefreshList();
        }

        private void ClearFridgeButton_Click(object sender, RoutedEventArgs e)
        {
            Fridge.ClearFridge();
            RefreshList();
        }

        private void RefreshList()
        {
            FoodListBox.Items.Clear();
            foreach (string food in Fridge.Foods)
            {
                FoodListBox.Items.Add(food);
            }
        }
    }
}
