using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace findPartByName
{
    public partial class Form1 : Form
    {
        private partCollection allParts = new partCollection();
        private List<elementData> searchedParts = new List<elementData>();

        private string searchValue = "EB-1-1004";
        private string searchType = "name";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_model_label();
            txt_search_value.Text = searchValue;
            lbl_results.Text = "";
            btn_get_model.Text = "Load model";
        }

        private void btn_get_model_Click(object sender, EventArgs e)
        {
            btn_get_model.Enabled = false;
            lbl_model_status.Text = "Loading...";

            allParts = teklaHandler.getModel();

            update_model_label();
            update_button_status();

            btn_get_model.Enabled = true;
        }

        private void update_model_label()
        {
            lbl_model_status.Text = DateTime.Now.ToString("h:mm:ss") + "\n" +
                allParts.assemblys.Count + " assemblys in memory\n" +
                allParts.parts.Count.ToString() + " parts in memory";
        }

        private void update_button_status()
        {
            if (allParts.parts.Count > 0 || allParts.assemblys.Count > 0)
            {
                btn_get_model.Text = "Reload model";

                txt_search_value.Enabled = true;
                btn_select.Enabled = true;
                rb_assembly.Enabled = true;
                rb_parts.Enabled = true;
                rb_position.Enabled = true;
                rb_name.Enabled = true;
            }
            else
            {
                txt_search_value.Enabled = false;
                btn_select.Enabled = false;
                rb_assembly.Enabled = false;
                rb_parts.Enabled = false;
                rb_position.Enabled = false;
                rb_name.Enabled = false;
            }
        }

        private void txt_search_value_TextChanged(object sender, EventArgs e)
        {
            searchValue = txt_search_value.Text;
        }

        private void btn_select_Click(object sender, EventArgs e)
        { 
            if (rb_guid.Checked)
            {
                teklaHandler.selectInModel(searchValue);
                lbl_results.Text = "Selecting by GUID";
            }
            else
            {
                if (rb_name.Checked)
                {
                    searchType = "name";
                }
                if (rb_position.Checked)
                {
                    searchType = "position";
                }

                if (rb_parts.Checked)
                {
                    searchedParts = allParts.parts;
                }
                if (rb_assembly.Checked)
                {
                    searchedParts = allParts.assemblys;
                }

                ArrayList select = searchLogic.findElements(searchedParts, searchValue, searchType);
                teklaHandler.selectFoundObject(select);
                lbl_results.Text = select.Count.ToString() + " item(s) found";
            }
        }


        private void txt_search_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_select.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


        private void rb_guid_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_guid.Checked)
            {
                rb_parts.Enabled = false;
                rb_assembly.Enabled = false;
            }
            else
            {
                rb_parts.Enabled = true;
                rb_assembly.Enabled = true;
            }
        }

    }
}
