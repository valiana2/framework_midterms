using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    public static BMIResultRepository BMIRepo { get; private set; }

    public App(BMIResultRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		BMIRepo = repo;
	}
}
