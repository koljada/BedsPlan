using System;
using Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace BedsPlan
{
    public partial class ThisWorkbook
    {
        public BedsForm Form { get; set; }

        private void ThisWorkbook_Startup(object sender, EventArgs e)
        {
            Globals.Beds.Protect("poIu12zXc");
            Globals.Beds.Visible = XlSheetVisibility.xlSheetHidden;
            Form = new BedsForm();
            Form.ShowDialog();
        }

        private void ThisWorkbook_Shutdown(object sender, EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += (ThisWorkbook_Startup);
            Shutdown += (ThisWorkbook_Shutdown);
        }

        #endregion
    }
}