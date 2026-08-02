public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rowsSet = new HashSet<char>[9];
        HashSet<char>[] columnsSet = new HashSet<char>[9];
        HashSet<char>[]boxsSet = new HashSet<char>[9];
        for(int i =0;i<9;i++)
        {
            rowsSet[i] = new HashSet<char>();
            columnsSet[i] =new HashSet<char>();
            boxsSet[i] = new HashSet<char>();
        }
        for(int row = 0;row<9;row++)
        {
          for(int col = 0; col<9;col++)
          {
              if(board[row][col] == '.')
              continue;
              char num = board[row][col];
              int box = (row/3)*3 + col/3;
              if(rowsSet[row].Contains(num) || columnsSet[col].Contains(num) || boxsSet[box].Contains(num))
              {
                 return false;
              }

              rowsSet[row].Add(num);
              columnsSet[col].Add(num);
              boxsSet[box].Add(num);
          }
        }
        return true;
    }
}
