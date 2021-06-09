using CalculateDaysSVC.appservicesdayssvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculateDaysSVC
{
    public partial class CalculateDaySVC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularConvertToDays_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);

            // Consumir servicio web desde visual studio
            /*appservicesdayssvc.DayOperationsClient dayOperationsClient = new appservicesdayssvc.DayOperationsClient();
            int days = dayOperationsClient.ConvertToDays(day,month,year);
            lblResultado.Text = "Resultado: " + days.ToString();*/

            // Consumir servicio con una Clase Proxy Cliente
            WSDaysOperationsSVC.DayOperationsClient dayOperationsClientProxy = new WSDaysOperationsSVC.DayOperationsClient();
            int daysProxy = dayOperationsClientProxy.ConvertToDays(day, month, year);
            lblResultado.Text = "Resultado: " + daysProxy.ToString();

        }


        protected void btnCalcularCDaysBetweenDays_Click(object sender, EventArgs e)
        {
            //fecha1
            int day = int.Parse(TextBox1.Text);
            int month = int.Parse(TextBox2.Text);
            int year = int.Parse(TextBox3.Text);

            //fecha2
            int day2 = int.Parse(TextBox4.Text);
            int month2 = int.Parse(TextBox5.Text);
            int year2 = int.Parse(TextBox6.Text);

            // Consumir servicio con una Clase Proxy Cliente
            WSDaysOperationsSVC.DayOperationsClient dayOperationsClientProxy = new WSDaysOperationsSVC.DayOperationsClient();
            int daysProxy = dayOperationsClientProxy.DaysBetweenDates(day, month, year,day2,month2,year2);
            Label4.Text = "Resultado: " + daysProxy.ToString();

        }
    }
}