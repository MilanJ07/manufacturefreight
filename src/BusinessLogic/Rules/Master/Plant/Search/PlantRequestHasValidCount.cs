using BusinessLogic.Rules.Exceptions;
using Utilities.Constants;
using Utilities.Enums;

namespace BusinessLogic.Rules.Master.Plant
{
    public partial class PlantSearchRules
    {
        public void RequestHasValidCount()
        {
            if (!int.TryParse(this.Count, out var intCount) || intCount < 0)
            {
                throw new RuleException(
                    Messages.InvalidCount.Description,
                    Messages.InvalidCount.Element,
                    this.Count,
                    Codes.InvalidCount,
                    Category.Warning
                    );
            }

            this.PlantSearchRequestEntity.Count = intCount;
        }
    }
}
