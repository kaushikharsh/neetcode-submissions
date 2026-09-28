public class Solution {
    public bool IsValidSudoku(char[][] board) {
        if(IsValueDuplicatesInRowsAndColumns(board)){
            Console.WriteLine("second-check");
            return false;
        }
        if(IsSubMatrixsValueDuplicate(board)){
            Console.WriteLine("third-check");
            return false;
        }
        return true;
    }

    private bool IsValueDuplicatesInRowsAndColumns(char [][] board){
        for(int i=0;i<board.Length;i++){
            HashSet<char> colset = new HashSet<char>();
            HashSet<char> rowset = new HashSet<char>();
            for(int j=0;j<board.Length;j++){
                if(board[j][i] != '.'){
                    if(colset.Contains(board[j][i])){
                        return true;
                    }
                    colset.Add(board[j][i]);
                }
                if(board[i][j] != '.'){
                    if(rowset.Contains(board[i][j])){
                        return true;
                    }
                    rowset.Add(board[i][j]);
                }
            }
        }
        return false;
    }

    private bool IsSubMatrixsValueDuplicate(char [][] board){
        int row1 = 0;
        int col1 = 0; 
        int row2 = row1 + 3;
        int col2 = col1 + 3;

        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                if(IsDuplicateUnderRange(board, row1, row2, col1, col2)){
                    return true;
                }
                col1 = col2;
                col2 = col1 + 3;
            }
            row1 = row2;
            row2 = row1 + 3;
            col1 = 0;
            col2 = col1 + 3;
        }
        return false;
    }

    private bool IsDuplicateUnderRange(char [][] board,int row1, int row2, int col1, int col2){
        HashSet<char> set = new HashSet<char>();
        for(int i=row1;i<row2;i++){
            for(int j=col1;j<col2;j++){
                if(board[i][j] != '.'){
                    if(set.Contains(board[i][j])){
                        return true;
                    }
                    set.Add(board[i][j]);
                }
            }
        }
        return false;
    }
}
