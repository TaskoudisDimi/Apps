using SudokuSolver.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Strategies
{
    public class SimpleMarkUpStrategy : ISudokuStrategy
    {
        private readonly SudokuMapper _sudokuMapper;


        public SimpleMarkUpStrategy(SudokuMapper sudokuMapper)
        {
            _sudokuMapper = sudokuMapper;
        }

        public int[,] Solve(int[,] sudokuBoard)
        {
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                for (var col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    if(sudokuBoard[row, col] == 0 || sudokuBoard[row, col].ToString().Length > 1)
                    {
                        var possibilitiesInRowAndCol = GetPossibilitiesInRowAndCol(sudokuBoard, row, col);
                        var possibilitiesInBlock = GetPossibilitiesInBlock(sudokuBoard, row, col);
                        sudokuBoard[row, col] = GetPossibilityIntersection(possibilitiesInRowAndCol, possibilitiesInBlock);

                    }
                }
                
            }
            return sudokuBoard;
        }

        private int GetPossibilityIntersection(int possibilitiesInRowAndCol, int possibilitiesInBlock)
        {
            var possibilitiesInRowAndColCharArray = possibilitiesInRowAndCol.ToString().ToCharArray();
            var possibilitiesInBlockCharArray = possibilitiesInBlock.ToString().ToCharArray();
            var possibilitiesSubset = possibilitiesInRowAndColCharArray.Intersect(possibilitiesInBlockCharArray);
            return Convert.ToInt32(string.Join(string.Empty, possibilitiesSubset));
        }

        private int GetPossibilitiesInBlock(int[,] sudokuBoard, int givenRow, int givenCol)
        {
            int[] possibilities = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sudokuMap = _sudokuMapper.Find(givenRow, givenCol);

            for (int row = sudokuMap.SudokuRow; row <= sudokuMap.SudokuRow + 2; row++)
            {
                for (var col = sudokuMap.SudokuCol; col <= sudokuMap.SudokuCol + 2; col++)
                {
                    if (IsValidSingle(sudokuBoard[row, col]))
                    {
                        possibilities[sudokuBoard[row, col] - 1] = 0;
                    }
                }
            }
            return Convert.ToInt32(String.Join(String.Empty, possibilities.Select(x => x).Where(x => x != 0)));
        }

        private int GetPossibilitiesInRowAndCol(int[,] sudokuBoard, int givenRow, int givenCol)
        {
            int[] possibilities = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            //Κάνω 0 το στοιχείο στον πίνακα πιθανοτητων σε περίπτωση που το κελί εχει τιμή
            for (int col = 0; col < 0; col++)
            {
                if(IsValidSingle(sudokuBoard[givenRow, col]))
                {
                    possibilities[sudokuBoard[givenRow, col] - 1] = 0;  
                }
            }

            for (int row = 0; row < 0; row++)
            {
                if (IsValidSingle(sudokuBoard[row, givenCol]))
                {
                    possibilities[sudokuBoard[row, givenCol] - 1] = 0;
                }
            }

            //Επιστρέφει τις τιμές του πίνακα possibilities που δεν είναι μηδέν
            return Convert.ToInt32(String.Join(string.Empty, possibilities.Select(x => x).Where(x => x != 0)));
        }
      
        private bool IsValidSingle(int cellDigit)
        {
            return cellDigit != 0 && cellDigit.ToString().Length == 1;
        }
    }
}
