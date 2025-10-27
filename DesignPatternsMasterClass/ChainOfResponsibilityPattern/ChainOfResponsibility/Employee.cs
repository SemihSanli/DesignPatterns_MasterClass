using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextAppRover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }
        public abstract void ProcessRequest(CustomerProccessViewModel request);
    }
}
