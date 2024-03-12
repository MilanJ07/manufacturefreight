using BusinessLogic.Rules.Exceptions;
using Utilities.Constants;
using Utilities.Enums;

namespace BusinessLogic.Rules.Master.Plant
{
    public partial class PlantSearchRules
    {
        public void RequestHasValidOffset()
        {
            if(!int.TryParse(this.Offset, out var intoffSet) || intoffSet < 0)
            {
                throw new RuleException(
                    Messages.InvalidOffset.Description,
                    Messages.InvalidOffset.Element,
                    this.Count,
                    Codes.InvalidOffset,
                    Category.Warning
                    );
            }

            this.PlantSearchRequestEntity.Offset = intoffSet;
        }
    }
}
