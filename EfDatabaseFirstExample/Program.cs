using EfDatabaseFirstExample.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDatabaseFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new MyDatabaseContext())
            {
                dbContext.tblExceptionLogs.Add(new tblExceptionLog
                {
                    Created = DateTime.Now,
                    ServerName = "Sample Server Name",
                    Message = "Sample Message",
                    ClassName = "Sample Class Name",
                    MethodName = "Sample Method Name",
                    StackTrace = "Long Stack Trace with lots of lines",
                    InnerException = "Might be null, might not be null",
                    AdditionalInfo = "Should give some meaningful information about the exception"
                });

                dbContext.SaveChanges();
            }


        }
    }
}
