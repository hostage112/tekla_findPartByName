using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tekla.Structures;
using TSF = Tekla.Structures.Filtering;
using TFC = Tekla.Structures.Filtering.Categories;
using Tekla.Structures.Model;
using TSM = Tekla.Structures.Model;

namespace findPartByName
{
    static class teklaHandler
    {
        public static partCollection getModel()
        {
            Model myModel = new Model();
            partCollection allParts = new partCollection();

            if (myModel.GetConnectionStatus())
            {
                System.Type[] selectionType = new System.Type[3];

                selectionType.SetValue(typeof(Beam), 0);
                selectionType.SetValue(typeof(ContourPlate), 1);
                selectionType.SetValue(typeof(Assembly), 2);

                ModelObjectEnumerator myEnum = myModel.GetModelObjectSelector().GetAllObjectsWithType(selectionType);

                allParts = getPartInfo(allParts, myEnum);
            }

            return allParts;
        }

        public static partCollection getPartInfo(partCollection allParts, ModelObjectEnumerator myEnum)
        {
            while (myEnum.MoveNext())
            {
                if (myEnum.Current is Part)
                {
                    allParts.parts.Add(new elementData(myEnum.Current as Part));
                }
                else if (myEnum.Current is Assembly)
                {
                    allParts.assemblys.Add(new elementData(myEnum.Current as Assembly));
                }
            }

            return allParts;
        }

        public static void selectFoundObject(ArrayList selectId)
        {
            ArrayList select = new ArrayList();

            Model myModel = new Model();

            foreach (Identifier id in selectId)
            {
                ModelObject foundPart = myModel.SelectModelObject(id) as ModelObject;
                select.Add(foundPart);
            }

            var ModelSelector = new TSM.UI.ModelObjectSelector();
            ModelSelector.Select(select);
        }
    }
}
