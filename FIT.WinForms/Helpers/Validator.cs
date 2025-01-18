
namespace FIT.WinForms.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string name, bool jelBroj = false)
        {
            bool validanUnos = true;
            if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                validanUnos = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validanUnos = false;
            else if (kontrola is TextBox && !(kontrola as TextBox).Text.Postavljen())
                validanUnos = false;
            else if (kontrola is RichTextBox && !(kontrola as RichTextBox).Text.Postavljen())
                validanUnos = false;
            else if (kontrola is TextBox && jelBroj)
                if(!JelBroj((kontrola as TextBox).Text))
                    validanUnos = false;


            if (!validanUnos)
            {
                err.SetError(kontrola, Resursi.Get(name));
                return false;
            }
            err.Clear();
            return true;
        }

        private static bool JelBroj(string text)
        {
            try
            {
                int.Parse(text);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
