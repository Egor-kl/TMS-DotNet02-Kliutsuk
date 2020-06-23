﻿using System.Threading.Tasks;

namespace EasyMeeting.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
