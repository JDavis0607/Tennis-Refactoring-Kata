using gv = Tennis.GlobalVariables;

namespace Tennis
{
    class TennisGame : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else if (playerName == "player2")
                m_score2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (m_score1 == m_score2)
            {
                switch (m_score1)
                {
                    case 0:
                        score = gv.score[0];
                        break;
                    case 1:
                        score = gv.score[1];
                        break;
                    case 2:
                        score = gv.score[2];
                        break;
                    default:
                        score = gv.score[3];
                        break;
                }
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;

                if (minusResult == 1) score = gv.score[18];
                else if (minusResult == -1) score = gv.score[19];
                else if (minusResult >= 2) score = gv.score[16];
                else score = gv.score[17];
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = m_score1;
                    else
                    {
                        score += "-";
                        tempScore = m_score2;
                    }

                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

