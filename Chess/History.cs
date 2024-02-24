using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess.Models;

namespace Chess
{
    public partial class History : Form
    {
        Db dataBase;
        List<Game> games;
        public History()
        {
            InitializeComponent();
            this.dataBase = new Db();
            this.games = this.dataBase.FetchGames();
            this.gamesHistoryTable.DataSource = this.games;
        }
    }
}
