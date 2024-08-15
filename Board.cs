namespace Model;


    public enum PieceColor { White, Black };

    public enum PieceType {
        King, Queen, Rook, Bishop, Knight, Pawn
    }

    public class Piece {
        private PieceColor color;
        private PieceType type;

        public Piece(bool isWhite, PieceType type) {
            this.color = isWhite ? PieceColor.White : PieceColor.Black;
            this.type = type;
        }

        private static PieceType TypeFromCharacter(char c) => char.ToLower(c) switch {
            'k' => PieceType.King,
            _ => throw new ArgumentOutOfRangeException("Bad character"),
        };

    public override string ToString()
    {
        return color + " " + type;
    }



        public static Piece FromCharacter(char c) {
            var isWhite = char.IsLower(c);
            return new Piece(isWhite, PieceType.King);
        }
    }


class Board {


    private class Cell {
        private Piece piece;
        public Cell(Piece piece) {
            this.piece = piece;
        }
    }

    private Cell[,] board;

    private const string FEN_STANDARD = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    public Board() {
        board = initializeBoard(FEN_STANDARD);
        Console.WriteLine("Board initialized");
    }



    private Cell[,] initializeBoard(string fen) {
        var cells = new Cell[8,8];
        // int file, rank;
        // file, rank = 0, 0;
        // foreach(char c in fen) {
        //     if(rank >= 8) {
        //         rank = 0;
        //         file++;
        //     }
        //     if(char.IsDigit(c)) {
        //         int skip = c - '0';
        //         rank += skip;
        //     }
        //     var isWhite = char.isLower(c);
        // }
        return cells;
    }



}