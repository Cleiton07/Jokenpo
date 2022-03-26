using Jokenpo.Application.Enums;

namespace Jokenpo.UI.Helpers
{
    public interface IMoveHelper
    {
        Task<EnumMoves> GenerateRandomMoveAsync();
    }
}
