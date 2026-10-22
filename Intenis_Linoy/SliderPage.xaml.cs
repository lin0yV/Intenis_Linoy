using static Android.Icu.Text.UnicodeSet;

namespace Intenis_Linoy;

public partial class SliderPage : ContentPage
{
	private int age = 0;
	public SliderPage()
	{
		InitializeComponent();
        entryAge.Text = "0";
	}

	private void sliderAge_ValueChanged_1(object sender, EventArgs e)
	{
		age =(int)sliderAge.Value;
        entryAge.Text =age.ToString();
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
	{
		result.Text = "In 10 yers from now" + entryName.Text + "will be " + (age + 10) + "years old";

    }
}