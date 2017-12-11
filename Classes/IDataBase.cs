using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
          public interface IDataBase
        {
            // Qui si def i metodi che agiscono sul database insert, getall, remove

            bool InsertMonthly(Monthly monthly);

            bool InsertPaymentMethod(PaymentMethod paymentMethod);

            bool InsertCategory(Category category);

            bool InsertUser(User user);

            bool InsertTransaction(Transaction transaction);

            bool UpdateMonthly(Monthly monthly);

            bool UpdateTransaction(Transaction transaction);

            bool UpdatePaymentMethod(PaymentMethod paymentMethod);

            bool UpdateCategory(Category category);

            bool UpdateUser(User user);

            bool RemoveMonthly(string id);

            bool RemoveTransaction(string id);

            bool RemovePaymentMethod(string id);

            bool RemoveCategory(string id);

            bool RemoveUser(string id);

            IEnumerable<Monthly> GetAllMonthly();

            IEnumerable<Transaction> GetAllTransactions();

            IEnumerable<PaymentMethod> GetAllPaymentMethods();

            IEnumerable<Category> GetAllCategories();

            User GetUser(User user);

            Monthly GetMonthly(string id);

            Transaction GetTransaction(string id);

            PaymentMethod GetPaymentMethod(string id);

            Category GetCategory(string id);


      
    }
}
