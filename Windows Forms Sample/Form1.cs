using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Windows_Forms_Sample
{
    public partial class Form1 : Form
    {

        //Note: connection to database is all in this class only for easier reference, but its not a recommended practice.

        //variables needed to form connection string to connect to database
        //when creating your own database: please follow the name of database, and name of table
        private const string serverName = "localhost";
        private const string dataBaseName = "StudentRecordDB";
        private const string uid = "root";
        private const string password = "P@ssw0rd123!..";
        
        //set value of index to 0, needed when accessing data
        private int index = 0;

        //initialize class for DataTable
        //DataTable -used to store data in a tabular format,
        private DataTable dt = new DataTable();


        //variables where value of username and password from database will be stored
        public string uname;
        public string pword;

        //initialize properties

        //Represents a connection to database
        public MySqlConnection con { get; set; }
        public MySqlCommand cmd { get; set; }
        public MySqlDataReader dr { get; set; }

        public int id { get; set; }
        public string username { get; set; }
        public string passsword { get; set; }

        //public Form1() { }
        public Form1(string username, string password)
        {
            this.username = username;
            this.passsword = password;
        }


        public Form1()
        {
            con = new MySqlConnection($"Server = {serverName} ; Database = " +
                $"{dataBaseName}; Uid = {uid}; Pwd = {password};");
            cmd = new MySqlCommand();
            cmd.Connection = this.con;
            InitializeComponent();
            if (!Connect())
                MessageBox.Show("Please Configure Your Connection");
        }

        public bool Connect()
        {
            if (this.con.State == ConnectionState.Closed || this.con.State == ConnectionState.Broken)
            {
                try
                {
                    this.con.Open();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        //method to connect to disconnect
        public void Disconnect()
        {
            if (this.con.State == ConnectionState.Open)
            {
                this.con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                load_users();
                //this.fill_TextBoxes(index);
            }
            else
            {
                Application.Exit();
            }
        }

        private void load_users()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from USERLOGINTB";
            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
        }

        private void usercred(int i)
        {
            uname = dt.Rows[i][1].ToString();
            pword = dt.Rows[i][2].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mock data
            //string userName = "Desire";
            //string passWord = "123";

            usercred(index);
            if (UsernameTxtbox.Text == uname && PasswordTxtBox.Text == pword)
            {
                Form form2 = new Form2();
                form2.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(UsernameTxtbox.Text))
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                    UsernameTxtbox.Focus();
                }
                else if (string.IsNullOrEmpty(PasswordTxtBox.Text))
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Password is required");
                    PasswordTxtBox.Focus();
                }
                else if (string.IsNullOrEmpty(UsernameTxtbox.Text) && string.IsNullOrEmpty(PasswordTxtBox.Text))
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                    UsernameTxtbox.Focus();
                    ErrorProvider1.SetError(PasswordTxtBox, "Password is required");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != uname && PasswordTxtBox.Text != pword)
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the right username");
                    UsernameTxtbox.Focus();
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the right password");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != uname)
                {

                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the right username");
                    UsernameTxtbox.Focus();

                }
                else if (PasswordTxtBox.Text != pword)
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the right password");
                    PasswordTxtBox.Focus();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
