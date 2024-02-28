using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Contract;
using Utilities.MessageStatus;

namespace Models.ResponseModels
{
    public class PlantResponseModel : IResponseMessage
    {
        public string PlantId { get; set; }
        public MessageStatusModel? MessageStatus { get; set; }
    }
}