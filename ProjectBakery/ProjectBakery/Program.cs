using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ProjectBakery.GUI_Layer;

namespace ProjectBakery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool check = true;
            while(check)
            {
                check = false;
                GUI_Layer.LoginForm loginForm = new GUI_Layer.LoginForm();
                Application.Run(loginForm);

                if(loginForm.IsLogin == true && loginForm.user.role!="Customer")
                {
                    MainForm mainForm = new MainForm(loginForm.user);
                    Application.Run(mainForm);
                    if (mainForm.IsLogout == true)
                    {
                        check = true;
                    }
                }

                else if(loginForm.IsLogin == true && loginForm.user.role == "Customer")
                {
                    MainFormCustomer mainFormCustomer = new MainFormCustomer(loginForm.user);
                    Application.Run(mainFormCustomer);
                    if (mainFormCustomer.IsLogout == true)
                        check = true;
                }

                if(loginForm.IsRegister == true)
                {
                    RegisterForm registerForm = new RegisterForm();
                    Application.Run(registerForm);
                    if (registerForm.IsLogin == true)
                        check = true;
                }
            }
        }
    }
}
