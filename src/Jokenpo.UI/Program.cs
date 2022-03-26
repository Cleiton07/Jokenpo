using Jokenpo.Application.Interfaces;
using Jokenpo.Application.Services;
using Jokenpo.UI.Helpers;

const int pointsToWin = 3;

int playerOnePoints = 0;
int playerTwoPoints = 0;

IMoveHelper moveHelper = new MoveHelper();
IJokenpoGameService gameService = new JokenpoGameService();

Console.WriteLine("The game is starting...");
Console.WriteLine("the game ends when one of the players gets 5 points.\n\n");
await Task.Delay(2000);
for (int round = 1; playerOnePoints < pointsToWin && playerTwoPoints < pointsToWin; round++)
{
    Console.WriteLine($"Go to round {round}.\n");
    Console.WriteLine($"-----------------------------------------");

    await Task.Delay(2000);
    Console.WriteLine("Jo...");

    await Task.Delay(2000);
    Console.WriteLine("Ken...");

    await Task.Delay(3000);
    Console.WriteLine("PO!\n");

    var playerOneMove = await moveHelper.GenerateRandomMoveAsync();
    var playerTwoMove = await moveHelper.GenerateRandomMoveAsync();

    Console.WriteLine($"Player ONE move: {playerOneMove}");
    Console.WriteLine($"Player TWO move: {playerTwoMove}\n");
    await Task.Delay(2000);

    var gameResult = await gameService.PlayAsync(playerOneMove, playerTwoMove);
    if (!gameResult.HasWinner)
        Console.WriteLine("No winner in this round!");
    else if (gameResult.WinningMove == playerOneMove)
    {
        playerOnePoints++;
        Console.WriteLine("Player ONE is the winner of this round!");
    }
    else if (gameResult.WinningMove == playerTwoMove)
    {
        playerTwoPoints++;
        Console.WriteLine("Player TWO is the winner of this round!");
    }
    await Task.Delay(1000);

    Console.WriteLine($"\nThe score is: Player One [{playerOnePoints}]  -  Player Two [{playerTwoPoints}]");
    await Task.Delay(3000);
}

Console.WriteLine($"\n\nGAME OVER! The Winner is a Player {(playerOnePoints > playerTwoPoints ? "ONE" : "TWO")}");
Console.WriteLine("\n--------------FINISH--------------");
Console.WriteLine("Press any key to exit");
_ = Console.ReadKey();