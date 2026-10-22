
namespace Intenis_Linoy;

public partial class InTenYears2 : ContentPage
{
	public InTenYears2()
	{
		InitializeComponent();
	}

    private void Butten_Clicked(object sender, EventArgs e)
    {
        int age = 10 + int.Parse(entryAge.Text);
        string personName = entryName.ToString();

        result.Text = "In ten years from now " + personName + " will be " + age + " years old";
    }
}