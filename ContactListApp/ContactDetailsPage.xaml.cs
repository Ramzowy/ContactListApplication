namespace ContactListApp;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage(Contact contact)
	{
		InitializeComponent();
		BindingContext = contact;
	}

	private void OnBackButtonClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}