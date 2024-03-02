using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Iris
{
    class D_LoginData
    {
        static int EmIDs;
        static string PoNames;
        static int PoIDs;
        static int SoIDs;
        static string SoNames;
        static DateTime LogDates;
        public static int EmID
        { get { return EmIDs; } set { EmIDs = value; } }
        public static string PoName
        { get { return PoNames; } set { PoNames = value; } }
        public static int PoID
        { get { return PoIDs; } set { PoIDs = value; } }
        public static string SoName
        { get { return SoNames; } set { SoNames = value; } }
        public static int SoID
        { get { return SoIDs; } set { SoIDs = value; } }
        public static DateTime LogDate
        { get { return LogDates; } set { LogDates = value; } }
    }
}
