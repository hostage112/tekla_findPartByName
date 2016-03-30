using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tekla.Structures;
using Tekla.Structures.Model;
using TSM = Tekla.Structures.Model;

namespace findPartByName
{
    class partCollection
    {
        public List<elementData> parts;
        public List<elementData> assemblys;

        public partCollection()
        {
            parts = new List<elementData>();
            assemblys = new List<elementData>();
        }
    }

    class elementData
    {
        public string _name;
        public string _position;
        public Identifier _id;

        public elementData(Part part)
        {
            _name = part.Name;
            part.GetReportProperty("PART_POS", ref _position);
            _id = part.Identifier;
        }

        public elementData(Assembly assembly)
        {
            _name = assembly.Name;
            assembly.GetReportProperty("ASSEMBLY_POS", ref _position);
            _id = assembly.Identifier;
        }
    }

}
