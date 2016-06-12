using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAcademiProject
{
    class ExceptionHandling : IExceptionHandle
    {
        int catchedExeptionsCounter;
        List<string> catchedExeptionsMessages;

        public ExceptionHandling()
        {
            this.catchedExeptionsCounter = 0;
            this.catchedExeptionsMessages = new List<string>();
        }

        public void WhichException(Exception catchedException)
        {
            this.catchedExeptionsCounter++;
            this.catchedExeptionsMessages.Add(catchedException.Message);
        }
    }
}
