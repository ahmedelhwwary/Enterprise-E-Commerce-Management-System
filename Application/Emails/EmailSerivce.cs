using AutoMapper;
using Azure.Core;
using Enterprise_E_Commerce_Management_System.Application.Emails.Results;
using Enterprise_E_Commerce_Management_System.Infrastructures;
using Enterprise_E_Commerce_Management_System.Models.ApplicationUserRoles;
using Enterprise_E_Commerce_Management_System.ViewModels.Role;
using Microsoft.Identity.Client;
using System.Net;
using System.Net.Mail; 
namespace Enterprise_E_Commerce_Management_System.Application.Emails
{
    public class EmailSerivce : IEmailSerivce
    {
        /// <summary>
        /// You can not use outlook with web app.
        /// You must send mail using smtp server direct.
        /// </summary>
        /// <param name="toEmail"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public enSendEmailResult SendOrderEmail(string toEmail, string token)
        {
            //if (string.IsNullOrEmpty(toEmail) ||
            //    string.IsNullOrEmpty(token))
            //    return enSendEmailResult.InvalidData;
             
            //mailItem.Subject = "Order Confirmation – Shopy";
            //mailItem.To = toEmail;  // Change this to the actual recipient's email address
            //mailItem.Body = $@"
            //   Hi,

            //   Thank you for your order! 🎉

            //   Your order has been successfully confirmed and is now being processed.

            //   You can view your order details and track its status using the link below:
            //   https://localhost:44370/Order/Track?AccessToken={token}

            //   Please keep this email for your records.

            //   If you have any questions, feel free to contact our support team.

            //   Best regards,
            //   Shopy Team
            //   "; 
            //mailItem.Send(); 
            return enSendEmailResult.Success;
        }
    }

}