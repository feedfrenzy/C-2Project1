using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Assignment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            double rate = 0;
            int SA = 100;
            int A = 75;
            int N = 50;
            int D = 25;
            int SD = 0;



            string message = "Thanks for your feed "+Request["txtName"]+" ID: "+Request["txtStudentID"]+" <br />";



            if (Request.Form["optlevel1"] != null)
            {
                count++;
                if (Request.Form["optlevel1"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel1"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel1"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel1"] == "Disagree")
                    rate += D;
                else 
                    rate += SD;
            }

            if (Request.Form["optlevel2"] != null)
            {
                count++;
                if (Request.Form["optlevel2"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel2"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel2"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel2"] == "Disagree")
                    rate += D;
                else 
                    rate += SD;
            }

            if (Request.Form["optlevel3"] != null)
            {
                count++;
                if (Request.Form["optlevel3"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel3"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel3"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel3"] == "Disagree")
                    rate += D;
                else 
                    rate += SD;
            }

            if (Request.Form["optlevel4"] != null)
            {
                count++;
                if (Request.Form["optlevel4"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel4"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel4"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel4"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel5"] != null)
            {
                count++;
                if (Request.Form["optlevel5"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel5"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel5"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel5"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel6"] != null)
            {
                count++;
                if (Request.Form["optlevel6"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel6"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel6"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel6"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel7"] != null)
            {
                count++;
                if (Request.Form["optlevel7"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel7"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel7"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel7"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel8"] != null)
            {
                count++;
                if (Request.Form["optlevel8"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel8"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel8"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel8"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel9"] != null)
            {
                count++;
                if (Request.Form["optlevel9"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel9"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel9"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel9"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel10"] != null)
            {
                count++;
                if (Request.Form["optlevel10"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel10"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel10"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel10"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel11"] != null)
            {
                count++;
                if (Request.Form["optlevel11"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel11"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel11"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel11"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            if (Request.Form["optlevel12"] != null)
            {
                count++;
                if (Request.Form["optlevel12"] == "StronglyAgree")
                    rate += SA;
                else if (Request.Form["optlevel12"] == "Agree")
                    rate += A;
                else if (Request.Form["optlevel12"] == "Neutral")
                    rate += N;
                else if (Request.Form["optlevel12"] == "Disagree")
                    rate += D;
                else
                    rate += SD;
            }

            rate =  rate / count;

            message += "The satisfactory percentage for your "+Request["txtCourse"]+" course is %"+rate+".";

            lblDisplay.Text = message;
            
        }
    }
}