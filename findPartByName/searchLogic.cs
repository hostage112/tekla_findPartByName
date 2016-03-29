using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace findPartByName
{
    static class searchLogic
    {
        public static ArrayList findElements(List<elementData> allParts, string value, string searchType)
        {
            ArrayList select;

            if (searchType == "name")
            {
                select = searchByName(allParts, value);
            }
            else if (searchType == "position")
            {
                select = searchByPosition(allParts, value);
            }
            else
            {
                select = new ArrayList();
            }

            return select;
        }

        public static ArrayList searchByName(List<elementData> allParts, string value)
        {
            ArrayList select = new ArrayList();

            foreach (elementData currentPart in allParts)
            {
                if (value == currentPart._name)
                {
                    select.Add(currentPart._id);
                }
            }

            return select;
        }

        public static ArrayList searchByPosition(List<elementData> allParts, string value)
        {
            ArrayList select = new ArrayList();

            foreach (elementData currentPart in allParts)
            {
                if (value == currentPart._position)
                {
                    MessageBox.Show(currentPart._position);
                    select.Add(currentPart._id);
                }
            }

            return select;
        }


    }
}
