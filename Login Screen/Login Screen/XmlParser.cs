using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using main;
using NewUsers;

namespace MAIN_GUI_Mangaer_window.ma_controller
{
    public class XmlParser
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        public static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";
        public static string xmlFeedBack = $"{dataDir}\\Data\\FeedBack.xml";
        public static string xmlVipUsers = $"{dataDir}\\Data\\VipUsers.xml";
        public static string xmlOrder = $"{dataDir}\\Data\\Order.xml";

        

        public static void XmlParserVipCustomer(VipCustomer vip)
        {
            XDocument doc = XDocument.Load(xmlVipUsers);
            XElement school = doc.Element("VIPCustomers");
            school.Add(new XElement("VIPCustomer",
                       new XElement("FirstName", vip.FirstName),
                       new XElement("LastName", vip.LastName),
                       new XElement("UserName", vip.UserName),
                       new XElement("PassWord", vip.PassWord),
                       new XElement("Email", vip.Email),
                       new XElement("Adress", vip.adress),
                       new XElement("PhoneNumber", vip.PhoneNumber),
                       new XElement("CreditCard",vip.CreditCard)));
                       
            doc.Save(xmlVipUsers);
        }
        public static void XmlParserFeedback(Feedback passFeedback)
        {
            XDocument doc = XDocument.Load(xmlFeedBackPath);
            XElement school = doc.Element("Feedbacks");
            school.Add(new XElement("Feedback",
                       new XElement("FeedbackComment", passFeedback.FeedbackComment),
                       new XElement("RatedFeedback", passFeedback.RatedFeedback)
                       ));

            doc.Save(xmlFeedBackPath);
        }


    }
}
