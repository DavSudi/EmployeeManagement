using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext context;

        public FeedbackRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void AddFeedBack(Feedback feedback)
        {
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }
    }
}
