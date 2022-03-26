using Jokenpo.Application.Enums;
using Jokenpo.Application.Models;

namespace Jokenpo.Application.Interfaces
{
    public interface IJokenpoGameService
    {
        Task<GameResultModel> PlayAsync(EnumMoves moveOne, EnumMoves moveTwo);
    }
}
