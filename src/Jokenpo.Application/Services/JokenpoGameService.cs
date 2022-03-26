using Jokenpo.Application.Enums;
using Jokenpo.Application.Models;

namespace Jokenpo.Application.Services
{
    public class JokenpoGameService : IJokenpoGameService
    {
        public Task<GameResultModel> PlayAsync(EnumMoves moveOne, EnumMoves moveTwo)
        {
            var gameResult = new GameResultModel();

            if (moveOne == moveTwo)
                gameResult.SetNoWinner();
            else
            {
                switch (moveOne)
                {
                    case EnumMoves.Stone:
                        gameResult.SetWinningMove(moveTwo == EnumMoves.Paper ? moveTwo : moveOne);
                        break;
                    case EnumMoves.Paper:
                        gameResult.SetWinningMove(moveTwo == EnumMoves.Scissors ? moveTwo : moveOne);
                        break;
                    case EnumMoves.Scissors:
                        gameResult.SetWinningMove(moveTwo == EnumMoves.Stone ? moveTwo : moveOne);
                        break;
                }
            }

            return Task.FromResult(gameResult);
        }
    }
}
