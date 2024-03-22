using Cz.Project.Dto;
using Cz.Project.GenericServices;
using System;
using System.Windows.Forms;
using Cz.Project.Abstraction.Exceptions;
using Cz.Project.GenericServices.UserSession;

namespace Cz.Project.UI.Forms
{
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var adminUserDto = new AdminUserDto()
                {
                    Name = txtName.Text,
                    Password = txtPassword.Text
                };

                var userService = new UserService();
                userService.Add(adminUserDto);

                RefreshList();
                MessageBox.Show("Usuario creado correctamente");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fallo la crecion de usuario, intentelo nuevamente");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem == null)
                    throw new CustomException("No hay items seleccionados");

                var selectedUser = (AdminUserDto)lstUsers.SelectedItems[0];

                if (selectedUser.Key == Session.GetInstance().AdminUser.Key)
                {
                    MessageBox.Show("No se puede eliminar el usuario porque esta siendo usado");
                    return;
                }

                var sqlUserContext = new UserService();
                sqlUserContext.Delete(selectedUser);

                RefreshList();
                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fallo la crecion de usuario, intentelo nuevamente");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem == null)
                    throw new CustomException("No hay items seleccionados");

                var selectedUser = (AdminUserDto)lstUsers.SelectedItems[0];

                var newUserValues = new AdminUserDto()
                {
                    Name = txtName.Text,
                    Password = txtPassword.Text
                };

                var userService = new UserService();
                userService.Update(selectedUser, newUserValues);

                RefreshList();
                MessageBox.Show("Usuario creado correctamente");
            }
            catch (CustomException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Fallo la crecion de usuario, intentelo nuevamente");
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem == null)
                    throw new Exception("No se selecciono ningun usuario");

                if (lstHistoricalInformation.SelectedItem == null)
                    throw new Exception("No se selecciono ningun dato historico para recuperar");

                var selectedHistoricalUser = (AdminUserHistoricalDto)lstHistoricalInformation.SelectedItem;
                var user = new UserService().GetByName(selectedHistoricalUser.Name);

                if (user != null)
                    throw new Exception("No se puede recuperar un usuario historico porque ese nombre esta siendo ocupado por otro usuario actual");

                var selectedUser = (AdminUserDto)lstUsers.SelectedItem;
                new AdminUserHistoricalService().RecoverUser(selectedUser, selectedHistoricalUser);
                this.RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillHistoricalList();
        }

        private void RefreshList()
        {
            try
            {
                lstUsers.Items.Clear();

                var userService = new UserService();
                var users = userService.GetAll();

                foreach (var user in users)
                {
                    lstUsers.Items.Add(user);
                }

                this.FillHistoricalList();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void FillHistoricalList()
        {
            lstHistoricalInformation.Items.Clear();

            if (lstUsers.SelectedItem == null)
                return;

            var selectedUser = (AdminUserDto)lstUsers.SelectedItems[0];
            var historicalData = new AdminUserHistoricalService().GetByAdminUser(selectedUser.Key);

            foreach (var item in historicalData)
            {
                lstHistoricalInformation.Items.Add(item);
            }
        }
    }
}
