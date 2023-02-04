using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Tools.Errors
{
    public class HelperError : Exception
    {
        private ErrorCode pOSITION_OUT_RANGE;

        public ErrorCode Code { get; set; }
        public string? Message { get; set; }

        public HelperError(ErrorCode errorCode, string? message = null) : base(message)
        {
            Code = errorCode;
            Message = message;
        }
    }
}
