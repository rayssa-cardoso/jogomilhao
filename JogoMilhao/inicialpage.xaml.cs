namespace JogoMilhao;

public partial class inicialpage : ContentPage
{
    public inicialpage()
    {
        InitializeComponent();
    }

    public void botaoComecar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}