using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiApp.Helpers
{
    public class Constants
    {
        #region Singleton
        private static Constants instance;

        public static Constants Instance
        {
            get
            {
                if (instance == null)
                    instance = new Constants();
                return instance;
            }
        }

        private Constants() { }
        #endregion
        


        public void InitializeConstants()
        {
            
        }
    }
}
