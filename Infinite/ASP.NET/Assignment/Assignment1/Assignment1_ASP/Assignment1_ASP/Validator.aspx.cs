using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_ASP
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Response.Redirect("ConfirmationPage.aspx"); // Redirect to confirmation page if validation succeeds
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Check if Name is different from Family Name
            if (txtName.Text.Trim().Equals(txtFamilyName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                rfvName.ErrorMessage = "Name must be different from Family Name";
                rfvName.IsValid = false;
                isValid = false;
            }

            // Check if Address has at least 2 characters
            if (txtAddress.Text.Trim().Length < 2)
            {
                rfvAddress.ErrorMessage = "Address must contain at least 2 letters";
                rfvAddress.IsValid = false;
                isValid = false;
            }

            // Check if City has at least 2 characters
            if (txtCity.Text.Trim().Length < 2)
            {
                rfvCity.ErrorMessage = "City must contain at least 2 letters";
                rfvCity.IsValid = false;
                isValid = false;
            }

            // Check if Zip Code is 5 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtZipCode.Text.Trim(), @"^\d{5}$"))
            {
                revZipCode.ErrorMessage = "Zip Code should be 5 digits";
                revZipCode.IsValid = false;
                isValid = false;
            }

            // Check if Phone is in format XX-XXXXXXX or XXX-XXXXXXX
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{2,3}-\d{7}$"))
            {
                revPhone.ErrorMessage = "Phone should be in format XX-XXXXXXX or XXX-XXXXXXX";
                revPhone.IsValid = false;
                isValid = false;
            }

            // Check if Email is a valid email
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
            {
                revEmail.ErrorMessage = "Invalid Email format";
                revEmail.IsValid = false;
                isValid = false;
            }

            return isValid;
        }

        protected void txtZipCode_TextChanged(object sender, EventArgs e)
        {


        }
    }
}