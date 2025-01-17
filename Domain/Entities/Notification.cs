using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notification
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
    }
}
