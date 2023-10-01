using Cz.Project.Abstraction.Enums;
using Cz.Project.Dto.Enums;
using Cz.Project.Dto.Exceptions;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.UI.Forms.FormResponses;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginFormResponse response = new LoginFormResponse();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var userService = new UserService();
            if (userService.IsLoggedIn())
            {
                LogHelper.Log(LogTypeCodeEnum.Info, "Se intento loguear un usuario mientras");
                MessageBox.Show("Ya se encuentra un usuario logueado");
                this.Close();
            }

            txtUserName.Text = "Admin";
            txtUserPassword.Text = "123456789";

            this.response = new LoginFormResponse()
            {
                LoginSuccessfully = false
            };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(Session.GetInstance().AdminUser != null)
                {
                    Session.LogOut();
                }

                var user = new Dto.AdminUserDto()
                {
                    Name = txtUserName.Text,
                    Password = txtUserPassword.Text,
                };

                LogHelper.Log(LogTypeCodeEnum.Info, $"Se esta intentando iniciar sesion con el usuario: {user.Name}");

                var userService = new UserService();
                var userResponse = userService.Login(user);

                if (userResponse != null)
                {
                    this.response = new LoginFormResponse()
                    {
                        LoginSuccessfully = true
                    };

                    new BitacoraService().Add(EventTypeEnum.Log_In, $"El usuario {Session.GetInstance().AdminUser.Name} inicio sesion", Session.GetInstance().AdminUser);
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos");
            }
            catch (InvalidAdminUsersException ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, $"Error al intentar iniciar sesion -> Usuario no encontrado");
                MessageBox.Show("Usuario no encontrado");
            }
            catch (IncorrectAdminUsersPasswordException ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, $"Error al intentar iniciar sesion -> Contraseña incorrecta");
                MessageBox.Show("Contraseña incorrecta");
            }
            catch (Exception)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, $"Error al intentar iniciar sesion");
                MessageBox.Show("Algo salio mal");
            }
        }

        private void ClearAll()
        {
            txtUserName.Clear();
            txtUserPassword.Clear();
        }
    }
}
