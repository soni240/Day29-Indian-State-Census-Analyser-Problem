using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class CensusAnalyserException : Exception
    {
        /// <summary>
        /// This enum ExceptionType for diffrent exception which is constant
        /// </summary>
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            INVALID_FILE_TYPE,
            INCORRECT_DELIMITER,
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY
        }

        public ExceptionType eType;
        /// <summary>
        /// This Parametrized Constructor Initialize a new instance of this class.
        /// </summary>
        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.eType = exceptionType;
        }

    }
}
