using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class NotificationDto
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
    }

    // NotificationCreateDto.cs
    public class NotificationCreateDto
    {
        public Guid UserId { get; set; }
        public string Message { get; set; }
    }

    // UpdateNotificationDto.cs
    public class UpdateNotificationDto
    {
        public Guid NotificationId { get; set; }
        public string Message { get; set; }
    }
}

