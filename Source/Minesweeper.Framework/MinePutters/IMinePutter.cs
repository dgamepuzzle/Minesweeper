using System;

namespace Minesweeper.Framework.MinePutters
{
    public interface IMinePutter
    {
        MinePutterDifficulty Difficulty { get; }
        int PutMines(MineField mineField, int clickCellX, int clickCellY, Random random);
    }
}