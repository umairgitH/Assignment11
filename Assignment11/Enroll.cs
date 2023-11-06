using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment11
{
    internal class Enroll: ISendNotification
    {
        public void ViewTrainings()
        {

        }
        public void Apply()
        {
            // Enter Name, Dept, Manager, Email, NIC, Mobile number
        }
        public void SubmitApplicaton()
        {
           
        }
        public void SendNotif()
        {
            //After submission of application, his manager should receive a nitification
        }
        public void CheckApplication()
        {
            // If no pre-requisite employee should not allowed to be enrolled
        }

    }
}
