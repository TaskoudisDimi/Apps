using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    public class SudokuFileReader
    {

        public int[,] ReadFile (string fileName)
        {
            int[,] sudokuBoard = new int[9, 9];
            try
            {
                var sudokuBoardLines = File.ReadAllLines(fileName);
                int row = 0;
                foreach(var sudokuBoardLine in sudokuBoardLines)
                {
                    //To |9|| | |2|3|2|7|8| | με το split θα επιστρέψει "" "9" " " " " "2" κλπ ""
                    //Για αυτό το πρώτο και το τελευταίο στοιχείο του πίνακα δεν τα κρατάω
                    string[] sudokuBoardLinesElemets = sudokuBoardLine.Split("|").Take(9).ToArray();

                    int col = 0;
                    foreach(var sudokuBoardLinesElement in sudokuBoardLinesElemets)
                    {
                        sudokuBoard[row, col] = sudokuBoardLinesElement.Equals(" ") ? 0 : Convert.ToInt16(sudokuBoardLinesElement);
                        col++;
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something get wrong with reading file", ex.Message);
            }
            return sudokuBoard;
        }


    }
}
