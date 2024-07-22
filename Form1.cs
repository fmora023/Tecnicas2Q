using ControllerClase;
using ModelClase.Interface;
using System.Reflection.Metadata.Ecma335;

namespace DemoClase
{
    /// <summary>
    /// View represention of user list.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        private List<IPersona> UserList { get; set; }

        private UserController UserController { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.UserList = new List<IPersona>();
            this.UserController = new UserController();
            InitializeComponent();
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            this.UserList = this.UserController.GetUsers();
            var listView = this.CreateListView();
            this.FillListView(listView, this.UserList);
            this.Controls.Add(listView);
        }

        private ListView CreateListView()
        {
            var listView = new ListView()
            {
                Name = "listView1",
                Location = new Point(12, 12),
                Size = new Size(350, 426),
                View = View.Details,
                Visible = true,
                Enabled = true,
            };

            return listView;
        }

        private void FillListView(ListView listView, List<IPersona> userList)
        {
            listView.Columns.Add(userList[0].Name, 100, HorizontalAlignment.Left);
            listView.Columns.Add(userList[0].LastName, 100, HorizontalAlignment.Left);
            listView.Columns.Add(userList[0].Country, 100, HorizontalAlignment.Left);

            for (var i = 1; i < this.UserList.Count; i++)
            {
                listView.Items.Add(new ListViewItem([userList[i].Name, userList[i].LastName, userList[i].Country]));
            }
        }
    }
}
