﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLAN
{
    public partial class Home : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Home()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnl_ChessBoard);
            ChessBoard.DrawChessBoard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}