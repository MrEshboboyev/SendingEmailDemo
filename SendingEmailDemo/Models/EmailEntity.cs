using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SendingEmailDemo.Models
{
    public class EmailEntity
    {
        [ValidateNever]
        public string FromEmailAddress { get; set; }

        public string ToEmailAddress { get; set; }

        public string Subject { get; set; }

        public string EmailBodyMessage { get; set; }

        [ValidateNever]
        public string AttachmentURL { get; set; }
    }
}
