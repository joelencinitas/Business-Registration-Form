using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Registration_Form.Entities;
using System.Net.Mail;
using System.Text.RegularExpressions;


namespace Business_Registration_Form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PostBack = 0;
            BusinessRegistrationForm m_Form = new BusinessRegistrationForm();
            return View("Home", m_Form);
        }


        [HttpPost]
        public ActionResult ProcessForm(BusinessRegistrationForm m_Form)
        {
            ViewBag.PostBack = 1;

            if(m_Form.CompanyType == "0")
            {
                ModelState.AddModelError("CompanyType", "Please enter a valid Company Type");
            }
            if(m_Form.Perjury == null || m_Form.Perjury != "on")
            {
                ModelState.AddModelError("Perjury", "Please check the Perjury Statement check box!");
            }

            if(((m_Form.AgentFirstName != null && m_Form.AgentFirstName.Length > 0) || (m_Form.AgentLastName != null && m_Form.AgentLastName.Length > 0)) && (m_Form.AgentEmail != null && m_Form.AgentEmail.Length == 0))
            {
                ModelState.AddModelError("AgentEmail", "Agent Email is required");
            }
            if (ModelState.IsValid)
            {
                string emailBody = "";
                emailBody += "<table><tr><td>Field:</td><td>Value:</td></tr>";

                foreach (string key in Request.Form.Keys)
                {
                    string m_key = Regex.Replace(key, "([a-z])([A-Z])", "$1 $2");
                    emailBody += "<tr><td><b>" + m_key + "</b></td><td>" + Request.Form[key] + "</td></tr>";
                }

                emailBody += "<tr><td>Submission Date</td><td>" + DateTime.Now + "</td></tr>";
                emailBody += "</table>";

                MailMessage mail = new MailMessage("noreply@encinitasca.gov", "clerkstaff@encinitasca.gov", "Business Registration Submission", emailBody);
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("192.168.1.80");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = false;
                client.Send(mail);

                return View("ProcessForm");
            }
            else
            {
                return View("Home", m_Form);
            }
        }
    }
}