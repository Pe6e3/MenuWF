using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UXElements;
using System.ComponentModel;

namespace MenuWF.Forms;

public static class FormHelper
{
    public static void OpenMainForm(Form currentForm)
    {
        MainForm mainForm = new MainForm();
        mainForm.Show();
        currentForm.Hide();
    }
    public static void RedirectToForm(Form currentForm, Form toForm)
    {
        toForm.Show();
        currentForm.Hide();
    }

    public static void CheckTextFieldLength(TextBox textBox, int maxLength)
    {
        if (textBox.Text.Length > maxLength)
            MessageBox.Show($"Длина поля не должна превышать {maxLength} символов");
    }
    public static void ExitProgramm()
    {
        Application.Exit();
    }
    public static void ValidateDecimal(TextBox textField, decimal maxValue = 10000)
    {
        if (!decimal.TryParse(textField.Text, out _))
        {
            if (textField.Text.Length > 1)
            {
                textField.Text = textField.Text.Substring(0, textField.Text.Length - 1);
                textField.SelectionStart = textField.Text.Length;
            }
            else
            {
                textField.Text = "";
            }
        }
        if (textField.Text.Length > 1 && Convert.ToDecimal(textField.Text) > maxValue)
        {
            textField.Text = textField.Text.Substring(0, textField.Text.Length - 1);
            textField.SelectionStart = textField.Text.Length;
            MessageBox.Show("Максимальное значение в этом поле не может превышать " + maxValue);
        }
    }

    public static void ClearFields(Control control)
    {
        foreach (Control c in control.Controls)
            if (c is TextBox textBox)
                textBox.Text = "";
            else if (c.Controls.Count > 0)
                ClearFields(c); // Рекурсивный вызов для вложенных контролов
    }


    // метод проверяет - если указанное поле пустое, то указанная кнопка неактивна и наоборот
    internal static void ButtonEnableByField(buttonUI button, TextBox textBox)
    {
        if (textBox.Text.Length == 0)
            button.Enabled = false;
        else
            button.Enabled = true;
    }
    internal static void ButtonEnableByListView(buttonUI button, ListView listView)
    {
        if (listView.SelectedItems == null)
            button.Enabled = false;
        else
            button.Enabled = true;
    }
    internal static void ButtonEnableByFieldAndListBox(buttonUI button, TextBox textBox, ListBox listBox)
    {
        if (listBox.SelectedItems.Count == 0 || textBox.Text.Length == 0)
            button.Enabled = false;
        else
            button.Enabled = true;
    }

    internal static void IncreaseField(TextBox field, int value)
    {
        if (field.Text.Length > 0)
            field.Text = (Convert.ToDecimal(field.Text) + value).ToString("0");
        else
            field.Text = value.ToString("0");
    }
    internal static void DecreaseField(TextBox field, int value)
    {
        if (field.Text.Length > 0 && Convert.ToDecimal(field.Text) > 0)
            field.Text = (Convert.ToDecimal(field.Text) - value).ToString("0");
    }

   

    internal async static void FilterDishComboBox(object sender)
    {
        if (sender is ComboBox comboBox)
        {
            comboBox.Items.Clear();
            IEnumerable<Dish> filteredDishes;
            string filteredText = comboBox.Text;
            using (var uow = new UnitOfWork())
            {
                filteredDishes = await uow.DishesRepository.FilterDishes(filteredText);
            }
            foreach (var filteredDish in filteredDishes)
                comboBox.Items.Add(filteredDish);
            comboBox.DroppedDown = true;
            comboBox.IntegralHeight = true;

            if (filteredDishes.Count() == 1)
            {
                comboBox.DroppedDown = false;
                comboBox.SelectedItem = filteredDishes.FirstOrDefault();
            }
            else
            {
                comboBox.SelectedIndex = -1;
                comboBox.Text = filteredText;
                comboBox.SelectionStart = filteredText.Length;
                comboBox.SelectionLength = 0;
            }
        }

    }

    internal async static void FilterProductComboBox(object sender)
    {
        if (sender is ComboBox comboBox)
        {
            comboBox.Items.Clear();
            IEnumerable<Product> filteredProducts;
            string filteredText = comboBox.Text;
            using (var uow = new UnitOfWork())
            {
                filteredProducts = await uow.ProductsRepository.FilterProducts(filteredText);
            }
            foreach (var filteredProduct in filteredProducts)
                comboBox.Items.Add(filteredProduct);

            comboBox.DroppedDown = true;
            comboBox.IntegralHeight = true;

            if (filteredProducts.Count() == 1)
            {
                comboBox.DroppedDown = false;
                comboBox.SelectedItem = filteredProducts.FirstOrDefault();
            }
            else
            {
                comboBox.SelectedIndex = -1;
                comboBox.Text = filteredText;
                comboBox.SelectionStart = filteredText.Length;
                comboBox.SelectionLength = 0;
            }
        }
    }
}
