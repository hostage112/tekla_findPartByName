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
        private List<elementData> allParts = new List<elementData>();
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
            lbl_results.Text = "Nothing selected";
        }

        private void update_button_status()
        {
            if (allParts.Count > 0)
            {
                txt_search_value.Enabled = true;
                btn_select.Enabled = true;
            }
            else
            {
                txt_search_value.Enabled = false;
                btn_select.Enabled = false;
            }
        }

        private void btn_get_model_Click(object sender, EventArgs e)
        {
            allParts = teklaHandler.getModel();
            update_model_label();
            update_button_status();
        }

        private void txt_search_value_TextChanged(object sender, EventArgs e)
        {
            searchValue = txt_search_value.Text;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ArrayList select = searchLogic.findElements(allParts, searchValue, searchType);
            teklaHandler.selectFoundObject(select);
            lbl_results.Text = select.Count.ToString() + " items selected.";
        }

        private void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_name.Checked)
            {
                searchType = "name";
            }
            else
            {
                searchType = "position";
            }
        }

        private void update_model_label()
        {
            lbl_model_status.Text = allParts.Count.ToString() + " parts in memory.";
        }
    }
}
