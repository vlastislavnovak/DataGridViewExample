using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;

namespace Forms;

public partial class Form1 : Form
{
    private AppDbContext context;
    private BindingList<User> allUsers;
    private BindingList<User> filteredUsers;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        tblUsers.AutoGenerateColumns = false;
        tblUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        tblUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "firstName",
            HeaderText = "Jm�no"
        });

        tblUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "lastName",
            HeaderText = "P��jmen�"
        });

        tblUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "birthDate",
            HeaderText = "Datum narozen�"
        });

        tblUsers.Columns.Add(new DataGridViewComboBoxColumn
        {
            DataPropertyName = "gender",
            HeaderText = "Pohlav�",
            DataSource = new char[] { 'M', 'F' }
        });

        context = new AppDbContext();

        context.ChangeTracker.AutoDetectChangesEnabled = true;

        try
        {
            context.Users.Load();

            allUsers = context.Users.Local.ToBindingList();

            filteredUsers = new BindingList<User>(allUsers.ToList());

            tblUsers.DataSource = filteredUsers;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nepoda�ilo se p�ipojit k datab�zi.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (areUsersValid() && MessageBox.Show("Opravdu chcete ulo�it zm�ny?", "Ulo�it", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            context.SaveChanges();
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        User user = new User
        {
            firstName = txtFirstName.Text,
            lastName = txtLastName.Text,
            birthDate = DateOnly.FromDateTime(dtpBirthDate.Value),
            gender = rbnMale.Checked ? 'M' : 'F'
        };

        if (isUserValid(user))
        {
            allUsers.Add(user);
            filteredUsers.Add(user);
            resetForm();
        }
    }

    private void resetForm()
    {
        txtFirstName.Clear();
        txtLastName.Clear();
        dtpBirthDate.Value = DateTime.Now;
        rbnMale.Checked = true;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in tblUsers.SelectedRows)
        {
            if (row.DataBoundItem is User user)
            {
                allUsers.Remove(user);
                filteredUsers.Remove(user);
            }
        }
    }

    private void tblUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        if (e.Row.DataBoundItem is User user)
        {
            allUsers.Remove(user);
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        context?.Dispose();
    }

    private void tblUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        MessageBox.Show(e.Exception.Message, "Chyba dat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        // Prevent default error window
        e.ThrowException = false;

        tblUsers.CancelEdit();
    }

    private bool areUsersValid()
    {
        foreach (User user in allUsers)
        {
            if (!isUserValid(user))
            {
                MessageBox.Show("Jm�no a p��jmen� je povinn�.");
                return false;
            }
        }
        return true;
    }

    private bool isUserValid(User user)
    {
        return (!string.IsNullOrWhiteSpace(user.firstName) && !string.IsNullOrWhiteSpace(user.lastName));
    }

    private void tblUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        tblUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string lowerSearch = txtSearch.Text.ToLower();

        List<User> results = allUsers
            .Where(u => (u.firstName?.ToLower().Contains(lowerSearch) ?? false) ||
                        (u.lastName?.ToLower().Contains(lowerSearch) ?? false))
            .ToList();

        filteredUsers = new BindingList<User>(results);
        tblUsers.DataSource = filteredUsers;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (context.ChangeTracker.HasChanges())
        {
            var result = MessageBox.Show(
                "M�te neulo�en� zm�ny. Chcete je ulo�it p�ed ukon�en�m?",
                "Upozorn�n�",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                context.SaveChanges();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}