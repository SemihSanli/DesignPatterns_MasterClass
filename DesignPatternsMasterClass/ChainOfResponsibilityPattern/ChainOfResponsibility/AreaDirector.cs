using ChainOfResponsibilityPattern.DAL.Context;
using ChainOfResponsibilityPattern.DAL.Entities;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProccessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.FullName = request.FullName;
                customerProcess.EmployeeName = "Bölge Müdürü  - Murat Yücedağ";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.FullName = request.FullName;
                customerProcess.EmployeeName = "Bölge Müdürü  - Murat Yücedağ";
                customerProcess.Description = "Para Çekme İşlemi Onaylanmadı,Çünkü Talep Ettiği Tutar Limitlerin Üzerinde";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
