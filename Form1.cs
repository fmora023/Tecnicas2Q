using ControllerClase;
using ModelClase.Interface;

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
            MessageBox.Show(this.UserList[1].ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
