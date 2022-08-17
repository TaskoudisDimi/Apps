using SudokuSolver.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Strategies
{
    public class SudokuSolverEngine
    {

        private readonly SudokuBoardStateManager _sudokuBoardStateManager;
        private readonly SudokuMapper _sudokuMapper;

        public SudokuSolverEngine(SudokuBoardStateManager sudokuBoardStateManager, SudokuMapper sudokuMapper)
        {
            _sudokuBoardStateManager = sudokuBoardStateManager;
            _sudokuMapper = sudokuMapper;
        }

        public bool Solve(int[,] sudokuBoard)
        {
            List<ISudokuStrategy> strategies = new List<ISudokuStrategy>();
            {

            };

            var currentState = _sudokuBoardStateManager.Generate(sudokuBoard);
            var nextState = _sudokuBoardStateManager.Generate(strategies.First().Solve(sudokuBoard));

            //Τελειώνει είτε όταν λυθεί το sudoku είτε δεν μπορεί να βρει κάποια λύση
            while (!_sudokuBoardStateManager.isSolved(sudokuBoard) && currentState != nextState)
            {
                currentState = nextState;
                foreach(var strategy in strategies)
                {
                    nextState = _sudokuBoardStateManager.Generate(strategy.Solve(sudokuBoard)); 
                }
            }

            return _sudokuBoardStateManager.isSolved(sudokuBoard);
        }


    }
}
