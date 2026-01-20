using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Testcase
{
    public partial class Form1 : Form
    {
        // 🔴 KẾT NỐI ĐÚNG DATABASE OrganizationDB
        private readonly string connectionString =
            @"Data Source=DESKTOP-AV9ONFH\SQLEXPRESS;Initial Catalog=OrganizationDB;Integrated Security=True";

        private int currentOrgId = -1;

        public Form1()
        {
            InitializeComponent();
            btnDirector.Enabled = false;
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errors = ValidateInput();

            if (errors.Count > 0)
            {
                MessageBox.Show(
                    string.Join("\n", errors),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (IsOrgNameExists(txtOrgName.Text.Trim()))
            {
                MessageBox.Show(
                    "Organization Name already exists",
                    "Duplicate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            currentOrgId = InsertOrganization();

            MessageBox.Show(
                "Save successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnDirector.Enabled = true;
        }

        // ================= BACK =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ================= DIRECTOR =================
        private void btnDirector_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Director Management\nOrgID = {currentOrgId}\nOrgName = {txtOrgName.Text}",
                "Director",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ================= VALIDATE =================
        private List<string> ValidateInput()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtOrgName.Text))
                errors.Add("Organization Name is required");
            else if (txtOrgName.Text.Length < 3 || txtOrgName.Text.Length > 255)
                errors.Add("Organization Name must be 3–255 characters");

            if (!string.IsNullOrWhiteSpace(txtPhone.Text) &&
                !Regex.IsMatch(txtPhone.Text, @"^\d{9,12}$"))
                errors.Add("Phone must contain 9–12 digits");

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errors.Add("Invalid email format");

            return errors;
        }

        // ================= CHECK DUPLICATE =================
        private bool IsOrgNameExists(string orgName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql =
                    "SELECT COUNT(*) FROM ORGANIZATION WHERE LOWER(OrgName) = LOWER(@OrgName)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrgName", orgName);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // ================= INSERT =================
        private int InsertOrganization()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    INSERT INTO ORGANIZATION (OrgName, Address, Phone, Email)
                    OUTPUT INSERTED.OrgID
                    VALUES (@OrgName, @Address, @Phone, @Email)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrgName", txtOrgName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address",
                    string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text);
                cmd.Parameters.AddWithValue("@Phone",
                    string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email",
                    string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
