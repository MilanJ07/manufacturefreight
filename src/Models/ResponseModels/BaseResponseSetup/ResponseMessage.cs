using Utilities.Contract;
using Utilities.MessageStatus;

namespace Models.ResponseModels.BaseResponseSetup
{
    public class ResponseMessage : IResponseMessage
    {
        public MessageStatusModel? MessageStatus { get; set; }
    }
}
