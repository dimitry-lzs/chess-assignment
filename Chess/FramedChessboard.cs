using System.Windows.Forms;

namespace Chess
{
    public partial class FramedChessboard : UserControl
    {
        public ChessBoard chessBoard
        {
            get
            {
                return this.board;
            }
        }

        public FramedChessboard()
        {
            InitializeComponent();
        }
    }
}
