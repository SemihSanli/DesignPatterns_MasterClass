using ChainOfResponsibilityPattern.DAL.Context;
using ChainOfResponsibilityPattern.DAL.Entities;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public class Treasure : Employee
    {
        public override void ProcessRequest(CustomerProccessViewModel request)
        {
           Context context = new Context();
            if (request.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.FullName = request.FullName;
                customerProcess.EmployeeName = "Veznedar - Emre Durak";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=request.Amount.ToString();
                customerProcess.FullName = request.FullName;
                customerProcess.EmployeeName = "Veznedar - Emre Durak";
                customerProcess.Description = "Para Çekme İşlemi Onaylanmadı,Çünkü Talep Ettiği Tutar Limitlerin Üzerinde";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
