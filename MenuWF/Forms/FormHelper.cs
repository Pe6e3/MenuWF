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
 
}
