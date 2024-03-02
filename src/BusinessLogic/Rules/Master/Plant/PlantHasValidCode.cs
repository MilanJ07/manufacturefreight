using BusinessLogic.Rules.Exceptions;
using DataAccess.Domain.Masters;
using Utilities.Constants;

namespace BusinessLogic.Rules.Master.Plant
{
    public partial class PlantCreateRules
    {
        public void HasValidCode()
        {
            if (this.PlantEntity.Name == "Test")
            {
                throw new RuleException(
                    Messages.HasInvalidName.Description,
                    Messages.HasInvalidName.Element,
                    PlantEntity.Name,
                    Codes.EntityNotFound
                    );
            }
        }
    }
}
