using Jokenpo.Application.Enums;

namespace Jokenpo.UI.Helpers
{
    public class MoveHelper : IMoveHelper
    {
        public Task<EnumMoves> GenerateRandomMoveAsync()
        {
            var movesPossibilities = Enum.GetValues(typeof(EnumMoves)).Cast<EnumMoves>();
            int random = new Random().Next(1, movesPossibilities.Count() + 1);
            return Task.FromResult(movesPossibilities.ElementAt(random - 1));
        }
    }
}
