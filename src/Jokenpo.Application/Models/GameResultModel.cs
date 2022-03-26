using Jokenpo.Application.Enums;

namespace Jokenpo.Application.Models
{
    public class GameResultModel
    {
        public bool HasWinner { get; private set; }
        public EnumMoves? WinningMove { get; private set; }

        public void SetWinningMove(EnumMoves move)
        {
            WinningMove = move;
            HasWinner = true;
        }

        public void SetNoWinner()
        {
            HasWinner = false;
            WinningMove = null;
        }
    }
}
