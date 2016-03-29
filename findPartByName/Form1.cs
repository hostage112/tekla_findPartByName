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

using Tekla.Structures;
using Tekla.Structures.Model;
using TSM = Tekla.Structures.Model;

namespace findPartByName
{
    public partial class Form1 : Form
    {
        private List<onePart> allParts = new List<onePart>();
        private string findName = "EB-1-1004";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();

            if (myModel.GetConnectionStatus())
            {
                System.Type[] selectionType = new System.Type[1];
                selectionType.SetValue(typeof(Beam), 0);
                ModelObjectEnumerator myEnum = myModel.GetModelObjectSelector().GetAllObjectsWithType(selectionType);

                while (myEnum.MoveNext())
                {
                    if (myEnum.Current != null)
                    {
                        Part currentPart = myEnum.Current as Part;
                        allParts.Add(new onePart(currentPart));
                    }
                }

                MessageBox.Show("GG" + "\n" + allParts.Count.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("find:" + findName);
           // MessageBox.Show(allParts.Count.ToString());

            ArrayList select = new ArrayList();

            foreach (onePart currentPart in allParts)
            {
                if (findName == currentPart._name)
                {
                    //MessageBox.Show("found");
                    Model myModel = new Model();
                    Part foundPart = myModel.SelectModelObject(currentPart._id) as Part;
                    select.Add(foundPart);
                    //break;
                }
            }

            var ModelSelector = new TSM.UI.ModelObjectSelector();
            ModelSelector.Select(select);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            findName = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = findName;
        }
    }

    public class onePart
    {
        public string _name;
        public Identifier _id;

        public onePart(Part part)
        {
            _name = part.Name;
            _id = part.Identifier;
        }
    }

}
