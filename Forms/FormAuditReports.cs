using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.Forms
{
    public partial class FormAuditReports : Form
    {
        // Declare the list at the class level
        private List<string> allChoices = new List<string>
        {
            //example
            "Babag",
            "Bakayam",
            "Bjakjlf",
            "Bjkahd",
            "Aabag",
            "Aakayam",
            "Ajakjlf",
            "Ajkahd",
            // Add more choices as needed
        };

        public FormAuditReports()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower(); // Trim to remove leading and trailing whitespaces

            if (!string.IsNullOrEmpty(keyword))
            {
                List<string> filteredChoices = allChoices
                    .Where(choice => choice.ToLower().StartsWith(keyword))
                    .ToList();

                UpdateFlowLayoutPanel(filteredChoices);
                fLpChoices.Visible = true;
            }
            else
            {
                fLpChoices.Visible = false;
            }
        }

        private void UpdateFlowLayoutPanel(List<string> filteredChoices)
        {
            fLpChoices.Controls.Clear();

            foreach (string choice in filteredChoices)
            {
                Label label = new Label
                {
                    Text = choice,
                    // Add more label properties as needed
                };

                fLpChoices.Controls.Add(label);
            }
        }
    }
}
