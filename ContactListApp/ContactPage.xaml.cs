using System.Security.Cryptography.X509Certificates;

namespace ContactListApp
{
    public partial class ContactPage : ContentPage
    {
       public List<ContactGroup> ContactGroups  = new List<ContactGroup>();

        public ContactPage()
        {
            InitializeComponent();

            List<Contact> contacts = new List<Contact>
            {
                new Contact {name = "Anna", phoneNumber="519-660-7894", email ="gty@mail.com", description="Nice Girl", imageName="pi2c.png"},
                new Contact {name = "Benjamin", phoneNumber="619-661-7895", email ="gt2@mail.com", description="Nice Guy", imageName="pi1c.png"},
                new Contact {name = "Charlotte", phoneNumber="519-662-7896", email ="gt3@mail.com", description="Cool girl", imageName="pi4c.png"},
                new Contact {name = "Christopher", phoneNumber="813-663-7897", email ="gt4@mail.com", description="Cool guy", imageName="pi3c.png"},
                new Contact {name = "Cameron", phoneNumber="919-664-7898", email ="gt5@mail.com", description ="Nice Guy", imageName="pi1c.png"},
                new Contact {name = "Bella", phoneNumber="419-665-7899", email ="gt6@mail.com", description="Bright Girl", imageName="pi2c.png"},
                new Contact {name = "Aaron", phoneNumber="719-666-7890", email ="gt7@mail.com", description="Bright Guy", imageName="pi3c.png"},
                new Contact {name ="Bill", phoneNumber= "512-757-0970", email="gt8@mail.com", description="Brilliant Boy", imageName="pi1c.png"},
                new Contact {name ="Caleb", phoneNumber= "912-756-0870", email="gt9@mail.com", description="Cool kid", imageName="pi1c.png" },
                new Contact {name="Ava", phoneNumber="863-769-9590", email="gt10@mail.com", description="Beautiful girl", imageName="pi2c.png" },
                new Contact {name = "Brandon", phoneNumber="863-769-9590", email="gt11@mail.com", description="Handsome guy", imageName="pi3c.png" },
                new Contact {name = "Bryce", phoneNumber="866-769-9590", email="gt12@mail.com", description="Handsome guy", imageName="pi3c.png" },
                new Contact {name = "Andrew", phoneNumber="863-769-9590", email="gt13@mail.com", description="Handsome guy", imageName="pi3c.png" },
                new Contact {name = "Alexander", phoneNumber="863-769-9590", email="gt14@mail.com", description="Handsome guy", imageName="pi3c.png" },
                new Contact {name = "Amelia", phoneNumber="863-769-9590", email="gt15@mail.com", description="Nice girl", imageName="pi4c.png" }
                };

                ContactGroups.Add( new ContactGroup("A", new List<Contact>{
                  new Contact(){name = "Aaron", phoneNumber="719-666-7890", email ="gt7@mail.com", description="Bright Guy", imageName="pi3c.png"},
                  new Contact() {name = "Alexander", phoneNumber="863-769-9590", email="gt14@mail.com", description="Handsome guy", imageName="pi3c.png" },
                  new Contact() {name = "Amelia", phoneNumber="863-769-9590", email="gt15@mail.com", description="Nice girl", imageName="pi4c.png" },
                  new Contact() {name = "Anna", phoneNumber="519-660-7894", email ="gty@mail.com", description="Nice Girl", imageName="pi2c.png"},
                  new Contact(){name="Ava", phoneNumber="863-769-9590", email="gt10@mail.com", description="Beautiful girl", imageName="pi2c.png"}
                }));


               ContactGroups.Add(new ContactGroup("B", new List<Contact>{
                 new Contact(){name = "Bella", phoneNumber="419-665-7899", email ="gt6@mail.com", description="Bright Girl", imageName="pi2c.png"},
                 new Contact() {name = "Benjamin", phoneNumber="619-661-7895", email ="gt2@mail.com", description="Nice Guy", imageName="pi1c.png"},
                 new Contact() {name ="Bill", phoneNumber= "512-757-0970", email="gt8@mail.com", description="Brilliant Boy", imageName="pi1c.png"},
                 new Contact(){name = "Brandon", phoneNumber="863-769-9590", email="gt11@mail.com", description="Handsome guy", imageName="pi3c.png" },
                 new Contact(){name = "Bryce", phoneNumber="866-769-9590", email="gt12@mail.com", description="Handsome guy", imageName="pi3c.png" }
                }));


              ContactGroups.Add(new ContactGroup("C", new List<Contact>{
                 new Contact(){name = "Charlotte", phoneNumber="519-662-7896", email ="gt3@mail.com", description="Cool girl", imageName="pi4c.png"},
                 new Contact(){name = "Christopher", phoneNumber="813-663-7897", email ="gt4@mail.com", description="Cool guy", imageName="pi3c.png"},
                 new Contact(){name ="Caleb", phoneNumber= "912-756-0870", email="gt9@mail.com", description="Cool kid", imageName="pi1c.png" },
                 new Contact(){name = "Cameron", phoneNumber="919-664-7898", email ="gt5@mail.com", description ="Nice Guy", imageName="pi1c.png"},
                 new Contact(){name = "Czech", phoneNumber="866-769-9590", email="gt12@mail.com", description="Handsome guy", imageName="pi3c.png" }
                }));

            ContactList.ItemsSource = ContactGroups;

            BindingContext = this;
        }


             
           private void OnSelection(object sender, SelectionChangedEventArgs e)
        {
          
             
            var contact = e.CurrentSelection.FirstOrDefault() as Contact;

            if(contact == null)  return;

            Navigation.PushAsync(new ContactDetailsPage(contact));
          
            ((CollectionView)sender).SelectedItem = null;
        }
 
     }

}
