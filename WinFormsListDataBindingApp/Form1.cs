namespace WinFormsListDataBindingApp
{
    public partial class Form1 : Form
    {
        List<User> users;

        public Form1()
        {
            InitializeComponent();

            users = new List<User>()
            {
                new()
                {
                    FirstName = "Bobby",
                    LastName = "Smith",
                    BirthDate = new(1999, 5, 21),
                    Admin = true,
                },
                new()
                {
                    FirstName = "Tommy",
                    LastName = "Whotson",
                    BirthDate = new(2001, 11, 3),
                    Admin = false,
                },
                new()
                {
                    FirstName = "Leopold",
                    LastName = "Twen",
                    BirthDate = new(1982, 2, 16),
                    Admin = false,
                },
            };

            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "LastName";
            lstUsers.ValueMember = "LastName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.Add(new()
            {
                LastName = "Goodwin",
                FirstName = "Jonny",
                BirthDate = new(2002, 7, 11),
                Admin = true
            });

            string str = "";
            foreach (var user in users)
                str += user + "\n";
            MessageBox.Show(str);
        }
    }
}
