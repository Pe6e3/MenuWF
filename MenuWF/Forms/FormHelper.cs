using MenuWF.Data;

namespace MenuWF.Forms;

public static class FormHelper
{
    public static void OpenMainForm(Form currentForm, AppDbContext db)
    {
        MainForm mainForm = new MainForm(db);
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
    public static void ExitProgramm( )
    {
        Application.Exit();
    }


}
